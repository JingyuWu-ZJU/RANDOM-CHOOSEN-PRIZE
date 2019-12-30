using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace 抽奖学程序
{
    public partial class Form1 : Form
    {
        int i;
        private Thread thread1;
        delegate void set_Text(string s); //定义委托

        set_Text Set_Text; //定义委托变更
        int[] prize = { 1, 3, 5, 13, 4, 1, 2, 8, 45 };
        string[] prize_name = { "一等奖", "二等奖", "三等奖", "合唱奖", "独唱奖", "独奏奖", "舞蹈奖", "游戏奖", "纪念奖" };
        int[] count = new int[59];
        string[] name = new string[59];
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void NAME_Click(object sender, EventArgs e)
        {

        }
        private void set_lableText(string s)
        {
            lab_NAME.Text = s;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("name.txt", FileMode.Open);
            StreamReader read = new StreamReader(fs, Encoding.UTF8);
            string strReadline;
            int j = 0;
            
            while ((strReadline = read.ReadLine()) != null)
            {
                name[j] = strReadline;
                j++;
                
            }
            this.lab_NAME.Text = "获奖姓名";
            this.lab_prize.Text = "奖项";
            fs.Close();
            read.Close();
        }

        private void btn_START_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10; //设置timer1的间隔时间    
            timer1.Start(); //启动timer1     
        }

        private void btn_END_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string temp_name;
            int temp_prize;
            temp_name = lab_NAME.Text;
            temp_prize = Convert.ToInt32(lab_number.Text);
            prize[temp_prize] = prize[temp_prize] - 1;
            for (int j = 0; j < 59; j++)
            {
                if (name[j] == temp_name)
                {
                    name[j] = " ";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random s1 = new Random();
            Random s2 = new Random();
            int ss1 = s1.Next(59);
            int ss2 = s2.Next(9);
            while (name[ss1] == " ")
            {
                ss1 = s1.Next(59);
            }
            this.lab_NAME.Text = name[ss1];
            while (prize[ss2] == 0)
            {
                ss2 = s2.Next(9);
            }
            this.lab_number.Text = ss2.ToString();
            this.lab_prize.Text = prize_name[ss2].ToString();
        }
    }
}
