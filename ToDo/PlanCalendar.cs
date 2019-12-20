using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class PlanCalendar : Form
    {
        public PlanCalendar()
        {
            InitializeComponent();
        }
        TableLayoutPanel table = new TableLayoutPanel();
        //DateTime dt = DateTime.Parse("2019 - 06 - 01");
        //DateTime dt = DateTime.Parse("2019 - 07 - 01");
        DateTime dt = DateTime.Now;

        private void Form1_Load(object sender, EventArgs e)
        {
            table.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            .SetValue(table, true, null);
            tablePrint();

        }
        public void tablePrint()
        {
            table.Dock = DockStyle.Fill;
            panel1.Controls.Add(table);
            textBox1.Text = "";
            label1.Text = dt.Year + "年" + dt.Month + "月" + dt.Day + "日日程";

            table.ColumnCount = 7;          
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));    
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, table.Width * 0.142857f));

            table.RowCount = 7;          
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.1f));    
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));    
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));
            table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, table.Height * 0.15f));
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;

            int day = dt.Day;//当天
            DateTime cdt = dt.AddDays(1 - dt.Day);//当月第一天
            int OneInWeek = dw(cdt.DayOfWeek);//当月第一天星期
            int Days = DateTime.DaysInMonth(dt.Year, dt.Month);//当月天数
            DateTime ndt = dt.AddDays(1 - dt.Day).AddMonths(1);//下个月
            DateTime pdt = dt.AddMonths(-1);//上个月
            int PDays = DateTime.DaysInMonth(pdt.Year, pdt.Month);//上个月天数
            
            float height = table.Height * 0.15f;
            float width = table.Width * 0.142857f;
            int Tmonth = dt.Month;

            ArrayList list = new ArrayList();
            int i, k, n, weekday;
            String[] weekStr = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", };

            String SQLStr = "Server=KAKA\\SQLEXP;User Id=sa;Pwd=123456;DataBase=ToDoDB";
            SqlConnection sqlcon = new SqlConnection(SQLStr);
            sqlcon.Open();
            if (sqlcon.State == ConnectionState.Open)
            {
                //MessageBox.Show("数据库连接成功");
            }
            SqlCommand sqlcmd = new SqlCommand("Select * from myPlan", sqlcon);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            try
            {
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        list.Add(sqldr.GetDateTime(6));
                        list.Add(sqldr.GetDateTime(7));
                        int t1 = dt.CompareTo(sqldr.GetDateTime(6));
                        int t2 = dt.CompareTo(sqldr.GetDateTime(7));
                        if ((t1 >= 0) && (t2 <= 0))
                        {
                            textBox1.Text = sqldr.GetString(2) + ":" + (String)sqldr["PlanText"] + "\n";
                            switch (sqldr.GetString(2))
                            {
                                case "缓慢":
                                    textBox1.ForeColor = Color.LightGreen;
                                    break;
                                case "一般":
                                    textBox1.ForeColor = Color.YellowGreen;
                                    break;
                                case "重要":
                                    textBox1.ForeColor = Color.ForestGreen;
                                    break;
                                default:
                                    textBox1.ForeColor = Color.White;
                                    break;
                            }
                        }
                    }
                }
                sqlcon.Close();
                sqldr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            switch (Tmonth)
            {
                case 1:
                case 2:
                case 3:
                    table.BackgroundImage = Image.FromFile(Application.StartupPath + "\\chun.jpg");
                    break;
                case 4:
                case 5:
                case 6:
                    table.BackgroundImage = Image.FromFile(Application.StartupPath + "\\xia.jpg");
                    break;
                case 7:
                case 8:
                case 9:
                    table.BackgroundImage = Image.FromFile(Application.StartupPath + "\\qiu.jpg");
                    break;
                default:
                    table.BackgroundImage = Image.FromFile(Application.StartupPath + "\\dong.jpg");
                    break;
            }

            for (weekday = 0; weekday < 7; weekday++)
            {

                Label labelzzx = new Label();
                labelzzx.BackColor = Color.Transparent;
                labelzzx.Text = weekStr[weekday];
                labelzzx.Width = (int)width;
                labelzzx.Height = (int)height;
                labelzzx.Font = new Font("宋体", 20, FontStyle.Bold);
                labelzzx.ForeColor = Color.Orange;
                labelzzx.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(labelzzx, weekday, 0);
            }

            DateTime a = DateTime.Parse(dt.ToString("yyyy-MM-01"));
            for (i = 0, k = OneInWeek; (i < OneInWeek) || (k < 0); i++, k--)
            {
                a = DateTime.Parse(a.ToShortDateString()).AddDays(-1);
                string lunar = GetChineseDateTime(a);

                n = table.RowCount - 6;
                Label labelzzx = new Label();
                labelzzx.BackColor = Color.Transparent;
                labelzzx.Width = (int)width;
                labelzzx.Height = (int)height;
                labelzzx.Text = (PDays + i - OneInWeek + 1).ToString() + "\n" + lunar;
                labelzzx.ForeColor = Color.Gray;
                labelzzx.Font = new Font("黑体", 18, FontStyle.Bold);
                labelzzx.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(labelzzx, i, n);

            }
            DateTime b = DateTime.Parse(dt.ToString("yyyy-MM-01")).AddDays(-1);
            for (i = 1, weekday = OneInWeek, n = table.RowCount - 6; i <= Days; n++)
            {
                for (; i <= Days; weekday++, i++)
                {
                    if (weekday > 6) { break; }

                    b = DateTime.Parse(b.ToShortDateString()).AddDays(1);
                    string lunar = GetChineseDateTime(b);

                    Label labelzzx = new Label();
                    labelzzx.BackColor = Color.Transparent;
                    labelzzx.Width = (int)width;
                    labelzzx.Height = (int)height;
                    if (weekday == 6 || weekday == 0)
                    { labelzzx.ForeColor = Color.Red; }
                    else { labelzzx.ForeColor = Color.Black; }
                    labelzzx.Text = i.ToString() + "\n" + lunar;
                    labelzzx.Font = new Font("黑体", 18, FontStyle.Bold);
                    
                    if (dt == b) { labelzzx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }

                    foreach (DateTime time in list)
                    { if (b == time) { labelzzx.ForeColor = Color.Purple; } }

                    labelzzx.TextAlign = ContentAlignment.MiddleCenter;
                    table.Controls.Add(labelzzx, weekday, n);
                }
                weekday = 0;
            }
            DateTime c = DateTime.Parse(dt.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1);
            int LastInWeek = dw(c.DayOfWeek);//下个月第一天星期    
            for (i = 1, weekday = LastInWeek + 1, n--; n < 7; i++, weekday++)
            {
                if (weekday > 6) { n++; weekday = 0; }
                if (n > 6) { break; }
                
                c = DateTime.Parse(c.ToShortDateString()).AddDays(1);
                string lunar = GetChineseDateTime(c);
                Label labelzzx = new Label();
                labelzzx.BackColor = Color.Transparent;
                labelzzx.Width = (int)width;
                labelzzx.Height = (int)height;
                labelzzx.Text = i.ToString() + "\n" + lunar;
                labelzzx.ForeColor = Color.Gray;
                labelzzx.Font = new Font("黑体", 18, FontStyle.Bold);
                labelzzx.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(labelzzx, weekday, n);
            }
        }
        private int dw(DayOfWeek dw)
        {
            int result = -1;
            switch (dw)
            {
                case DayOfWeek.Monday:
                    result = 1;
                    break;
                case DayOfWeek.Tuesday:
                    result = 2;
                    break;
                case DayOfWeek.Wednesday:
                    result = 3;
                    break;
                case DayOfWeek.Thursday:
                    result = 4;
                    break;
                case DayOfWeek.Friday:
                    result = 5;
                    break;
                case DayOfWeek.Saturday:
                    result = 6;
                    break;
                case DayOfWeek.Sunday:
                    result = 0;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }
        
        //C# 获取农历日期

        ///<summary>
        /// 实例化一个 ChineseLunisolarCalendar
        ///</summary>
        private static ChineseLunisolarCalendar ChineseCalendar = new ChineseLunisolarCalendar();
        
        ///<summary>
        /// 十天干
        ///</summary>
        private static string[] tg = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };

        ///<summary>
        /// 十二地支
        ///</summary>
        private static string[] dz = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };

        ///<summary>
        /// 十二生肖
        ///</summary>
        private static string[] sx = { "鼠", "牛", "虎", "免", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };

        ///<summary>
        /// 返回农历天干地支年
        ///</summary>
        ///<param name="year">农历年</param>
        ///<return s></return s>
        public static string GetLunisolarYear(int year)
        {
            if (year > 3)
            {
                int tgIndex = (year - 4) % 10;
                int dzIndex = (year - 4) % 12;

                return string.Concat(tg[tgIndex], dz[dzIndex], "[", sx[dzIndex], "]");
            }

            throw new ArgumentOutOfRangeException("无效的年份!");
        }
        ///<summary>
        /// 农历月
        ///</summary>

        ///<return s></return s>
        private static string[] months = { "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "腊" };

        ///<summary>
        /// 农历日
        ///</summary>
        private static string[] days1 = { "初", "十", "廿", "三" };
        ///<summary>
        /// 农历日
        ///</summary>
        private static string[] days = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };

        ///<summary>
        /// 返回农历月
        ///</summary>
        ///<param name="month">月份</param>
        ///<return s></return s>
        public static string GetLunisolarMonth(int month)
        {
            if (month < 13 && month > 0)
            {
                return months[month - 1];
            }

            throw new ArgumentOutOfRangeException("无效的月份!");
        }
        ///<summary>
        /// 返回农历日
        ///</summary>
        ///<param name="day">天</param>
        ///<return s></return s>
        public static string GetLunisolarDay(int day)
        {
            if (day > 0 && day < 32)
            {
                if (day != 20 && day != 30)
                {
                    return string.Concat(days1[(day - 1) / 10], days[(day - 1) % 10]);
                }
                else
                {
                    return string.Concat(days[(day - 1) / 10], days1[1]);
                }
            }

            throw new ArgumentOutOfRangeException("无效的日!");
        }

        ///<summary>
        /// 根据公历获取农历日期
        ///</summary>
        ///<param name="datetime">公历日期</param>
        ///<return s></return s>
        public static string GetChineseDateTime(DateTime datetime)
        {
            int year = ChineseCalendar.GetYear(datetime);
            int month = ChineseCalendar.GetMonth(datetime);
            int day = ChineseCalendar.GetDayOfMonth(datetime);
            //获取闰月， 0 则表示没有闰月
            int leapMonth = ChineseCalendar.GetLeapMonth(year);

            bool isleap = false;

            if (leapMonth > 0)
            {
                if (leapMonth == month)
                {
                    //闰月
                    isleap = true;
                    month--;
                }
                else if (month > leapMonth)
                {
                    month--;
                }
            }
            //return string.Concat(GetLunisolarYear(year), "年", isleap ? "闰" : string.Empty, GetLunisolarMonth(month), "月", GetLunisolarDay(day));
            if (day == 1) { return string.Concat(isleap ? "闰" : string.Empty, GetLunisolarMonth(month), "月"); }
            else { return string.Concat(isleap ? "闰" : string.Empty, GetLunisolarDay(day)); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = DateTime.Parse(dt.ToShortDateString()).AddMonths(-1);
            table.Controls.Clear();
            table.Refresh();
            tablePrint();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = dateTimePicker1.Value;
            table.Controls.Clear();
            table.Refresh();
            tablePrint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = DateTime.Parse(dt.ToShortDateString()).AddMonths(1);
            table.Controls.Clear();
            table.Refresh();
            tablePrint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            table.Controls.Clear();
            table.Refresh();
            tablePrint();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}