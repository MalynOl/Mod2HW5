namespace Hw9
{
    public abstract class PluckedInstrument : StringInstrument // щипковый
    {
        public override string MakeSound()
        {
            return "Я извлекаю звук путем защипывания струн пальцами или упругой пластинкой — медиатором";
        }
    }
}
