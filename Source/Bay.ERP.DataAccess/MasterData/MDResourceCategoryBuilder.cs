// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDResourceCategoryBuilder : IEntityBuilder<MDResourceCategoryEntity>
    {
        IList<MDResourceCategoryEntity> IEntityBuilder<MDResourceCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDResourceCategoryEntity> MDResourceCategoryEntityList = new List<MDResourceCategoryEntity>();

            while (reader.Read())
            {
                MDResourceCategoryEntityList.Add(((IEntityBuilder<MDResourceCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDResourceCategoryEntityList.Count > 0) ? MDResourceCategoryEntityList : null;
        }

        MDResourceCategoryEntity IEntityBuilder<MDResourceCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDResourceCategoryEntity mDResourceCategoryEntity = new MDResourceCategoryEntity();

            mDResourceCategoryEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            mDResourceCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDResourceCategoryEntity.Description = String.Empty; } else { mDResourceCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDResourceCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDResourceCategoryEntity;
        }
    }
}
