using LocalisationZero.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationZeroTestbed.SampleData
{
    public static class LanguageEN
    {
        /* E_Bananas,   */
        /* E_Hello,     */
        /* E_World,     */
        /* E_Welcome,   */



        public static LocalisationPack GetLocalisationPack()
        {
            var retval = new LocalisationPack(GetLocalisationRecordList());

            return retval;
        }

        private static IList<LocalisationRecord> GetLocalisationRecordList()
        {
            var retval = new List<LocalisationRecord>();

            // E_Bananas ...

            List<LocalisationItem> bananaItems = new List<LocalisationItem>();

            bananaItems.Add(new LocalisationItem("Count == 0", "There are no bananas"));
            bananaItems.Add(new LocalisationItem("Count == 1", "There is one banana"));
            bananaItems.Add(new LocalisationItem("Count <= 5", "There are {Count} bananas, half of {Count*2}. The otherCount is {OtherCount}"));
            bananaItems.Add(new LocalisationItem("True      ", "There are loads of bananas"));

            var bananaLocalisationRecord = new LocalisationRecord(bananaItems, "Count", "OtherCount");

            retval.Add(bananaLocalisationRecord);

            // E_Hello

            List<LocalisationItem> helloItems = new List<LocalisationItem>();
            helloItems.Add(new LocalisationItem("True", "Hello"));
            var helloLocalisationRecord = new LocalisationRecord(helloItems);
            retval.Add(helloLocalisationRecord);

            // E_World

            var worldItems = new List<LocalisationItem>();
            worldItems.Add(new LocalisationItem("True", "World"));
            var worldLocalisationRecord = new LocalisationRecord(worldItems);
            retval.Add(worldLocalisationRecord);

            // E_Welcome

            var welcomeItems = new List<LocalisationItem>();
            welcomeItems.Add(new LocalisationItem("True", "Welcome"));
            var welcomeLocalisationRecord = new LocalisationRecord(welcomeItems);
            retval.Add(welcomeLocalisationRecord);


            return retval;
        }
    }
}
