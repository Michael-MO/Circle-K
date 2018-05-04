using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;
using Client.Configeration.App;




namespace Client.Model.Base
{
    public abstract CatalogAppBase<TDomainData, TViewData, TPersistentData> : RestApiPersistableCatalogAsync<TDomainData, TViewData, TPersistentData>
    where TViewData : class, IStorable, ICopyable, new()
    where TDomainData : class, IStorable
    where TPersistentData : IStorable
    {
    protected CatalogAppBase(string apiID)
        : base(AppConfig.ServerURL, apiID)
    {

    }
    }
}
