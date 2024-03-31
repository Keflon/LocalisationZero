using LocalisationZeroTestbed.Localisation;
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
        private readonly LocalisationService _lang;

        public int Count { get => _count; set => SetProperty(ref _count, value); }
        public int OtherCount { get; }

        //private string _testString;
        private string _testString;
        public string TestString { get => _testString; set => SetProperty(ref _testString, value); }

        public HomePageVm(LocalisationService lang)
        {
            _lang = lang;

            Count = 4;
            OtherCount = 6;
            TestString = _lang.GetText(LocalisationStrings.E_Bananas, 3, 9);

            AddPageTimer(1000, MyTimerCallback, null, null);
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
