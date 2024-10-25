namespace Visualiser
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
            this.ts_btn_randomise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_allowDuplicates = new System.Windows.Forms.ToolStripButton();
            this.ts_lbl_length = new System.Windows.Forms.ToolStripLabel();
            this.ts_txt_length = new System.Windows.Forms.ToolStripTextBox();
            this.ts_lbl_min = new System.Windows.Forms.ToolStripLabel();
            this.ts_txt_min = new System.Windows.Forms.ToolStripTextBox();
            this.ts_lbl_max = new System.Windows.Forms.ToolStripLabel();
            this.ts_txt_max = new System.Windows.Forms.ToolStripTextBox();
            this.ts_lbl_interval = new System.Windows.Forms.ToolStripLabel();
            this.ts_txt_interval = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_bubbleSort = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_quickSort = new System.Windows.Forms.ToolStripButton();
            this.pb_visualiser = new System.Windows.Forms.PictureBox();
            this.ts_btn_bogoSort = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_visualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_randomise,
            this.toolStripSeparator1,
            this.ts_btn_allowDuplicates,
            this.ts_lbl_length,
            this.ts_txt_length,
            this.ts_lbl_min,
            this.ts_txt_min,
            this.ts_lbl_max,
            this.ts_txt_max,
            this.ts_lbl_interval,
            this.ts_txt_interval,
            this.toolStripSeparator2,
            this.ts_btn_bubbleSort,
            this.ts_btn_quickSort,
            this.ts_btn_bogoSort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_randomise
            // 
            this.ts_btn_randomise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_randomise.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_randomise.Image")));
            this.ts_btn_randomise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_randomise.Name = "ts_btn_randomise";
            this.ts_btn_randomise.Size = new System.Drawing.Size(70, 22);
            this.ts_btn_randomise.Text = "Randomise";
            this.ts_btn_randomise.ToolTipText = "Replace the current data with a randomised array.";
            this.ts_btn_randomise.Click += new System.EventHandler(this.ts_btn_randomise_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_btn_allowDuplicates
            // 
            this.ts_btn_allowDuplicates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_allowDuplicates.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_allowDuplicates.Image")));
            this.ts_btn_allowDuplicates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_allowDuplicates.Name = "ts_btn_allowDuplicates";
            this.ts_btn_allowDuplicates.Size = new System.Drawing.Size(98, 22);
            this.ts_btn_allowDuplicates.Text = "Duplicates: False";
            this.ts_btn_allowDuplicates.Click += new System.EventHandler(this.ts_btn_allowDuplicates_Click);
            // 
            // ts_lbl_length
            // 
            this.ts_lbl_length.Name = "ts_lbl_length";
            this.ts_lbl_length.Size = new System.Drawing.Size(47, 22);
            this.ts_lbl_length.Text = "Length:";
            // 
            // ts_txt_length
            // 
            this.ts_txt_length.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_txt_length.MaxLength = 4;
            this.ts_txt_length.Name = "ts_txt_length";
            this.ts_txt_length.Size = new System.Drawing.Size(50, 25);
            this.ts_txt_length.Text = "360";
            // 
            // ts_lbl_min
            // 
            this.ts_lbl_min.Name = "ts_lbl_min";
            this.ts_lbl_min.Size = new System.Drawing.Size(63, 22);
            this.ts_lbl_min.Text = "Minimum:";
            // 
            // ts_txt_min
            // 
            this.ts_txt_min.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_txt_min.MaxLength = 3;
            this.ts_txt_min.Name = "ts_txt_min";
            this.ts_txt_min.Size = new System.Drawing.Size(25, 25);
            this.ts_txt_min.Text = "1";
            // 
            // ts_lbl_max
            // 
            this.ts_lbl_max.Name = "ts_lbl_max";
            this.ts_lbl_max.Size = new System.Drawing.Size(65, 22);
            this.ts_lbl_max.Text = "Maximum:";
            // 
            // ts_txt_max
            // 
            this.ts_txt_max.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_txt_max.MaxLength = 3;
            this.ts_txt_max.Name = "ts_txt_max";
            this.ts_txt_max.Size = new System.Drawing.Size(25, 25);
            this.ts_txt_max.Text = "360";
            // 
            // ts_lbl_interval
            // 
            this.ts_lbl_interval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_lbl_interval.Name = "ts_lbl_interval";
            this.ts_lbl_interval.Size = new System.Drawing.Size(46, 22);
            this.ts_lbl_interval.Text = "Interval";
            // 
            // ts_txt_interval
            // 
            this.ts_txt_interval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ts_txt_interval.MaxLength = 5;
            this.ts_txt_interval.Name = "ts_txt_interval";
            this.ts_txt_interval.Size = new System.Drawing.Size(50, 25);
            this.ts_txt_interval.Text = "10";
            this.ts_txt_interval.TextChanged += new System.EventHandler(this.ts_txt_interval_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ts_btn_bubbleSort
            // 
            this.ts_btn_bubbleSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_bubbleSort.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_bubbleSort.Image")));
            this.ts_btn_bubbleSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_bubbleSort.Name = "ts_btn_bubbleSort";
            this.ts_btn_bubbleSort.Size = new System.Drawing.Size(72, 22);
            this.ts_btn_bubbleSort.Text = "Bubble Sort";
            this.ts_btn_bubbleSort.Click += new System.EventHandler(this.ts_btn_bubbleSort_Click);
            // 
            // ts_btn_quickSort
            // 
            this.ts_btn_quickSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_quickSort.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_quickSort.Image")));
            this.ts_btn_quickSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_quickSort.Name = "ts_btn_quickSort";
            this.ts_btn_quickSort.Size = new System.Drawing.Size(66, 22);
            this.ts_btn_quickSort.Text = "Quick Sort";
            this.ts_btn_quickSort.Click += new System.EventHandler(this.ts_btn_quickSort_Click);
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
            // ts_btn_bogoSort
            // 
            this.ts_btn_bogoSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_btn_bogoSort.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_bogoSort.Image")));
            this.ts_btn_bogoSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_bogoSort.Name = "ts_btn_bogoSort";
            this.ts_btn_bogoSort.Size = new System.Drawing.Size(63, 22);
            this.ts_btn_bogoSort.Text = "Bogo Sort";
            this.ts_btn_bogoSort.Click += new System.EventHandler(this.ts_btn_bogoSort_Click);
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
        private System.Windows.Forms.ToolStripButton ts_btn_randomise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ts_lbl_length;
        private System.Windows.Forms.ToolStripTextBox ts_txt_length;
        private System.Windows.Forms.ToolStripLabel ts_lbl_min;
        private System.Windows.Forms.ToolStripTextBox ts_txt_min;
        private System.Windows.Forms.ToolStripLabel ts_lbl_max;
        private System.Windows.Forms.ToolStripTextBox ts_txt_max;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pb_visualiser;
        private System.Windows.Forms.ToolStripButton ts_btn_quickSort;
        private System.Windows.Forms.ToolStripLabel ts_lbl_interval;
        private System.Windows.Forms.ToolStripTextBox ts_txt_interval;
        private System.Windows.Forms.ToolStripButton ts_btn_allowDuplicates;
        private System.Windows.Forms.ToolStripButton ts_btn_bubbleSort;
        private System.Windows.Forms.ToolStripButton ts_btn_bogoSort;
    }
}

