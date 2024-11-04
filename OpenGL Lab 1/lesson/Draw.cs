using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lesson.OpenGL;

namespace lesson
{
    public class Draw
    {
        private int min_x, max_x, min_y, max_y;

        public Draw(int MinX, int MaxX, int MinY, int MaxY)
        {
            min_x = MinX;
            max_x = MaxX;
            min_y = MinY;
            max_y = MaxY;
        }

        public void Drawing()
        {
            //glColor3f(0.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);

            DrawGrid();
            DrawAxis();
            DrawFigure();
            DrawPorintsFigure();
        }

        private void DrawGrid()
        {
            glLineStipple(1, 4369);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(2);
            glBegin(GL_LINES);

            // draw horizontal lines
            for (float i = min_x; i <= max_x; i += 1)
            {

                glVertex2d(i, min_y - 1);
                glVertex2d(i, max_y + 1);
            }

            // draw vertical lines
            for (float i = min_y; i <= max_y; i += 1)
            {
                glVertex2d(min_x - 1, i);
                glVertex2d(max_x + 1, i);

            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
            glLineWidth(1);
        }

        private void DrawAxis()
        {
            glLineWidth(4);
            glBegin(GL_LINES);

            // Y
            glVertex2d(min_x - 1, min_y - 0.2);
            glVertex2d(min_x - 1, max_y + 1);

            // arrow
            glVertex2d(min_x - 1, max_y + 1);
            glVertex2d(min_x - 1 - 0.2, max_y + 1 - 0.2);

            glVertex2d(min_x - 1, max_y + 1);
            glVertex2d(min_x - 1 + 0.2, max_y + 1 - 0.2);

            // strokes
            for (int i = min_y; i <= max_y; i++)
            {
                glVertex2d(min_x - 1, i);
                glVertex2d(min_x - 1 - 0.2, i);
            }

            // X
            glVertex2d(min_x - 0.2, min_y - 1);
            glVertex2d(max_x + 1, min_y - 1);

            // arrow
            glVertex2d(max_x + 1, min_y - 1);
            glVertex2d(max_x + 1 - 0.2, min_y - 1 - 0.2);

            glVertex2d(max_x + 1, min_y - 1);
            glVertex2d(max_x + 1 - 0.2, min_y - 1 + 0.2);

            // strokes
            for (int i = min_x; i <= max_x; i++)
            {
                glVertex2d(i, min_y - 1);
                glVertex2d(i, min_y - 1 - 0.2);
            }

            glEnd();
            glLineWidth(1);
        }


        private void DrawFigure()
        {
            glLineWidth(8);
            glBegin(GL_LINES);

            glVertex2d(-1, 2);
            glVertex2d(-1, 0);

            glVertex2d(-1, 0);
            glVertex2d(0, -1);

            glVertex2d(0, -1);
            glVertex2d(2, -2);

            glVertex2d(2, -2);
            glVertex2d(2, -1);

            glVertex2d(2, -1);
            glVertex2d(1, 1);

            glVertex2d(1, 1);
            glVertex2d(0, 2);

            glVertex2d(0, 2);
            glVertex2d(-1, 2);

            glEnd();
            glLineWidth(1);
        }

        private void DrawPorintsFigure()
        {
            glPointSize(16);
            glEnable(GL_POINT_SMOOTH);
            glBegin(GL_POINTS);

            glVertex2d(4, 2);
            glVertex2d(4, 0);
            glVertex2d(5, -1);
            glVertex2d(7, -2);
            glVertex2d(7, -1);
            glVertex2d(6, 1);
            glVertex2d(5, 2);

            glEnd();
            glDisable(GL_POINT_SMOOTH);
            glPointSize(1);
        }
    }
}
