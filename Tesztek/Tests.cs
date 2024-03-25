namespace Tesztek
{
    public class Tests
    {
        [Fact]
        public void FirstCharTest()
        {
            string input = "alma k�rte barack";
            string expected = "lma �rte arack";
            string result = Stringatalakitas.Program.FirstCharacterRemove(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void LastCharTest()
        {
            string input = "alma k�rte barack";
            string expected = "alm k�rt barac";
            string result = Stringatalakitas.Program.LastCharacterRemove(input);
            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void WrongCharTest()
        //{
        //    string input = "alma k�rte barack";
        //    string expected = "alm k�rt barac";
        //    string result = Stringatalakitas.Program.FirstCharacterRemove(input);
        //    Assert.Equal(expected, result);
        //}
    }
}