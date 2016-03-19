using System;
using System.Collections.Generic;
using DLG.Account.Contract;
using DLG.Core.Cache;
using DLG.Core.Service;
using DLG.Crm.Contract;
using DLG.HR.Contract;

namespace DLG.Web
{
    public class ServiceContext
    {
        public static ServiceContext Current
        {
            get
            {
                return CacheHelper.GetItem<ServiceContext>("ServiceContext", () => new ServiceContext());
            }
        }
        
        public IAccountService AccountService
        {
            get
            {
                return ServiceHelper.CreateService<IAccountService>();
            }
        }
         

        public ICrmService CrmService
        {
            get
            {
                return ServiceHelper.CreateService<ICrmService>();
            }
        }

        public IHRService HRService
        {
            get
            {
                return ServiceHelper.CreateService<IHRService>();
            }
        }
    }
}
