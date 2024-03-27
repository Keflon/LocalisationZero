using LocalisationZero.MarkupExtensions;
using SampleApp.Translations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationZeroTestbed.Localisation
{
    public class LangExtension : BaseLanguageExtension<LangStrings>
    {
        public LangExtension() : base("languageResource")
        {

        }
    }
}
