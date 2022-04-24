namespace ExercicioMoradia.Models
{
    public class Apartment : Home
    {
        public int Floor {get; set;}
        public double CondominiumAmount {get; set;}
                public override double CalculateRent()
        {
                return 0;
        }
    }
}