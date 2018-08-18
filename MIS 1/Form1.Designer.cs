using System;

namespace MIS
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_load = new System.Windows.Forms.Button();
            this.tb_分数 = new System.Windows.Forms.TextBox();
            this.tb_课程名 = new System.Windows.Forms.TextBox();
            this.tb_姓名 = new System.Windows.Forms.TextBox();
            this.tb_学号 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置为只读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.某行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.某列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.某单元格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改某单元格数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.冻结行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.冻结列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助和关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按学号排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按成绩降序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按成绩升序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按学号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按分数筛选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准之上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准之下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助和关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.btn_load);
            this.splitContainer1.Panel1.Controls.Add(this.tb_分数);
            this.splitContainer1.Panel1.Controls.Add(this.tb_课程名);
            this.splitContainer1.Panel1.Controls.Add(this.tb_姓名);
            this.splitContainer1.Panel1.Controls.Add(this.tb_学号);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(678, 331);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.Location = new System.Drawing.Point(85, 254);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "加载";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.tbn_load);
            // 
            // tb_分数
            // 
            this.tb_分数.Location = new System.Drawing.Point(60, 183);
            this.tb_分数.Name = "tb_分数";
            this.tb_分数.Size = new System.Drawing.Size(165, 21);
            this.tb_分数.TabIndex = 7;
            // 
            // tb_课程名
            // 
            this.tb_课程名.Location = new System.Drawing.Point(59, 146);
            this.tb_课程名.Name = "tb_课程名";
            this.tb_课程名.Size = new System.Drawing.Size(166, 21);
            this.tb_课程名.TabIndex = 6;
            // 
            // tb_姓名
            // 
            this.tb_姓名.Location = new System.Drawing.Point(58, 110);
            this.tb_姓名.Name = "tb_姓名";
            this.tb_姓名.Size = new System.Drawing.Size(166, 21);
            this.tb_姓名.TabIndex = 5;
            // 
            // tb_学号
            // 
            this.tb_学号.Location = new System.Drawing.Point(60, 76);
            this.tb_学号.Name = "tb_学号";
            this.tb_学号.Size = new System.Drawing.Size(166, 21);
            this.tb_学号.TabIndex = 4;
            this.tb_学号.TextChanged += new System.EventHandler(this.tb_学号_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "分数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助和关于ToolStripMenuItem,
            this.帮助和关于ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.保存为txtToolStripMenuItem,
            this.保存为excelToolStripMenuItem,
            this.设置为只读ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 保存为txtToolStripMenuItem
            // 
            this.保存为txtToolStripMenuItem.Name = "保存为txtToolStripMenuItem";
            this.保存为txtToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.保存为txtToolStripMenuItem.Text = "保存为txt";
            this.保存为txtToolStripMenuItem.Click += new System.EventHandler(this.保存为txtToolStripMenuItem_Click);
            // 
            // 保存为excelToolStripMenuItem
            // 
            this.保存为excelToolStripMenuItem.Name = "保存为excelToolStripMenuItem";
            this.保存为excelToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.保存为excelToolStripMenuItem.Text = "保存为excel";
            this.保存为excelToolStripMenuItem.Click += new System.EventHandler(this.保存为excelToolStripMenuItem_Click);
            // 
            // 设置为只读ToolStripMenuItem
            // 
            this.设置为只读ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部ToolStripMenuItem,
            this.某行ToolStripMenuItem,
            this.某列ToolStripMenuItem,
            this.某单元格ToolStripMenuItem});
            this.设置为只读ToolStripMenuItem.Name = "设置为只读ToolStripMenuItem";
            this.设置为只读ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.设置为只读ToolStripMenuItem.Text = "设置为只读";
            this.设置为只读ToolStripMenuItem.Click += new System.EventHandler(this.设置为只读ToolStripMenuItem_Click);
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // 某行ToolStripMenuItem
            // 
            this.某行ToolStripMenuItem.Name = "某行ToolStripMenuItem";
            this.某行ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.某行ToolStripMenuItem.Text = "某行";
            this.某行ToolStripMenuItem.Click += new System.EventHandler(this.某行ToolStripMenuItem_Click);
            // 
            // 某列ToolStripMenuItem
            // 
            this.某列ToolStripMenuItem.Name = "某列ToolStripMenuItem";
            this.某列ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.某列ToolStripMenuItem.Text = "某列";
            // 
            // 某单元格ToolStripMenuItem
            // 
            this.某单元格ToolStripMenuItem.Name = "某单元格ToolStripMenuItem";
            this.某单元格ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.某单元格ToolStripMenuItem.Text = "某单元格";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.修改某单元格数据ToolStripMenuItem,
            this.添加学生信息ToolStripMenuItem,
            this.冻结行ToolStripMenuItem,
            this.冻结列ToolStripMenuItem,
            this.隐藏行ToolStripMenuItem,
            this.隐藏列ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改ToolStripMenuItem.Text = "修改某行数据";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 修改某单元格数据ToolStripMenuItem
            // 
            this.修改某单元格数据ToolStripMenuItem.Name = "修改某单元格数据ToolStripMenuItem";
            this.修改某单元格数据ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改某单元格数据ToolStripMenuItem.Text = "修改某单元格数据";
            this.修改某单元格数据ToolStripMenuItem.Click += new System.EventHandler(this.修改某单元格数据ToolStripMenuItem_Click);
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // 冻结行ToolStripMenuItem
            // 
            this.冻结行ToolStripMenuItem.Name = "冻结行ToolStripMenuItem";
            this.冻结行ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.冻结行ToolStripMenuItem.Text = "冻结选中行";
            this.冻结行ToolStripMenuItem.Click += new System.EventHandler(this.冻结行ToolStripMenuItem_Click);
            // 
            // 冻结列ToolStripMenuItem
            // 
            this.冻结列ToolStripMenuItem.Name = "冻结列ToolStripMenuItem";
            this.冻结列ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.冻结列ToolStripMenuItem.Text = "冻结选中列";
            this.冻结列ToolStripMenuItem.Click += new System.EventHandler(this.冻结列ToolStripMenuItem_Click);
            // 
            // 隐藏行ToolStripMenuItem
            // 
            this.隐藏行ToolStripMenuItem.Name = "隐藏行ToolStripMenuItem";
            this.隐藏行ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.隐藏行ToolStripMenuItem.Text = "隐藏选中行";
            this.隐藏行ToolStripMenuItem.Click += new System.EventHandler(this.隐藏行ToolStripMenuItem_Click);
            // 
            // 隐藏列ToolStripMenuItem
            // 
            this.隐藏列ToolStripMenuItem.Name = "隐藏列ToolStripMenuItem";
            this.隐藏列ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.隐藏列ToolStripMenuItem.Text = "隐藏选中列";
            // 
            // 帮助和关于ToolStripMenuItem
            // 
            this.帮助和关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按学号排序ToolStripMenuItem,
            this.按成绩降序ToolStripMenuItem,
            this.按成绩升序ToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.按分数筛选ToolStripMenuItem});
            this.帮助和关于ToolStripMenuItem.Name = "帮助和关于ToolStripMenuItem";
            this.帮助和关于ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助和关于ToolStripMenuItem.Text = "筛选";
            // 
            // 按学号排序ToolStripMenuItem
            // 
            this.按学号排序ToolStripMenuItem.Name = "按学号排序ToolStripMenuItem";
            this.按学号排序ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.按学号排序ToolStripMenuItem.Text = "按学号排序";
            this.按学号排序ToolStripMenuItem.Click += new System.EventHandler(this.按学号排序ToolStripMenuItem_Click);
            // 
            // 按成绩降序ToolStripMenuItem
            // 
            this.按成绩降序ToolStripMenuItem.Name = "按成绩降序ToolStripMenuItem";
            this.按成绩降序ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.按成绩降序ToolStripMenuItem.Text = "按成绩降序";
            this.按成绩降序ToolStripMenuItem.Click += new System.EventHandler(this.按成绩降序ToolStripMenuItem_Click);
            // 
            // 按成绩升序ToolStripMenuItem
            // 
            this.按成绩升序ToolStripMenuItem.Name = "按成绩升序ToolStripMenuItem";
            this.按成绩升序ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.按成绩升序ToolStripMenuItem.Text = "按成绩升序";
            this.按成绩升序ToolStripMenuItem.Click += new System.EventHandler(this.按成绩升序ToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按学号ToolStripMenuItem,
            this.按姓名ToolStripMenuItem,
            this.按成绩ToolStripMenuItem,
            this.按课程ToolStripMenuItem});
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 按学号ToolStripMenuItem
            // 
            this.按学号ToolStripMenuItem.Name = "按学号ToolStripMenuItem";
            this.按学号ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.按学号ToolStripMenuItem.Text = "按学号";
            this.按学号ToolStripMenuItem.Click += new System.EventHandler(this.按学号ToolStripMenuItem_Click);
            // 
            // 按姓名ToolStripMenuItem
            // 
            this.按姓名ToolStripMenuItem.Name = "按姓名ToolStripMenuItem";
            this.按姓名ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.按姓名ToolStripMenuItem.Text = "按姓名";
            this.按姓名ToolStripMenuItem.Click += new System.EventHandler(this.按姓名ToolStripMenuItem_Click);
            // 
            // 按成绩ToolStripMenuItem
            // 
            this.按成绩ToolStripMenuItem.Name = "按成绩ToolStripMenuItem";
            this.按成绩ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.按成绩ToolStripMenuItem.Text = "按成绩";
            this.按成绩ToolStripMenuItem.Click += new System.EventHandler(this.按成绩ToolStripMenuItem_Click);
            // 
            // 按课程ToolStripMenuItem
            // 
            this.按课程ToolStripMenuItem.Name = "按课程ToolStripMenuItem";
            this.按课程ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.按课程ToolStripMenuItem.Text = "按课程";
            this.按课程ToolStripMenuItem.Click += new System.EventHandler(this.按课程ToolStripMenuItem_Click);
            // 
            // 按分数筛选ToolStripMenuItem
            // 
            this.按分数筛选ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标准之上ToolStripMenuItem,
            this.标准之下ToolStripMenuItem});
            this.按分数筛选ToolStripMenuItem.Name = "按分数筛选ToolStripMenuItem";
            this.按分数筛选ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.按分数筛选ToolStripMenuItem.Text = "按分数筛选";
            // 
            // 标准之上ToolStripMenuItem
            // 
            this.标准之上ToolStripMenuItem.Name = "标准之上ToolStripMenuItem";
            this.标准之上ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.标准之上ToolStripMenuItem.Text = "标准之上";
            this.标准之上ToolStripMenuItem.Click += new System.EventHandler(this.标准之上ToolStripMenuItem_Click);
            // 
            // 标准之下ToolStripMenuItem
            // 
            this.标准之下ToolStripMenuItem.Name = "标准之下ToolStripMenuItem";
            this.标准之下ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.标准之下ToolStripMenuItem.Text = "标准之下";
            this.标准之下ToolStripMenuItem.Click += new System.EventHandler(this.标准之下ToolStripMenuItem_Click);
            // 
            // 帮助和关于ToolStripMenuItem1
            // 
            this.帮助和关于ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助和关于ToolStripMenuItem1.Name = "帮助和关于ToolStripMenuItem1";
            this.帮助和关于ToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.帮助和关于ToolStripMenuItem1.Text = "帮助";
            this.帮助和关于ToolStripMenuItem1.Click += new System.EventHandler(this.帮助和关于ToolStripMenuItem1_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(428, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 331);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_分数;
        private System.Windows.Forms.TextBox tb_课程名;
        private System.Windows.Forms.TextBox tb_姓名;
        private System.Windows.Forms.TextBox tb_学号;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存为txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存为excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助和关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按学号排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按成绩降序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按成绩升序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助和关于ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改某单元格数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按学号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按分数筛选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标准之上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标准之下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 冻结行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 冻结列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置为只读ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 某行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 某列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 某单元格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

