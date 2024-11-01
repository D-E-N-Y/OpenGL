using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace OpenGL_Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size = 10.5f;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }

        private float angleX = 10.0f;
        private float angleY = 20.0f;

        private float gridStep = 1f;
        private float gridMerge = 0.5f;

        private float _heigth;
        private float _width;

        private float segment = 15.0f;

        private float sphereRadius = 3.5f;

        private float coneHeight = 5.0f;
        private float coneRadius = 2.5f;
        private float coneSlice = 2.0f;

        private float innerRadius = 4.5f;
        private float outerRadius = 1.5f;
        private float startAngle = 180f;
        private float sweepAngle = 90f;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            glOrtho(Xmin, Xmax, Ymin, Ymax, Zmin, Zmax);

            glRotated(angleX, 1, 0, 0);
            glRotated(angleY, 0, 1, 0);

            _heigth = size * 2;
            _width = size * 2;

            DrawGrid();
            DrawAxis();
            DrawTextAxis();
            DrawSphere();
            DrawConus();
            DrawPartialDisk();
        }

        private void DrawPartialDisk()
        {
            float x0 = 4.5f;
            float y0 = -3.5f;
            float z0 = -4.5f;
            
            var id = gluNewQuadric();
            gluQuadricDrawStyle(id, GLU_LINE);

            glPushMatrix();
            glTranslatef(x0, y0, z0);

            gluPartialDisk(id, size / innerRadius, size / outerRadius, (int)segment, 1, startAngle, sweepAngle);

            glPopMatrix();
            gluDeleteQuadric(id);
        }

        private void DrawConus()
        {
            float x0 = 3.0f;
            float y0 = 2.0f;
            float z0 = 2.5f;
            
            float slice = coneHeight - coneSlice;

            float upsilonStep = slice / segment;
            float tetaStep = 2 * float.Pi / segment;

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (float upsilon = 0; upsilon < coneHeight; upsilon += upsilonStep)
            {
                for (float teta = 0; teta < 2 * float.Pi; teta += tetaStep)
                {
                    float x1 = x0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Cos(teta);
                    float y1 = y0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Sin(teta);
                    float z1 = z0 + upsilon;

                    float x2 = x0 + (coneHeight - (upsilon + upsilonStep)) / coneHeight * coneRadius * MathF.Cos(teta);
                    float y2 = y0 + (coneHeight - (upsilon + upsilonStep)) / coneHeight * coneRadius * MathF.Sin(teta);
                    float z2 = z0 + upsilon + upsilonStep;

                    float x3 = x0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Cos(teta + tetaStep);
                    float y3 = y0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Sin(teta + tetaStep);
                    float z3 = z0 + upsilon;

                    // base bottom
                    glVertex3d(x1, y1, z0);
                    glVertex3d(x2, y2, z0);

                    glVertex3d(x1, y1, z0);
                    glVertex3d(x3, y3, z0);

                    if (z1 < slice + z0 || z2 < slice + z0 || z3 < slice + z0)
                    {
                        glVertex3d(x1, y1, z1);
                        glVertex3d(x2, y2, z2);

                        glVertex3d(x1, y1, z1);
                        glVertex3d(x3, y3, z3);
                    }
                    else if (z1 > slice + z0 || z2 > slice + z0 || z3 > slice + z0)
                    {
                        // base top
                        glVertex3d(x1, y1, slice + z0);
                        glVertex3d(x2, y2, slice + z0);

                        glVertex3d(x1, y1, slice + z0);
                        glVertex3d(x3, y3, slice + z0);
                    }
                }
            }

            glEnd();
        }

        private void DrawSphere()
        {
            float stepTeta = float.Pi / segment;
            float stepPhi = 2 * float.Pi / segment;

            float x0 = -4.5f;
            float y0 = -3.5f;
            float z0 = 3.5f;

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (float teta = 0.0f; teta < float.Pi; teta += stepTeta)
            {
                for(float phi = 0.0f; phi < 2 * float.Pi; phi += stepPhi)
                {
                    float x1 = x0 + sphereRadius * MathF.Sin(teta) * MathF.Cos(phi);
                    float y1 = y0 + sphereRadius * MathF.Sin(teta) * MathF.Sin(phi);
                    float z1 = z0 + sphereRadius * MathF.Cos(teta);

                    float x2 = x0 + sphereRadius * MathF.Sin(teta) * MathF.Cos(phi + stepPhi);
                    float y2 = y0 + sphereRadius * MathF.Sin(teta) * MathF.Sin(phi + stepPhi);
                    float z2 = z0 + sphereRadius * MathF.Cos(teta);

                    float x3 = x0 + sphereRadius * MathF.Sin(teta + stepTeta) * MathF.Cos(phi);
                    float y3 = y0 + sphereRadius * MathF.Sin(teta + stepTeta) * MathF.Sin(phi);
                    float z3 = z0 + sphereRadius * MathF.Cos(teta + stepTeta);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x2, y2, z2);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x3, y3, z3);
                }
            }

            glEnd();
        }

        private void DrawAxis()
        {
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(255f / 255f, 255f / 255f, 255f / 255f);

            // X axis
            glVertex3d(-size + gridMerge, 0.0f, 0.0f);
            glVertex3d(size - gridMerge, 0.0f, 0.0f);

            float _start = gridStep * (((-size + gridMerge) / gridStep) % 1);

            // draw lines
            for (float colum = _start; colum < _width - gridMerge; colum += gridStep)
            {
                glVertex3d(-size + gridMerge + colum, 0f, 0f);
                glVertex3d(-size + gridMerge + colum, -gridStep / 3, 0f);
            }

            // Y axis
            glVertex3d(0.0f, -size + gridMerge, 0.0f);
            glVertex3d(0.0f, size - gridMerge, 0.0f);

            _start = gridStep * (((size - gridMerge) / gridStep) % 1);

            // draw lines
            for (float row = _start; row < _heigth - gridMerge; row += gridStep)
            {
                glVertex3d(-gridStep / 3, size - gridMerge - row, 0f);
                glVertex3d(0f, size - gridMerge - row, 0f);
            }

            // Z axis
            glVertex3d(0.0f, 0.0f, -size + gridMerge);
            glVertex3d(0.0f, 0.0f, size - gridMerge);

            _start = gridStep * (((size - gridMerge) / gridStep) % 1);

            // draw lines
            for (float row = _start; row < _heigth - gridMerge; row += gridStep)
            {
                glVertex3d(-gridStep / 3, 0f, size - gridMerge - row);
                glVertex3d(0f, 0f, size - gridMerge - row);
            }

            glEnd();
        }

        private void DrawTextAxis()
        {
            // draw text axis
            DrawText("+X", size, 0, 0);
            DrawText("+Y", 0, size, 0);
            DrawText("+Z", 0, 0, size);

            glColor3d(200f / 255f, 200f / 255f, 200f / 255f);

            // Z axis
            float _start = gridStep * (((-size) / gridStep) % 1);
            for (float colum = _start + gridStep; colum < _width; colum += gridStep)
            {
                if (-size + colum >= 0.1f || -size + colum <= -0.1f)
                {
                    DrawText((-size + colum).ToString("F1"), 0f, -gridStep / 2, -size + colum);
                }
            }

            // Y axis
            _start = gridStep * ((size / gridStep) % 1);
            for (float row = _start; row < _heigth; row += gridStep)
            {
                if (size - row >= 0.1f || size - row <= -0.1f)
                {
                    DrawText((size - row).ToString("F1"), -gridStep / 2, size - row, 0f);
                }
            }

            // X axis
            _start = gridStep * ((size / gridStep) % 1);
            for (float row = _start; row < _heigth; row += gridStep)
            {
                if (size - row >= 0.1f || size - row <= -0.1f)
                {
                    DrawText((size - row).ToString("F1"), size - row, -gridStep / 2, 0f);
                }
            }

            // 0
            DrawText((0).ToString(), -gridStep / 2.5f, -gridStep / 2.5f);

        }

        private void DrawGrid()
        {
            glLineWidth(1);

            glBegin(GL_LINES);
            glColor3d(60f / 255f, 60f / 255f, 60f / 255f);

            float _start = gridStep * ((size / gridStep) % 1) + gridMerge;

            // draw Y lines
            for (float row = _start; row < _heigth - gridMerge * 2; row += gridStep)
            {
                glVertex3d(0.0f, size - row - gridMerge, size - gridMerge);
                glVertex3d(0.0f, size - row - gridMerge, -size + gridMerge);
            }

            _start = gridStep * ((size / gridStep) % 1) + gridMerge;

            // draw Z lines
            for (float colum = _start; colum < _width - gridMerge * 2; colum += gridStep)
            {
                glVertex3d(0.0f, -size + gridMerge, size - colum - gridMerge);
                glVertex3d(0.0f, size - gridMerge, size - colum - gridMerge);
            }

            glEnd();

        }

        private bool mouseFlag = false;
        private Point mouseStart;

        private void OnMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseFlag = e.Button == MouseButtons.Left;
            mouseStart = e.Location;
        }

        private void OnMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(mouseFlag)
                mouseFlag = !(e.Button == MouseButtons.Left);
        }

        private void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(mouseFlag)
            {
                Point current = e.Location;
                angleX += (current.Y - mouseStart.Y) / 2.0f;
                angleY += (current.X - mouseStart.X) / 2.0f;
                mouseStart = current;
                Invalidate();
            }
        }
    }
}

