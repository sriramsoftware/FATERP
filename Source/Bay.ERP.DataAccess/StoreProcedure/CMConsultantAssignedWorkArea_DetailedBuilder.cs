// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 11:59:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantAssignedWorkArea_DetailedBuilder : IEntityBuilder<CMConsultantAssignedWorkArea_DetailedEntity>
    {
        IList<CMConsultantAssignedWorkArea_DetailedEntity> IEntityBuilder<CMConsultantAssignedWorkArea_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantAssignedWorkArea_DetailedEntity> CMConsultantAssignedWorkArea_DetailedEntityList = new List<CMConsultantAssignedWorkArea_DetailedEntity>();

            while (reader.Read())
            {
                CMConsultantAssignedWorkArea_DetailedEntityList.Add(((IEntityBuilder<CMConsultantAssignedWorkArea_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantAssignedWorkArea_DetailedEntityList.Count > 0) ? CMConsultantAssignedWorkArea_DetailedEntityList : null;
        }

        CMConsultantAssignedWorkArea_DetailedEntity IEntityBuilder<CMConsultantAssignedWorkArea_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTASSIGNEDWORKAREAID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_CONSULTANTWORKAREAID = 3;
            const Int32 FLD_WORKAREASTATUSID = 4;
            const Int32 FLD_STARTDATE = 5;
            const Int32 FLD_ENDDATE = 6;
            const Int32 FLD_ACTUALSTARTDATE = 7;
            const Int32 FLD_ACTUALENDDATE = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_CONSULTANTNAME = 10;
            const Int32 FLD_PROJECTNAME = 11;
            const Int32 FLD_CONSULTANTWORKAREANAME = 12;
            const Int32 FLD_WORKAREASTATUSNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            CMConsultantAssignedWorkArea_DetailedEntity cMConsultantAssignedWorkArea_DetailedEntity = new CMConsultantAssignedWorkArea_DetailedEntity();

            cMConsultantAssignedWorkArea_DetailedEntity.ConsultantAssignedWorkAreaID = reader.GetInt64(FLD_CONSULTANTASSIGNEDWORKAREAID);
            cMConsultantAssignedWorkArea_DetailedEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantAssignedWorkArea_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMConsultantAssignedWorkArea_DetailedEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);
            cMConsultantAssignedWorkArea_DetailedEntity.WorkAreaStatusID = reader.GetInt64(FLD_WORKAREASTATUSID);
            if (reader.IsDBNull(FLD_STARTDATE)) { cMConsultantAssignedWorkArea_DetailedEntity.StartDate = null; } else { cMConsultantAssignedWorkArea_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { cMConsultantAssignedWorkArea_DetailedEntity.EndDate = null; } else { cMConsultantAssignedWorkArea_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMConsultantAssignedWorkArea_DetailedEntity.ActualStartDate = null; } else { cMConsultantAssignedWorkArea_DetailedEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMConsultantAssignedWorkArea_DetailedEntity.ActualEndDate = null; } else { cMConsultantAssignedWorkArea_DetailedEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConsultantAssignedWorkArea_DetailedEntity.Remarks = String.Empty; } else { cMConsultantAssignedWorkArea_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_CONSULTANTNAME)) { cMConsultantAssignedWorkArea_DetailedEntity.ConsultantName = String.Empty; } else { cMConsultantAssignedWorkArea_DetailedEntity.ConsultantName = reader.GetString(FLD_CONSULTANTNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cMConsultantAssignedWorkArea_DetailedEntity.ProjectName = String.Empty; } else { cMConsultantAssignedWorkArea_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_CONSULTANTWORKAREANAME)) { cMConsultantAssignedWorkArea_DetailedEntity.ConsultantWorkAreaName = String.Empty; } else { cMConsultantAssignedWorkArea_DetailedEntity.ConsultantWorkAreaName = reader.GetString(FLD_CONSULTANTWORKAREANAME); }
            if (reader.IsDBNull(FLD_WORKAREASTATUSNAME)) { cMConsultantAssignedWorkArea_DetailedEntity.WorkAreaStatusName = String.Empty; } else { cMConsultantAssignedWorkArea_DetailedEntity.WorkAreaStatusName = reader.GetString(FLD_WORKAREASTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConsultantAssignedWorkArea_DetailedEntity.RowNumber = null; } else { cMConsultantAssignedWorkArea_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConsultantAssignedWorkArea_DetailedEntity;
        }
    }
}
