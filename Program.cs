namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int num3 = 8;                      
            int minInt = Math.Min(Math.Min(num1, num2), num3);
            Console.WriteLine("Minimum Integer: " + minInt);

            float num4 = 10.5f;
            float num5 = 5.2f;
            float num6 = 8.7f;
            float minFloat = Math.Min(Math.Min(num4, num5), num6);
            Console.WriteLine("Minimum Float: " + minFloat);


            string str1 = "apple";
            string str2 = "banana";
            string str3 = "cherry";
            string minString = str1;

            if (string.Compare(str2, minString) < 0)
                minString = str2;

            if (string.Compare(str3, minString) < 0)
                minString = str3;

            Console.WriteLine("Minimum String: " + minString);


            
            Minimum min = new Minimum();
            Console.WriteLine(min.FindMinimum<int>(4,3,2));
            Console.WriteLine(min.FindMinimum<float>(2.1f,3.2f,4.5f));
            Console.WriteLine(min.FindMinimum<string>("apple","banana","cherry"));
            
            
            MinimumFinder<int> intFinder = new MinimumFinder<int>(10, 5, 8);
            int minInt1 = intFinder.FindMinimum();
            Console.WriteLine("Minimum Integer: " + minInt1);

            MinimumFinder<float> floatFinder = new MinimumFinder<float>(10.5f, 5.2f, 8.7f);
            float minFloat1 = floatFinder.FindMinimum();
            Console.WriteLine("Minimum Float: " + minFloat1);

            MinimumFinder<string> stringFinder = new MinimumFinder<string>("apple", "banana", "cherry");
            string minString1 = stringFinder.FindMinimum();
            Console.WriteLine("Minimum String: " + minString1);
        }
    }
}