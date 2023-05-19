class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Input: ");
            int row = int.Parse(Console.ReadLine());
            if (row < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                continue;
            }
            Console.Write("");
            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalculatePascalValue(i, j) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            break;
        }
    }
    static int CalculatePascalValue(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, col - 1) + CalculatePascalValue(row - 1, col);
        }
    }
}