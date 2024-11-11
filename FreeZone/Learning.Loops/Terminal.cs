namespace Learning.Loops
{
    /*
        Aşağıdaki sınıfta temel döngü kullanımlarına ait bazı örnekler yer almaktadır.
     */
    public static class Terminal
    {
        static readonly string[] books = {
            "Dune", "Neuromancer", "Snow Crash", "Hyperion", "The Left Hand of Darkness",
            "Foundation", "Brave New World", "The Stars My Destination", "The Dispossessed",
            "Fahrenheit 451", "1984", "Ubik", "Do Androids Dream of Electric Sheep?", "Solaris",
            "The Man in the High Castle", "A Canticle for Leibowitz", "The Forever War",
            "The Moon is a Harsh Mistress", "Rendezvous with Rama", "Ringworld", "I, Robot",
            "The Demolished Man", "The Martian Chronicles", "Childhood's End",
            "The Time Machine", "The War of the Worlds", "The Lathe of Heaven",
            "Altered Carbon", "Stranger in a Strange Land", "The Day of the Triffids",
            "The Three-Body Problem", "The Windup Girl", "Blindsight", "Ancillary Justice",
            "The Expanse: Leviathan Wakes", "The Handmaid's Tale", "The Diamond Age",
            "The City and the Stars", "The Sirens of Titan", "A Fire Upon the Deep",
            "The Inverted World", "Old Man's War", "The Road", "The Book of the New Sun",
            "Perdido Street Station", "The Drowned Cities", "The Iron Dream",
            "The Player of Games", "The Culture: Consider Phlebas", "Accelerando",
            "The Hunger Games", "The Dark Forest", "A Scanner Darkly"
        };

        // Foreach döngüsü örneği
        public static void ForeachLoopExample()
        {
            Console.WriteLine("Foreach Loop Example:");
            int i = 1;
            foreach (var book in books)
            {
                Console.WriteLine($"{i}, {book}");
                i++;
            }
            Console.WriteLine();
        }

        // For döngüsü örneği
        public static void ForLoopExample()
        {
            Console.WriteLine("For Loop Example:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}, {books[i]}");
            }
            Console.WriteLine();
        }

        // While döngüsü örneği
        public static void WhileLoopExample()
        {
            Console.WriteLine("While Loop Example:");
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine($"{i + 1}, {books[i]}");
                i++;
            }
            Console.WriteLine();
        }

        // Do-While döngüsü örneği
        public static void DoWhileLoopExample()
        {
            Console.WriteLine("Do-While Loop Example:");
            int i = 0;
            do
            {
                Console.WriteLine($"{i + 1}, {books[i]}");
                i++;
            } while (i < books.Length);
            Console.WriteLine();
        }

        public static List<string> GetBooksStartingWith(char letter)
        {
            List<string> result = [];
            int i = 0;
            bool found = false;
            do
            {
                if (books[i].StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(books[i]);
                    found = true;
                }
                i++;
            } while (i < books.Length);

            if (!found)
            {
                Console.WriteLine($"No books found starting with '{letter}'");
            }
            return result;
        }

        // Kitap içinde belli bir kelime geçenleri döndüren metot
        public static List<string> GetBooksContainingWord(string word)
        {
            List<string> result = [];
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Contains(word))
                {
                    result.Add(books[i]);
                }
            }
            return result;
        }

        // Belli sayıda kelimeden fazlasına sahip olan kitapları bulan metot
        public static List<string> GetBooksWithWordCountGreaterThan(int wordCount)
        {
            List<string> result = [];
            foreach (var book in books)
            {
                if (book.Split(' ').Length > wordCount)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public static void PrintBooks(List<string> books)
        {
            Console.WriteLine();
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
