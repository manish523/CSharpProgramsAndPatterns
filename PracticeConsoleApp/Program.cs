using PracticeConsoleApp;
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

//int res= RomanToInteger.RomanToInt("MCMXCIV");
//Console.WriteLine(res);

string[] strs = { "flower", "flow", "flight" };
string longestCommonStr = LongestCommonPrefix.Find(strs);
Console.WriteLine(longestCommonStr);
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

//Factorial objFact= new Factorial();
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