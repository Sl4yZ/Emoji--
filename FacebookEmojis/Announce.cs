using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookEmojis
{
    public partial class Announce : Form
    {
        public static SmileyList mainUI;
        public Announce()
        {
            InitializeComponent();
            mainUI = new SmileyList();
            mainUI.notifyIcon1.Visible = false;
        }

        private void Announce_Load(object sender, EventArgs e)
        {
           
            
            this.CenterToParent();
           // mainUI.notifyIcon1.Visible = false;
        }


        public void FadeEffects()
        {

            Opacity = 0;
            int duration = 1000;//in milliseconds
            int steps = 100;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    
                    //Fade Out

                    duration = 4000;
                    timer.Interval = duration / steps;

                   currentStep = 100;
                    timer.Tick += (arg3, arg4) =>
                    {
                        Opacity = ((double)currentStep) / steps;
                        currentStep--;

                        if (currentStep >= steps)
                        {
                            timer.Stop();
                            timer.Dispose();
                        }
                    };

                    timer.Start();
                }
            };

            timer.Start();
            Refresh();
        }
    }
}
