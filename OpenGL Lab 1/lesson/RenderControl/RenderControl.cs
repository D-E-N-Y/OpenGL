using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace lesson
{
    public delegate void OutText(string s, double x, double y, double z = 0);
    

    public partial class RenderControl : OpenGL
    {
        int min_x = -1, max_x = 8;
        int min_y = -2, max_y = 2;

        Draw draw;

        public static OutText OutText { get; set; }
        
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(min_x - 2, max_x + 2, min_y - 2, max_y + 2, -1, 1);

            draw.Drawing();

            DrawText("X1", min_x, min_y - 1.5);
            DrawText("X2", max_x, min_y - 1.5);

            DrawText("Y1", min_x - 1.5, min_y);
            DrawText("Y2", min_x - 1.5, max_y);
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            draw = new Draw(min_x, max_x, min_y, max_y);
        }
    }
}

