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
using static System.Windows.Forms.AxHost;

namespace OpenGL_Lab_5
{
    public partial class RenderControl : OpenGL
    {
        private float size = 10.5f;
        private float AspectRatio { get => (float)Width / Height; }

        private float Xmin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        private float Xmax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        private float Ymin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        private float Ymax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }
        private float Zmin { get => -size; }
        private float Zmax { get => +size; }

        private float angleX;
        private float angleY;

        private float gridStep;
        private float gridMerge;

        private float _heigth;
        private float _width;

        private float segment;

        private bool isFillMode;
        private uint gluMode;

        private float sphereRadius;

        private float coneHeight;
        private float coneRadius;
        private float coneSlice;

        private float innerRadius;
        private float outerRadius;
        private float startAngle;
        private float sweepAngle;

        private bool isPerspective;

        public RenderControl()
        {
            InitializeComponent();
        }

        private uint idAxis;
        private IntPtr qObj;
        private void Start(object sender, EventArgs e)
        {
            angleY = 20.0f;
            angleX = 10.0f;

            gridStep = 1f;
            gridMerge = 0.5f;

            _heigth = size * 2;
            _width = size * 2;

            segment = 15.0f;

            isFillMode = true;
            gluMode = GLU_FILL;

            sphereRadius = 3.5f;

            coneHeight = 4.0f;
            coneRadius = 2.0f;
            coneSlice = 2.0f;

            innerRadius = 1.5f;
            outerRadius = 4.5f;
            startAngle = 180f;
            sweepAngle = 90f;

            isPerspective = false;

            idAxis = glGenLists(3);
            glNewList(idAxis, GL_COMPILE);

            DrawGrid();
            DrawAxis();
            DrawTextAxis();

            glEndList();

            qObj = gluNewQuadric();
        }

        private void Destroy(object sender, EventArgs e)
        {
            gluDeleteQuadric(qObj);
        }

        public void SetSegments(int _segment)
        {
            segment = _segment;

            Invalidate();
        }

        public void SetDrawMode(bool _fill, uint _gluMode)
        {
            isFillMode = _fill;
            gluMode = _gluMode;

            Invalidate();
        }

        public void SetRenderMode(bool _isPerspective)
        {
            isPerspective = _isPerspective;

            Invalidate();
        }

        public void SetSphereRadius(float _radius)
        {
            sphereRadius = _radius;

            Invalidate();
        }

        public void SetConeRadius(float _radius)
        {
            coneRadius = _radius;

            Invalidate();
        }

        public void SetConeHeight(float _height)
        {
            coneHeight = _height;

            Invalidate();
        }

        public void SetConeSlice(float _slice)
        {
            coneSlice = _slice;

            Invalidate();
        }

        public void SetPDInnerRadius(float _radius)
        {
            innerRadius = _radius;

            Invalidate();
        }

        public void SetPDOuterRadius(float _radius)
        {
            outerRadius = _radius;

            Invalidate();
        }

        public void SetPDStartAngle(float _angle)
        {
            startAngle = _angle;

            Invalidate();
        }

        public void SetPDSweepAngle(float _angle)
        {
            sweepAngle = _angle;

            Invalidate();
        }

        private void SetProjection()
        {
            // Переходим на матрицу проекции и сбрасываем её
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();

            if (isPerspective)
            {
                // Настройка перспективной проекции
                float fieldOfView = 45.0f;
                float nearClip = 0.1f;
                float farClip = 100.0f;
                gluPerspective(fieldOfView, AspectRatio, nearClip, farClip);
            }
            else
            {
                // Настройка ортогональной проекции
                glOrtho(Xmin, Xmax, Ymin, Ymax, Zmin, Zmax);
            }

            // Возвращаемся к матрице модели
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            // Устанавливаем проекцию
            SetProjection();

            if (isPerspective)
            {
                // Для перспективной проекции добавляем отступ камеры назад
                glTranslatef(0, 0, -size * 3);
            }

            glRotated(angleX, 1, 0, 0);
            glRotated(angleY, 0, 1, 0);

            // Enable depth
            glEnable(GL_DEPTH_TEST);

            gluQuadricDrawStyle(qObj, gluMode);

            // Draw system coorditane
            glCallList(idAxis);

            glEnable(GL_COLOR_MATERIAL);
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);
            glLightfv(GL_LIGHT0, GL_POSITION, new float[] { size, size, size, 0 });

            //Draw figures
            //DrawSphere();
            //DrawConus();
            //DrawPartialDisk();

            //DrawTorus();
            DrawBottleKlein();

