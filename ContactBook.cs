namespace ContactManagementSystem
{
    public class ContactBook
    {
        private readonly List<Contact> contacts = new();

        private int id = 0;
        // Implement methods for managing contacts (add, view, update, delete)

        public void ViewContacts()
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Id:{contact.ID}\nName: {contact.Name}\nMail: {contact.Mail}\nPhone: {contact.PhoneNumber}\n");
            }
        }

        public void UpdateContact()
        {
            object Contact = ContactExists();
            
            if(Contact != null)
            {
                Console.WriteLine("Select what would you like to edit:\n1.Name\n2.Email\n3.Phone number");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter new full name for your contact: ");
                        string newName = Console.ReadLine();
                        Contact.Name = newName;
                        break;
                    case "2":
                    Console.WriteLine("Enter new Email for your contact: ");
                        string newEmail = Console.ReadLine();
                        Contact.Email = newEmail;
                        break;
                    case "3":
                        Console.WriteLine("Enter new phone number for your contact: ");
                        string newPhone = Console.ReadLine();
                        Contact.PhoneNumber = newPhone;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public Contact ContactExists() //object
        {
            Console.WriteLine("Give me ID of contact.");
            bool isInt = int.TryParse(input, out int contactID);
            if(isInt)
            {
                foreach(var contact in contacts)
                {
                    if(contact.ID == contactID)
                    {
                        return contact;
                    }
                    else
                    {
                        Console.WriteLine("There is no contact with this ID.");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("This isn't a int you dumbass.");
                continue;
            }

        public void Add()
        {            
            Console.Write("Name: ")
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Email: ")
            string email = Console.ReadLine();   
            Console.WriteLine();
            Console.Write("Phone number: ")
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();

            Contact newContact = new Contact(id, name, mail, phoneNumber);
            contacts.Add(newContact);
            id++;   
        }



        public void Delete()
        {
            
        }
    }

}
