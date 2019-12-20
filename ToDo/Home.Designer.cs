namespace ToDo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.我的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新想法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新观点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计划提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日历计划ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小助手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myPlanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.toDoDBDataSet1 = new ToDo.ToDoDBDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.endPage = new System.Windows.Forms.Button();
            this.headPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.backPage = new System.Windows.Forms.Button();
            this.myPlanTableAdapter1 = new ToDo.ToDoDBDataSet1TableAdapters.myPlanTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置提醒toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPlanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDBDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的ToolStripMenuItem,
            this.新计划ToolStripMenuItem,
            this.新想法ToolStripMenuItem,
            this.新观点ToolStripMenuItem,
            this.计划提醒ToolStripMenuItem,
            this.日历计划ToolStripMenuItem,
            this.小助手ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 我的ToolStripMenuItem
            // 
            this.我的ToolStripMenuItem.Name = "我的ToolStripMenuItem";
            this.我的ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.我的ToolStripMenuItem.Text = "我的收藏";
            // 
            // 新计划ToolStripMenuItem
            // 
            this.新计划ToolStripMenuItem.Name = "新计划ToolStripMenuItem";
            this.新计划ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.新计划ToolStripMenuItem.Text = "新计划";
            this.新计划ToolStripMenuItem.Click += new System.EventHandler(this.新计划ToolStripMenuItem_Click);
            // 
            // 新想法ToolStripMenuItem
            // 
            this.新想法ToolStripMenuItem.Name = "新想法ToolStripMenuItem";
            this.新想法ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.新想法ToolStripMenuItem.Text = "新想法";
            this.新想法ToolStripMenuItem.Click += new System.EventHandler(this.新想法ToolStripMenuItem_Click);
            // 
            // 新观点ToolStripMenuItem
            // 
            this.新观点ToolStripMenuItem.Name = "新观点ToolStripMenuItem";
            this.新观点ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.新观点ToolStripMenuItem.Text = "新观点";
            // 
            // 计划提醒ToolStripMenuItem
            // 
            this.计划提醒ToolStripMenuItem.Name = "计划提醒ToolStripMenuItem";
            this.计划提醒ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.计划提醒ToolStripMenuItem.Text = "计划提醒";
            // 
            // 日历计划ToolStripMenuItem
            // 
            this.日历计划ToolStripMenuItem.Name = "日历计划ToolStripMenuItem";
            this.日历计划ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.日历计划ToolStripMenuItem.Text = "计划日历";
            this.日历计划ToolStripMenuItem.Click += new System.EventHandler(this.日历计划ToolStripMenuItem_Click);
            // 
            // 小助手ToolStripMenuItem
            // 
            this.小助手ToolStripMenuItem.Name = "小助手ToolStripMenuItem";
            this.小助手ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.小助手ToolStripMenuItem.Text = "小助手";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "写计划是为了更有效的管理时间，更高效的生活";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // select
            // 
            this.select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "全部",
            "程度",
            "状态",
            "类型"});
            this.select.Location = new System.Drawing.Point(69, 45);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(152, 33);
            this.select.TabIndex = 2;
            this.select.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(932, 239);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // myPlanBindingSource4
            // 
            this.myPlanBindingSource4.DataMember = "myPlan";
            this.myPlanBindingSource4.DataSource = this.toDoDBDataSet1;
            // 
            // toDoDBDataSet1
            // 
            this.toDoDBDataSet1.DataSetName = "ToDoDBDataSet1";
            this.toDoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(269, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "限制";
            // 
            // condition
            // 
            this.condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition.FormattingEnabled = true;
            this.condition.Location = new System.Drawing.Point(341, 45);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(148, 33);
            this.condition.TabIndex = 5;
            // 
            // check
            // 
            this.check.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.check.Location = new System.Drawing.Point(526, 45);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(80, 36);
            this.check.TabIndex = 6;
            this.check.Text = "查询";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.select);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.condition);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "高级操作设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.endPage);
            this.groupBox2.Controls.Add(this.headPage);
            this.groupBox2.Controls.Add(this.nextPage);
            this.groupBox2.Controls.Add(this.backPage);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(630, 83);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分页操作";
            // 
            // endPage
            // 
            this.endPage.Location = new System.Drawing.Point(497, 35);
            this.endPage.Name = "endPage";
            this.endPage.Size = new System.Drawing.Size(109, 32);
            this.endPage.TabIndex = 9;
            this.endPage.Text = "尾页";
            this.endPage.UseVisualStyleBackColor = true;
            this.endPage.Click += new System.EventHandler(this.endPage_Click);
            // 
            // headPage
            // 
            this.headPage.Location = new System.Drawing.Point(11, 33);
            this.headPage.Name = "headPage";
            this.headPage.Size = new System.Drawing.Size(109, 32);
            this.headPage.TabIndex = 6;
            this.headPage.Text = "首页";
            this.headPage.UseVisualStyleBackColor = true;
            this.headPage.Click += new System.EventHandler(this.headPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(175, 33);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(109, 32);
            this.nextPage.TabIndex = 7;
            this.nextPage.Text = "下一页";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // backPage
            // 
            this.backPage.Location = new System.Drawing.Point(341, 35);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(109, 32);
            this.backPage.TabIndex = 8;
            this.backPage.Text = "上一页";
            this.backPage.UseVisualStyleBackColor = true;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // myPlanTableAdapter1
            // 
            this.myPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem1,
            this.设置提醒toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // 设置提醒toolStripMenuItem1
            // 
            this.设置提醒toolStripMenuItem1.Name = "设置提醒toolStripMenuItem1";
            this.设置提醒toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.设置提醒toolStripMenuItem1.Text = "设置提醒";
            this.设置提醒toolStripMenuItem1.Click += new System.EventHandler(this.设置提醒toolStripMenuItem1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtStatu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.change);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(648, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(272, 201);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "更改操作";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(96, 102);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(128, 36);
            this.txtType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "类型";
            // 
            // txtStatu
            // 
            this.txtStatu.Location = new System.Drawing.Point(95, 42);
            this.txtStatu.Name = "txtStatu";
            this.txtStatu.Size = new System.Drawing.Size(129, 36);
            this.txtStatu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "状态";
            // 
            // change
            // 
            this.change.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.change.Location = new System.Drawing.Point(96, 153);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(128, 41);
            this.change.TabIndex = 0;
            this.change.Text = "更改";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPlanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoDBDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 我的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新计划ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计划提醒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小助手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日历计划ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 新想法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新观点ToolStripMenuItem;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.GroupBox groupBox1;
        private ToDoDBDataSet1 toDoDBDataSet1;
        private ToDoDBDataSet1TableAdapters.myPlanTableAdapter myPlanTableAdapter1;
        private System.Windows.Forms.BindingSource myPlanBindingSource4;
   
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button endPage;
        private System.Windows.Forms.Button headPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button backPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.ToolStripMenuItem 设置提醒toolStripMenuItem1;
    }
}