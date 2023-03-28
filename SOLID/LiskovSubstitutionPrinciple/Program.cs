using System
using Reserved

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotelRoom = new HotelRoom();
            hotelRoom.StartDate = DateTime.Now.AddDays(-1);
            hotelRoom.EndDate = DateTime.Now.AddDays(1);
            hotelRoom.Price = 100;
            hotelRoom.HotelName = "Hotel";
            hotelRoom.RoomNumber = 1;
            hotelRoom.Floor = 1;
            Console.WriteLine(hotelRoom.IsReserved());
            Console.WriteLine(hotelRoom.Price);
            Console.WriteLine(hotelRoom.HotelName);
            Console.WriteLine(hotelRoom.RoomNumber);
            Console.WriteLine(hotelRoom.Floor);
            Console.WriteLine();

            var meetingRoom = new MeetingRoom();
            meetingRoom.StartDate = DateTime.Now.AddDays(-1);
            meetingRoom.EndDate = DateTime.Now.AddDays(1);
            meetingRoom.Price = 100;
            meetingRoom.MeetingName = "Meeting";
            meetingRoom.RoomNumber = 1;
            meetingRoom.Floor = 1;
            Console.WriteLine(meetingRoom.IsReserved());
            Console.WriteLine(meetingRoom.Price);
            Console.WriteLine(meetingRoom.MeetingName);
            Console.WriteLine(meetingRoom.RoomNumber);
            Console.WriteLine(meetingRoom.Floor);
            Console.WriteLine();

            var RentCar = new RentCar();
            RentCar.StartDate = DateTime.Now.AddDays(-1);
            RentCar.EndDate = DateTime.Now.AddDays(1);
            RentCar.Price = 100;
            RentCar.CarName = "Car";
            RentCar.CarNumber = 1;
            Console.WriteLine(RentCar.IsReserved());
            Console.WriteLine(RentCar.Price);
            Console.WriteLine(RentCar.CarName);
            Console.WriteLine(RentCar.CarNumber);
            Console.WriteLine();
        }
    }
}
{
    
}