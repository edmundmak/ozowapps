using Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Sorting
{
    public  class GetSorting: IGetSorting
    {

        public string SortedListLettersUsingBuiltIn(string inputText)
        {
            string cleanInput = Regex.Replace(inputText.ToLower(), Constants.RemoveUnwantedCharacters, "");
            string sortedLetters = string.Empty;
            try
            {
                char[] stringtoArray = cleanInput.ToCharArray();
                Array.Sort(stringtoArray);
                sortedLetters = new string(stringtoArray);
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
            }
            return sortedLetters;

        }
        public string sortedListLettersNoBuiltIn(string inputText)
        {
            string sortedLetters = string.Empty;
            try
            {
                string cleanInput = Regex.Replace(inputText.ToLower(), Constants.RemoveUnwantedCharacters, "");
                int[] charCount = new int[Constants.Maximum_Characters];
                for (int i = 0; i < cleanInput.Length; i++)
                {
                    charCount[cleanInput[i] - 'a']++;
                }
                for (int i = 0; i < Constants.Maximum_Characters - 1; i++)
                {
                    for (int j = 0; j < charCount[i]; j++)
                    {
                        sortedLetters += (char)('a' + i);
                    }
                }
            }
            catch(Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
            }
            return sortedLetters;

        }

    }
}
