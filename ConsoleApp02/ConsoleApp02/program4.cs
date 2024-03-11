namespace ConsoleApp02

{
    enum vehicleType
        {
        TwoWheeler, FourWheeler
    }

    class ParkingArea
    {
        private vehicleType type;
        private int count, price, amount;

        public ParkingArea(vehicleType type, int count)
        {
            this.type = type;
            this.count = count;
            if (type == vehicleType.TwoWheeler)
            {
                price = 20;
            }
            else if (type == vehicleType.FourWheeler) price = 40;

            amount = price * count;

        }

        public void getDetails()
        {
            Console.WriteLine($"vehicle type is {type}, count of {type} vehicles: {count}, price: {price}, amount: {amount}");
        }

        public void bigCount(ParkingArea slot)
        {
            if (count > slot.count)
                Console.WriteLine($"{type} slot is bigger and count {count}");
            else if
                (count == slot.count)
                Console.WriteLine("both slot uints are same");
            else
                Console.WriteLine($"{slot.type} slot is higher and count is {slot.count}");
        }

        public void bigAmount(ParkingArea amount2)
        {
            if (amount > amount2.amount)
                Console.WriteLine($"{type} has the greatest amount : {amount}");
            else if (amount == amount2.amount)
                Console.WriteLine("both has same amount");
            else
                Console.WriteLine($"{amount2.type} has the greatest amount: {amount2.amount}");
        }
    }
    public class program4
    {
        static void Main()
        {
            ParkingArea p1 = new ParkingArea(vehicleType.TwoWheeler,20);
            ParkingArea p2 = new ParkingArea(vehicleType.FourWheeler, 40);

            p1.getDetails();
            p2.getDetails();

            p1.bigCount(p2);
            p2.bigAmount(p1);



        }
    }
}
