using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpAddressParser
{
    class MainClass
    {
        public static List<string> solution = new List<string>();
        public static int numDots = 3;

        public static void Main(string[] args)
        {
            // Variables
            List<string> ipAddress = new List<string>();

            // User Input
            Console.WriteLine("Enter an IP Address with no periods: ");
            String input = Console.ReadLine();
            if(input.Contains(' ')){ // whitespace not accepted
                return;
            }
            if (input.Length < 4 || input.Length > 12) return;

            // Splitting
            split(ipAddress, input, numDots);

            // Output
            if (solution.Count == 0) return;
            Console.Write("[ ");
            string lastItem = solution.Last();
            foreach (String address in solution)
            {
                if(address == lastItem){
                    Console.Write("'" + address + "' ");
                }
                else Console.Write("'"+address+"', ");
            }
            Console.Write("]");
        }

        public static void split(List<String> ipAddressBuilder, string toParse, int dotsLeft)
        {
            // No dots left base case
            if (dotsLeft == 0)
            {
                if (isValidPortion(toParse))
                {
                    ipAddressBuilder.Add(toParse);
                    addIpAddress(ipAddressBuilder, toParse);
                    ipAddressBuilder.RemoveAt(ipAddressBuilder.Count - 1);
                    dotsLeft++;
                    return;
                }
                dotsLeft--;
                return;
            }

            else if (dotsLeft >= 1) // First Three Splits
            {
                for (int i = 1; i < toParse.Length; i++)
                {
                    string firstDigit = toParse.Remove(1); // Three length options
                    string twoDigits = toParse.Substring(0, 2);
                    string threeDigits = "";
                    if (toParse.Length > 2)
                    {
                        threeDigits = toParse.Substring(0, 3);
                    }


                    if (isValidPortion(firstDigit) && dotsLeft > 0)
                    {
                        ipAddressBuilder.Add(firstDigit); // Add One Digit
                        dotsLeft--;
                        split(ipAddressBuilder, toParse.Substring(i), dotsLeft);
                        ipAddressBuilder.RemoveAt(ipAddressBuilder.Count - 1);
                        dotsLeft++;
                    }
                    if (isValidPortion(twoDigits) && dotsLeft > 0)
                    {
                        ipAddressBuilder.Add(twoDigits); // Add Two Digits
                        dotsLeft--;
                        split(ipAddressBuilder, toParse.Substring(i+1), dotsLeft);
                        ipAddressBuilder.RemoveAt(ipAddressBuilder.Count - 1);
                        dotsLeft++;
                    }
                    if (isValidPortion(threeDigits) && dotsLeft > 0 && threeDigits.Length>0)
                    {
                        ipAddressBuilder.Add(threeDigits); // Add Three Digit
                        dotsLeft--;
                        split(ipAddressBuilder, toParse.Substring(i + 2), dotsLeft);
                        ipAddressBuilder.RemoveAt(ipAddressBuilder.Count - 1);
                        dotsLeft++;
                        return;
                    }
                    else return;
                }
            }
            return;
        }


        public static bool isValidPortion(String portion)
        {
            // Check if between 0 - 255
            int x = 0;

            // Check for leading zeros
            if(portion.Length > 1){
                if (portion.ElementAt(0).Equals('0'))
                    return false;
            }
            if (Int32.TryParse(portion, out x))
            {
                if (x > 0 && x <= 255)
                {
                    return true;
                }
                if (x == 0){
                    if (portion.Length == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }return false;
        }


        public static void addIpAddress(List<string> firstHalf, String secondHalf)
        {
            solution.Add(firstHalf[0] + "." + firstHalf[1] + "." + firstHalf[2] + "." + secondHalf);
        }

    }
}
