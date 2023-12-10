using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(\+359)( |-)(2)(\2)(\d{3})(\2)(\d{4})\b";
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);

Console.WriteLine(string.Join(", ", matches));