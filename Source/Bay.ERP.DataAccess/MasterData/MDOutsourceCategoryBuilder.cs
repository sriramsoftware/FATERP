// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDOutsourceCategoryBuilder : IEntityBuilder<MDOutsourceCategoryEntity>
    {
        IList<MDOutsourceCategoryEntity> IEntityBuilder<MDOutsourceCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDOutsourceCategoryEntity> MDOutsourceCategoryEntityList = new List<MDOutsourceCategoryEntity>();

            while (reader.Read())
            {
                MDOutsourceCategoryEntityList.Add(((IEntityBuilder<MDOutsourceCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDOutsourceCategoryEntityList.Count > 0) ? MDOutsourceCategoryEntityList : null;
        }

        MDOutsourceCategoryEntity IEntityBuilder<MDOutsourceCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OUTSOURCECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDOutsourceCategoryEntity mDOutsourceCategoryEntity = new MDOutsourceCategoryEntity();

            mDOutsourceCategoryEntity.OutsourceCategoryID = reader.GetInt64(FLD_OUTSOURCECATEGORYID);
            mDOutsourceCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDOutsourceCategoryEntity.Description = String.Empty; } else { mDOutsourceCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDOutsourceCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDOutsourceCategoryEntity;
        }
    }
}
