using System;


namespace BookLibrary
{
    public class BookShelf
    {
        public string name;
        public string genres;
        public string author;
        public string publicationDate;
        static void Main(string[] args)
        {
            Console.WriteLine("Horror Books:\n");
            Console.WriteLine(HorrorBook1.name + " " + HorrorBook1.genres + " " + HorrorBook1.author + " " + HorrorBook1.publicationDate);
            Console.WriteLine(HorrorBook2.name + " " + HorrorBook2.genres + " " + HorrorBook2.author + " " + HorrorBook2.publicationDate);
            Console.WriteLine("\nDetective Books:\n");
            Console.WriteLine(DetectiveBook1.name + " " + DetectiveBook1.genres + " " + DetectiveBook1.author + " " + DetectiveBook1.publicationDate);
            Console.WriteLine(DetectiveBook2.name + " " + DetectiveBook2.genres + " " + DetectiveBook2.author +" " + DetectiveBook1.publicationDate);
            Console.WriteLine("\nComedy Books:\n");
            Console.WriteLine(ComedyBook1.name + " " + ComedyBook1.genres + " " + ComedyBook1.author + " " + ComedyBook1.publicationDate);
            Console.WriteLine(ComedyBook2.name + " " + ComedyBook2.genres + " " + ComedyBook2.author + " " + ComedyBook2.publicationDate);
        }
        public BookShelf(string bookName, string genreName, string authorName, string bookPublicationDate)
        {
            name = bookName;
            genres = genreName;
            author = authorName;
            publicationDate = bookPublicationDate;
        }
        public static BookShelf HorrorBook1 = new BookShelf("Призраки рядом с тобой", "Елена Артамонова","Horror " , "2001" );
        public static BookShelf HorrorBook2 = new BookShelf("Кто стучится в дверь ко мне?", "Том Б. Стоун","Horror", "2002");


        public static BookShelf DetectiveBook1 = new BookShelf("Смерть приходит в конце", "Агата Кристи", "Detective", "1944");
        public static BookShelf DetectiveBook2 = new BookShelf("Шифр", "Изабелла Мальдонадо", "Detective", "2022");


        public static BookShelf ComedyBook1 = new BookShelf("Божественная комедия", "Данте Алигьери", " Comedy", "1320");
        public static BookShelf ComedyBook2 = new BookShelf("Рай", "Данте Алигьери", "Comedy ", "1320" );
    }
}
//checked
