using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeOverlapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTimeOverlapping(TimeSpan mainStart, TimeSpan mainEnd)
        {
                TimeSpan secondaryStart = tse_start2.TimeSpan;
                TimeSpan secondaryEnd = tse_end2.TimeSpan;

                DateTime dateMainStart = DateTime.Today.Add(mainStart);
                DateTime dateMainEnd;

                if (mainStart > mainEnd)
                {
                dateMainEnd = DateTime.Today.AddDays(1);
                dateMainEnd = dateMainEnd.Add(mainEnd);
                }
                else
                dateMainEnd = DateTime.Today.Add(mainEnd);

                DateTime dateSecondaryEnd;
                DateTime dateSecondaryStart = DateTime.Today.Add(secondaryStart);

                if (mainStart > mainEnd)
                {
                dateSecondaryEnd = DateTime.Today.AddDays(1);
                dateSecondaryEnd = dateSecondaryEnd.Add(secondaryEnd);
                }
                else
                dateSecondaryEnd = DateTime.Today.Add(secondaryEnd);

                if (mainStart < secondaryEnd)
                {
                    if (secondaryStart > secondaryEnd)
                    {
                    dateSecondaryStart = dateSecondaryStart.AddDays(-1);
                    }

                }

                int count = 0;

                for (var i = dateMainStart; i < dateMainEnd; i = i.AddHours(1))
                {
                    if (i >= dateSecondaryStart && i < dateSecondaryEnd)
                    {
                        count++;
                    }
                }

                int minutesStart = 0;
                int minutesEnd = 0;
                int Minutes = 0;

                if (dateMainStart > dateSecondaryStart && dateMainStart < dateSecondaryEnd)
                {
                minutesStart = 60 - dateMainStart.Minute;
                }
                if (dateMainEnd < dateSecondaryEnd && dateMainEnd > dateSecondaryStart)
                {
                minutesEnd = dateMainEnd.Minute;
                }

            Minutes = minutesStart + minutesEnd;

                if (Minutes > 0)
                {
                    count = count - 1;

                    if (Minutes > 60)
                    {
                    Minutes = Minutes - 60;
                    }
                }

                tse_result.TimeSpan = new TimeSpan(count, Minutes, 0);
            
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            if(tse_start1.TimeSpan == null || tse_end1.TimeSpan == null || tse_start2.TimeSpan == null || tse_end2.TimeSpan == null)
            {
                MessageBox.Show("Please insert all time spans to get correct result.");
                return;
            }

            GetTimeOverlapping(tse_start1.TimeSpan, tse_end1.TimeSpan);
        }
    }
}
