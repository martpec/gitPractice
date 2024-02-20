namespace ContactManagementSystem
{
    public class ContactBook
    {
        private readonly List<Contact> contacts = new();

        private int id = 0;
        // Implement methods for managing contacts (add, view, update, delete)

        public void ViewContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Id:{contact.getID()}\nName: {contact.getName()}\nMail: {contact.getEmail()}\nPhone: {contact.getPhoneNumber()}\n");
            }
        }

        public void UpdateContact()
        {
            Contact? Contact = ContactExists();

            if (Contact != null)
            {
                Console.WriteLine("Select what would you like to edit:\n1.Name\n2.Email\n3.Phone number");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter new full name for your contact: ");
                        string? newName = Console.ReadLine();
                        if(newName != null)
                            Contact.setName(newName);
                        break;
                    case "2":
                        Console.WriteLine("Enter new Email for your contact: ");
                        string? newEmail = Console.ReadLine();
                        if(newEmail != null)
                            Contact.setEmail(newEmail);
                        break;
                    case "3":
                        Console.WriteLine("Enter new phone number for your contact: ");
                        string? newPhone = Console.ReadLine();
                        if(newPhone != null)
                            Contact.setPhoneNumber(newPhone);
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public Contact? ContactExists() //object
        {
            Console.WriteLine("Give me ID of contact:");
            bool isInt = int.TryParse(Console.ReadLine(), out int contactID);
            if (isInt)
            {
                foreach (Contact contact in contacts) //why this doesn't work ?
                {
                    if (contact.ID == contactID)
                    {
                        return contact;
                    }
                    else
                    {
                        Console.WriteLine("There is no contact with this ID.");
                        return null;
                    }
                }
            }
            else
            {
                Console.WriteLine("This isn't a int you dumbass.");
                return null;
            }
            return null;
        }

        public void Add()
        {
            Console.Write("Name: ");
                string? name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Email: ");
                string? email = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Phone number: ");
                string? phoneNumber = Console.ReadLine();
            Console.WriteLine();

            if(name != null && email != null && phoneNumber != null)
            {
                Contact newContact = new Contact(id, name, email, phoneNumber);
                contacts.Add(newContact);
                id++;
            }
        }



        public void Delete()
        {
            Contact? deleteContact = ContactExists();

            if(deleteContact != null)
            {
                contacts.Remove(deleteContact);
            }
            else
            {
                Console.WriteLine("Error: void Delete()");
            }
        }
    }

}