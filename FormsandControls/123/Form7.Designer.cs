
namespace _123
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatHang = new System.Windows.Forms.ListBox();
            this.DaChon = new System.Windows.Forms.ListBox();
            this.moveone = new System.Windows.Forms.Button();
            this.moveall = new System.Windows.Forms.Button();
            this.removeone = new System.Windows.Forms.Button();
            this.removeall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách các mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các mặt hàng lựa chọn";
            // 
            // MatHang
            // 
            this.MatHang.FormattingEnabled = true;
            this.MatHang.ItemHeight = 16;
            this.MatHang.Items.AddRange(new object[] {
            "CPU",
            "Ram",
            "KeyBoard",
            "NIC",
            "Mouse",
            "FAN"});
            this.MatHang.Location = new System.Drawing.Point(31, 50);
            this.MatHang.Name = "MatHang";
            this.MatHang.Size = new System.Drawing.Size(230, 260);
            this.MatHang.TabIndex = 2;
            // 
            // DaChon
            // 
            this.DaChon.FormattingEnabled = true;
            this.DaChon.ItemHeight = 16;
            this.DaChon.Items.AddRange(new object[] {
            "lstDaChon"});
            this.DaChon.Location = new System.Drawing.Point(522, 50);
            this.DaChon.Name = "DaChon";
            this.DaChon.Size = new System.Drawing.Size(226, 260);
            this.DaChon.TabIndex = 3;
            // 
            // moveone
            // 
            this.moveone.Location = new System.Drawing.Point(356, 77);
            this.moveone.Name = "moveone";
            this.moveone.Size = new System.Drawing.Size(75, 34);
            this.moveone.TabIndex = 4;
            this.moveone.Text = ">";
            this.moveone.UseVisualStyleBackColor = true;
            this.moveone.Click += new System.EventHandler(this.moveone_Click);
            // 
            // moveall
            // 
            this.moveall.Location = new System.Drawing.Point(356, 131);
            this.moveall.Name = "moveall";
            this.moveall.Size = new System.Drawing.Size(75, 37);
            this.moveall.TabIndex = 5;
            this.moveall.Text = ">>";
            this.moveall.UseVisualStyleBackColor = true;
            this.moveall.Click += new System.EventHandler(this.moveall_Click);
            // 
            // removeone
            // 
            this.removeone.Location = new System.Drawing.Point(356, 184);
            this.removeone.Name = "removeone";
            this.removeone.Size = new System.Drawing.Size(75, 36);
            this.removeone.TabIndex = 6;
            this.removeone.Text = "<";
            this.removeone.UseVisualStyleBackColor = true;
            this.removeone.Click += new System.EventHandler(this.removeone_Click);
            // 
            // removeall
            // 
            this.removeall.Location = new System.Drawing.Point(356, 238);
            this.removeall.Name = "removeall";
            this.removeall.Size = new System.Drawing.Size(75, 33);
            this.removeall.TabIndex = 7;
            this.removeall.Text = "<<";
            this.removeall.UseVisualStyleBackColor = true;
            this.removeall.Click += new System.EventHandler(this.removeall_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeall);
            this.Controls.Add(this.removeone);
            this.Controls.Add(this.moveall);
            this.Controls.Add(this.moveone);
            this.Controls.Add(this.DaChon);
            this.Controls.Add(this.MatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox MatHang;
        private System.Windows.Forms.ListBox DaChon;
        private System.Windows.Forms.Button moveone;
        private System.Windows.Forms.Button moveall;
        private System.Windows.Forms.Button removeone;
        private System.Windows.Forms.Button removeall;
    }
}