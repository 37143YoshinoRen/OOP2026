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

            
            PrintSongs(songs);
        }

        private static void PrintSongs(List<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine($"{song.Title},{song.ArtistName},{song.Length / 60}:{song.Length % 60}:00");
            }
        }
    }
}