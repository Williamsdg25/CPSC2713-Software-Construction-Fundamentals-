using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            try
            {
                var adapter = new HistoryTableAdapter();
                adapter.Insert(item.URL, item.Title, item.Date);
            }
            catch
            {
                
            }
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
#pragma warning disable IDE0017 // Simplify object initialization
                var item = new HistoryItem();
#pragma warning restore IDE0017 // Simplify object initialization
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;

                results.Add(item);
            }
            return results;
        }

        public static void DeleteHistory()
        {
            var adapter = new HistoryTableAdapter();
            //var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                row.Delete();
/*#pragma warning disable IDE0017 // Simplify object initialization
                var item = new HistoryItem();
#pragma warning restore IDE0017 // Simplify object initialization
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;*/
                
                //results.Remove(item);
            }
        }
    }
}
