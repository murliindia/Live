using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerNameSpace
{
    public class Calculation
    {
        public string Getadata(int Divisor, int Postition)
        {
            string Data = string.Empty;

            string[] ReturnValue = new string[2];
            List<string> DataList = new List<string>();
            DataList.Add("1");
            DataList.Add("1");
            DataList.Add("1");
            DataList.Add("3");
            DataList.Add("5");
            DataList.Add("9");
            DataList.Add("17");
            DataList.Add("31");
            DataList.Add("57");
            DataList.Add("105");
            DataList.Add("355");
            DataList.Add("653");
            int PostionData = 0;
            foreach (string item in DataList)
            {

                int Cal = Convert.ToInt32(item) / Divisor;
                if (Cal == 0)
                {
                    PostionData = PostionData + 1;

                    if (PostionData == Postition)
                    {
                        Data = item;
                        break;
                    }
                }

            }

            return Data;

        }

    }
}
