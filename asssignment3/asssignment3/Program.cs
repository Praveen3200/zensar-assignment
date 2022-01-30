using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
    class TicketBookingException : ApplicationException
    {
        public TicketBookingException(string msg):base(msg)
        {

        }
    }
    class Passenger
    {
        public string Name;
        public int Age;
        public int tickets;
        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets>5)
            {
                throw (new TicketBookingException("cannot book more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("tickets booked successfully");
            }
        }
    }
    class Test : Passenger
    {
      public void test()
        {
            Console.WriteLine("enter passenger name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter passenger age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no.of tickets to book:");
            tickets = Convert.ToInt32(Console.ReadLine());
            TicketBooking(tickets);
        }
    }
    class ExceptionHandling
    {
        static void Main()
        {
            Test t = new Test();
            try
            {
                t.test();
            }
            catch(TicketBookingException tb)
            {
                Console.WriteLine(tb.Message);
            }
            Console.Read();
        }
    }
}
