using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;

namespace OpenGL_Lab_4
{
    public partial class RenderControl : OpenGL
    {
        private float size = 3.0f;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }

        private float margin = 0.2f;
        private float step = 0.5f;

        private float _heigth;
        private float _width;

        private int drawCurve = 0;

        private float radius = 2f;
        
        private float[] point1;
        private float[] point2;
        private bool isDrawLine = false;

        private float a = 2f;
        private float b = 2f;

        public RenderControl()
        {
            InitializeComponent();
        }

        public void SetDrawCurve(int indexCurve)
        {
            drawCurve = indexCurve;

            Refresh();
        }

        private void UpdateHeightWidth()
        {
            _heigth = (-Ymin) + Ymax;
            _width = (-Xmin) + Xmax;
        }

        public void SetPointsLine(float[] _point1, float[] _point2)
        {
            point1 = _point1;
            point2 = _point2;

            isDrawLine = true;

            Refresh();
        }

        public void SetRadius(float _radius)
        {
            radius = _radius;

            Refresh();
        }

        public void SetHypA(float _a)
        {
            a = _a;

            Refresh();
        }

        public void SetHypB(float _b)
        {
            b = _b;

            Refresh();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(Xmin - margin, Xmax + margin, Ymin - margin, Ymax + margin, -1, 1);
            
            UpdateHeightWidth();

            DrawGrid();
            DrawAxis();
            DrawTextAxis();

            switch(drawCurve)
            {
                case 0:
                    DrawCircle();
                    if(isDrawLine) DrawLine();
                    break;

                case 1:
                    DrawHyperbole();
                    break;
            }
        }

        private void DrawGrid()
        {
            glLineWidth(1);

            glBegin(GL_LINES);
            glColor3d(60f / 255f, 60f / 255f, 60f / 255f);

            float _start = step * ((Ymax / step) % 1);

            // draw horizontal lines
            for (float row = _start; row < _heigth; row += step)
            {
                glVertex2d(Xmin, Ymax - row);
                glVertex2d(Xmax, Ymax - row);
            }

            _start = step * (((-Xmin) / step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < _width; colum += step)
            {
                glVertex2d(Xmin + colum, Ymax);
                glVertex2d(Xmin + colum, Ymin);
            }

            // draw borders
            glVertex2d(Xmin, Ymax);
            glVertex2d(Xmax, Ymax);

            glVertex2d(Xmin, Ymin);
            glVertex2d(Xmax, Ymin);

            glVertex2d(Xmax, Ymax);
            glVertex2d(Xmax, Ymin);

            glVertex2d(Xmin, Ymax);
            glVertex2d(Xmin, Ymin);

            glEnd();
        }

        private void DrawAxis()
        {
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(200f / 255f, 200f / 255f, 200f / 255f);

            // X axis
            glVertex2d(Xmax, 0f);
            glVertex2d(Xmin, 0f);

            float _start = step * (((-Xmin) / step) % 1);

            // draw vertical lines
            for (float colum = _start; colum < _width + step; colum += step)
            {
                glVertex2d(Xmin + colum, 0);
                glVertex2d(Xmin + colum, -step / 3);
            }

            // Y axis
            glVertex2d(0f, Ymax);
            glVertex2d(0f, Ymin);

            _start = step * ((Ymax / step) % 1);

            // draw horizontal lines
            for (float row = _start; row < _heigth + step; row += step)
            {
                glVertex2d(-step / 3, Ymax - row);
                glVertex2d(0, Ymax - row);
            }

            glLineWidth(1);
            glEnd();
        }

        private void DrawTextAxis()
        {
            glColor3d(200f / 255f, 200f / 255f, 200f / 255f);

            // X axis
            float _start = step * (((-Xmin) / step) % 1);
            for (float colum = _start; colum < _width + step; colum += step)
            {
                if (Xmin + colum >= 0.1f || Xmin + colum <= -0.1f)
                {
                    DrawText((Xmin + colum).ToString("F1"), Xmin + colum, -step / 2);
                }
            }


            // Y axis
            _start = step * ((Ymax / step) % 1);
            for (float row = _start; row < _heigth + step; row += step)
            {
                if (Ymax - row >= 0.1f || Ymax - row <= -0.1f)
                {
                    DrawText((Ymax - row).ToString("F1"), -step / 2, Ymax - row);
                }
            }

            // 0
            DrawText((0).ToString(), -step / 2.5f, -step / 2.5f);
        }

        private void DrawCircle()
        {
            float x = 0;
            float y = 0;

            float _x = 0;
            float _y = 0;

            float c = 0.001f;

            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for(x = -radius; x < radius + c; x += c)
            {
                x = MathF.Round(x, 3);
                y = MathF.Sqrt((radius*radius) - (x*x));

                if (x > -radius)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    glVertex2d(_x, -_y);
                    glVertex2d(x, -y);

                    if(isDrawLine)
                    {
                        DrawPoint([_x, _y], [x, y]);
                        DrawPoint([_x, -_y], [x, -y]);
                    }
                }

                _y = y;
                _x = x;
            }

            glEnd();
        }

        private void DrawLine()
        {
            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(255f / 255f, 128f / 255f, 0f / 255f);

            glVertex2d(point1[0], point1[1]);
            glVertex2d(point2[0], point2[1]);

            glEnd();
        }

        private void DrawPoint(float[] _point1, float[] _point2)
        {
            // circle
            float x1 = _point1[0];
            float y1 = _point1[1];
            float x2 = _point2[0];
            float y2 = _point2[1];

            // line
            float x3 = point1[0];
            float y3 = point1[1];
            float x4 = point2[0];
            float y4 = point2[1];

            // point
            float x0 = 0;
            float y0 = 0;

            float D = (x2 - x1) * (y4 - y3) - (y2 - y1) * (x4 - x3);

            float t1 = 0;
            float t2 = 0;

            if (D != 0)
            {
                t1 = ((x3 - x1) * (y4 - y3) - (y3 - y1) * (x4 - x3)) / D;
                t2 = ((x3 - x1) * (y2 - y1) - (y3 - y1) * (x2 - x1)) / D;

                if ((t1 >= 0 && t1 <= 1) && (t2 >= 0 && t2 <= 1))
                {
                    x0 = (x2 - x1) * t1 + x1;
                    y0 = (y2 - y1) * t1 + y1;

                    // end draw function
                    glEnd();

                    glPointSize(20);

                    glBegin(GL_POINTS);
                    glColor3d(255f / 255f, 255f / 255f, 0f / 255f);

                    glVertex2d(x0, y0);

                    glEnd();

                    // continue draw function
                    glBegin(GL_LINES);
                    glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
                }
            }
        }

        private void DrawHyperbole()
        {
            float x = 0, y = 0;
            float _x = 0, _y = 0;

            float c = 0.001f;

            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for(x = Xmin; x <= Xmax; x += c)
            {
                x = MathF.Round(x, 3);
                y = MathF.Sqrt((((x*x) / (a*a)) - 1) * (b*b));

                if(y > Ymax || y < Ymin)
                {
                    _x = x;
                    _y = y;

                    continue;
                }

                if(x > Xmin + c)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    glVertex2d(_x, -_y);
                    glVertex2d(x, -y);
                }

                _x = x;
                _y = y;
            }

            glEnd();
        }
    }
}

