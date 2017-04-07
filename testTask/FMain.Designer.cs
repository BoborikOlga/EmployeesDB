namespace testTask
{
    partial class fMain
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
            this.dgvEmployeeTable = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPositions = new System.Windows.Forms.ComboBox();
            this.pFilter = new System.Windows.Forms.Panel();
            this.bShowAllPositions = new System.Windows.Forms.Button();
            this.bFilter = new System.Windows.Forms.Button();
            this.lChooseFilter = new System.Windows.Forms.Label();
            this.pActionButtons = new System.Windows.Forms.Panel();
            this.bDeleteEmloyee = new System.Windows.Forms.Button();
            this.bAddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).BeginInit();
            this.pFilter.SuspendLayout();
            this.pActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeTable
            // 
            this.dgvEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colSurName,
            this.colPosition,
            this.colYear,
            this.colSalary});
            this.dgvEmployeeTable.Location = new System.Drawing.Point(49, 128);
            this.dgvEmployeeTable.MultiSelect = false;
            this.dgvEmployeeTable.Name = "dgvEmployeeTable";
            this.dgvEmployeeTable.ReadOnly = true;
            this.dgvEmployeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeTable.Size = new System.Drawing.Size(625, 404);
            this.dgvEmployeeTable.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "№";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Имя";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSurName
            // 
            this.colSurName.HeaderText = "Фамилия";
            this.colSurName.Name = "colSurName";
            this.colSurName.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Должность";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Год рождения";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colSalary
            // 
            this.colSalary.HeaderText = "Зарплата";
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            // 
            // cbPositions
            // 
            this.cbPositions.FormattingEnabled = true;
            this.cbPositions.Location = new System.Drawing.Point(197, 40);
            this.cbPositions.Name = "cbPositions";
            this.cbPositions.Size = new System.Drawing.Size(175, 21);
            this.cbPositions.TabIndex = 2;
            this.cbPositions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPositions_KeyPress);
            // 
            // pFilter
            // 
            this.pFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFilter.Controls.Add(this.bShowAllPositions);
            this.pFilter.Controls.Add(this.bFilter);
            this.pFilter.Controls.Add(this.lChooseFilter);
            this.pFilter.Controls.Add(this.cbPositions);
            this.pFilter.Location = new System.Drawing.Point(49, 12);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(625, 93);
            this.pFilter.TabIndex = 3;
            // 
            // bShowAllPositions
            // 
            this.bShowAllPositions.Location = new System.Drawing.Point(428, 57);
            this.bShowAllPositions.Name = "bShowAllPositions";
            this.bShowAllPositions.Size = new System.Drawing.Size(109, 23);
            this.bShowAllPositions.TabIndex = 5;
            this.bShowAllPositions.Text = "Все должности";
            this.bShowAllPositions.UseVisualStyleBackColor = true;
            this.bShowAllPositions.Click += new System.EventHandler(this.bShowAllPositions_Click);
            // 
            // bFilter
            // 
            this.bFilter.Location = new System.Drawing.Point(428, 19);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(109, 23);
            this.bFilter.TabIndex = 4;
            this.bFilter.Text = "Фильтровать";
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // lChooseFilter
            // 
            this.lChooseFilter.AutoSize = true;
            this.lChooseFilter.Location = new System.Drawing.Point(51, 43);
            this.lChooseFilter.Name = "lChooseFilter";
            this.lChooseFilter.Size = new System.Drawing.Size(118, 13);
            this.lChooseFilter.TabIndex = 3;
            this.lChooseFilter.Text = "Выберите должность:";
            // 
            // pActionButtons
            // 
            this.pActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pActionButtons.Controls.Add(this.bDeleteEmloyee);
            this.pActionButtons.Controls.Add(this.bAddEmployee);
            this.pActionButtons.Location = new System.Drawing.Point(680, 12);
            this.pActionButtons.Name = "pActionButtons";
            this.pActionButtons.Size = new System.Drawing.Size(167, 520);
            this.pActionButtons.TabIndex = 4;
            // 
            // bDeleteEmloyee
            // 
            this.bDeleteEmloyee.Location = new System.Drawing.Point(35, 200);
            this.bDeleteEmloyee.Name = "bDeleteEmloyee";
            this.bDeleteEmloyee.Size = new System.Drawing.Size(117, 35);
            this.bDeleteEmloyee.TabIndex = 1;
            this.bDeleteEmloyee.Text = "Удалить";
            this.bDeleteEmloyee.UseVisualStyleBackColor = true;
            this.bDeleteEmloyee.Click += new System.EventHandler(this.bDeleteEmloyee_Click);
            // 
            // bAddEmployee
            // 
            this.bAddEmployee.Location = new System.Drawing.Point(35, 136);
            this.bAddEmployee.Name = "bAddEmployee";
            this.bAddEmployee.Size = new System.Drawing.Size(117, 33);
            this.bAddEmployee.TabIndex = 0;
            this.bAddEmployee.Text = "Добавить";
            this.bAddEmployee.UseVisualStyleBackColor = true;
            this.bAddEmployee.Click += new System.EventHandler(this.bAddEmployee_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 557);
            this.Controls.Add(this.pActionButtons);
            this.Controls.Add(this.pFilter);
            this.Controls.Add(this.dgvEmployeeTable);
            this.Name = "fMain";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeTable)).EndInit();
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            this.pActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeTable;
        private System.Windows.Forms.ComboBox cbPositions;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.Label lChooseFilter;
        private System.Windows.Forms.Panel pActionButtons;
        private System.Windows.Forms.Button bDeleteEmloyee;
        private System.Windows.Forms.Button bAddEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.Button bShowAllPositions;
    }
}

