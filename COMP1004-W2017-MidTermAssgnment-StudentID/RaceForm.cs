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
    public partial class RaceForm : Form
    {
        public AbilityForm previousForm;      
        private string _selectedRace;        //instance variables

        private int _StrMode = Convert.ToInt32(Program.character.STR);
        private int _DexMode = Convert.ToInt32(Program.character.DEX);
        private int _EndMode = Convert.ToInt32(Program.character.END);
        private int _IntMode = Convert.ToInt32(Program.character.INT);
        private int _PerMode = Convert.ToInt32(Program.character.PER);
        private int _ChaMode = Convert.ToInt32(Program.character.CHA);


        public RaceForm()
        {
            InitializeComponent();
            this.load();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityValues character = Program.character;

            character.Race = _selectedRace;


            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }
        private void load()
        {
            CharacterPictureBox.Image = Properties.Resources.Human;
           

            RacialBonusTextBox.Text = "Increase all abilities by 10";

        }
        /// <summary>
        /// selecting the radio button for getting the picture and other functionality
        /// of the human radio function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HumanRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.Human;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase all abilities by 10";

            _StrMode = _StrMode + 5;
            _DexMode = _DexMode + 5;
            _EndMode = _EndMode + 5;
            _IntMode = _IntMode + 5;
            _PerMode = _PerMode + 5;
            _ChaMode = _ChaMode + 5;


            this._selectedRace = selectedRace.Text;
        }

        /// <summary>
        /// selecting the radio button for getting the picture and other functionality
        /// of the elf radio function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CharacterPictureBox.Image = Properties.Resources.elf;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DexMode = _DexMode + 20;
            _PerMode = _PerMode + 20;

            this._selectedRace = selectedRace.Text;

        }

        /// <summary>
        /// selecting the radio button for getting the picture and other functionality
        /// ofthe dwarf radio function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.drawf;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _StrMode = _StrMode + 20;
            _PerMode = _PerMode + 20;
            _ChaMode = _ChaMode - 10;
            this._selectedRace = selectedRace.Text;

        }

        /// <summary>
        /// selecting the radio button for getting the picture and other functionality
        /// ofthe halfling radio function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.Halfling;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DexMode = _DexMode + 20;
            _IntMode = _IntMode + 20;
            _StrMode = _StrMode - 10;

            this._selectedRace = selectedRace.Text;

        }

      
    }
}
