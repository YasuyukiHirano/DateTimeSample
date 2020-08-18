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
        private DateTime _now;

        public Form1()
        {
            InitializeComponent();
        }

        //現在日時ボタン
        private void btNow_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now; //現在時刻取得
            tbNowDisp.Text = _now.ToShortDateString();  //日付だけ表示
        }
        //〇ヵ月〇日前ボタン
        private void btBefore_Click(object sender, EventArgs e)
        {
            //メソッドチェーン（メソッドの連結）
            var outputDate = (_now.AddDays(-(double)nudDayBeforeAfter.Value)).AddMonths(-(int)nudMonthBeforeAfter.Value);

            //月を戻して表示
            tbBeforeAfterDisp.Text = outputDate.ToShortDateString();

            //閏年の判定（三項演算子）
            tbLeapYearDisp.Text = DateTime.IsLeapYear(outputDate.Year) ? "閏年です" : "平年です";
        }
        //〇ヵ月〇日後ボタン
        private void btAfter_Click(object sender, EventArgs e)
        {
            var outputDate = (_now.AddDays((double)nudDayBeforeAfter.Value)).AddMonths((int)nudMonthBeforeAfter.Value);

            //月を進めて表示
            tbBeforeAfterDisp.Text = outputDate.ToShortDateString();

            //閏年の判定（三項演算子）
            tbLeapYearDisp.Text = DateTime.IsLeapYear(outputDate.Year) ? "閏年です" : "平年です";
        }

        private void btDayCount_Click(object sender, EventArgs e)
        {
            //誕生日の日付オブジェクト
            DateTime birthDate = new DateTime((int)nudBirthYear.Value, (int)nudBirthMonth.Value, (int)nudBirthDay.Value);
            //今日の日付オブジェクト
            DateTime today = DateTime.Today;
            //差を計算
            TimeSpan dateDiff = today - birthDate;  

            tbDayCountDisp.Text = dateDiff.Days.ToString(); //日数を表示
        }
    }
}
