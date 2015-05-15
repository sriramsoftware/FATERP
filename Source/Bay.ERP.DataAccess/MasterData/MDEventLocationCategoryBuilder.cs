// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEventLocationCategoryBuilder : IEntityBuilder<MDEventLocationCategoryEntity>
    {
        IList<MDEventLocationCategoryEntity> IEntityBuilder<MDEventLocationCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEventLocationCategoryEntity> MDEventLocationCategoryEntityList = new List<MDEventLocationCategoryEntity>();

            while (reader.Read())
            {
                MDEventLocationCategoryEntityList.Add(((IEntityBuilder<MDEventLocationCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDEventLocationCategoryEntityList.Count > 0) ? MDEventLocationCategoryEntityList : null;
        }

        MDEventLocationCategoryEntity IEntityBuilder<MDEventLocationCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTLOCATIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEventLocationCategoryEntity mDEventLocationCategoryEntity = new MDEventLocationCategoryEntity();

            mDEventLocationCategoryEntity.EventLocationCategoryID = reader.GetInt64(FLD_EVENTLOCATIONCATEGORYID);
            mDEventLocationCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEventLocationCategoryEntity.Description = String.Empty; } else { mDEventLocationCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEventLocationCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEventLocationCategoryEntity;
        }
    }
}
