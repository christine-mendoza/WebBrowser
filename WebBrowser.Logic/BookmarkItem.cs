using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        public int ID { get; set; }
        public String URL { get; set; }
        public String Title { get; set; }

        public override string ToString()
        {
            String input = string.Format("{0} - {1}", Title, URL);
            return input;
        }
    }
}
