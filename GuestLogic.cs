
namespace GuestBookDemo
{
	public static class GuestLogic
	{
		public static void WelcomeMessage()
		{
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("******************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            Console.Write("What is your party/group name?: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;

            do
            {

                Console.Write("How many people are in your party?: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }
    }
}

