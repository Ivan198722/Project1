namespace PayrollTrackingApp1
{
    partial class Position_Rates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Position_Rates));
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionsAndPayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTrackingDBDataSet5 = new PayrollTrackingApp1.PayrollTrackingDBDataSet5();
            this.positionsAndPayTableAdapter = new PayrollTrackingApp1.PayrollTrackingDBDataSet5TableAdapters.PositionsAndPayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsAndPayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update_button.Location = new System.Drawing.Point(446, 36);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(105, 35);
            this.update_button.TabIndex = 0;
            this.update_button.Text = "Refresh";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_button.Location = new System.Drawing.Point(222, 36);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 35);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Add Position";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.positionNameDataGridViewTextBoxColumn,
            this.hourlySalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.positionsAndPayBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 277);
            this.dataGridView1.TabIndex = 2;
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
            // positionsAndPayBindingSource
            // 
            this.positionsAndPayBindingSource.DataMember = "PositionsAndPay";
            this.positionsAndPayBindingSource.DataSource = this.payrollTrackingDBDataSet5;
            // 
            // payrollTrackingDBDataSet5
            // 
            this.payrollTrackingDBDataSet5.DataSetName = "PayrollTrackingDBDataSet5";
            this.payrollTrackingDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsAndPayTableAdapter
            // 
            this.positionsAndPayTableAdapter.ClearBeforeFill = true;
            // 
            // Position_Rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.update_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Position_Rates";
            this.Text = "Position_Rates";
            this.Load += new System.EventHandler(this.Position_Rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsAndPayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTrackingDBDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PayrollTrackingDBDataSet5 payrollTrackingDBDataSet5;
        private System.Windows.Forms.BindingSource positionsAndPayBindingSource;
        private PayrollTrackingDBDataSet5TableAdapters.PositionsAndPayTableAdapter positionsAndPayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlySalaryDataGridViewTextBoxColumn;
    }
}