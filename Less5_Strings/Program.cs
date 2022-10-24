
using Less5_Strings;

string line = File.ReadAllText("D:\\TMS .Net\\Less5_Strings\\Less5_Strings\\string_file.txt");
Console.WriteLine(line);

actWithStrings actWithStr = new actWithStrings();

Console.WriteLine("Choose the action.");
Console.WriteLine("'j' - Max amount of numbers in word.");
Console.WriteLine("'l' - Longest word.");
Console.WriteLine("'r' - Replace numbers with words.");
Console.WriteLine("'i' - Only interrogative and negative sentences.");
Console.WriteLine("'c' - Sentences without commas.");
Console.WriteLine("'b' - Words with the same letter at the beginning and in the end.");

char act = Convert.ToChar(Console.ReadLine());

switch (act)
{
    case 'j':
        actWithStr.MaxAmountOfNums(line);
        break;

    case 'l':
        actWithStr.LongestWord(line);
        break;

    case 'r':
        actWithStr.ReplaceNumbersWithWords(line);
        break;

    case 'i':
        actWithStr.InterrogativeAndNegativeSentences(line);
        break;

    case 'c':
        actWithStr.SentencesWithoutCommas(line);
        break;

    case 'b':
        actWithStr.TheSameBeginningAndEnd(line);
        break;
}
