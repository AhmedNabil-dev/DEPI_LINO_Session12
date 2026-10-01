using DEPI_C__LINQ_Session12.Class;
using static DEPI_C__LINQ_Session12.Class.ListGenerator;
namespace DEPI_LINO_Session12
{
    class Program
    {
        static void Main()
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock
            // Fluent 
            //var Result1 = ProductsList.Where(p => p.UnitsInStock == 0);
            //var Result1 = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p;



            //foreach(var P in Result1) Console.WriteLine(P);
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit
            // Fluent 
            //var Result2 = ProductsList.Where(
            //p => p.UnitsInStock != 0 && p.UnitPrice > 3
            // );
            //var Result2 = from p in ProductsList
            //              where p.UnitsInStock != 0 && p.UnitPrice > 3
            //              select p;


            //foreach (var P in Result2) Console.WriteLine(P);
            #endregion

            #region  Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result3 = Arr.Where((d, i) => d.Length < i);
            //var Result3 = from d in Arr
            //              where d.Length < Arr.IndexOf(d)
            //              select d;

            //foreach(var d in Result3 ) Console.WriteLine(d);
            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1-Get first Product out of Stock
            //var Result1 = ProductsList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result1);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result2 = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result2 is null ? "Not Found Product" : Result2);
            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result3 = Arr
            //    .Where(x => x > 5)
            //    .Skip(1)
            //    .First();
            //Console.WriteLine(Result3);
            #endregion


            #endregion

            #region LINQ - Aggregate Operators

