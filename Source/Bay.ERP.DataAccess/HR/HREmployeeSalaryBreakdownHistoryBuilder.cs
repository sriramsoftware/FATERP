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
    internal sealed class HREmployeeSalaryBreakdownHistoryBuilder : IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>
    {
        IList<HREmployeeSalaryBreakdownHistoryEntity> IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeSalaryBreakdownHistoryEntity> HREmployeeSalaryBreakdownHistoryEntityList = new List<HREmployeeSalaryBreakdownHistoryEntity>();

            while (reader.Read())
            {
                HREmployeeSalaryBreakdownHistoryEntityList.Add(((IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeSalaryBreakdownHistoryEntityList.Count > 0) ? HREmployeeSalaryBreakdownHistoryEntityList : null;
        }

        HREmployeeSalaryBreakdownHistoryEntity IEntityBuilder<HREmployeeSalaryBreakdownHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEESALARYBREAKDOWNHISTORYID = 0;
            const Int32 FLD_EMPLOYEESALARYBREAKDOWNID = 1;
            const Int32 FLD_EMPLOYEESALARYINFOID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_YEARLYRATE = 4;
            const Int32 FLD_MONTHLYRATE = 5;
            const Int32 FLD_DAILYRATE = 6;
            const Int32 FLD_OTHOURLYRATE = 7;
            const Int32 FLD_HOULRYRATE = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 10;

            HREmployeeSalaryBreakdownHistoryEntity hREmployeeSalaryBreakdownHistoryEntity = new HREmployeeSalaryBreakdownHistoryEntity();

            hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakdownHistoryID = reader.GetInt64(FLD_EMPLOYEESALARYBREAKDOWNHISTORYID);
            hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryBreakDownID = reader.GetInt64(FLD_EMPLOYEESALARYBREAKDOWNID);
            hREmployeeSalaryBreakdownHistoryEntity.EmployeeSalaryInfoID = reader.GetInt64(FLD_EMPLOYEESALARYINFOID);
            hREmployeeSalaryBreakdownHistoryEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeSalaryBreakdownHistoryEntity.YearlyRate = reader.GetDecimal(FLD_YEARLYRATE);
            hREmployeeSalaryBreakdownHistoryEntity.MonthlyRate = reader.GetDecimal(FLD_MONTHLYRATE);
            hREmployeeSalaryBreakdownHistoryEntity.DailyRate = reader.GetDecimal(FLD_DAILYRATE);
            hREmployeeSalaryBreakdownHistoryEntity.OTHourlyRate = reader.GetDecimal(FLD_OTHOURLYRATE);
            hREmployeeSalaryBreakdownHistoryEntity.HoulryRate = reader.GetDecimal(FLD_HOULRYRATE);
            hREmployeeSalaryBreakdownHistoryEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            hREmployeeSalaryBreakdownHistoryEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return hREmployeeSalaryBreakdownHistoryEntity;
        }
    }
}
