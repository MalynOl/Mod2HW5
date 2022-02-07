namespace Hw9
{
    public static class ExtensionMethods
    {
        public static T[] FindAnimalByAge<T>(this T[] array, SourceSound sourceSound)
            where T : MusicalInstrument
        {
            var newArray = new T[1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].SoundSource == sourceSound)
                {
                    if (newArray.Length == 1 && newArray[0] == null)
                    {
                        newArray[0] = array[i];
                    }
                    else
                    {
                        newArray = newArray.Add(array[i]);
                    }
                }
            }

            return newArray;
        }

        public static T[] Add<T>(this T[] oldArray, T addItem)
            where T : MusicalInstrument
        {
            T[] newArray = new T[oldArray.Length + 1];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }

            newArray[oldArray.Length] = addItem;

            return newArray;
        }
    }
}
