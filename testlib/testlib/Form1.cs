using datelib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testlib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            TimeSpan difference = dateclass.CalculateDateDifference(date1, date2);

            MessageBox.Show($"Разница во времени: {difference.Days} дней, {difference.Hours} часов, {difference.Minutes} минут");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);

            bool isLeapYear = datelib.dateclass.IsLeapYear(year);

            MessageBox.Show($"Год {year} является високосным: {isLeapYear}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker3.Value;

            string timeOfDay = datelib.dateclass.GetTimeOfDay(time);

            MessageBox.Show($"Время суток: {timeOfDay}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker4.Value;

            string formattedDateTime = datelib.dateclass.FormatDateTime(dateTime);

            MessageBox.Show($"Отформатированная дата и время: {formattedDateTime}");
        }
    }
}
