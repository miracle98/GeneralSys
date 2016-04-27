using System;
using System.Linq;
using System.Linq.Expressions;

#region Version Info

/* ========================================================================
* 【本接口功能概述】
* 
* 作者：Wendell 时间：2016/4/27 10:12:48
* 文件名：IRepository
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
    ///     仓储接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        T FindSingle(Expression<Func<T, bool>> exp = null);
        bool IsExist(Expression<Func<T, bool>> exp);
        IQueryable<T> Find(Expression<Func<T, bool>> exp = null);

        IQueryable<T> Find(int pageindex = 1, int pagesize = 10, string orderby = "",
            Expression<Func<T, bool>> exp = null);

        int GetCount(Expression<Func<T, bool>> exp = null);

        void Add(T entity);

        void BatchAdd(T[] entities);

        /// <summary>
        ///     更新一个实体的所有属性
        /// </summary>
        void Update(T entity);

        void Delete(T entity);

        /// <summary>
        ///     按指定的ID进行批量更新
        /// </summary>
        void Update(Expression<Func<T, object>> identityExp, T entity);

        /// <summary>
        ///     实现按需要只更新部分更新
        ///     <para>如：Update(u =>u.Id==1,u =>new User{Name="ok"});</para>
        /// </summary>
        /// <param name="where">更新条件</param>
        /// <param name="entity">更新后的实体</param>
        void Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity);

        /// <summary>
        ///     批量删除
        /// </summary>
        void Delete(Expression<Func<T, bool>> exp);

        void Save();
    }
}