namespace pixeleditor_core
{
    partial class ToolBoxForm
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
            this.colorList1 = new pixeleditor_core.ColorList();
            this.toolBox1 = new pixeleditor_core.ToolBox();
            this.SuspendLayout();
            // 
            // colorList1
            // 
            this.colorList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorList1.Location = new System.Drawing.Point(11, 104);
            this.colorList1.Name = "colorList1";
            this.colorList1.Size = new System.Drawing.Size(236, 334);
            this.colorList1.TabIndex = 1;
            this.colorList1.Load += new System.EventHandler(this.colorList1_Load);
            // 
            // toolBox1
            // 
            this.toolBox1.Location = new System.Drawing.Point(8, 12);
            this.toolBox1.Name = "toolBox1";
            this.toolBox1.Size = new System.Drawing.Size(248, 463);
            this.toolBox1.TabIndex = 0;
            this.toolBox1.Load += new System.EventHandler(this.toolBox1_Load);
            // 
            // ToolBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 444);
            this.ControlBox = false;
            this.Controls.Add(this.colorList1);
            this.Controls.Add(this.toolBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ToolBoxForm";
            this.Text = "Tool Box :3";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private ToolBox toolBox1;
        private ColorList colorList1;
    }
}