using Xunit;
using ExercicioMoradia.Models;
using System;
namespace ProjetoMoradia.TesteUnitario;

public class ResidentTest
{
    [Fact]
    public void DataDeNascimentoDeveSalvarOValor()

    {
        var expectedBirthdate = "04/04/2004";
        var resident = new Resident("Gabriel", "10688854791", expectedBirthdate);
        var currentBirthdate = resident.GetbirthDate();

        Assert.Equal(expectedBirthdate, currentBirthdate.ToString("dd/MM/yyyy"));
    }
    [Fact]
    public void BirthdateMustNotEmpty()

    {
        var birthdateEmpty = "";
        var resident = new Resident("Gabriel", "10688854791", birthdateEmpty);
        var currentbirthDate = resident.GetbirthDate();

        Assert.Equal(DateTime.MinValue, currentbirthDate);
    }
    [Fact]
    public void ResidentMustNotSaveCpfWithMoreThan11Caracterers()
    {
        var IncorrectCpf = "123456789111";
        var resident = new Resident("Gabriel", IncorrectCpf, "01/01/2001");
        var currentCpf = resident.GetCpf();
        Assert.Equal(null, currentCpf);
    }
    [Fact]
    public void TestFunctionGetName()
    {
        var expectedName = "Gabriel";
        var resident = new Resident(expectedName, "12345678911", "01/01/2001");
        var currentName = resident.GetName();
        Assert.Equal(currentName, expectedName);
    }

    [Fact]
    public void ZipCodeMustHave8Digits()
    {
        int expectedZipCode = 12345678;
        var home = new Home(expectedZipCode, 2);
        var currentZipCode = home.GetZipCode();
        Assert.Equal(expectedZipCode, currentZipCode );
    }

    [Fact]
    public void KitnetCanHave2Bathrooms()
    {
        int expectedBathroom = 2;
        Home kitnet = new Kitnet("test", 12345678, 40,  expectedBathroom, 2);
        var currentBathroom = kitnet.GetQuantityOfBathrooms();
        Assert.Equal(expectedBathroom, currentBathroom);
    }
    [Fact]
    public void ApartamentCanHaveUpTo3Bathrooms()
    {
        int expectedBathroom = 3;
        Home apartament = new Apartment("test", 12345678, 40, expectedBathroom, 2, 1, 20);
        var currentBathroom = apartament.GetQuantityOfBathrooms();
        Assert.Equal(expectedBathroom, currentBathroom);

    }

    [Fact]
    public void HouseCanHaveUpTo5Bathrooms()
    {
        int expectedBathroom = 5;
        Home house = new House("test", 12345678, 10, expectedBathroom, 3, true);
        var currentBathroom = house.GetQuantityOfBathrooms();
        Assert.Equal( expectedBathroom, currentBathroom );
    }

    [Fact]
    public void KitnetCanHaveUpTo50m2()
    {
        double expectedMeters = 50;
        Home kitnet = new Kitnet("test", 12345678, expectedMeters,  2, 2);
        var currentMeters = kitnet.GetQuantityOfBathrooms();
        Assert.Equal(expectedMeters, currentMeters);
    }


    [Fact]
    public void ApartamentCanHaveUpTo60m2()
    {
       double expectedMeters = 60;
        Home apartament = new Apartment("test", 12345678, expectedMeters, 1, 2, 1, 30);
        var currentMeters = apartament.GetQuantityOfBathrooms();
        Assert.Equal(expectedMeters, currentMeters);
    }
    [Fact]
    public void HouseCanHaveUpTo100m2()
    {
        double expectedMeters = 100;
        Home house = new House("test", 12345678, expectedMeters, 2, 3, true);
        var currentMeters = house.GetQuantityOfBathrooms();
        Assert.Equal(expectedMeters, currentMeters);
    }

    [Fact]
    public void ApartamentCanHaveUpTo10Floor()
    {
        int expectedfloor = 10;
        Home apartament = new Apartment("test", 12345678, 30, 1, 2, expectedfloor, 30);
        var currentfloor = apartament.GetQuantityOfBathrooms();
        Assert.Equal(expectedfloor, currentfloor);
   
    }
}

