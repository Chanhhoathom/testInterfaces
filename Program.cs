using System;

namespace testInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Magazine myMag = new Magazine();
            string magContents = $" My Title is: { myMag.GetTitle()}  my Publisher is: {myMag.GetPublisher()}  and I have this many pages: { myMag.NumberOfPages() }";
            Console.WriteLine(magContents);
            Console.WriteLine("press any key to exit ");
            Console.ReadKey();
          
        }
    }
}
