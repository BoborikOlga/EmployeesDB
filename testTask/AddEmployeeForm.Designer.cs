namespace testTask
{
    partial class AddEmployeeForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lPosition = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lSalary = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.bAddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(141, 67);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSurname_KeyPress);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(141, 132);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 2;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(141, 173);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 3;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(23, 35);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(32, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "Имя:";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(23, 67);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(59, 13);
            this.lSurname.TabIndex = 5;
            this.lSurname.Text = "Фамилия:";
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(23, 105);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(68, 13);
            this.lPosition.TabIndex = 6;
            this.lPosition.Text = "Должность:";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(23, 139);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(81, 13);
            this.lYear.TabIndex = 7;
            this.lYear.Text = "Год рождения:";
            // 
            // lSalary
            // 
            this.lSalary.AutoSize = true;
            this.lSalary.Location = new System.Drawing.Point(23, 176);
            this.lSalary.Name = "lSalary";
            this.lSalary.Size = new System.Drawing.Size(58, 13);
            this.lSalary.TabIndex = 8;
            this.lSalary.Text = "Зарплата:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(141, 96);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(100, 21);
            this.cbPosition.TabIndex = 9;
            this.cbPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPosition_KeyPress);
            // 
            // bAddEmployee
            // 
            this.bAddEmployee.Location = new System.Drawing.Point(26, 225);
            this.bAddEmployee.Name = "bAddEmployee";
            this.bAddEmployee.Size = new System.Drawing.Size(215, 40);
            this.bAddEmployee.TabIndex = 10;
            this.bAddEmployee.Text = "Добавить сотрудника";
            this.bAddEmployee.UseVisualStyleBackColor = true;
            this.bAddEmployee.Click += new System.EventHandler(this.bAddEmployee_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 277);
            this.Controls.Add(this.bAddEmployee);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.lSalary);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.lPosition);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lSalary;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button bAddEmployee;
    }
}