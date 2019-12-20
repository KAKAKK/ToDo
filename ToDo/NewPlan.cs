using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDo
{
    public partial class NewPlan : Form
    {
        //水印
        private const String DEFAULT_TEXT = "例如 地点/人物/"; 
        private const String DEFAULT_TEXT2= "你准备什么时候在什么地方做什么事？";

        public NewPlan()
        {
            InitializeComponent();

            SetDefaultText();

            keyword.GotFocus += new EventHandler(text_Enter);
            keyword.LostFocus += new EventHandler(text_Leave);

            planTxt.GotFocus += new EventHandler(text_Enter2);
            planTxt.LostFocus += new EventHandler(text_Leave2);




        }


        private void NewPlan_Load(object sender, EventArgs e)
        {
        }

        //点击添加
        private void Commit_Click(object sender, EventArgs e)
        {
            //数据库连接
            string sqlStr = "Server=KAKA\\SQLEXP;User Id=sa;Pwd=123456;DataBase=ToDoDB";
            SqlConnection conn = new SqlConnection(sqlStr);
            conn.Open();

            //数据库连接测试
            /*if (conn.State == ConnectionState.Open)
             {
                 MessageBox.Show("aaaaa");

             }*/

            //程度取值
            string grade ;
            if (major.Checked)
            {
                //重要==1
                grade = "重要";
            }
            else if (normal.Checked)
            {
                //一般==2
                grade = "一般";
            }
            else 
            { 
                //缓慢==3
                grade = "缓慢"; 
            }

            //状态取值
            string statu ;
            if (unStart.Checked)
            {
                //未开始==1
                statu = "未开始";
            }
            else if (doing.Checked)
            {
                //进行中==2
                statu = "进行中";
            }
            else
            {
                //已完成==3
                statu = "已完成";
            }

            //空值不能提交
            if (string.IsNullOrEmpty(keyword.Text))
            {
                MessageBox.Show("标题要写");
                keyword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(planTxt.Text))
            {
                MessageBox.Show("具体内容还没写");
                planTxt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(type.Text))
            {
                MessageBox.Show("计划类型没选择");
                type.Focus();
                return;
            }


            //插入语句
            string strSql = "insert into myPlan(KeyWord,PlanText,Grade,Statu,Type,BeginTime,EndTime) values('" + keyword.Text + "','" + planTxt.Text+"','" + grade+ "','"+statu+"','" + type.SelectedItem+ "','"+ beginTime.Value.ToString()+"','"+ endTime.Value.ToString()+"')";

            //单个测试
            //string strSql = "insert into myPlan(Type) values('" + type.SelectedItem+ "')";
            //  string strSql = "insert into myPlan(Grade) values('" + grade+ "')";
            //string strSql = "insert into myPlan(BeginTime) values('"+ beginTime.Value.ToString()+"')";
            //  string strSql = "insert into myPlan(PlanText) values('"+ planTxt.Text + "')";
          


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = strSql;

            //判断是否执行成功
            if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
            {
                MessageBox.Show("计划添加成功,记得执行喔!!!");

                //关闭数据库连接
                conn.Close();

                //返回到主界面home
                Home home = new Home();
                home.Show();
                this.Close();

            }

           
           
             
        }

        //点击取消
        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        //设置默认文本1
        private void SetDefaultText()
        {
             keyword.Text = DEFAULT_TEXT;
            keyword.ForeColor = Color.Gray;         
        }

        private void SetDefaultText2()
        {       
            planTxt.Text = DEFAULT_TEXT2;
            planTxt.ForeColor = Color.Gray;
        }

        //获取焦点事件 Enter
        private void text_Enter(object sender, EventArgs e)
        {
             if (keyword.Text == DEFAULT_TEXT)
             {
                keyword.Text = "";
                keyword.ForeColor = Color.Black;
             }

        }

        private void text_Enter2(object sender, EventArgs e)
        {                     

            if (planTxt.Text == DEFAULT_TEXT2)
            {
                planTxt.Text = "";
                planTxt.ForeColor = Color.Black;
            }
        }

        //失去焦点事件 Leave
        private void text_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(keyword.Text))
            {
                SetDefaultText();
            }

        }

        private void text_Leave2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(planTxt.Text))
            {
                SetDefaultText2();
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
