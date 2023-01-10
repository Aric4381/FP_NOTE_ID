﻿using NOTE_ID.API;
using NOTE_ID.Data_Acces_Layer;
using NOTE_ID.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NOTE_ID
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Book> books = new List<Book>();
        public static List<QuickNote> quickNotes = new List<QuickNote>();
        public static NoteIdJSON JsonClient = new NoteIdJSON();

        public App()
        {
            books = JsonClient.LoadList<Book>("Book.json");
        }

        ~App()
        {
            JsonClient.SaveList<Book>(books, "Book.json");
            
        }
    }
}
