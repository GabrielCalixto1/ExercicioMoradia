namespace ExercicioMoradia.Models
{
    public class Resident
    {
        private string Name { get; set; }
        private string Cpf { get; set; }
        private DateTime Birthdate { get; set; }
        public Resident(string name, string cpf, string birthdate)
        {
            SetName(name);
            SetCpf(cpf);
            SetbirthDate(birthdate);
    
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
            if (cpf.Length != 11)
            {
                Cpf = null;
                return;
            }
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetbirthDate(string birthDate)
        {
            if (string.IsNullOrEmpty(birthDate))
                return;
            var birthDateDateTime = DateTime.Parse(birthDate);
            if (birthDateDateTime.CompareTo(DateTime.Now) > 0)
                return;
            Birthdate = birthDateDateTime;

        }
        public DateTime GetbirthDate()
        {
            return Birthdate;
        }

    }
}