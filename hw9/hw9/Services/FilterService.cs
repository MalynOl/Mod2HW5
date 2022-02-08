namespace Hw9
{
   public class FilterService : IFilterService
    {
        public StringInstrument[] FilterInstruments(StringInstrument[] instruments, bool isKeep, int countStrings)
        {
            StringInstrument[] filterMusicalInstruments = new StringInstrument[1];

            for (int i = 0; i < instruments.Length; i++)
            {
                if (instruments[i].IsCanKeepInHand == isKeep && instruments[i].CountString < countStrings)
                {
                    if (filterMusicalInstruments.Length == 1 && filterMusicalInstruments[0] == null)
                    {
                        filterMusicalInstruments[0] = instruments[i];
                    }
                    else
                    {
                        filterMusicalInstruments = filterMusicalInstruments.Add(instruments[i]);
                    }
                }
            }

            return filterMusicalInstruments;
        }
    }
}
