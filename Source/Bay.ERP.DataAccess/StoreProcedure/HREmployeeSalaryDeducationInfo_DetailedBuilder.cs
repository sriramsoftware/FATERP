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
    internal sealed class HREmployeeSalaryDeducationInfo_DetailedBuilder : IEntityBuilder<HREmployeeSalaryDeducationInfo_DetailedEntity>
    {
        IList<HREmployeeSalaryDeducationInfo_DetailedEntity> IEntityBuilder<HREmployeeSalaryDeducationInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryDeducationInfo_DetailedEntity> HREmployeeSalaryDeducationInfo_DetailedEntityList = new List<HREmployeeSalaryDeducationInfo_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryDeducationInfo_DetailedEntityList.Add(((IEntityBuilder<HREmployeeSalaryDeducationInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryDeducationInfo_DetailedEntityList.Count > 0) ? HREmployeeSalaryDeducationInfo_DetailedEntityList : null;
        }

        HREmployeeSalaryDeducationInfo_DetailedEntity IEntityBuilder<HREmployeeSalaryDeducationInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYDEDUCATIONINFOID = 0;
            const Int32 FLD_SALARYDEDUCATIONCATEGORYID = 1;
            const Int32 FLD_SALARYSESSIONID = 2;
            const Int32 FLD_FISCALYEARID = 3;
            const Int32 FLD_EMPLOYEEID = 4;
            const Int32 FLD_DEDUCTIONAMOUNT = 5;
            const Int32 FLD_PERCENTAGEOFBASICSALARY = 6;
            const Int32 FLD_PAYCYCLEID = 7;
            const Int32 FLD_EFFECTIVEDATE = 8;
            const Int32 FLD_ENDDATE = 9;
            const Int32 FLD_NUMBEROFPAYMENTS = 10;
            const Int32 FLD_NOTE = 11;
            const Int32 FLD_ISREMOVED = 12;
            const Int32 FLD_SALARYDEDUCATIONCATEGORYNAME = 13;
            const Int32 FLD_SESSIONSTARTDATE = 14;
            const Int32 FLD_SESSIONENDDATE = 15;
            const Int32 FLD_EMPLOYEEFULLNAME = 16;
            const Int32 FLD_FISCALYEARBEGINDATE = 17;
            const Int32 FLD_FISCALYEARENDDATE = 18;
            const Int32 FLD_PAYCYCLENAME = 19;
            const Int32 FLD_NEXTINSTALLMENT = 20;
            const Int32 FLD_EMPLOYEECODE = 21;

            HREmployeeSalaryDeducationInfo_DetailedEntity hREmployeeSalaryDeducationInfo_DetailedEntity = new HREmployeeSalaryDeducationInfo_DetailedEntity();

            hREmployeeSalaryDeducationInfo_DetailedEntity.EmployeeSalaryDeducationInfoID = reader.GetInt64(FLD_EMPLOYEESALARYDEDUCATIONINFOID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.SalaryDeducationCategoryID = reader.GetInt64(FLD_SALARYDEDUCATIONCATEGORYID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.DeductionAmount = reader.GetDecimal(FLD_DEDUCTIONAMOUNT);
            hREmployeeSalaryDeducationInfo_DetailedEntity.PercentageOfBasicSalary = reader.GetDecimal(FLD_PERCENTAGEOFBASICSALARY);
            hREmployeeSalaryDeducationInfo_DetailedEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID);
            hREmployeeSalaryDeducationInfo_DetailedEntity.EffectiveDate = reader.GetDateTime(FLD_EFFECTIVEDATE);
            if (reader.IsDBNull(FLD_ENDDATE)) { hREmployeeSalaryDeducationInfo_DetailedEntity.EndDate = null; } else { hREmployeeSalaryDeducationInfo_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            hREmployeeSalaryDeducationInfo_DetailedEntity.NumberOfPayments = reader.GetDecimal(FLD_NUMBEROFPAYMENTS);
            if (reader.IsDBNull(FLD_NOTE)) { hREmployeeSalaryDeducationInfo_DetailedEntity.Note = String.Empty; } else { hREmployeeSalaryDeducationInfo_DetailedEntity.Note = reader.GetString(FLD_NOTE); }
            hREmployeeSalaryDeducationInfo_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_NEXTINSTALLMENT)) { hREmployeeSalaryDeducationInfo_DetailedEntity.NextInstallMent = null; } else { hREmployeeSalaryDeducationInfo_DetailedEntity.NextInstallMent = reader.GetDecimal(FLD_NEXTINSTALLMENT); }
            hREmployeeSalaryDeducationInfo_DetailedEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE);
            hREmployeeSalaryDeducationInfo_DetailedEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE);
            hREmployeeSalaryDeducationInfo_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME);
            hREmployeeSalaryDeducationInfo_DetailedEntity.FiscalYearBeginDate = reader.GetDateTime(FLD_FISCALYEARBEGINDATE);
            hREmployeeSalaryDeducationInfo_DetailedEntity.FiscalYearEndDate = reader.GetDateTime(FLD_FISCALYEARENDDATE);
            hREmployeeSalaryDeducationInfo_DetailedEntity.SalaryDeducationCategoryName = reader.GetString(FLD_SALARYDEDUCATIONCATEGORYNAME);
            hREmployeeSalaryDeducationInfo_DetailedEntity.PayCycleName = reader.GetString(FLD_PAYCYCLENAME);
            hREmployeeSalaryDeducationInfo_DetailedEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE);

            return hREmployeeSalaryDeducationInfo_DetailedEntity;
        }
    }
}
