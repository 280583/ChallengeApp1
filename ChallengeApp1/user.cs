namespace ChallengeApp1
{
    public internal class user
    {
        User user1 = new User("Adam", "3456fdd");
        User user2 = new User("Monika", "3456fdd");
        User user3 = new User("Zuzia", "3456fdd");
        User user4 = new User("Damian", "3456fdd");

        var name = user1.Login;
        user1.AddScore(5);
user1.AddScore(2);
var result = user1.result;
        Console.WriteLine(result);
var name = User.Gamename;
        var pI = Math.PI;

        class User
        {
            public static string Gamename = "Diablo";
            private List<int> score = new List<int>();
            public User(string login, string password
            {
                this.Login = login;
                this.Password = password;
            }

            public string Login { get; private set; }

            public string Password { get; private set; }

            public int Resoult;
    {
                get
                {
                    return this.score.Sum();
                }
            }


            public void AddScore(int number)
            {
                this.score.Add(number);
            }
        }
    }
}
