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
       public void MoradorNaoDeveTerDataNascimentoMaiorQueADataAtual()
    {
       var birthDateEsperado = "04/04/2004";
        var resident = new Resident("Gabriel", "10688854791", birthDateEsperado);
        var birthDate = resident.GetbirthDate();

        Assert.Equal(birthDateEsperado, birthDate.ToString("dd/MM/yyyy"));
    }
}