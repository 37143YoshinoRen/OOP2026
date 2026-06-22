namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        public IEnumerable<Student> ReadScore(string filePath) {
            var student = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var scr = line.Split(',');　//カンマ区切りで分割
                var std = new Student {
                    Name = scr[0],
                    Subject = scr[1],
                    Score = int.Parse(scr[2]),
                };
                student.Add(std);
            }
            return student;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var sco in _score) {
                if (dict.ContainsKey(sco.Name))
                    dict[sco.Name] += sco.Score;
                else
                    dict[sco.Name] = sco.Score;
            }
            return dict;
        }
    }
}
