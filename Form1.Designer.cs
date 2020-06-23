namespace NetDLab1
{
    partial class frmUnitsShipped
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
            this.components = new System.ComponentModel.Container();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUserEntry = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtUserData = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.appHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(33, 334);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "&Enter";
            this.appHelp.SetToolTip(this.btnEnter, "This button will enter the number of units shipped and once the 7th day is entere" +
        "d will calculate the average shipped.");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(139, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.appHelp.SetToolTip(this.btnReset, "This button will reset the application and clear all data.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.appHelp.SetToolTip(this.btnExit, "This button will exit the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(74, 33);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(34, 13);
            this.lblUnits.TabIndex = 6;
            this.lblUnits.Text = "Units:";
            // 
            // txtUserEntry
            // 
            this.txtUserEntry.Location = new System.Drawing.Point(114, 30);
            this.txtUserEntry.Name = "txtUserEntry";
            this.txtUserEntry.Size = new System.Drawing.Size(100, 20);
            this.txtUserEntry.TabIndex = 0;
            this.appHelp.SetToolTip(this.txtUserEntry, "Enter the number of units shipped that day in this box.");
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(220, 33);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(32, 13);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "Day: ";
            this.appHelp.SetToolTip(this.lblDays, "Shows which day you are entering Units Shipped for.");
            // 
            // txtUserData
            // 
            this.txtUserData.Location = new System.Drawing.Point(86, 68);
            this.txtUserData.Multiline = true;
            this.txtUserData.Name = "txtUserData";
            this.txtUserData.ReadOnly = true;
            this.txtUserData.Size = new System.Drawing.Size(183, 207);
            this.txtUserData.TabIndex = 1;
            this.txtUserData.TabStop = false;
            this.appHelp.SetToolTip(this.txtUserData, "This box displays the numbers of units shipped that have been entered.");
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(86, 278);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(183, 32);
            this.lblResults.TabIndex = 2;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appHelp.SetToolTip(this.lblResults, "This box displays the average number of units shipped once they have been entered" +
        " and calculcated.");
            // 
            // frmUnitsShipped
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(371, 380);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtUserData);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtUserEntry);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(387, 419);
            this.Name = "frmUnitsShipped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUserEntry;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtUserData;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ToolTip appHelp;
    }
}

