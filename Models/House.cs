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
            return 0;
        }
    }
}