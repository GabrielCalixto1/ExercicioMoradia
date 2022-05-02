namespace ExercicioMoradia.Models
{
    public class House : Home
    {
        private bool HaveAYard { get; set; }

        public House(string adresses, int cep, double sizeInMeters, int quantityOfBathrooms, int quantityOfBedrooms, bool haveAYard) : base(adresses, cep, sizeInMeters, quantityOfBathrooms, quantityOfBathrooms)
        {
            HaveAYard = haveAYard;
        }

        public void SetHaveAYard(bool haveAYard)
        {
            HaveAYard = haveAYard;
        }
        public bool GetHaveAYard()
        {
            return HaveAYard;
        }
        public override double CalculateRent()
        {


            double HaveOneYard;

            var rent = (GetSizeInMeters() * 35) + (GetQuantityOfBedrooms() * 10) + (GetQuantityOfBathrooms() * 5);

            if (GetHaveAYard())
            {
                rent = rent * 1.1;
            }
            return rent;
        }
        public override void SetQuantityOfBathrooms(int quantityOfBathrooms)
        {
            if (quantityOfBathrooms >= 0 && quantityOfBathrooms <= 5)
            {
                QuantityOfBathrooms = quantityOfBathrooms;
            }

        }

        public override void SetSizeInMeters(double sizeInMeters)
        {
            if (sizeInMeters <= 100)
            {
                SizeInMeters = sizeInMeters;
            }

        }

    }

}