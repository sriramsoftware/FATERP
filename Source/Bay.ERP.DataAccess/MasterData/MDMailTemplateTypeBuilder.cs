// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Nov-2012, 10:24:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDMailTemplateTypeBuilder : IEntityBuilder<MDMailTemplateTypeEntity>
    {
        IList<MDMailTemplateTypeEntity> IEntityBuilder<MDMailTemplateTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDMailTemplateTypeEntity> MDMailTemplateTypeEntityList = new List<MDMailTemplateTypeEntity>();

            while (reader.Read())
            {
                MDMailTemplateTypeEntityList.Add(((IEntityBuilder<MDMailTemplateTypeEntity>)this).BuildEntity(reader));
            }

            return (MDMailTemplateTypeEntityList.Count > 0) ? MDMailTemplateTypeEntityList : null;
        }

        MDMailTemplateTypeEntity IEntityBuilder<MDMailTemplateTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MAILTEMPLATETYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDMailTemplateTypeEntity mDMailTemplateTypeEntity = new MDMailTemplateTypeEntity();

            mDMailTemplateTypeEntity.MailTemplateTypeID = reader.GetInt64(FLD_MAILTEMPLATETYPEID);
            mDMailTemplateTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDMailTemplateTypeEntity.Description = String.Empty; } else { mDMailTemplateTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDMailTemplateTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDMailTemplateTypeEntity;
        }
    }
}
