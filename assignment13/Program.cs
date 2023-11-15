using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
                // Prompt the user to enter a piece of text
                Console.WriteLine("Enter a piece of text:");
                string inputText = Console.ReadLine();

                // Word Count
                int wordCount = CountWords(inputText);
                Console.WriteLine($"Word Count: {wordCount}");

                // Extract Email Addresses
                string[] emailAddresses = ExtractEmailAddresses(inputText);
                Console.WriteLine($"Email Addresses:");
                foreach (var email in emailAddresses)
                {
                    Console.WriteLine(email);
                }

                // Extract Mobile Numbers
                string[] mobileNumbers = ExtractMobileNumbers(inputText);
                Console.WriteLine($"Mobile Numbers:");
                foreach (var mobileNumber in mobileNumbers)
                {
                    Console.WriteLine(mobileNumber);
                }

                // Custom Regex Search
                Console.WriteLine("Enter a custom regular expression:");
                string customRegexPattern = Console.ReadLine();
                string[] customRegexResults = PerformCustomRegexSearch(inputText, customRegexPattern);
                Console.WriteLine($"Custom Regex Search Results:");
                foreach (var result in customRegexResults)
                {
                    Console.WriteLine(result);
                }
            }

            // Method to count words in a given text
            static int CountWords(string text)
            {
                string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                return words.Length;
            }

            // Method to extract email addresses from a given text using regular expression
            static string[] ExtractEmailAddresses(string text)
            {
                string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
                MatchCollection matches = Regex.Matches(text, pattern);

                string[] emailAddresses = new string[matches.Count];
                for (int i = 0; i < matches.Count; i++)
                {
                    emailAddresses[i] = matches[i].Value;
                }

                return emailAddresses;
            }

            // Method to extract mobile numbers from a given text using regular expression
            static string[] ExtractMobileNumbers(string text)
            {
                string pattern = @"\b\d{10}\b";
                MatchCollection matches = Regex.Matches(text, pattern);

                string[] mobileNumbers = new string[matches.Count];
                for (int i = 0; i < matches.Count; i++)
                {
                    mobileNumbers[i] = matches[i].Value;
                }

                return mobileNumbers;
            }

            // Method to perform custom regex search in a given text
            static string[] PerformCustomRegexSearch(string text, string pattern)
            {
                MatchCollection matches = Regex.Matches(text, pattern);

                string[] results = new string[matches.Count];
                for (int i = 0; i < matches.Count; i++)
                {
                    results[i] = matches[i].Value;
                }

                return results;
            }
        

    }
}

