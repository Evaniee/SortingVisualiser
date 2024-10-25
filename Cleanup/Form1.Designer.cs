namespace Cleanup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_btn_generateArray = new System.Windows.Forms.ToolStripButton();
            this.ts_lbl_waitTime = new System.Windows.Forms.ToolStripLabel();
            this.ts_txt_waitTime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_startStop = new System.Windows.Forms.ToolStripButton();
            this.pb_visualiser = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_generateArray,
            this.toolStripSeparator2,
            this.ts_btn_startStop,
            this.toolStripSeparator3,
            this.ts_lbl_waitTime,
            this.ts_txt_waitTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_generateArray
            // 
            this.ts_btn_generateArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_generateArray.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_generateArray.Image")));
            this.ts_btn_generateArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_generateArray.Name = "ts_btn_generateArray";
            this.ts_btn_generateArray.Size = new System.Drawing.Size(89, 22);
            this.ts_btn_generateArray.Text = "Generate Array";
            this.ts_btn_generateArray.Click += new System.EventHandler(this.ts_btn_generateArray_Click);
            // 
            // ts_lbl_waitTime
            // 
            this.ts_lbl_waitTime.Name = "ts_lbl_waitTime";
            this.ts_lbl_waitTime.Size = new System.Drawing.Size(61, 22);
            this.ts_lbl_waitTime.Text = "Wait (ms):";
            // 
            // ts_txt_waitTime
            // 
            this.ts_txt_waitTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_txt_waitTime.Name = "ts_txt_waitTime";
            this.ts_txt_waitTime.Size = new System.Drawing.Size(100, 25);
            this.ts_txt_waitTime.TextChanged += new System.EventHandler(this.ts_txt_waitTime_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_btn_startStop
            // 
            this.ts_btn_startStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_startStop.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_startStop.Image")));
            this.ts_btn_startStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_startStop.Name = "ts_btn_startStop";
            this.ts_btn_startStop.Size = new System.Drawing.Size(35, 22);
            this.ts_btn_startStop.Text = "Start";
            this.ts_btn_startStop.Click += new System.EventHandler(this.ts_btn_startStop_Click);
            // 
            // pb_visualiser
            // 
            this.pb_visualiser.Location = new System.Drawing.Point(12, 28);
            this.pb_visualiser.Name = "pb_visualiser";
            this.pb_visualiser.Size = new System.Drawing.Size(776, 410);
            this.pb_visualiser.TabIndex = 1;
            this.pb_visualiser.TabStop = false;
            this.pb_visualiser.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_visualiser_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_visualiser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visualiser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_btn_generateArray;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_btn_startStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ts_lbl_waitTime;
        private System.Windows.Forms.ToolStripTextBox ts_txt_waitTime;
        private System.Windows.Forms.PictureBox pb_visualiser;
    }
}

