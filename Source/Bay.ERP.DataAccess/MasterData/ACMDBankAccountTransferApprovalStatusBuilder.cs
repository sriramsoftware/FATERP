// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 10:27:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDBankAccountTransferApprovalStatusBuilder : IEntityBuilder<ACMDBankAccountTransferApprovalStatusEntity>
    {
        IList<ACMDBankAccountTransferApprovalStatusEntity> IEntityBuilder<ACMDBankAccountTransferApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDBankAccountTransferApprovalStatusEntity> ACMDBankAccountTransferApprovalStatusEntityList = new List<ACMDBankAccountTransferApprovalStatusEntity>();

            while (reader.Read())
            {
                ACMDBankAccountTransferApprovalStatusEntityList.Add(((IEntityBuilder<ACMDBankAccountTransferApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (ACMDBankAccountTransferApprovalStatusEntityList.Count > 0) ? ACMDBankAccountTransferApprovalStatusEntityList : null;
        }

        ACMDBankAccountTransferApprovalStatusEntity IEntityBuilder<ACMDBankAccountTransferApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDBankAccountTransferApprovalStatusEntity aCMDBankAccountTransferApprovalStatusEntity = new ACMDBankAccountTransferApprovalStatusEntity();

            aCMDBankAccountTransferApprovalStatusEntity.BankAccountTransferApprovalStatusID = reader.GetInt64(FLD_BANKACCOUNTTRANSFERAPPROVALSTATUSID);
            aCMDBankAccountTransferApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDBankAccountTransferApprovalStatusEntity.Description = null; } else { aCMDBankAccountTransferApprovalStatusEntity.Description = reader.GetChar(FLD_DESCRIPTION); }
            aCMDBankAccountTransferApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDBankAccountTransferApprovalStatusEntity;
        }
    }
}
