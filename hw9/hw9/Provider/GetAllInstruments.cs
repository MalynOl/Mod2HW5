namespace Hw9
{
    public class GetAllInstruments : IGetInstruments
    {
        public StringInstrument[] GetInstruments()
        {
            Guitar guitar1 = new Guitar(
                name: "Guitar",
                sourceSound: SourceSound.String,
                countString: 5,
                soundboard: "Контур деки украшают окантовкой",
                isCanKeepInHand: true,
                weight: 1.3,
                price: 1500.5);

            Guitar guitar2 = new Guitar(
               name: "Guitar",
               sourceSound: SourceSound.String,
               countString: 7,
               soundboard: "Приклеенный порожек",
               isCanKeepInHand: true,
               weight: 3.5,
               price: 1270.5);

            Mandoline mandoline1 = new Mandoline(
              name: "Mandoline",
              sourceSound: SourceSound.String,
              countString: 4,
              type: "овальная",
              isCanKeepInHand: true,
              weight: 1.5,
              price: 620.5);

            Piano piano1 = new Piano(
                 name: "Piano",
                 sourceSound: SourceSound.String,
                 countString: 230,
                 verticalBody: "механизмами расположен вертикально",
                 isCanKeepInHand: false,
                 weight: 200,
                 price: 100520.5);

            Piano piano2 = new Piano(
                name: "Piano grand",
                sourceSound: SourceSound.String,
                countString: 350,
                verticalBody: "механизмами расположен горизонтально",
                isCanKeepInHand: false,
                weight: 380,
                price: 370520.5);

            Violin violin1 = new Violin(
                 name: "Violin",
                 sourceSound: SourceSound.String,
                 countString: 4,
                 violinBow: "трость из березы",
                 isCanKeepInHand: true,
                 weight: 0.5,
                 price: 12570.5);

            Violin violin2 = new Violin(
                name: "Violin",
                sourceSound: SourceSound.String,
                countString: 4,
                violinBow: "трость из клена",
                isCanKeepInHand: true,
                weight: 0.6,
                price: 1570.5);

            StringInstrument[] musicalInstruments = new StringInstrument[]
            {
                guitar1, guitar2, mandoline1, piano1, piano2, violin1, violin2
            };

            return musicalInstruments;
        }
    }
}
