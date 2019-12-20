namespace ToDo
{
    partial class NewPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlan));
            this.planTxt = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.slow = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unStart = new System.Windows.Forms.RadioButton();
            this.doing = new System.Windows.Forms.RadioButton();
            this.done = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beginTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.Commit = new System.Windows.Forms.Button();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // planTxt
            // 
            this.planTxt.BackColor = System.Drawing.SystemColors.Info;
            this.planTxt.Location = new System.Drawing.Point(56, 168);
            this.planTxt.Multiline = true;
            this.planTxt.Name = "planTxt";
            this.planTxt.Size = new System.Drawing.Size(475, 393);
            this.planTxt.TabIndex = 0;
            // 
            // major
            // 
            this.major.AutoSize = true;
            this.major.Location = new System.Drawing.Point(83, 39);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(58, 19);
            this.major.TabIndex = 1;
            this.major.Text = "重要";
            this.major.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Location = new System.Drawing.Point(162, 39);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(58, 19);
            this.normal.TabIndex = 2;
            this.normal.TabStop = true;
            this.normal.Text = "一般";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // slow
            // 
            this.slow.AutoSize = true;
            this.slow.Location = new System.Drawing.Point(241, 39);
            this.slow.Name = "slow";
            this.slow.Size = new System.Drawing.Size(58, 19);
            this.slow.TabIndex = 3;
            this.slow.Text = "缓慢";
            this.slow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "程度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(572, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "状态";
            // 
            // unStart
            // 
            this.unStart.AutoSize = true;
            this.unStart.Checked = true;
            this.unStart.Location = new System.Drawing.Point(658, 147);
            this.unStart.Name = "unStart";
            this.unStart.Size = new System.Drawing.Size(73, 19);
            this.unStart.TabIndex = 6;
            this.unStart.TabStop = true;
            this.unStart.Text = "未开始";
            this.unStart.UseVisualStyleBackColor = true;
            // 
            // doing
            // 
            this.doing.AutoSize = true;
            this.doing.Location = new System.Drawing.Point(737, 147);
            this.doing.Name = "doing";
            this.doing.Size = new System.Drawing.Size(73, 19);
            this.doing.TabIndex = 7;
            this.doing.Text = "进行中";
            this.doing.UseVisualStyleBackColor = true;
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.Location = new System.Drawing.Point(816, 147);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(73, 19);
            this.done.TabIndex = 8;
            this.done.Text = "已完成";
            this.done.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(571, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "类型";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "学习",
            "日常",
            "工作"});
            this.type.Location = new System.Drawing.Point(675, 215);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(169, 23);
            this.type.TabIndex = 10;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.major);
            this.panel1.Controls.Add(this.normal);
            this.panel1.Controls.Add(this.slow);
            this.panel1.Location = new System.Drawing.Point(575, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 100);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(571, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "开始时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(572, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "结束时间";
            // 
            // beginTime
            // 
            this.beginTime.Location = new System.Drawing.Point(675, 283);
            this.beginTime.Name = "beginTime";
            this.beginTime.Size = new System.Drawing.Size(169, 25);
            this.beginTime.TabIndex = 14;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(675, 364);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(169, 25);
            this.endTime.TabIndex = 15;
            // 
            // Commit
            // 
            this.Commit.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Commit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Commit.Location = new System.Drawing.Point(576, 461);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(155, 45);
            this.Commit.TabIndex = 16;
            this.Commit.Text = "添加";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // keyword
            // 
            this.keyword.BackColor = System.Drawing.Color.Tan;
            this.keyword.Location = new System.Drawing.Point(33, 46);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(328, 25);
            this.keyword.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(29, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "关键词";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(29, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "具体内容";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(763, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.beginTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.done);
            this.Controls.Add(this.doing);
            this.Controls.Add(this.unStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlan";
            this.RightToLeftLayout = true;
            this.Text = "新计划";
            this.Load += new System.EventHandler(this.NewPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox planTxt;
        private System.Windows.Forms.RadioButton major;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton slow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton unStart;
        private System.Windows.Forms.RadioButton doing;
        private System.Windows.Forms.RadioButton done;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker beginTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}