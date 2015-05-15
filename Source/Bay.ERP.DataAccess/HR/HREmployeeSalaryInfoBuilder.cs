// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSalaryInfoBuilder : IEntityBuilder<HREmployeeSalaryInfoEntity>
    {
        IList<HREmployeeSalaryInfoEntity> IEntityBuilder<HREmployeeSalaryInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryInfoEntity> HREmployeeSalaryInfoEntityList = new List<HREmployeeSalaryInfoEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryInfoEntityList.Add(((IEntityBuilder<HREmployeeSalaryInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryInfoEntityList.Count > 0) ? HREmployeeSalaryInfoEntityList : null;
        }

        HREmployeeSalaryInfoEntity IEntityBuilder<HREmployeeSalaryInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYINFOID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_ISDEPOSITE = 3;
            const Int32 FLD_SALARYAMOUNT = 4;
            const Int32 FLD_PAYCYCLEID = 5;
            const Int32 FLD_PAYSCALEID = 6;
            const Int32 FLD_EMPLOYEECODE = 7;
            const Int32 FLD_PROJECTID = 8;
            const Int32 FLD_DEPARTMENTID = 9;
            const Int32 FLD_DESIGNATIONID = 10;

            HREmployeeSalaryInfoEntity hREmployeeSalaryInfoEntity = new HREmployeeSalaryInfoEntity();

            hREmployeeSalaryInfoEntity.EmployeeSalaryInfoID = reader.GetInt64(FLD_EMPLOYEESALARYINFOID);
            hREmployeeSalaryInfoEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeSalaryInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryInfoEntity.IsDeposite = reader.GetBoolean(FLD_ISDEPOSITE);
            hREmployeeSalaryInfoEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT);
            if (reader.IsDBNull(FLD_PAYCYCLEID)) { hREmployeeSalaryInfoEntity.PayCycleID = null; } else { hREmployeeSalaryInfoEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID); }
            if (reader.IsDBNull(FLD_PAYSCALEID)) { hREmployeeSalaryInfoEntity.PayscaleID = null; } else { hREmployeeSalaryInfoEntity.PayscaleID = reader.GetInt64(FLD_PAYSCALEID); }
            hREmployeeSalaryInfoEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryInfoEntity.ProjectID = null; } else { hREmployeeSalaryInfoEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeSalaryInfoEntity.DepartmentID = null; } else { hREmployeeSalaryInfoEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryInfoEntity.DesignationID = null; } else { hREmployeeSalaryInfoEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }

            return hREmployeeSalaryInfoEntity;
        }
    }
}
