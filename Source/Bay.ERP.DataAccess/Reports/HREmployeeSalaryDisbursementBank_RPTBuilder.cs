// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 11:29:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSalaryDisbursementBank_RPTBuilder : IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>
    {
        IList<HREmployeeSalaryDisbursementBank_RPTEntity> IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryDisbursementBank_RPTEntity> HREmployeeSalaryDisbursementBank_RPTEntityList = new List<HREmployeeSalaryDisbursementBank_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryDisbursementBank_RPTEntityList.Add(((IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryDisbursementBank_RPTEntityList.Count > 0) ? HREmployeeSalaryDisbursementBank_RPTEntityList : null;
        }

        HREmployeeSalaryDisbursementBank_RPTEntity IEntityBuilder<HREmployeeSalaryDisbursementBank_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEID = 0;
            const Int32 FLD_PROJECTID = 1;
            const Int32 FLD_DESIGNATIONID = 2;
            const Int32 FLD_EMPLOYEECODE = 3;
            const Int32 FLD_EMPLOYEEFULLNAME = 4;
            const Int32 FLD_PROJECTCODE = 5;
            const Int32 FLD_PROJECTNAME = 6;
            const Int32 FLD_DEPARTMENTCODE = 7;
            const Int32 FLD_DESIGNATIONNAME = 8;
            const Int32 FLD_BANKACCOUNTNO = 9;
            const Int32 FLD_SESSIONSTARTDATE = 10;
            const Int32 FLD_SESSIONENDDATE = 11;
            const Int32 FLD_SALARYAMOUNT = 12;


            HREmployeeSalaryDisbursementBank_RPTEntity hREmployeeSalaryDisbursementBank_RPTEntity = new HREmployeeSalaryDisbursementBank_RPTEntity();

            hREmployeeSalaryDisbursementBank_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectID = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryDisbursementBank_RPTEntity.DesignationID = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeSalaryDisbursementBank_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hREmployeeSalaryDisbursementBank_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectCode = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectName = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTCODE)) { hREmployeeSalaryDisbursementBank_RPTEntity.DepartmentCode = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeSalaryDisbursementBank_RPTEntity.DesignationName = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTNO)) { hREmployeeSalaryDisbursementBank_RPTEntity.BankAccountNo = null; } else { hREmployeeSalaryDisbursementBank_RPTEntity.BankAccountNo = reader.GetString(FLD_BANKACCOUNTNO); }
            hREmployeeSalaryDisbursementBank_RPTEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            hREmployeeSalaryDisbursementBank_RPTEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            hREmployeeSalaryDisbursementBank_RPTEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT);

            return hREmployeeSalaryDisbursementBank_RPTEntity;
        }
    }
}
