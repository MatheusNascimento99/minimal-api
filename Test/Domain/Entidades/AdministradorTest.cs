namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange - variáveis que criamos para fazer as validações
        var adm = new Administrador();

        //Act - ação que faremos devido a validação
        adm.Id = 1;
        adm.Email = "teste@testando.com";
        adm.Senha = "teste123";
        adm.Perfil = "Perfil-teste";

        //Assert - validação dos dados
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@testando.com", adm.Email);
        Assert.AreEqual("teste123", adm.Senha);
        Assert.AreEqual("Perfil-teste", adm.Perfil);
    }
}