namespace PayrollTrackingApp1
{
    partial class Regisration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regisration));
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pasword = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pasword_label = new System.Windows.Forms.Label();
            this.open_eye = new System.Windows.Forms.PictureBox();
            this.close_eye = new System.Windows.Forms.PictureBox();
            this.create_button = new System.Windows.Forms.Button();
            this.registration_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.open_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(305, 147);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(128, 22);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_pasword
            // 
            this.textBox_pasword.Location = new System.Drawing.Point(305, 205);
            this.textBox_pasword.Name = "textBox_pasword";
            this.textBox_pasword.Size = new System.Drawing.Size(128, 22);
            this.textBox_pasword.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(208, 147);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(36, 16);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "login";
            // 
            // pasword_label
            // 
            this.pasword_label.AutoSize = true;
            this.pasword_label.Location = new System.Drawing.Point(208, 211);
            this.pasword_label.Name = "pasword_label";
            this.pasword_label.Size = new System.Drawing.Size(59, 16);
            this.pasword_label.TabIndex = 3;
            this.pasword_label.Text = "pasword";
            // 
            // open_eye
            // 
            this.open_eye.Image = ((System.Drawing.Image)(resources.GetObject("open_eye.Image")));
            this.open_eye.Location = new System.Drawing.Point(439, 205);
            this.open_eye.Name = "open_eye";
            this.open_eye.Size = new System.Drawing.Size(35, 28);
            this.open_eye.TabIndex = 4;
            this.open_eye.TabStop = false;
            this.open_eye.Click += new System.EventHandler(this.open_eye_Click_1);
            // 
            // close_eye
            // 
            this.close_eye.Image = ((System.Drawing.Image)(resources.GetObject("close_eye.Image")));
            this.close_eye.Location = new System.Drawing.Point(441, 205);
            this.close_eye.Name = "close_eye";
            this.close_eye.Size = new System.Drawing.Size(33, 27);
            this.close_eye.TabIndex = 5;
            this.close_eye.TabStop = false;
            this.close_eye.Click += new System.EventHandler(this.close_eye_Click_1);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(305, 283);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(128, 23);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registration_label.Location = new System.Drawing.Point(268, 35);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(99, 16);
            this.registration_label.TabIndex = 7;
            this.registration_label.Text = "REGISRATION";
            // 
            // Regisration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registration_label);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.close_eye);
            this.Controls.Add(this.open_eye);
            this.Controls.Add(this.pasword_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.textBox_pasword);
            this.Controls.Add(this.textBox_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Regisration";
            this.Load += new System.EventHandler(this.Regisration_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Regisration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.open_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pasword;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label pasword_label;
        private System.Windows.Forms.PictureBox open_eye;
        private System.Windows.Forms.PictureBox close_eye;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label registration_label;
    }
}