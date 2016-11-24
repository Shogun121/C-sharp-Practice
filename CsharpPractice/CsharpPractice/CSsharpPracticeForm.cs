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
            MessageBox.Show("Welcome to the Character Creator!" + Environment.NewLine +
                            "Here you can create a completely tailored character");
            race1RadioButton.Checked = false;
            race2RadioButton.Checked = false;
            race3RadioButton.Checked = false;

            clan1RadioButton.Visible = false;
            clan2RadioButton.Visible = false;
            clan3RadioButton.Visible = false;

            faction1RadioButton.Checked = false;
            faction2RadioButton.Checked = false;

            upbringing1RadioButton.Checked = false;
            upbringing2RadioButton.Checked = false;
            upbringing3RadioButton.Checked = false;

            clanGroupBox.Enabled = false;
            factionGroupBox.Enabled = false;
            upbringingGroupBox.Enabled = false;

            //Code Radio Button text in to allow for easy switch out
            race1RadioButton.Text = "Human";
            race2RadioButton.Text = "Dwarf";
            race3RadioButton.Text = "Elf";

            faction1RadioButton.Text = "Alliance";
            faction2RadioButton.Text = "Horde";

            upbringing1RadioButton.Text = "Affluence";
            upbringing2RadioButton.Text = "Working Class";
            upbringing3RadioButton.Text = "Poverty";

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
        }
        /// <summary>
        /// Control Group for all of the upbringings the faction/clan/race/character could be.
        /// When an 'upbringing' is 'selected' output related info to the output display label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upbringingGroupBox_Enter(object sender, EventArgs e)
        {
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
        //---------------------------------------------------------------------------------------
        //RACE RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void race1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race1RadioButton.Checked)
            {
                this.characterStatOutputLabel.Text += "human bio " + "+ 1 Intellect" + Environment.NewLine;

                race2RadioButton.Enabled = false;
                race3RadioButton.Enabled = false;
            }
        }
        private void race2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "dwarf bio " + "+ 1 Strength" + Environment.NewLine;

                race1RadioButton.Enabled = false;
                race3RadioButton.Enabled = false;
            }
        }
        private void race3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race3RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "elf bio " + "+ 1 Agility" + Environment.NewLine;

                race1RadioButton.Enabled = false;
                race2RadioButton.Enabled = false;
            }
        }
        //---------------------------------------------------------------------------------------
        //END  RACE RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            characterStatOutputLabel.Text = "";

            race1RadioButton.Checked = false;
            race2RadioButton.Checked = false;
            race3RadioButton.Checked = false;

            clan1RadioButton.Visible = false;
            clan2RadioButton.Visible = false;
            clan3RadioButton.Visible = false;

            faction1RadioButton.Checked = false;
            faction2RadioButton.Checked = false;

            upbringing1RadioButton.Checked = false;
            upbringing2RadioButton.Checked = false;
            upbringing3RadioButton.Checked = false;

            raceGroupBox.Enabled = true;
            clanGroupBox.Enabled = false;
            factionGroupBox.Enabled = false;
            upbringingGroupBox.Enabled = false;

            //Code Radio Button text in to allow for easy switch out
            race1RadioButton.Text = "Human";
            race2RadioButton.Text = "Dwarf";
            race3RadioButton.Text = "Elf";

            faction1RadioButton.Text = "Alliance";
            faction2RadioButton.Text = "Horde";

            upbringing1RadioButton.Text = "Affluence";
            upbringing2RadioButton.Text = "Working Class";
            upbringing3RadioButton.Text = "Poverty";

        }
        //---------------------------------------------------------------------------------------
        //FACTION RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void faction1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (faction1RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Alliance bio " + "+ 5 Rapport" + Environment.NewLine;

                faction2RadioButton.Enabled = false;
            }
        }

        private void faction2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (faction2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Horde bio " + "+ 5 Intimidation" + Environment.NewLine;

                faction1RadioButton.Enabled = false;
            }
        }
        //---------------------------------------------------------------------------------------
        //END FACTION RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Method used to advance selection of character feature.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (race1RadioButton.Checked || race2RadioButton.Checked || race3RadioButton.Checked)
            {
                if (!clanGroupBox.Enabled && !factionGroupBox.Enabled && !upbringingGroupBox.Enabled)
                {
                    MessageBox.Show("Race Has been selected!" + Environment.NewLine);
                    clanGroupBox.Enabled = true;
                    RaceClanDisplayer();
                    raceGroupBox.Enabled = false;

                }
            }
            if (clan1RadioButton.Checked || clan2RadioButton.Checked || clan3RadioButton.Checked)
            {
                if (!factionGroupBox.Enabled && !upbringingGroupBox.Enabled)
                {
                    MessageBox.Show("Clan Has been selected!" + Environment.NewLine);
                    clanGroupBox.Enabled = false;
                    factionGroupBox.Enabled = true;
                }
            }
            if (faction1RadioButton.Checked || faction2RadioButton.Checked)
            {
                if (!upbringingGroupBox.Enabled)
                {
                    MessageBox.Show("Faction has bene selected!" + Environment.NewLine);
                    factionGroupBox.Enabled = false;
                    upbringingGroupBox.Enabled = true;
                }
            }
            if (upbringing1RadioButton.Checked || upbringing2RadioButton.Checked || upbringing3RadioButton.Checked)
            {
                MessageBox.Show("Character Creation is Complete.");
            }
        }
            /// <summary>
            /// Method to set the clans displayed to ensure race-clan logic
            /// </summary>
        public void RaceClanDisplayer()
            {
                if(race1RadioButton.Checked)
                {
                    clan1RadioButton.Text = "Mountain";
                    clan2RadioButton.Text = "City";
                    clan3RadioButton.Text = "Vagabond";

                    clan1RadioButton.Visible = true;
                    clan2RadioButton.Visible = true;
                    clan3RadioButton.Visible = true;
                }
                if (race2RadioButton.Checked)
                {
                    clan1RadioButton.Text = "Bronzebeard";
                    clan2RadioButton.Text = "Wildhammer";
                    clan3RadioButton.Text = "Dark Iron";

                    clan1RadioButton.Visible = true;
                    clan2RadioButton.Visible = true;
                    clan3RadioButton.Visible = true;
                }
                if (race3RadioButton.Checked)
                {
                    clan1RadioButton.Text = "Dark";
                    clan2RadioButton.Text = "High";
                    clan3RadioButton.Text = "Blood";

                    clan1RadioButton.Visible = true;
                    clan2RadioButton.Visible = true;
                    clan3RadioButton.Visible = true;
                }
            }
        //---------------------------------------------------------------------------------------
        //CLAN RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void clan1RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                //if(race1RadioButton.Checked)
               // {
                    if(clan1RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Mountain bio "+"+ 1 Survivability"+Environment.NewLine;
                        clan2RadioButton.Enabled= false;
                        clan3RadioButton.Enabled= false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "City bio " + "+ 1 Communication" + Environment.NewLine;
                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Vagabond bio " + "+ 1 Persuasion" + Environment.NewLine;
                        clan1RadioButton.Enabled = false;
                        clan2RadioButton.Enabled = false;
                    }
                //}
            }

        private void clan2RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (race2RadioButton.Checked)
                {
                    if (clan1RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Bronzebeard bio " + "+ 1 Blacksmithing" + Environment.NewLine;

                        clan2RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Wildhammer bio " + "+ 1 Combat" + Environment.NewLine;

                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Dark Iron bio " + "+ 1 Dark Magic, - 1 Repuation" + Environment.NewLine;

                        clan1RadioButton.Enabled = false;
                        clan2RadioButton.Enabled = false;
                    }
                }
                
            }

        private void clan3RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (race3RadioButton.Checked)
                {
                    if (clan1RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Dark bio " + "+ 1 Stealth" + Environment.NewLine;

                        clan2RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "High bio " + "+ 1 Intellect" + Environment.NewLine;

                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Blood bio " + "+ 2 Zeal" + Environment.NewLine;

                        clan1RadioButton.Enabled = false;
                        clan2RadioButton.Enabled = false;
                    }
                }
            }
            //---------------------------------------------------------------------------------------
            //END CLAN RADIO BUTTONS
            //---------------------------------------------------------------------------------------

        private void upbringing1RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (upbringing1RadioButton.Checked)
                {
                    characterStatOutputLabel.Text += "Affluence bio " + "+100g, + 1 Elegence";
                }
            }

        private void upbringing2RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (upbringing1RadioButton.Checked)
                {
                    characterStatOutputLabel.Text += "Working class bio " + " + 1 Strength, + 1 Respect";
                }
            }

        private void upbringing3RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (upbringing1RadioButton.Checked)
                {
                    characterStatOutputLabel.Text += "Poverty bio " + " + 1 Humility, - 1 Repuation";
                }
            }
        
      
        
    }
}
/**
 * TO DO
 * 1)Clean up
 * 2)Develope Creation choices, be more orginal.
 * 3)Format output display
 *  i.e Human gets +2 Spirit.
 * 4)Add stat column to display stat changes, but also to allow stat rolls.
 * 5)Maybe add pictureboxes for when radiobuttons are checked.
 * 6)Comment
 * 7)Code Clear() to reset program to Load status
 * 8)Debug
 * 
 * TO IMRPOVE
 * 1)Modularize
 * 2)Make more efficient
 * */