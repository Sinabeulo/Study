namespace Winform
{
    partial class Form1
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
            this.btn_TagEx = new System.Windows.Forms.Button();
            this.pn_ExArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_TagEx
            // 
            this.btn_TagEx.Location = new System.Drawing.Point(12, 12);
            this.btn_TagEx.Name = "btn_TagEx";
            this.btn_TagEx.Size = new System.Drawing.Size(91, 31);
            this.btn_TagEx.TabIndex = 0;
            this.btn_TagEx.Text = "Tag Ex";
            this.btn_TagEx.UseVisualStyleBackColor = true;
            this.btn_TagEx.Click += new System.EventHandler(this.btn_TagEx_Click);
            // 
            // pn_ExArea
            // 
            this.pn_ExArea.Location = new System.Drawing.Point(115, 53);
            this.pn_ExArea.Name = "pn_ExArea";
            this.pn_ExArea.Size = new System.Drawing.Size(673, 385);
            this.pn_ExArea.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_ExArea);
            this.Controls.Add(this.btn_TagEx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TagEx;
        private System.Windows.Forms.Panel pn_ExArea;
    }
}

