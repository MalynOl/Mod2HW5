using System;

namespace Hw9
{
    public class NotificationService : INotificationService
    {
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteNumber(double d)
        {
            Console.WriteLine(d.ToString());
        }

        public void WriteMI(StringInstrument[] musicalInstruments)
        {
            for (int i = 0; i < musicalInstruments.Length; i++)
            {
                Console.WriteLine($"Musical instrument {musicalInstruments[i].Name}, count of string: {musicalInstruments[i].CountString}, price: {musicalInstruments[i].Price}, source sound: {musicalInstruments[i].SoundSource}");
            }

            Console.WriteLine();
        }

        public void WriteMIWithWeight(StringInstrument[] musicalInstruments)
        {
            for (int i = 0; i < musicalInstruments.Length; i++)
            {
                Console.WriteLine($"Musical instrument {musicalInstruments[i].Name}, weight: {musicalInstruments[i].Weight}.");
            }

            Console.WriteLine();
        }

        public void WriteSound(StringInstrument[] musicalInstruments)
        {
            for (int i = 0; i < musicalInstruments.Length; i++)
            {
                Console.WriteLine($"Musical instrument {musicalInstruments[i].Name}. {musicalInstruments[i].MakeSound()}");
            }

            Console.WriteLine();
        }
    }
}
