// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2013, 10:44:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueDateWise_RPTBuilder : IEntityBuilder<OTIssueDateWise_RPTEntity>
    {
        IList<OTIssueDateWise_RPTEntity> IEntityBuilder<OTIssueDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueDateWise_RPTEntity> OTIssueDateWise_RPTEntityList = new List<OTIssueDateWise_RPTEntity>();

            while (reader.Read())
            {
                OTIssueDateWise_RPTEntityList.Add(((IEntityBuilder<OTIssueDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTIssueDateWise_RPTEntityList.Count > 0) ? OTIssueDateWise_RPTEntityList : null;
        }

        OTIssueDateWise_RPTEntity IEntityBuilder<OTIssueDateWise_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_ASSIGNEDTOEMPLOYEEID = 20;
            const Int32 FLD_SUPERVISORAGREED = 21;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 22;
            const Int32 FLD_MODIFIEDBYSUPERVISORDATETIME = 23;
            const Int32 FLD_REFERENCEISSUEID = 24;
            const Int32 FLD_ISSUEIDENTITYCATEGORYNAME = 25;
            const Int32 FLD_ISSUECATEGORYNAME = 26;
            const Int32 FLD_ISSUEPRIORITYNAME = 27;
            const Int32 FLD_ISSUESTATUSNAME = 28;
            const Int32 FLD_ASSIGNEDTOEMPLOYEEFULLNAME = 29;
            const Int32 FLD_SUPERVISORFULLNAME = 30;
            const Int32 FLD_PROJECTCODE = 31;
            const Int32 FLD_PROJECTNAME = 32;

            OTIssueDateWise_RPTEntity oTIssueDateWise_RPTEntity = new OTIssueDateWise_RPTEntity();

            oTIssueDateWise_RPTEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssueDateWise_RPTEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTIssueDateWise_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTIssueDateWise_RPTEntity.ParentIssueID = null; } else { oTIssueDateWise_RPTEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssueDateWise_RPTEntity.ReferenceID = null; } else { oTIssueDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssueDateWise_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTIssueDateWise_RPTEntity.Description = String.Empty; } else { oTIssueDateWise_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTIssueDateWise_RPTEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTIssueDateWise_RPTEntity.CompletionPercentage = null; } else { oTIssueDateWise_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTIssueDateWise_RPTEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTIssueDateWise_RPTEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTIssueDateWise_RPTEntity.CreateDate = null; } else { oTIssueDateWise_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTIssueDateWise_RPTEntity.Duration = null; } else { oTIssueDateWise_RPTEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTIssueDateWise_RPTEntity.ExpectedStartDate = null; } else { oTIssueDateWise_RPTEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTIssueDateWise_RPTEntity.ExpectedEndDate = null; } else { oTIssueDateWise_RPTEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTIssueDateWise_RPTEntity.ActualStartDate = null; } else { oTIssueDateWise_RPTEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTIssueDateWise_RPTEntity.ActualEndDate = null; } else { oTIssueDateWise_RPTEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTIssueDateWise_RPTEntity.NotifyBeforeMin = null; } else { oTIssueDateWise_RPTEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTIssueDateWise_RPTEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssueDateWise_RPTEntity.Remarks = String.Empty; } else { oTIssueDateWise_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            oTIssueDateWise_RPTEntity.AssignedToEmployeeID = reader.GetInt64(FLD_ASSIGNEDTOEMPLOYEEID);
            oTIssueDateWise_RPTEntity.SupervisorAgreed = reader.GetBoolean(FLD_SUPERVISORAGREED);
            oTIssueDateWise_RPTEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            oTIssueDateWise_RPTEntity.ModifiedBySupervisorDateTime = reader.GetDateTime(FLD_MODIFIEDBYSUPERVISORDATETIME);
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTIssueDateWise_RPTEntity.ReferenceIssueID = null; } else { oTIssueDateWise_RPTEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTIssueDateWise_RPTEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME);
            oTIssueDateWise_RPTEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME);
            oTIssueDateWise_RPTEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME);
            oTIssueDateWise_RPTEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);
            if (reader.IsDBNull(FLD_ASSIGNEDTOEMPLOYEEFULLNAME)) { oTIssueDateWise_RPTEntity.AssignedToEmployeeFullName = String.Empty; } else { oTIssueDateWise_RPTEntity.AssignedToEmployeeFullName = reader.GetString(FLD_ASSIGNEDTOEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { oTIssueDateWise_RPTEntity.SupervisorFullName = String.Empty; } else { oTIssueDateWise_RPTEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { oTIssueDateWise_RPTEntity.ProjectCode = String.Empty; } else { oTIssueDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssueDateWise_RPTEntity.ProjectName = String.Empty; } else { oTIssueDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return oTIssueDateWise_RPTEntity;
        }
    }
}
