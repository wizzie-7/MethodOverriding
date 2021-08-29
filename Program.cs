using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            PNB pn = new PNB();
            pn.RoiCal();
            axis a = new axis();
            a.RoiCal();
            Bank bn1 = new PNB();
            bn1.RoiCal();
            Bank bn2 = new axis();
            bn2.RoiCal();
        }
    }
    class Bank
    {
        public virtual void RoiCal()
        {
            Console.WriteLine("This is Main Bank");
            int Roi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Roi);
        }
    }
    //class pnb : bank
    //{
    //    public override void roical()
    //    {
    //        console.writeline("this is pnb bank");
    //        int roi1 = convert.toint32(console.readline());
    //        console.writeline(roi1);
    //    }
    //}
    //class axis : bank
    //{
    //    public override void roical()
    //    {
    //        console.writeline("this is axis bank");
    //        int roi2 = convert.toint32(console.readline());
    //        console.writeline(roi2);
    //    }
    //}
    class PNB : Bank
    {
        public new void RoiCal()
        {
            Console.WriteLine("This is PNB Bank");
            int Roi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Roi1);
        }
    }
    class axis : Bank
    {
        public new void RoiCal()
        {
            Console.WriteLine("This is AXIS Bank");
            int Roi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Roi2);
        }
    }
}
