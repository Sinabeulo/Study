namespace Winform
{
    partial class TagExUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.lb_Tag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(3, 17);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(129, 24);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create Buttons";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lb_Tag
            // 
            this.lb_Tag.AutoSize = true;
            this.lb_Tag.Location = new System.Drawing.Point(156, 26);
            this.lb_Tag.Name = "lb_Tag";
            this.lb_Tag.Size = new System.Drawing.Size(45, 15);
            this.lb_Tag.TabIndex = 1;
            this.lb_Tag.Text = "label1";
            // 
            // TagExUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Tag);
            this.Controls.Add(this.btn_create);
            this.Name = "TagExUC";
            this.Size = new System.Drawing.Size(456, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lb_Tag;
    }
}
