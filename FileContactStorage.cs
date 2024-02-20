using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ContactManagementSystem
{
    public class FileContactStorage : IContactStorage
    {
        private readonly string filePath = "contacts.json";
        public List<Contact> LoadContacts()
        {
            //string jsonText = File.ReadAllText(filePath);
            //dynamic data = JsonConvert.DeserializeObject(jsonText);
            //example: string message = data.message;
            // message: "hi"
            /*foreach (var item in data)
            {
                var data.user
            }*/
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Contact>>(json);
            }
            else
            {
                return new List<Contact>();
            }

            // Load contacts from JSON file if exists, else return new list
            // Use JsonSerializer.Deserialize to convert JSON string to List<Contact>
            throw new NotImplementedException();
        }

        public void SaveContacts(List<Contact> contacts)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(filePath, json);
            // Save contacts to JSON file
            // Use JsonSerializer.Serialize with WriteIndented option for pretty print
            throw new NotImplementedException();
        }
    }
}
