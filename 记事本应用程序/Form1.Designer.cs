
namespace 记事本应用程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.打开记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViserble = new System.Windows.Forms.ToolStripMenuItem();
            this.tbShow = new System.Windows.Forms.TextBox();
            this.panelFather = new System.Windows.Forms.Panel();
            this.btnviserble = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panelFather.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.样式ToolStripMenuItem,
            this.打开记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenFile,
            this.tsmSaveFile});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // tsmOpenFile
            // 
            this.tsmOpenFile.Name = "tsmOpenFile";
            this.tsmOpenFile.Size = new System.Drawing.Size(122, 26);
            this.tsmOpenFile.Text = "打开";
            this.tsmOpenFile.Click += new System.EventHandler(this.tsmOpenFile_Click);
            // 
            // tsmSaveFile
            // 
            this.tsmSaveFile.Name = "tsmSaveFile";
            this.tsmSaveFile.Size = new System.Drawing.Size(122, 26);
            this.tsmSaveFile.Text = "保存";
            this.tsmSaveFile.Click += new System.EventHandler(this.tsmSaveFile_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWordWrap});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // tsmWordWrap
            // 
            this.tsmWordWrap.Name = "tsmWordWrap";
            this.tsmWordWrap.Size = new System.Drawing.Size(152, 26);
            this.tsmWordWrap.Text = "自动换行";
            this.tsmWordWrap.Click += new System.EventHandler(this.tsmWordWrap_Click);
            // 
            // 样式ToolStripMenuItem
            // 
            this.样式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFont,
            this.tsmColor});
            this.样式ToolStripMenuItem.Name = "样式ToolStripMenuItem";
            this.样式ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.样式ToolStripMenuItem.Text = "样式";
            // 
            // tsmFont
            // 
            this.tsmFont.Name = "tsmFont";
            this.tsmFont.Size = new System.Drawing.Size(122, 26);
            this.tsmFont.Text = "字体";
            this.tsmFont.Click += new System.EventHandler(this.tsmFont_Click);
            // 
            // tsmColor
            // 
            this.tsmColor.Name = "tsmColor";
            this.tsmColor.Size = new System.Drawing.Size(122, 26);
            this.tsmColor.Text = "颜色";
            this.tsmColor.Click += new System.EventHandler(this.tsmColor_Click);
            // 
            // 打开记录ToolStripMenuItem
            // 
            this.打开记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShow,
            this.tsmViserble});
            this.打开记录ToolStripMenuItem.Name = "打开记录ToolStripMenuItem";
            this.打开记录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.打开记录ToolStripMenuItem.Text = "打开记录";
            // 
            // tsmShow
            // 
            this.tsmShow.Name = "tsmShow";
            this.tsmShow.Size = new System.Drawing.Size(122, 26);
            this.tsmShow.Text = "显示";
            this.tsmShow.Click += new System.EventHandler(this.tsmShow_Click);
            // 
            // tsmViserble
            // 
            this.tsmViserble.Name = "tsmViserble";
            this.tsmViserble.Size = new System.Drawing.Size(122, 26);
            this.tsmViserble.Text = "隐藏";
            this.tsmViserble.Click += new System.EventHandler(this.tsmViserble_Click);
            // 
            // tbShow
            // 
            this.tbShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShow.Location = new System.Drawing.Point(0, 32);
            this.tbShow.Multiline = true;
            this.tbShow.Name = "tbShow";
            this.tbShow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbShow.Size = new System.Drawing.Size(806, 608);
            this.tbShow.TabIndex = 1;
            // 
            // panelFather
            // 
            this.panelFather.Controls.Add(this.btnviserble);
            this.panelFather.Controls.Add(this.listbox);
            this.panelFather.Location = new System.Drawing.Point(0, 32);
            this.panelFather.Name = "panelFather";
            this.panelFather.Size = new System.Drawing.Size(211, 611);
            this.panelFather.TabIndex = 2;
            // 
            // btnviserble
            // 
            this.btnviserble.Location = new System.Drawing.Point(177, 245);
            this.btnviserble.Name = "btnviserble";
            this.btnviserble.Size = new System.Drawing.Size(30, 93);
            this.btnviserble.TabIndex = 1;
            this.btnviserble.Text = "<";
            this.btnviserble.UseVisualStyleBackColor = true;
            this.btnviserble.Click += new System.EventHandler(this.btnviserble_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 15;
            this.listbox.Location = new System.Drawing.Point(0, 4);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(171, 604);
            this.listbox.TabIndex = 0;
            this.listbox.DoubleClick += new System.EventHandler(this.listbox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 643);
            this.Controls.Add(this.panelFather);
            this.Controls.Add(this.tbShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFather.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenFile;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveFile;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmWordWrap;
        private System.Windows.Forms.ToolStripMenuItem 样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmFont;
        private System.Windows.Forms.ToolStripMenuItem tsmColor;
        private System.Windows.Forms.ToolStripMenuItem 打开记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmShow;
        private System.Windows.Forms.ToolStripMenuItem tsmViserble;
        private System.Windows.Forms.TextBox tbShow;
        private System.Windows.Forms.Panel panelFather;
        private System.Windows.Forms.Button btnviserble;
        private System.Windows.Forms.ListBox listbox;
    }
}

