using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Drawing
{
    class Square :  DrawingShape, IDraw, IColor
    {
        public Square(int sideLenght) : base(sideLenght)
        { 
        }

        public override void Draw(Canvas canvas)
        {
            if(this.shape != null)
            {
                canvas.Children.Remove(this.shape);                   
            }
            else
            {
                this.shape = new Rectangle();
            }

            base.Draw(canvas);
        }

  
     }
    
}
