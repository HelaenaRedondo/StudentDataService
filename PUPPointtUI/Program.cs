using UserDataAccount;
using PUPPointsBusinessServices;
namespace PUPPointUI
{

    public class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student account: ");
            string userdataService = Console.ReadLine();

            UserDataService userDataService = new UserDataService();
            bool result = userdataService.Equals(userdataService);

            if (result)
            {
                Console.WriteLine("Wew Mali!");
            }
            else
            {
                {
                    Console.WriteLine("Welcome to your account!");
                }
            }
        }
    }
}
