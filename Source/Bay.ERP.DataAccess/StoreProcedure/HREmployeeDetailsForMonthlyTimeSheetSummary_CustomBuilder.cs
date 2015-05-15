// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jan-2014, 04:42:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeDetailsForMonthlyTimeSheetSummary_CustomBuilder : IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>
    {
        IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntityList = new List<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>();

            while (reader.Read())
            {
                HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntityList.Add(((IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntityList.Count > 0) ? HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntityList : null;
        }

        HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYSESSIONID = 0;
            const Int32 FLD_ONJOB = 1;
            const Int32 FLD_HOLIDAY = 2;
            const Int32 FLD_LEAVEDAY = 3;
            const Int32 FLD_ACTUALWORKINGDAY = 4;

            HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity = new HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity();

            hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity.OnJob = reader.GetInt32(FLD_ONJOB);
            hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity.Holiday = reader.GetInt32(FLD_HOLIDAY);
            hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity.LeaveDay = reader.GetInt32(FLD_LEAVEDAY);
            hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity.ActualWorkingDay = reader.GetInt32(FLD_ACTUALWORKINGDAY); 

            return hREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity;
        }
    }
}
