// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRDepartmentEmployeeMapBuilder : IEntityBuilder<HRDepartmentEmployeeMapEntity>
    {
        IList<HRDepartmentEmployeeMapEntity> IEntityBuilder<HRDepartmentEmployeeMapEntity>.BuildEntities(IDataReader reader)
        {
            List<HRDepartmentEmployeeMapEntity> HRDepartmentEmployeeMapEntityList = new List<HRDepartmentEmployeeMapEntity>();

            while (reader.Read())
            {
                HRDepartmentEmployeeMapEntityList.Add(((IEntityBuilder<HRDepartmentEmployeeMapEntity>)this).BuildEntity(reader));
            }

            return (HRDepartmentEmployeeMapEntityList.Count > 0) ? HRDepartmentEmployeeMapEntityList : null;
        }

        HRDepartmentEmployeeMapEntity IEntityBuilder<HRDepartmentEmployeeMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEPARTMENTEMPLOYEEMAPID = 0;
            const Int32 FLD_DEPARTMENTID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_ISHEADOFDEPARTMENT = 3;

            HRDepartmentEmployeeMapEntity hRDepartmentEmployeeMapEntity = new HRDepartmentEmployeeMapEntity();

            hRDepartmentEmployeeMapEntity.DepartmentEmployeeMapID = reader.GetInt64(FLD_DEPARTMENTEMPLOYEEMAPID);
            hRDepartmentEmployeeMapEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            hRDepartmentEmployeeMapEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hRDepartmentEmployeeMapEntity.IsHeadOfDepartment = reader.GetBoolean(FLD_ISHEADOFDEPARTMENT);

            return hRDepartmentEmployeeMapEntity;
        }
    }
}
