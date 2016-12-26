namespace WindowsFormsApplication1
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.近一月ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从高到低ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从低到高ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.搜索ToolStripMenuItem,
            this.分数ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日期ToolStripMenuItem,
            this.近一月ToolStripMenuItem,
            this.自定义ToolStripMenuItem});
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.搜索ToolStripMenuItem.Text = "日期";
            // 
            // 日期ToolStripMenuItem
            // 
            this.日期ToolStripMenuItem.Name = "日期ToolStripMenuItem";
            this.日期ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.日期ToolStripMenuItem.Text = "近一周";
            // 
            // 近一月ToolStripMenuItem
            // 
            this.近一月ToolStripMenuItem.Name = "近一月ToolStripMenuItem";
            this.近一月ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.近一月ToolStripMenuItem.Text = "近一月";
            // 
            // 自定义ToolStripMenuItem
            // 
            this.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem";
            this.自定义ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.自定义ToolStripMenuItem.Text = "自定义";
            // 
            // 分数ToolStripMenuItem
            // 
            this.分数ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从高到低ToolStripMenuItem,
            this.从低到高ToolStripMenuItem});
            this.分数ToolStripMenuItem.Name = "分数ToolStripMenuItem";
            this.分数ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.分数ToolStripMenuItem.Text = "分数";
            // 
            // 从高到低ToolStripMenuItem
            // 
            this.从高到低ToolStripMenuItem.Name = "从高到低ToolStripMenuItem";
            this.从高到低ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.从高到低ToolStripMenuItem.Text = "从高到低";
            // 
            // 从低到高ToolStripMenuItem
            // 
            this.从低到高ToolStripMenuItem.Name = "从低到高ToolStripMenuItem";
            this.从低到高ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.从低到高ToolStripMenuItem.Text = "从低到高";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(379, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(444, 191);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史记录";
            this.Load += new System.EventHandler(this.history_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 近一月ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分数ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从高到低ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从低到高ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}