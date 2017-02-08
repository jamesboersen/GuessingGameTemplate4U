using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class resultsScreen : UserControl
    {
        public resultsScreen()
        {
            InitializeComponent();
 
            totalGuessesOutput.Text = "" + Form1.guessList.Count();

            for (int i = 0; i < student.Count(); i++)
            {
               GuessesOutput.Text += "\n" + i + ": " + student[i];
            }



            GuessesOutput.Text = "" + 

        }
    }
}
