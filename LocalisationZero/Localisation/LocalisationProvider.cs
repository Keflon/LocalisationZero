namespace LocalisationZero.Localisation
{
    public class LocalisationProvider
    {
        public LocalisationProvider(Func<LocalisationPack> getLookup, string languageName)
        {
            GetLookup = getLookup;
            LanguageName = languageName;
        }
        //public LocalisationProvider(Func<LocalisationPack> getLookup, string languageName)
        //{
        //    GetLookup = GetLookupFromStringList(getLookup);
        //    LanguageName = languageName;
        //}

        //private Func<LocalisationPack> GetLookupFromStringList(Func<LocalisationPack> getLookup)
        //{
        //    throw new NotImplementedException();
        //}

        public Func<LocalisationPack> GetLookup { get; }
        public string LanguageName { get; }
    }
}
