namespace FunWithMusic;

class Program
{
    enum Genre
    {
        Hiphop,
        Pop,
        Rock,
        Country,
        Jazz
    }
    struct Music
    {
        private string Title;
        private string Artist;
        private string Album;
        private string Length;
        private Genre? Genre;

        public Music(string title, string artist, string album, string length, Genre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }
        public void setTitle(string title)
        {
            Title = title;
        }
        public void setLength(string length)
        {
            Length = length;
        }
        public string Display()
        {
            return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("What is the title of your favorite song?");
        string tempTitle = Console.ReadLine();
        Console.WriteLine("Who is the artist?");
        string tempArtist = Console.ReadLine();
        Console.WriteLine("Which album is the song on?");
        string tempAlbum = Console.ReadLine();
        Console.WriteLine("What is the length of the song?");
        string tempLength = Console.ReadLine();
        Console.WriteLine("What is the genre?");
        Console.WriteLine("H - Hip hop\nP - Pop\nR - Rock\nC - Country\nJ - Jazz");
        Genre tempGenre = Genre.Hiphop;
        char g = char.Parse(Console.ReadLine());
        switch(g)
        {
            case 'H':
                tempGenre = Genre.Hiphop;
                break;
            case 'P':
                tempGenre = Genre.Pop;
                break;
            case 'R':
                tempGenre = Genre.Rock;
                break;
            case 'C':
                tempGenre = Genre.Country;
                break;
            case 'J':
                tempGenre = Genre.Jazz;
                break;
        }
        Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
        Music moreMusic = music;
        moreMusic.setTitle("Bandit");
        moreMusic.setLength("2.28");
        Console.WriteLine("Here's song #2");
        Console.WriteLine($"{moreMusic.Display()}");
        Console.WriteLine();
        Console.WriteLine("Here's song #1");
        Console.WriteLine($"{music.Display()}");
    }
}

