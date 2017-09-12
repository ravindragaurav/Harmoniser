using Web.Business;
using Xunit;

namespace Tests.Business
{
    public class ChordLogicTests
    {
        [Fact]
        public void shouldGetChordBasedOnSoprano()
        {
            //Given
            ChordLogic logic = new ChordLogic();

            //When
            var chord = logic.GetChord('C');

            //Then
            Assert.Equal(chord.Soparano, 'C');
            Assert.Equal(chord.Alto, 'E');
            Assert.Equal(chord.Tenor, 'G');
            Assert.Equal(chord.Bass, 'C');
        }

    }
}
