using NUnit.Framework;
using Web.Business;

namespace Tests
{
    [TestFixture]
    public class ChordLogicTests
    {
        [TestCase('C', 'G', 'E', 'C')]
        [TestCase('F', 'C', 'A', 'F')]
        [TestCase('G', 'D', 'B', 'G')]
        public void ShouldGetChordBasedOnSoprano(char soparano, char alto, char tenor, char bass)
        {
            //Given
            ChordLogic logic = new ChordLogic();

            //When
            var chord = logic.GetChord(soparano);

            //Then
            Assert.That(chord.Soparano,Is.EqualTo(soparano));
            Assert.That(chord.Alto, Is.EqualTo(alto));
            Assert.That(chord.Tenor, Is.EqualTo(tenor));
            Assert.That(chord.Bass, Is.EqualTo(bass));
        }
    }
}
