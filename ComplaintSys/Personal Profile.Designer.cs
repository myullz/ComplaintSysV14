namespace ComplaintSys
{
    partial class Personal_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal_Profile));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.pnlSingleSelection = new System.Windows.Forms.GroupBox();
            this.radFirstName = new System.Windows.Forms.RadioButton();
            this.btnDisplaySelCheckboxes = new System.Windows.Forms.Button();
            this.radLastName = new System.Windows.Forms.RadioButton();
            this.radCustID = new System.Windows.Forms.RadioButton();
            this.pnlMultiSelect = new System.Windows.Forms.Panel();
            this.btnDisplaySelection2 = new System.Windows.Forms.Button();
            this.chkFn = new System.Windows.Forms.CheckBox();
            this.chkLn = new System.Windows.Forms.CheckBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radState = new System.Windows.Forms.RadioButton();
            this.chkState = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.pnlSingleSelection.SuspendLayout();
            this.pnlMultiSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1386, 100);
            this.panel4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1128, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(92, 94);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Personal Profile";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(140, 133);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(1016, 351);
            this.dgvCustomer.TabIndex = 19;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(619, 526);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 26;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(733, 526);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 25;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(513, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(405, 526);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // pnlSingleSelection
            // 
            this.pnlSingleSelection.Controls.Add(this.radState);
            this.pnlSingleSelection.Controls.Add(this.radFirstName);
            this.pnlSingleSelection.Controls.Add(this.btnDisplaySelCheckboxes);
            this.pnlSingleSelection.Controls.Add(this.radLastName);
            this.pnlSingleSelection.Controls.Add(this.radCustID);
            this.pnlSingleSelection.ForeColor = System.Drawing.Color.Black;
            this.pnlSingleSelection.Location = new System.Drawing.Point(12, 160);
            this.pnlSingleSelection.Name = "pnlSingleSelection";
            this.pnlSingleSelection.Size = new System.Drawing.Size(122, 153);
            this.pnlSingleSelection.TabIndex = 67;
            this.pnlSingleSelection.TabStop = false;
            this.pnlSingleSelection.Text = "Single Selection";
            // 
            // radFirstName
            // 
            this.radFirstName.AutoSize = true;
            this.radFirstName.Location = new System.Drawing.Point(12, 69);
            this.radFirstName.Name = "radFirstName";
            this.radFirstName.Size = new System.Drawing.Size(75, 17);
            this.radFirstName.TabIndex = 69;
            this.radFirstName.TabStop = true;
            this.radFirstName.Text = "First Name";
            this.radFirstName.UseVisualStyleBackColor = true;
            // 
            // btnDisplaySelCheckboxes
            // 
            this.btnDisplaySelCheckboxes.ForeColor = System.Drawing.Color.Black;
            this.btnDisplaySelCheckboxes.Location = new System.Drawing.Point(6, 121);
            this.btnDisplaySelCheckboxes.Name = "btnDisplaySelCheckboxes";
            this.btnDisplaySelCheckboxes.Size = new System.Drawing.Size(111, 26);
            this.btnDisplaySelCheckboxes.TabIndex = 67;
            this.btnDisplaySelCheckboxes.Text = "Display Selections";
            this.btnDisplaySelCheckboxes.UseVisualStyleBackColor = true;
            this.btnDisplaySelCheckboxes.Click += new System.EventHandler(this.btnDisplaySelCheckboxes_Click);
            // 
            // radLastName
            // 
            this.radLastName.AutoSize = true;
            this.radLastName.Location = new System.Drawing.Point(12, 48);
            this.radLastName.Name = "radLastName";
            this.radLastName.Size = new System.Drawing.Size(76, 17);
            this.radLastName.TabIndex = 68;
            this.radLastName.TabStop = true;
            this.radLastName.Text = "Last Name";
            this.radLastName.UseVisualStyleBackColor = true;
            // 
            // radCustID
            // 
            this.radCustID.AutoSize = true;
            this.radCustID.Location = new System.Drawing.Point(11, 25);
            this.radCustID.Name = "radCustID";
            this.radCustID.Size = new System.Drawing.Size(80, 17);
            this.radCustID.TabIndex = 67;
            this.radCustID.TabStop = true;
            this.radCustID.Text = "CustomerID";
            this.radCustID.UseVisualStyleBackColor = true;
            // 
            // pnlMultiSelect
            // 
            this.pnlMultiSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMultiSelect.Controls.Add(this.chkState);
            this.pnlMultiSelect.Controls.Add(this.btnDisplaySelection2);
            this.pnlMultiSelect.Controls.Add(this.chkFn);
            this.pnlMultiSelect.Controls.Add(this.chkLn);
            this.pnlMultiSelect.Controls.Add(this.chkID);
            this.pnlMultiSelect.Controls.Add(this.label5);
            this.pnlMultiSelect.Location = new System.Drawing.Point(4, 352);
            this.pnlMultiSelect.Name = "pnlMultiSelect";
            this.pnlMultiSelect.Size = new System.Drawing.Size(130, 155);
            this.pnlMultiSelect.TabIndex = 68;
            // 
            // btnDisplaySelection2
            // 
            this.btnDisplaySelection2.Location = new System.Drawing.Point(7, 124);
            this.btnDisplaySelection2.Name = "btnDisplaySelection2";
            this.btnDisplaySelection2.Size = new System.Drawing.Size(115, 26);
            this.btnDisplaySelection2.TabIndex = 49;
            this.btnDisplaySelection2.Text = "Display Selection";
            this.btnDisplaySelection2.UseVisualStyleBackColor = true;
            this.btnDisplaySelection2.Click += new System.EventHandler(this.btnDisplaySelection2_Click);
            // 
            // chkFn
            // 
            this.chkFn.AutoSize = true;
            this.chkFn.Location = new System.Drawing.Point(16, 72);
            this.chkFn.Name = "chkFn";
            this.chkFn.Size = new System.Drawing.Size(76, 17);
            this.chkFn.TabIndex = 52;
            this.chkFn.Text = "First Name";
            this.chkFn.UseVisualStyleBackColor = true;
            this.chkFn.CheckedChanged += new System.EventHandler(this.chkFn_CheckedChanged);
            // 
            // chkLn
            // 
            this.chkLn.AutoSize = true;
            this.chkLn.Location = new System.Drawing.Point(16, 52);
            this.chkLn.Name = "chkLn";
            this.chkLn.Size = new System.Drawing.Size(77, 17);
            this.chkLn.TabIndex = 51;
            this.chkLn.Text = "Last Name";
            this.chkLn.UseVisualStyleBackColor = true;
            this.chkLn.CheckedChanged += new System.EventHandler(this.chkLn_CheckedChanged);
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(16, 29);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(81, 17);
            this.chkID.TabIndex = 50;
            this.chkID.Text = "CustomerID";
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.CheckedChanged += new System.EventHandler(this.chkID_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Multi-Select Sort";
            // 
            // radState
            // 
            this.radState.AutoSize = true;
            this.radState.Location = new System.Drawing.Point(12, 92);
            this.radState.Name = "radState";
            this.radState.Size = new System.Drawing.Size(50, 17);
            this.radState.TabIndex = 70;
            this.radState.TabStop = true;
            this.radState.Text = "State";
            this.radState.UseVisualStyleBackColor = true;
            // 
            // chkState
            // 
            this.chkState.AutoSize = true;
            this.chkState.Location = new System.Drawing.Point(16, 95);
            this.chkState.Name = "chkState";
            this.chkState.Size = new System.Drawing.Size(51, 17);
            this.chkState.TabIndex = 69;
            this.chkState.Text = "State";
            this.chkState.UseVisualStyleBackColor = true;
            this.chkState.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // Personal_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlMultiSelect);
            this.Controls.Add(this.pnlSingleSelection);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel4);
            this.Name = "Personal_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal_Profile";
            this.Load += new System.EventHandler(this.Personal_Profile_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.pnlSingleSelection.ResumeLayout(false);
            this.pnlSingleSelection.PerformLayout();
            this.pnlMultiSelect.ResumeLayout(false);
            this.pnlMultiSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox pnlSingleSelection;
        private System.Windows.Forms.RadioButton radFirstName;
        private System.Windows.Forms.Button btnDisplaySelCheckboxes;
        private System.Windows.Forms.RadioButton radLastName;
        private System.Windows.Forms.RadioButton radCustID;
        private System.Windows.Forms.Panel pnlMultiSelect;
        private System.Windows.Forms.Button btnDisplaySelection2;
        private System.Windows.Forms.CheckBox chkFn;
        private System.Windows.Forms.CheckBox chkLn;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radState;
        private System.Windows.Forms.CheckBox chkState;
    }
}