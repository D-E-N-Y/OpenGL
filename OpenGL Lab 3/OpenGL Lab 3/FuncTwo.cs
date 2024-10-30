using lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenGL_Lab_3.OpenGL;

namespace OpenGL_Lab_3
{
    internal class FuncTwo : Draw
    {
        private int points;
        private bool autoSizeY;

        private NumericUpDown Ymin_numeric;
        private NumericUpDown Ymax_numeric;

        public FuncTwo(int _points, NumericUpDown _Ymin_numeric, NumericUpDown _Ymax_numeric, DrawConfig config, bool _autoSizeY)
            : base(config)
        {
            points = _points;
            autoSizeY = _autoSizeY;

            Ymin_numeric = _Ymin_numeric;
            Ymax_numeric = _Ymax_numeric;
        }

        private float Func(float x)
        {
            float numerator = MathF.Cos(float.Pi * x / 2) * MathF.Cos(MathF.Abs(float.Pi * x));
            float denominator = MathF.Abs(MathF.Sin(float.Pi * x));

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

            float breakdown = 1f / points * _width;

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

                if (MathF.Abs(x - MathF.Round(x)) < breakdown)
                {
                    continue;
                }
                else if (MathF.Abs(_x - MathF.Round(_x)) < breakdown)
                {
                    DrawLinesBreakdown(_x, _y);

                    continue;
                }

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

            _Ymin = MathF.Round(_Ymin, 1);
            _Ymax = MathF.Round(_Ymax, 1);

            if (_Ymin < -100) _Ymin = -99.0f;
            if (_Ymax > 100) _Ymax = 99.0f;

            if (autoSizeY && (_Ymin < -0.1f && _Ymax > 0.1f))
            {
                Ymin_numeric.Value = (decimal)(_Ymin - step);
                Ymax_numeric.Value = (decimal)(_Ymax + step);
            }

            glEnd();
        }

        private void DrawLinesBreakdown(float x, float y)
        {
            // end draw function
            glEnd();

            glLineStipple(10, 21845);
            glEnable(GL_LINE_STIPPLE);
            glLineWidth(3);

            glBegin(GL_LINES);
            glColor3d(255f / 255f, 128f / 255f, 0f / 255f);

            if (y > Ymax)
            {
                y = Ymax;
            }
            else if (y < Ymin)
            {
                y = Ymin;
            }

            glVertex2d(x, y);
            glVertex2d(x, -y);

            glEnd();

            glDisable(GL_LINE_STIPPLE);
            glLineWidth(2);

            glBegin(GL_LINES);
            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
        }
    }
}
