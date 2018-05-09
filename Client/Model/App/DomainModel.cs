using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Catalog;

namespace Client.Model.App
{
    public class DomainModel
    {
        private EmployeeCatalog _employeeCatalog;
       //private StationCatalog _stationCatalog;


        public event Action LoadBegins;
        public event Action LoadEnds;
        public event Action SaveBegins;
        public event Action SaveEnd;

        #region Singleton implementation

        private static DomainModel _instance;

        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }

        public static DomainModel Catalogs
        {
            get { return Instance; }
        }

        #endregion

        #region Constructor

        private DomainModel()
        {
            _employeeCatalog = new EmployeeCatalog();
            //_stationCatalog = new StationCatalog();
        }

        #endregion


        #region Properties

        public EmployeeCatalog Employees
        {
            get { return _employeeCatalog; }
        }

        //public StationCatalog Stations
        //{
        //    get { return _stationCatalog; }
        //}


        #endregion


        #region Persistency methods

        public async void LoadModel()
        {
            LoadBegins?.Invoke();

            await _employeeCatalog.LoadAsync();
            //await _stationCatalog.LoadAsync();

            LoadEnds?.Invoke();
        }


        public async void SaveModel()
        {
            SaveBegins?.Invoke();

            await _employeeCatalog.SaveAsync();
            //await _stationCatalog.SaveAsync();

            SaveEnd?.Invoke();
        }
        #endregion

    }
}
