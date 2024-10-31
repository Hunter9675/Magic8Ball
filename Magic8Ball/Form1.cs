using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ranGen = new Random();
            int randomNumber;

            randomNumber = ranGen.Next(1, 7);

            if (randomNumber == 1)
            {
                eightBallOutput.Text = "Yes.";

            }

            else if (randomNumber == 2)
            {
                eightBallOutput.Text = "No.";

            }

            else if (randomNumber == 3)
            {
                eightBallOutput.Text = "Maybe.";

            }

            else if (randomNumber == 4)
            {
                eightBallOutput.Text = "Probably.";

            }

            else if (randomNumber == 5)
            {
                eightBallOutput.Text = "Probably not.";

            }

            else if (randomNumber == 6)
            {
                eightBallOutput.Text = "I don't know.";

            }

        }
    }
}
