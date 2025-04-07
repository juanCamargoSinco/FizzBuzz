


namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Debe_generar_numeros_del_1_al_100()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            var result = fizzbuzz.GenerarSecuencia();

            Assert.Equal(1, result.First());
            Assert.Equal(100, result.Last());
        }

        [Fact]
        public void Debe_devolver_fizz_si_numero_es_3()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            var result = fizzbuzz.ValidarNumeroFizz(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Debe_numero_en_lugar_de_fizz_si_numero_no_es_3()
        {
            var fizzbuzz = new FizzBuzzGenerator();
            int numeroInsertado = 8;

            var result = fizzbuzz.ValidarNumeroFizz(numeroInsertado);

            Assert.Equal(numeroInsertado.ToString(), result);
        }
    }

    internal class FizzBuzzGenerator
    {
        internal List<int> GenerarSecuencia()
        {
            var numeros = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numeros.Add(i);
            }
            return numeros;
        }

        internal string ValidarNumeroFizz(int numero)
        {
            if(numero == 3)
                return "Fizz";

            return numero.ToString();
        }
    }
}