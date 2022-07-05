using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omnitrix
{
    internal class Details
    {
        private string item;
        private string category;
        private string purchase;
        private string purchaseOrder;

        public string Item { get => item; set => item = value; }
        public string Category { get => category; set => category = value; }
        public string Purchase { get => purchase; set => purchase = value; }
        public string PurchaseOrder { get => purchaseOrder; set => purchaseOrder = value; }
    }
}
