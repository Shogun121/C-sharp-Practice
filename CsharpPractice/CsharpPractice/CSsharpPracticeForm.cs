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
            MessageBox.Show("Character was not created.","Character Creation Exit");
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
            MessageBox.Show("Welcome to the Character Creator!","Character Creation Setup" + Environment.NewLine +
                            "Here you can create a completely tailored character");
            //reset description string
            characterStatOutputLabel.Text = "";
            //Reset all of the radio buttons to runtime.
            ClearRadioButtons();
            //Reset all of the groupboxes to runtime.
            ClearGroupBoxes();
            //Reset stat values to runtime.
            ClearStats();

            //clan1RadioButton.Visible = false;
            //clan2RadioButton.Visible = false;
            //clan3RadioButton.Visible = false;

            //faction1RadioButton.Checked = false;
            //faction2RadioButton.Checked = false;

            //upbringing1RadioButton.Checked = false;
            //upbringing2RadioButton.Checked = false;
            //upbringing3RadioButton.Checked = false;

            //clanGroupBox.Enabled = false;
            //factionGroupBox.Enabled = false;
            //upbringingGroupBox.Enabled = false;

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
        private void raceGroupBox_Enter(object sender, EventArgs e)
        {
        }
        private void clanGroupBox_Enter(object sender, EventArgs e)
        {
            // TO DO: relate sect/clans to each race.

        }
        private void factionGroupBox_Enter(object sender, EventArgs e)
        {
        }
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
            //TO DO :Notify user that they have 'point(s)' to spend on their 'primary' stats.
        }
        //---------------------------------------------------------------------------------------
        //RACE RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void race1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race1RadioButton.Checked)
            {
                //text output to the description box
                this.characterStatOutputLabel.Text += "Humanity " + Environment.NewLine+
                                                "A species strong of will and prejudice. "+
                                                "Capable and cautious, undertaking tasks borne "+
                                                "of necessity to ensure their survival."+
                                                Environment.NewLine;
                //Stat updates

                //pri Stat set
                UpdateStatValue(priStatOutputLabel, 5);
                UpdateStatValue(priStat2OutputLabel, 5);
                UpdateStatValue(priStat3OutputLabel, 6);
                UpdateStatValue(priStat4OutputLabel, 10);

                //sec stat set
                UpdateStatValue(secStatOutputLabel, 20);
                UpdateStatValue(secStat2OutputLabel, 15);
                UpdateStatValue(secStat3OutputLabel, 15);
                UpdateStatValue(secStat4OutputLabel, 5);

                //Disable other races to prevent cross selection
                race2RadioButton.Enabled = false;
                race3RadioButton.Enabled = false;
            }
        }
        private void race2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Dwarf"+ Environment.NewLine+
                                                 "A species intereted first and forement "+
                                                 "in wealth and status."+
                                                 "Dwarves are divided into castes socially and "+
                                                 "economically"+Environment.NewLine;

                //Set Pri Stats
                UpdateStatValue(priStatOutputLabel,10);
                UpdateStatValue(priStat2OutputLabel, 5);
                UpdateStatValue(priStat3OutputLabel, 3);
                UpdateStatValue(priStat4OutputLabel, 15);

                //set Sec Stats
                UpdateStatValue(secStatOutputLabel, 5);
                UpdateStatValue(secStat2OutputLabel, 10);
                UpdateStatValue(secStat3OutputLabel, 5);
                UpdateStatValue(secStat4OutputLabel, 5);

                race1RadioButton.Enabled = false;
                race3RadioButton.Enabled = false;
            }
        }
        private void race3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (race3RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Elf " + Environment.NewLine+
                                                 "A species of untold ages, that are "+
                                                 "even tempered, fair, patient, and mindful "+
                                                 "of their impact on others"+Environment.NewLine;

                //Set Pri Stats
                UpdateStatValue(priStatOutputLabel,10);
                UpdateStatValue(priStat2OutputLabel, 10);
                UpdateStatValue(priStat3OutputLabel, 20);
                UpdateStatValue(priStat4OutputLabel, 10);

                //Set Sec Stats
                UpdateStatValue(secStatOutputLabel,10);
                UpdateStatValue(secStat2OutputLabel, 10);
                UpdateStatValue(secStat3OutputLabel, 20);
                UpdateStatValue(secStat4OutputLabel, 15);

                race1RadioButton.Enabled = false;
                race2RadioButton.Enabled = false;
            }
        }
        //---------------------------------------------------------------------------------------
        //END  RACE RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void clearButton_Click(object sender, EventArgs e)
        {
            //reset description string
            characterStatOutputLabel.Text = "";
            //Reset all of the radio buttons to runtime.
            ClearRadioButtons();
            //Reset all of the groupboxes to runtime.
            ClearGroupBoxes();
            //Reset stat values to runtime.
            ClearStats();
        }
        private void ClearRadioButtons()
        {
            ClearRaceRadioButtons();
            ClearClanRadioButtons();
            ClearFactionRadioButtons();
            ClearUpbringingRadioButtons();           
        }
        private void ClearRaceRadioButtons()
        {
            //clear race buttons
            race1RadioButton.Checked = false;
            race2RadioButton.Checked = false;
            race3RadioButton.Checked = false;

            race1RadioButton.Enabled = true;
            race2RadioButton.Enabled = true;
            race3RadioButton.Enabled = true;
        }
        private void ClearClanRadioButtons()
        {
            //clear clan buttons
            clan1RadioButton.Visible = false;
            clan2RadioButton.Visible = false;
            clan3RadioButton.Visible = false;

            clan1RadioButton.Enabled = true;
            clan2RadioButton.Enabled = true;
            clan3RadioButton.Enabled = true;

            clan1RadioButton.Checked = false;
            clan2RadioButton.Checked = false;
            clan3RadioButton.Checked = false;
        }
        private void ClearFactionRadioButtons()
        {
            //clear faction buttons
            faction1RadioButton.Checked = false;
            faction2RadioButton.Checked = false;

            faction1RadioButton.Enabled = true;
            faction2RadioButton.Enabled = true;
        }
        private void ClearUpbringingRadioButtons()
        {
            //clear upbringing buttons
            upbringing1RadioButton.Checked = false;
            upbringing2RadioButton.Checked = false;
            upbringing3RadioButton.Checked = false;

            upbringing1RadioButton.Enabled = true;
            upbringing2RadioButton.Enabled = true;
            upbringing3RadioButton.Enabled = true;
        }
        private void ClearGroupBoxes()
        {
            //reset groupbox accessibility
            raceGroupBox.Enabled = true;
            clanGroupBox.Enabled = false;
            factionGroupBox.Enabled = false;
            upbringingGroupBox.Enabled = false;
        }
        //---------------------------------------------------------------------------------------
        //FACTION RADIO BUTTONS
        //---------------------------------------------------------------------------------------
        private void faction1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (faction1RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Alliance"+ Environment.NewLine+
                                                 "The alliance is comprised of species "+
                                                 "commiting to fair treatment of each other"+
                                                 Environment.NewLine;

                //Updating the "Respect" stat
                UpdateStatValue(secStat4OutputLabel, 5);

                faction2RadioButton.Enabled = false;
            }
        }

        private void faction2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (faction2RadioButton.Checked)
            {
                characterStatOutputLabel.Text += "Horde" + Environment.NewLine+
                                                 "A loose collaboration of organizations "+
                                                 "simlpy striving for similar goals."+                   
                                                 Environment.NewLine;

                //Update Stats
                UpdateStatValue(secStat2OutputLabel,5);

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
                    MessageBox.Show("Race Has been selected!","Race Selection" + Environment.NewLine);
                    clanGroupBox.Enabled = true;
                    RaceClanDisplayer();
                    raceGroupBox.Enabled = false;

                }
            }
            if (clan1RadioButton.Checked || clan2RadioButton.Checked || clan3RadioButton.Checked)
            {
                if (!factionGroupBox.Enabled && !upbringingGroupBox.Enabled)
                {
                    MessageBox.Show("Clan Has been selected!","Clan Selection" + Environment.NewLine);
                    clanGroupBox.Enabled = false;
                    factionGroupBox.Enabled = true;
                }
            }
            if (faction1RadioButton.Checked || faction2RadioButton.Checked)
            {
                if (!upbringingGroupBox.Enabled)
                {
                    MessageBox.Show("Faction has been selected!","Faction Selection" + Environment.NewLine);
                    factionGroupBox.Enabled = false;
                    upbringingGroupBox.Enabled = true;
                }
            }
            if (upbringing1RadioButton.Checked || upbringing2RadioButton.Checked || upbringing3RadioButton.Checked)
            {
                MessageBox.Show("Character Creation is Complete.","Character Creation");
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
                if(race1RadioButton.Checked)
                {
                    if(clan1RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Mountain "+Environment.NewLine+
                                                         "Mountain Humans are rugged and are "+
                                                         "accustomed to hard living"+ Environment.NewLine;

                        UpdateStatValue(secStatOutputLabel,2);

                        clan2RadioButton.Enabled= false;
                        clan3RadioButton.Enabled= false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "City" + Environment.NewLine+
                                                         "Human Citydwellers are given a great "+
                                                         "deal of respect, most cities are plagued "+
                                                         "by crime lords and political machines. "+
                                                         Environment.NewLine;

                        UpdateStatValue(secStat4OutputLabel,2);

                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Vagabond" + Environment.NewLine+
                                                         "Human Vagabonds are abrasive, they "+
                                                         "care little for the well-beling of "+
                                                         "others and wouldn't hesitate to sell "+
                                                         "someone out to save their own skin. "+
                                                         Environment.NewLine;

                        UpdateStatValue(secStat2OutputLabel,2);

                        clan1RadioButton.Enabled = false;
                        clan2RadioButton.Enabled = false;
                    }
                }
            }

        private void clan2RadioButton_CheckedChanged(object sender, EventArgs e)
            {
                if (race2RadioButton.Checked)
                {
                    if (clan1RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Bronzebeard"+ Environment.NewLine+
                                                         "Theese dwarves are masters of metalworking "+
                                                         Environment.NewLine;

                        UpdateStatValue(priStatOutputLabel,2);

                        clan2RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Wildhammer" + Environment.NewLine+
                                                         "These dwarves are more attuned to elements"+
                                                         Environment.NewLine;

                        UpdateStatValue(secStat4OutputLabel, 2);


                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Dark Iron"+ Environment.NewLine+
                                                         "These dwarves were exiled from society for their traditions"
                                                         +Environment.NewLine;

                        UpdateStatValue(priStat3OutputLabel, 2);

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
                        characterStatOutputLabel.Text += "Dark"+ Environment.NewLine+
                                                         "These elves are isolationists, and pious "+
                                                         "but also capable of immense stealth and nature might."+
                                                         Environment.NewLine;

                        UpdateStatValue(priStat2OutputLabel,2);

                        clan2RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan2RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "High"+ Environment.NewLine+
                                                         "These elves are magically augmented by their power source "+
                                                         "the sunwell. Civillized, capable, and wise."+
                                                         Environment.NewLine;

                        UpdateStatValue(priStat3OutputLabel,2);

                        clan1RadioButton.Enabled = false;
                        clan3RadioButton.Enabled = false;
                    }
                    if (clan3RadioButton.Checked)
                    {
                        characterStatOutputLabel.Text += "Blood"+ Environment.NewLine+
                                                         "These elves are the surviors of a pseudo-ethnic purge "+
                                                         "Deprived of their magical fount, they hunger for a replacement "+
                                                         "source of magic to sate their hunger. " +Environment.NewLine;

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
        /// <summary>
        /// Method used to update the text property of the output labels with current
        /// stat amounts.
        /// </summary>
        /// <param name="Label">The Output Label in question</param>
        /// <param name="Number">The stat amount needing to be set</param>
        private void UpdateStatValue(Label Label, int Number)
        {
            //Parse the old stat amount and roll it into the new amount(totl=old+new)
            Number += int.Parse(Label.Text);
            //Update the Label's text with the current stat amount.
            Label.Text = Number.ToString();
        }
        /// <summary>
        /// Method to clear the stats when a char is cleared/start-up occurs.
        /// </summary>
        private void ClearStats()
        {
            ClearPriStats();
            ClearSecStats();
        }
        private void ClearPriStats()
        {
            //Pri Stat Reset
            priStatOutputLabel.Text = 0.ToString();
            priStat2OutputLabel.Text = 0.ToString();
            priStat3OutputLabel.Text = 0.ToString();
            priStat4OutputLabel.Text = 0.ToString();
        }
        private void ClearSecStats()
        {
            //Sec Stat Reset
            secStatOutputLabel.Text = 0.ToString();
            secStat2OutputLabel.Text = 0.ToString();
            secStat3OutputLabel.Text = 0.ToString();
            secStat4OutputLabel.Text = 0.ToString();
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
 * 9)Fix bug with display Clan 2 and 3 for Human.
 * 
 * TO IMRPOVE
 * 1)Modularize
 * 2)Make more efficient
 * */