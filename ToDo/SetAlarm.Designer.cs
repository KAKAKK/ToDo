namespace ToDo
{
    partial class SetAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetAlarm));
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Days = new System.Windows.Forms.NumericUpDown();
            this.chb_IsAutoCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.chb_IsTimeCue = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "提前提醒天数:";
            // 
            // nud_Days
            // 
            this.nud_Days.Location = new System.Drawing.Point(252, 66);
            this.nud_Days.Margin = new System.Windows.Forms.Padding(5);
            this.nud_Days.Name = "nud_Days";
            this.nud_Days.Size = new System.Drawing.Size(70, 36);
            this.nud_Days.TabIndex = 1;
            // 
            // chb_IsAutoCheck
            // 
            this.chb_IsAutoCheck.AutoSize = true;
            this.chb_IsAutoCheck.Location = new System.Drawing.Point(59, 211);
            this.chb_IsAutoCheck.Margin = new System.Windows.Forms.Padding(5);
            this.chb_IsAutoCheck.Name = "chb_IsAutoCheck";
            this.chb_IsAutoCheck.Size = new System.Drawing.Size(412, 29);
            this.chb_IsAutoCheck.TabIndex = 2;
            this.chb_IsAutoCheck.Text = "系统启动自动检查最近计划任务";
            this.chb_IsAutoCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "每隔";
            // 
            // nud_TimeInterval
            // 
            this.nud_TimeInterval.Location = new System.Drawing.Point(323, 333);
            this.nud_TimeInterval.Margin = new System.Windows.Forms.Padding(5);
            this.nud_TimeInterval.Name = "nud_TimeInterval";
            this.nud_TimeInterval.Size = new System.Drawing.Size(95, 36);
            this.nud_TimeInterval.TabIndex = 5;
          
            // 
            // chb_IsTimeCue
            // 
            this.chb_IsTimeCue.AutoSize = true;
            this.chb_IsTimeCue.Location = new System.Drawing.Point(59, 340);
            this.chb_IsTimeCue.Margin = new System.Windows.Forms.Padding(5);
            this.chb_IsTimeCue.Name = "chb_IsTimeCue";
            this.chb_IsTimeCue.Size = new System.Drawing.Size(142, 29);
            this.chb_IsTimeCue.TabIndex = 6;
            this.chb_IsTimeCue.Text = "实时提醒";
            this.chb_IsTimeCue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "小时提醒一次";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "编号";
            // 
            // myId
            // 
            this.myId.Location = new System.Drawing.Point(763, 66);
            this.myId.Margin = new System.Windows.Forms.Padding(5);
            this.myId.Name = "myId";
            this.myId.Size = new System.Drawing.Size(70, 36);
            this.myId.TabIndex = 9;
            // 
            // SetAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.myId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chb_IsTimeCue);
            this.Controls.Add(this.nud_TimeInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_IsAutoCheck);
            this.Controls.Add(this.nud_Days);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SetAlarm";
            this.Text = "提醒设置";
            this.Load += new System.EventHandler(this.TiXing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Days;
        private System.Windows.Forms.CheckBox chb_IsAutoCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_TimeInterval;
        private System.Windows.Forms.CheckBox chb_IsTimeCue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox myId;
        private System.Windows.Forms.Timer timer1;
    }
}