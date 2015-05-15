// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Nov-2012, 03:38:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractorAssignedWorkArea_DetailedBuilder : IEntityBuilder<CMContractorAssignedWorkArea_DetailedEntity>
    {
        IList<CMContractorAssignedWorkArea_DetailedEntity> IEntityBuilder<CMContractorAssignedWorkArea_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractorAssignedWorkArea_DetailedEntity> CMContractorAssignedWorkArea_DetailedEntityList = new List<CMContractorAssignedWorkArea_DetailedEntity>();

            while (reader.Read())
            {
                CMContractorAssignedWorkArea_DetailedEntityList.Add(((IEntityBuilder<CMContractorAssignedWorkArea_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMContractorAssignedWorkArea_DetailedEntityList.Count > 0) ? CMContractorAssignedWorkArea_DetailedEntityList : null;
        }

        CMContractorAssignedWorkArea_DetailedEntity IEntityBuilder<CMContractorAssignedWorkArea_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_CONTRACTORNAME = 10;
            const Int32 FLD_PROJECTNAME = 11;
            const Int32 FLD_WORKAREASTATUSNAME = 12;
            const Int32 FLD_ROWNUMBER = 13;

            CMContractorAssignedWorkArea_DetailedEntity cMContractorAssignedWorkArea_DetailedEntity = new CMContractorAssignedWorkArea_DetailedEntity();

            cMContractorAssignedWorkArea_DetailedEntity.ContractorAssignedWorkAreaID = reader.GetInt64(FLD_CONTRACTORASSIGNEDWORKAREAID);
            cMContractorAssignedWorkArea_DetailedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractorAssignedWorkArea_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMContractorAssignedWorkArea_DetailedEntity.WorkDescription = reader.GetString(FLD_WORKDESCRIPTION);
            cMContractorAssignedWorkArea_DetailedEntity.WorkAreaStatusID = reader.GetInt64(FLD_WORKAREASTATUSID);
            if (reader.IsDBNull(FLD_STARTDATE)) { cMContractorAssignedWorkArea_DetailedEntity.StartDate = null; } else { cMContractorAssignedWorkArea_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { cMContractorAssignedWorkArea_DetailedEntity.EndDate = null; } else { cMContractorAssignedWorkArea_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ACTUALSTARTDATE)) { cMContractorAssignedWorkArea_DetailedEntity.ActualStartDate = null; } else { cMContractorAssignedWorkArea_DetailedEntity.ActualStartDate = reader.GetDateTime(FLD_ACTUALSTARTDATE); }
            if (reader.IsDBNull(FLD_ACTUALENDDATE)) { cMContractorAssignedWorkArea_DetailedEntity.ActualEndDate = null; } else { cMContractorAssignedWorkArea_DetailedEntity.ActualEndDate = reader.GetDateTime(FLD_ACTUALENDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMContractorAssignedWorkArea_DetailedEntity.Remarks = String.Empty; } else { cMContractorAssignedWorkArea_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_CONTRACTORNAME)) { cMContractorAssignedWorkArea_DetailedEntity.ContractorName = String.Empty; } else { cMContractorAssignedWorkArea_DetailedEntity.ContractorName = reader.GetString(FLD_CONTRACTORNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cMContractorAssignedWorkArea_DetailedEntity.ProjectName = String.Empty; } else { cMContractorAssignedWorkArea_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_WORKAREASTATUSNAME)) { cMContractorAssignedWorkArea_DetailedEntity.WorkAreaStatusName = String.Empty; } else { cMContractorAssignedWorkArea_DetailedEntity.WorkAreaStatusName = reader.GetString(FLD_WORKAREASTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMContractorAssignedWorkArea_DetailedEntity.RowNumber = null; } else { cMContractorAssignedWorkArea_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMContractorAssignedWorkArea_DetailedEntity;
        }
    }
}
