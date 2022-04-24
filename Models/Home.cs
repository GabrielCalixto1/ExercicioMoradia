namespace ExercicioMoradia.Models
{
    public class Home
    {
        public string Addresses {get; set;}
        public int Cep {get; set;}
        public double SizeInMeters {get; set;}
        public int QuantityOfBathrooms {get; set;}
        public int QuantityOfBedrooms {get; set;}
        public List<Resident> Residents  {get; set;}

        public virtual double CalculateRent()
        {
                return 0;
        }

        public void AddResident()
        {

        }
        public void RemoveResident()
        {

        }
    }
}