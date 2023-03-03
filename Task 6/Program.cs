// Написать программу вычисления функции Аккермана
int GetNumber(string message)
{
   Console.WriteLine(message);
   int number = int.Parse(Console.ReadLine()?? "");
   return number;
}
int AckermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
  
    if ((m > 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

Console.WriteLine($"m = {m}, n = {n} -> " + AckermanFunction(m, n));
