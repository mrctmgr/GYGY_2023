using System;
using System.IO
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Reserved
{
    public dateTime StartDate { get; set; }
    public dateTime EndDate { get; set; }
    public int Price { get; set; }

    public bool IsReserved()
    {
        return StartDate < DateTime.Now && EndDate > DateTime.Now;
    }
}

public class hotelRoom : Reserved
{
    public string HotelName { get; set; }
    public int RoomNumber { get; set; }
    public int Floor { get; set; }

    public override int Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            if (value > 100)
            {
                base.Price = value;
            }
        }
    }

    public override bool IsReserved()
    {
        return base.IsReserved();
    }
}

public class meetingRoom : Reserved
{
    public string MeetingName { get; set; }
    public int RoomNumber { get; set; }
    public int Floor { get; set; }

    public override int Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            if (value > 100)
            {
                base.Price = value;
            }
        }
    }

    public override bool IsReserved()
    {
        return base.IsReserved();
    }
}

public class RentCar : Reserved
{
    public string CarName { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    public override int Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            if (value > 100)
            {
                base.Price = value;
            }
        }
    }

    public override bool IsReserved()
    {
        return base.IsReserved();
    }
}

