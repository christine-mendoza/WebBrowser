﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
   public class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            var returnURL = adapter.URLExistQuery(item.URL);
            if (returnURL == null)
            {
                adapter.Insert(item.URL, item.Title);
            }
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.ID = row.Id;
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);
            }
            return results;
        }

        public void DeleteItem(int ID)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Delete1(ID);
        }

    }
}


