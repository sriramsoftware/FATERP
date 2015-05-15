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
    internal sealed class MDContractorCriterionStatusBuilder : IEntityBuilder<MDContractorCriterionStatusEntity>
    {
        IList<MDContractorCriterionStatusEntity> IEntityBuilder<MDContractorCriterionStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDContractorCriterionStatusEntity> MDContractorCriterionStatusEntityList = new List<MDContractorCriterionStatusEntity>();

            while (reader.Read())
            {
                MDContractorCriterionStatusEntityList.Add(((IEntityBuilder<MDContractorCriterionStatusEntity>)this).BuildEntity(reader));
            }

            return (MDContractorCriterionStatusEntityList.Count > 0) ? MDContractorCriterionStatusEntityList : null;
        }

        MDContractorCriterionStatusEntity IEntityBuilder<MDContractorCriterionStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORCRITERIONSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDContractorCriterionStatusEntity mDContractorCriterionStatusEntity = new MDContractorCriterionStatusEntity();

            mDContractorCriterionStatusEntity.ContractorCriterionStatusID = reader.GetInt64(FLD_CONTRACTORCRITERIONSTATUSID);
            if (reader.IsDBNull(FLD_NAME)) { mDContractorCriterionStatusEntity.Name = String.Empty; } else { mDContractorCriterionStatusEntity.Name = reader.GetString(FLD_NAME); }
            mDContractorCriterionStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDContractorCriterionStatusEntity;
        }
    }
}
