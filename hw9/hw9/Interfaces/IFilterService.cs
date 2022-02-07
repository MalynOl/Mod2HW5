namespace Hw9
{
    public interface IFilterService
    {
        public StringInstrument[] FilterInstruments(StringInstrument[] instruments, bool isKeep, int countStrings);
    }
}
