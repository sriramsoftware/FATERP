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
    internal sealed class HREmployeeSalaryDeducationInfoBuilder : IEntityBuilder<HREmployeeSalaryDeducationInfoEntity>
    {
        IList<HREmployeeSalaryDeducationInfoEntity> IEntityBuilder<HREmployeeSalaryDeducationInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryDeducationInfoEntity> HREmployeeSalaryDeducationInfoEntityList = new List<HREmployeeSalaryDeducationInfoEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryDeducationInfoEntityList.Add(((IEntityBuilder<HREmployeeSalaryDeducationInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryDeducationInfoEntityList.Count > 0) ? HREmployeeSalaryDeducationInfoEntityList : null;
        }

        HREmployeeSalaryDeducationInfoEntity IEntityBuilder<HREmployeeSalaryDeducationInfoEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_NEXTINSTALLMENT = 13;

            HREmployeeSalaryDeducationInfoEntity hREmployeeSalaryDeducationInfoEntity = new HREmployeeSalaryDeducationInfoEntity();

            hREmployeeSalaryDeducationInfoEntity.EmployeeSalaryDeducationInfoID = reader.GetInt64(FLD_EMPLOYEESALARYDEDUCATIONINFOID);
            hREmployeeSalaryDeducationInfoEntity.SalaryDeducationCategoryID = reader.GetInt64(FLD_SALARYDEDUCATIONCATEGORYID);
            hREmployeeSalaryDeducationInfoEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeSalaryDeducationInfoEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hREmployeeSalaryDeducationInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryDeducationInfoEntity.DeductionAmount = reader.GetDecimal(FLD_DEDUCTIONAMOUNT);
            hREmployeeSalaryDeducationInfoEntity.PercentageOfBasicSalary = reader.GetDecimal(FLD_PERCENTAGEOFBASICSALARY);
            hREmployeeSalaryDeducationInfoEntity.PayCycleID = reader.GetInt64(FLD_PAYCYCLEID);
            hREmployeeSalaryDeducationInfoEntity.EffectiveDate = reader.GetDateTime(FLD_EFFECTIVEDATE);
            if (reader.IsDBNull(FLD_ENDDATE)) { hREmployeeSalaryDeducationInfoEntity.EndDate = null; } else { hREmployeeSalaryDeducationInfoEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            hREmployeeSalaryDeducationInfoEntity.NumberOfPayments = reader.GetDecimal(FLD_NUMBEROFPAYMENTS);
            if (reader.IsDBNull(FLD_NOTE)) { hREmployeeSalaryDeducationInfoEntity.Note = String.Empty; } else { hREmployeeSalaryDeducationInfoEntity.Note = reader.GetString(FLD_NOTE); }
            hREmployeeSalaryDeducationInfoEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_NEXTINSTALLMENT)) { hREmployeeSalaryDeducationInfoEntity.NextInstallMent = null; } else { hREmployeeSalaryDeducationInfoEntity.NextInstallMent = reader.GetDecimal(FLD_NEXTINSTALLMENT); }

            return hREmployeeSalaryDeducationInfoEntity;
        }
    }
}
