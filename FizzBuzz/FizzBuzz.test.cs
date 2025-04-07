

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
    }
}