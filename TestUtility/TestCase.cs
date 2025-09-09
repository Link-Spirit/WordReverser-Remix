namespace WordReverser.TestUtility
{
    public class TestCase {
        public required string TestingCase { get; set; }
        public required string Expected { get; set; }
        public string? Results { get; set; } = null;
        public Exception? error { get; set; } = null;
        public TimeSpan Runtime { get; set; }

        public bool IsValid() {
            if(Results is null)
                return false;
            return Results == Expected;
        }
    }
}
