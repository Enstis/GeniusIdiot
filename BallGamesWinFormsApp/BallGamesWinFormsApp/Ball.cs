﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWinFormsApp
{


    public class Ball
    {
        protected  MainForm form;
        protected int vx = 1;
        protected int vy = 1;
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;

        public Ball(MainForm form)
        {
            this.form = form;
            this.form.BackColor = Color.White;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
           
        }

        protected void Go()
        {
            x += vx;
            y += vy;
        }

        protected void Clear () 
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        } 
        
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }
    
}
