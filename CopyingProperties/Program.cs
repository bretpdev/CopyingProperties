using static System.Console;

namespace CopyingProperties
{
    public class Program
    {
        public enum Sex
        {
            M,
            F,
            O
        }

        public enum JobType
        {
            Software,
            Groceries
        }

        public static void Main(string[] args)
        {
            new SameName.ProcessSameName().Start();
            WriteLine("");
            WriteLine("");
            new Attributes.ProcessAttributes().Start();

            ReadKey();
        }
    }
}