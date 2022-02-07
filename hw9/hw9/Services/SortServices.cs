namespace Hw9
{
    public class SortServices : ISortService
    {
        public StringInstrument[] SortByWeight(StringInstrument[] instruments)
        {
            for (int i = 0; i < instruments.Length - 1; i++)
            {
                for (int j = i + 1; j < instruments.Length; j++)
                {
                    if (instruments[i].Weight > instruments[j].Weight)
                    {
                        var temp = instruments[i];
                        instruments[i] = instruments[j];
                        instruments[j] = temp;
                    }
                }
            }

            return instruments;
        }
    }
}
