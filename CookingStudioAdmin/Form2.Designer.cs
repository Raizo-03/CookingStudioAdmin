namespace CookingStudioAdmin
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BookingGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.downloadExcelButton = new System.Windows.Forms.Button();
            this.downloadXMLButton = new System.Windows.Forms.Button();
            this.downloadTxtButton = new System.Windows.Forms.Button();
            this.downloadCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, Admin";
            // 
            // BookingGridView
            // 
            this.BookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingGridView.Location = new System.Drawing.Point(12, 99);
            this.BookingGridView.Name = "BookingGridView";
            this.BookingGridView.Size = new System.Drawing.Size(776, 336);
            this.BookingGridView.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.Location = new System.Drawing.Point(753, 26);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(35, 35);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(712, 26);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(35, 35);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // downloadExcelButton
            // 
            this.downloadExcelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadExcelButton.Location = new System.Drawing.Point(618, 450);
            this.downloadExcelButton.Name = "downloadExcelButton";
            this.downloadExcelButton.Size = new System.Drawing.Size(169, 32);
            this.downloadExcelButton.TabIndex = 5;
            this.downloadExcelButton.Text = "DOWNLOAD EXCEL";
            this.downloadExcelButton.UseVisualStyleBackColor = true;
            this.downloadExcelButton.Click += new System.EventHandler(this.downloadExcelButton_Click);
            // 
            // downloadXMLButton
            // 
            this.downloadXMLButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadXMLButton.Location = new System.Drawing.Point(443, 450);
            this.downloadXMLButton.Name = "downloadXMLButton";
            this.downloadXMLButton.Size = new System.Drawing.Size(169, 32);
            this.downloadXMLButton.TabIndex = 6;
            this.downloadXMLButton.Text = "DOWNLOAD XML";
            this.downloadXMLButton.UseVisualStyleBackColor = true;
            this.downloadXMLButton.Click += new System.EventHandler(this.downloadXMLButton_Click);
            // 
            // downloadTxtButton
            // 
            this.downloadTxtButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadTxtButton.Location = new System.Drawing.Point(268, 450);
            this.downloadTxtButton.Name = "downloadTxtButton";
            this.downloadTxtButton.Size = new System.Drawing.Size(169, 32);
            this.downloadTxtButton.TabIndex = 7;
            this.downloadTxtButton.Text = "DOWNLOAD TEXT";
            this.downloadTxtButton.UseVisualStyleBackColor = true;
            this.downloadTxtButton.Click += new System.EventHandler(this.downloadTxtButton_Click);
            // 
            // downloadCSVButton
            // 
            this.downloadCSVButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadCSVButton.Location = new System.Drawing.Point(93, 450);
            this.downloadCSVButton.Name = "downloadCSVButton";
            this.downloadCSVButton.Size = new System.Drawing.Size(169, 32);
            this.downloadCSVButton.TabIndex = 8;
            this.downloadCSVButton.Text = "DOWNLOAD CSV";
            this.downloadCSVButton.UseVisualStyleBackColor = true;
            this.downloadCSVButton.Click += new System.EventHandler(this.downloadCSVButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.ControlBox = false;
            this.Controls.Add(this.downloadCSVButton);
            this.Controls.Add(this.downloadTxtButton);
            this.Controls.Add(this.downloadXMLButton);
            this.Controls.Add(this.downloadExcelButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookingGridView);
            this.Controls.Add(this.label1);
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BookingGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.Button downloadExcelButton;
        private System.Windows.Forms.Button downloadXMLButton;
        private System.Windows.Forms.Button downloadTxtButton;
        private System.Windows.Forms.Button downloadCSVButton;
    }
}