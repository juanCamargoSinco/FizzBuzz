

namespace FizzBuzz
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Debe_escribir_numeros_del_1_al_100()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            var result = fizzbuzz.Escribir();


            Assert.Equal(1, result.First());
            Assert.Equal(100, result.Last());

            //Assert.Equal(100, result.Count());
            //for (int i = 0; i < 100; i++) {
            //    Assert.Equal(i + 1, result[i]);
            //}
        }
    }

    internal class FizzBuzzGenerator
    {
        internal List<int> Escribir()
        {
            throw new NotImplementedException();
        }
    }
}