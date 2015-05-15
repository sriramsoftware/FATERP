// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDTemporaryJournalApprovalStatusBuilder : IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>
    {
        IList<ACMDTemporaryJournalApprovalStatusEntity> IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDTemporaryJournalApprovalStatusEntity> ACMDTemporaryJournalApprovalStatusEntityList = new List<ACMDTemporaryJournalApprovalStatusEntity>();

            while (reader.Read())
            {
                ACMDTemporaryJournalApprovalStatusEntityList.Add(((IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (ACMDTemporaryJournalApprovalStatusEntityList.Count > 0) ? ACMDTemporaryJournalApprovalStatusEntityList : null;
        }

        ACMDTemporaryJournalApprovalStatusEntity IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TEMPORYJOURNALAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity = new ACMDTemporaryJournalApprovalStatusEntity();

            aCMDTemporaryJournalApprovalStatusEntity.TemporyJournalApprovalStatusID = reader.GetInt64(FLD_TEMPORYJOURNALAPPROVALSTATUSID);
            aCMDTemporaryJournalApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDTemporaryJournalApprovalStatusEntity.Description = String.Empty; } else { aCMDTemporaryJournalApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDTemporaryJournalApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDTemporaryJournalApprovalStatusEntity;
        }
    }
}
