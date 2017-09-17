using NUnit.Framework;
using Web.Business;

namespace Tests
{
    [TestFixture]
    public class ChordLogicTests
    {
        [Test]
        public void ShouldGetChordBasedOnSoprano()
        {
            //Given
            ChordLogic logic = new ChordLogic();

            //When
            var chord = logic.GetChord('C');

            //Then
            Assert.That(chord.Soparano,Is.EqualTo( 'C'));
            Assert.That(chord.Alto, Is.EqualTo('E'));
            Assert.That(chord.Tenor, Is.EqualTo('G'));
            Assert.That(chord.Bass, Is.EqualTo('C'));
        }
    }
}
