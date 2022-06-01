using System.Text;
namespace laba2_1
{
    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Wing wing = new Wing();
            Wheels wheels = new Wheels();
            Engine engine = new Engine();


            Plane plane = new Plane(wheels, wing, engine, "Boing", "red", "DF4585");
            string startPoint = "Kiev";
            string finishPoint = "London";

            plane.CreateRoute(startPoint, finishPoint);
            plane.ShowRoute();
            plane.Fly();
        }
    }
}
