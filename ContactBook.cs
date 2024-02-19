namespace ContactManagementSystem
{
    public class ContactBook
    {
        private readonly List<Contact> contacts = new();

        private int id = 0;
        // Implement methods for managing contacts (add, view, update, delete)
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
