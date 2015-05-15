// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantAssignedWorkAreaBuilder : IEntityBuilder<CMConsultantAssignedWorkAreaEntity>
    {
        IList<CMConsultantAssignedWorkAreaEntity> IEntityBuilder<CMConsultantAssignedWorkAreaEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantAssignedWorkAreaEntity> CMConsultantAssignedWorkAreaEntityList = new List<CMConsultantAssignedWorkAreaEntity>();

            while (reader.Read())
            {
                CMConsultantAssignedWorkAreaEntityList.Add(((IEntityBuilder<CMConsultantAssignedWorkAreaEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantAssignedWorkAreaEntityList.Count > 0) ? CMConsultantAssignedWorkAreaEntityList : null;
        }

        CMConsultantAssignedWorkAreaEntity IEntityBuilder<CMConsultantAssignedWorkAreaEntity>.BuildEntity(IDataReader reader)
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

            CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity = new CMConsultantAssignedWorkAreaEntity();

            cMConsultantAssignedWorkAreaEntity.ConsultantAssignedWorkAreaID = reader.GetInt64(FLD_CONSULTANTASSIGNEDWORKAREAID);
            cMConsultantAssignedWorkAreaEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantAssignedWorkAreaEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMConsultantAssignedWorkAreaEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);
            cMConsultantAssignedWorkAreaEntity.WorkAreaStatusID = reader.GetInt64(FLD_WORKAREASTATUSID);
            if (reader.IsDBNull(FLD_STARTDATE)) { cMConsultantAssignedWorkAreaEntity.StartDate = null; } else { cMConsultantAssignedWorkAreaEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { cMConsultantAssignedWorkAreaEntity.EndDate = null; } else { cMConsultantAssignedWorkAreaEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMConsultantAssignedWorkAreaEntity.ActualStartDate = null; } else { cMConsultantAssignedWorkAreaEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMConsultantAssignedWorkAreaEntity.ActualEndDate = null; } else { cMConsultantAssignedWorkAreaEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConsultantAssignedWorkAreaEntity.Remarks = String.Empty; } else { cMConsultantAssignedWorkAreaEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cMConsultantAssignedWorkAreaEntity;
        }
    }
}
