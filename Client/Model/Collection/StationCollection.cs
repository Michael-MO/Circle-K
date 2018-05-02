using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Client.Model.Domain;

namespace Client.Model.Collection
{
    class StationCollection
    {
        private static StationCollection instance;
        private static Dictionary<int, Station> _collection;

        private StationCollection()
        {
            _collection = new Dictionary<int, Station>();
        }

        public static StationCollection Instance
        {
            get
            {
                if (Instance == null)
                {
                    instance = new StationCollection();
                }

                return instance;
            }
        }

        public Dictionary<int, Station> Collection
        {
            get { return _collection; }
        }









    }
}
