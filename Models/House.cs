namespace ExercicioMoradia.Models
{
    public class House : Home
    {
        public bool HaveAYard {get; set;}
                        public override double CalculateRent()
        {
                return 0;
        }
    }
}