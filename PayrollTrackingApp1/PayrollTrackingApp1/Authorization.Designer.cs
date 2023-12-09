namespace PayrollTrackingApp1
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.pasword_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter_button = new System.Windows.Forms.Button();
            this.close_eye = new System.Windows.Forms.PictureBox();
            this.open_eye = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTHORIZATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(304, 170);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(136, 22);
            this.login_textBox.TabIndex = 2;
            // 
            // pasword_textBox
            // 
            this.pasword_textBox.Location = new System.Drawing.Point(304, 228);
            this.pasword_textBox.Name = "pasword_textBox";
            this.pasword_textBox.Size = new System.Drawing.Size(136, 22);
            this.pasword_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "pasword";
            // 
            // Enter_button
            // 
            this.Enter_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Enter_button.Location = new System.Drawing.Point(332, 279);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(75, 23);
            this.Enter_button.TabIndex = 6;
            this.Enter_button.Text = "ENTER";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // close_eye
            // 
            this.close_eye.Image = ((System.Drawing.Image)(resources.GetObject("close_eye.Image")));
            this.close_eye.Location = new System.Drawing.Point(465, 228);
            this.close_eye.Name = "close_eye";
            this.close_eye.Size = new System.Drawing.Size(37, 35);
            this.close_eye.TabIndex = 7;
            this.close_eye.TabStop = false;
            this.close_eye.Click += new System.EventHandler(this.close_eye_Click);
            // 
            // open_eye
            // 
            this.open_eye.Image = ((System.Drawing.Image)(resources.GetObject("open_eye.Image")));
            this.open_eye.Location = new System.Drawing.Point(463, 228);
            this.open_eye.Name = "open_eye";
            this.open_eye.Size = new System.Drawing.Size(39, 35);
            this.open_eye.TabIndex = 8;
            this.open_eye.TabStop = false;
            this.open_eye.Click += new System.EventHandler(this.open_eye_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "login: admin, pasword: admin";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.open_eye);
            this.Controls.Add(this.close_eye);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pasword_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox pasword_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.PictureBox close_eye;
        private System.Windows.Forms.PictureBox open_eye;
        private System.Windows.Forms.Label label4;
    }
}

