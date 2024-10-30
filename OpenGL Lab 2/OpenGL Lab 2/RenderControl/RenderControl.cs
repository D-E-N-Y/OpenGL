using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace OpenGL_Lab_2
{
    public partial class RenderControl : OpenGL
    {
        private int count_hor;
        private int count_vert;

        private float a;
        private float size_plit;
        private float size;

        private uint polygonMode;
        private uint shadeModel;

        private float min_x, max_x;
        private float min_y, max_y;

        public RenderControl()
        {
            InitializeComponent();
        }

        // start value
        public void Start()
        {
            a = 0.2f;       // size side of figure
            size_plit = 0.575f;

            count_hor = 1;
            count_vert = 1;

            polygonMode = GL_FILL;
            shadeModel = GL_SMOOTH;

            UpdateSizeScreen();
        }

        // set sizze screen
        public void UpdateSizeScreen()
        {
            float modX = 0, modY = 0, exMod = 0;

            if(count_hor >= count_vert)
            {
                exMod = (a / 2) * (count_vert - 1);
                modX = (0.375f * (count_hor - 1));
                modY = modX + exMod;

                min_x = -a - exMod;
                max_x = 0.375f + modX;

                min_y = -0.3375f - modY;
                max_y = 0.2375f;
            }
            else if(count_hor < count_vert)
            {
                modX = (a / 2) * (count_vert - 1);
                modY = (0.375f * (count_vert - 1)) + modX;

                min_x = -a - modX;
                max_x = 0.375f + (modY - modX);

                min_y = -0.3375f - modY;
                max_y = 0.2375f;
            }
        } 

        // set count horizontal
        public void SetHorValue(int value)
        {
            count_hor = value;

            UpdateSizeScreen();
        }
        
        // set count vertival
        public void SetVerValue(int value)
        {
            count_vert = value;

            UpdateSizeScreen();
        }

        public void SetPolygonMode(uint value)
        {
            polygonMode = value;

            Refresh();
        }

        public void SetShadeMode(uint value)
        {
            shadeModel = value;

            Refresh();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            // Устанавливаем квадратную область просмотра, сохраняя пропорции
            if (Width > Height)
            {
                // Если ширина больше высоты, центрируем по горизонтали
                glViewport((Width - Height) / 2, 0, Height, Height);
            }
            else
            {
                // Если высота больше ширины, центрируем по вертикали
                glViewport(0, (Height - Width) / 2, Width, Width);
            }

            glOrtho(min_x, max_x, min_y, max_y, -1, 1);

            for (int vert = 0; vert < count_vert; vert++)
            {
                for (int hor = 0; hor < count_hor; hor++)
                {
                    DrawFidures(vert, hor);
                }
            }
        }
                
        private void DrawFidures(int vert, int hor)
        {
            float coef_x = ((((a * MathF.Sqrt(3)) / 2) + a) * hor) - ((a / 2) * vert);
            float coef_y = ((-a / 2) * hor) - ((((a * MathF.Sqrt(3)) / 2) + a) * vert);

            float pos_x = 0 + coef_x;
            float pos_y = 0 + coef_y;

            glPolygonMode(GL_FRONT_AND_BACK, polygonMode);
            glShadeModel(shadeModel);

            glPointSize(5);
            glLineWidth(5);

            // figure 1
            glBegin(GL_POLYGON);
            glColor3f(1f, 0f, 0f); // Красный
            glVertex2d(pos_x - a, pos_y);

            glColor3f(0f, 1f, 0f); // Зеленый
            glVertex2d(pos_x - a, pos_y - a);

            glColor3f(0f, 0f, 1f); // Синий
            glVertex2d(pos_x, pos_y - a);

            glColor3f(1f, 1f, 0f); // Желтый
            glVertex2d(pos_x, pos_y);
            glEnd();

            // figure 2
            glBegin(GL_POLYGON);
            glColor3f(1f, 0f, 1f); // Фиолетовый
            glVertex2d(pos_x, pos_y);

            glColor3f(0f, 1f, 1f); // Голубой
            glVertex2d(pos_x + ((a * Math.Sqrt(3)) / 2), pos_y - (a / 2));

            glColor3f(1f, 1f, 1f); // Белый
            glVertex2d(pos_x, pos_y - a);
            glEnd();

            // figure 3
            glBegin(GL_POLYGON);
            glColor3f(1f, 0.5f, 0f); // Оранжевый
            glVertex2d(pos_x + ((a * Math.Sqrt(3)) / 2), pos_y - (a / 2));

            glColor3f(0.5f, 0.5f, 0.5f); // Серый
            glVertex2d(pos_x + ((a * Math.Sqrt(3)) / 2), pos_y + ((-a / 2) - a));

            glColor3f(0f, 0f, 0f); // Черный
            glVertex2d(pos_x, pos_y - a);
            glEnd();

            // figure 4
            glBegin(GL_POLYGON);
            glColor3f(0.7f, 0f, 0.7f); // Фиолетово-розовый
            glVertex2d(pos_x + ((a * Math.Sqrt(3)) / 2), pos_y - (a / 2));

            glColor3f(0.2f, 0.4f, 0.6f); // Сине-зеленый
            glVertex2d(pos_x + (((a * Math.Sqrt(3)) / 2) + a), pos_y - (a / 2));

            glColor3f(0.3f, 0.7f, 0.9f); // Голубовато-зеленый
            glVertex2d(pos_x + (((a * Math.Sqrt(3)) / 2) + a / 2), (pos_y - (a / 2)) + ((a * Math.Sqrt(3)) / 2));
            glEnd();

            // figure 5
            glBegin(GL_POLYGON);
            glColor3f(0.9f, 0.1f, 0.3f); // Темно-красный
            glVertex2d(pos_x, pos_y);

            glColor3f(0.4f, 0.8f, 0.2f); // Светло-зеленый
            glVertex2d(pos_x + (a / 2), pos_y + ((a * Math.Sqrt(3)) / 2));

            glColor3f(0.2f, 0.4f, 0.8f); // Синий
            glVertex2d(pos_x + (((a * Math.Sqrt(3)) / 2) + a / 2), (pos_y - (a / 2)) + ((a * Math.Sqrt(3)) / 2));

            glColor3f(0.1f, 0.6f, 0.1f); // Зеленый
            glVertex2d(pos_x + ((a * Math.Sqrt(3)) / 2), pos_y - (a / 2));
            glEnd();

            // figure 6
            glBegin(GL_POLYGON);
            glColor3f(0.8f, 0.3f, 0.7f); // Лиловый
            glVertex2d(pos_x, pos_y);

            glColor3f(0.7f, 0.7f, 0.2f); // Желтоватый
            glVertex2d(pos_x - (a / 2), pos_y + ((a * Math.Sqrt(3)) / 2));

            glColor3f(0.6f, 0.2f, 0.6f); // Фиолетовый
            glVertex2d(pos_x + (a / 2), pos_y + ((a * Math.Sqrt(3)) / 2));
            glEnd();
        }
    }
}

