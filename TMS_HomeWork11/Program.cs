namespace TMS_HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////Pair<int, string> pair = new Pair<int, string>(14, "Alex");
            ////////Console.WriteLine($"Value1 = {pair.FirstValue}");
            ////////Console.WriteLine($"Value2 = {pair.SecondValue}");
            var pair1 = new ComparablePair<int, string>(45, "Alex");
            var pair2 = new ComparablePair<int, string>(45, "Jhon");

            int comparisonResult = pair1.CompareTo(pair2);

            if (comparisonResult < 0)
            {
                Console.WriteLine("pair1 меньше pair2");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("pair1 больше pair2");
            }
            else
            {
                Console.WriteLine("pair1 равен pair2");
            }



        }
    }
}
