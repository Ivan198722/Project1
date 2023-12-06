namespace PayrollTrackingApp1
{
    partial class Bonus_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonus_Settings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payrollTrackingDBDataSet6 = new PayrollTrackingApp1.PayrollTrackingDBDataSet6();
            this.salaryBonusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryBonusesTableAdapter = new PayrollTrackingApp1.PayrollTrackingDBDataSet6TableAdapters.SalaryBonusesTableAdapter();
            this.bonusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplly_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBonusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonusIDDataGridViewTextBoxColumn,
            this.bonusNameDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salaryBonusesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // payrollTrackingDBDataSet6
            // 
            this.payrollTrackingDBDataSet6.DataSetName = "PayrollTrackingDBDataSet6";
            this.payrollTrackingDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryBonusesBindingSource
            // 
            this.salaryBonusesBindingSource.DataMember = "SalaryBonuses";
            this.salaryBonusesBindingSource.DataSource = this.payrollTrackingDBDataSet6;
            // 
            // salaryBonusesTableAdapter
            // 
            this.salaryBonusesTableAdapter.ClearBeforeFill = true;
            // 
            // bonusIDDataGridViewTextBoxColumn
            // 
            this.bonusIDDataGridViewTextBoxColumn.DataPropertyName = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.HeaderText = "BonusID";
            this.bonusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bonusIDDataGridViewTextBoxColumn.Name = "bonusIDDataGridViewTextBoxColumn";
            this.bonusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bonusNameDataGridViewTextBoxColumn
            // 
            this.bonusNameDataGridViewTextBoxColumn.DataPropertyName = "BonusName";
            this.bonusNameDataGridViewTextBoxColumn.HeaderText = "BonusName";
            this.bonusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bonusNameDataGridViewTextBoxColumn.Name = "bonusNameDataGridViewTextBoxColumn";
            this.bonusNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage %";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage %";
            this.percentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.Width = 125;
            // 
            // aplly_button
            // 
            this.aplly_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aplly_button.Location = new System.Drawing.Point(224, 27);
            this.aplly_button.Name = "aplly_button";
            this.aplly_button.Size = new System.Drawing.Size(116, 36);
            this.aplly_button.TabIndex = 1;
            this.aplly_button.Text = "Aplly";
            this.aplly_button.UseVisualStyleBackColor = false;
            this.aplly_button.Click += new System.EventHandler(this.aplly_button_Click);
            // 
            // Bonus_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(578, 378);
            this.Controls.Add(this.aplly_button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bonus_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus Settings";
            this.Load += new System.EventHandler(this.Bonus_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBonusesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PayrollTrackingDBDataSet6 payrollTrackingDBDataSet6;
        private System.Windows.Forms.BindingSource salaryBonusesBindingSource;
        private PayrollTrackingDBDataSet6TableAdapters.SalaryBonusesTableAdapter salaryBonusesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button aplly_button;
    }
}