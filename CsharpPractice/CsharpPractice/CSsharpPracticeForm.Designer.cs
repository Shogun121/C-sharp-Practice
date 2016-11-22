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
            this.race1RadioButton = new System.Windows.Forms.RadioButton();
            this.race2RadioButton = new System.Windows.Forms.RadioButton();
            this.race3RadioButton = new System.Windows.Forms.RadioButton();
            this.clanGroupBox = new System.Windows.Forms.GroupBox();
            this.factionGroupBox = new System.Windows.Forms.GroupBox();
            this.faction1RadioButton = new System.Windows.Forms.RadioButton();
            this.faction2RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringingGroupBox = new System.Windows.Forms.GroupBox();
            this.upbringing1RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringing2RadioButton = new System.Windows.Forms.RadioButton();
            this.upbringing3RadioButton = new System.Windows.Forms.RadioButton();
            this.characterStatOutputHeaderLabel = new System.Windows.Forms.Label();
            this.characterStatOutputLabel = new System.Windows.Forms.Label();
            this.raceGroupBox.SuspendLayout();
            this.factionGroupBox.SuspendLayout();
            this.upbringingGroupBox.SuspendLayout();
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
            this.exitButton.TabIndex = 4;
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
            this.raceGroupBox.TabIndex = 0;
            this.raceGroupBox.TabStop = false;
            this.raceGroupBox.Text = "R&aces";
            this.raceGroupBox.Enter += new System.EventHandler(this.raceGroupBox_Enter);
            // 
            // race1RadioButton
            // 
            this.race1RadioButton.AutoSize = true;
            this.race1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.race1RadioButton.Name = "race1RadioButton";
            this.race1RadioButton.Size = new System.Drawing.Size(59, 17);
            this.race1RadioButton.TabIndex = 0;
            this.race1RadioButton.TabStop = true;
            this.race1RadioButton.Text = "Human";
            this.race1RadioButton.UseVisualStyleBackColor = true;
            // 
            // race2RadioButton
            // 
            this.race2RadioButton.AutoSize = true;
            this.race2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.race2RadioButton.Name = "race2RadioButton";
            this.race2RadioButton.Size = new System.Drawing.Size(53, 17);
            this.race2RadioButton.TabIndex = 1;
            this.race2RadioButton.TabStop = true;
            this.race2RadioButton.Text = "Dwarf";
            this.race2RadioButton.UseVisualStyleBackColor = true;
            // 
            // race3RadioButton
            // 
            this.race3RadioButton.AutoSize = true;
            this.race3RadioButton.Location = new System.Drawing.Point(7, 68);
            this.race3RadioButton.Name = "race3RadioButton";
            this.race3RadioButton.Size = new System.Drawing.Size(37, 17);
            this.race3RadioButton.TabIndex = 2;
            this.race3RadioButton.TabStop = true;
            this.race3RadioButton.Text = "Elf";
            this.race3RadioButton.UseVisualStyleBackColor = true;
            // 
            // clanGroupBox
            // 
            this.clanGroupBox.Location = new System.Drawing.Point(13, 130);
            this.clanGroupBox.Name = "clanGroupBox";
            this.clanGroupBox.Size = new System.Drawing.Size(100, 100);
            this.clanGroupBox.TabIndex = 1;
            this.clanGroupBox.TabStop = false;
            this.clanGroupBox.Text = "S&ect/Clan ";
            this.clanGroupBox.Enter += new System.EventHandler(this.clanGroupBox_Enter);
            // 
            // factionGroupBox
            // 
            this.factionGroupBox.Controls.Add(this.faction2RadioButton);
            this.factionGroupBox.Controls.Add(this.faction1RadioButton);
            this.factionGroupBox.Location = new System.Drawing.Point(13, 237);
            this.factionGroupBox.Name = "factionGroupBox";
            this.factionGroupBox.Size = new System.Drawing.Size(99, 64);
            this.factionGroupBox.TabIndex = 2;
            this.factionGroupBox.TabStop = false;
            this.factionGroupBox.Text = "&Faction";
            this.factionGroupBox.Enter += new System.EventHandler(this.factionGroupBox_Enter);
            // 
            // faction1RadioButton
            // 
            this.faction1RadioButton.AutoSize = true;
            this.faction1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.faction1RadioButton.Name = "faction1RadioButton";
            this.faction1RadioButton.Size = new System.Drawing.Size(62, 17);
            this.faction1RadioButton.TabIndex = 0;
            this.faction1RadioButton.TabStop = true;
            this.faction1RadioButton.Text = "Alliance";
            this.faction1RadioButton.UseVisualStyleBackColor = true;
            // 
            // faction2RadioButton
            // 
            this.faction2RadioButton.AutoSize = true;
            this.faction2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.faction2RadioButton.Name = "faction2RadioButton";
            this.faction2RadioButton.Size = new System.Drawing.Size(54, 17);
            this.faction2RadioButton.TabIndex = 1;
            this.faction2RadioButton.TabStop = true;
            this.faction2RadioButton.Text = "Horde";
            this.faction2RadioButton.UseVisualStyleBackColor = true;
            // 
            // upbringingGroupBox
            // 
            this.upbringingGroupBox.Controls.Add(this.upbringing3RadioButton);
            this.upbringingGroupBox.Controls.Add(this.upbringing2RadioButton);
            this.upbringingGroupBox.Controls.Add(this.upbringing1RadioButton);
            this.upbringingGroupBox.Location = new System.Drawing.Point(13, 308);
            this.upbringingGroupBox.Name = "upbringingGroupBox";
            this.upbringingGroupBox.Size = new System.Drawing.Size(99, 100);
            this.upbringingGroupBox.TabIndex = 3;
            this.upbringingGroupBox.TabStop = false;
            this.upbringingGroupBox.Text = "Upbringing";
            this.upbringingGroupBox.Enter += new System.EventHandler(this.upbringingGroupBox_Enter);
            // 
            // upbringing1RadioButton
            // 
            this.upbringing1RadioButton.AutoSize = true;
            this.upbringing1RadioButton.Location = new System.Drawing.Point(7, 20);
            this.upbringing1RadioButton.Name = "upbringing1RadioButton";
            this.upbringing1RadioButton.Size = new System.Drawing.Size(70, 17);
            this.upbringing1RadioButton.TabIndex = 0;
            this.upbringing1RadioButton.TabStop = true;
            this.upbringing1RadioButton.Text = "Affluence";
            this.upbringing1RadioButton.UseVisualStyleBackColor = true;
            // 
            // upbringing2RadioButton
            // 
            this.upbringing2RadioButton.AutoSize = true;
            this.upbringing2RadioButton.Location = new System.Drawing.Point(7, 44);
            this.upbringing2RadioButton.Name = "upbringing2RadioButton";
            this.upbringing2RadioButton.Size = new System.Drawing.Size(93, 17);
            this.upbringing2RadioButton.TabIndex = 1;
            this.upbringing2RadioButton.TabStop = true;
            this.upbringing2RadioButton.Text = "Working Class";
            this.upbringing2RadioButton.UseVisualStyleBackColor = true;
            // 
            // upbringing3RadioButton
            // 
            this.upbringing3RadioButton.AutoSize = true;
            this.upbringing3RadioButton.Location = new System.Drawing.Point(7, 68);
            this.upbringing3RadioButton.Name = "upbringing3RadioButton";
            this.upbringing3RadioButton.Size = new System.Drawing.Size(61, 17);
            this.upbringing3RadioButton.TabIndex = 2;
            this.upbringing3RadioButton.TabStop = true;
            this.upbringing3RadioButton.Text = "Poverty";
            this.upbringing3RadioButton.UseVisualStyleBackColor = true;
            // 
            // characterStatOutputHeaderLabel
            // 
            this.characterStatOutputHeaderLabel.AutoSize = true;
            this.characterStatOutputHeaderLabel.Location = new System.Drawing.Point(304, 308);
            this.characterStatOutputHeaderLabel.Name = "characterStatOutputHeaderLabel";
            this.characterStatOutputHeaderLabel.Size = new System.Drawing.Size(87, 13);
            this.characterStatOutputHeaderLabel.TabIndex = 5;
            this.characterStatOutputHeaderLabel.Text = "Character\'s Stats";
            // 
            // characterStatOutputLabel
            // 
            this.characterStatOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterStatOutputLabel.Location = new System.Drawing.Point(307, 328);
            this.characterStatOutputLabel.Name = "characterStatOutputLabel";
            this.characterStatOutputLabel.Size = new System.Drawing.Size(84, 97);
            this.characterStatOutputLabel.TabIndex = 6;
            // 
            // CSsharpPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 434);
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
            this.factionGroupBox.ResumeLayout(false);
            this.factionGroupBox.PerformLayout();
            this.upbringingGroupBox.ResumeLayout(false);
            this.upbringingGroupBox.PerformLayout();
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
    }
}

