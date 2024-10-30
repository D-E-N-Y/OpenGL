using lesson;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenGL_Lab_3.OpenGL;

namespace OpenGL_Lab_3
{
    internal class FuncOne : Draw
    {
        private int points;
        private bool autoSizeY;

        private NumericUpDown Ymin_numeric;
        private NumericUpDown Ymax_numeric;

        public FuncOne(int _points, NumericUpDown _Ymin_numeric, NumericUpDown _Ymax_numeric, DrawConfig config, bool _autoSizeY)
            : base(config)
        {
            points = _points;
            autoSizeY = _autoSizeY;

            Ymin_numeric = _Ymin_numeric;
            Ymax_numeric = _Ymax_numeric;
        }

        private float Func(float x)
        {
            float numerator = MathF.Abs(MathF.Cos(0.5f * x + 1.0f)) * MathF.Cos(x);
            float denominator = MathF.Abs(MathF.Cos(x + 0.01f));

            return numerator / denominator;
        }

        public void DrawFunction()
        {
            float h = _width / (points - 1);

            float x = 0;
            float y = 0;

            float _x = 0;
            float _y = 0;

            float _Ymin = float.MaxValue;
            float _Ymax = float.MinValue;

            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (int i = 0; i < points; i++)
            {
                if (i > 0)
                {
                    _x = x;
                    _y = y;
                }

                x = Xmin + i * h;
                y = Func(x);

                if (!autoSizeY)
                {
                    if (y > Ymax)
                    {
                        y = Ymax;
                        continue;
                    }
                    else if (y < Ymin)
                    {
                        y = Ymin;
                        continue;
                    }
                }

                if (i > 0)
                {
                    glVertex2d(_x, _y);
                    glVertex2d(x, y);

                    if (_y * y <= 0)
                    {
                        DrawPoint((_x + x) / 2, (_y + y) / 2);
                    }
                }

                if (y < _Ymin && y < 0)
                {
                    _Ymin = y;
                }
                if (y > _Ymax && y > 0)
                {
                    _Ymax = y;
                }
            }

            glEnd();

            _Ymin = MathF.Round(_Ymin, 1);
            _Ymax = MathF.Round(_Ymax, 1);

            if (_Ymin < -100) _Ymin = -99.0f;
            if (_Ymax > 100) _Ymax = 99.0f;

            if (autoSizeY)
            {
                Ymin_numeric.Value = (decimal)(_Ymin - step);
                Ymax_numeric.Value = (decimal)(_Ymax + step);
            }
        }

        private void DrawPoint(float x, float y)
        {
            // end draw function
            glEnd();

            // draw point
            glPointSize(10);

            glBegin(GL_POINTS);
            glColor3d(255f / 255f, 128f / 255f, 0f / 255f);

            glVertex2d(x, y);

            glEnd();

            // continue draw function
            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
        }
    }
}
