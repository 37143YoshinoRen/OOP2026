namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();
            while (true) { 
            //"アーティスト名："出力
            Console.WriteLine("曲名");
            string? title = Console.ReadLine();

            if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

            Console.Write("アーティスト名");
            string? artistname = Console.ReadLine();

            Console.Write("演奏時間（秒）：");
            int length = int.Parse(Console.ReadLine());

            Song song = new Song(title, artistname, length);

            songs.Add(song);

            Console.WriteLine();
            }
            PrintSongs(songs);
            
        }

        private static void PrintSongs(List<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine($"{song.Title},{song.ArtistName},{song.Length / 60}:{song.Length % 60}:00");
            }
        }
    }
}