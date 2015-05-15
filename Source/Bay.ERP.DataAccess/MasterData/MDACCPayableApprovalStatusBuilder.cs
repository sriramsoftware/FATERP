// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDACCPayableApprovalStatusBuilder : IEntityBuilder<MDACCPayableApprovalStatusEntity>
    {
        IList<MDACCPayableApprovalStatusEntity> IEntityBuilder<MDACCPayableApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDACCPayableApprovalStatusEntity> MDACCPayableApprovalStatusEntityList = new List<MDACCPayableApprovalStatusEntity>();

            while (reader.Read())
            {
                MDACCPayableApprovalStatusEntityList.Add(((IEntityBuilder<MDACCPayableApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDACCPayableApprovalStatusEntityList.Count > 0) ? MDACCPayableApprovalStatusEntityList : null;
        }

        MDACCPayableApprovalStatusEntity IEntityBuilder<MDACCPayableApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCPAYABLEAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDACCPayableApprovalStatusEntity mDACCPayableApprovalStatusEntity = new MDACCPayableApprovalStatusEntity();

            mDACCPayableApprovalStatusEntity.ACCPayableApprovalStatusID = reader.GetInt64(FLD_ACCPAYABLEAPPROVALSTATUSID);
            mDACCPayableApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDACCPayableApprovalStatusEntity.Description = String.Empty; } else { mDACCPayableApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDACCPayableApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDACCPayableApprovalStatusEntity;
        }
    }
}
