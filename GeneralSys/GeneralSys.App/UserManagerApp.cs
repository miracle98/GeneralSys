using System.Collections.Generic;
using GeneralSys.Domain;
using GeneralSys.Domain.Interface;

namespace GeneralSys.App
{
    public class UserManagerApp
    {
        private readonly IUserRepository _repository;

        public UserManagerApp(IUserRepository repository)
        {
            _repository = repository;
        }

        public dynamic LoadUser(int pageindex, int pagesize, int orgId = 0)
        {
            if (pageindex < 1) pageindex = 1;
            IEnumerable<User> users = null;
            var total = 0;
            if (orgId == 0)
            {
                users = _repository.Find(pageindex, pagesize);
                total = _repository.GetCount();
            }

            return new
            {
                total,
                list = users,
                pageCurrent = pageindex
            };
        }
    }
}