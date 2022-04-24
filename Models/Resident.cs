namespace ExercicioMoradia.Models
{
    public class Resident
    {
        private string Name {get ; set;}
        private string Cpf {get; set;}
        private DateTime BirthDate {get; set;}
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
           return Name;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string GetCpf()
        {
           return Cpf;
        }
        public void SetFloor(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime GetFloor()
        {
           return BirthDate;
        }
        
    }
}