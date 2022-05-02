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

        public override void SetQuantityOfBathrooms(int quantityOfBathrooms)
        {
            if (quantityOfBathrooms >= 0 && quantityOfBathrooms <= 2)
            {
                QuantityOfBathrooms = quantityOfBathrooms;
            }
        }
        public override void SetSizeInMeters(double sizeInMeters)
        {
            if (sizeInMeters <= 50)
            {
                SizeInMeters = sizeInMeters;
            }


        }
    }
}
