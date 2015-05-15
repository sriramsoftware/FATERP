// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 02:53:23




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDLeaveCategoryBuilder : IEntityBuilder<MDLeaveCategoryEntity>
    {
        IList<MDLeaveCategoryEntity> IEntityBuilder<MDLeaveCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDLeaveCategoryEntity> MDLeaveCategoryEntityList = new List<MDLeaveCategoryEntity>();

            while (reader.Read())
            {
                MDLeaveCategoryEntityList.Add(((IEntityBuilder<MDLeaveCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDLeaveCategoryEntityList.Count > 0) ? MDLeaveCategoryEntityList : null;
        }

        MDLeaveCategoryEntity IEntityBuilder<MDLeaveCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LEAVECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDLeaveCategoryEntity mDLeaveCategoryEntity = new MDLeaveCategoryEntity();

            mDLeaveCategoryEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID);
            mDLeaveCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDLeaveCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDLeaveCategoryEntity;
        }
    }
}
