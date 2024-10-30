using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace OpenGL_Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size = 1.1f;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }

        private float angleX = 10.0f;
        private float angleY = 20.0f;

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

            DrawAxis();
        }

        private void DrawAxis()
        {
            glBegin(GL_LINES);
            
            // X axis
            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(1.0f, 0.0f, 0.0f);

            // Y axis
            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(0.0f, 1.0f, 0.0f);

            // Z axis
            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(0.0f, 0.0f, 1.0f);

            glEnd();

            // draw text axis
            DrawText("+X", 1, 0, 0);
            DrawText("+Y", 0, 1, 0);
            DrawText("+Z", 0, 0, 1);
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

