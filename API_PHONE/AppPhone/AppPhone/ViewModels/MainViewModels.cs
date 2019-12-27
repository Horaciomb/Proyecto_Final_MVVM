

namespace AppPhone.ViewModels
{
    using AppPhone.Models;
    using System.Collections.Generic;
    public class MainViewModel
    {
        #region Properties

        public List<AppModel> ListAppModel{ get; set; }
        #endregion



        #region Singleton 
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }

        #endregion

    }

}