            #region Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var OddNum = Arr.Where(d => d % 2 != 0)
            //                 .Count();
            //Console.WriteLine(OddNum);

            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var Customer = CustomersList.Select(c =>
            //   new
            //   {
            //       c.CustomerID,
            //       c.CustomerName,
            //       OrdersCount = c.Orders.Count()
            //   });
            //foreach(var c in Customer) Console.WriteLine(c);


            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Categories = ProductsList.GroupBy(p => p.Category)
            //                 .Select(g => new { Category = g.Key , Productnum = g.Count() });

            //  foreach (var c in Categories) Console.WriteLine(c);              
            #endregion

            #region 4. Get the total of the numbers in an array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Sum();
            //Console.WriteLine(total);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var TotalCharacters = Words.Sum(word => word.Length);

            //Console.WriteLine(TotalCharacters);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var ShortestWordLength = Words.Min(word => word.Length);

            //Console.WriteLine(ShortestWordLength);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Words = File.ReadAllLines("dictionary_english.txt");

            //var LongestWordLength = Words.Max(word => word.Length);

            //Console.WriteLine(LongestWordLength);

            #endregion

            #region 8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
             string[] Words = File.ReadAllLines("dictionary_english.txt");

            var AvgWordLength = Words.Average(word => word.Length);

            Console.WriteLine(AvgWordLength);

            #endregion



            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var ProductsByName = ProductsList
            //    .OrderBy(P => P.ProductName);

            //foreach (var Product in ProductsByName)
            //    Console.WriteLine(Product.ProductName);


            #endregion


            #region 2. Case-insensitive sort of the words in an array

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var CaseInsensitiveWords = Arr
            //    .OrderBy(Word => Word, StringComparer.OrdinalIgnoreCase);

            //foreach (var Word in CaseInsensitiveWords)
            //{
            //    Console.WriteLine(Word);
            //}

            #endregion


            #region 3. Sort products by units in stock from highest to lowest

            //var ProductsByStock = ProductsList
            //    .OrderByDescending(P => P.UnitsInStock);

            //foreach (var Product in ProductsByStock)
            //{
            //    Console.WriteLine($"{Product.ProductName} - {Product.UnitsInStock}");
            //}

            #endregion


            #region 4. Sort digits by name length, then alphabetically

            //string[] Arr =
            //{
            //   "zero", "one", "two", "three", "four",
            //   "five", "six", "seven", "eight", "nine"
            // };

            //var SortedDigits = Arr
            //    .OrderBy(Digit => Digit.Length)
            //    .ThenBy(Digit => Digit);

            //foreach (var Digit in SortedDigits)
            //{
            //    Console.WriteLine(Digit);
            //}

            #endregion


            #region 5. Sort by word length, then case-insensitive alphabetically

            //string[] Arr =
            //{
            // "aPPLE",
            // "AbAcUs",
            // "bRaNcH",
            // "BlUeBeRrY",
            // "ClOvEr",
            // "cHeRry"
            //};

            //var SortedWords = Arr
            //    .OrderBy(Word => Word.Length)
            //    .ThenBy(Word => Word, StringComparer.OrdinalIgnoreCase);

            //foreach (var Word in SortedWords)
            //{
            //    Console.WriteLine(Word);
            //}

            #endregion


            #region 6. Sort products by category, then unit price descending

            //var SortedProducts = ProductsList
            //    .OrderBy(P => P.Category)
            //    .ThenByDescending(P => P.UnitPrice);

            //foreach (var Product in SortedProducts)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion


            #region 7. Sort by word length, then case-insensitive descending

            //string[] Arr =
            //{
            //  "aPPLE",
            //  "AbAcUs",
            //  "bRaNcH",
            //  "BlUeBeRrY",
            //  "ClOvEr",
            //  "cHeRry"
            //};

            //var SortedWordsDescending = Arr
            //    .OrderBy(Word => Word.Length)
            //    .ThenByDescending(Word => Word, StringComparer.OrdinalIgnoreCase);

            //foreach (var Word in SortedWordsDescending)
            //{
            //    Console.WriteLine(Word);
            //}

            #endregion


            #region 8. Select digits whose second letter is 'i', reversed

            //string[] Arr =
            //{
            // "zero", "one", "two", "three", "four",
            // "five", "six", "seven", "eight", "nine"
            //};

            //var Digits = Arr
            //    .Where(Digit => Digit.Length > 1 && Digit[1] == 'i')
            //    .Reverse();

            //foreach (var Digit in Digits)
            //{
            //    Console.WriteLine(Digit);
            //}

            #endregion

            #endregion


            #region LINQ - Transformation Operators

            #region 1. Return a sequence of just the names of products

            //var ProductNames = ProductsList
            //    .Select(P => P.ProductName);

            //foreach (var ProductName in ProductNames)
            //{
            //    Console.WriteLine(ProductName);
            //}

            #endregion


            #region 2. Produce uppercase and lowercase versions of each word

            //string[] words =
            //{
            // "aPPLE",
            // "BlUeBeRrY",
            // "cHeRry"
            //};

            //var WordVersions = words
            //    .Select(Word => new
            //    {
            //        UpperCase = Word.ToUpper(),
            //        LowerCase = Word.ToLower()
            //    });

            //foreach (var Word in WordVersions)
            //{
            //    Console.WriteLine($"Upper: {Word.UpperCase}");
            //    Console.WriteLine($"Lower: {Word.LowerCase}");
            //}

            #endregion


            #region 3. Select product properties and rename UnitPrice to Price

            //var ProductInfo = ProductsList
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.Category,
            //        Price = P.UnitPrice
            //    });

            //foreach (var Product in ProductInfo)
            //{
            //    Console.WriteLine(
            //        $"{Product.ProductName} - {Product.Category} - {Product.Price}");
            //}

            #endregion


            #region 4. Determine if array values match their positions

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var MatchingValues = Arr
            //    .Select((Value, Index) => new
            //    {
            //        Value,
            //        Index,
            //        Matches = Value == Index
            //    });

            //foreach (var Item in MatchingValues)
            //{
            //    Console.WriteLine(
            //        $"Value: {Item.Value}, Index: {Item.Index}, Matches: {Item.Matches}");
            //}

            #endregion


            #region 5. Return pairs where numbersA is less than numbersB

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };

            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Pairs =
            //    from A in numbersA
            //    from B in numbersB
            //    where A < B
            //    select new
            //    {
            //        A,
            //        B
            //    };

            //foreach (var Pair in Pairs)
            //{
            //    Console.WriteLine($"{Pair.A} is less than {Pair.B}");
            //}

            #endregion


            #region 6. Select orders where order total is less than 500.00

            //var OrdersLessThan500 = CustomersList
            //      .SelectMany(c => c.Orders)
            //      .Where(o => o.Total < 500);

            //foreach (var Order in OrdersLessThan500)
            //{
            //    Console.WriteLine(Order);
            //}

            #endregion


            #region 7. Select orders where the order was made in 1998 or later

            //var OrdersFrom1998 = CustomersList
            //      .SelectMany(c => c.Orders)
            //      .Where(o => o.OrderDate.Year <= 1998);

            //foreach (var Order in OrdersFrom1998)
            //{
            //    Console.WriteLine(Order);
            //}

            #endregion

            #endregion
        }

    }
}