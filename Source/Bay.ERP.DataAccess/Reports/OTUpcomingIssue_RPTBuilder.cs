// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 05:15:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTUpcomingIssue_RPTBuilder : IEntityBuilder<OTUpcomingIssue_RPTEntity>
    {
        IList<OTUpcomingIssue_RPTEntity> IEntityBuilder<OTUpcomingIssue_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTUpcomingIssue_RPTEntity> OTUpcomingIssue_RPTEntityList = new List<OTUpcomingIssue_RPTEntity>();

            while (reader.Read())
            {
                OTUpcomingIssue_RPTEntityList.Add(((IEntityBuilder<OTUpcomingIssue_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTUpcomingIssue_RPTEntityList.Count > 0) ? OTUpcomingIssue_RPTEntityList : null;
        }

        OTUpcomingIssue_RPTEntity IEntityBuilder<OTUpcomingIssue_RPTEntity>.BuildEntity(IDataReader reader)
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

            OTUpcomingIssue_RPTEntity oTUpcomingIssue_RPTEntity = new OTUpcomingIssue_RPTEntity();

            oTUpcomingIssue_RPTEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTUpcomingIssue_RPTEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTUpcomingIssue_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTUpcomingIssue_RPTEntity.ParentIssueID = null; } else { oTUpcomingIssue_RPTEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTUpcomingIssue_RPTEntity.ReferenceID = null; } else { oTUpcomingIssue_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTUpcomingIssue_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTUpcomingIssue_RPTEntity.Description = String.Empty; } else { oTUpcomingIssue_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTUpcomingIssue_RPTEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTUpcomingIssue_RPTEntity.CompletionPercentage = null; } else { oTUpcomingIssue_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTUpcomingIssue_RPTEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTUpcomingIssue_RPTEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTUpcomingIssue_RPTEntity.CreateDate = null; } else { oTUpcomingIssue_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTUpcomingIssue_RPTEntity.Duration = null; } else { oTUpcomingIssue_RPTEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTUpcomingIssue_RPTEntity.ExpectedStartDate = null; } else { oTUpcomingIssue_RPTEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTUpcomingIssue_RPTEntity.ExpectedEndDate = null; } else { oTUpcomingIssue_RPTEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTUpcomingIssue_RPTEntity.ActualStartDate = null; } else { oTUpcomingIssue_RPTEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTUpcomingIssue_RPTEntity.ActualEndDate = null; } else { oTUpcomingIssue_RPTEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTUpcomingIssue_RPTEntity.NotifyBeforeMin = null; } else { oTUpcomingIssue_RPTEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTUpcomingIssue_RPTEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTUpcomingIssue_RPTEntity.Remarks = String.Empty; } else { oTUpcomingIssue_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTUpcomingIssue_RPTEntity.ReferenceIssueID = null; } else { oTUpcomingIssue_RPTEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTUpcomingIssue_RPTEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME);
            oTUpcomingIssue_RPTEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME);
            oTUpcomingIssue_RPTEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME);
            oTUpcomingIssue_RPTEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);

            return oTUpcomingIssue_RPTEntity;
        }
    }
}
