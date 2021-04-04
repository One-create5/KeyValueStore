using System;

namespace KeyValueStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();

            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            d["Cats"] = 42;
            d["Dogs"] = 17;
        }
    }
}
