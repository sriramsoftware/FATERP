// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRDepartmentEmployeeMap_DetailedBuilder : IEntityBuilder<HRDepartmentEmployeeMap_DetailedEntity>
    {
        IList<HRDepartmentEmployeeMap_DetailedEntity> IEntityBuilder<HRDepartmentEmployeeMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRDepartmentEmployeeMap_DetailedEntity> HRDepartmentEmployeeMap_DetailedEntityList = new List<HRDepartmentEmployeeMap_DetailedEntity>();

            while (reader.Read())
            {
                HRDepartmentEmployeeMap_DetailedEntityList.Add(((IEntityBuilder<HRDepartmentEmployeeMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRDepartmentEmployeeMap_DetailedEntityList.Count > 0) ? HRDepartmentEmployeeMap_DetailedEntityList : null;
        }

        HRDepartmentEmployeeMap_DetailedEntity IEntityBuilder<HRDepartmentEmployeeMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEPARTMENTEMPLOYEEMAPID = 0;
            const Int32 FLD_DEPARTMENTID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_ISHEADOFDEPARTMENT = 3;
            const Int32 FLD_EMPLOYEEFULLNAME = 4;
            const Int32 FLD_DEPARTMENTCODE = 5;
            const Int32 FLD_ROWNUMBER = 6;

            HRDepartmentEmployeeMap_DetailedEntity hRDepartmentEmployeeMap_DetailedEntity = new HRDepartmentEmployeeMap_DetailedEntity();

            hRDepartmentEmployeeMap_DetailedEntity.DepartmentEmployeeMapID = reader.GetInt64(FLD_DEPARTMENTEMPLOYEEMAPID);
            hRDepartmentEmployeeMap_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            hRDepartmentEmployeeMap_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hRDepartmentEmployeeMap_DetailedEntity.IsHeadOfDepartment = reader.GetBoolean(FLD_ISHEADOFDEPARTMENT);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hRDepartmentEmployeeMap_DetailedEntity.EmployeeFullName = String.Empty; } else { hRDepartmentEmployeeMap_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hRDepartmentEmployeeMap_DetailedEntity.DepartmentCode = String.Empty; } else { hRDepartmentEmployeeMap_DetailedEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRDepartmentEmployeeMap_DetailedEntity.RowNumber = null; } else { hRDepartmentEmployeeMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hRDepartmentEmployeeMap_DetailedEntity;
        }
    }
}
