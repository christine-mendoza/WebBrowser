using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public int ID { get; set; }
        public String URL { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }

        public override String ToString()
        {
            String input = string.Format("{0} - {1} - {2}", Date, Title, URL);
            return input;
        }
    }
}
