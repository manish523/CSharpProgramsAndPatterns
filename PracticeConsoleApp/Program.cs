using PracticeConsoleApp;
using PracticeConsoleApp.Feb25;
using PracticeConsoleApp.Jan25;
using PracticeConsoleApp.LeetCodeQuestions;
//using static PracticeConsoleApp.ProgramCheckSealedMethod;

#region LeetCode Practice
//TwoSum ts = new TwoSum();
//int[] arrRet = ts.TwoSumOfArrays([3, 3], 6);
//Console.WriteLine("[{0}]", string.Join(", ", arrRet));

//IntegerPalindrome integerPalindrome = new IntegerPalindrome();
//bool isPalindrome = integerPalindrome.isPalindrome(10);
//Console.WriteLine(isPalindrome.ToString());

//TwoSumAnyIndex twoSumAnyIndex = new TwoSumAnyIndex();
//int[] arrRet = twoSumAnyIndex.TwoSumOfArrays([3,2,4], 6);
//Console.WriteLine("[{0}]", string.Join(", ", arrRet));

//int res = RomanToInteger.RomanToInt("MCMXCIv");
//Console.WriteLine(res);

//string test = "hello";
//Console.WriteLine(test.Capitalize());

//ArrayManipulations obj = new ArrayManipulations();
//int[] revArr = obj.SortArray([1, 4, 3, 5, 6, 2]);
//Console.WriteLine(string.Join(", ", revArr));

//StringPalindrome obj = new StringPalindrome();
////bool res = obj.CheckPalindrome("geeksskeeg");
//bool resAnother = obj.IsPalindrome("geeksskeeg");

//Console.WriteLine(resAnother ? " palindrome" : "not palindrome");

//int num = ReverseInputNumber.ReverserInputNumber(123);
//Console.WriteLine(num);

//long largeReverse = ReverseInputNumber.ReverserInputNumber(1534236469);
//Console.WriteLine($"Revrse: {largeReverse}");

//string str = LongestPalindromicSubString.Find("cbbd");
//Console.WriteLine(str);

//SearchInsertPosition obj = new SearchInsertPosition();
//int res = obj.SearchInsert([1, 3, 5, 6], 7);
//Console.WriteLine(res);

//Temp temp = new Temp();
//bool res = temp.IsPalindrome("bbb");
//if (res) { }
//temp.CountOccurence("aaaaaaaaaaa");

RemoveDuplicatesFromString obj = new RemoveDuplicatesFromString();
string str = obj.ManualRemoval("aabb");
Console.WriteLine(str);

//obj.ArrayInitializations();




//string[] strs = { "flower", "fow", "flight" };
//string longestCommonStr = LongestCommonPrefix.Find(strs);
//Console.WriteLine(longestCommonStr);

//int[] sum = SumArraySumOfAsdjacents.SumAdjacents([-5, 60, -10, 100], 3);
//Console.WriteLine(string.Join(", \n", sum));

//int maxSumOfAdjacents = HieghestSumOfAdjacentElements.ReturnMaxSumOfAdjacents([-5, 60, -10, 100], 3);
//Console.WriteLine(maxSumOfAdjacents);
#endregion


//PlatinumCustomer cs = new PlatinumCustomer();
//SumOfDigitsInNumber obj = new SumOfDigitsInNumber();


//FactorialRecursion obj = new FactorialRecursion();
//var res = obj.CalculateFactorial(5);
//Console.WriteLine(res);

//AsyncLambda obj = new AsyncLambda();

//String str = "ABC";
//int n = str.Length;
//StringPermutations.Permute(str, 0, n - 1);

//string inputstr = "Geeks";
//// Calling function 
//FindAllSubStrWithoutInBuiltFunction.find_Substring(inputstr, inputstr.Length);

//LongestSubstringWithCount.PrintLongestSubstringWithCount();
//FindLongestSubstring.PrintLongestSubstring("abbcdd");

//AnagramCheck anagramCheck = new AnagramCheck();
//anagramCheck.IsAnagram("aabbccddg", "bbddccaag");
//A a = new A();
//bool res =A.AreEqual<string>("A","A");
//Console.WriteLine(res);

#region SingleTon Design Pattern Demo
//Thread t1 = new Thread(() =>
//{
//    var instance = UploadService.Instance(1);
//});

//Thread t2 = new Thread(() =>
//{
//    var instance = UploadService.Instance(2);
//});

//t1.Start();
//t2.Start();

//t1.Join();
//t2.Join();
#endregion


//PatternOne.ArrowStar(5);

//PatternOne.PrintPatternNumber(5);

//PatternOne.PrintPatternStar(6);

//PalindromeNumberCheck objPalindromeNumberCheck = new PalindromeNumberCheck();
//objPalindromeNumberCheck.CheckPalindrome();

//SumOfNumber objSumNumber = new SumOfNumber();

//SwapNumber objSwapNumber = new SwapNumber();

//Febonacci objFebonacci = new Febonacci();
//objFebonacci.GenerateFibonacciSeries();

//Factorial objFact = new Factorial();
//objFact.GenerateFactorial();

//BubbleSort objBubbleSort = new BubbleSort();
//StringLength objStrLength = new StringLength();

//ReverseNumber objRevNum = new();
//ReverseString objReversStr = new ReverseString();

//StarTriangle objST = new();
//objST.PrintSTar();
//objST.PrintSTar("\n\n  *****************************************  ");

////PrimeNumber objPrime = new(5);
//PrimeNumber.GeneratePrimeNumberSeries();