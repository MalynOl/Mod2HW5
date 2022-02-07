namespace Hw9
{
    public class Mandoline : PluckedInstrument
    {
        private string _typrOfMandoline;
        public Mandoline(string name, SourceSound sourceSound, int countString, string type, bool isCanKeepInHand, double weight, double price)
        {
            Name = name;
            SoundSource = sourceSound;
            CountString = countString;
            IsCanKeepInHand = isCanKeepInHand;
            Weight = weight;
            Price = price;

            _typrOfMandoline = type;
        }

        public string TypeOfMandoline
        {
            get
            {
                return _typrOfMandoline;
            }
            set
            {
                _typrOfMandoline = value;
            }
        }

        public override string MakeSound()
        {
            return base.MakeSound();
        }
    }
}
