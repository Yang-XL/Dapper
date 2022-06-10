using System.Reflection;

namespace Dapper.Expand.Tests
{
    internal interface ITableFiled
    {
        /// <summary>
        /// 函数列
        ///  例如Top(1)
        /// </summary>
        bool FunctionColumn { get; set; }
        /// <summary>
        /// 元数据
        /// </summary>
        PropertyInfo MetaData { get; }

        /// <summary>
        /// 列名
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 别名
        /// </summary>
        string Alias { get; set; }

        /// <summary>
        /// 忽略更新
        /// </summary>
        bool IgnoreUpdate { get; }
        /// <summary>
        /// 忽略插入
        /// </summary>
        bool IgnoreInsert { get; }
        /// <summary>
        /// 忽略查询
        /// </summary>
        bool IgnoreSelect { get; }
        /// <summary>
        /// 主键列
        /// </summary>
        bool Key { get; }
        /// <summary>
        /// 更新时间列
        /// </summary>
        bool UpdatedAt { get; }
        /// <summary>
        /// 创建时间列
        /// </summary>
        bool CreateAt { get; }

        /// <summary>
        /// 
        /// </summary>
        bool LogicalDelete { get; }
        /// <summary>
        /// 
        /// </summary>
        bool TenantId { get; set; }

    }
}
