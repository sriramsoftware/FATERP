// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2013, 12:26:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssue_RPTBuilder : IEntityBuilder<OTIssue_RPTEntity>
    {
        IList<OTIssue_RPTEntity> IEntityBuilder<OTIssue_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssue_RPTEntity> OTIssue_RPTEntityList = new List<OTIssue_RPTEntity>();

            while (reader.Read())
            {
                OTIssue_RPTEntityList.Add(((IEntityBuilder<OTIssue_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTIssue_RPTEntityList.Count > 0) ? OTIssue_RPTEntityList : null;
        }

        OTIssue_RPTEntity IEntityBuilder<OTIssue_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_PROJECTCODE = 25;
            const Int32 FLD_PROJECTNAME = 26;
            const Int32 FLD_RESOURCEID = 27;
            const Int32 FLD_MEMBERFULLNAME = 28;

            OTIssue_RPTEntity oTIssue_RPTEntity = new OTIssue_RPTEntity();

            oTIssue_RPTEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssue_RPTEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTIssue_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTIssue_RPTEntity.ParentIssueID = null; } else { oTIssue_RPTEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssue_RPTEntity.ReferenceID = null; } else { oTIssue_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssue_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTIssue_RPTEntity.Description = String.Empty; } else { oTIssue_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTIssue_RPTEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTIssue_RPTEntity.CompletionPercentage = null; } else { oTIssue_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTIssue_RPTEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTIssue_RPTEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTIssue_RPTEntity.CreateDate = null; } else { oTIssue_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTIssue_RPTEntity.Duration = null; } else { oTIssue_RPTEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTIssue_RPTEntity.ExpectedStartDate = null; } else { oTIssue_RPTEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTIssue_RPTEntity.ExpectedEndDate = null; } else { oTIssue_RPTEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTIssue_RPTEntity.ActualStartDate = null; } else { oTIssue_RPTEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTIssue_RPTEntity.ActualEndDate = null; } else { oTIssue_RPTEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTIssue_RPTEntity.NotifyBeforeMin = null; } else { oTIssue_RPTEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTIssue_RPTEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssue_RPTEntity.Remarks = String.Empty; } else { oTIssue_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTIssue_RPTEntity.ReferenceIssueID = null; } else { oTIssue_RPTEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTIssue_RPTEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME);
            oTIssue_RPTEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME);
            oTIssue_RPTEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME);
            oTIssue_RPTEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { oTIssue_RPTEntity.ProjectCode = String.Empty; } else { oTIssue_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssue_RPTEntity.ProjectName = String.Empty; } else { oTIssue_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_RESOURCEID)) { oTIssue_RPTEntity.ResourceID = null; } else { oTIssue_RPTEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { oTIssue_RPTEntity.MemberFullName = String.Empty; } else { oTIssue_RPTEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }

            return oTIssue_RPTEntity;
        }
    }
}
