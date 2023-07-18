namespace Assignment_Logic_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 4 digit number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int zero_count = 0, odd_count = 0, even_count = 0;
            for (int i = 0; i < 4; i++)
            {
                int d = num % 10;
                num = num / 10;
                if (d==0) zero_count++;
                else if (d % 2 == 0) even_count++;
                else odd_count++;
            }
            Console.WriteLine($"For the enterend number {num}, count of zeroes = {zero_count}, " +
                $"count of even digits = {even_count} and count of odd digits = {odd_count}");


            /*//int num = Convert.ToInt32(Console.ReadLine());
          string num = Console.ReadLine();
          int zero_count = 0, odd_count = 0, even_count = 0;
          for(int i=0;i<num.Length;i++)
          {
              if (num[i] == '0') zero_count++;
              else if (Convert.ToInt32(num[i]) % 2 == 0) even_count++;
              else odd_count++;
          }*/
        }
    }
}