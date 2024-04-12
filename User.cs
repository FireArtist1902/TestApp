namespace TestApp
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsStident { get; set; } = false;
        public bool IsTeacher { get; set; } = false;
    }