// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeSalaryPayment_RPTBuilder : IEntityBuilder<HREmployeeSalaryPayment_RPTEntity>
    {
        IList<HREmployeeSalaryPayment_RPTEntity> IEntityBuilder<HREmployeeSalaryPayment_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryPayment_RPTEntity> HREmployeeSalaryPayment_RPTEntityList = new List<HREmployeeSalaryPayment_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryPayment_RPTEntityList.Add(((IEntityBuilder<HREmployeeSalaryPayment_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryPayment_RPTEntityList.Count > 0) ? HREmployeeSalaryPayment_RPTEntityList : null;
        }

        HREmployeeSalaryPayment_RPTEntity IEntityBuilder<HREmployeeSalaryPayment_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYPAYMENTID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 2;
            const Int32 FLD_PROJECTID = 3;
            const Int32 FLD_DEPARTMENTID = 4;
            const Int32 FLD_DESIGNATIONID = 5;
            const Int32 FLD_EMPLOYEECODE = 6;
            const Int32 FLD_SALARYSESSIONID = 7;
            const Int32 FLD_SALARYSESSIONSTARTDATE = 8;
            const Int32 FLD_SALARYSESSIONENDDATE = 9;
            const Int32 FLD_CONSOLIDATESALARYAMOUNT = 10;
            const Int32 FLD_WORKDAYS = 11;
            const Int32 FLD_ADVANCE = 12;
            const Int32 FLD_FINE = 13;
            const Int32 FLD_MEALS = 14;
            const Int32 FLD_AIT = 15;
            const Int32 FLD_ADJUSTMENT = 16;
            const Int32 FLD_NETPAYABLE = 17;
            const Int32 FLD_NOTE = 18;
            const Int32 FLD_CASH = 19;
            const Int32 FLD_BANKAMOUNT = 20;
            const Int32 FLD_SALARYPAYABLE = 21;
            const Int32 FLD_ALLOWANCE = 22;
            const Int32 FLD_PROJECTACTUAL = 23;
            const Int32 FLD_BONUS = 24;
            const Int32 FLD_PHONECEILING = 25;
            const Int32 FLD_PHONEACTUALBILL = 26;
            const Int32 FLD_PHONEBILLADJUSTMENT = 27;
            const Int32 FLD_PROVIDENTFUNDDEDUCTEDAMOUNT = 28;
            const Int32 FLD_PBR = 29;
            const Int32 FLD_EBR = 30;
            const Int32 FLD_PHONEBILL = 31;
            const Int32 FLD_EMPLOYEESALARYPAYMENTSTATUSID = 32;
            const Int32 FLD_EMPLOYEEFULLNAME = 33;
            const Int32 FLD_DESIGNATIONNAME = 34;
            const Int32 FLD_SALARYSESSIONNAME = 35;
            const Int32 FLD_SESSIONSTARTDATE = 36;
            const Int32 FLD_SESSIONENDDATE = 37;
            const Int32 FLD_PROJECTCODE = 38;
            const Int32 FLD_PROJECTNAME = 39;

            HREmployeeSalaryPayment_RPTEntity hREmployeeSalaryPayment_RPTEntity = new HREmployeeSalaryPayment_RPTEntity();

            hREmployeeSalaryPayment_RPTEntity.EmployeeSalaryPaymentID = reader.GetInt64(FLD_EMPLOYEESALARYPAYMENTID);
            hREmployeeSalaryPayment_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryPayment_RPTEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryPayment_RPTEntity.ProjectID = null; } else { hREmployeeSalaryPayment_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeSalaryPayment_RPTEntity.DepartmentID = null; } else { hREmployeeSalaryPayment_RPTEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryPayment_RPTEntity.DesignationID = null; } else { hREmployeeSalaryPayment_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeSalaryPayment_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_SALARYSESSIONID)) { hREmployeeSalaryPayment_RPTEntity.SalarySessionID = null; } else { hREmployeeSalaryPayment_RPTEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID); }
            hREmployeeSalaryPayment_RPTEntity.SalarySessionStartDate = reader.GetDateTime(FLD_SALARYSESSIONSTARTDATE);
            if (reader.IsDBNull(FLD_SALARYSESSIONENDDATE)) { hREmployeeSalaryPayment_RPTEntity.SalarySessionEndDate = null; } else { hREmployeeSalaryPayment_RPTEntity.SalarySessionEndDate = reader.GetDateTime(FLD_SALARYSESSIONENDDATE); }
            hREmployeeSalaryPayment_RPTEntity.ConsolidateSalaryAmount = reader.GetDecimal(FLD_CONSOLIDATESALARYAMOUNT);
            hREmployeeSalaryPayment_RPTEntity.Workdays = reader.GetDecimal(FLD_WORKDAYS);
            hREmployeeSalaryPayment_RPTEntity.Advance = reader.GetDecimal(FLD_ADVANCE);
            hREmployeeSalaryPayment_RPTEntity.Fine = reader.GetDecimal(FLD_FINE);
            hREmployeeSalaryPayment_RPTEntity.Meals = reader.GetDecimal(FLD_MEALS);
            hREmployeeSalaryPayment_RPTEntity.AIT = reader.GetDecimal(FLD_AIT);
            hREmployeeSalaryPayment_RPTEntity.Adjustment = reader.GetDecimal(FLD_ADJUSTMENT);
            hREmployeeSalaryPayment_RPTEntity.NetPayable = reader.GetDecimal(FLD_NETPAYABLE);
            hREmployeeSalaryPayment_RPTEntity.Note = reader.GetDecimal(FLD_NOTE);
            hREmployeeSalaryPayment_RPTEntity.Cash = reader.GetDecimal(FLD_CASH);
            hREmployeeSalaryPayment_RPTEntity.BankAmount = reader.GetDecimal(FLD_BANKAMOUNT);
            hREmployeeSalaryPayment_RPTEntity.SalaryPayable = reader.GetDecimal(FLD_SALARYPAYABLE);
            hREmployeeSalaryPayment_RPTEntity.Allowance = reader.GetDecimal(FLD_ALLOWANCE);
            hREmployeeSalaryPayment_RPTEntity.ProjectActual = reader.GetDecimal(FLD_PROJECTACTUAL);
            hREmployeeSalaryPayment_RPTEntity.Bonus = reader.GetDecimal(FLD_BONUS);
            hREmployeeSalaryPayment_RPTEntity.PhoneCeiling = reader.GetDecimal(FLD_PHONECEILING);
            hREmployeeSalaryPayment_RPTEntity.PhoneActualBill = reader.GetDecimal(FLD_PHONEACTUALBILL);
            hREmployeeSalaryPayment_RPTEntity.PhoneBillAdjustment = reader.GetDecimal(FLD_PHONEBILLADJUSTMENT);
            hREmployeeSalaryPayment_RPTEntity.ProvidentFundDeductedAmount = reader.GetDecimal(FLD_PROVIDENTFUNDDEDUCTEDAMOUNT);
            hREmployeeSalaryPayment_RPTEntity.PBR = reader.GetDecimal(FLD_PBR);
            hREmployeeSalaryPayment_RPTEntity.EBR = reader.GetDecimal(FLD_EBR);
            hREmployeeSalaryPayment_RPTEntity.PhoneBill = reader.GetDecimal(FLD_PHONEBILL);
            hREmployeeSalaryPayment_RPTEntity.EmployeeSalaryPaymentStatusID = reader.GetInt64(FLD_EMPLOYEESALARYPAYMENTSTATUSID);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeSalaryPayment_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeSalaryPayment_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeSalaryPayment_RPTEntity.DesignationName = String.Empty; } else { hREmployeeSalaryPayment_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_SALARYSESSIONNAME)) { hREmployeeSalaryPayment_RPTEntity.SalarySessionName = String.Empty; } else { hREmployeeSalaryPayment_RPTEntity.SalarySessionName = reader.GetString(FLD_SALARYSESSIONNAME); }
            if (reader.IsDBNull(FLD_SESSIONSTARTDATE)) { hREmployeeSalaryPayment_RPTEntity.SessionStartDate = null; } else { hREmployeeSalaryPayment_RPTEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE); }
            if (reader.IsDBNull(FLD_SESSIONENDDATE)) { hREmployeeSalaryPayment_RPTEntity.SessionEndDate = null; } else { hREmployeeSalaryPayment_RPTEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeSalaryPayment_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeSalaryPayment_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeSalaryPayment_RPTEntity.ProjectName = String.Empty; } else { hREmployeeSalaryPayment_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return hREmployeeSalaryPayment_RPTEntity;
        }
    }
}
