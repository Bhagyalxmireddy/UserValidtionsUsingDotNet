using System;

namespace UserValidationsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To UserRegistration program");
            UserValidation validation = new UserValidation();
            Console.WriteLine("Enter FirstName : ");
            String firstName = Console.ReadLine();
            Console.WriteLine(validation.firstName_Validation(firstName));
            Console.WriteLine("Enter LastName : ");
            String lastName = Console.ReadLine();
            Console.WriteLine(validation.lastName_Validation(lastName));
            Console.WriteLine("Enter MobileNumber : ");
            String mobileNumber = Console.ReadLine();
            Console.WriteLine(validation.mobileNumber_Validation(mobileNumber));
            Console.WriteLine("Enter Email : ");
            String emailID = Console.ReadLine();
            Console.WriteLine(validation.email_Validation(emailID));
            Console.WriteLine("Enter Password : ");
            String password = Console.ReadLine();
            Console.WriteLine(validation.password_Validation(password));
            Console.ReadKey();
        }
    }
}
