namespace Hw9
{
    public abstract class MusicalInstrument
    {
        public bool IsCanKeepInHand { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public SourceSound SoundSource { get; set; }
    }
}
