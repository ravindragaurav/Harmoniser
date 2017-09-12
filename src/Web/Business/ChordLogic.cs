using Web.Models;

namespace Web.Business
{
    public class ChordLogic
    {
        public ChordLogic()
        {

        }

        public Chord GetChord(char soprano)
        {
            var chord = new Chord();
            if(soprano.Equals('C'))
            {
                chord.Soparano = soprano;
                chord.Alto = 'E';
                chord.Tenor = 'G';
                chord.Bass = 'C';
            }
            return chord;
        }

    }
}
