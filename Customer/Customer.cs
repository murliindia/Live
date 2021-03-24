using System;
using EmailNameSpace;
using CustomerNameSpace;
namespace CustomerNameSpace
{
    public class Customer
    {
        public bool SaveRecord(Email obj)
        {
         bool result=   obj.SendMail();

            // EF Code for save the record

            return result;

        }

        public string GenerateNumber(int Divisor, int Postition)
        {
            string Data = string.Empty;

            Calculation _Calculation = new Calculation();
            Data = _Calculation.Getadata(Divisor, Postition);
            return Data;

        }

    }
}
