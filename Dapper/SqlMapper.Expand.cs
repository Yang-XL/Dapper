using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    /// <summary>
    /// SqlMapper 扩展
    /// </summary>
    public partial class SqlMapper
    {
        /// <summary>
        /// YXL:2022-02-11 扩展
        /// </summary>
        /// <param name="provider"></param>
        public static void SetTypeMap(Func<Type, ITypeMap> provider)
        {
            TypeMapProvider = provider;
        }
    }
}
