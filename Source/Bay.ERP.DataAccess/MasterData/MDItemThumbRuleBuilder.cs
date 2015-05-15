// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDItemThumbRuleBuilder : IEntityBuilder<MDItemThumbRuleEntity>
    {
        IList<MDItemThumbRuleEntity> IEntityBuilder<MDItemThumbRuleEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemThumbRuleEntity> MDItemThumbRuleEntityList = new List<MDItemThumbRuleEntity>();

            while (reader.Read())
            {
                MDItemThumbRuleEntityList.Add(((IEntityBuilder<MDItemThumbRuleEntity>)this).BuildEntity(reader));
            }

            return (MDItemThumbRuleEntityList.Count > 0) ? MDItemThumbRuleEntityList : null;
        }

        MDItemThumbRuleEntity IEntityBuilder<MDItemThumbRuleEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MDITEMTHUMBRULEID = 0;
            const Int32 FLD_ITEMID = 1;
            const Int32 FLD_FLOORRULEVARIABLE = 2;
            const Int32 FLD_FLOORQUANTITY = 3;
            const Int32 FLD_BASEMENTRULEVARIABLE = 4;
            const Int32 FLD_BASEMENTQUANTITY = 5;
            const Int32 FLD_OVERALLRULEVARIABLE = 6;
            const Int32 FLD_OVERALLQUANTITY = 7;

            MDItemThumbRuleEntity mDItemThumbRuleEntity = new MDItemThumbRuleEntity();

            mDItemThumbRuleEntity.MDItemThumbRuleID = reader.GetInt64(FLD_MDITEMTHUMBRULEID);
            mDItemThumbRuleEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            mDItemThumbRuleEntity.FloorRuleVariable = reader.GetDecimal(FLD_FLOORRULEVARIABLE);
            mDItemThumbRuleEntity.FloorQuantity = reader.GetDecimal(FLD_FLOORQUANTITY);
            mDItemThumbRuleEntity.BasementRuleVariable = reader.GetDecimal(FLD_BASEMENTRULEVARIABLE);
            mDItemThumbRuleEntity.BasementQuantity = reader.GetDecimal(FLD_BASEMENTQUANTITY);
            mDItemThumbRuleEntity.OverallRuleVariable = reader.GetDecimal(FLD_OVERALLRULEVARIABLE);
            mDItemThumbRuleEntity.OverallQuantity = reader.GetDecimal(FLD_OVERALLQUANTITY);

            return mDItemThumbRuleEntity;
        }
    }
}
