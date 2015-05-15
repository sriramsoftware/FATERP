using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Bay.ERP.Common.BusinessEntities
{
    [Serializable()]
    public abstract class BaseEntity : ICloneable
    {
        [XmlIgnore()]
        public virtual bool IsNew
        {
            [DebuggerStepThrough()]
            get
            {
                return true;
            }
        }

        protected BaseEntity()
        {
            
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public Int32 TotalRowCount = 0;

        public virtual BaseEntity Clone()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, this);

                ms.Seek(0, SeekOrigin.Begin);

                return (new BinaryFormatter()).Deserialize(ms) as BaseEntity;
            }
        }
    }
}