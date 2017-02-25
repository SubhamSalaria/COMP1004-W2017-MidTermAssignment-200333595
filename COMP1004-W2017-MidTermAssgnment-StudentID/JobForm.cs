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
    public partial class JobForm : Form
    {
        private string _jobSelected;
        public RaceForm previousForm;

        private int _soldierHealth = 30;
        private int _rogueHealth = 28;
        private int _magickerHealth = 15;
        private int _cultistHealth = 24;


        private int _DexHealthMode = Convert.ToInt32(Program.character.DEX);
        private int _EndHealthMode = Convert.ToInt32(Program.character.END);
        private int _IntHealthMode = Convert.ToInt32(Program.character.INT);
        private int _ChaHealthMode = Convert.ToInt32(Program.character.CHA);



        public JobForm()
        {
            InitializeComponent();
        }

         //next button will generate the next form and close the current form
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;


            character.Job = _jobSelected;


            character.Health = healthPointTextBox.Text;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_soldierHealth + _EndHealthMode).ToString();
        }

        //radio button for selecting the rouge health points
        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_rogueHealth + _DexHealthMode).ToString();
        }
           
        //radio button for selecting the magicker health points
        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_magickerHealth + _IntHealthMode).ToString();
        }
        
        //radio button for selecting the cultist health points
        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthPointTextBox.Text = (_cultistHealth + _ChaHealthMode).ToString();
        }
    }
}
