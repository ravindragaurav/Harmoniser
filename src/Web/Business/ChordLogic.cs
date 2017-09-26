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
                chord.Alto = 'G';
                chord.Tenor = 'E';
                chord.Bass = 'C';
            }
            else if (soprano.Equals('F'))
            {
                chord.Soparano = soprano;
                chord.Alto = 'C';
                chord.Tenor = 'A';
                chord.Bass = 'F';
            }
            else if (soprano.Equals('G'))
            {
                chord.Soparano = soprano;
                chord.Alto = 'D';
                chord.Tenor = 'B';
                chord.Bass = 'G';
            }
            return chord;
        }

    }
}
