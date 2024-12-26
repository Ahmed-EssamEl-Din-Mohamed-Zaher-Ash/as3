namespace Assignment_02
{
   internal class Program
   {
      static void Main(string[] args)
      {

         //1- الفرق ان اللي بالقيمة بتكون نسخة ومش حتتغير يعني لو عملت كده 

         void printNum(int a)
         {
            a += 10;//مثلا 
            Console.WriteLine(a);
         }
         int x = 5;
         Console.WriteLine(x);   //5 
         printNum(x);  //5 فاهمني يعني مش حتتأثر قيمة الإكس
                       //التانية حيشاور علي الذاكرة فحيتغير طبعا حتختلف في السنتكس للبارامتر الاولي النوع العادي التاني حتكون قبلها ريف

         //3--------------------
         static void SumSub(int x, int y, out int sum, out int sub)
         {
            sum = x + y;
            sub = x - y;
         }
         Console.WriteLine("Enter first number:");
         int num1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter second number:");
         int num2 = int.Parse(Console.ReadLine());
         SumSub(num1, num2, out int sumResult, out int subResult);
         Console.WriteLine($"Sum: {sumResult}");
         Console.WriteLine($"Subtraction: {subResult}");
         //4---لو فهمت صح انه 5 و2 فبيجمعهم 
         static int SumOfDigits(int number)
         {
            string numberStr = number.ToString();
            int sum = 0;
            foreach (char digit in numberStr)
            { sum += int.Parse(digit.ToString()); }
            return sum;
         }
         SumOfDigits(42);
         //5-------------------
         static bool IsPrime(int number)
         { 
            if (number <= 1)
            { return false; }
            for (int i = 2; i <= number; i++)
            { 
               if (number % i == 0 && i != number)
               { return false; }
            }
            return true;
               }
               Console.WriteLine("Enter a number:");
               int  num    = int.Parse(Console.ReadLine());
               bool result = IsPrime(num);
               Console.WriteLine($"Is the number {num} prime? {result}");
      }
   }
}