namespace Hw9
{
    public abstract class StringInstrument : MusicalInstrument, IMakeSound
    {
        private int _countString;
        private double _lengthString;

        public StringInstrument()
        {
            SoundSource = SourceSound.String;
        }

        public int CountString
        {
            get
            {
                return _countString;
            }
            set
            {
                _countString = value;
            }
        }

        public double LengthString
        {
            get
            {
                return _lengthString;
            }
            set
            {
                _lengthString = value;
            }
        }

        public virtual string MakeSound()
        {
            return "I can extract sound with strings";
        }
    }
}
