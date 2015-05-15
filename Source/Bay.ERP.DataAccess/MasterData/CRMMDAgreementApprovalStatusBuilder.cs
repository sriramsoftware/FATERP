// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDAgreementApprovalStatusBuilder : IEntityBuilder<CRMMDAgreementApprovalStatusEntity>
    {
        IList<CRMMDAgreementApprovalStatusEntity> IEntityBuilder<CRMMDAgreementApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAgreementApprovalStatusEntity> CRMMDAgreementApprovalStatusEntityList = new List<CRMMDAgreementApprovalStatusEntity>();

            while (reader.Read())
            {
                CRMMDAgreementApprovalStatusEntityList.Add(((IEntityBuilder<CRMMDAgreementApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAgreementApprovalStatusEntityList.Count > 0) ? CRMMDAgreementApprovalStatusEntityList : null;
        }

        CRMMDAgreementApprovalStatusEntity IEntityBuilder<CRMMDAgreementApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity = new CRMMDAgreementApprovalStatusEntity();

            cRMMDAgreementApprovalStatusEntity.AgreementApprovalStatusID = reader.GetInt64(FLD_AGREEMENTAPPROVALSTATUSID);
            cRMMDAgreementApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDAgreementApprovalStatusEntity.Description = String.Empty; } else { cRMMDAgreementApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDAgreementApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAgreementApprovalStatusEntity;
        }
    }
}
