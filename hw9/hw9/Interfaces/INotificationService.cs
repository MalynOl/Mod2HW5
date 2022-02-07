namespace Hw9
{
    public interface INotificationService
    {
        public void WriteMI(StringInstrument[] animalChordals);

        public void WriteMIWithWeight(StringInstrument[] musicalInstruments);

        public void WriteSound(StringInstrument[] musicalInstruments);

        public void WriteText(string text);

        public void WriteNumber(double d);
    }
}
