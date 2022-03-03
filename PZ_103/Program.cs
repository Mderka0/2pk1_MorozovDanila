using System;

namespace PZ_103

{

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