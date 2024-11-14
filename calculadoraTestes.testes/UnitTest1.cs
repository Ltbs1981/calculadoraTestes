namespace calculadoraTestes.testes
{
    public class UnitTest1
    {
        Calculadora sut = new Calculadora();
        [Fact]
        public void Soma_DeveRetornarResultadoCorreto()

        {
//arrange
Calculadora sut = new Calculadora();
            double numero1 = 5;
            double numero2 = 4;
            double resultadoEsperado = 9;

            //act
            double resultado = sut.Soma(numero1, numero2);

            //assert
            Assert.Equal(resultadoEsperado, resultado);
        }
        [Fact]
        public void Subtracao_DeveRetornarResultadoCorreto()
        {
            // Arrange
            Calculadora sut = new Calculadora();
            double numero1 = 10;
            double numero2 = 4;
            double resultadoEsperado = 6;

            // Act
            double resultado = sut.Subtracao(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarResultadoCorreto()
        {
            // Arrange
            Calculadora sut = new Calculadora();
            double numero1 = 7;
            double numero2 = 6;
            double resultadoEsperado = 42;

            // Act
            double resultado = sut.Multiplicacao(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarResultadoCorreto()
        {
            // Arrange
            Calculadora sut = new Calculadora();
            double numero1 = 65536;
            double numero2 = 256;
            double resultadoEsperado = 256;

            // Act
            double resultado = sut.Divisao(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarZeroQuandoDivisorEhZero()
        {
            // Arrange
            Calculadora sut = new Calculadora();
            double numero1 = 512;
            double numero2 = 0;
            double resultadoEsperado = 0;

            // Act
            double resultado = sut.Divisao(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
