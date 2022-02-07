namespace Hw9
{
    public class Starter
    {
        private readonly INotificationService _notificationService;
        private readonly IGetInstruments _getInstruments;
        private readonly IFilterService _filterService;
        private readonly ISortService _sortService;
        private readonly ICountService _countService;

        public Starter(INotificationService notificationService, IGetInstruments getInstruments, IFilterService filterService, ISortService sortService, ICountService countService)
        {
            _notificationService = notificationService;
            _getInstruments = getInstruments;
            _filterService = filterService;
            _sortService = sortService;
            _countService = countService;
        }

        public void Start()
        {
            _notificationService.WriteText("How to make sound: ");
            StringInstrument[] allInstruments = _getInstruments.GetInstruments();
            _notificationService.WriteSound(allInstruments);

            _notificationService.WriteText("Musical instruments which can keep in hands and have string less 6: ");
            var instrumentsWithLessSixString = _filterService.FilterInstruments(allInstruments, true, 6);
            _notificationService.WriteMI(instrumentsWithLessSixString);

            _notificationService.WriteText("Sort by weight: ");
            var sortInstruments = _sortService.SortByWeight(instrumentsWithLessSixString);
            _notificationService.WriteMIWithWeight(sortInstruments);

            _notificationService.WriteText("Total cost: ");
            var totalCost = _countService.CountMoney(sortInstruments);
            _notificationService.WriteNumber(totalCost);
        }
    }
}
