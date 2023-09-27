using CsvHelper.Configuration;
using MedifoxDan.PizzaOnline.Persistence.Csv.DataModel;

namespace MedifoxDan.PizzaOnline.Persistence.Csv
{
    public sealed class PizzaSorteMap : ClassMap<PizzaSorteModel>
    {
        public PizzaSorteMap()
        {
            Map(x => x.Nummer);
            Map(x => x.Bezeichnung);
            //Map(x => x.Bild).TypeConverter<ByteArrayConverter>();
        }
    }
}