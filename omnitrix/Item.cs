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
            Console.WriteLine("Added Successfully");
        }
        public void Update()
        {
            Console.WriteLine("Updated Successfully");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted Successfully");
        }
    }

    public interface Iitem
    {
        void Create();
        void Update();
        void Delete();
    }

}
