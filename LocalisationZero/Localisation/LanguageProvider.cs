namespace LocalisationZero.Localisation
{
    public class LanguageProvider
    {
        public LanguageProvider(Func<LocalisationPack> getLookup, string languageName)
        {
            GetLookup = getLookup;
            LanguageName = languageName;
        }
        //public LanguageProvider(Func<IEnumerable<string>> getLookup, string languageName)
        //{
        //    GetLookup = GetLookupFromStringList(getLookup);
        //    LanguageName = languageName;
        //}

        //private Func<LocalisationPack> GetLookupFromStringList(Func<IEnumerable<string>> getLookup)
        //{
        //    throw new NotImplementedException();
        //}

        public Func<LocalisationPack> GetLookup { get; }
        public string LanguageName { get; }
    }
}
