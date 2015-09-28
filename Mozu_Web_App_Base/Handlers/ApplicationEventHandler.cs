using Mozu.Api.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mozu_Web_App_Base.Handlers
{
    public class ApplicationEventHandler : IApplicationEvents
    {
        public void Disabled(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task DisabledAsync(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Enabled(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task EnabledAsync(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Installed(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task InstalledAsync(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Uninstalled(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task UninstalledAsync(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Upgraded(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task UpgradedAsync(Mozu.Api.IApiContext apiContext, Mozu.Api.Contracts.Event.Event eventPayLoad)
        {
            Console.WriteLine("Inside the Upgraded Handler");
            return null;
        }
    }
}