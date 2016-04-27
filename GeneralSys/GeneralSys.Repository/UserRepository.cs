using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralSys.Domain;
using GeneralSys.Domain.Interface;

namespace GeneralSys.Repository
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
    }
}
