using System;
using System.Collections.Generic;
using System.Text;

namespace AppPhone.Interface
{
    using ViewModels;
    public class InstanceLocator
    {
        #region Properties
        public MainViewModels Main { get; set; }
        #endregion        

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModels();
        }
        #endregion
    }

}
