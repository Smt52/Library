namespace Library
{
    public abstract class User
    {
        public string Name { get; }
        protected string _email;
        protected string _password;

        public User(string name, string email, string password)
        {
            Name = name;
            _email = email;
            _password = password;
        }

        public abstract bool LogIn();
    }
}