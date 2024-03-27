namespace LocalisationZero.Localisation
{
    public class LocalisatiobChangedEventArgs : EventArgs
    {
        public LocalisatiobChangedEventArgs(string languageId)
        {
            LanguageId = languageId;
        }

        public string LanguageId { get; }
    }
}