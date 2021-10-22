using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakerySize = int.Parse(Console.ReadLine());
            string[,] bakery = new string[bakerySize, bakerySize];
            int sellerRow = -1;
            int sellerCol = -1;
            int firstPillarRow = -1;
            int firstPillarCol = -1;
            int secondPillarRow = -1;
            int secondPillarCol = -1;
            bool isFirstPillarSet = false;
            bool isOutOfBakery = false;
            int money = 0;

            for (int r = 0; r < bakerySize; r++)
            {
                string bakeryInfo = Console.ReadLine();

                for (int c = 0; c < bakerySize; c++)
                {
                    bakery[r, c] = bakeryInfo[c].ToString();

                    if (bakery[r, c] == "S")
                    {
                        sellerRow = r;
                        sellerCol = c;
                    }
                    else if (bakery[r, c] == "O")
                    {
                        if (isFirstPillarSet == false)
                        {
                            firstPillarRow = r;
                            firstPillarCol = c;
                            isFirstPillarSet = true;
                        }
                        else
                        {
                            secondPillarRow = r;
                            secondPillarCol = c;
                        }
                    }
                }
            }

            while (money < 50)
            {
                string command = Console.ReadLine();
                bakery[sellerRow, sellerCol] = "-";

                switch (command)
                {
                    case "up":
                        sellerRow--;
                        break;
                    case "down":
                        sellerRow++;
                        break;
                    case "right":
                        sellerCol++;
                        break;
                    case "left":
                        sellerCol--;
                        break;
                }

                if (sellerRow >= 0 && sellerRow < bakerySize && sellerCol >= 0 && sellerCol < bakerySize)
                {
                    if (bakery[sellerRow, sellerCol] == "-")
                    {
                        bakery[sellerRow, sellerCol] = "S";
                    }
                    else if (bakery[sellerRow, sellerCol] == "O")
                    {
                        if (sellerRow == firstPillarRow && sellerCol == firstPillarCol)
                        {
                            bakery[sellerRow, sellerCol] = "-";
                            sellerRow = secondPillarRow;
                            sellerCol = secondPillarCol;
                            bakery[sellerRow, sellerCol] = "S";
                        }
                        else
                        {
                            bakery[sellerRow, sellerCol] = "-";
                            sellerRow = firstPillarRow;
                            sellerCol = firstPillarCol;
                            bakery[sellerRow, sellerCol] = "S";
                        }
                    }
                    else
                    {
                        int currentMoney = int.Parse(bakery[sellerRow, sellerCol]);
                        money += currentMoney;
                        bakery[sellerRow, sellerCol] = "S";
                    }
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    isOutOfBakery = true;
                    break;
                }
            }

            if (isOutOfBakery == false)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

            for (int r = 0; r < bakerySize; r++)
            {
                for (int c = 0; c < bakerySize; c++)
                {
                    Console.Write(bakery[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
