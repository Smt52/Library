namespace Library
{
    public abstract class User
    {
        public string Name { get; }
        protected string _email;
        protected string _password;

        public abstract bool LogIn();
        

    }
}
