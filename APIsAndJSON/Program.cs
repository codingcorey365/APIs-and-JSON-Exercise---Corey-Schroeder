namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World");
            
            // 1.
            // Call the General API Call Class and its method
            // This will call the Ron Swanson api once.
            General_API_Call testing = new General_API_Call();
            testing.MethodTest();
            //Console.WriteLine("GENERAL API CLASS");
            Console.WriteLine("---------------------------------");

            // 2.
            // Make a quote generator class for RonVSKanyeAPI

            RonVSKanyeAPI exerciseOne = new RonVSKanyeAPI();
            exerciseOne.RonAndKanyeConversation();
            //Console.WriteLine("RONVSKANYEAPI PERSONAL");
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------

            // Teacher answer below for RonVSKanye

            var client = new HttpClient();
            var quote = new QuoteGeneratorBetterPractice(client);

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine($"Kanye West: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");
                Console.WriteLine("------------------------");
            }
            //Console.WriteLine("TEACHER");
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
            // ---------------------------------------------------------------------------
        }
    }
}
