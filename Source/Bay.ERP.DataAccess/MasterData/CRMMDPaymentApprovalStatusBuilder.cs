// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDPaymentApprovalStatusBuilder : IEntityBuilder<CRMMDPaymentApprovalStatusEntity>
    {
        IList<CRMMDPaymentApprovalStatusEntity> IEntityBuilder<CRMMDPaymentApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDPaymentApprovalStatusEntity> CRMMDPaymentApprovalStatusEntityList = new List<CRMMDPaymentApprovalStatusEntity>();

            while (reader.Read())
            {
                CRMMDPaymentApprovalStatusEntityList.Add(((IEntityBuilder<CRMMDPaymentApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (CRMMDPaymentApprovalStatusEntityList.Count > 0) ? CRMMDPaymentApprovalStatusEntityList : null;
        }

        CRMMDPaymentApprovalStatusEntity IEntityBuilder<CRMMDPaymentApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PAYMENTAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity = new CRMMDPaymentApprovalStatusEntity();

            cRMMDPaymentApprovalStatusEntity.PaymentApprovalStatusID = reader.GetInt64(FLD_PAYMENTAPPROVALSTATUSID);
            cRMMDPaymentApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDPaymentApprovalStatusEntity.Description = String.Empty; } else { cRMMDPaymentApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDPaymentApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDPaymentApprovalStatusEntity;
        }
    }
}
