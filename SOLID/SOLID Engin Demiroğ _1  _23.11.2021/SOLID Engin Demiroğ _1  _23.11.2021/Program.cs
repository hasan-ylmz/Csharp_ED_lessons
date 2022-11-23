using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Engin_Demiroğ__1___23._11._2021
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Sıngle of responsibilty
             Open Closed 
             Liskov's Substituon 
             Interface Segregeation
             Dependecy inversion 
             
            Data access
            Business
            MVC 

            // SINGLE OF REPSONSİBİLİTY // 

            Sorun 1 - Mvc katmanında business kodlarının  yazılması .
                    
            Olması gereken : 
                    - Mvc katmanında sadece arayüz ile alakalı kodlar yazılır. 
            
            Sorun 2 - Business içerisine Data access kodu koymak . Progrmacı business katmanu içinde veriye erişmeye çalışıyor .

            Kurumsal mimaride Data access kısmında yapılan daha genel bir sorun , method içinde iki context açıyor .Contextler de farklı sorgular gönderiyor .
            Bir method içinde aslında iki tane işlem yapılıyor . // Single of responsibility prensibine aykırı 



             */
        }
    }

    class CustomerManager
    {
        // TransActionalOperation = Bir tabloya update bir tabloya insert yapılacak. 
        // Aspect Oriented Programming SOR prensibini ciddi manada korur .
        public void TransActionalOperation()
        {
            Insert();
            Update();

        }

        public void Update()
        {
            Mycontext context = new Mycontext();
            context.Update();
        }

        public void Insert()
        {
            Mycontext context = new Mycontext();
            context.Insert();
        }
    }

    class PersonManager
    { 
        public void Add()
        {
            CustomerManager customerManager= new CustomerManager();
            customerManager.Insert();
        }

        public void Update()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Update();
        }
    }

    internal class Mycontext 
    {
        public void Insert()
        {

        }

        public void Update()
        {

        }
    
    }
}
