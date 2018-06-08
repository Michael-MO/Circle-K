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
        private StationCatalog _stationCatalog;
        private CityCatalog _cityCatalog;
        private EmployeeStationCatalog _employeeStationCatalog;

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

        public StationCatalog Stations
        {
            get { return _stationCatalog; }
        }

        public CityCatalog Cities
        {
            get { return _cityCatalog; }
        }

        public EmployeeStationCatalog EmployeesStations
        {
            get { return _employeeStationCatalog; }
        }

        public async void LoadModel()
        {
            LoadBegins?.Invoke();

            await Employees.LoadAsync();
            await Cities.LoadAsync();
            await Stations.LoadAsync();
            await EmployeesStations.LoadAsync();

            // For hvert objekt i kataloget 'Employees', gør det følgende:
            foreach (var emp in Employees.All)
            {
                // For hvert objekt i kataloget 'Employees', kør listen af 'Cities' igennem.
                foreach (var city in Cities.All)
                {
                    // Hvis, postalCode propertien i 'Employee' er ens med en by's 'Key/postalCode', gør følgende:
                    if(city.Key == emp.PostalCode)
                    {
                        // Sæt 'Employee' propertien 'City' som en direkte reference til det bestemte 'City' objekt.
                        emp.City = city;
                        // Opdater det originale domæne objekt.
                        Employees.Update(emp, emp.Key);
                    }
                    // Fortsæt til næste 'Employee'
                }
            }

            foreach (var stat in Stations.All)
            {
                foreach (var city in Cities.All)
                {
                    if (city.Key == stat.PostalCode)
                    {
                        stat.City = city;
                        Stations.Update(stat, stat.Key);
                    }
                }
            }

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
