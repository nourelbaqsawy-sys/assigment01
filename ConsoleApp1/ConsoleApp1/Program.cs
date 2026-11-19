namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book FromZeroToOne = new Book();
            FromZeroToOne.Title = "From Zero to One";
            FromZeroToOne.Pages = 200;

            Console.WriteLine($"Title: {FromZeroToOne.Title}, Pages: {FromZeroToOne.Pages}");



            Console.WriteLine(FromZeroToOne.ToString());
            Console.WriteLine(FromZeroToOne.GetHashCode());
            Console.WriteLine(FromZeroToOne.Equals(FromZeroToOne));
            Console.WriteLine(FromZeroToOne.GetType());

            Console.WriteLine("========================================");
            
            int xx = 10;
            int yy = 0;

            try
            {
                int result = xx / yy;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Done");
            }


            Console.WriteLine("========================================");


            int page = 300;
            double ppage = page;
            Console.WriteLine(page);
            Console.WriteLine(ppage);


            Console.WriteLine("========================================");


            double price = 49.99;
            int iprice = (int)price;
            Console.WriteLine(price);
            Console.WriteLine(iprice);

            Console.WriteLine("=============================================");

            string pages = "464";
            Console.WriteLine(Convert.ToUInt32(pages));
            Console.WriteLine("======================================");


            string year = "2023";
            Console.WriteLine(int.Parse(year));
            string badText = "abc";
            bool isparsed = int.TryParse(badText, out int num);
            Console.WriteLine($"Invalid number: {isparsed}, Value: {num}");
            Console.WriteLine("=====================================================");
        
            int number = 464;
            string n = number.ToString();
            Console.WriteLine(n.GetType());
            Console.WriteLine("========================================");

            int copies = 100;
            object obj = copies;
            Console.WriteLine(obj);
            int copeis2 = (int) obj;
            Console.WriteLine(copeis2);

            Console.WriteLine("================================================================");



            int? Year = null;
            Console.WriteLine(Year);

            Year = 2023;

            Console.WriteLine(Year);
            Console.WriteLine("=============================================================");


            string? reviewer = null;
            Console.WriteLine(reviewer);

            Console.WriteLine(reviewer);
            Console.WriteLine("==============================");


            Book? book = new Book();
            Console.WriteLine(book);

            Console.WriteLine("======================================");

            Console.WriteLine(reviewer ?? "Untitled");

            Console.WriteLine("======================================");

            string? name = "ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);


        }
    }
}
