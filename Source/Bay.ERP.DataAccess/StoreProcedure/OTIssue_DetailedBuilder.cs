// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Aug-2013, 05:20:36




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using System.Data.SqlClient;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssue_DetailedBuilder : IEntityBuilder<OTIssue_DetailedEntity>
    {
        IList<OTIssue_DetailedEntity> IEntityBuilder<OTIssue_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssue_DetailedEntity> OTIssue_DetailedEntityList = new List<OTIssue_DetailedEntity>();

            while (reader.Read())
            {
                OTIssue_DetailedEntityList.Add(((IEntityBuilder<OTIssue_DetailedEntity>)this).BuildEntity(reader));
            }

            return (OTIssue_DetailedEntityList.Count > 0) ? OTIssue_DetailedEntityList : null;
        }

        OTIssue_DetailedEntity IEntityBuilder<OTIssue_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ISREMOVED = 21;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 22;
            const Int32 FLD_ASSIGNEDTOEMPLOYEEID = 23;
            const Int32 FLD_SUPERVISORAGREED = 24;
            const Int32 FLD_MODIFIEDBYSUPERVISORDATETIME = 25;
            const Int32 FLD_IP = 26;
            const Int32 FLD_DTLDURATION = 27;
            const Int32 FLD_ISSUEIDENTITYCATEGORYNAME = 28;
            const Int32 FLD_ISSUECATEGORYNAME = 29;
            const Int32 FLD_PARENTISSUETITLE = 30;
            const Int32 FLD_ISSUEPRIORITYNAME = 31;
            const Int32 FLD_ISSUESTATUSNAME = 32;
            const Int32 FLD_PROJECTCODE = 33;
            const Int32 FLD_PROJECTNAME = 34;
            const Int32 FLD_MEMBERFULLNAME = 35;
            const Int32 FLD_SUPERVISORFULLNAME = 36;
            const Int32 FLD_ASSIGNEDTOFULLNAME = 37;
            const Int32 FLD_REFERENCEISSUETITLE = 38;
            const Int32 FLD_MEETINGINPROJECT = 39;
            const Int32 FLD_PROJECTFLOORNAME = 40;
            const Int32 FLD_PROJECTFLOORUNITNAME = 41;
            const Int32 FLD_PROJECTUNITLOCATIONNAME = 42;
            const Int32 FLD_ROWNUMBER = 43;

            OTIssue_DetailedEntity oTIssue_DetailedEntity = new OTIssue_DetailedEntity();

            oTIssue_DetailedEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssue_DetailedEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTIssue_DetailedEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTIssue_DetailedEntity.ParentIssueID = null; } else { oTIssue_DetailedEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssue_DetailedEntity.ReferenceID = null; } else { oTIssue_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssue_DetailedEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTIssue_DetailedEntity.Description = String.Empty; } else { oTIssue_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTIssue_DetailedEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTIssue_DetailedEntity.CompletionPercentage = null; } else { oTIssue_DetailedEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTIssue_DetailedEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTIssue_DetailedEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTIssue_DetailedEntity.CreateDate = null; } else { oTIssue_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTIssue_DetailedEntity.Duration = null; } else { oTIssue_DetailedEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTIssue_DetailedEntity.ExpectedStartDate = null; } else { oTIssue_DetailedEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTIssue_DetailedEntity.ExpectedEndDate = null; } else { oTIssue_DetailedEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTIssue_DetailedEntity.ActualStartDate = null; } else { oTIssue_DetailedEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTIssue_DetailedEntity.ActualEndDate = null; } else { oTIssue_DetailedEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTIssue_DetailedEntity.NotifyBeforeMin = null; } else { oTIssue_DetailedEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTIssue_DetailedEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssue_DetailedEntity.Remarks = String.Empty; } else { oTIssue_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTIssue_DetailedEntity.ReferenceIssueID = null; } else { oTIssue_DetailedEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTIssue_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            oTIssue_DetailedEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            oTIssue_DetailedEntity.AssignedToEmployeeID = reader.GetInt64(FLD_ASSIGNEDTOEMPLOYEEID);
            oTIssue_DetailedEntity.SupervisorAgreed = reader.GetBoolean(FLD_SUPERVISORAGREED);
            oTIssue_DetailedEntity.ModifiedBySupervisorDateTime = reader.GetDateTime(FLD_MODIFIEDBYSUPERVISORDATETIME);
            if (reader.IsDBNull(FLD_IP)) { oTIssue_DetailedEntity.IP = String.Empty; } else { oTIssue_DetailedEntity.IP = reader.GetString(FLD_IP); }
            if (reader.IsDBNull(FLD_DTLDURATION)) { oTIssue_DetailedEntity.DTLDuration = null; } else { oTIssue_DetailedEntity.DTLDuration = ((SqlDataReader)reader).GetTimeSpan(FLD_DTLDURATION); }
            if (reader.IsDBNull(FLD_ISSUEIDENTITYCATEGORYNAME)) { oTIssue_DetailedEntity.IssueIdentityCategoryName = String.Empty; } else { oTIssue_DetailedEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ISSUECATEGORYNAME)) { oTIssue_DetailedEntity.IssueCategoryName = String.Empty; } else { oTIssue_DetailedEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME); }
            if (reader.IsDBNull(FLD_PARENTISSUETITLE)) { oTIssue_DetailedEntity.ParentIssueTitle = String.Empty; } else { oTIssue_DetailedEntity.ParentIssueTitle = reader.GetString(FLD_PARENTISSUETITLE); }
            if (reader.IsDBNull(FLD_ISSUEPRIORITYNAME)) { oTIssue_DetailedEntity.IssuePriorityName = String.Empty; } else { oTIssue_DetailedEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME); }
            if (reader.IsDBNull(FLD_ISSUESTATUSNAME)) { oTIssue_DetailedEntity.IssueStatusName = String.Empty; } else { oTIssue_DetailedEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { oTIssue_DetailedEntity.ProjectCode = String.Empty; } else { oTIssue_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssue_DetailedEntity.ProjectName = String.Empty; } else { oTIssue_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { oTIssue_DetailedEntity.MemberFullName = String.Empty; } else { oTIssue_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { oTIssue_DetailedEntity.SupervisorFullName = String.Empty; } else { oTIssue_DetailedEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_ASSIGNEDTOFULLNAME)) { oTIssue_DetailedEntity.AssignedToFullName = String.Empty; } else { oTIssue_DetailedEntity.AssignedToFullName = reader.GetString(FLD_ASSIGNEDTOFULLNAME); }
            if (reader.IsDBNull(FLD_REFERENCEISSUETITLE)) { oTIssue_DetailedEntity.ReferenceIssueTitle = String.Empty; } else { oTIssue_DetailedEntity.ReferenceIssueTitle = reader.GetString(FLD_REFERENCEISSUETITLE); }
            if (reader.IsDBNull(FLD_MEETINGINPROJECT)) { oTIssue_DetailedEntity.MeetingInProject = String.Empty; } else { oTIssue_DetailedEntity.MeetingInProject = reader.GetString(FLD_MEETINGINPROJECT); }
            if (reader.IsDBNull(FLD_PROJECTFLOORNAME)) { oTIssue_DetailedEntity.ProjectFloorName = String.Empty; } else { oTIssue_DetailedEntity.ProjectFloorName = reader.GetString(FLD_PROJECTFLOORNAME); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITNAME)) { oTIssue_DetailedEntity.ProjectFloorUnitName = String.Empty; } else { oTIssue_DetailedEntity.ProjectFloorUnitName = reader.GetString(FLD_PROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_PROJECTUNITLOCATIONNAME)) { oTIssue_DetailedEntity.ProjectUnitLocationName = String.Empty; } else { oTIssue_DetailedEntity.ProjectUnitLocationName = reader.GetString(FLD_PROJECTUNITLOCATIONNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { oTIssue_DetailedEntity.RowNumber = null; } else { oTIssue_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return oTIssue_DetailedEntity;
        }
    }
}
