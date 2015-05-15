// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDCriterionCategoryBuilder : IEntityBuilder<MDCriterionCategoryEntity>
    {
        IList<MDCriterionCategoryEntity> IEntityBuilder<MDCriterionCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCriterionCategoryEntity> MDCriterionCategoryEntityList = new List<MDCriterionCategoryEntity>();

            while (reader.Read())
            {
                MDCriterionCategoryEntityList.Add(((IEntityBuilder<MDCriterionCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDCriterionCategoryEntityList.Count > 0) ? MDCriterionCategoryEntityList : null;
        }

        MDCriterionCategoryEntity IEntityBuilder<MDCriterionCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CRITERIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDCriterionCategoryEntity mDCriterionCategoryEntity = new MDCriterionCategoryEntity();

            mDCriterionCategoryEntity.CriterionCategoryID = reader.GetInt64(FLD_CRITERIONCATEGORYID);
            mDCriterionCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDCriterionCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDCriterionCategoryEntity;
        }
    }
}
