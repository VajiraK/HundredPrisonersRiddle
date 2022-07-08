namespace HundredPrisonersGUI
{
    partial class BoxControl
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
            this.lblOutside = new System.Windows.Forms.Label();
            this.lblInside = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutside
            // 
            this.lblOutside.AutoSize = true;
            this.lblOutside.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblOutside.Location = new System.Drawing.Point(3, 3);
            this.lblOutside.Name = "lblOutside";
            this.lblOutside.Size = new System.Drawing.Size(27, 19);
            this.lblOutside.TabIndex = 0;
            this.lblOutside.Text = "34";
            // 
            // lblInside
            // 
            this.lblInside.AutoSize = true;
            this.lblInside.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInside.Location = new System.Drawing.Point(18, 29);
            this.lblInside.Name = "lblInside";
            this.lblInside.Size = new System.Drawing.Size(27, 19);
            this.lblInside.TabIndex = 1;
            this.lblInside.Text = "97";
            this.lblInside.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInside);
            this.Controls.Add(this.lblOutside);
            this.Name = "BoxControl";
            this.Size = new System.Drawing.Size(50, 50);
            this.Load += new System.EventHandler(this.BoxControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutside;
        private System.Windows.Forms.Label lblInside;
    }
}
