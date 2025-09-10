using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser {
    internal class WordManipulator {
        public static string ReverseWords(string input) {
            string word = "";
            List<string> words = new List<string>();

            for(int i = 0; i < input.Length; i++) { // use length instead of count
                
                if(char.IsWhiteSpace(input[i])) {  //change char.IsLetter
                    word = word + input[i];
                }
                else { 
                    if(word.Length > 0)
                    {
                    words.Add(word);
                    word = "";
                }    
            }
            }
            if (word.Length>0) // checks if the last word exist 
            {
                words.Add(word);
            }
            List<string> reverseWordOrder = new List<string>();

            for(int i = words.Count(); i > 0; i--) {
                if(!string.IsNullOrWhiteSpace(words[i-1])) 
                {
                    reverseWordOrder.Add(words[i-1]);
                }
            }

            string Results = "";

            for(int i = 0; i < reverseWordOrder.Count; i++) 
            {
                Results = Results + reverseWordOrder[i] + " ";
            }
            if (Results.Length > 0) //Trims Substrings
            {
            Results = Results.Substring(0, Results.Length - 1);
            }
            return Results;
        }
    }
}
