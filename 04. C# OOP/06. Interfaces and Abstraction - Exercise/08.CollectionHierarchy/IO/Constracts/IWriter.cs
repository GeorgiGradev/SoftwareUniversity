namespace CollectionHierarchy.IO.Constracts
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine();

        void WriteLine(string text);
    }
}
