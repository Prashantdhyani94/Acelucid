
namespace ValidDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateInput = "3/31/2025";
            Console.WriteLine(IsValidDate(dateInput));
        }
        public static bool IsValidDate(string date)
        {
            if(string.IsNullOrEmpty(date)) return false;
            return DateTime.TryParse(date, out DateTime dateTime);
            
        }
    }


}
