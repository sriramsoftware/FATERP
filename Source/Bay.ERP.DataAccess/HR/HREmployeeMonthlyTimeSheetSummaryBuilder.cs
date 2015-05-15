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
    internal sealed class HREmployeeMonthlyTimeSheetSummaryBuilder : IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>
    {
        IList<HREmployeeMonthlyTimeSheetSummaryEntity> IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeMonthlyTimeSheetSummaryEntity> HREmployeeMonthlyTimeSheetSummaryEntityList = new List<HREmployeeMonthlyTimeSheetSummaryEntity>();

            while (reader.Read())
            {
                HREmployeeMonthlyTimeSheetSummaryEntityList.Add(((IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeMonthlyTimeSheetSummaryEntityList.Count > 0) ? HREmployeeMonthlyTimeSheetSummaryEntityList : null;
        }

        HREmployeeMonthlyTimeSheetSummaryEntity IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEMONTHLYTIMESHEETID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_DESIGNATIONID = 2;
            const Int32 FLD_EMPLOYEEJOBTYPEID = 3;
            const Int32 FLD_SALARYLEVEL = 4;
            const Int32 FLD_SALARYSESSIONID = 5;
            const Int32 FLD_ONJOB = 6;
            const Int32 FLD_HOLIDAY = 7;
            const Int32 FLD_LCASUAL = 8;
            const Int32 FLD_LMEDICAL = 9;
            const Int32 FLD_EARNLEAVE = 10;
            const Int32 FLD_LWP = 11;
            const Int32 FLD_ACTUALWORKDAYS = 12;
            const Int32 FLD_REMARKS = 13;
            const Int32 FLD_NUMBEROFMEALS = 14;
            const Int32 FLD_PROJECTACTUAL = 15;
            const Int32 FLD_OTHERLEAVE = 16;
            const Int32 FLD_FIELD1 = 17;
            const Int32 FLD_FIELD11 = 18;
            const Int32 FLD_FIELD12 = 19;
            const Int32 FLD_FIELD13 = 20;
            const Int32 FLD_FIELD14 = 21;
            const Int32 FLD_FIELD15 = 22;
            const Int32 FLD_DEPARTMENTID = 23;

            HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity = new HREmployeeMonthlyTimeSheetSummaryEntity();

            hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeMonthlyTimeSheetID = reader.GetInt64(FLD_EMPLOYEEMONTHLYTIMESHEETID);
            hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeMonthlyTimeSheetSummaryEntity.OnJob = reader.GetDecimal(FLD_ONJOB);
            hREmployeeMonthlyTimeSheetSummaryEntity.Holiday = reader.GetDecimal(FLD_HOLIDAY);
            hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL = reader.GetDecimal(FLD_LCASUAL);
            hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL = reader.GetDecimal(FLD_LMEDICAL);
            hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE = reader.GetDecimal(FLD_EARNLEAVE);
            hREmployeeMonthlyTimeSheetSummaryEntity.LWP = reader.GetDecimal(FLD_LWP);
            hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS = reader.GetDecimal(FLD_ACTUALWORKDAYS);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS = String.Empty; } else { hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS = reader.GetString(FLD_REMARKS); }
            hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS = reader.GetDecimal(FLD_NUMBEROFMEALS);
            hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL = reader.GetDecimal(FLD_PROJECTACTUAL);
            hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE = reader.GetDecimal(FLD_OTHERLEAVE);
            if (reader.IsDBNull(FLD_FIELD1)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field1 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field1 = reader.GetDecimal(FLD_FIELD1); }
            if (reader.IsDBNull(FLD_FIELD11)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field11 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field11 = reader.GetChar(FLD_FIELD11); }
            if (reader.IsDBNull(FLD_FIELD12)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field12 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field12 = reader.GetChar(FLD_FIELD12); }
            if (reader.IsDBNull(FLD_FIELD13)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field13 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field13 = reader.GetChar(FLD_FIELD13); }
            if (reader.IsDBNull(FLD_FIELD14)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field14 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field14 = reader.GetChar(FLD_FIELD14); }
            if (reader.IsDBNull(FLD_FIELD15)) { hREmployeeMonthlyTimeSheetSummaryEntity.Field15 = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.Field15 = reader.GetChar(FLD_FIELD15); }
            if (reader.IsDBNull(FLD_DEPARTMENTID)) { hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID = null; } else { hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID); }

            return hREmployeeMonthlyTimeSheetSummaryEntity;
        }
    }
}