            glDisable(GL_LIGHTING);
        }

        private void DrawPartialDisk()
        {
            glPushMatrix();

            float x0 = 4.5f;
            float y0 = -3.5f;
            float z0 = -4.5f;
            
            glTranslatef(x0, y0, z0);

            glColor3d(0, 1, 0);
            gluPartialDisk(qObj, innerRadius, outerRadius, (int)segment, 1, startAngle, sweepAngle);

            glPopMatrix();
        }

        private void DrawConus()
        {
            glPushMatrix();

            float x0 = 3.0f;
            float y0 = 2.0f;
            float z0 = -2.5f;

            float slice = coneHeight - coneSlice;

            // slice
            glClipPlane(GL_CLIP_PLANE0, new double[] {0, 0, -(z0 / z0), -(z0 / z0) * -(z0 + slice) });
            glEnable(GL_CLIP_PLANE0);

            glTranslatef(x0, y0, z0);
            glColor3d(255f / 255f, 237f / 255f, 0f / 255f);
            gluCylinder(qObj, coneRadius, 0.0f, coneHeight, (int)segment, (int)segment);

            glDisable(GL_CLIP_PLANE0);

            glPopMatrix();

            return;

            if (slice <= 0) return;

            float upsilonStep = coneHeight / segment;
            float tetaStep = 2 * float.Pi / segment;

            if (isFillMode)
            {
                //glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                glBegin(GL_QUAD_STRIP);
            }
            else
            {
                glBegin(GL_LINES);
            }

            glColor3d(255f / 255f, 237f / 255f, 0f / 255f);
            bool isSlice = false;

            for (float upsilon = 0; upsilon < coneHeight; upsilon += upsilonStep)
            {
                if ((z0 + upsilon + upsilonStep >= slice + z0) && coneSlice != 0)
                {
                    if (!isSlice)
                    {
                        upsilonStep = (slice + z0) - (z0 + upsilon);
                        isSlice = true;
                    }
                    else
                    {
                        upsilonStep = coneHeight / segment;
                    }
                }

                for (float teta = 0; teta < 2 * float.Pi; teta += tetaStep)
                {
                    float x1 = x0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Cos(teta);
                    float y1 = y0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Sin(teta);
                    float z1 = z0 + upsilon;

                    float x2 = x0 + (coneHeight - (upsilon + upsilonStep)) / coneHeight * coneRadius * MathF.Cos(teta);
                    float y2 = y0 + (coneHeight - (upsilon + upsilonStep)) / coneHeight * coneRadius * MathF.Sin(teta);
                    float z2 = z0 + upsilon + upsilonStep;

                    float x3 = x0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Cos(teta + tetaStep);
                    float y3 = y0 + (coneHeight - upsilon) / coneHeight * coneRadius * MathF.Sin(teta + tetaStep);
                    float z3 = z0 + upsilon;

                    // base bottom
                    glVertex3d(x1, y1, z0);
                    glVertex3d(x2, y2, z0);

                    glVertex3d(x1, y1, z0);
                    glVertex3d(x3, y3, z0);

                    if (z2 <= slice + z0)
                    {
                        glVertex3d(x1, y1, z1);
                        glVertex3d(x2, y2, z2);

                        glVertex3d(x1, y1, z1);
                        glVertex3d(x3, y3, z3);
                    }

                    if (z2 > slice + z0 && coneSlice != 0)
                    {
                        //base top
                        glVertex3d(x1, y1, slice + z0);
                        glVertex3d(x2, y2, slice + z0);

                        glVertex3d(x1, y1, slice + z0);
                        glVertex3d(x3, y3, slice + z0);
                    }
                }
            }

            glEnd();
        }

        private void DrawSphere()
        {
            glPushMatrix();
            
            float x0 = -4.5f;
            float y0 = -3.5f;
            float z0 = 3.5f;

            glTranslatef(x0, y0, z0);

            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);
            gluSphere(qObj, sphereRadius, (int)segment, (int)segment);

            glPopMatrix();

            return;

            float stepTeta = float.Pi / segment;
            float stepPhi = 2 * float.Pi / segment;

            if (isFillMode)
            {
                //glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
                glBegin(GL_QUAD_STRIP);
            }
            else
            {
                glBegin(GL_LINES);
            }

            glColor3d(64f / 255f, 224f / 255f, 208f / 255f);

            for (float teta = 0.0f; teta < float.Pi / 2; teta += stepTeta)
            {
                for (float phi = 0.0f; phi < 2 * float.Pi; phi += stepPhi)
                {
                    float x1 = x0 + sphereRadius * MathF.Sin(teta) * MathF.Cos(phi);
                    float y1 = y0 + sphereRadius * MathF.Sin(teta) * MathF.Sin(phi);
                    float z1 = z0 + sphereRadius * MathF.Cos(teta);

                    float x2 = x0 + sphereRadius * MathF.Sin(teta) * MathF.Cos(phi + stepPhi);
                    float y2 = y0 + sphereRadius * MathF.Sin(teta) * MathF.Sin(phi + stepPhi);
                    float z2 = z0 + sphereRadius * MathF.Cos(teta);

                    float x3 = x0 + sphereRadius * MathF.Sin(teta + stepTeta) * MathF.Cos(phi);
                    float y3 = y0 + sphereRadius * MathF.Sin(teta + stepTeta) * MathF.Sin(phi);
                    float z3 = z0 + sphereRadius * MathF.Cos(teta + stepTeta);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x2, y2, z2);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x3, y3, z3);
                }
            }

            glEnd();
        }

        private void DrawTorus()
        {
            float stepU = 2 * float.Pi / segment;
            float stepV = 2 * float.Pi / segment;

            float c = 5;
            float a = 2;

            float x0 = 0;
            float y0 = 0;
            float z0 = 0;

            glBegin(GL_LINES);
            glColor3d(1, 0, 0);

            for(float U = 0; U < 2 * float.Pi; U += stepU)
            {
                for(float V = 0; V < 2 * float.Pi; V += stepV)
                {
                    float x1 = x0 + (c + a * MathF.Cos(V)) * MathF.Cos(U);
                    float y1 = y0 + (c + a * MathF.Cos(V)) * MathF.Sin(U);
                    float z1 = z0 + a * MathF.Sin(V);

                    float x2 = x0 + (c + a * MathF.Cos(V + stepV)) * MathF.Cos(U);
                    float y2 = y0 + (c + a * MathF.Cos(V + stepV)) * MathF.Sin(U);
                    float z2 = z0 + a * MathF.Sin(V + stepV);

                    float x3 = x0 + (c + a * MathF.Cos(V)) * MathF.Cos(U + stepU);
                    float y3 = y0 + (c + a * MathF.Cos(V)) * MathF.Sin(U + stepU);
                    float z3 = z0 + a * MathF.Sin(V);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x2, y2, z2);

                    glVertex3d(x1, y1, z1);
                    glVertex3d(x3, y3, z3);
                }
            }

            glEnd();
        }

        private void DrawBottleKlein()
        {
            float stepU = 2 * float.Pi / segment;
            float stepV = 2 * float.Pi / segment;

            float a = 10;

            float x0 = 0;
            float y0 = 0;
            float z0 = 0;

            glBegin(GL_LINES);
            glColor3d(1, 0, 0);

            for (float U = 0; U < 2 * float.Pi; U += stepU)
            {
                for (float V = 0; V < 2 * float.Pi; V += stepV)
                {
                    float x1 = x0 + MathF.Cos(U) * MathF.Abs(MathF.Cos(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Sin(1 / 2 * U) * MathF.Sin(V) * MathF.Cos(V));
                    float y1 = y0 + MathF.Sin(U) * MathF.Abs(MathF.Cos(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Sin(1 / 2 * U) * MathF.Sin(V) * MathF.Cos(V));
                    float z1 = z0 + -MathF.Sin(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Cos(1 / 2 * U) * MathF.Sin(V) * MathF.Cos(V);

                    float x2 = x0 + MathF.Cos(U) * MathF.Abs(MathF.Cos(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos((V + stepV))) + MathF.Sin(1 / 2 * U) * MathF.Sin((V + stepV)) * MathF.Cos((V + stepV)));
                    float y2 = y0 + MathF.Sin(U) * MathF.Abs(MathF.Cos(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos((V + stepV))) + MathF.Sin(1 / 2 * U) * MathF.Sin((V + stepV)) * MathF.Cos((V + stepV)));
                    float z2 = z0 + -MathF.Sin(1 / 2 * U) * (MathF.Sqrt(2) + MathF.Cos((V + stepV))) + MathF.Cos(1 / 2 * U) * MathF.Sin((V + stepV)) * MathF.Cos((V + stepV));

                    float x3 = x0 + MathF.Cos((U + stepU)) * MathF.Abs(MathF.Cos(1 / 2 * (U + stepU)) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Sin(1 / 2 * (U + stepU)) * MathF.Sin(V) * MathF.Cos(V));
                    float y3 = y0 + MathF.Sin((U + stepU)) * MathF.Abs(MathF.Cos(1 / 2 * (U + stepU)) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Sin(1 / 2 * (U + stepU)) * MathF.Sin(V) * MathF.Cos(V));
                    float z3 = z0 + -MathF.Sin(1 / 2 * (U + stepU)) * (MathF.Sqrt(2) + MathF.Cos(V)) + MathF.Cos(1 / 2 * (U + stepU)) * MathF.Sin(V) * MathF.Cos(V);

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
            if (mouseFlag)
                mouseFlag = !(e.Button == MouseButtons.Left);
        }

        private void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseFlag)
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

