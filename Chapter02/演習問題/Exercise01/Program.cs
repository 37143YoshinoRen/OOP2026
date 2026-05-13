namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();

            //"アーティスト名："出力
            Console.Write("曲名");
            string? title = Console.ReadLine();

            Console.Write("アーティスト名");
            string? srtistname = Console.ReadLine();

            Console.Write("演奏時間（秒）：");
            int length = Console.Read();

            Console.ReadLine(); //バッファリング

            Song song = new Song(title, srtistname, length);

            songs.Add(song);

            var songs = new Song[] {
            new Song("Let it be", "The Beatles", 243),
             new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
             new Song("Close To You", "Carpenters", 276),
             new Song("Honesty", "Billy Joel", 231),
             new Song("I Will Always Love You", "Whitney Houston", 273),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine($"{song.Title},{song.ArtistName},{song.Length / 60}:{song.Length % 60}:00");
            }
        }
    }
}