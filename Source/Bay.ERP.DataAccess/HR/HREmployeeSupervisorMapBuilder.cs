// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:37:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSupervisorMapBuilder : IEntityBuilder<HREmployeeSupervisorMapEntity>
    {
        IList<HREmployeeSupervisorMapEntity> IEntityBuilder<HREmployeeSupervisorMapEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSupervisorMapEntity> HREmployeeSupervisorMapEntityList = new List<HREmployeeSupervisorMapEntity>();

            while (reader.Read())
            {
                HREmployeeSupervisorMapEntityList.Add(((IEntityBuilder<HREmployeeSupervisorMapEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSupervisorMapEntityList.Count > 0) ? HREmployeeSupervisorMapEntityList : null;
        }

        HREmployeeSupervisorMapEntity IEntityBuilder<HREmployeeSupervisorMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESUPERVISORMAPID = 0;
            const Int32 FLD_SESSIONCATEGORYID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_EMPLOYEECODE = 3;
            const Int32 FLD_SUPERVISORTYPEID = 4;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 5;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_CREATEDATE = 8;

            HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity = new HREmployeeSupervisorMapEntity();

            hREmployeeSupervisorMapEntity.EmployeeSupervisorMapID = reader.GetInt64(FLD_EMPLOYEESUPERVISORMAPID);
            hREmployeeSupervisorMapEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            hREmployeeSupervisorMapEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSupervisorMapEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeSupervisorMapEntity.SupervisorTypeID = reader.GetInt64(FLD_SUPERVISORTYPEID);
            hREmployeeSupervisorMapEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            hREmployeeSupervisorMapEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeSupervisorMapEntity.Remarks = String.Empty; } else { hREmployeeSupervisorMapEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeSupervisorMapEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return hREmployeeSupervisorMapEntity;
        }
    }
}
