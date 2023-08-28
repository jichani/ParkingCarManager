using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCarManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteLog("버튼1 클릭");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // 로그 작성 부분 2.
        private void WriteLog(string contents)
        {
            string log = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff")}]";
            log += contents;
            DataManager.printLog(log);
            listBox1.Items.Insert(0, log); // 새로운 내용이 맨 위로 올라온다.
            // listBox1.Items.Add(0, log); // 새로운 내용이 맨 밑으로 간다.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteLog("버튼2 클릭");
        }
    }
    
}
