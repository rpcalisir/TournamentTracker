namespace TrackerUI
{
    partial class TournamentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cmbRoundDropdown = new System.Windows.Forms.ComboBox();
            this.lblUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lstMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblScoreOne = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblScoreTwo = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(15, 95);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(124, 46);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round:";
            // 
            // cmbRoundDropdown
            // 
            this.cmbRoundDropdown.FormattingEnabled = true;
            this.cmbRoundDropdown.Location = new System.Drawing.Point(166, 96);
            this.cmbRoundDropdown.Name = "cmbRoundDropdown";
            this.cmbRoundDropdown.Size = new System.Drawing.Size(305, 45);
            this.cmbRoundDropdown.TabIndex = 3;
            // 
            // lblUnplayedOnly
            // 
            this.lblUnplayedOnly.AutoSize = true;
            this.lblUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblUnplayedOnly.Location = new System.Drawing.Point(166, 147);
            this.lblUnplayedOnly.Name = "lblUnplayedOnly";
            this.lblUnplayedOnly.Size = new System.Drawing.Size(257, 50);
            this.lblUnplayedOnly.TabIndex = 4;
            this.lblUnplayedOnly.Text = "Unplayed Only";
            this.lblUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lstMatchup
            // 
            this.lstMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMatchup.FormattingEnabled = true;
            this.lstMatchup.ItemHeight = 37;
            this.lstMatchup.Location = new System.Drawing.Point(23, 216);
            this.lstMatchup.Name = "lstMatchup";
            this.lstMatchup.Size = new System.Drawing.Size(448, 224);
            this.lstMatchup.TabIndex = 5;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOne.Location = new System.Drawing.Point(616, 128);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(208, 46);
            this.lblTeamOne.TabIndex = 6;
            this.lblTeamOne.Text = "<team one>";
            // 
            // lblScoreOne
            // 
            this.lblScoreOne.AutoSize = true;
            this.lblScoreOne.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblScoreOne.Location = new System.Drawing.Point(616, 182);
            this.lblScoreOne.Name = "lblScoreOne";
            this.lblScoreOne.Size = new System.Drawing.Size(104, 46);
            this.lblScoreOne.TabIndex = 7;
            this.lblScoreOne.Text = "Score";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(726, 189);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 43);
            this.txtTeamOneScore.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(726, 385);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 43);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lblScoreTwo
            // 
            this.lblScoreTwo.AutoSize = true;
            this.lblScoreTwo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblScoreTwo.Location = new System.Drawing.Point(616, 378);
            this.lblScoreTwo.Name = "lblScoreTwo";
            this.lblScoreTwo.Size = new System.Drawing.Size(104, 46);
            this.lblScoreTwo.TabIndex = 10;
            this.lblScoreTwo.Text = "Score";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwo.Location = new System.Drawing.Point(616, 324);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(208, 46);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<team two>";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVs.Location = new System.Drawing.Point(683, 259);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(87, 46);
            this.lblVs.TabIndex = 12;
            this.lblVs.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(862, 252);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(107, 62);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 542);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblScoreTwo);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lblScoreOne);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lstMatchup);
            this.Controls.Add(this.lblUnplayedOnly);
            this.Controls.Add(this.cmbRoundDropdown);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cmbRoundDropdown;
        private System.Windows.Forms.CheckBox lblUnplayedOnly;
        private System.Windows.Forms.ListBox lstMatchup;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblScoreOne;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lblScoreTwo;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Button btnScore;
    }
}

