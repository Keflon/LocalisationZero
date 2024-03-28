using SampleApp.Translations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationZeroTestbed.Mvvm.PageViewModels
{
    public class HomePageVm : BasePageVm
    {
        private int _count;
        public int Count { get => _count; set => SetProperty(ref _count, value); }
        public int OtherCount { get; }

        //private string _testString;
        public LangString TestString { get; }

        public HomePageVm(Localisation loc)
        {
            Count = 4;
            OtherCount = 6;

            AddPageTimer(1000, MyTimerCallback, null, null);

            // LangString = loc.Create(E_Bananas, args somehow.
        }

        private void MyTimerCallback(object obj)
        {
            Count = (Count == 0) ? 4 : 0;
        }

        internal void Init(string friendlyMessage)
        {

        }
    }
}
