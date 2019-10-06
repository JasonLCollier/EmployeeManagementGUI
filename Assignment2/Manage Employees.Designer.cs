namespace Assignment2
{
    partial class Manage_Employees
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
            this.grbType = new System.Windows.Forms.GroupBox();
            this.rbtnPart = new System.Windows.Forms.RadioButton();
            this.rbtnFull = new System.Windows.Forms.RadioButton();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbFull = new System.Windows.Forms.GroupBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbPart = new System.Windows.Forms.GroupBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.grbType.SuspendLayout();
            this.grbDetails.SuspendLayout();
            this.grbFull.SuspendLayout();
            this.grbPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.rbtnPart);
            this.grbType.Controls.Add(this.rbtnFull);
            this.grbType.Location = new System.Drawing.Point(12, 12);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(325, 57);
            this.grbType.TabIndex = 0;
            this.grbType.TabStop = false;
            this.grbType.Text = "Employee type";
            // 
            // rbtnPart
            // 
            this.rbtnPart.AutoSize = true;
            this.rbtnPart.Location = new System.Drawing.Point(183, 19);
            this.rbtnPart.Name = "rbtnPart";
            this.rbtnPart.Size = new System.Drawing.Size(66, 17);
            this.rbtnPart.TabIndex = 1;
            this.rbtnPart.TabStop = true;
            this.rbtnPart.Text = "Part-time";
            this.rbtnPart.UseVisualStyleBackColor = true;
            this.rbtnPart.CheckedChanged += new System.EventHandler(this.rbtnPart_CheckedChanged);
            // 
            // rbtnFull
            // 
            this.rbtnFull.AutoSize = true;
            this.rbtnFull.Location = new System.Drawing.Point(18, 19);
            this.rbtnFull.Name = "rbtnFull";
            this.rbtnFull.Size = new System.Drawing.Size(63, 17);
            this.rbtnFull.TabIndex = 0;
            this.rbtnFull.TabStop = true;
            this.rbtnFull.Text = "Full-time";
            this.rbtnFull.UseVisualStyleBackColor = true;
            this.rbtnFull.CheckedChanged += new System.EventHandler(this.rbtnFull_CheckedChanged);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.txtSurname);
            this.grbDetails.Controls.Add(this.txtName);
            this.grbDetails.Controls.Add(this.lblSurname);
            this.grbDetails.Controls.Add(this.lblName);
            this.grbDetails.Location = new System.Drawing.Point(12, 75);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(325, 104);
            this.grbDetails.TabIndex = 1;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Basic details";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(156, 56);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(127, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 63);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grbFull
            // 
            this.grbFull.Controls.Add(this.lblSalary);
            this.grbFull.Controls.Add(this.txtSalary);
            this.grbFull.Location = new System.Drawing.Point(12, 185);
            this.grbFull.Name = "grbFull";
            this.grbFull.Size = new System.Drawing.Size(325, 54);
            this.grbFull.TabIndex = 2;
            this.grbFull.TabStop = false;
            this.grbFull.Text = "Full time";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(15, 22);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(156, 19);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(127, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbPart
            // 
            this.grbPart.Controls.Add(this.lblRate);
            this.grbPart.Controls.Add(this.lblHours);
            this.grbPart.Controls.Add(this.txtRate);
            this.grbPart.Controls.Add(this.txtHours);
            this.grbPart.Location = new System.Drawing.Point(12, 245);
            this.grbPart.Name = "grbPart";
            this.grbPart.Size = new System.Drawing.Size(325, 82);
            this.grbPart.TabIndex = 3;
            this.grbPart.TabStop = false;
            this.grbPart.Text = "Part time";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(15, 51);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(61, 13);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "Hourly rate:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(15, 26);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(88, 13);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours per month:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(156, 51);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(127, 20);
            this.txtRate.TabIndex = 6;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(156, 19);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(127, 20);
            this.txtHours.TabIndex = 5;
            // 
            // lstEmp
            // 
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.Location = new System.Drawing.Point(343, 12);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(541, 342);
            this.lstEmp.TabIndex = 7;
            this.lstEmp.TabStop = false;
            // 
            // Manage_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 371);
            this.Controls.Add(this.lstEmp);
            this.Controls.Add(this.grbPart);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbFull);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.grbType);
            this.Name = "Manage_Employees";
            this.Text = "Manage employees";
            this.Load += new System.EventHandler(this.Manage_Employees_Load);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.grbFull.ResumeLayout(false);
            this.grbFull.PerformLayout();
            this.grbPart.ResumeLayout(false);
            this.grbPart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton rbtnPart;
        private System.Windows.Forms.RadioButton rbtnFull;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbFull;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox grbPart;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.Label lblSalary;
    }
}