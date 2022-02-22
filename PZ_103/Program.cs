using System;

namespace PZ_103

{
    public class DeliveryRequest
    {
        uint id;
         DateTime requestTime;
        public int summ;
        public string adr;
        public DeliveryRequest(uint id, DateTime x, int n, string a)
        {
            this.id = id;
            requestTime = x;
            summ = n;
            adr = a;
            /*if (id == null || id == 0)
            {
                Console.WriteLine("Не корректное ID");
            }
            if (adr == null)
            {
                Console.WriteLine("Не указан адрес");
            }*/

        }
        /*public DeliveryRequest(int id, int n, string a)
        {
            this.id = id;
            summ = n;
            adr = a;
        }
        public DeliveryRequest(int id, DateTime x, string a)
        {
            this.id = id;
            requestTime = x;
            adr = a;
        }
        public DeliveryRequest(int id, DateTime x, int n)
        {
            this.id = id;
            requestTime = x;
            summ = n;
        }*/

        public uint ID
        { 
            get => id;
            set
            {
                if (value == 0)
                    Console.WriteLine("data error");
                else id = value;
            }

        }

        public DateTime RequestTime
        {
            get => requestTime;

            set 
            { 
                if (requestTime < 01.01.2022)
                { 
                           
                }
            }
        }
        public void GetDeliveryInfo()
        {
            Console.WriteLine($"id: {id};\n Request time: {requestTime};\n summ: {summ};\n adr: {adr}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int id = Convert.ToUInt32(Console.ReadLine());
            DateTime requestTime = Convert.ToDateTime(Console.ReadLine());
            int summ = Convert.ToInt32(Console.ReadLine());
            string adr = Console.ReadLine();
            DeliveryRequest request1 = new DeliveryRequest(id, requestTime, summ, adr);
            request1.GetDeliveryInfo();
           /* DeliveryRequest request2 = new DeliveryRequest(id, summ, adr);
            request2.GetDeliveryInfo();
            DeliveryRequest request3 = new DeliveryRequest(id, requestTime, adr);
            request3.GetDeliveryInfo();
            DeliveryRequest request4 = new DeliveryRequest(id, requestTime, summ,);
            request4.GetDeliveryInfo();*/

        }
    }
}