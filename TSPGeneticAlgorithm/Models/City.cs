using System.Text.Json.Serialization;

namespace TSPGeneticAlgorithm.Models
{
    public class City
    {
        public int ID { get; set; }
        public double X  { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        public City(int id, double x, double y)
        {
            ID = id;
            X = x;
            Y = y;
            Name = $"City_{ID+1}";
        }

        [JsonConstructor]
        public City(int id, string name, double x, double y)
        {
            ID = id;
            X = x;
            Y = y;
            Name = name;
        }

        public double DistanceTo(City other)
        {
            double D_x =  X - other.X,
                   D_y  = Y - other.Y;
            return Math.Sqrt(D_x* D_x + D_y * D_y);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

