using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var adm = new Administrador();

        //Act
        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);

        //Arrange
        var vei = new Veiculo();

        //Act
        vei.Id = 1;
        vei.Nome = "teste.veiculo";
        vei.Marca = "teste";
        vei.Ano = 1;

        //Assert
        Assert.AreEqual(1, vei.Id);
        Assert.AreEqual("teste.veiculo", vei.Nome);
        Assert.AreEqual("teste", vei.Marca);
        Assert.AreEqual(1, vei.Ano);
    }
}