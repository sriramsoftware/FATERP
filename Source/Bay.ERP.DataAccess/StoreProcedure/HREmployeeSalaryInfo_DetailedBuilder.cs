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
    internal sealed class HREmployeeSalaryInfo_DetailedBuilder : IEntityBuilder<HREmployeeSalaryInfo_DetailedEntity>
    {
        IList<HREmployeeSalaryInfo_DetailedEntity> IEntityBuilder<HREmployeeSalaryInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryInfo_DetailedEntity> HREmployeeSalaryInfo_DetailedEntityList = new List<HREmployeeSalaryInfo_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryInfo_DetailedEntityList.Add(((IEntityBuilder<HREmployeeSalaryInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryInfo_DetailedEntityList.Count > 0) ? HREmployeeSalaryInfo_DetailedEntityList : null;
        }

        HREmployeeSalaryInfo_DetailedEntity IEntityBuilder<HREmployeeSalaryInfo_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_FISCALYEARBEGINDATE = 11;
            const Int32 FLD_FISCALYEARENDDATE = 12;
            const Int32 FLD_EMPLOYEEFULLNAME = 13;
            const Int32 FLD_PAYCYCLENAME = 14;
            const Int32 FLD_PAYSCALENAME = 15;
            const Int32 FLD_PROJECTNAME = 16;
            const Int32 FLD_PROJECTCODE = 17;
            const Int32 FLD_DEPARTMENTCODE = 18;
            const Int32 FLD_DESIGNAITONNAME = 19;

            HREmployeeSalaryInfo_DetailedEntity hREmployeeSalaryInfo_DetailedEntity = new HREmployeeSalaryInfo_DetailedEntity();

            hREmployeeSalaryInfo_DetailedEntity.EmployeeSalaryInfoID = reader.GetInt64(FLD_EMPLOYEESALARYINFOID);
            hREmployeeSalaryInfo_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeSalaryInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryInfo_DetailedEntity.IsDeposite = reader.GetBoolean(FLD_ISDEPOSITE);
            hREmployeeSalaryInfo_DetailedEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT);
            if (reader.IsDBNull(FLD_PAYCYCLEID)) { hREmployeeSalaryInfo_DetailedEntity.PayCycleID = null; } else { hREmployeeSalaryInfo_DetailedEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID); }
            if (reader.IsDBNull(FLD_PAYSCALEID)) { hREmployeeSalaryInfo_DetailedEntity.PayscaleID = null; } else { hREmployeeSalaryInfo_DetailedEntity.PayscaleID = reader.GetInt64(FLD_PAYSCALEID); }
            hREmployeeSalaryInfo_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryInfo_DetailedEntity.ProjectID = null; } else { hREmployeeSalaryInfo_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeSalaryInfo_DetailedEntity.DepartmentID = null; } else { hREmployeeSalaryInfo_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryInfo_DetailedEntity.DesignationID = null; } else { hREmployeeSalaryInfo_DetailedEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeSalaryInfo_DetailedEntity.FiscalYearBeginDate = reader.GetDateTime(FLD_FISCALYEARBEGINDATE);
            hREmployeeSalaryInfo_DetailedEntity.FiscalYearEndDate = reader.GetDateTime(FLD_FISCALYEARENDDATE);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeSalaryInfo_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PAYCYCLENAME)) { hREmployeeSalaryInfo_DetailedEntity.PayCycleName = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.PayCycleName = reader.GetString(FLD_PAYCYCLENAME); }
            if (reader.IsDBNull(FLD_PAYSCALENAME)) { hREmployeeSalaryInfo_DetailedEntity.PayscaleName = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.PayscaleName = reader.GetString(FLD_PAYSCALENAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeSalaryInfo_DetailedEntity.ProjectName = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeSalaryInfo_DetailedEntity.ProjectCode = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeSalaryInfo_DetailedEntity.DepartmentCode = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_DESIGNAITONNAME)) { hREmployeeSalaryInfo_DetailedEntity.DesignaitonName = String.Empty; } else { hREmployeeSalaryInfo_DetailedEntity.DesignaitonName = reader.GetString(FLD_DESIGNAITONNAME); }

            return hREmployeeSalaryInfo_DetailedEntity;
        }
    }
}
