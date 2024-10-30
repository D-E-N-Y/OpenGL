using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL_Lab_3
{
    public class DrawConfig
    {
        public float Xmin { get; set; }
        public float Xmax { get; set; }
        public float Ymin { get; set; }
        public float Ymax { get; set; }
        public float margin { get; set; }
        public float step { get; set; }
        public float height { get; set; }
        public float width { get; set; }

        public DrawConfig(float xmin, float xmax, float ymin, float ymax, float _margin, float _step, float _height, float _width)
        {
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
            margin = _margin;
            step = _step;
            height = _height;
            width = _width;
        }
    }
}
