using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverser {
    internal class WordManipulator {
        public static string ReverseWords(string input) {
            string word = "";
            List<string> ReverseOrder = [];
            List<string> words = [];

            for(int i = 0; i < input.Count(); i++) {
                
                if(char.IsLetter(input[i])) { 
                    word = word + input[i];
                }
                else { 
                    words.Add(word);
                    word = "";
                }    
            }


            List<string> reverseWordOrder = [];

            for(int i = words.Count(); i > 0; i--) {
                if(!string.IsNullOrWhiteSpace(words[i-1])) {
                    reverseWordOrder.Add(words[i-1]);
                }
            }

            string Results = "";

            for(int i = 0; i < reverseWordOrder.Count(); i++) {
                Results = Results + reverseWordOrder[i] + " ";
            }

            Results = Results.Substring(0, Results.Length - 1);

            return Results;
        }
    }
}
