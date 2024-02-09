namespace CRUDwindows
{
    partial class Insert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Empname = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.TextBox();
            this.SubmitInsert = new System.Windows.Forms.Button();
            this.DateJoing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Joining:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(611, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter the details of the Employee for Insertion";
            // 
            // Empname
            // 
            this.Empname.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empname.Location = new System.Drawing.Point(239, 130);
            this.Empname.Name = "Empname";
            this.Empname.Size = new System.Drawing.Size(522, 29);
            this.Empname.TabIndex = 5;
            this.Empname.TextChanged += new System.EventHandler(this.OnEmployeeName);
            // 
            // Department
            // 
            this.Department.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(239, 189);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(522, 29);
            this.Department.TabIndex = 7;
            this.Department.TextChanged += new System.EventHandler(this.OnDepartment);
            // 
            // Designation
            // 
            this.Designation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.Location = new System.Drawing.Point(239, 257);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(522, 29);
            this.Designation.TabIndex = 8;
            this.Designation.TextChanged += new System.EventHandler(this.OnDesignation);
            // 
            // SubmitInsert
            // 
            this.SubmitInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitInsert.Location = new System.Drawing.Point(630, 367);
            this.SubmitInsert.Name = "SubmitInsert";
            this.SubmitInsert.Size = new System.Drawing.Size(129, 47);
            this.SubmitInsert.TabIndex = 10;
            this.SubmitInsert.Text = "SUBMIT";
            this.SubmitInsert.UseVisualStyleBackColor = true;
            this.SubmitInsert.Click += new System.EventHandler(this.InsertSubmit);
            // 
            // DateJoing
            // 
            this.DateJoing.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateJoing.Location = new System.Drawing.Point(239, 311);
            this.DateJoing.Name = "DateJoing";
            this.DateJoing.Size = new System.Drawing.Size(522, 29);
            this.DateJoing.TabIndex = 11;
            this.DateJoing.TextChanged += new System.EventHandler(this.DateJoining);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 430);
            this.Controls.Add(this.DateJoing);
            this.Controls.Add(this.SubmitInsert);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Empname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Insert";
            this.Text = "Insertion";
            this.Load += new System.EventHandler(this.Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Empname;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.Button SubmitInsert;
        private System.Windows.Forms.TextBox DateJoing;
    }
}