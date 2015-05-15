// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Jan-2014, 04:17:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMonthlySalaryPayment_CustomBuilder : IEntityBuilder<HRMonthlySalaryPayment_CustomEntity>
    {
        IList<HRMonthlySalaryPayment_CustomEntity> IEntityBuilder<HRMonthlySalaryPayment_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMonthlySalaryPayment_CustomEntity> HRMonthlySalaryPayment_CustomEntityList = new List<HRMonthlySalaryPayment_CustomEntity>();

            while (reader.Read())
            {
                HRMonthlySalaryPayment_CustomEntityList.Add(((IEntityBuilder<HRMonthlySalaryPayment_CustomEntity>)this).BuildEntity(reader));
            }

            return (HRMonthlySalaryPayment_CustomEntityList.Count > 0) ? HRMonthlySalaryPayment_CustomEntityList : null;
        }

        HRMonthlySalaryPayment_CustomEntity IEntityBuilder<HRMonthlySalaryPayment_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYSESSIONID = 0;
            const Int32 FLD_FISCALYEARID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_SESSIONSTARTDATE = 3;
            const Int32 FLD_SESSIONENDDATE = 4;
            const Int32 FLD_REMARKS = 5;
            const Int32 FLD_SALARYSESSIONSTATUSID = 6;
            const Int32 FLD_ISCURRENTSESSION = 7;
            const Int32 FLD_EMPLOYEEID = 8;
            const Int32 FLD_FIRSTNAME = 9;
            const Int32 FLD_MIDDLENAME = 10;
            const Int32 FLD_LASTNAME = 11;
            const Int32 FLD_SALARYAMOUNT = 12;
            const Int32 FLD_ACTUALWORKDAYS = 13;
            const Int32 FLD_MEMBERID = 14;
            const Int32 FLD_EMPLOYMENTSTATUSID = 15;
            const Int32 FLD_PROJECTID = 16;
            const Int32 FLD_PROJECTCODE = 17;
            const Int32 FLD_PROJECTNAME = 18;
            const Int32 FLD_DEPARTMENTCODE = 19;
            const Int32 FLD_DEPARTMENTNAME = 20;
            const Int32 FLD_DESIGNATIONNAME = 21;
            const Int32 FLD_DEPARTMENTID = 22;
            const Int32 FLD_DESIGNATIONID = 23;
            const Int32 FLD_EMPLOYEECODE = 24;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 25;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 26;
            const Int32 FLD_SALARYLEVEL= 27;
            const Int32 FLD_SERVICEDAYS = 28;

            HRMonthlySalaryPayment_CustomEntity hRMonthlySalaryPayment_CustomEntity = new HRMonthlySalaryPayment_CustomEntity();

            hRMonthlySalaryPayment_CustomEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hRMonthlySalaryPayment_CustomEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRMonthlySalaryPayment_CustomEntity.Name = reader.GetString(FLD_NAME);
            hRMonthlySalaryPayment_CustomEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            hRMonthlySalaryPayment_CustomEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { hRMonthlySalaryPayment_CustomEntity.Remarks = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hRMonthlySalaryPayment_CustomEntity.SalarySessionStatusID = reader.GetInt64(FLD_SALARYSESSIONSTATUSID);
            hRMonthlySalaryPayment_CustomEntity.IsCurrentSession = reader.GetBoolean(FLD_ISCURRENTSESSION);
            hRMonthlySalaryPayment_CustomEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hRMonthlySalaryPayment_CustomEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hRMonthlySalaryPayment_CustomEntity.MiddleName = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hRMonthlySalaryPayment_CustomEntity.LastName = reader.GetString(FLD_LASTNAME);
            hRMonthlySalaryPayment_CustomEntity.SalaryAmount = reader.GetDecimal(FLD_SALARYAMOUNT);
            hRMonthlySalaryPayment_CustomEntity.ACTUALWORKDAYS = reader.GetDecimal(FLD_ACTUALWORKDAYS);
            hRMonthlySalaryPayment_CustomEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            if (reader.IsDBNull(FLD_EMPLOYMENTSTATUSID)) { hRMonthlySalaryPayment_CustomEntity.EmploymentStatusID = null; } else { hRMonthlySalaryPayment_CustomEntity.EmploymentStatusID = reader.GetInt64(FLD_EMPLOYMENTSTATUSID); }
            if (reader.IsDBNull(FLD_PROJECTID)) { hRMonthlySalaryPayment_CustomEntity.ProjectID = null; } else { hRMonthlySalaryPayment_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hRMonthlySalaryPayment_CustomEntity.ProjectCode = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hRMonthlySalaryPayment_CustomEntity.ProjectName = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            //hRMonthlySalaryPayment_CustomEntity.DepartmentCode = reader.GetString(FLD_DEPARTMENTCODE);
            //hRMonthlySalaryPayment_CustomEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME);
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hRMonthlySalaryPayment_CustomEntity.DesignationName = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hRMonthlySalaryPayment_CustomEntity.DepartmentID = null; } else { hRMonthlySalaryPayment_CustomEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hRMonthlySalaryPayment_CustomEntity.DesignationID = null; } else { hRMonthlySalaryPayment_CustomEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hRMonthlySalaryPayment_CustomEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            hRMonthlySalaryPayment_CustomEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_EMPLOYEEJOBTYPENAME)) { hRMonthlySalaryPayment_CustomEntity.EmployeeJobTypeName = String.Empty; } else { hRMonthlySalaryPayment_CustomEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME); }
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hRMonthlySalaryPayment_CustomEntity.SalaryLevel = null; } else { hRMonthlySalaryPayment_CustomEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_SERVICEDAYS)) { hRMonthlySalaryPayment_CustomEntity.ServiceDays = null; } else { hRMonthlySalaryPayment_CustomEntity.ServiceDays = reader.GetInt32(FLD_SERVICEDAYS); }

            return hRMonthlySalaryPayment_CustomEntity;
        }
    }
}
