// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Sep-2013, 04:16:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueWithEmployeeandDateWise_RPTBuilder : IEntityBuilder<OTIssueWithEmployeeandDateWise_RPTEntity>
    {
        IList<OTIssueWithEmployeeandDateWise_RPTEntity> IEntityBuilder<OTIssueWithEmployeeandDateWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueWithEmployeeandDateWise_RPTEntity> OTIssueWithEmployeeandDateWise_RPTEntityList = new List<OTIssueWithEmployeeandDateWise_RPTEntity>();

            while (reader.Read())
            {
                OTIssueWithEmployeeandDateWise_RPTEntityList.Add(((IEntityBuilder<OTIssueWithEmployeeandDateWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTIssueWithEmployeeandDateWise_RPTEntityList.Count > 0) ? OTIssueWithEmployeeandDateWise_RPTEntityList : null;
        }

        OTIssueWithEmployeeandDateWise_RPTEntity IEntityBuilder<OTIssueWithEmployeeandDateWise_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_DTLDURATION = 25;
            const Int32 FLD_ISSUEIDENTITYCATEGORYNAME = 26;
            const Int32 FLD_ISSUECATEGORYNAME = 27;
            const Int32 FLD_ISSUEPRIORITYNAME = 28;
            const Int32 FLD_ISSUESTATUSNAME = 29;
            const Int32 FLD_ASSIGNEDPERSONEMPLOYEECODE = 30;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 31;
            const Int32 FLD_ASSIGNEDPERSONDESIGNATIONNAME = 32;
            const Int32 FLD_SUPERVISORDESIGNATIONNAME = 33;
            const Int32 FLD_ASSIGNEDPERSONDEPARTMENTNAME = 34;
            const Int32 FLD_SUPERVISORDEPARTMENTNAME = 35;
            const Int32 FLD_ASSIGNEDTOEMPLOYEEFULLNAME = 36;
            const Int32 FLD_SUPERVISORFULLNAME = 37;
            const Int32 FLD_PROJECTCODE = 38;
            const Int32 FLD_PROJECTNAME = 39;

            OTIssueWithEmployeeandDateWise_RPTEntity oTIssueWithEmployeeandDateWise_RPTEntity = new OTIssueWithEmployeeandDateWise_RPTEntity();

            oTIssueWithEmployeeandDateWise_RPTEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTIssueWithEmployeeandDateWise_RPTEntity.ParentIssueID = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssueWithEmployeeandDateWise_RPTEntity.ReferenceID = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssueWithEmployeeandDateWise_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTIssueWithEmployeeandDateWise_RPTEntity.Description = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTIssueWithEmployeeandDateWise_RPTEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTIssueWithEmployeeandDateWise_RPTEntity.CompletionPercentage = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTIssueWithEmployeeandDateWise_RPTEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTIssueWithEmployeeandDateWise_RPTEntity.CreateDate = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTIssueWithEmployeeandDateWise_RPTEntity.Duration = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTIssueWithEmployeeandDateWise_RPTEntity.ExpectedStartDate = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTIssueWithEmployeeandDateWise_RPTEntity.ExpectedEndDate = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTIssueWithEmployeeandDateWise_RPTEntity.ActualStartDate = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTIssueWithEmployeeandDateWise_RPTEntity.ActualEndDate = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTIssueWithEmployeeandDateWise_RPTEntity.NotifyBeforeMin = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTIssueWithEmployeeandDateWise_RPTEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssueWithEmployeeandDateWise_RPTEntity.Remarks = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            oTIssueWithEmployeeandDateWise_RPTEntity.AssignedToEmployeeID = reader.GetInt64(FLD_ASSIGNEDTOEMPLOYEEID);
            oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorAgreed = reader.GetBoolean(FLD_SUPERVISORAGREED);
            oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            oTIssueWithEmployeeandDateWise_RPTEntity.ModifiedBySupervisorDateTime = reader.GetDateTime(FLD_MODIFIEDBYSUPERVISORDATETIME);
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTIssueWithEmployeeandDateWise_RPTEntity.ReferenceIssueID = null; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            if (reader.IsDBNull(FLD_DTLDURATION)) { oTIssueWithEmployeeandDateWise_RPTEntity.DTLDuration = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.DTLDuration = reader.GetString(FLD_DTLDURATION); }
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueIdentityCategoryName = reader.GetString(FLD_ISSUEIDENTITYCATEGORYNAME);
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueCategoryName = reader.GetString(FLD_ISSUECATEGORYNAME);
            oTIssueWithEmployeeandDateWise_RPTEntity.IssuePriorityName = reader.GetString(FLD_ISSUEPRIORITYNAME);
            oTIssueWithEmployeeandDateWise_RPTEntity.IssueStatusName = reader.GetString(FLD_ISSUESTATUSNAME);
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONEMPLOYEECODE)) { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonEmployeeCode = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonEmployeeCode = reader.GetString(FLD_ASSIGNEDPERSONEMPLOYEECODE); }
            if (reader.IsDBNull(FLD_SUPERVISOREMPLOYEECODE)) { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorEmployeeCode = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE); }
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONDESIGNATIONNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonDesignationName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonDesignationName = reader.GetString(FLD_ASSIGNEDPERSONDESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_SUPERVISORDESIGNATIONNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorDesignationName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorDesignationName = reader.GetString(FLD_SUPERVISORDESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONDEPARTMENTNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonDepartmentName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedPersonDepartmentName = reader.GetString(FLD_ASSIGNEDPERSONDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_SUPERVISORDEPARTMENTNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorDepartmentName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorDepartmentName = reader.GetString(FLD_SUPERVISORDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_ASSIGNEDTOEMPLOYEEFULLNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedToEmployeeFullName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.AssignedToEmployeeFullName = reader.GetString(FLD_ASSIGNEDTOEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_SUPERVISORFULLNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorFullName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { oTIssueWithEmployeeandDateWise_RPTEntity.ProjectCode = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssueWithEmployeeandDateWise_RPTEntity.ProjectName = String.Empty; } else { oTIssueWithEmployeeandDateWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return oTIssueWithEmployeeandDateWise_RPTEntity;
        }
    }
}
