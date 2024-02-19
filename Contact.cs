namespace ContactManagementSystem
{
    public class Contact
    {
        private int ID;
        private string name;
        private string mail;
        private string phoneNumber;

        public Contact(int ID, string name, string mail, string phoneNumber)
        {
            this.ID = ID;
            this.name = name;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
        }
    }
}