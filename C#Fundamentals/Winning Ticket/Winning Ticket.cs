using System;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string winningTicketPattern = @"[a-zA-Z]{0,4}([@#$^]{6,10})[a-zA-Z]{0,4}[a-zA-Z]{0,4}\1[a-zA-Z]{0,4}";
            string[] tickets = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i].Trim();

                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Match winningTicket = Regex.Match(currentTicket, winningTicketPattern);

                    if (winningTicket.Success && winningTicket.Groups[0].Value.Length == 20)
                    {
                        if (winningTicket.Groups[1].Value.Length == 10)
                        {
                            string jacpotTicket = winningTicket.Groups[0].Value.ToString(); 
                            Console.WriteLine($"ticket \"{jacpotTicket}\" - 10{jacpotTicket.Substring(0,1)} Jackpot!");
                        }
                        else
                        {
                            string ticket = winningTicket.Groups[0].Value.ToString();
                            string symbol = winningTicket.Groups[1].Value.ToString();
                            Console.WriteLine($"ticket \"{ticket}\" - {winningTicket.Groups[1].Value.Length}{symbol.Substring(0, 1)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
            }
        }
    }
}
