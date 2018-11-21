using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blank_eraser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            const int S0 = 0;
            const int S1 = 1;
            const int S2 = 2;
            const char BL = ' ';
            string theString = tin.Text;
            string throwOut = "";
            int TheCurrentState = S0;
            for(int i = 0; i <theString.Length; i++)
            {
                char c = theString[i];

                switch (TheCurrentState)
                {
                    case S0:
                        if (c != BL)
                        {

                            throwOut += c.ToString();
                            TheCurrentState = S1;
                        
                        }


                        break;

                    case S1:
                        
                        if (c == BL)
                        {

                            TheCurrentState = S2;

                        }

                        break;

                    case S2:
                        if(c != BL)
                        {
                            throwOut += BL;
                            throwOut += c;
                            TheCurrentState = S0;
                        }
                        break;
                        
                }
                tout.Text = throwOut;
            }
        }
    }
}
