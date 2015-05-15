// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDStoreIssueNoteApprovalStatusBuilder : IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>
    {
        IList<MDStoreIssueNoteApprovalStatusEntity> IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDStoreIssueNoteApprovalStatusEntity> MDStoreIssueNoteApprovalStatusEntityList = new List<MDStoreIssueNoteApprovalStatusEntity>();

            while (reader.Read())
            {
                MDStoreIssueNoteApprovalStatusEntityList.Add(((IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDStoreIssueNoteApprovalStatusEntityList.Count > 0) ? MDStoreIssueNoteApprovalStatusEntityList : null;
        }

        MDStoreIssueNoteApprovalStatusEntity IEntityBuilder<MDStoreIssueNoteApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREISSUENOTEAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity = new MDStoreIssueNoteApprovalStatusEntity();

            mDStoreIssueNoteApprovalStatusEntity.StoreIssueNoteApprovalStatusID = reader.GetInt64(FLD_STOREISSUENOTEAPPROVALSTATUSID);
            mDStoreIssueNoteApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDStoreIssueNoteApprovalStatusEntity.Description = String.Empty; } else { mDStoreIssueNoteApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDStoreIssueNoteApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDStoreIssueNoteApprovalStatusEntity;
        }
    }
}
