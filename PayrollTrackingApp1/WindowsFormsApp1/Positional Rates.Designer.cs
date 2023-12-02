namespace PayrollTrackingApp1
{
    partial class Positional_Rates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Positional_Rates));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payrollTrackingDBDataSet2 = new PayrollTrackingApp1.PayrollTrackingDBDataSet2();
            this.positionsAndPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionsAndPayTableAdapter = new PayrollTrackingApp1.PayrollTrackingDBDataSet2TableAdapters.PositionsAndPayTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsAndPayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.positionNameDataGridViewTextBoxColumn,
            this.hourlySalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.positionsAndPayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // payrollTrackingDBDataSet2
            // 
            this.payrollTrackingDBDataSet2.DataSetName = "PayrollTrackingDBDataSet2";
            this.payrollTrackingDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsAndPayBindingSource
            // 
            this.positionsAndPayBindingSource.DataMember = "PositionsAndPay";
            this.positionsAndPayBindingSource.DataSource = this.payrollTrackingDBDataSet2;
            // 
            // positionsAndPayTableAdapter
            // 
            this.positionsAndPayTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionNameDataGridViewTextBoxColumn
            // 
            this.positionNameDataGridViewTextBoxColumn.DataPropertyName = "PositionName";
            this.positionNameDataGridViewTextBoxColumn.HeaderText = "PositionName";
            this.positionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionNameDataGridViewTextBoxColumn.Name = "positionNameDataGridViewTextBoxColumn";
            this.positionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlySalaryDataGridViewTextBoxColumn
            // 
            this.hourlySalaryDataGridViewTextBoxColumn.DataPropertyName = "HourlySalary($)";
            this.hourlySalaryDataGridViewTextBoxColumn.HeaderText = "HourlySalary($)";
            this.hourlySalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hourlySalaryDataGridViewTextBoxColumn.Name = "hourlySalaryDataGridViewTextBoxColumn";
            this.hourlySalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refresh_button.Location = new System.Drawing.Point(339, 12);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(150, 23);
            this.refresh_button.TabIndex = 1;
            this.refresh_button.Text = "Edit Pay";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_button.Location = new System.Drawing.Point(64, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(134, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Add Position";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Positional_Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Positional_Rates";
            this.Text = "Positional Rates";
            this.Load += new System.EventHandler(this.Positional_Rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsAndPayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PayrollTrackingDBDataSet2 payrollTrackingDBDataSet2;
        private System.Windows.Forms.BindingSource positionsAndPayBindingSource;
        private PayrollTrackingDBDataSet2TableAdapters.PositionsAndPayTableAdapter positionsAndPayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button add_button;
    }
}