// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDMDRepeatCategoryBuilder : IEntityBuilder<BDMDRepeatCategoryEntity>
    {
        IList<BDMDRepeatCategoryEntity> IEntityBuilder<BDMDRepeatCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDRepeatCategoryEntity> BDMDRepeatCategoryEntityList = new List<BDMDRepeatCategoryEntity>();

            while (reader.Read())
            {
                BDMDRepeatCategoryEntityList.Add(((IEntityBuilder<BDMDRepeatCategoryEntity>)this).BuildEntity(reader));
            }

            return (BDMDRepeatCategoryEntityList.Count > 0) ? BDMDRepeatCategoryEntityList : null;
        }

        BDMDRepeatCategoryEntity IEntityBuilder<BDMDRepeatCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REPEATCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity = new BDMDRepeatCategoryEntity();

            bDMDRepeatCategoryEntity.RepeatCategoryID = reader.GetInt64(FLD_REPEATCATEGORYID);
            bDMDRepeatCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { bDMDRepeatCategoryEntity.Remarks = String.Empty; } else { bDMDRepeatCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDMDRepeatCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDMDRepeatCategoryEntity;
        }
    }
}
