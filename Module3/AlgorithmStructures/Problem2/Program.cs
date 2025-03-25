class Program2 {
    static void CheckGenre(string genre) {
        switch (genre) {
            case "Fiction":
                Console.WriteLine("Category: Fiction.");
                break;
            case "Non-Fiction":
                Console.WriteLine("Category: Non-Fiction.");
                break;
            case "Science Fiction":
                Console.WriteLine("Category: Science Fiction.");
                break;
            default:
                Console.WriteLine("Category: Unknown.");
                break;
        }
    }

    static void Main(string[] args) {
        Console.Write("Enter book genre: ");
        string genre = Console.ReadLine();

        CheckGenre(genre);
    }
}