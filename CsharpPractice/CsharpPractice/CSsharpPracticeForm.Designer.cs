namespace CsharpPractice
{
    partial class CSsharpPracticeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newCharacterHeaderLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.raceGroupBox = new System.Windows.Forms.GroupBox();
            this.race3RadioButton = new System.Windows.Forms.RadioButton();
            this.race2RadioButton = new System.Windows.Forms.RadioButton();
            this.race1RadioButton = new System.Windows.Forms.RadioButton();
            this.clanGroupBox = new System.Windows.Forms.GroupBox();
            this.clan3RadioButton = new System.Windows.Forms.RadioButton();
            this.clan2RadioButton = new System.Windows.Forms.RadioButton();
            this.clan1RadioButton = new System.Windows.Forms.RadioButton();
            this.factionGroupBox = new System.Windows.Forms.GroupBox();
            this.faction2RadioButton = new System.Windows.Forms.RadioButton();
            this.faction1RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringingGroupBox = new System.Windows.Forms.GroupBox();
            this.upbringing3RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringing2RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringing1RadioButton = new System.Windows.Forms.RadioButton();
            this.characterStatOutputHeaderLabel = new System.Windows.Forms.Label();
            this.characterStatOutputLabel = new System.Windows.Forms.Label();
            this.primaryStatGroupBox = new System.Windows.Forms.GroupBox();
            this.priStat3OutputLabel = new System.Windows.Forms.Label();
            this.priStat2OutputLabel = new System.Windows.Forms.Label();
            this.priStatOutputLabel = new System.Windows.Forms.Label();
            this.priStat3NameLabel = new System.Windows.Forms.Label();
            this.priStat2NameLabel = new System.Windows.Forms.Label();
            this.priStatNameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.proceedButton = new System.Windows.Forms.Button();
            this.priStat4NameLabel = new System.Windows.Forms.Label();
            this.priStat4OutputLabel = new System.Windows.Forms.Label();
            this.secondaryStatGroupBox = new System.Windows.Forms.GroupBox();
            this.secStatNameLabel = new System.Windows.Forms.Label();
            this.secStat2NameLabel = new System.Windows.Forms.Label();
            this.secStat3NameLabel = new System.Windows.Forms.Label();
            this.secStat4NameLabel = new System.Windows.Forms.Label();
            this.secStatOutputLabel = new System.Windows.Forms.Label();
            this.secStat2OutputLabel = new System.Windows.Forms.Label();
            this.secStat3OutputLabel = new System.Windows.Forms.Label();
            this.secStat4OutputLabel = new System.Windows.Forms.Label();
            this.raceGroupBox.SuspendLayout();
            this.clanGroupBox.SuspendLayout();
            this.factionGroupBox.SuspendLayout();
            this.upbringingGroupBox.SuspendLayout();
            this.primaryStatGroupBox.SuspendLayout();
            this.secondaryStatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newCharacterHeaderLabel
            // 
            this.newCharacterHeaderLabel.AutoSize = true;
            this.newCharacterHeaderLabel.Location = new System.Drawing.Point(139, 9);
            this.newCharacterHeaderLabel.Name = "newCharacterHeaderLabel";
            this.newCharacterHeaderLabel.Size = new System.Drawing.Size(78, 13);
            this.newCharacterHeaderLabel.TabIndex = 0;
            this.newCharacterHeaderLabel.Text = "New Character";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 414);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // raceGroupBox
            // 
            this.raceGroupBox.Controls.Add(this.race3RadioButton);
            this.raceGroupBox.Controls.Add(this.race2RadioButton);
            this.raceGroupBox.Controls.Add(this.race1RadioButton);
            this.raceGroupBox.Location = new System.Drawing.Point(13, 34);
            this.raceGroupBox.Name = "raceGroupBox";
            this.raceGroupBox.Size = new System.Drawing.Size(100, 89);
            this.raceGroupBox.TabIndex = 1;
            this.raceGroupBox.TabStop = false;
            this.raceGroupBox.Text = "R&ace";
            this.raceGroupBox.Enter += new System.EventHandler(this.raceGroupBox_Enter);
            // 
            // race3RadioButton
            // 
            this.race3RadioButton.AutoSize = true;
            this.race3RadioButton.Location = new System.Drawing.Point(7, 68);
            this.race3RadioButton.Name = "race3RadioButton";
            this.race3RadioButton.Size = new System.Drawing.Size(57, 17);
            this.race3RadioButton.TabIndex = 2;
            this.race3RadioButton.TabStop = true;
            this.race3RadioButton.Text = "Race3";
            this.race3RadioButton.UseVisualStyleBackColor = true;
            this.race3RadioButton.CheckedChanged += new System.EventHandler(this.race3RadioButton_CheckedChanged);
            // 
            // race2RadioButton
            // 
            this.race2RadioButton.AutoSize = true;
            this.race2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.race2RadioButton.Name = "race2RadioButton";
            this.race2RadioButton.Size = new System.Drawing.Size(57, 17);
            this.race2RadioButton.TabIndex = 1;
            this.race2RadioButton.TabStop = true;
            this.race2RadioButton.Text = "Race2";
            this.race2RadioButton.UseVisualStyleBackColor = true;
            this.race2RadioButton.CheckedChanged += new System.EventHandler(this.race2RadioButton_CheckedChanged);
            // 
            // race1RadioButton
            // 
            this.race1RadioButton.AutoSize = true;
            this.race1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.race1RadioButton.Name = "race1RadioButton";
            this.race1RadioButton.Size = new System.Drawing.Size(57, 17);
            this.race1RadioButton.TabIndex = 0;
            this.race1RadioButton.TabStop = true;
            this.race1RadioButton.Text = "Race1";
            this.race1RadioButton.UseVisualStyleBackColor = true;
            this.race1RadioButton.CheckedChanged += new System.EventHandler(this.race1RadioButton_CheckedChanged);
            // 
            // clanGroupBox
            // 
            this.clanGroupBox.Controls.Add(this.clan3RadioButton);
            this.clanGroupBox.Controls.Add(this.clan2RadioButton);
            this.clanGroupBox.Controls.Add(this.clan1RadioButton);
            this.clanGroupBox.Location = new System.Drawing.Point(13, 130);
            this.clanGroupBox.Name = "clanGroupBox";
            this.clanGroupBox.Size = new System.Drawing.Size(100, 100);
            this.clanGroupBox.TabIndex = 2;
            this.clanGroupBox.TabStop = false;
            this.clanGroupBox.Text = "S&ect/Clan ";
            this.clanGroupBox.Enter += new System.EventHandler(this.clanGroupBox_Enter);
            // 
            // clan3RadioButton
            // 
            this.clan3RadioButton.AutoSize = true;
            this.clan3RadioButton.Location = new System.Drawing.Point(7, 68);
            this.clan3RadioButton.Name = "clan3RadioButton";
            this.clan3RadioButton.Size = new System.Drawing.Size(52, 17);
            this.clan3RadioButton.TabIndex = 2;
            this.clan3RadioButton.TabStop = true;
            this.clan3RadioButton.Text = "Clan3";
            this.clan3RadioButton.UseVisualStyleBackColor = true;
            this.clan3RadioButton.CheckedChanged += new System.EventHandler(this.clan3RadioButton_CheckedChanged);
            // 
            // clan2RadioButton
            // 
            this.clan2RadioButton.AutoSize = true;
            this.clan2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.clan2RadioButton.Name = "clan2RadioButton";
            this.clan2RadioButton.Size = new System.Drawing.Size(52, 17);
            this.clan2RadioButton.TabIndex = 1;
            this.clan2RadioButton.TabStop = true;
            this.clan2RadioButton.Text = "Clan2";
            this.clan2RadioButton.UseVisualStyleBackColor = true;
            this.clan2RadioButton.CheckedChanged += new System.EventHandler(this.clan2RadioButton_CheckedChanged);
            // 
            // clan1RadioButton
            // 
            this.clan1RadioButton.AutoSize = true;
            this.clan1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.clan1RadioButton.Name = "clan1RadioButton";
            this.clan1RadioButton.Size = new System.Drawing.Size(52, 17);
            this.clan1RadioButton.TabIndex = 0;
            this.clan1RadioButton.TabStop = true;
            this.clan1RadioButton.Text = "Clan1";
            this.clan1RadioButton.UseVisualStyleBackColor = true;
            this.clan1RadioButton.CheckedChanged += new System.EventHandler(this.clan1RadioButton_CheckedChanged);
            // 
            // factionGroupBox
            // 
            this.factionGroupBox.Controls.Add(this.faction2RadioButton);
            this.factionGroupBox.Controls.Add(this.faction1RadioButton);
            this.factionGroupBox.Location = new System.Drawing.Point(13, 237);
            this.factionGroupBox.Name = "factionGroupBox";
            this.factionGroupBox.Size = new System.Drawing.Size(99, 64);
            this.factionGroupBox.TabIndex = 3;
            this.factionGroupBox.TabStop = false;
            this.factionGroupBox.Text = "&Faction";
            this.factionGroupBox.Enter += new System.EventHandler(this.factionGroupBox_Enter);
            // 
            // faction2RadioButton
            // 
            this.faction2RadioButton.AutoSize = true;
            this.faction2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.faction2RadioButton.Name = "faction2RadioButton";
            this.faction2RadioButton.Size = new System.Drawing.Size(66, 17);
            this.faction2RadioButton.TabIndex = 1;
            this.faction2RadioButton.TabStop = true;
            this.faction2RadioButton.Text = "Faction2";
            this.faction2RadioButton.UseVisualStyleBackColor = true;
            this.faction2RadioButton.CheckedChanged += new System.EventHandler(this.faction2RadioButton_CheckedChanged);
            // 
            // faction1RadioButton
            // 
            this.faction1RadioButton.AutoSize = true;
            this.faction1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.faction1RadioButton.Name = "faction1RadioButton";
            this.faction1RadioButton.Size = new System.Drawing.Size(66, 17);
            this.faction1RadioButton.TabIndex = 0;
            this.faction1RadioButton.TabStop = true;
            this.faction1RadioButton.Text = "Faction1";
            this.faction1RadioButton.UseVisualStyleBackColor = true;
            this.faction1RadioButton.CheckedChanged += new System.EventHandler(this.faction1RadioButton_CheckedChanged);
            // 
            // upbringingGroupBox
            // 
            this.upbringingGroupBox.Controls.Add(this.upbringing3RadioButton);
            this.upbringingGroupBox.Controls.Add(this.upbringing2RadioButton);
            this.upbringingGroupBox.Controls.Add(this.upbringing1RadioButton);
            this.upbringingGroupBox.Location = new System.Drawing.Point(13, 308);
            this.upbringingGroupBox.Name = "upbringingGroupBox";
            this.upbringingGroupBox.Size = new System.Drawing.Size(99, 100);
            this.upbringingGroupBox.TabIndex = 4;
            this.upbringingGroupBox.TabStop = false;
            this.upbringingGroupBox.Text = "Upbringing";
            this.upbringingGroupBox.Enter += new System.EventHandler(this.upbringingGroupBox_Enter);
            // 
            // upbringing3RadioButton
            // 
            this.upbringing3RadioButton.AutoSize = true;
            this.upbringing3RadioButton.Location = new System.Drawing.Point(7, 68);
            this.upbringing3RadioButton.Name = "upbringing3RadioButton";
            this.upbringing3RadioButton.Size = new System.Drawing.Size(82, 17);
            this.upbringing3RadioButton.TabIndex = 2;
            this.upbringing3RadioButton.TabStop = true;
            this.upbringing3RadioButton.Text = "Upbringing3";
            this.upbringing3RadioButton.UseVisualStyleBackColor = true;
            this.upbringing3RadioButton.CheckedChanged += new System.EventHandler(this.upbringing3RadioButton_CheckedChanged);
            // 
            // upbringing2RadioButton
            // 
            this.upbringing2RadioButton.AutoSize = true;
            this.upbringing2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.upbringing2RadioButton.Name = "upbringing2RadioButton";
            this.upbringing2RadioButton.Size = new System.Drawing.Size(82, 17);
            this.upbringing2RadioButton.TabIndex = 1;
            this.upbringing2RadioButton.TabStop = true;
            this.upbringing2RadioButton.Text = "Upbringing2";
            this.upbringing2RadioButton.UseVisualStyleBackColor = true;
            this.upbringing2RadioButton.CheckedChanged += new System.EventHandler(this.upbringing2RadioButton_CheckedChanged);
            // 
            // upbringing1RadioButton
            // 
            this.upbringing1RadioButton.AutoSize = true;
            this.upbringing1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.upbringing1RadioButton.Name = "upbringing1RadioButton";
            this.upbringing1RadioButton.Size = new System.Drawing.Size(82, 17);
            this.upbringing1RadioButton.TabIndex = 0;
            this.upbringing1RadioButton.TabStop = true;
            this.upbringing1RadioButton.Text = "Upbringing1";
            this.upbringing1RadioButton.UseVisualStyleBackColor = true;
            this.upbringing1RadioButton.CheckedChanged += new System.EventHandler(this.upbringing1RadioButton_CheckedChanged);
            // 
            // characterStatOutputHeaderLabel
            // 
            this.characterStatOutputHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterStatOutputHeaderLabel.Location = new System.Drawing.Point(256, 303);
            this.characterStatOutputHeaderLabel.Name = "characterStatOutputHeaderLabel";
            this.characterStatOutputHeaderLabel.Size = new System.Drawing.Size(135, 18);
            this.characterStatOutputHeaderLabel.TabIndex = 5;
            this.characterStatOutputHeaderLabel.Text = "Character\'s Bio/Stats";
            this.characterStatOutputHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterStatOutputLabel
            // 
            this.characterStatOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterStatOutputLabel.Location = new System.Drawing.Point(256, 328);
            this.characterStatOutputLabel.Name = "characterStatOutputLabel";
            this.characterStatOutputLabel.Size = new System.Drawing.Size(135, 97);
            this.characterStatOutputLabel.TabIndex = 6;
            // 
            // primaryStatGroupBox
            // 
            this.primaryStatGroupBox.Controls.Add(this.priStat4OutputLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStat4NameLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStat3OutputLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStat2OutputLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStatOutputLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStat3NameLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStat2NameLabel);
            this.primaryStatGroupBox.Controls.Add(this.priStatNameLabel);
            this.primaryStatGroupBox.Location = new System.Drawing.Point(133, 34);
            this.primaryStatGroupBox.Name = "primaryStatGroupBox";
            this.primaryStatGroupBox.Size = new System.Drawing.Size(116, 119);
            this.primaryStatGroupBox.TabIndex = 7;
            this.primaryStatGroupBox.TabStop = false;
            this.primaryStatGroupBox.Text = "Primary Stats";
            this.primaryStatGroupBox.Enter += new System.EventHandler(this.primaryStatGroupBox_Enter);
            // 
            // priStat3OutputLabel
            // 
            this.priStat3OutputLabel.AutoSize = true;
            this.priStat3OutputLabel.Location = new System.Drawing.Point(94, 70);
            this.priStat3OutputLabel.Name = "priStat3OutputLabel";
            this.priStat3OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.priStat3OutputLabel.TabIndex = 5;
            this.priStat3OutputLabel.Text = "0";
            // 
            // priStat2OutputLabel
            // 
            this.priStat2OutputLabel.AutoSize = true;
            this.priStat2OutputLabel.Location = new System.Drawing.Point(94, 45);
            this.priStat2OutputLabel.Name = "priStat2OutputLabel";
            this.priStat2OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.priStat2OutputLabel.TabIndex = 4;
            this.priStat2OutputLabel.Text = "0";
            // 
            // priStatOutputLabel
            // 
            this.priStatOutputLabel.AutoSize = true;
            this.priStatOutputLabel.Location = new System.Drawing.Point(94, 20);
            this.priStatOutputLabel.Name = "priStatOutputLabel";
            this.priStatOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.priStatOutputLabel.TabIndex = 3;
            this.priStatOutputLabel.Text = "0";
            // 
            // priStat3NameLabel
            // 
            this.priStat3NameLabel.AutoSize = true;
            this.priStat3NameLabel.Location = new System.Drawing.Point(9, 70);
            this.priStat3NameLabel.Name = "priStat3NameLabel";
            this.priStat3NameLabel.Size = new System.Drawing.Size(44, 13);
            this.priStat3NameLabel.TabIndex = 2;
            this.priStat3NameLabel.Text = "Intellect";
            // 
            // priStat2NameLabel
            // 
            this.priStat2NameLabel.AutoSize = true;
            this.priStat2NameLabel.Location = new System.Drawing.Point(9, 45);
            this.priStat2NameLabel.Name = "priStat2NameLabel";
            this.priStat2NameLabel.Size = new System.Drawing.Size(34, 13);
            this.priStat2NameLabel.TabIndex = 1;
            this.priStat2NameLabel.Text = "Agility";
            // 
            // priStatNameLabel
            // 
            this.priStatNameLabel.AutoSize = true;
            this.priStatNameLabel.Location = new System.Drawing.Point(9, 20);
            this.priStatNameLabel.Name = "priStatNameLabel";
            this.priStatNameLabel.Size = new System.Drawing.Size(47, 13);
            this.priStatNameLabel.TabIndex = 0;
            this.priStatNameLabel.Text = "Strength";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 414);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(175, 413);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 8;
            this.proceedButton.Text = "P&roceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // priStat4NameLabel
            // 
            this.priStat4NameLabel.AutoSize = true;
            this.priStat4NameLabel.Location = new System.Drawing.Point(9, 95);
            this.priStat4NameLabel.Name = "priStat4NameLabel";
            this.priStat4NameLabel.Size = new System.Drawing.Size(48, 13);
            this.priStat4NameLabel.TabIndex = 6;
            this.priStat4NameLabel.Text = "Fortitude";
            // 
            // priStat4OutputLabel
            // 
            this.priStat4OutputLabel.AutoSize = true;
            this.priStat4OutputLabel.Location = new System.Drawing.Point(94, 95);
            this.priStat4OutputLabel.Name = "priStat4OutputLabel";
            this.priStat4OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.priStat4OutputLabel.TabIndex = 7;
            this.priStat4OutputLabel.Text = "0";
            // 
            // secondaryStatGroupBox
            // 
            this.secondaryStatGroupBox.Controls.Add(this.secStat4OutputLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStat3OutputLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStat2OutputLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStatOutputLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStat4NameLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStat3NameLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStat2NameLabel);
            this.secondaryStatGroupBox.Controls.Add(this.secStatNameLabel);
            this.secondaryStatGroupBox.Location = new System.Drawing.Point(133, 160);
            this.secondaryStatGroupBox.Name = "secondaryStatGroupBox";
            this.secondaryStatGroupBox.Size = new System.Drawing.Size(117, 100);
            this.secondaryStatGroupBox.TabIndex = 9;
            this.secondaryStatGroupBox.TabStop = false;
            this.secondaryStatGroupBox.Text = "Secondary Stats";
            // 
            // secStatNameLabel
            // 
            this.secStatNameLabel.AutoSize = true;
            this.secStatNameLabel.Location = new System.Drawing.Point(7, 20);
            this.secStatNameLabel.Name = "secStatNameLabel";
            this.secStatNameLabel.Size = new System.Drawing.Size(53, 13);
            this.secStatNameLabel.TabIndex = 0;
            this.secStatNameLabel.Text = "Willpower";
            // 
            // secStat2NameLabel
            // 
            this.secStat2NameLabel.AutoSize = true;
            this.secStat2NameLabel.Location = new System.Drawing.Point(7, 40);
            this.secStat2NameLabel.Name = "secStat2NameLabel";
            this.secStat2NameLabel.Size = new System.Drawing.Size(60, 13);
            this.secStat2NameLabel.TabIndex = 1;
            this.secStat2NameLabel.Text = "Intimidation";
            // 
            // secStat3NameLabel
            // 
            this.secStat3NameLabel.AutoSize = true;
            this.secStat3NameLabel.Location = new System.Drawing.Point(7, 60);
            this.secStat3NameLabel.Name = "secStat3NameLabel";
            this.secStat3NameLabel.Size = new System.Drawing.Size(48, 13);
            this.secStat3NameLabel.TabIndex = 2;
            this.secStat3NameLabel.Text = "Empathy";
            // 
            // secStat4NameLabel
            // 
            this.secStat4NameLabel.AutoSize = true;
            this.secStat4NameLabel.Location = new System.Drawing.Point(7, 80);
            this.secStat4NameLabel.Name = "secStat4NameLabel";
            this.secStat4NameLabel.Size = new System.Drawing.Size(47, 13);
            this.secStat4NameLabel.TabIndex = 3;
            this.secStat4NameLabel.Text = "Respect";
            // 
            // secStatOutputLabel
            // 
            this.secStatOutputLabel.AutoSize = true;
            this.secStatOutputLabel.Location = new System.Drawing.Point(94, 20);
            this.secStatOutputLabel.Name = "secStatOutputLabel";
            this.secStatOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.secStatOutputLabel.TabIndex = 4;
            this.secStatOutputLabel.Text = "0";
            // 
            // secStat2OutputLabel
            // 
            this.secStat2OutputLabel.AutoSize = true;
            this.secStat2OutputLabel.Location = new System.Drawing.Point(94, 39);
            this.secStat2OutputLabel.Name = "secStat2OutputLabel";
            this.secStat2OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.secStat2OutputLabel.TabIndex = 5;
            this.secStat2OutputLabel.Text = "0";
            // 
            // secStat3OutputLabel
            // 
            this.secStat3OutputLabel.AutoSize = true;
            this.secStat3OutputLabel.Location = new System.Drawing.Point(94, 58);
            this.secStat3OutputLabel.Name = "secStat3OutputLabel";
            this.secStat3OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.secStat3OutputLabel.TabIndex = 6;
            this.secStat3OutputLabel.Text = "0";
            // 
            // secStat4OutputLabel
            // 
            this.secStat4OutputLabel.AutoSize = true;
            this.secStat4OutputLabel.Location = new System.Drawing.Point(94, 77);
            this.secStat4OutputLabel.Name = "secStat4OutputLabel";
            this.secStat4OutputLabel.Size = new System.Drawing.Size(13, 13);
            this.secStat4OutputLabel.TabIndex = 7;
            this.secStat4OutputLabel.Text = "0";
            // 
            // CSsharpPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 434);
            this.Controls.Add(this.secondaryStatGroupBox);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.primaryStatGroupBox);
            this.Controls.Add(this.characterStatOutputLabel);
            this.Controls.Add(this.characterStatOutputHeaderLabel);
            this.Controls.Add(this.upbringingGroupBox);
            this.Controls.Add(this.factionGroupBox);
            this.Controls.Add(this.clanGroupBox);
            this.Controls.Add(this.raceGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newCharacterHeaderLabel);
            this.Name = "CSsharpPracticeForm";
            this.Text = "Character Creation";
            this.Load += new System.EventHandler(this.CSsharpPracticeForm_Load);
            this.raceGroupBox.ResumeLayout(false);
            this.raceGroupBox.PerformLayout();
            this.clanGroupBox.ResumeLayout(false);
            this.clanGroupBox.PerformLayout();
            this.factionGroupBox.ResumeLayout(false);
            this.factionGroupBox.PerformLayout();
            this.upbringingGroupBox.ResumeLayout(false);
            this.upbringingGroupBox.PerformLayout();
            this.primaryStatGroupBox.ResumeLayout(false);
            this.primaryStatGroupBox.PerformLayout();
            this.secondaryStatGroupBox.ResumeLayout(false);
            this.secondaryStatGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCharacterHeaderLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox raceGroupBox;
        private System.Windows.Forms.RadioButton race3RadioButton;
        private System.Windows.Forms.RadioButton race2RadioButton;
        private System.Windows.Forms.RadioButton race1RadioButton;
        private System.Windows.Forms.GroupBox clanGroupBox;
        private System.Windows.Forms.GroupBox factionGroupBox;
        private System.Windows.Forms.RadioButton faction2RadioButton;
        private System.Windows.Forms.RadioButton faction1RadioButton;
        private System.Windows.Forms.GroupBox upbringingGroupBox;
        private System.Windows.Forms.RadioButton upbringing3RadioButton;
        private System.Windows.Forms.RadioButton upbringing2RadioButton;
        private System.Windows.Forms.RadioButton upbringing1RadioButton;
        private System.Windows.Forms.Label characterStatOutputHeaderLabel;
        private System.Windows.Forms.Label characterStatOutputLabel;
        private System.Windows.Forms.GroupBox primaryStatGroupBox;
        private System.Windows.Forms.Label priStat2NameLabel;
        private System.Windows.Forms.Label priStatNameLabel;
        private System.Windows.Forms.Label priStat3OutputLabel;
        private System.Windows.Forms.Label priStat2OutputLabel;
        private System.Windows.Forms.Label priStatOutputLabel;
        private System.Windows.Forms.Label priStat3NameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton clan3RadioButton;
        private System.Windows.Forms.RadioButton clan2RadioButton;
        private System.Windows.Forms.RadioButton clan1RadioButton;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label priStat4OutputLabel;
        private System.Windows.Forms.Label priStat4NameLabel;
        private System.Windows.Forms.GroupBox secondaryStatGroupBox;
        private System.Windows.Forms.Label secStat4OutputLabel;
        private System.Windows.Forms.Label secStat3OutputLabel;
        private System.Windows.Forms.Label secStat2OutputLabel;
        private System.Windows.Forms.Label secStatOutputLabel;
        private System.Windows.Forms.Label secStat4NameLabel;
        private System.Windows.Forms.Label secStat3NameLabel;
        private System.Windows.Forms.Label secStat2NameLabel;
        private System.Windows.Forms.Label secStatNameLabel;
    }
}

