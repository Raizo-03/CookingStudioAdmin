namespace CookingStudioAdmin
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.adminLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unamePicture = new System.Windows.Forms.PictureBox();
            this.passwordPicture = new System.Windows.Forms.PictureBox();
            this.showPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.unamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(80, 138);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(152, 33);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "ADMIN";
            this.adminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(65, 205);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(200, 29);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(65, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // unamePicture
            // 
            this.unamePicture.Image = ((System.Drawing.Image)(resources.GetObject("unamePicture.Image")));
            this.unamePicture.Location = new System.Drawing.Point(31, 205);
            this.unamePicture.Name = "unamePicture";
            this.unamePicture.Size = new System.Drawing.Size(29, 29);
            this.unamePicture.TabIndex = 4;
            this.unamePicture.TabStop = false;
            // 
            // passwordPicture
            // 
            this.passwordPicture.Image = ((System.Drawing.Image)(resources.GetObject("passwordPicture.Image")));
            this.passwordPicture.Location = new System.Drawing.Point(30, 262);
            this.passwordPicture.Name = "passwordPicture";
            this.passwordPicture.Size = new System.Drawing.Size(29, 29);
            this.passwordPicture.TabIndex = 5;
            this.passwordPicture.TabStop = false;
            // 
            // showPicture
            // 
            this.showPicture.Image = ((System.Drawing.Image)(resources.GetObject("showPicture.Image")));
            this.showPicture.Location = new System.Drawing.Point(271, 262);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(29, 29);
            this.showPicture.TabIndex = 6;
            this.showPicture.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.showPicture);
            this.Controls.Add(this.passwordPicture);
            this.Controls.Add(this.unamePicture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.adminLabel);
            this.Name = "loginForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox unamePicture;
        private System.Windows.Forms.PictureBox passwordPicture;
        private System.Windows.Forms.PictureBox showPicture;
    }
}

