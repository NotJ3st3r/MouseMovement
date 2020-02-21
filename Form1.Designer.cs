namespace MouseMovement
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
            this.components = new System.ComponentModel.Container();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.tmr_mouse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_pos.Location = new System.Drawing.Point(12, 9);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(46, 17);
            this.lbl_pos.TabIndex = 0;
            this.lbl_pos.Text = "label1";
            // 
            // tmr_mouse
            // 
            this.tmr_mouse.Enabled = true;
            this.tmr_mouse.Interval = 1;
            this.tmr_mouse.Tick += new System.EventHandler(this.tmr_mouse_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 38);
            this.Controls.Add(this.lbl_pos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Timer tmr_mouse;
    }
}

