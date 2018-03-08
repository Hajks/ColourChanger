using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clicking button will start background colour changer
        //Using some loops to get smooth colour change
        private void button1_Click(object sender, EventArgs e)
        {
           
            { 
            int c = 0;
            while  (c < 255 && Visible) //After closing program it was still working so i had to add one more condition.
            {
                BackColor = Color.FromArgb(c, 255 - c, c); // We could use siple colours like blue/red/green but instead we use Color.FromArgb to mix some colors
                Application.DoEvents();                    // It pause loop for a while to refresh background colour and check if user didnt click anything etc.
                System.Threading.Thread.Sleep(1);          // Stops loop for 1 ms -> 0,001 sec.
                c++;

               if (c == 255)
                {
                    while (c > 0 && Visible)
                    {
                        BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                        c--;
                    }
                }
                }
            }
        }
    }
    }

