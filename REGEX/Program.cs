// See https://aka.ms/new-console-template for more information
using REGEX;

Console.WriteLine("Welcome to User Registration Problem Using REGEX!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Entering Valid FirstName\n2)Entering Valid LastName\n3)Entering Valid EmailId\n4)Enter Mobile Number");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName();
            break;
        case 2:
            UserRegistration userRegistration1 = new UserRegistration();
            userRegistration1.LastName();
            break;
        case 3:
            UserRegistration EmailID = new UserRegistration();
            EmailID.EmailID();
            break;
        case 4:
            UserRegistration Mobileno = new UserRegistration();
            Mobileno.MobileNumber();
            break;
        case 5:
            UserRegistration Pass = new UserRegistration();
            Pass.Password();
            break;
        default:
            Console.WriteLine("Please select the correct option");
            break;

    }
}