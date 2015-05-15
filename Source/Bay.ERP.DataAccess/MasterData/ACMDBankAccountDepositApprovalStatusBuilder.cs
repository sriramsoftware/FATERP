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
    internal sealed class ACMDBankAccountDepositApprovalStatusBuilder : IEntityBuilder<ACMDBankAccountDepositApprovalStatusEntity>
    {
        IList<ACMDBankAccountDepositApprovalStatusEntity> IEntityBuilder<ACMDBankAccountDepositApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDBankAccountDepositApprovalStatusEntity> ACMDBankAccountDepositApprovalStatusEntityList = new List<ACMDBankAccountDepositApprovalStatusEntity>();

            while (reader.Read())
            {
                ACMDBankAccountDepositApprovalStatusEntityList.Add(((IEntityBuilder<ACMDBankAccountDepositApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (ACMDBankAccountDepositApprovalStatusEntityList.Count > 0) ? ACMDBankAccountDepositApprovalStatusEntityList : null;
        }

        ACMDBankAccountDepositApprovalStatusEntity IEntityBuilder<ACMDBankAccountDepositApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDBankAccountDepositApprovalStatusEntity aCMDBankAccountDepositApprovalStatusEntity = new ACMDBankAccountDepositApprovalStatusEntity();

            aCMDBankAccountDepositApprovalStatusEntity.BankAccountDepositApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTDEPOSITAPPROVALSTATUSID);
            aCMDBankAccountDepositApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDBankAccountDepositApprovalStatusEntity.Description = String.Empty; } else { aCMDBankAccountDepositApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDBankAccountDepositApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDBankAccountDepositApprovalStatusEntity;
        }
    }
}
