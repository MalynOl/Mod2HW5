namespace Hw9
{
   public class Piano : PercussionKeyboards
    {
        private string _typeBody;

        public Piano(string name, SourceSound sourceSound, int countString, string verticalBody, bool isCanKeepInHand, double weight, double price)
        {
            Name = name;
            SoundSource = sourceSound;
            CountString = countString;
            IsCanKeepInHand = isCanKeepInHand;
            Weight = weight;
            Price = price;

            _typeBody = verticalBody;
        }

        public string TypeBody
        {
            get
            {
                return _typeBody;
            }
            set
            {
                _typeBody = value;
            }
        }

        public override string MakeSound()
        {
            return base.MakeSound();
        }
    }
}
