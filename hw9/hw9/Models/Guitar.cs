namespace Hw9
{
    public class Guitar : PluckedInstrument
    {
        private string _soundboard;

        public Guitar(string name, SourceSound sourceSound, int countString, string soundboard, bool isCanKeepInHand, double weight, double price)
        {
            Name = name;
            SoundSource = sourceSound;
            CountString = countString;
            IsCanKeepInHand = isCanKeepInHand;
            Weight = weight;
            Price = price;

            _soundboard = soundboard;
        }

        public string Soundboard
        {
            get
            {
                return _soundboard;
            }
            set
            {
                _soundboard = value;
            }
        }

        public override string MakeSound()
        {
            return base.MakeSound();
        }
    }
}
