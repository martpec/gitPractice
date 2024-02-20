using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ContactManagementSystem
{
    public class FileContactStorage : IContactStorage
    {
        private readonly string filePath = "./contacts.json";
        public List<Contact> LoadContacts()
        {
            if (File.Exists(filePath))
    {
        var json = File.ReadAllText(filePath);
        if (string.IsNullOrWhiteSpace(json))
        {
            // File is empty, return a new list
            return new List<Contact>();
        }
        try
        {
            return JsonSerializer.Deserialize<List<Contact>>(json);
        }
        catch (JsonException)
        {
            // JSON is not properly formatted, return a new list
            return new List<Contact>();
        }
    }
    else
    {
        return new List<Contact>();
    }
        }

        public void SaveContacts(List<Contact> contacts)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(filePath, json);
        }
    }
}