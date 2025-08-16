namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "John Doe";
            String phoneNumber = "123-456-7890";

            // fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);

            String username = fullName.Insert(0, "mr.");
            Console.WriteLine(username);

            Console.WriteLine(fullName.Length); // Outputs the length of the string

            String firstName = fullName.Substring(0, 4); // Extracts "John"
            String lastName = fullName.Substring(5, 3); // Extracts "Doe"
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}