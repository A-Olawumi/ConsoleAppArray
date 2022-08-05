namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] Ulist = { 43, 56, 67, 78, 89, 23, 12, 34, 56, 78, 19, 29, 35, 57, 32};
            Console.WriteLine("The Ulist is []{0}", string.Join(",", Ulist));
            Class1 sortedList = new Class1();
        int[] output = sortedList.SortedArray(Ulist);
        Console.WriteLine(" The sorted list is [{0}]",string.Join(",",output));
        }
    }
}