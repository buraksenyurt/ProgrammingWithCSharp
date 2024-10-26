namespace Learning.Loops
{
    internal class Program
    {
        static void Main()
        {
            Terminal.ForLoopExample();
            Terminal.WhileLoopExample();
            Terminal.DoWhileLoopExample();
            Terminal.ForeachLoopExample();
            var booksStartsWithA = Terminal.GetBooksStartingWith('A');
            Terminal.PrintBooks(booksStartsWithA);
            var booksStartsWithX = Terminal.GetBooksStartingWith('X');
            Terminal.PrintBooks(booksStartsWithX);

            var forWords = Terminal.GetBooksContainingWord("for");
            Terminal.PrintBooks(forWords);

            var greaterThan3 = Terminal.GetBooksWithWordCountGreaterThan(3);
            Terminal.PrintBooks(greaterThan3);
        }
    }
}
