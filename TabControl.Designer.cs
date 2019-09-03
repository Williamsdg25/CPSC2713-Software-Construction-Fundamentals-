namespace WebBrowser.UI
{
    partial class TabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.backbttn = new System.Windows.Forms.ToolStripButton();
            this.forwardBttn = new System.Windows.Forms.ToolStripButton();
            this.refreshBttn = new System.Windows.Forms.ToolStripButton();
            this.homeBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goBttn = new System.Windows.Forms.ToolStripButton();
            this.bookmarkBttn = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backbttn,
            this.forwardBttn,
            this.refreshBttn,
            this.homeBttn,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.goBttn,
            this.bookmarkBttn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1188, 39);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // backbttn
            // 
            this.backbttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backbttn.Image = ((System.Drawing.Image)(resources.GetObject("backbttn.Image")));
            this.backbttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backbttn.Name = "backbttn";
            this.backbttn.Size = new System.Drawing.Size(36, 36);
            this.backbttn.Text = "Back";
            this.backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // forwardBttn
            // 
            this.forwardBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardBttn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBttn.Image")));
            this.forwardBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBttn.Name = "forwardBttn";
            this.forwardBttn.Size = new System.Drawing.Size(36, 36);
            this.forwardBttn.Text = "Forward";
            this.forwardBttn.Click += new System.EventHandler(this.ForwardBttn_Click);
            // 
            // refreshBttn
            // 
            this.refreshBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBttn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBttn.Image")));
            this.refreshBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBttn.Name = "refreshBttn";
            this.refreshBttn.Size = new System.Drawing.Size(36, 36);
            this.refreshBttn.Text = "Refresh";
            this.refreshBttn.Click += new System.EventHandler(this.RefreshBttn_Click);
            // 
            // homeBttn
            // 
            this.homeBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeBttn.Image = ((System.Drawing.Image)(resources.GetObject("homeBttn.Image")));
            this.homeBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBttn.Name = "homeBttn";
            this.homeBttn.Size = new System.Drawing.Size(36, 36);
            this.homeBttn.Text = "Home";
            this.homeBttn.Click += new System.EventHandler(this.HomeBttn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(800, 39);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // goBttn
            // 
            this.goBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBttn.Image = ((System.Drawing.Image)(resources.GetObject("goBttn.Image")));
            this.goBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBttn.Name = "goBttn";
            this.goBttn.Size = new System.Drawing.Size(36, 36);
            this.goBttn.Text = "Go";
            this.goBttn.Click += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // bookmarkBttn
            // 
            this.bookmarkBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkBttn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkBttn.Image")));
            this.bookmarkBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkBttn.Name = "bookmarkBttn";
            this.bookmarkBttn.Size = new System.Drawing.Size(36, 36);
            this.bookmarkBttn.Text = "Bookmark";
            this.bookmarkBttn.Click += new System.EventHandler(this.BookmarkBttn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1188, 753);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebBrowser1_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar1,
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 754);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 38);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.AutoSize = false;
            this.ProgressBar1.MarqueeAnimationSpeed = 1000;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(200, 32);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoSize = false;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(238, 33);
            this.StatusLabel1.MouseHover += new System.EventHandler(this.ToolStripTextBox1_Click);
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "TabControl";
            this.Size = new System.Drawing.Size(1188, 792);
            this.Load += new System.EventHandler(this.TabControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton backbttn;
        private System.Windows.Forms.ToolStripButton forwardBttn;
        private System.Windows.Forms.ToolStripButton refreshBttn;
        private System.Windows.Forms.ToolStripButton homeBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton goBttn;
        private System.Windows.Forms.ToolStripButton bookmarkBttn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
    }
}
