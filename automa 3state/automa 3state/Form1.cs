using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automa_3state
{
    public partial class Form1 : Form
    {
        const int S0 = 0;
        const int S1 = 1;
        const int S2 = 2;
        const int S3 = 3;
        const int SE = 4;
        int state = S0;
        public Form1()
        {
            InitializeComponent();
        }
        private void seek(object sender,EventArgs e)
        {
            Button pressed = (Button)sender;
            txt.Text += pressed.Text;
            state = S0;
            txt.ForeColor = Color.Black;


        }

        private void test_Click(object sender, EventArgs e)
        {
            this.startAutome();
            this.fore();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            state = S0;
            txt.Text = "";
            txt.ForeColor = Color.Black;
           
        }

        private void fore()
        {
            if (state==S2 || state == S3)
            {
                txt.ForeColor = Color.Green;

            }
            else
            {
                txt.ForeColor = Color.Red;
            }
        }
        private void startAutome()
        {
            String work = txt.Text;
            foreach (char chip in work){
                switch (state)
                {
                    case S0:
                        if (chip == 'A')
                        {
                            state = S1;
                        }
                        else
                        {
                            state = SE;
                        }
                        break;

                    case S1:
                        if (chip == 'B')
                        {
                            state = S2;
                        }
                       
                        break;

                    case S2:
                        if (chip == 'A')
                        {
                            state = S3;
                        }                 
                        break;

                    case S3:
                        if (chip == 'B')
                        {
                            state = SE;
                        }
                        break;

                }
            }
        
        }
    }
}
