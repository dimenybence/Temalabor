namespace Tesztek
{
    public class Tests
    {
        [Fact]
        public void FirstCharTest()
        {
            string input = "alma k�rte";
            string expected = "lma �rte";
            string result = Stringatalakitas.Program.FirstCharacterRemove(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void LastCharTest()
        {
            string input = "alma k�rte";
            string expected = "alm k�rt";
            string result = Stringatalakitas.Program.LastCharacterRemove(input);
            Assert.Equal(expected, result);
        }
    }
}