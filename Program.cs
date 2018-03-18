using System;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var myBirthday = new DateTime(1982, 10, 23); //create instance and pass parameters, use new
            //Console.WriteLine(myBirthday.ToString("dd MMMM yyyy"));

            var currentDate = DateTime.Now;//static property
            //Console.WriteLine(currentDate.ToString("dd MMMM yyyy"));

            //Console.WriteLine(myBirthday.DayOfYear);
            //Console.WriteLine(currentDate.DayOfYear);

            if (myBirthday.DayOfYear < currentDate.DayOfYear){
                Console.WriteLine("My birthday has already been this year");

            }
            else{
                Console.WriteLine("woohoo the best day of the year is still to come...");
            }
            //Console.WriteLine(currentDate.Year - myBirthday.Year);

       /* } var age = currentDate.Year - myBirthday.Year;

        if (myBirthday.DayOfYear > currentDate.DayOfYear){
            age -=1;
        
    } Console.WriteLine($"My age is {age}");
}*/
