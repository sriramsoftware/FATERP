// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 03:53:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INVStoreIssueNote_DetailedBuilder : IEntityBuilder<INVStoreIssueNote_DetailedEntity>
    {
        IList<INVStoreIssueNote_DetailedEntity> IEntityBuilder<INVStoreIssueNote_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<INVStoreIssueNote_DetailedEntity> INVStoreIssueNote_DetailedEntityList = new List<INVStoreIssueNote_DetailedEntity>();

            while (reader.Read())
            {
                INVStoreIssueNote_DetailedEntityList.Add(((IEntityBuilder<INVStoreIssueNote_DetailedEntity>)this).BuildEntity(reader));
            }

            return (INVStoreIssueNote_DetailedEntityList.Count > 0) ? INVStoreIssueNote_DetailedEntityList : null;
        }

        INVStoreIssueNote_DetailedEntity IEntityBuilder<INVStoreIssueNote_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_BDPROJECTPROJECTNAME = 9;
            const Int32 FLD_MEMBERFULLNAME = 10;
            const Int32 FLD_MDSTOREISSUENOTEAPPROVALSTATUSNAME = 11;
            const Int32 FLD_ROWNUMBER = 12;

            INVStoreIssueNote_DetailedEntity iNVStoreIssueNote_DetailedEntity = new INVStoreIssueNote_DetailedEntity();

            iNVStoreIssueNote_DetailedEntity.StoreIssueNoteID = reader.GetInt64(FLD_STOREISSUENOTEID);
            iNVStoreIssueNote_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            iNVStoreIssueNote_DetailedEntity.StoreIssueNoteNo = reader.GetString(FLD_STOREISSUENOTENO);
            iNVStoreIssueNote_DetailedEntity.SRFNo = reader.GetString(FLD_SRFNO);
            iNVStoreIssueNote_DetailedEntity.RequestedByEmployeeID = reader.GetInt64(FLD_REQUESTEDBYEMPLOYEEID);
            iNVStoreIssueNote_DetailedEntity.RequestDate = reader.GetDateTime(FLD_REQUESTDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { iNVStoreIssueNote_DetailedEntity.Remarks = String.Empty; } else { iNVStoreIssueNote_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            iNVStoreIssueNote_DetailedEntity.StoreIssueNoteApprovalStatusID = reader.GetInt64(FLD_STOREISSUENOTEAPPROVALSTATUSID);
            iNVStoreIssueNote_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { iNVStoreIssueNote_DetailedEntity.BDProjectProjectName = String.Empty; } else { iNVStoreIssueNote_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { iNVStoreIssueNote_DetailedEntity.MemberFullName = String.Empty; } else { iNVStoreIssueNote_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_MDSTOREISSUENOTEAPPROVALSTATUSNAME)) { iNVStoreIssueNote_DetailedEntity.MDStoreIssueNoteApprovalStatusName = String.Empty; } else { iNVStoreIssueNote_DetailedEntity.MDStoreIssueNoteApprovalStatusName = reader.GetString(FLD_MDSTOREISSUENOTEAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { iNVStoreIssueNote_DetailedEntity.RowNumber = null; } else { iNVStoreIssueNote_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return iNVStoreIssueNote_DetailedEntity;
        }
    }
}
