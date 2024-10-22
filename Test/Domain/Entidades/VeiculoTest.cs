namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange - variáveis que criamos para fazer as validações
        var veiculo = new VeiculoDTO();

        //Act - ação que faremos devido a validação
        veiculo.Nome = "Nome Veículo";
        veiculo.Marca = "Marca Veículo";
        veiculo.Ano = 2018;

        //Assert - validação dos dados
        Assert.AreEqual("Nome Veículo", veiculo.Nome);
        Assert.AreEqual("Marca Veículo", veiculo.Marca);
        Assert.AreEqual(2018, veiculo.Ano);
    }
}