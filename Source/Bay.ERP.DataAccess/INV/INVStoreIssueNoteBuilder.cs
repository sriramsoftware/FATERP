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
    internal sealed class INVStoreIssueNoteBuilder : IEntityBuilder<INVStoreIssueNoteEntity>
    {
        IList<INVStoreIssueNoteEntity> IEntityBuilder<INVStoreIssueNoteEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreIssueNoteEntity> INVStoreIssueNoteEntityList = new List<INVStoreIssueNoteEntity>();

            while (reader.Read())
            {
                INVStoreIssueNoteEntityList.Add(((IEntityBuilder<INVStoreIssueNoteEntity>)this).BuildEntity(reader));
            }

            return (INVStoreIssueNoteEntityList.Count > 0) ? INVStoreIssueNoteEntityList : null;
        }

        INVStoreIssueNoteEntity IEntityBuilder<INVStoreIssueNoteEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_STOREISSUENOTEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_STOREISSUENOTENO = 2;
            const Int32 FLD_SRFNO = 3;
            const Int32 FLD_REQUESTEDBYEMPLOYEEID = 4;
            const Int32 FLD_REQUESTDATE = 5;
            const Int32 FLD_REMARKS = 6;
            const Int32 FLD_STOREISSUENOTEAPPROVALSTATUSID = 7;
            const Int32 FLD_ISREMOVED = 8;

            INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();

            iNVStoreIssueNoteEntity.StoreIssueNoteID = reader.GetInt64(FLD_STOREISSUENOTEID);
            iNVStoreIssueNoteEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            iNVStoreIssueNoteEntity.StoreIssueNoteNo = reader.GetString(FLD_STOREISSUENOTENO);
            iNVStoreIssueNoteEntity.SRFNo = reader.GetString(FLD_SRFNO);
            iNVStoreIssueNoteEntity.RequestedByEmployeeID = reader.GetInt64(FLD_REQUESTEDBYEMPLOYEEID);
            iNVStoreIssueNoteEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVStoreIssueNoteEntity.Remarks = String.Empty; } else { iNVStoreIssueNoteEntity.Remarks = reader.GetString(FLD_REMARKS); }
            iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID = reader.GetInt64(FLD_STOREISSUENOTEAPPROVALSTATUSID);
            iNVStoreIssueNoteEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return iNVStoreIssueNoteEntity;
        }
    }
}
