// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorAssignedWorkAreaBuilder : IEntityBuilder<CMContractorAssignedWorkAreaEntity>
    {
        IList<CMContractorAssignedWorkAreaEntity> IEntityBuilder<CMContractorAssignedWorkAreaEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorAssignedWorkAreaEntity> CMContractorAssignedWorkAreaEntityList = new List<CMContractorAssignedWorkAreaEntity>();

            while (reader.Read())
            {
                CMContractorAssignedWorkAreaEntityList.Add(((IEntityBuilder<CMContractorAssignedWorkAreaEntity>)this).BuildEntity(reader));
            }

            return (CMContractorAssignedWorkAreaEntityList.Count > 0) ? CMContractorAssignedWorkAreaEntityList : null;
        }

        CMContractorAssignedWorkAreaEntity IEntityBuilder<CMContractorAssignedWorkAreaEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORASSIGNEDWORKAREAID = 0;
            const Int32 FLD_CONTRACTORID = 1;
            const Int32 FLD_PROJECTID = 2;
            const Int32 FLD_WORKDESCRIPTION = 3;
            const Int32 FLD_WORKAREASTATUSID = 4;
            const Int32 FLD_STARTDATE = 5;
            const Int32 FLD_ENDDATE = 6;
            const Int32 FLD_ACTUALSTARTDATE = 7;
            const Int32 FLD_ACTUALENDDATE = 8;
            const Int32 FLD_REMARKS = 9;

            CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity = new CMContractorAssignedWorkAreaEntity();

            cMContractorAssignedWorkAreaEntity.ContractorAssignedWorkAreaID = reader.GetInt64(FLD_CONTRACTORASSIGNEDWORKAREAID);
            cMContractorAssignedWorkAreaEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorAssignedWorkAreaEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMContractorAssignedWorkAreaEntity.WorkDescription = reader.GetString(FLD_WORKDESCRIPTION);
            cMContractorAssignedWorkAreaEntity.WorkAreaStatusID = reader.GetInt64(FLD_WORKAREASTATUSID);
            if (reader.IsDBNull(FLD_STARTDATE)) { cMContractorAssignedWorkAreaEntity.StartDate = null; } else { cMContractorAssignedWorkAreaEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { cMContractorAssignedWorkAreaEntity.EndDate = null; } else { cMContractorAssignedWorkAreaEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMContractorAssignedWorkAreaEntity.ActualStartDate = null; } else { cMContractorAssignedWorkAreaEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMContractorAssignedWorkAreaEntity.ActualEndDate = null; } else { cMContractorAssignedWorkAreaEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMContractorAssignedWorkAreaEntity.Remarks = String.Empty; } else { cMContractorAssignedWorkAreaEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cMContractorAssignedWorkAreaEntity;
        }
    }
}
