using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(\d)(\d)(\.|-|\/)([A-Z]{1}[a-z]{2})(\3)(\d{4})";
Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups[1]}{match.Groups[2]}, Month: {match.Groups[4]}, Year: {match.Groups[6]}");
}