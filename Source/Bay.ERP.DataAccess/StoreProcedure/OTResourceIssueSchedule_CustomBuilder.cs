// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jun-2012, 11:27:18




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTResourceIssueSchedule_CustomBuilder : IEntityBuilder<OTResourceIssueSchedule_CustomEntity>
    {
        IList<OTResourceIssueSchedule_CustomEntity> IEntityBuilder<OTResourceIssueSchedule_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<OTResourceIssueSchedule_CustomEntity> OTResourceIssueSchedule_CustomEntityList = new List<OTResourceIssueSchedule_CustomEntity>();

            while (reader.Read())
            {
                OTResourceIssueSchedule_CustomEntityList.Add(((IEntityBuilder<OTResourceIssueSchedule_CustomEntity>)this).BuildEntity(reader));
            }

            return (OTResourceIssueSchedule_CustomEntityList.Count > 0) ? OTResourceIssueSchedule_CustomEntityList : null;
        }

        OTResourceIssueSchedule_CustomEntity IEntityBuilder<OTResourceIssueSchedule_CustomEntity>.BuildEntity(IDataReader reader)
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

            OTResourceIssueSchedule_CustomEntity oTResourceIssueSchedule_CustomEntity = new OTResourceIssueSchedule_CustomEntity();

            oTResourceIssueSchedule_CustomEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTResourceIssueSchedule_CustomEntity.IssueIdentityCategoryID = reader.GetInt64(FLD_ISSUEIDENTITYCATEGORYID);
            oTResourceIssueSchedule_CustomEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_PARENTISSUEID)) { oTResourceIssueSchedule_CustomEntity.ParentIssueID = null; } else { oTResourceIssueSchedule_CustomEntity.ParentIssueID = reader.GetInt64(FLD_PARENTISSUEID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTResourceIssueSchedule_CustomEntity.ReferenceID = null; } else { oTResourceIssueSchedule_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTResourceIssueSchedule_CustomEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { oTResourceIssueSchedule_CustomEntity.Description = String.Empty; } else { oTResourceIssueSchedule_CustomEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            oTResourceIssueSchedule_CustomEntity.IssuePriorityID = reader.GetInt64(FLD_ISSUEPRIORITYID);
            if (reader.IsDBNull(FLD_COMPLETIONPERCENTAGE)) { oTResourceIssueSchedule_CustomEntity.CompletionPercentage = null; } else { oTResourceIssueSchedule_CustomEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE); }
            oTResourceIssueSchedule_CustomEntity.IssueStatusID = reader.GetInt64(FLD_ISSUESTATUSID);
            oTResourceIssueSchedule_CustomEntity.CreatedByMemberID = reader.GetInt64(FLD_CREATEDBYMEMBERID);
            if (reader.IsDBNull(FLD_CREATEDATE)) { oTResourceIssueSchedule_CustomEntity.CreateDate = null; } else { oTResourceIssueSchedule_CustomEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE); }
            if (reader.IsDBNull(FLD_DURATION)) { oTResourceIssueSchedule_CustomEntity.Duration = null; } else { oTResourceIssueSchedule_CustomEntity.Duration = reader.GetDecimal(FLD_DURATION); }
            if (reader.IsDBNull(FLD_EXPECTEDSTARTDATE)) { oTResourceIssueSchedule_CustomEntity.ExpectedStartDate = null; } else { oTResourceIssueSchedule_CustomEntity.ExpectedStartDate = reader.GetDateTime(FLD_EXPECTEDSTARTDATE); }
            if (reader.IsDBNull(FLD_EXPECTEDENDDATE)) { oTResourceIssueSchedule_CustomEntity.ExpectedEndDate = null; } else { oTResourceIssueSchedule_CustomEntity.ExpectedEndDate = reader.GetDateTime(FLD_EXPECTEDENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { oTResourceIssueSchedule_CustomEntity.ActualStartDate = null; } else { oTResourceIssueSchedule_CustomEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { oTResourceIssueSchedule_CustomEntity.ActualEndDate = null; } else { oTResourceIssueSchedule_CustomEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_NOTIFYBEFOREMIN)) { oTResourceIssueSchedule_CustomEntity.NotifyBeforeMin = null; } else { oTResourceIssueSchedule_CustomEntity.NotifyBeforeMin = reader.GetInt32(FLD_NOTIFYBEFOREMIN); }
            oTResourceIssueSchedule_CustomEntity.IsNotifyCompleted = reader.GetBoolean(FLD_ISNOTIFYCOMPLETED);
            if (reader.IsDBNull(FLD_REMARKS)) { oTResourceIssueSchedule_CustomEntity.Remarks = String.Empty; } else { oTResourceIssueSchedule_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REFERENCEISSUEID)) { oTResourceIssueSchedule_CustomEntity.ReferenceIssueID = null; } else { oTResourceIssueSchedule_CustomEntity.ReferenceIssueID = reader.GetInt64(FLD_REFERENCEISSUEID); }

            return oTResourceIssueSchedule_CustomEntity;
        }
    }
}
