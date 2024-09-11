
namespace _123
{
    partial class Form3
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
            this.txtHienthi = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbnHienThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHienthi
            // 
            this.txtHienthi.Location = new System.Drawing.Point(143, 58);
            this.txtHienthi.Multiline = true;
            this.txtHienthi.Name = "txtHienthi";
            this.txtHienthi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHienthi.Size = new System.Drawing.Size(495, 124);
            this.txtHienthi.TabIndex = 0;
            this.txtHienthi.TextChanged += new System.EventHandler(this.txtHienthi_TextChanged);
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(184, 254);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(118, 55);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 55);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbnHienThi
            // 
            this.lbnHienThi.AutoSize = true;
            this.lbnHienThi.Location = new System.Drawing.Point(162, 383);
            this.lbnHienThi.Name = "lbnHienThi";
            this.lbnHienThi.Size = new System.Drawing.Size(0, 16);
            this.lbnHienThi.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbnHienThi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtHienthi);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHienthi;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbnHienThi;
    }
}