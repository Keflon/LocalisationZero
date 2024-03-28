namespace LocalisationZero.Localisation
{
    public class LocalisationProvider
    {
        public LocalisationProvider(Func<LocalisationPack> getLookup, string languageName)
        {
            GetLookup = getLookup;
            LanguageName = languageName;
        }
        public LocalisationProvider(Func<IEnumerable<string>> getLookup, string languageName)
        {
            GetLookup = ()=> GetLocalisationPackFromStringList(getLookup);
            LanguageName = languageName;
        }

        private LocalisationPack GetLocalisationPackFromStringList(Func<IEnumerable<string>> getLookup)
        {
            // LocalisationPack
            //    LocalisationRecord
            //        LocalisationItem

            var localisationItemList = new List<LocalisationItem>();

            foreach (var localString in getLookup())
                localisationItemList.Add(new LocalisationItem("True", localString));

            var recordList = new List<LocalisationRecord> { new LocalisationRecord(localisationItemList) };

            return new LocalisationPack(recordList);
        }

        public Func<LocalisationPack> GetLookup { get; }
        public string LanguageName { get; }
    }
}
