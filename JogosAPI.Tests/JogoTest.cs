using JogosAPI.Controllers;
using JogosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosAPI.Tests
{
    public class JogoTest
    {
        [Fact]
        public void Obter_DeveRetornarListaDeJogos()
        {
            // Arrange
            var controller = new JogoController();

            // Act
            var resultado = controller.Obter();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(resultado);
            var jogos = Assert.IsType<List<Jogo>>(okResult.Value);

            Assert.Equal(4, jogos.Count);
        }

        [Fact]
        public void Obter_DeveRetornarTituloPrimeiroJogo()
        {
            // Arrange
            var controller = new JogoController();

            // Act
            var resultado = controller.Obter();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(resultado);
            var jogos = Assert.IsType<List<Jogo>>(okResult.Value);

            Assert.Equal("Hollow Knight", jogos[0].Titulo);
        }
    }
}