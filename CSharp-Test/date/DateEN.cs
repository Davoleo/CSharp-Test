using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.date
{
    //Date in formato anglosassone
    class DateEN : Date
    {
        public DateEN() : base() {}

        public DateEN(int aaaa, int mm, int gg) : base(gg, mm, aaaa)
        {}

        //Probably broken
        public new string GetMonthName()
        {
            string month = "";

            switch (MM)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                default:
                    month = "December";
                    break;
            }
            return month;
        }

    }
}
