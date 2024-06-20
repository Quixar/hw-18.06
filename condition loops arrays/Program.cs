namespace condition_loops_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string[] romanNumerals = new string[4000];

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            for (int i = 1; i < romanNumerals.Length; i++)
            {
                int thousand = i / 1000;
                int hundred = (i % 1000) / 100;
                int ten = (i % 100) / 10;
                int one = i % 10;

                romanNumerals[i - 1] = thousands[thousand] + hundreds[hundred] + tens[ten] + ones[one];
            }

            for (int i = 0; i < romanNumerals.Length; i++)
            {
                Console.Write(romanNumerals[i] + ", ");
            }

            Console.WriteLine();

            // Task 2
            int[,] ar = new int[5, 6];
            int n = 1;
            for (int y = 0; y < ar.GetLength(0); y++)
            {
                for (int x = 0; x < ar.GetLength(1); x++)
                {
                    ar[y, x] = n++;
                    Console.Write(ar[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
