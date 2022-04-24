namespace ExercicioMoradia.Models
{
    public class Apartment : Home
    {
        private int Floor { get; set; }
        private double CondominiumAmount { get; set; }
        public Apartment(string adresses, int cep, double sizeInMeters, int quantityOfBathrooms, int quantityOfBedrooms, int floor, double condominiumAmount) : base(adresses, cep, sizeInMeters, quantityOfBathrooms, quantityOfBathrooms)
        {
            Floor = floor;
            CondominiumAmount = condominiumAmount;
        }
        public void SetFloor(int floor)
        {
            Floor = floor;
        }
        public int GetFloor()
        {
            return Floor;
        }
        public void SetCondominiumAmount(double condominiumAmount)
        {
            CondominiumAmount = condominiumAmount;
        }
        public double GetCondominiumAmount()
        {
            return CondominiumAmount;
        }
        public override double CalculateRent()
        {
            var rent = (SizeInMeters * 40) + (GetQuantityOfBedrooms() * 10) + (GetQuantityOfBathrooms() * 5) + GetCondominiumAmount();
            return rent;
        }
    }
}