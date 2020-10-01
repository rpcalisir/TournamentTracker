namespace TrackerUI
{
    partial class CreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeam));
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.cmbSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.grpAddNewMember = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.grpAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(22, 109);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(400, 35);
            this.txtTeamName.TabIndex = 13;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(14, 60);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 37);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(218, 51);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Create Team";
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeamMember.Location = new System.Drawing.Point(100, 253);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Size = new System.Drawing.Size(216, 43);
            this.btnAddTeamMember.TabIndex = 19;
            this.btnAddTeamMember.Text = "Add Member";
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeamMember.Location = new System.Drawing.Point(19, 169);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.lblSelectTeamMember.TabIndex = 18;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // cmbSelectTeamMember
            // 
            this.cmbSelectTeamMember.FormattingEnabled = true;
            this.cmbSelectTeamMember.Location = new System.Drawing.Point(22, 209);
            this.cmbSelectTeamMember.Name = "cmbSelectTeamMember";
            this.cmbSelectTeamMember.Size = new System.Drawing.Size(400, 38);
            this.cmbSelectTeamMember.TabIndex = 17;
            // 
            // grpAddNewMember
            // 
            this.grpAddNewMember.Controls.Add(this.btnCreateMember);
            this.grpAddNewMember.Controls.Add(this.txtCellphone);
            this.grpAddNewMember.Controls.Add(this.txtEmail);
            this.grpAddNewMember.Controls.Add(this.lblCellphone);
            this.grpAddNewMember.Controls.Add(this.lblEmail);
            this.grpAddNewMember.Controls.Add(this.txtLastName);
            this.grpAddNewMember.Controls.Add(this.lblLastName);
            this.grpAddNewMember.Controls.Add(this.txtFirstName);
            this.grpAddNewMember.Controls.Add(this.lblFirstName);
            this.grpAddNewMember.Location = new System.Drawing.Point(26, 332);
            this.grpAddNewMember.Name = "grpAddNewMember";
            this.grpAddNewMember.Size = new System.Drawing.Size(396, 321);
            this.grpAddNewMember.TabIndex = 20;
            this.grpAddNewMember.TabStop = false;
            this.grpAddNewMember.Text = "Add New Member";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(226, 35);
            this.txtFirstName.TabIndex = 22;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(6, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 37);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(226, 35);
            this.txtLastName.TabIndex = 24;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(6, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 37);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 35);
            this.txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(6, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 37);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "E-mail";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(156, 208);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(226, 35);
            this.txtCellphone.TabIndex = 26;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(6, 206);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(138, 37);
            this.lblCellphone.TabIndex = 25;
            this.lblCellphone.Text = "Cellphone";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateMember.Location = new System.Drawing.Point(74, 267);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(216, 43);
            this.btnCreateMember.TabIndex = 21;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 30;
            this.lstTeamMembers.Location = new System.Drawing.Point(470, 109);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.Size = new System.Drawing.Size(401, 544);
            this.lstTeamMembers.TabIndex = 21;
            // 
            // btnDeleteSelectedMember
            // 
            this.btnDeleteSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedMember.Location = new System.Drawing.Point(877, 312);
            this.btnDeleteSelectedMember.Name = "btnDeleteSelectedMember";
            this.btnDeleteSelectedMember.Size = new System.Drawing.Size(139, 110);
            this.btnDeleteSelectedMember.TabIndex = 27;
            this.btnDeleteSelectedMember.Text = "Delete Selected Member";
            this.btnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(350, 659);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(216, 43);
            this.btnCreateTeam.TabIndex = 27;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2030, 1061);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteSelectedMember);
            this.Controls.Add(this.lstTeamMembers);
            this.Controls.Add(this.grpAddNewMember);
            this.Controls.Add(this.btnAddTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.cmbSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.grpAddNewMember.ResumeLayout(false);
            this.grpAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.ComboBox cmbSelectTeamMember;
        private System.Windows.Forms.GroupBox grpAddNewMember;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnDeleteSelectedMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}