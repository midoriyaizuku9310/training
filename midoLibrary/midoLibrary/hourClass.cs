namespace midoLibrary
{
    public class hourClass
    {
        public static string wishes()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 12)
                return "good morning ";
            else return "bye bye ";
        }
    }
}
