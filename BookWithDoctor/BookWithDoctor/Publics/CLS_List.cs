using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWithDoctor.Publics
{
    public static class CLS_List
    {
        public static List<string> ID = new List<string>();
        public static List<string> Name = new List<string>();
        public static List<string> Date = new List<string>();
        public static List<string> Notes = new List<string>();
        public static void Add(string id, string name, string date, string notes)
        {
            ID.Add(id);
            Name.Add(name);
            Date.Add(date);
            Notes.Add(notes);
        }
        public static void Edit(string id, string name, string date, string notes)
        {
            Name[int.Parse(id)] = name;
            Date[int.Parse(id)] = date;
            Notes[int.Parse(id)] = notes;
        }
        public static string Show(string id)
        {
            string Book;
            return Book = "* الرقم التسلسلي: " + ID[int.Parse(id)] + " - الاسم الكامل: " + Name[int.Parse(id)] + " - التاريخ: " + Date[int.Parse(id)] + " - الملاحظات: " + Notes[int.Parse(id)];
        }
        public static int LsSize()
        {
            return ID.Count;
        }
    }
}
