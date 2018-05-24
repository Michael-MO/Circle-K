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

        private DomainModel()
        {
            _employeeCatalog = new EmployeeCatalog();
            //_stationCatalog = new StationCatalog();
        }

        public EmployeeCatalog Employees
        {
            get { return _employeeCatalog; }
        }

        //public StationCatalog Stations
        //{
        //    get { return _stationCatalog; }
        //}

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
    }
}
