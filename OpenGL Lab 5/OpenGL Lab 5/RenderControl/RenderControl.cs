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

namespace OpenGL_Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size = 7.5f;
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
            //DrawSphere();
            //DrawConus();
            //DrawPartialDisk();
        }

        private void DrawPartialDisk()
        {
            var id = gluNewQuadric();
            gluQuadricDrawStyle(id, GLU_LINE);
            gluPartialDisk(id, size / 4.5f, size / 1.5f, 15, 1, 180f, 90f);
            gluDeleteQuadric(id);
        }

        private void DrawConus()
        {
            float h = 1f;
            float c = 0f;

            float slice = h - c;

            float r = 0.5f;

            float segment = 15.0f;

            float upsilonStep = slice / segment;
            float tetaStep = 2 * float.Pi / segment;

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (float upsilon = 0; upsilon < h; upsilon += upsilonStep)
            {
                for (float teta = 0; teta < 2 * float.Pi; teta += tetaStep)
                {
                    float x1 = (h - upsilon) / h * r * MathF.Cos(teta);
                    float y1 = (h - upsilon) / h * r * MathF.Sin(teta);
                    float z1 = upsilon;

                    float x2 = (h - (upsilon + upsilonStep)) / h * r * MathF.Cos(teta);
                    float y2 = (h - (upsilon + upsilonStep)) / h * r * MathF.Sin(teta);
                    float z2 = upsilon + upsilonStep;

                    float x3 = (h - upsilon) / h * r * MathF.Cos(teta + tetaStep);
                    float y3 = (h - upsilon) / h * r * MathF.Sin(teta + tetaStep);
                    float z3 = upsilon;

                    // base bottom
                    glVertex3d(x1, y1, 0);
                    glVertex3d(x2, y2, 0);

                    glVertex3d(x1, y1, 0);
                    glVertex3d(x3, y3, 0);

                    if (z1 < slice || z2 < slice || z3 < slice)
                    {
                        glVertex3d(x1, y1, z1);
                        glVertex3d(x2, y2, z2);

                        glVertex3d(x1, y1, z1);
                        glVertex3d(x3, y3, z3);
                    }
                    else if (z1 > slice || z2 > slice || z3 > slice)
                    {
                        // base top
                        glVertex3d(x1, y1, slice);
                        glVertex3d(x2, y2, slice);

                        glVertex3d(x1, y1, slice);
                        glVertex3d(x3, y3, slice);
                    }
                }
            }

            glEnd();
        }

        private void DrawSphere()
        {
            float radius = 0.5f;
            float segment = 15.0f;
            
            float stepTeta = float.Pi / segment;
            float stepPhi = 2 * float.Pi / segment;

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (float teta = 0.0f; teta < float.Pi; teta += stepTeta)
            {
                for(float phi = 0.0f; phi < 2 * float.Pi; phi += stepPhi)
                {
                    float x1 = radius * MathF.Sin(teta) * MathF.Cos(phi);
                    float y1 = radius * MathF.Sin(teta) * MathF.Sin(phi);
                    float z1 = radius * MathF.Cos(teta);

                    float x2 = radius * MathF.Sin(teta) * MathF.Cos(phi + stepPhi);
                    float y2 = radius * MathF.Sin(teta) * MathF.Sin(phi + stepPhi);
                    float z2 = radius * MathF.Cos(teta);

                    float x3 = radius * MathF.Sin(teta + stepTeta) * MathF.Cos(phi);
                    float y3 = radius * MathF.Sin(teta + stepTeta) * MathF.Sin(phi);
                    float z3 = radius * MathF.Cos(teta + stepTeta);

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

