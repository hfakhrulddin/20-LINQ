using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>
                                                {
                                                "apple",
                                                "passionfruit",
                                                "banana",
                                                "mango",
                                                "orange",
                                                "blueberry",
                                                "grape",
                                                "strawberry"
                                                 };
            int[] numbers = { 3, 4, 5, 6, 7, 8 };

            LinqQuery(fruits);
            LinqSelection(fruits);
            LinqPartialSelection(fruits);
            LinqAggregation(numbers);
            Console.Read();
        }

        public static void LinqQuery(List<string> fruits)
        {
            // find all fruits that have names of length 5 or less
            IEnumerable<string> query1 = fruits.Where(fruit => fruit.Length < 6);

            foreach (string fruit in query1)
                Console.WriteLine(fruit);
        }

        public static void LinqSelection(List<string> fruits)
        {

            // convert the names of all the fruits to uppercase
            IEnumerable<string> query2 = fruits.Select(fruit => fruit.ToUpper());

            foreach (string fruit in query2)
                Console.WriteLine(fruit);

        }


        public static void LinqPartialSelection(List<string> fruits)
        {
            // find first 3 fruits
            IEnumerable<string> query1 = fruits.Take(3);


            foreach (string fruit in query1)
                Console.WriteLine(fruit);

            // skip the first 3 fruits
            IEnumerable<string> query2 = fruits.Skip(3);

            foreach (string fruit in query2)
                Console.WriteLine(fruit);

            // single element operations
            string firstFruit = fruits.First(); // apple
            Console.WriteLine(firstFruit);
            string lastFruit = fruits.Last(); //  strawberry
            Console.WriteLine(lastFruit);
            string thirdFruit = fruits.ElementAt(2); // banana
            Console.WriteLine(thirdFruit);
            string fruitStratingWithM = fruits.First(fruit => fruit.StartsWith("m")); // mango
            Console.WriteLine(fruitStratingWithM);
        }

        public static void LinqAggregation(int[] numbers)
        {

            // aggregation operations
            int count = numbers.Count(); // 6
            Console.WriteLine(count);
            int min = numbers.Min(); // 3
            Console.WriteLine(min);
            int max = numbers.Max(); // 8
            Console.WriteLine(max);
            double average = numbers.Average(); // 5.5
            Console.WriteLine(average);

            // the operators above also take an optional predicate
            int countEvensOnly = numbers.Count(number => number % 2 == 0);
            Console.WriteLine(countEvensOnly);

            // assume that values decay over period
            // MAX and MIN functions allow the numbers to be transformed
            // before the operation
            int maxAfterMultiplicationByTwo = numbers.Max(number => number * 2); // 16
            Console.WriteLine(maxAfterMultiplicationByTwo);
        }
    }
}
