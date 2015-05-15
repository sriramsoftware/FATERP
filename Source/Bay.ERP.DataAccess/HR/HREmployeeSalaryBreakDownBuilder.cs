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
    internal sealed class HREmployeeSalaryBreakDownBuilder : IEntityBuilder<HREmployeeSalaryBreakDownEntity>
    {
        IList<HREmployeeSalaryBreakDownEntity> IEntityBuilder<HREmployeeSalaryBreakDownEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryBreakDownEntity> HREmployeeSalaryBreakDownEntityList = new List<HREmployeeSalaryBreakDownEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryBreakDownEntityList.Add(((IEntityBuilder<HREmployeeSalaryBreakDownEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryBreakDownEntityList.Count > 0) ? HREmployeeSalaryBreakDownEntityList : null;
        }

        HREmployeeSalaryBreakDownEntity IEntityBuilder<HREmployeeSalaryBreakDownEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYBREAKDOWNID = 0;
            const Int32 FLD_EMPLOYEESALARYINFOID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_YEARLYRATE = 3;
            const Int32 FLD_MONTHLYRATE = 4;
            const Int32 FLD_DAILYRATE = 5;
            const Int32 FLD_OTHOURLYRATE = 6;
            const Int32 FLD_HOULRYRATE = 7;

            HREmployeeSalaryBreakDownEntity hREmployeeSalaryBreakDownEntity = new HREmployeeSalaryBreakDownEntity();

            hREmployeeSalaryBreakDownEntity.EmployeeSalaryBreakDownID = reader.GetInt64(FLD_EMPLOYEESALARYBREAKDOWNID);
            hREmployeeSalaryBreakDownEntity.EmployeeSalaryInfoID = reader.GetInt64(FLD_EMPLOYEESALARYINFOID);
            hREmployeeSalaryBreakDownEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryBreakDownEntity.YearlyRate = reader.GetDecimal(FLD_YEARLYRATE);
            hREmployeeSalaryBreakDownEntity.MonthlyRate = reader.GetDecimal(FLD_MONTHLYRATE);
            hREmployeeSalaryBreakDownEntity.DailyRate = reader.GetDecimal(FLD_DAILYRATE);
            hREmployeeSalaryBreakDownEntity.OTHourlyRate = reader.GetDecimal(FLD_OTHOURLYRATE);
            hREmployeeSalaryBreakDownEntity.HoulryRate = reader.GetDecimal(FLD_HOULRYRATE);

            return hREmployeeSalaryBreakDownEntity;
        }
    }
}
