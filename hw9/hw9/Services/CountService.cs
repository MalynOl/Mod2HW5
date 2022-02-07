namespace Hw9
{
    public class CountService : ICountService
    {
        private readonly INotificationService _notificationService;

        public CountService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public double CountMoney(StringInstrument[] instruments)
        {
            double fullPrice = 0;
            try
            {
                for (int i = 0; i < instruments.Length; i++)
                {
                    fullPrice += instruments[i].Price;
                }

                if (fullPrice < 0)
                {
                    throw new BusinessException("Price must be more 0");
                }
            }
            catch (BusinessException b)
            {
                _notificationService.WriteText(b.ExceptionText);
            }

            return fullPrice;
        }
    }
}
