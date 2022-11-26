using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engin_Demirog_OOP_1_11._11._2022
{
    public class Classes1
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.ReadLine();
        }    

    
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Added ");
            }

            public void Delete()
            {
                Console.WriteLine("Customer Deleted");
            }

            public void Update()
            {
                Console.WriteLine("Customer İnformation Updated");
            }
        }
    }
}
