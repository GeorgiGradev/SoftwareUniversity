using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
