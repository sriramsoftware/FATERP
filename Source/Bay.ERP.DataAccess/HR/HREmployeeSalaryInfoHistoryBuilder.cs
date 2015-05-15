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
    internal sealed class HREmployeeSalaryInfoHistoryBuilder : IEntityBuilder<HREmployeeSalaryInfoHistoryEntity>
    {
        IList<HREmployeeSalaryInfoHistoryEntity> IEntityBuilder<HREmployeeSalaryInfoHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryInfoHistoryEntity> HREmployeeSalaryInfoHistoryEntityList = new List<HREmployeeSalaryInfoHistoryEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryInfoHistoryEntityList.Add(((IEntityBuilder<HREmployeeSalaryInfoHistoryEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryInfoHistoryEntityList.Count > 0) ? HREmployeeSalaryInfoHistoryEntityList : null;
        }

        HREmployeeSalaryInfoHistoryEntity IEntityBuilder<HREmployeeSalaryInfoHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYINFOHISTORYID = 0;
            const Int32 FLD_EMPLOYEESALARYINFOID = 1;
            const Int32 FLD_DESIGNATIONID = 2;
            const Int32 FLD_FISCALYEARID = 3;
            const Int32 FLD_SALARYSESSIONID = 4;
            const Int32 FLD_EMPLOYEEID = 5;
            const Int32 FLD_ISDEPOSITE = 6;
            const Int32 FLD_SALARYAMOUNT = 7;
            const Int32 FLD_PAYCYCLEID = 8;
            const Int32 FLD_PAYSCALEID = 9;
            const Int32 FLD_EMPLOYEECODE = 10;
            const Int32 FLD_PROJECTID = 11;
            const Int32 FLD_DEPARTMENTID = 12;
            const Int32 FLD_CREATEDATE = 13;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 14;

            HREmployeeSalaryInfoHistoryEntity hREmployeeSalaryInfoHistoryEntity = new HREmployeeSalaryInfoHistoryEntity();

            hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoHistoryID = reader.GetInt64(FLD_EMPLOYEESALARYINFOHISTORYID);
            hREmployeeSalaryInfoHistoryEntity.EmployeeSalaryInfoID = reader.GetInt64(FLD_EMPLOYEESALARYINFOID);
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryInfoHistoryEntity.DesignationID = null; } else { hREmployeeSalaryInfoHistoryEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeSalaryInfoHistoryEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeSalaryInfoHistoryEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeSalaryInfoHistoryEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryInfoHistoryEntity.IsDeposite = reader.GetBoolean(FLD_ISDEPOSITE);
            hREmployeeSalaryInfoHistoryEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT);
            if (reader.IsDBNull(FLD_PAYCYCLEID)) { hREmployeeSalaryInfoHistoryEntity.PayCycleID = null; } else { hREmployeeSalaryInfoHistoryEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID); }
            if (reader.IsDBNull(FLD_PAYSCALEID)) { hREmployeeSalaryInfoHistoryEntity.PayscaleID = null; } else { hREmployeeSalaryInfoHistoryEntity.PayscaleID = reader.GetInt64(FLD_PAYSCALEID); }
            hREmployeeSalaryInfoHistoryEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryInfoHistoryEntity.ProjectID = null; } else { hREmployeeSalaryInfoHistoryEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeSalaryInfoHistoryEntity.DepartmentID = null; } else { hREmployeeSalaryInfoHistoryEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            hREmployeeSalaryInfoHistoryEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            hREmployeeSalaryInfoHistoryEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return hREmployeeSalaryInfoHistoryEntity;
        }
    }
}
