namespace ContactManagementSystem
{
    public class Contact
    {
        public int ID;
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

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return mail;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmail(string mail)
        {
            this.mail = mail;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}