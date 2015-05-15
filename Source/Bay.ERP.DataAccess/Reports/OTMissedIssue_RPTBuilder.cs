// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 11:08:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTMissedIssue_RPTBuilder : IEntityBuilder<OTMissedIssue_RPTEntity>
    {
        IList<OTMissedIssue_RPTEntity> IEntityBuilder<OTMissedIssue_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTMissedIssue_RPTEntity> OTMissedIssue_RPTEntityList = new List<OTMissedIssue_RPTEntity>();

            while (reader.Read())
            {
                OTMissedIssue_RPTEntityList.Add(((IEntityBuilder<OTMissedIssue_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTMissedIssue_RPTEntityList.Count > 0) ? OTMissedIssue_RPTEntityList : null;
        }

        OTMissedIssue_RPTEntity IEntityBuilder<OTMissedIssue_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEID = 0;
            const Int32 FLD_ISSUEIDENTITYCATEGORYID = 1;
            const Int32 FLD_ISSUECATEGORYID = 2;
            const Int32 FLD_PARENTISSUEID = 3;
            const Int32 FLD_REFERENCEID = 4;
            const Int32 FLD_TITLE = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_ISSUEPRIORITYID = 7;
            const Int32 FLD_COMPLETIONPERCENTAGE = 8;
            const Int32 FLD_ISSUESTATUSID = 9;
            const Int32 FLD_CREATEDBYMEMBERID = 10;
            const Int32 FLD_CREATEDATE = 11;
            const Int32 FLD_DURATION = 12;
            const Int32 FLD_EXPECTEDSTARTDATE = 13;
            const Int32 FLD_EXPECTEDENDDATE = 14;
            const Int32 FLD_ACTUALSTARTDATE = 15;
            const Int32 FLD_ACTUALENDDATE = 16;
            const Int32 FLD_NOTIFYBEFOREMIN = 17;
            const Int32 FLD_ISNOTIFYCOMPLETED = 18;
            const Int32 FLD_REMARKS = 19;
            const Int32 FLD_REFERENCEISSUEID = 20;
            const Int32 FLD_ISSUEIDENTITYCATEGORYNAME = 21;
            const Int32 FLD_ISSUECATEGORYNAME = 22;
            const Int32 FLD_ISSUEPRIORITYNAME = 23;
            const Int32 FLD_ISSUESTATUSNAME = 24;

            OTMissedIssue_RPTEntity oTMissedIssue_RPTEntity = new OTMissedIssue_RPTEntity();

            oTMissedIssue_RPTEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTMissedIssue_RPTEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTMissedIssue_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTMissedIssue_RPTEntity.ParentIssueID = null; } else { oTMissedIssue_RPTEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTMissedIssue_RPTEntity.ReferenceID = null; } else { oTMissedIssue_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTMissedIssue_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTMissedIssue_RPTEntity.Description = String.Empty; } else { oTMissedIssue_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTMissedIssue_RPTEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTMissedIssue_RPTEntity.CompletionPercentage = null; } else { oTMissedIssue_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTMissedIssue_RPTEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTMissedIssue_RPTEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTMissedIssue_RPTEntity.CreateDate = null; } else { oTMissedIssue_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTMissedIssue_RPTEntity.Duration = null; } else { oTMissedIssue_RPTEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTMissedIssue_RPTEntity.ExpectedStartDate = null; } else { oTMissedIssue_RPTEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTMissedIssue_RPTEntity.ExpectedEndDate = null; } else { oTMissedIssue_RPTEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTMissedIssue_RPTEntity.ActualStartDate = null; } else { oTMissedIssue_RPTEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTMissedIssue_RPTEntity.ActualEndDate = null; } else { oTMissedIssue_RPTEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTMissedIssue_RPTEntity.NotifyBeforeMin = null; } else { oTMissedIssue_RPTEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTMissedIssue_RPTEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTMissedIssue_RPTEntity.Remarks = String.Empty; } else { oTMissedIssue_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTMissedIssue_RPTEntity.ReferenceIssueID = null; } else { oTMissedIssue_RPTEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTMissedIssue_RPTEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME);
            oTMissedIssue_RPTEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME);
            oTMissedIssue_RPTEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME);
            oTMissedIssue_RPTEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);

            return oTMissedIssue_RPTEntity;
        }
    }
}
