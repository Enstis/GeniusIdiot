﻿using Ball.CommonNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public class PigBall : MoveBallRandom
    {
        public PigBall(Form form) : base(form)
        {
            radius = 15;
            brush = Brushes.Green;
            
        }
    }
}