namespace ExercicioMoradia.Models
{
    public class Kitnet : Home
    {
        public Kitnet(string adresses, int cep, double sizeInMeters, int quantityOfBathrooms, int quantityOfBedrooms) : base(adresses, cep, sizeInMeters, quantityOfBathrooms, quantityOfBathrooms)
        {

        }
        public override double CalculateRent()
        {
            var rent = SizeInMeters * 30;
            return rent;
        }
    }
}