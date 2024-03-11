namespace ConsoleApp02
{
    abstract class university
    {
        public void courseDesign()
        {
            Console.WriteLine("the courses are made within uiversity");
        }

        public abstract void enrollment();
    }

    class studyCenter : university
    {
        public override void enrollment()
        {
            Console.WriteLine("enrollements are made in study center");
        }
    }

    class program8
    {
        static void Main()
        {
            studyCenter sc = new studyCenter();
            sc.courseDesign();
            sc.enrollment();
        }
    }
}