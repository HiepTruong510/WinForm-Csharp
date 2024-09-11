
namespace _123
{
    partial class Form9
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.tong = new System.Windows.Forms.TextBox();
            this.tinhtong = new System.Windows.Forms.Button();
            this.btne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(198, 71);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 0;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(450, 71);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 1;
            // 
            // tong
            // 
            this.tong.Location = new System.Drawing.Point(313, 183);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(100, 22);
            this.tong.TabIndex = 2;
            // 
            // tinhtong
            // 
            this.tinhtong.Location = new System.Drawing.Point(154, 313);
            this.tinhtong.Name = "tinhtong";
            this.tinhtong.Size = new System.Drawing.Size(75, 23);
            this.tinhtong.TabIndex = 3;
            this.tinhtong.Text = "tinh";
            this.tinhtong.UseVisualStyleBackColor = true;
            this.tinhtong.Click += new System.EventHandler(this.tinhtong_Click);
            // 
            // btne
            // 
            this.btne.Location = new System.Drawing.Point(477, 313);
            this.btne.Name = "btne";
            this.btne.Size = new System.Drawing.Size(75, 23);
            this.btne.TabIndex = 4;
            this.btne.Text = "exit";
            this.btne.UseVisualStyleBackColor = true;
            this.btne.Click += new System.EventHandler(this.btne_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btne);
            this.Controls.Add(this.tinhtong);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox tong;
        private System.Windows.Forms.Button tinhtong;
        private System.Windows.Forms.Button btne;
    }
}