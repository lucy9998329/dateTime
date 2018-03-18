using System;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBirthday = new DateTime(1982, 10, 23); //create instance just
            Console.WriteLine(myBirthday.ToString("dd MMMM yyyy"));

            var currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dd MMMM yyyy"));
        }
    }
}
