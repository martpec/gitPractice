namespace ContactManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize new FileContactStorage and ContactBook.
            FileContactStorage fcs = new();
            ContactBook cb = new();

            fcs.LoadContacts();
            // Implement user interaction loop here:
            // Display menu options, take user input, and call corresponding ContactBook methods
            while (true)
            {
                Console.WriteLine("\nContact Book Application");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        cb.Add();
                        break;
                    case "2":
                        cb.ViewContacts();
                        break;
                    case "3":
                        cb.UpdateContact();
                        break;
                    case "4":
                        cb.Delete();
                        break;
                    case "5":
                        Console.WriteLine("\n\n\n\n\nTolko kontaktov mame:");
                        foreach (var contact in cb.contacts)
                        {
                            Console.WriteLine($"Id:{contact.getID()}\nName: {contact.getName()}\nMail: {contact.getEmail()}\nPhone: {contact.getPhoneNumber()}\n");
                        }
                        fcs.SaveContacts(cb.contacts);
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }

        }
    }

}