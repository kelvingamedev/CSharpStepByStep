using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCord, int yCord);
        void Draw(Canvas canvas);
    }
}
