using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class BombFruit : Fruit
    {
        public BombFruit(Form form) : base(form)
        {
            brush = Brushes.Black;
        }
    }
}
