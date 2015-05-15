// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDBankAccountPaymentApprovalStatusBuilder : IEntityBuilder<ACMDBankAccountPaymentApprovalStatusEntity>
    {
        IList<ACMDBankAccountPaymentApprovalStatusEntity> IEntityBuilder<ACMDBankAccountPaymentApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDBankAccountPaymentApprovalStatusEntity> ACMDBankAccountPaymentApprovalStatusEntityList = new List<ACMDBankAccountPaymentApprovalStatusEntity>();

            while (reader.Read())
            {
                ACMDBankAccountPaymentApprovalStatusEntityList.Add(((IEntityBuilder<ACMDBankAccountPaymentApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (ACMDBankAccountPaymentApprovalStatusEntityList.Count > 0) ? ACMDBankAccountPaymentApprovalStatusEntityList : null;
        }

        ACMDBankAccountPaymentApprovalStatusEntity IEntityBuilder<ACMDBankAccountPaymentApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity = new ACMDBankAccountPaymentApprovalStatusEntity();

            aCMDBankAccountPaymentApprovalStatusEntity.BankAccountPaymentApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTAPPROVALSTATUSID);
            aCMDBankAccountPaymentApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDBankAccountPaymentApprovalStatusEntity.Description = String.Empty; } else { aCMDBankAccountPaymentApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDBankAccountPaymentApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDBankAccountPaymentApprovalStatusEntity;
        }
    }
}
