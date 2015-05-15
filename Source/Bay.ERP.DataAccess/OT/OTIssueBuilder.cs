// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Aug-2013, 04:20:37

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
    internal sealed class OTIssueBuilder : IEntityBuilder<OTIssueEntity>
    {
        IList<OTIssueEntity> IEntityBuilder<OTIssueEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueEntity> OTIssueEntityList = new List<OTIssueEntity>();

            while (reader.Read())
            {
                OTIssueEntityList.Add(((IEntityBuilder<OTIssueEntity>)this).BuildEntity(reader));
            }

            return (OTIssueEntityList.Count > 0) ? OTIssueEntityList : null;
        }

        OTIssueEntity IEntityBuilder<OTIssueEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_SUPERVISOREMPLOYEEID = 19;
            const Int32 FLD_ASSIGNEDTOEMPLOYEEID = 20;
            const Int32 FLD_REMARKS = 21;
            const Int32 FLD_REFERENCEISSUEID = 22;
            const Int32 FLD_ISREMOVED = 23;
            const Int32 FLD_SUPERVISORAGREED = 24;
            const Int32 FLD_MODIFIEDBYSUPERVISORDATETIME = 25;
            const Int32 FLD_IP = 26;
            const Int32 FLD_DTLDURATION = 27;
            const Int32 FLD_PROJECTID = 28;
            const Int32 FLD_PROJECTFLOORID = 29;
            const Int32 FLD_PROJECTFLOORUNITID = 30;
            const Int32 FLD_PROJECTFLOORUNITLOCATIONID = 31;

            OTIssueEntity oTIssueEntity = new OTIssueEntity();

            oTIssueEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssueEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTIssueEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTIssueEntity.ParentIssueID = null; } else { oTIssueEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssueEntity.ReferenceID = null; } else { oTIssueEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssueEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTIssueEntity.Description = String.Empty; } else { oTIssueEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTIssueEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTIssueEntity.CompletionPercentage = null; } else { oTIssueEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTIssueEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTIssueEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTIssueEntity.CreateDate = null; } else { oTIssueEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTIssueEntity.Duration = null; } else { oTIssueEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTIssueEntity.ExpectedStartDate = null; } else { oTIssueEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTIssueEntity.ExpectedEndDate = null; } else { oTIssueEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTIssueEntity.ActualStartDate = null; } else { oTIssueEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTIssueEntity.ActualEndDate = null; } else { oTIssueEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTIssueEntity.NotifyBeforeMin = null; } else { oTIssueEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTIssueEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            oTIssueEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            oTIssueEntity.AssignedToEmployeeID = reader.GetInt64(FLD_ASSIGNEDTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_REMARKS)) { oTIssueEntity.Remarks = String.Empty; } else { oTIssueEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTIssueEntity.ReferenceIssueID = null; } else { oTIssueEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }
            oTIssueEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            oTIssueEntity.SupervisorAgreed = reader.GetBoolean(FLD_SUPERVISORAGREED);
            oTIssueEntity.ModifiedBySupervisorDateTime = reader.GetDateTime(FLD_MODIFIEDBYSUPERVISORDATETIME);
            if (reader.IsDBNull(FLD_IP)) { oTIssueEntity.IP = String.Empty; } else { oTIssueEntity.IP = reader.GetString(FLD_IP); }
           // if (reader.IsDBNull(FLD_DTLDURATION)) { oTIssueEntity.DTLDuration = null; } else { oTIssueEntity.DTLDuration = ((SqlDataReader)reader).GetTimeSpan(FLD_DTLDURATION); }
            if (reader.IsDBNull(FLD_PROJECTID)) { oTIssueEntity.ProjectID = null; } else { oTIssueEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORID)) { oTIssueEntity.ProjectFloorID = null; } else { oTIssueEntity.ProjectFloorID = reader.GetInt64(FLD_PROJECTFLOORID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { oTIssueEntity.ProjectFloorUnitID = null; } else { oTIssueEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITLOCATIONID)) { oTIssueEntity.ProjectFloorUnitLocationID = null; } else { oTIssueEntity.ProjectFloorUnitLocationID = reader.GetInt64(FLD_PROJECTFLOORUNITLOCATIONID); }

            return oTIssueEntity;
        }
    }
}
