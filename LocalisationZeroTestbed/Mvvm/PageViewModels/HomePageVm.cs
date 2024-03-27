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
        public HomePageVm()
        {
            Count = 4;
        }

        internal void Init(string friendlyMessage)
        {

        }
    }
}
