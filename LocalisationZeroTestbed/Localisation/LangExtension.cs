using LocalisationZero.MarkupExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationZeroTestbed.Localisation
{
    public class LangExtension : BaseLocalisationExtension<LocalisationStrings>
    {
        public LangExtension() : base("languageResource")
        {

        }
    }
}
