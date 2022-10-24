using System.Text;

namespace Less5_Strings
{
    internal class actWithStrings
    {
        #region max amount
        public void MaxAmountOfNums(string str)
        {
            string[] textsplit = str.Split('\n', ' ', '.');
            int Max = 0;
            int Index = 0;
            for (int slovo = 0; slovo < textsplit.Length; slovo++)
            {
                int currmax = 0;
                for (int simvol = 0; simvol < textsplit[slovo].Length; simvol++)
                {
                    if (char.IsNumber(textsplit[slovo][simvol])) // Где i это слово k смвол 
                    {
                        currmax++;
                    }
                }
                if (currmax > Max)
                {
                    Max = currmax;
                    Index = slovo;
                }
            }
            Console.WriteLine("Наибольше цифр в слове " + textsplit[Index]);
        }
        #endregion

        #region longest word
        public void LongestWord(string str)
        {

            string[] chars = str.Split('\n', ' ', '.', ',');
            string maxLength = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (maxLength.Length < chars[i].Length)
                {
                    maxLength = chars[i];
                }
            }

            int count = 0;
            foreach (string x in chars)
            {
                if (x == maxLength)
                    count++;
            }

            Console.WriteLine("Longest word: " + maxLength);
            Console.WriteLine("Repetition count: " + count);
        }
        #endregion

        #region replace numbers with words
        public void ReplaceNumbersWithWords(string str)
        {
            var text = str;
            var numbers = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
                if (char.IsDigit(text[i]))
                    sb.Append(numbers[text[i] - '0']);
                else
                    sb.Append(text[i]);

            text = sb.ToString();
            Console.WriteLine(text);
        }
        #endregion

        #region interrogative and negative sentences
        public void InterrogativeAndNegativeSentences(string str)
        {

            string text = str;
            string[] textsplit = text.Split('.');
            foreach (string st in textsplit)
            {
                if (st.Contains('?') == true || st.Contains('!') == true)
                {
                    string trimmed = st.Trim();
                    Console.WriteLine(trimmed.Substring(0, trimmed.IndexOf('?') + 1));
                    Console.WriteLine(trimmed.Substring(0, trimmed.IndexOf('!') + 1));
                }
            }
        }
        #endregion   

        #region without commas
        public void SentencesWithoutCommas(string str)
        {
            string text = str;
            string[] sentences = text.Split(new[] { '.', '!', '?' });
            foreach (string st in sentences)
                if (st.Contains(","))
                    continue;
                else Console.WriteLine(st);
        }
        #endregion

        #region the same beginning and end
        public void TheSameBeginningAndEnd(string str)
        {
            Console.WriteLine("Words with the same letter at the beginning and in the end: ");
            var words = str.Split(' ', ',', '!', '?', '.', '-', '\n');
            foreach (var word in words)
            {
                if (word.Length > 1 && word[0] == word[word.Length - 1])
                {
                    Console.WriteLine(word);
                }
            }
        }
        #endregion
    }
}
