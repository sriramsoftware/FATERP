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
    internal sealed class HREmployeeSalaryPaymentBuilder : IEntityBuilder<HREmployeeSalaryPaymentEntity>
    {
        IList<HREmployeeSalaryPaymentEntity> IEntityBuilder<HREmployeeSalaryPaymentEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryPaymentEntity> HREmployeeSalaryPaymentEntityList = new List<HREmployeeSalaryPaymentEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryPaymentEntityList.Add(((IEntityBuilder<HREmployeeSalaryPaymentEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryPaymentEntityList.Count > 0) ? HREmployeeSalaryPaymentEntityList : null;
        }

        HREmployeeSalaryPaymentEntity IEntityBuilder<HREmployeeSalaryPaymentEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_SALARYLEVEL = 33;
            const Int32 FLD_FIELD2 = 34;
            const Int32 FLD_FIELD3 = 35;
            const Int32 FLD_FIELD4 = 36;
            const Int32 FLD_TBR = 37;
            const Int32 FLD_TAX = 38;

            HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity = new HREmployeeSalaryPaymentEntity();

            hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentID = reader.GetInt64(FLD_EMPLOYEESALARYPAYMENTID);
            hREmployeeSalaryPaymentEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryPaymentEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_PROJECTID)) { hREmployeeSalaryPaymentEntity.ProjectID = null; } else { hREmployeeSalaryPaymentEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeSalaryPaymentEntity.DepartmentID = null; } else { hREmployeeSalaryPaymentEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeSalaryPaymentEntity.DesignationID = null; } else { hREmployeeSalaryPaymentEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeSalaryPaymentEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);
            if (reader.IsDBNull(FLD_SALARYSESSIONID)) { hREmployeeSalaryPaymentEntity.SalarySessionID = null; } else { hREmployeeSalaryPaymentEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID); }
            hREmployeeSalaryPaymentEntity.SalarySessionStartDate = reader.GetDateTime(FLD_SALARYSESSIONSTARTDATE);
            if (reader.IsDBNull(FLD_SALARYSESSIONENDDATE)) { hREmployeeSalaryPaymentEntity.SalarySessionEndDate = null; } else { hREmployeeSalaryPaymentEntity.SalarySessionEndDate = reader.GetDateTime(FLD_SALARYSESSIONENDDATE); }
            hREmployeeSalaryPaymentEntity.ConsolidateSalaryAmount = reader.GetDecimal(FLD_CONSOLIDATESALARYAMOUNT);
            hREmployeeSalaryPaymentEntity.Workdays = reader.GetDecimal(FLD_WORKDAYS);
            hREmployeeSalaryPaymentEntity.Advance = reader.GetDecimal(FLD_ADVANCE);
            hREmployeeSalaryPaymentEntity.Fine = reader.GetDecimal(FLD_FINE);
            hREmployeeSalaryPaymentEntity.Meals = reader.GetDecimal(FLD_MEALS);
            hREmployeeSalaryPaymentEntity.AIT = reader.GetDecimal(FLD_AIT);
            hREmployeeSalaryPaymentEntity.Adjustment = reader.GetDecimal(FLD_ADJUSTMENT);
            hREmployeeSalaryPaymentEntity.NetPayable = reader.GetDecimal(FLD_NETPAYABLE);
            hREmployeeSalaryPaymentEntity.Note = reader.GetDecimal(FLD_NOTE);
            hREmployeeSalaryPaymentEntity.Cash = reader.GetDecimal(FLD_CASH);
            hREmployeeSalaryPaymentEntity.BankAmount = reader.GetDecimal(FLD_BANKAMOUNT);
            hREmployeeSalaryPaymentEntity.SalaryPayable = reader.GetDecimal(FLD_SALARYPAYABLE);
            hREmployeeSalaryPaymentEntity.Allowance = reader.GetDecimal(FLD_ALLOWANCE);
            hREmployeeSalaryPaymentEntity.ProjectActual = reader.GetDecimal(FLD_PROJECTACTUAL);
            hREmployeeSalaryPaymentEntity.Bonus = reader.GetDecimal(FLD_BONUS);
            hREmployeeSalaryPaymentEntity.PhoneCeiling = reader.GetDecimal(FLD_PHONECEILING);
            hREmployeeSalaryPaymentEntity.PhoneActualBill = reader.GetDecimal(FLD_PHONEACTUALBILL);
            hREmployeeSalaryPaymentEntity.PhoneBillAdjustment = reader.GetDecimal(FLD_PHONEBILLADJUSTMENT);
            hREmployeeSalaryPaymentEntity.ProvidentFundDeductedAmount = reader.GetDecimal(FLD_PROVIDENTFUNDDEDUCTEDAMOUNT);
            hREmployeeSalaryPaymentEntity.PBR = reader.GetDecimal(FLD_PBR);
            hREmployeeSalaryPaymentEntity.EBR = reader.GetDecimal(FLD_EBR);
            hREmployeeSalaryPaymentEntity.PhoneBill = reader.GetDecimal(FLD_PHONEBILL);
            hREmployeeSalaryPaymentEntity.EmployeeSalaryPaymentStatusID = reader.GetInt64(FLD_EMPLOYEESALARYPAYMENTSTATUSID);
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeSalaryPaymentEntity.SalaryLevel = null; } else { hREmployeeSalaryPaymentEntity.SalaryLevel = reader.GetInt64(FLD_SALARYLEVEL); }
            if (reader.IsDBNull(FLD_FIELD2)) { hREmployeeSalaryPaymentEntity.Field2 = String.Empty; } else { hREmployeeSalaryPaymentEntity.Field2 = reader.GetString(FLD_FIELD2); }
            if (reader.IsDBNull(FLD_FIELD3)) { hREmployeeSalaryPaymentEntity.Field3 = String.Empty; } else { hREmployeeSalaryPaymentEntity.Field3 = reader.GetString(FLD_FIELD3); }
            if (reader.IsDBNull(FLD_FIELD4)) { hREmployeeSalaryPaymentEntity.Field4 = String.Empty; } else { hREmployeeSalaryPaymentEntity.Field4 = reader.GetString(FLD_FIELD4); }
            if (reader.IsDBNull(FLD_TBR)) { hREmployeeSalaryPaymentEntity.TBR = null; } else { hREmployeeSalaryPaymentEntity.TBR = reader.GetDecimal(FLD_TBR); }
            if (reader.IsDBNull(FLD_TAX)) { hREmployeeSalaryPaymentEntity.TAX = null; } else { hREmployeeSalaryPaymentEntity.TAX = reader.GetDecimal(FLD_TAX); }

            return hREmployeeSalaryPaymentEntity;
        }
    }
}
