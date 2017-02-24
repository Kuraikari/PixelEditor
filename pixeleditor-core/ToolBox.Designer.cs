namespace pixeleditor_core
{
    partial class ToolBox
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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(3, 34);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(3, 60);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(43, 13);
            this.lblOpacity.TabIndex = 1;
            this.lblOpacity.Text = "Opacity";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(52, 31);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 2;
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(52, 57);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(100, 20);
            this.txtOpacity.TabIndex = 3;
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOpacity);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.lblSize);
            this.Name = "ToolBox";
            this.Size = new System.Drawing.Size(204, 382);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtOpacity;
    }
}
