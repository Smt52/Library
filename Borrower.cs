namespace Library
{
    public class Borrower : User
    {


        public override bool LogIn()
        {
            Console.Write("Please enter your email:");
            string email = Console.ReadLine();
            Console.Write("Please enter your password:");
            string password = Console.ReadLine();

            if (email == null || password == null)
            {
                Console.WriteLine("Email or password cannot be empty.");
                return false;
            }
            if (email != _email || password != _password)
            {
                Console.WriteLine("Email or password is wrong.");
                return false;
            }

            return true;
        }

    }
}
