using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Dapper.Expand.Tests
{
    internal class ColumnAttributeTypeMapper : DefaultTypeMap
    {
        private readonly IEnumerable<ITableFiled> Fileds;
        public ColumnAttributeTypeMapper(Type t) : base(t)
        {
            Fileds = CreateFiles(t);
        }

        public override IMemberMap GetMember(string columnName)
        {
            var file = Fileds.FirstOrDefault(a => string.Equals(columnName, a.Name));
            if (file == null)
            {
                return base.GetMember(columnName);
            }
            return new SimpleMemberMap(columnName, file.MetaData);
        }

        public IEnumerable<ITableFiled> CreateFiles(Type objectType)
        {
            //if (_metaDataFiledsCache.TryGetValue(objectType, out var cachedEntry))
            //    return cachedEntry;

            //var props = objectType.GetProperties();
            //var propertyInfos = props
            //    .OrderByDescending(x => x.GetCustomAttribute<KeyAttribute>() != null)
            //    .ThenBy(p => p.GetCustomAttributes<ColumnAttribute>()
            //        .Select(a => a.Order)
            //        .DefaultIfEmpty(int.MaxValue)
            //        .FirstOrDefault()).Where(ExpressionHelper.GetPrimitivePropertiesPredicate())
            //    .Where(p => !p.GetCustomAttributes<NotMappedAttribute>().Any())
            //    .Where(igs => !igs.GetCustomAttributes<IgnoreAttribute>().Any(ig => ig.Ignore == Enum.IgnoreEnum.All))
            //    .Select(p => p.CreateFiled(objectType)).ToList();
            //_metaDataFiledsCache.TryAdd(objectType, propertyInfos);
            return new List<ITableFiled>();
        }
    }
}
