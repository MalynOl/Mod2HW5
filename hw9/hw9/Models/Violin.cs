namespace Hw9
{
    public class Violin : BowedInstrument
    {
        private string _violinBow;

        public Violin(string name, SourceSound sourceSound, int countString, string violinBow, bool isCanKeepInHand, double weight, double price)
        {
            Name = name;
            SoundSource = sourceSound;
            CountString = countString;
            IsCanKeepInHand = isCanKeepInHand;
            Weight = weight;
            Price = price;

            _violinBow = violinBow;
        }

        public string ViolinBow
        {
            get
            {
                return _violinBow;
            }
            set
            {
                _violinBow = value;
            }
        }

        public override string MakeSound()
        {
            return base.MakeSound();
        }
    }
}
