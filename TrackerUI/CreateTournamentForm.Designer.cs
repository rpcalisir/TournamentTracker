﻿namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cmbSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.linklblCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayers = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayers = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrizes = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(411, 65);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(23, 150);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(400, 43);
            this.txtTournamentName.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(15, 101);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(298, 46);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(165, 223);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(258, 43);
            this.txtEntryFee.TabIndex = 12;
            this.txtEntryFee.Text = "0";
            this.txtEntryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEntryFee.Location = new System.Drawing.Point(15, 220);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(158, 46);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // cmbSelectTeam
            // 
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(23, 395);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(400, 45);
            this.cmbSelectTeam.TabIndex = 13;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(15, 336);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(198, 46);
            this.lblSelectTeam.TabIndex = 14;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // linklblCreateNewTeam
            // 
            this.linklblCreateNewTeam.AutoSize = true;
            this.linklblCreateNewTeam.Location = new System.Drawing.Point(282, 342);
            this.linklblCreateNewTeam.Name = "linklblCreateNewTeam";
            this.linklblCreateNewTeam.Size = new System.Drawing.Size(152, 38);
            this.linklblCreateNewTeam.TabIndex = 15;
            this.linklblCreateNewTeam.TabStop = true;
            this.linklblCreateNewTeam.Text = "create new";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(136, 462);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(167, 48);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreatePrize.Location = new System.Drawing.Point(136, 534);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(167, 90);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lbTournamentPlayers
            // 
            this.lbTournamentPlayers.FormattingEnabled = true;
            this.lbTournamentPlayers.ItemHeight = 37;
            this.lbTournamentPlayers.Location = new System.Drawing.Point(530, 150);
            this.lbTournamentPlayers.Name = "lbTournamentPlayers";
            this.lbTournamentPlayers.Size = new System.Drawing.Size(419, 152);
            this.lbTournamentPlayers.TabIndex = 18;
            // 
            // lblTournamentPlayers
            // 
            this.lblTournamentPlayers.AutoSize = true;
            this.lblTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentPlayers.Location = new System.Drawing.Point(522, 89);
            this.lblTournamentPlayers.Name = "lblTournamentPlayers";
            this.lblTournamentPlayers.Size = new System.Drawing.Size(239, 46);
            this.lblTournamentPlayers.TabIndex = 19;
            this.lblTournamentPlayers.Text = "Teams/ Players";
            // 
            // btnDeleteSelectedPlayers
            // 
            this.btnDeleteSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedPlayers.Location = new System.Drawing.Point(629, 308);
            this.btnDeleteSelectedPlayers.Name = "btnDeleteSelectedPlayers";
            this.btnDeleteSelectedPlayers.Size = new System.Drawing.Size(226, 48);
            this.btnDeleteSelectedPlayers.TabIndex = 20;
            this.btnDeleteSelectedPlayers.Text = "Delete Selected";
            this.btnDeleteSelectedPlayers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrizes
            // 
            this.btnDeleteSelectedPrizes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPrizes.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedPrizes.Location = new System.Drawing.Point(629, 612);
            this.btnDeleteSelectedPrizes.Name = "btnDeleteSelectedPrizes";
            this.btnDeleteSelectedPrizes.Size = new System.Drawing.Size(226, 48);
            this.btnDeleteSelectedPrizes.TabIndex = 23;
            this.btnDeleteSelectedPrizes.Text = "Delete Selected";
            this.btnDeleteSelectedPrizes.UseVisualStyleBackColor = true;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrizes.Location = new System.Drawing.Point(522, 392);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(106, 46);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Prizes";
            // 
            // lbPrizes
            // 
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 37;
            this.lbPrizes.Location = new System.Drawing.Point(530, 453);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(419, 152);
            this.lbPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(322, 705);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(323, 65);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 782);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrizes);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.btnDeleteSelectedPlayers);
            this.Controls.Add(this.lblTournamentPlayers);
            this.Controls.Add(this.lbTournamentPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linklblCreateNewTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.cmbSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cmbSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel linklblCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lbTournamentPlayers;
        private System.Windows.Forms.Label lblTournamentPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedPrizes;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox lbPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}