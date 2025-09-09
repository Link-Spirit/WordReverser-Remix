using System.Diagnostics;
using System.Text;
using static WordReverser.Program;

namespace WordReverser.TestUtility
{
    public static class TestRunner {
        public static void Run(IEnumerable<TestCase> testColletion) {
            foreach(TestCase test in testColletion) {
                Run(test);
            }
        }


        public static void Run(TestCase test) {
            try {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                // code that needs to be tested goes here
                /*****************************************/
                test.Results = WordManipulator.ReverseWords(test.TestingCase);
                /*****************************************/
                stopwatch.Stop();
                test.Runtime = stopwatch.Elapsed;
            }
            catch(Exception ex) {
                test.error = ex;
            }
        }

        public static void Render(IEnumerable<TestCase> testCollection) {
            for(int i = 0; i < testCollection.Count(); i++) {
                Render(testCollection.ElementAt(i), i + 1);
            }
        }


        public static void Render(TestCase test, int itter) {
            StringBuilder sb = new();

            sb.AppendLine($"***** * Test {itter} * *****");
            sb.AppendLine($"Test Case: \"{test.TestingCase}\"");
            sb.AppendLine($"Expected result: \"{test.Expected}\"");
            if(test.error is null) {
                sb.AppendLine($"Test results: \"{test.Results}\"");
            }

            else {
                sb.AppendLine("Error!");
                sb.AppendLine(test.error.Message);
                sb.AppendLine(test.error.StackTrace);
            }

            sb.AppendLine();
            if(test.IsValid()) {
                sb.AppendLine("\tTest passed!");
                sb.AppendLine($"\tRuntime: {test.Runtime.TotalMilliseconds} ms");
            }
            else {
                sb.AppendLine("\tTest failed!");
            }
            sb.AppendLine();
            
            sb.AppendLine("***********************\n");
            Console.WriteLine(sb.ToString());
        }
    }
}
