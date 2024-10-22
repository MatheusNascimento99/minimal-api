namespace Test.Domain.Entidades;

[TestClass]
public class LoginTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange - variáveis que criamos para fazer as validações
        var login = new LoginDTO();

        //Act - ação que faremos devido a validação
        login.Email = "LOGIN@testando.com";
        login.Senha = "teste123";

        //Assert - validação dos dados
        Assert.AreEqual("LOGIN@testando.com", login.Email);
        Assert.AreEqual("teste123", login.Senha);
    }
}