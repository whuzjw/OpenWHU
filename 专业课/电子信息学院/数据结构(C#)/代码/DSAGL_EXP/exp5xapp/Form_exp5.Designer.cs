﻿namespace exp5xapp
{
    partial class Form_exp5
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
            this.l2O_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l2XML_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l2D_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SSL1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l2O_StripMenuItem,
            this.l2XML_StripMenuItem,
            this.l2D_StripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // l2O_StripMenuItem
            // 
            this.l2O_StripMenuItem.Name = "l2O_StripMenuItem";
            this.l2O_StripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.l2O_StripMenuItem.Text = "Linq2Object";
            this.l2O_StripMenuItem.Click += new System.EventHandler(this.l2O_StripMenuItem_Click);
            // 
            // l2XML_StripMenuItem
            // 
            this.l2XML_StripMenuItem.Name = "l2XML_StripMenuItem";
            this.l2XML_StripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.l2XML_StripMenuItem.Text = "Linq2XML";
            this.l2XML_StripMenuItem.Click += new System.EventHandler(this.l2XML_StripMenuItem_Click);
            // 
            // l2D_StripMenuItem
            // 
            this.l2D_StripMenuItem.Name = "l2D_StripMenuItem";
            this.l2D_StripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.l2D_StripMenuItem.Text = "Linq2DataSet";
            this.l2D_StripMenuItem.Click += new System.EventHandler(this.l2D_StripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(26, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 18);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "请输入机器人名字：";
            // 
            // tb_input
            // 
            this.tb_input.AcceptsReturn = true;
            this.tb_input.AutoCompleteCustomSource.AddRange(new string[] {
            "悟空",
            "八戒",
            "沙僧",
            "AlphaGo",
            "AlphaGoZero"});
            this.tb_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_input.Location = new System.Drawing.Point(167, 39);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(148, 25);
            this.tb_input.TabIndex = 2;
            this.tb_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_input_KeyDown);
            // 
            // bt_search
            // 
            this.bt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_search.Font = new System.Drawing.Font("宋体", 12F);
            this.bt_search.Location = new System.Drawing.Point(406, 31);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(95, 40);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // tb_result
            // 
            this.tb_result.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_result.Location = new System.Drawing.Point(26, 74);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(509, 209);
            this.tb_result.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSL1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SSL1
            // 
            this.SSL1.Name = "SSL1";
            this.SSL1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_exp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_exp5";
            this.Text = "Search by Linq";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem l2O_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem l2XML_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem l2D_StripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel SSL1;
    }
}

