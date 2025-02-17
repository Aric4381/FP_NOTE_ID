﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE_ID.API
{
    public class NoteIdJSON
    {
        public void SaveList<T>(List<T> list, string filePath)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
        }

        public void Save<T>(T obj, string filePath)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, obj);
            }
        }

        public List<T> LoadList<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
        }

        public T Load<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }
    }
}
