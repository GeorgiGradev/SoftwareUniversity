using CollectionHierarchy.IO;
using CollectionHierarchy.Core;
using CollectionHierarchy.Core.Contracts;
using CollectionHierarchy.IO.Constracts;

namespace CollectionHierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
