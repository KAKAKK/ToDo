using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDo
{
    public partial class Home : Form
    {
        //连接数据库
        string sqlStr = "Server=KAKA\\SQLEXP;User Id=sa;Pwd=123456;DataBase=ToDoDB";
        //声明Linq连接对象
        DataClasses1DataContext linq;

        //选中的编号初始化为0
        //string strID = "";
        int intID = 0;

        //记录页数，设定一页能显示的数量，可随意更改pageSize
        int pageSize = 2;

        //记录当前页
        int page = 0;



        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“toDoDBDataSet1.myPlan”中。您可以根据需要移动或删除它。
            //使用dataGridView myPlanSource4
            //this.myPlanTableAdapter1.Fill(this.toDoDBDataSet1.myPlan);

            //使用Linq查询
            BindInfo();
            BindInfo2();

            //分页，设置0为当前页
            page = 0;

            //有分页的DateGridView
            bindGrid();

            //设置颜色
            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (dgvRow.Index % 2 == 0)
                {
                    dataGridView1.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightCyan;
                }
                else
                {
                    dataGridView1.Rows[dgvRow.Index].DefaultCellStyle.BackColor = Color.LightPink;
                }

            }



        }


        //点击新计划添加计划
        private void 新计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlan newPlan = new NewPlan();
            newPlan.Show();
            this.Hide();
        }

        //点击新想法添加想法
        private void 新想法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewIdea newIdea = new NewIdea();
            newIdea.Show();

        }

        //点击日历计划，查看日历
        private void 日历计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanCalendar planCalendar = new PlanCalendar();
            planCalendar.Show();

        }

        //数据视图表
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中的编号，
            //strID = Convert.ToString(dataGridView1[1,e.RowIndex].Value).Trim();
            intID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            //建立连接
            linq = new DataClasses1DataContext(sqlStr);

            //查询
            var result = from info in linq.myPlan
                         where info.Id == intID
                         select new
                         {
                             编号 = info.Id,
                             关键词 = info.KeyWord,
                             具体内容 = info.PlanText,
                             程度 = info.Grade,
                             状态 = info.Statu,
                             类型 = info.Type,
                             开始时间 = info.BeginTime,
                             截止时间 = info.EndTime,

                         };

            //将查询到的显示到文本框中
            foreach (var item in result)
            {
                txtStatu.Text = item.状态;
                txtType.Text = item.类型;

            }
        }



        //Linq查询方法
        private void BindInfo()
        {
            linq = new DataClasses1DataContext(sqlStr);

            if (condition.Text == "")
            {
                /* var result = from info in linq.myPlan
                              select new
                              {
                                  编号 = info.Id,
                                  关键词 = info.KeyWord,
                                  具体内容 = info.PlanText,
                                  程度 = info.Grade,
                                  状态 = info.Statu,
                                  类型 = info.Type,
                                  开始时间 = info.BeginTime,
                                  截止时间 = info.EndTime,

                              };

                 dataGridView1.DataSource = result;*/


                //获取当前页数
                int pageIndex = Convert.ToInt32(page);

                //对查询到的数据进行分页
                var result = (from info in linq.myPlan
                              select new
                              {
                                  编号 = info.Id,
                                  关键词 = info.KeyWord,
                                  具体内容 = info.PlanText,
                                  程度 = info.Grade,
                                  状态 = info.Statu,
                                  类型 = info.Type,
                                  开始时间 = info.BeginTime,
                                  截止时间 = info.EndTime,
                              }).Skip(pageSize * pageIndex).Take(pageSize);

                dataGridView1.DataSource = result;

                headPage.Enabled = backPage.Enabled = nextPage.Enabled = endPage.Enabled = true;

                //如果为第一页，禁止首页和上一页
                if (page == 0)
                {
                    headPage.Enabled = false;
                    backPage.Enabled = false;
                }

                //如果是最后一页，禁止尾页和下一页
                if (page == getCount() - 1)
                {
                    endPage.Enabled = false;
                    nextPage.Enabled = false;

                }


            }
            else
            {
                switch (select.Text)
                {
                    case "程度":

                        var resultGrade = from info in linq.myPlan
                                          where info.Grade == condition.Text
                                          select new
                                          {
                                              编号 = info.Id,
                                              关键词 = info.KeyWord,
                                              具体内容 = info.PlanText,
                                              程度 = info.Grade,
                                              状态 = info.Statu,
                                              类型 = info.Type,
                                              开始时间 = info.BeginTime,
                                              截止时间 = info.EndTime,

                                          };
                        dataGridView1.DataSource = resultGrade;
                        break;

                    case "状态":

                        var resultStatu = from info in linq.myPlan
                                          where info.Statu == condition.Text
                                          select new
                                          {
                                              编号 = info.Id,
                                              关键词 = info.KeyWord,
                                              具体内容 = info.PlanText,
                                              程度 = info.Grade,
                                              状态 = info.Statu,
                                              类型 = info.Type,
                                              开始时间 = info.BeginTime,
                                              截止时间 = info.EndTime,

                                          };
                        dataGridView1.DataSource = resultStatu;
                        break;


                    case "类型":

                        var resultType = from info in linq.myPlan
                                         where info.Type == condition.Text
                                         select new
                                         {
                                             编号 = info.Id,
                                             关键词 = info.KeyWord,
                                             具体内容 = info.PlanText,
                                             程度 = info.Grade,
                                             状态 = info.Statu,
                                             类型 = info.Type,
                                             开始时间 = info.BeginTime,
                                             截止时间 = info.EndTime,

                                         };
                        dataGridView1.DataSource = resultType;
                        break;


                }

            }



        }

        //返回全部数据
        private void BindInfo2()
        {
            linq = new DataClasses1DataContext(sqlStr);

            
            
                var result = from info in linq.myPlan
                             select new
                             {
                                 编号 = info.Id,
                                 关键词 = info.KeyWord,
                                 具体内容 = info.PlanText,
                                 程度 = info.Grade,
                                 状态 = info.Statu,
                                 类型 = info.Type,
                                 开始时间 = info.BeginTime,
                                 截止时间 = info.EndTime,

                             };

                dataGridView1.DataSource = result;
            

        }

        //查询选择
        private void select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select.Text == "全部")
            {
                condition.Items.Clear();


            }
            else if (select.Text == "程度")
            {
                //清空上一次的结果
                condition.Items.Clear();
                //condition.Text ="重要";
                string[] strGrade = { "重要", "一般", "缓慢" };
                //添加数组
                condition.Items.AddRange(strGrade);
                //设置“重要”为默认选项
                condition.SelectedIndex = 0;


            }
            else if (select.Text == "状态")
            {
                condition.Items.Clear();
                string[] strStatu = { "未开始", "进行中", "已完成" };
                condition.Items.AddRange(strStatu);
                condition.SelectedIndex = 0;

                //condition.Text = "进行中";
            }
            else
            {
                condition.Items.Clear();
                //  condition.Text = "日常";
                string[] strType = { "日常", "学习", "工作" };
                condition.Items.AddRange(strType);
                condition.SelectedIndex = 1;

            }
        }

        //点击查询
        private void check_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        //右键删除
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("kkk");

            if (intID == 0)
            {
                MessageBox.Show("请选择你要删除的计划编号");
                return;
            }
            else
            {
                //对话框
                DialogResult dialogResult = MessageBox.Show("确定要删除这项计划吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("ppp");

                    /*  linq = new DataClasses1DataContext(sqlStr);

                      var del = from info in linq.myPlan
                                where info.Id == intID
                                select info;

                        linq.myPlan.DeleteAllOnSubmit(del);
                      linq.SubmitChanges();
                      MessageBox.Show("计划删除成功");
                        BindInfo2();*/

                }


            }
        }

        //右键设置提醒
        private void 设置提醒toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (intID == 0)
            {
                MessageBox.Show("请选择你要设置提醒的计划编号");
                return;
            }
            else
            {
                //对话框
                DialogResult dialogResult = MessageBox.Show("确定要更改提醒设置吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    //MessageBox.Show("ppp");

                      SetAlarm setAlarm = new SetAlarm(intID);
                    setAlarm.Show();
                    


                    /*  linq = new DataClasses1DataContext(sqlStr);

                      var del = from info in linq.myPlan
                                where info.Id == intID
                                select info;

                        linq.myPlan.DeleteAllOnSubmit(del);
                      linq.SubmitChanges();
                      MessageBox.Show("计划删除成功");
                        BindInfo2();*/

                }
            }
        }


        //点击更改
        private void change_Click(object sender, EventArgs e)
        {

            if (intID == 0)
            {
                MessageBox.Show("请选择你要删除的计划编号");
                return;
            }
            else
            {
                //对话框
                DialogResult dialogResult = MessageBox.Show("确定要更改这项计划吗?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                      MessageBox.Show("ppp");

                    /* linq = new DataClasses1DataContext(sqlStr);

                     var change = from info in linq.myPlan
                                  where info.Id == intID
                                  select info;

                     foreach (myPlan plan in change)
                     {
                         plan.Statu = txtStatu.Text;
                         plan.Type = txtType.Text;
                     }

                     //提交更改
                     linq.SubmitChanges();

                     MessageBox.Show("计划修改成功");*/

                    //BindInfo2();
                    BindInfo();

                }
                else
                {
                    MessageBox.Show("计划没有修改");

                }
            }
        }


        /*分页操作，国庆完成*/
        //计算总页数
        protected int getCount()
        {
           // linq = new DataClasses1DataContext(sqlStr);
            //获取总页数
            int sum = linq.myPlan.Count();

            //获取可以分的页面
            int s1 = sum / pageSize;

            //如果取余大于0返回1
            int s2 = sum % pageSize > 0 ? 1 : 0;

            //计算出总页数
            int count = s1 + s2;
            return count;


        
        }

        protected void bindGrid()
        {
            linq = new DataClasses1DataContext(sqlStr);

            //获取当前页数
            int pageIndex = Convert.ToInt32(page);

            //对查询到的数据进行分页
            var result = (from info in linq.myPlan
                          select new
                          {
                              编号 = info.Id,
                              关键词 = info.KeyWord,
                              具体内容 = info.PlanText,
                              程度 = info.Grade,
                              状态 = info.Statu,
                              类型 = info.Type,
                              开始时间 = info.BeginTime,
                              截止时间 = info.EndTime,
                          }).Skip(pageSize * pageIndex).Take(pageSize);

            dataGridView1.DataSource = result;

            headPage.Enabled = backPage.Enabled = nextPage.Enabled = endPage.Enabled = true;

            //如果为第一页，禁止首页和上一页
            if (page == 0)
            {
                headPage.Enabled = false;
                backPage.Enabled = false;
            }

            //如果是最后一页，禁止尾页和下一页
            if (page == getCount() - 1)
            {
                endPage.Enabled = false;
                nextPage.Enabled = false;
            
            }
        
        }

        //首页
        private void headPage_Click(object sender, EventArgs e)
        {
            page = 0;
            // bindGrid();
            BindInfo();
        }

        //下一页
        private void nextPage_Click(object sender, EventArgs e)
        {
            page = page + 1;
            //bindGrid();
            BindInfo();
        }

        //上一页
        private void backPage_Click(object sender, EventArgs e)
        {
            page = page - 1;
            //bindGrid();
            BindInfo();
        }

        //尾页
        private void endPage_Click(object sender, EventArgs e)
        {
            page = getCount()-1;
            // bindGrid();
            BindInfo();
        }


    }
}
