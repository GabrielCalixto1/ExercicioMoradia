using Xunit;
using ExercicioMoradia.Models;

namespace ProjetoMoradia.TesteUnitario;

public class ResidentTest
{
   
    public void Test1()
    
    {
        var birthDateEsperado = "04/04/2004";
        var resident = new Resident("Gabriel", "10688854791", birthDateEsperado);
        var birthDate = resident.GetbirthDate();

        Assert.Equal(birthDateEsperado, birthDate.ToString("dd/MM/yyyy"));
    }
     [Fact]
       public void MoradorDeveSalvarCpfComOnzeDigitos()
    {
       var birthDateEsperado = "04/04/2004";
        var resident = new Resident("Gabriel", "10688854791", birthDateEsperado);
        var birthDate = resident.GetbirthDate();

        Assert.Equal(birthDateEsperado, birthDate.ToString("dd/MM/yyyy"));
    }
    [Fact]
    public void MoradorNaoDeveSalvarCpfComMaisQueOnzeDigitos()
    {
        var IncorrectCpf = "123456789111";
        var resident = new Resident("Gabriel" , IncorrectCpf, "01/01/2001");
        var currentCpf = resident.GetCpf();
        Assert.Equal(null, currentCpf);
    }
    [Fact]
    public void test2()
    {
        var correctName = "Gabriel";
        var resident = new Resident(correctName, "12345678911" , "01/01/2001");
        var currentName = resident.GetName();
        Assert.Equal(currentName, correctName);
    }
    
}