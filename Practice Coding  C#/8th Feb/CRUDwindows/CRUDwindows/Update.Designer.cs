namespace CRUDwindows
{
    partial class Update
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
            this.SubmitUpdate = new System.Windows.Forms.Button();
            this.Designation = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.TextBox();
            this.JoiningDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitUpdate
            // 
            this.SubmitUpdate.Location = new System.Drawing.Point(759, 448);
            this.SubmitUpdate.Name = "SubmitUpdate";
            this.SubmitUpdate.Size = new System.Drawing.Size(165, 57);
            this.SubmitUpdate.TabIndex = 20;
            this.SubmitUpdate.Text = "SUBMIT";
            this.SubmitUpdate.UseVisualStyleBackColor = true;
            this.SubmitUpdate.Click += new System.EventHandler(this.OnSubmitUpdate);
            // 
            // Designation
            // 
            this.Designation.Location = new System.Drawing.Point(261, 326);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(663, 26);
            this.Designation.TabIndex = 18;
            this.Designation.TextChanged += new System.EventHandler(this.onDesignationChange);
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(261, 258);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(663, 26);
            this.Department.TabIndex = 17;
            this.Department.TextChanged += new System.EventHandler(this.OnDepartmentChange);
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(261, 200);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(663, 26);
            this.EmpName.TabIndex = 16;
            this.EmpName.TextChanged += new System.EventHandler(this.OnEmpNameChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(586, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter the details of the Employee for Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Designation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date of Joining:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Employee Id:";
            // 
            // EmpId
            // 
            this.EmpId.Location = new System.Drawing.Point(261, 136);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(663, 26);
            this.EmpId.TabIndex = 23;
            this.EmpId.TextChanged += new System.EventHandler(this.OnEmpIdChange);
            // 
            // JoiningDate
            // 
            this.JoiningDate.Location = new System.Drawing.Point(261, 389);
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.Size = new System.Drawing.Size(663, 26);
            this.JoiningDate.TabIndex = 24;
            this.JoiningDate.TextChanged += new System.EventHandler(this.OnJoiningDateChange);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 560);
            this.Controls.Add(this.JoiningDate);
            this.Controls.Add(this.EmpId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitUpdate);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitUpdate;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmpId;
        private System.Windows.Forms.TextBox JoiningDate;
    }
}