using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Version Info
/* ========================================================================
* 【本接口功能概述】
* 
* 作者：Wendell 时间：2016/4/27 10:29:32
* 文件名：IUserRepository
* 版本：V1.0.1
*
* 修改者： 时间： 
* 修改说明：
* ========================================================================
*/
#endregion
namespace GeneralSys.Domain.Interface
{
    /// <summary>
    /// 用户仓储接口
    /// </summary>
    public interface IUserRepository:IRepository<User>
    {
    }
}
