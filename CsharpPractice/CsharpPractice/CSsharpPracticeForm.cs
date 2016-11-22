using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPractice
{
    public partial class CSsharpPracticeForm : Form
    {
        public CSsharpPracticeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method used to close the form application, canceling character creation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO :Add a Y/N decision dialog box for saftey.
            MessageBox.Show("Character was not created.");
            this.Close();
        }
        /// <summary>
        /// The method being called on Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSsharpPracticeForm_Load(object sender, EventArgs e)
        {
            //Display message to users stating the purpose of the application.
            MessageBox.Show("Welcome to the Character Creator!"+ Environment.NewLine+
                            "Here you can create a completely tailored character");

            //TO DO :Write Button text here instead of on the form to allow for easy change.
        }
        /// <summary>
        /// Control Group for all of the races the character could be.
        /// When a 'race' is 'selected' output related info to the output display label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void raceGroupBox_Enter(object sender, EventArgs e)
        {
            if(race1RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "human bio " + "racial stats/perks";
            }
            if (race2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "dwarf bio " + "racial stats/perks";
            }
            if (race3RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "elf bio " + "racial stats/perks";
            }
        }

        /// <summary>
        /// Control Group for all of the sects/clans the race could be.
        /// When a 'sect/clan' is 'selected' output related info to the output display label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clanGroupBox_Enter(object sender, EventArgs e)
        {
            // TO DO: relate sect/clans to each race.

        }

        /// <summary>
        /// Control Group for all of the factions the race/clan/character could be.
        /// When a 'faction' is 'selected' output related info to the output display label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void factionGroupBox_Enter(object sender, EventArgs e)
        {
            if(faction1RadioButton.Checked)
            {
                characterStatOutputLabel.Text+="Alliance bio "+"Faction statistics";
            }
            if (faction2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Horde bio " + "Faction statistics";
            }
        }
        /// <summary>
        /// Control Group for all of the upbringings the faction/clan/race/character could be.
        /// When an 'upbringing' is 'selected' output related info to the output display label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upbringingGroupBox_Enter(object sender, EventArgs e)
        {
            if(upbringing1RadioButton.Checked)
            {
                characterStatOutputLabel.Text="Affluence bio "+ " stats/perks";
            }
            if (upbringing1RadioButton.Checked)
            {
                characterStatOutputLabel.Text = "Working class bio " + " stats/perks";
            }
            if (upbringing1RadioButton.Checked)
            {
                characterStatOutputLabel.Text = "Poverty bio " + " stats/perks";
            }
        }
        /// <summary>
        /// Control Group to keep track of Primary Stat changes and evetual extra point
        /// distribution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void primaryStatGroupBox_Enter(object sender, EventArgs e)
        {
            //TO DO :Make responsive to creation selections.
            //TO DO :Notify user that they have 'point(s)' to spend on their 'primary' stats.
        }
    }
}
/**
 * TO DO
 * 1)Configure Radio Buttons to account for cross selection within same groupbox 
 *  i.e. User selecting Human and it displaying, then selecting Dwarf. LOOK INTO FIXING THAT PROBLEM
 * 2)Develope Creation choices, be more orginal.
 * 3)Format output display
 *  i.e Human gets +2 Spirit.
 * 4)Add stat column to display stat changes, but also to allow stat rolls.
 * 5)Maybe add pictureboxes for when radiobuttons are checked.
 * */