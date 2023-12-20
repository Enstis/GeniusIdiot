using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp 
{
    public class SlowMotionFruit : Fruit
    {
        public SlowMotionFruit(Form form) : base(form)
        {
            brush = Brushes.Yellow;
        }
    }
}
