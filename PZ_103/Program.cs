using System;

namespace PZ_103

{
    public class DeliveryRequest
    {
        uint id;
        DateTime requestTime;
        uint summ;
        string adr;

        uint total_summ = 0;
        static double total_request = 0;
        
        public static void counter_total_request()
        {
            Console.WriteLine($"Общая сумма заказа: {total_request}");
        }
        public static void counter_total_summ()
        {
            /*Console.WriteLine($"Общая сумма заказа: {total_summ}");*/
        }

        public DeliveryRequest(uint id, DateTime x, uint n, string a)
        {
            this.id = id;
            requestTime = x;
            summ = n;
            adr = a;

        }
        public DeliveryRequest(uint id, uint n, string a)
        {
            this.id = id;
            summ = n;
            adr = a;
        }
        public DeliveryRequest(uint id, DateTime x, string a)
        {
            this.id = id;
            requestTime = x;
            adr = a;
        }
        public DeliveryRequest(uint id, DateTime x, uint n)
        {
            this.id = id;
            requestTime = x;
            summ = n;
        }

        public uint ID
        { 
            get => id;
            set
            {
                if (value == 0)
                    Console.WriteLine("id data error");
                else id = value;
            }

        }

        public string ADR
        {
            get => adr;
            set
            {
                if (value == "")
                    Console.WriteLine("adres data error");
                else adr = value;
            }

        }

        public uint SUMM_NULL
        {
            get => summ;
            set
            {
                if (value == 0)
                    Console.WriteLine("summ data error");
                else summ = value;
            }

        }
        public uint SUMM
        {
            get => summ;
            set
            {
                if (value > 1000 && value < 10000)
                    Console.WriteLine("неверная сумма заказа");
                else summ = value;
            }

        }
        public DateTime RequestTime
        {
            get => requestTime;

            set 
            {
                DateTime date1 = new DateTime(2022, 01, 01);
                if (requestTime < date1)
                {
                    Console.WriteLine("Не правильная дата заказа");
                }
                else requestTime = value;
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
            uint id = Convert.ToUInt32(Console.ReadLine());
            DateTime requestTime = Convert.ToDateTime(Console.ReadLine());
            uint summ = Convert.ToUInt32(Console.ReadLine());
            string adr = Console.ReadLine();
            DeliveryRequest request1 = new DeliveryRequest(id, requestTime, summ, adr);
            request1.GetDeliveryInfo();

            DeliveryRequest request2 = new DeliveryRequest(id, summ, adr);
            request2.GetDeliveryInfo();

            DeliveryRequest request3 = new DeliveryRequest(id, requestTime, adr);
            request3.GetDeliveryInfo();

            DeliveryRequest request4 = new DeliveryRequest(id, requestTime, summ);
            request4.GetDeliveryInfo();

        }
    }
}