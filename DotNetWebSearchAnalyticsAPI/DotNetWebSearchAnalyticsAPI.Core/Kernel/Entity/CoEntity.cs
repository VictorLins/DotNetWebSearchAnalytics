using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DotNetWebSearchAnalyticsAPI.Core.Kernel
{
    public class CoEntity
    {
        #region [ Constructors ]

        public CoEntity() { }

        #endregion

        public virtual Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> lDictionary = new Dictionary<string, string>();

            var lObject = this.GetType();

            lDictionary.Add("CLASS", this.GetType().Name);
            foreach (var propertyInfo in lObject.GetProperties())
                lDictionary.Add(propertyInfo.Name, Convert.ToString(lObject.GetProperty(propertyInfo.Name).GetValue(this, null)));

            return lDictionary;
        }

        public virtual int GetId()
        {
            var prCoEntity = this;
            int lEntityId;

            PropertyInfo lPropertyInfo =
                prCoEntity.GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetCustomAttributes(typeof(KeyAttribute), true).Length != 0);

            lEntityId = lPropertyInfo != null ? Convert.ToInt32(lPropertyInfo.GetValue(prCoEntity, null)) : 0;

            return lEntityId;
        }

        public string GetEntityTypeName()
        {
            return this.GetType().Name;
        }
    }
}