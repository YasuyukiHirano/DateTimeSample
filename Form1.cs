using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample
{
    public partial class Form1 : Form
    {
        //現在時刻取得
        DateTime _now = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void btNow_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            tbNowDisp.Text = now.ToString();
        }

        //〇日前
        private void btBefore_Click(object sender, EventArgs e)
        {
            var dateBefore = _now.AddDays(-(double)nudDayBeforeAfter.Value);

            tbBeforeAfterDisp.Text = dateBefore.ToShortDateString(); //ToShortDateStringは日付のみを返す(秒を省略)
        }

        //〇日後
        private void btAfter_Click(object sender, EventArgs e)
        {
            var dateAfter = _now.AddDays((double)nudDayBeforeAfter.Value);

            tbBeforeAfterDisp.Text = dateAfter.ToShortDateString(); //ToShortDateStringは日付のみを返す(秒を省略)
        }
    }
}
