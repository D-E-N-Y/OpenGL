using OpenGL_Lab_3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenGL_Lab_3.OpenGL;

namespace lesson
{
    public class Draw
    {
        protected float Xmin, Xmax;
        protected float Ymin, Ymax;

        protected float margin;
        protected float step;

        protected float _heigth;
        protected float _width;

        public Draw(DrawConfig config)
        {
            Xmin = config.Xmin;
            Xmax = config.Xmax;
            Ymin = config.Ymin;
            Ymax = config.Ymax;

            margin = config.margin;
            step = config.step;

            _heigth = config.height;
            _width = config.width;
        }

        public void DrawCoordinateSystem()
        {
            DrawGrid();
            DrawAxis();
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
                if(Xmin + colum >= Xmin && Xmin + colum <= Xmax)
                {
                    glVertex2d(Xmin + colum, 0);
                    glVertex2d(Xmin + colum, -step / 5);
                }
            }

            // Y axis
            glVertex2d(0f, Ymax);
            glVertex2d(0f, Ymin);

            _start = step * ((Ymax / step) % 1);

            // draw horizontal lines
            for (float row = _start; row < _heigth + step; row += step)
            {
                if(Ymax - row <= Ymax && Ymax - row >= Ymin)
                {
                    glVertex2d(-step / 5, Ymax - row);
                    glVertex2d(0, Ymax - row);
                }
                
            }

            glLineWidth(1);
            glEnd();
        }
    }
}