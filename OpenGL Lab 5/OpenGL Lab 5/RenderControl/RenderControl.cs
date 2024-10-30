using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace OpenGL_Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size = 1.1f;
        private float AspectRatio { get => (float) Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }
        
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

            glBegin(GL_LINES);

            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(1.0f, 0.0f, 0.0f);

            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(0.0f, 1.0f, 0.0f);

            glVertex3d(0.0f, 0.0f, 0.0f);
            glVertex3d(0.0f, 0.0f, 1.0f);

            glEnd();
        }
    }
}

