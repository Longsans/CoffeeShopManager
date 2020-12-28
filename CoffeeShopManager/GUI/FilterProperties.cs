using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FilterProperties
    {
        public string CurrentFilter { get; set; }
        public string CurrentFilterText { get; set; }

        public FilterProperties()
        {
            CurrentFilter = null;
            CurrentFilterText = null;
        }

        public FilterProperties(string filter, string filtertext)
        {
            CurrentFilter = filter;
            CurrentFilterText = filtertext;
        }
    }
}
