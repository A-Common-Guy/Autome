using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parser_autome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int S0 = 0;
        private const int S1 = 1;
        private const int SE = 2;
        private int state = S0;
        

        private void aButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String mychar=b.Text;
            txt.Text += mychar;
            this.flow(mychar);
        }


        private void flow(String operate)
        {
            switch (state)
            {
                case S0:
                    
                    switch (operate)
                    {
                        case "A":
                            state = S1;
                            txt.ForeColor = Color.Green;
                            break;

                        case "B":
                            state = SE;
                            txt.ForeColor = Color.Red;
                            break;
                    }
                    
                    break;

                case S1:
                    txt.ForeColor = Color.Red;
                    switch (operate)
                    {
                        case "A":
                            txt.ForeColor = Color.Red;
                            state = SE;
                            break;

                        case "B":
                            txt.ForeColor = Color.Red;
                            state = S0;
                            break;
                    }


                    break;

                case SE:
                    txt.ForeColor = Color.Red;
                    break;
                    
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            state = S0;
            txt.Text = "";
            txt.ForeColor = Color.Green;
        }

        private void test_Click(object sender, EventArgs e)
        {
            foreach (char g in txt.Text)
            {
                flow(g.ToString());
            }
        }
    }
}
