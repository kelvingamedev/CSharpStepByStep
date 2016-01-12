using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace Drawing
{
    class Circle : DrawingShape,IDraw, IColor
    {
        public Circle(int radius) : base(radius)
        {          
        }

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }

            base.Draw(canvas);
        }
    }
}
