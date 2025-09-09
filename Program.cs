using System.Diagnostics.Contracts;
using WordReverser.TestUtility;

namespace WordReverser
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            TestCase[] testCases = {
                new(){TestingCase = "", Expected =  "" },
                new(){TestingCase = "    ", Expected =  ""},
                new(){TestingCase = "a", Expected =  "a"},
                new(){TestingCase = "   hello world   ", Expected =  "world hello" },
                new(){TestingCase = "    Other Test ", Expected =  "Test Other" },
                new(){TestingCase = "    the sky is blue   ", Expected =  "blue is sky the" },
                new(){TestingCase = "$$$ %%%  ***"  , Expected =  "*** %%% $$$"  },
                new(){TestingCase = " Something, other. What Time is it?  "  , Expected =  "it? is Time What other. Something,"  }
            };
            TestRunner.Run(testCases);
            TestRunner.Render(testCases);   
        }
    }
}
