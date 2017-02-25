/// <summary>
/// Program:  Character Creator
/// Name: Subham Salaria
/// StudentID: 200333595
/// App Creation Date: Feb 24, 2017
/// 
/// </summary>
/// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }


        //Calls the variable that fills all the read only text boxes with information gathered from other forms
        //Done this way instead of one at a time to maximize cpu and uses less space.
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Stats();
            if (raceTextBox.Text == "Human")
            {
                pictureBox.Image = Properties.Resources.Human;
            }
            else if (raceTextBox.Text == "Elf")
            {
                pictureBox.Image = Properties.Resources.elf;
            }
            else if (raceTextBox.Text == "Dwarf")
            {
                pictureBox.Image = Properties.Resources.drawf;
            }
            else if (raceTextBox.Text == "Halfling")
            {
                pictureBox.Image = Properties.Resources.Halfling;
            }
        }

        /// <summary>
        /// this method sends the message to printer for printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer For Printing.......!");
        }

        /// <summary>
        /// this method helps to exit from the running program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// this method changes the font of the labels and the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
            textBox2.Font = fontDialog.Font;
            textBox3.Font = fontDialog.Font;
            textBox4.Font = fontDialog.Font;
            textBox5.Font = fontDialog.Font;
            jobTextBox.Font = fontDialog.Font;
            raceTextBox.Font = fontDialog.Font;
            healthTextBox.Font = fontDialog.Font;
            nameLabel.Font = fontDialog.Font;
            ageLabel.Font = fontDialog.Font;
            heightLabel.Font = fontDialog.Font;
            weightLabel.Font = fontDialog.Font;
            jobLabel.Font = fontDialog.Font;
            titleLabel.Font = fontDialog.Font;
            raceLabel.Font = fontDialog.Font;
            healthPointsLabel.Font = fontDialog.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new form
            AboutBox aboutForm = new AboutBox();

            // show the about form with showdialog(a modal method to display the form)
            aboutForm.ShowDialog();
        }

        public void Stats()
        {
            healthTextBox.Text = Program.character.Health;
            raceTextBox.Text = Program.character.Race;
            jobTextBox.Text = Program.character.Job;
            STRTextBox.Text = Program.character.STR;
            DEXTextBox.Text = Program.character.DEX;
            ENDTextBox.Text = Program.character.END;
            INTTextBox.Text = Program.character.INT;
            PERTextBox.Text = Program.character.PER;
            CHATextBox.Text = Program.character.CHA;
        }


    }
}
