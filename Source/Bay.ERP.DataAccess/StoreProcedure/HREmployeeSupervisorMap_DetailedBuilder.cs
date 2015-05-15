// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSupervisorMap_DetailedBuilder : IEntityBuilder<HREmployeeSupervisorMap_DetailedEntity>
    {
        IList<HREmployeeSupervisorMap_DetailedEntity> IEntityBuilder<HREmployeeSupervisorMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSupervisorMap_DetailedEntity> HREmployeeSupervisorMap_DetailedEntityList = new List<HREmployeeSupervisorMap_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeSupervisorMap_DetailedEntityList.Add(((IEntityBuilder<HREmployeeSupervisorMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSupervisorMap_DetailedEntityList.Count > 0) ? HREmployeeSupervisorMap_DetailedEntityList : null;
        }

        HREmployeeSupervisorMap_DetailedEntity IEntityBuilder<HREmployeeSupervisorMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESUPERFVISORMAPID = 0;
            const Int32 FLD_SESSIONCATEGORYID = 1;
            const Int32 FLD_SESSIONCATEGORYNAME = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_EMPLOYEECODE = 4;
            const Int32 FLD_EMPLOYEEFULLNAME = 5;
            const Int32 FLD_SUPERVISORTYPEID = 6;
            const Int32 FLD_SUPERVISORTYPENAME = 7;
            const Int32 FLD_SUPERVISOREMPLOYEEID = 8;
            const Int32 FLD_SUPERVISOREMPLOYEECODE = 9;
            const Int32 FLD_SUPERVISORFULLNAME = 10;
            const Int32 FLD_REMARKS = 11;
            const Int32 FLD_CREATEDATE = 12;
            const Int32 FLD_ROWNUMBER = 13;

            HREmployeeSupervisorMap_DetailedEntity aHREmployeeSupervisorMap_DetailedEntity = new HREmployeeSupervisorMap_DetailedEntity();

            aHREmployeeSupervisorMap_DetailedEntity.EmployeeSupervisorMapID = reader.GetInt64(FLD_EMPLOYEESUPERFVISORMAPID);
            aHREmployeeSupervisorMap_DetailedEntity.SessionCategoryID = reader.GetInt64(FLD_SESSIONCATEGORYID);
            aHREmployeeSupervisorMap_DetailedEntity.SessionCategoryName = reader.GetString(FLD_SESSIONCATEGORYNAME);
            aHREmployeeSupervisorMap_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aHREmployeeSupervisorMap_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            aHREmployeeSupervisorMap_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            aHREmployeeSupervisorMap_DetailedEntity.SupervisorTypeID = reader.GetInt64(FLD_SUPERVISORTYPEID);
            aHREmployeeSupervisorMap_DetailedEntity.SupervisorTypeName = reader.GetString(FLD_SUPERVISORTYPENAME);
            aHREmployeeSupervisorMap_DetailedEntity.SupervisorEmployeeID = reader.GetInt64(FLD_SUPERVISOREMPLOYEEID);
            aHREmployeeSupervisorMap_DetailedEntity.SupervisorEmployeeCode = reader.GetString(FLD_SUPERVISOREMPLOYEECODE);
            aHREmployeeSupervisorMap_DetailedEntity.SupervisorFullName = reader.GetString(FLD_SUPERVISORFULLNAME);
            aHREmployeeSupervisorMap_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS);
            aHREmployeeSupervisorMap_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aHREmployeeSupervisorMap_DetailedEntity.RowNumber = null; } else { aHREmployeeSupervisorMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aHREmployeeSupervisorMap_DetailedEntity;
        }
    }
}
