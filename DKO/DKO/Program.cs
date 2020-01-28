using System;
using System.Collections.Generic;
using System.Linq;

namespace DKO
{
    class DedskiKytOstrova
    {
        static void Main(string[] args)
        {

            int bungee = 0;
            int wall = 0;
            int bounciCastle = 0;
            int sphere = 0;
            double theLounge = 0.0; // zanimalnq
            double incomFromTheLounge = 0.0;

            int bcTicketsFrom2Lv = 0;
            int bcTicketsFrom3Lv = 0;
            int wTicketsFrom2Lv = 0;
            int wTicketsFrom3Lv = 0;

            int price = 0;
            double totalIncomFromTheDay = 0.0;

            int totalTicketsFrom2Lv = 0;
            int totalTicketsFrom3Lv = 0;
            double moneyToRemove = 0.0;

            var input = Console.ReadLine()
                .Split(" ")
                .ToList();

            string equipment = string.Empty;

            while (equipment != "end")
            {
                if (input.Count() == 1)
                {
                    equipment = input[0];
                }
                else
                {
                    equipment = input[1].ToLower();
                }

                switch (equipment)
                {
                    case "b":
                        bungee += int.Parse(input[0]);
                        totalTicketsFrom3Lv++;
                        break;
                    case "w":
                        wall += int.Parse(input[0]);

                        price = int.Parse(input[2]);

                        if (price == 2)
                        {
                            wTicketsFrom2Lv += int.Parse(input[0]);
                        }
                        else
                        {
                            wTicketsFrom3Lv += int.Parse(input[0]);
                        }
                        break;
                    case "s":
                        sphere += int.Parse(input[0]);
                        break;
                    case "bc":
                        bounciCastle += int.Parse(input[0]);

                        price = int.Parse(input[2]);

                        if (price == 2)
                        {
                            bcTicketsFrom2Lv += int.Parse(input[0]);
                        }
                        else
                        {
                            bcTicketsFrom3Lv += int.Parse(input[0]);
                        }
                        break;
                    case "t":
                        incomFromTheLounge += double.Parse(input[0]);
                        break;
                    default:
                        break;
                }


                if (equipment == "str")
                {
                    double priceToRemove = double.Parse(input[0]);

                    moneyToRemove += priceToRemove;
                }

                input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
            }

            Console.WriteLine($"Tickets sells for Bungee = {bungee} \nTotal income = {bungee * 3}lv.");
            Console.WriteLine($"Tickets sells for Wall = {wall} \n   tickets from 2 Leva = {wTicketsFrom2Lv} \n   tickets from 3 Leva = {wTicketsFrom3Lv} \nTotal income = {((wTicketsFrom2Lv * 2) + (wTicketsFrom3Lv * 3))}lv.");
            Console.WriteLine($"Tickets sells for Bounci Castle = {bounciCastle} \n   tickets from 2 Leva = {bcTicketsFrom2Lv} \n   tickets from 3 Leva = {bcTicketsFrom3Lv} \nTotal income = {((bcTicketsFrom2Lv * 2) + (bcTicketsFrom3Lv * 3))}lv.");
            Console.WriteLine($"Tickets sells for Sphere = {sphere} \nTotal income = {sphere * 5}lv.");

            totalTicketsFrom2Lv = wTicketsFrom2Lv + bcTicketsFrom2Lv;
            totalTicketsFrom3Lv += wTicketsFrom3Lv + bcTicketsFrom3Lv;

            Console.WriteLine($"Total Tickers from 2 Leva {totalTicketsFrom2Lv}");
            Console.WriteLine($"Total Tickets from 3 Leva {totalTicketsFrom3Lv}");
            Console.WriteLine($"Total Tickets from 5 Leva {sphere}");
            Console.WriteLine($"Total incom from the Loungh = {incomFromTheLounge.ToString("0.00")}lv.");

            totalIncomFromTheDay = bungee * 3 + sphere * 5 + totalTicketsFrom2Lv * 2 + totalTicketsFrom3Lv * 3 + incomFromTheLounge - moneyToRemove;

            Console.WriteLine($"Total incom for the day {totalIncomFromTheDay.ToString("0.00")}lv.");
        }
    }
}
