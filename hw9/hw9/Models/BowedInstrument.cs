namespace Hw9
{
    public abstract class BowedInstrument : StringInstrument // смычковые
    {
        public override string MakeSound()
        {
            return "Я извлекаю звук при трении волоса смычка о струны";
        }
    }
}
