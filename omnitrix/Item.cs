using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omnitrix
{
    public class Item : Iitem
    {
        public void Create()
        {
            Console.WriteLine("Item added Successfully");
        }
        public void Update()
        {
            Console.WriteLine("Item updated Successfully");
        }
        public void Delete()
        {
            Console.WriteLine("Item deleted Successfully");
        }
    }

    public interface Iitem
    {
        void Create();
        void Update();
        void Delete();
    }

}
