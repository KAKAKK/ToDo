using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class SetAlarm : Form
    {
        //设置获取的id的变量
        int getId;
        public SetAlarm(int planId)
        {
            //将myPlan表的id 传给 getId
            getId = planId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "Server=LAPTOP-QRR6ABS1;User Id=sa;Pwd=123456;DataBase=ToDoDB";
            SqlConnection conn = new SqlConnection(sqlStr);
            conn.Open();
           
            
            int a = Int32.Parse(nud_Days.Value.ToString());
            int b = Int32.Parse(nud_TimeInterval.Value.ToString());
            int update = 0;
            int qwe = 0;
           
            
            
            if (chb_IsAutoCheck.Checked)
            {
                update = 1;
            }
            if (chb_IsTimeCue.Checked)
            {
                qwe = 1;
            }
          
            
            string strSql = "insert into setalarm(Id,day,int,int1,time) values('"+getId+"','" + a + "','" + update + "','" + qwe + "','" + b + "')";

            string strSql1 = "upadte setalarm set day='" + a + "',int='" + update + "',int1='" + qwe + "',time='" + b + " ' where Id= 1 ";

            // string strSql1 = "upadte setalarm set day='" + a + "' where Id='" + myId.Text + "'";

            //string strSql1 = "upadte setalarm set day=1 where Id=1";

            SqlCommand sqlcmd = new SqlCommand("select * from setalarm where Id='" + myId.Text + "'", conn);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
           
            
            try
            {
                if (sqldr.HasRows)
                {
                    command.CommandText = strSql1;
                }
                else
                {
                  
                    command.CommandText = strSql;

                }            

            }
            catch { 
            
            
            }
            finally
            {
                sqldr.Close();
               

            }
            
            
            //判断是否执行成功
            if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
            {
                conn.Close();
                //返回到主界面home
                MessageBox.Show("成功");
               
                if(chb_IsTimeCue.Checked){
                    timer1.Interval = Convert.ToInt32(nud_TimeInterval.Value * 3600 * 1000);
                    timer1.Enabled = true;

                }
                else
                {

                    timer1.Enabled = false;

                }
            }
        }
       
        private void TiXing_Load(object sender, EventArgs e)
        {
            //将id显示到文本框中
            myId.Text = getId.ToString();
            string sqlStr = "Server=KAKA\\SQLEXP;User Id=sa;Pwd=123456;DataBase=ToDoDB";
            SqlConnection conn = new SqlConnection(sqlStr);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from setalarm where Id='" + myId.Text+ "'", conn);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            try
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        if ((int)sqldr["int"] == 1)
                        {
                            chb_IsAutoCheck.Checked = true;
                        }
                        if ((int)sqldr["int1"] == 1)
                        {
                            chb_IsTimeCue.Checked = true;
                        }


                        nud_TimeInterval.Value = Int32.Parse(sqldr["time"].ToString());

                        nud_Days.Value = Int32.Parse(sqldr["day"].ToString());
                    }

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }

            finally
            {
                sqldr.Close();
                conn.Close();


            
            }

        }


    }
}
