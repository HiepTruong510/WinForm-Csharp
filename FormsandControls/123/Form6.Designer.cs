
namespace _123
{
    partial class Form6
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
            this.tenKetQua = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tenKetQua
            // 
            this.tenKetQua.Location = new System.Drawing.Point(343, 57);
            this.tenKetQua.Name = "tenKetQua";
            this.tenKetQua.Size = new System.Drawing.Size(245, 22);
            this.tenKetQua.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstMatHang
            // 
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.ItemHeight = 16;
            this.lstMatHang.Items.AddRange(new object[] {
            "CPU",
            "Ram",
            "Audio Card",
            "Mouse",
            "Hiep"});
            this.lstMatHang.Location = new System.Drawing.Point(25, 24);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.Size = new System.Drawing.Size(260, 356);
            this.lstMatHang.TabIndex = 2;
            this.lstMatHang.SelectedIndexChanged += new System.EventHandler(this.lstMatHang_SelectedIndexChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lstMatHang);
            this.Controls.Add(this.tenKetQua);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenKetQua;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstMatHang;
    }
}