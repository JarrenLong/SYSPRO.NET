using System;
using System.Collections.Generic;
using System.Linq;

namespace SYSPRO.NET.BusinessObjects.SORTOXDOC
{
    namespace Response
    {
        public class postsalesordercancel
        {
            public Item Item { get; set; }
            public StatusOfItems StatusOfItems { get; set; }

            public postsalesordercancel() { }
        }

        public class StatusOfItems
        {
            public string ItemsProcessed { get; set; }
            public string ItemsInvalid { get; set; }

            public StatusOfItems() { }
        }

        public class Item
        {
            public string SalesOrder { get; set; }
            public string OriginalOrderStatus { get; set; }
            public string SalesOrderLine { get; set; }
            public string SalesOrderInitialLine { get; set; }
            public string LineType { get; set; }
            public string Cancelled { get; set; }
            public string Completed { get; set; }
            public string ItemNumber { get; set; }

            public Item() { }
        }
    }
}
