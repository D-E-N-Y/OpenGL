using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace OpenGL_Lab_3
{
    public partial class RenderControl : OpenGL
    {
        private float Xmin, Xmax;
        private float Ymin, Ymax;

        private float margin;
        private float step;

        private float _heigth;
        private float _width;

        private int points;

        private int tabIndex;

        private bool autoSizeY;

        private NumericUpDown Ymin_numeric;
        private NumericUpDown Ymax_numeric;

        private DrawConfig config;
        private FuncOne _funcOne;
        private FuncTwo _funcTwo;

        public RenderControl()
        {
            InitializeComponent();
        }

        public void Start(NumericUpDown _Ymin_numeric, NumericUpDown _Ymax_numeric, int _tabIndex, bool _autoSizeY, float _Xmin, float _Xmax, float _Ymin, float _Ymax, float _margin, float _step, int _points)
        {
            Ymin_numeric = _Ymin_numeric;
            Ymax_numeric = _Ymax_numeric;
            tabIndex = _tabIndex;
            autoSizeY = _autoSizeY;

            Xmin = _Xmin;
            Xmax = _Xmax;

            Ymin = _Ymin;
            Ymax = _Ymax;

            margin = _margin;
            step = _step;

            points = _points;

            UpdateHeightWidth();
            UpdateConfig();
        }

        private void UpdateHeightWidth()
        {
            _heigth = (-Ymin) + Ymax;
            _width = (-Xmin) + Xmax;
        }

        private void UpdateConfig()
        {
            config = new DrawConfig(Xmin, Xmax, Ymin, Ymax, margin, step, _heigth, _width);

            switch(tabIndex)
            {
                case 0:
                    _funcOne = new FuncOne(points, Ymin_numeric, Ymax_numeric, config, autoSizeY);
                    break;

                case 1:
                    _funcTwo = new FuncTwo(points, Ymin_numeric, Ymax_numeric, config, autoSizeY);
                    break;
            }
        }

        public void SetAutoSizeY(bool _autoSizeY)
        {
            autoSizeY = _autoSizeY;

            UpdateConfig();
            Refresh();
        }

        public void SetXmin(float _Xmin)
        {
            Xmin = _Xmin;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        public void SetXmax(float _Xmax)
        {
            Xmax = _Xmax;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        public void SetYmin(float _Ymin)
        {
            Ymin = _Ymin;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        public void SetYmax(float _Ymax)
        {
            Ymax = _Ymax;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        public void SetPoints(int _points)
        {
            points = _points;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        public void SetStep(float _step)
        {
            step = _step;

            UpdateHeightWidth();
            UpdateConfig();
            Refresh();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            glOrtho(Xmin - margin, Xmax + margin, Ymin - margin, Ymax + margin, -1, 1);
            
            switch(tabIndex)
            {
                case 0:
                    if(_funcOne != null)
                    {
                        _funcOne.DrawCoordinateSystem();
                        _funcOne.DrawFunction();
                    }
                    break;

                case 1:
                    if(_funcTwo != null)
                    {
                        _funcTwo.DrawCoordinateSystem();
                        _funcTwo.DrawFunction();
                    }
                    break;
            }

            DrawTextAxis();
        }
        private void DrawTextAxis()
        {
            glColor3d(200f / 255f, 200f / 255f, 200f / 255f);

            // X axis
            float _start = step * (((-Xmin) / step) % 1);
            for (float colum = _start; colum < _width + step; colum += step)
            {
                if ((Xmin + colum != 0) && (Xmin + colum >= Xmin && Xmin + colum <= Xmax))
                {
                    DrawText((Xmin + colum).ToString("F1"), Xmin + colum, -step / 3);
                }
            }

            // Y axis
            _start = step * ((Ymax / step) % 1);
            for (float row = _start; row < _heigth + step; row += step)
            {
                if ((Ymax - row != 0) && (Ymax - row <= Ymax && Ymax - row >= Ymin))
                {
                    DrawText((Ymax - row).ToString("F1"), -step / 3, Ymax - row);
                }
            }

            // 0
            DrawText((0).ToString("F1"), -step / 3, -step / 3);
        }
    }
}

