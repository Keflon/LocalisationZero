using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalisationZeroTestbed.Mvvm.PageViewModels
{
    public class HomePageVm : BasePageVm
    {
        public int Count { get; }
        public int OtherCount { get; }
        public HomePageVm()
        {
            Count = 4;
            OtherCount = 6;
        }

        internal void Init(string friendlyMessage)
        {

        }
    }
}
