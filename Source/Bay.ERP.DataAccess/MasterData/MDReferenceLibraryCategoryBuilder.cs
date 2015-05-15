// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDReferenceLibraryCategoryBuilder : IEntityBuilder<MDReferenceLibraryCategoryEntity>
    {
        IList<MDReferenceLibraryCategoryEntity> IEntityBuilder<MDReferenceLibraryCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDReferenceLibraryCategoryEntity> MDReferenceLibraryCategoryEntityList = new List<MDReferenceLibraryCategoryEntity>();

            while (reader.Read())
            {
                MDReferenceLibraryCategoryEntityList.Add(((IEntityBuilder<MDReferenceLibraryCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDReferenceLibraryCategoryEntityList.Count > 0) ? MDReferenceLibraryCategoryEntityList : null;
        }

        MDReferenceLibraryCategoryEntity IEntityBuilder<MDReferenceLibraryCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REFERENCELIBRARYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDReferenceLibraryCategoryEntity mDReferenceLibraryCategoryEntity = new MDReferenceLibraryCategoryEntity();

            mDReferenceLibraryCategoryEntity.ReferenceLibraryCategoryID = reader.GetInt64(FLD_REFERENCELIBRARYCATEGORYID);
            mDReferenceLibraryCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDReferenceLibraryCategoryEntity.Description = String.Empty; } else { mDReferenceLibraryCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDReferenceLibraryCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDReferenceLibraryCategoryEntity;
        }
    }
}
