namespace ExercicioMoradia.Models
{
    public class Resident
    {
        private string Name {get ; set;}
        private string Cpf {get; set;}
        private DateTime BirthDate {get; set;}
        public Resident(string name, string cpf, string dataNascimento)
        {
            Name = name;
            Cpf = cpf;
            SetbirthDate(dataNascimento);
        }
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
        public void SetbirthDate(string birthDate)
        {
            var birthDateDateTime = DateTime.Parse(birthDate);
            BirthDate = birthDateDateTime;
        }
        public DateTime GetbirthDate()
        {
           return BirthDate;
        }
        
    }
}