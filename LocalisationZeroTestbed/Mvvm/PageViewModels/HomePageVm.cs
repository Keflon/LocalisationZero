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
        public HomePageVm()
        {
            Count = 4;
            OtherCount = 6;

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
