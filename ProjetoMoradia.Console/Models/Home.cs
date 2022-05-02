namespace ExercicioMoradia.Models
{
    public class Home
    {
        private string Addresses { get; set; }
        private int ZipCode { get; set; }
        protected double SizeInMeters { get; set; }
        protected int QuantityOfBathrooms { get; set; }
        private int QuantityOfBedrooms { get; set; }
        private List<Resident> Residents { get; set; }

        public Home(string adresses, int cep, double sizeInMeters, int quantityOfBathrooms, int quantityOfBedrooms)
        {
            Addresses = adresses;
            SizeInMeters = sizeInMeters;
            QuantityOfBathrooms = quantityOfBathrooms;
            QuantityOfBedrooms = quantityOfBedrooms;
            new List<Resident>();

        }
        public Home(int zipCode, int quantityOfBathrooms)
        {
            SetZipCode(zipCode);
            SetQuantityOfBathrooms(quantityOfBathrooms);
        }

        public void SetAdress(string adress)
        {
            Addresses = adress;
        }
        public string GetAdress()
        {
            return Addresses;
        }
        public void SetZipCode(int zipCode)
        {

            if (zipCode.ToString().Length == 8)
            {
                ZipCode = zipCode;
            }



        }
        public int GetZipCode()
        {
            return ZipCode;
        }
        public virtual void SetSizeInMeters(double sizeInMeters)
        {
            if(sizeInMeters <= 50)
            {
                   SizeInMeters = sizeInMeters;
            }                 
            
        }
        public double GetSizeInMeters()
        {
            return SizeInMeters;
        }
        public void SetAdress(int quantityOfBathrooms)
        {
            QuantityOfBathrooms = quantityOfBathrooms;
        }
        public virtual void SetQuantityOfBathrooms(int quantityOfBathrooms)
        {
            if(quantityOfBathrooms >= 0 && quantityOfBathrooms <= 2)
            {
                    QuantityOfBathrooms = quantityOfBathrooms;
            }
           
        }
        public int GetQuantityOfBathrooms()
        {
            return QuantityOfBathrooms;
        }
        public void SetQuantityOfBedrooms(int quantityOfBedrooms)
        {
            QuantityOfBedrooms = quantityOfBedrooms;

        }
        public int GetQuantityOfBedrooms()
        {
            return QuantityOfBedrooms;
        }
        public void SetResidents(List<Resident> residents)
        {
            Residents = residents;
        }
        public List<Resident> GetResidents()
        {
            return Residents;
        }

        public virtual double CalculateRent()
        {
            return 0;
        }

        public void AddResident(Resident newResident)
        {
            var resident = new List<Resident>();
            resident.Add(newResident);
        }
        public void RemoveResident(Resident formerResident)
        {
            var resident = new List<Resident>();
            resident.Remove(formerResident);
        }
    }
}