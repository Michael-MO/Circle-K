using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Data.InMemory.Interfaces;
using Data.Transformed.Interfaces;
using Extensions.Commands.Interfaces;
using Extensions.ViewModel.Implementation;
using Model.Interfaces;

namespace Client.ViewModel.Base
{
    public abstract class PageViewModelAppBase<TViewData> : PageViewModelCRUD<TViewData>
        where TViewData : class, ICopyable, IStorable, new()
    {
        private Dictionary<string, FontWeight> _menuFontWeights;
        public static IDataWrapper<TViewData> ItemSelectedInstance;

        protected PageViewModelAppBase(ICatalog<TViewData> catalog, List<string> immutablecontrols,
            List<string> mutablecontrols)
            : base(catalog, immutablecontrols, mutablecontrols)
        {
            _menuFontWeights = new Dictionary<string, FontWeight>();
            UpdateFontWeights();

            ViewStateService.ViewStateChanged += s =>
            {
                UpdateFontWeights();
                OnPropertyChanged(nameof(MenuFontWeights));
                
            };
        }

        public Dictionary<string, FontWeight> MenuFontWeights
        {
            get { return _menuFontWeights; }
        }

        public void UpdateFontWeights()
        {
            _menuFontWeights.Clear();

            _menuFontWeights.Add("CreateMenuItem", ViewStateService.ViewState == CRUDStates.CreateState ? FontWeights.Bold : FontWeights.Normal);
            _menuFontWeights.Add("ReadMenuItem", ViewStateService.ViewState == CRUDStates.ReadState ? FontWeights.Bold : FontWeights.Normal);
            _menuFontWeights.Add("UpdateMenuItem", ViewStateService.ViewState == CRUDStates.UpdateState ? FontWeights.Bold : FontWeights.Normal);
            _menuFontWeights.Add("DeleteMenuItem", ViewStateService.ViewState == CRUDStates.DeleteState ? FontWeights.Bold : FontWeights.Normal);
        }

        public override IDataWrapper<TViewData> ItemSelected
        {
            get { return base.ItemSelected; }

            set
            {   
                base.ItemSelected = value;
                ItemSelectedInstance = base.ItemSelected;
            }
        }
    }
}
