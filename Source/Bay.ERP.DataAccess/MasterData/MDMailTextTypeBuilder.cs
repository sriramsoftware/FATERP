// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDMailTextTypeBuilder : IEntityBuilder<MDMailTextTypeEntity>
    {
        IList<MDMailTextTypeEntity> IEntityBuilder<MDMailTextTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDMailTextTypeEntity> MDMailTextTypeEntityList = new List<MDMailTextTypeEntity>();

            while (reader.Read())
            {
                MDMailTextTypeEntityList.Add(((IEntityBuilder<MDMailTextTypeEntity>)this).BuildEntity(reader));
            }

            return (MDMailTextTypeEntityList.Count > 0) ? MDMailTextTypeEntityList : null;
        }

        MDMailTextTypeEntity IEntityBuilder<MDMailTextTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MAILTEXTTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDMailTextTypeEntity mDMailTextTypeEntity = new MDMailTextTypeEntity();

            mDMailTextTypeEntity.MailTextTypeID = reader.GetInt64(FLD_MAILTEXTTYPEID);
            mDMailTextTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDMailTextTypeEntity.Description = String.Empty; } else { mDMailTextTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDMailTextTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDMailTextTypeEntity;
        }
    }
}
