using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GeneralSys.App.ViewModel;
using GeneralSys.Domain;
using GeneralSys.Domain.Interface;

namespace GeneralSys.App
{
    public class SysResourceManagerApp
    {
        private readonly ISysResourceRepository _sysResourceRepository;

        public SysResourceManagerApp(ISysResourceRepository sysResourceRepository)
        {
            _sysResourceRepository = sysResourceRepository;
        }

        public dynamic GetAllResource(int pageCurrent = 1, int pageSize = 30)
        {
            var resource = _sysResourceRepository.Find(pageCurrent, pageSize,"", t=>t.IsActive).AsEnumerable().Select(t=>new SysResourceVm
            {
                Id = t.Id,
                Name = t.Name,
                Url = t.Url,
                Icon = t.Icon,
                ParentId = t.ParentId,
                Description = t.Description
            });
            var count = _sysResourceRepository.GetCount(t => t.IsActive);
            return new
            {
                list=resource,
                total=count,
                pageCurrent=pageCurrent
            };
        }
    }
}
