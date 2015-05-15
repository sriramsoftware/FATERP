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
    internal sealed class HREmployeeMonthlyTimeSheetSummary_RPTBuilder : IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>
    {
        IList<HREmployeeMonthlyTimeSheetSummary_RPTEntity> IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeMonthlyTimeSheetSummary_RPTEntity> HREmployeeMonthlyTimeSheetSummary_RPTEntityList = new List<HREmployeeMonthlyTimeSheetSummary_RPTEntity>();

            while (reader.Read())
            {
                HREmployeeMonthlyTimeSheetSummary_RPTEntityList.Add(((IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeMonthlyTimeSheetSummary_RPTEntityList.Count > 0) ? HREmployeeMonthlyTimeSheetSummary_RPTEntityList : null;
        }

        HREmployeeMonthlyTimeSheetSummary_RPTEntity IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 17;
            const Int32 FLD_EMPLOYEECODE = 18;
            const Int32 FLD_EMPLOYEEJOBTYPENAME = 19;
            const Int32 FLD_DESIGNATIONNAME = 20;
            const Int32 FLD_JOINDATE = 21;
            const Int32 FLD_DISCONTINUTION = 22;
            const Int32 FLD_SERVICEAGEMONTH = 23;
            const Int32 FLD_SALARYSESSIONNAME = 24;
            const Int32 FLD_SESSIONSTARTDATE = 25;
            const Int32 FLD_SESSIONENDDATE = 26;
            const Int32 FLD_PROJECTCODE = 27;
            const Int32 FLD_PROJECTNAME = 28;

            HREmployeeMonthlyTimeSheetSummary_RPTEntity hREmployeeMonthlyTimeSheetSummary_RPTEntity = new HREmployeeMonthlyTimeSheetSummary_RPTEntity();

            hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeMonthlyTimeSheetID = reader.GetInt64(FLD_EMPLOYEEMONTHLYTIMESHEETID);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_DESIGNATIONID)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DesignationID = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID); }
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeJobTypeID = reader.GetInt64(FLD_EMPLOYEEJOBTYPEID);
            if (reader.IsDBNull(FLD_SALARYLEVEL)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SalaryLevel = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SalaryLevel = reader.GetInt32(FLD_SALARYLEVEL); }
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.OnJob = reader.GetDecimal(FLD_ONJOB);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.Holiday = reader.GetDecimal(FLD_HOLIDAY);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.LCASUAL = reader.GetDecimal(FLD_LCASUAL);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.LMEDICAL = reader.GetDecimal(FLD_LMEDICAL);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.EARNLEAVE = reader.GetDecimal(FLD_EARNLEAVE);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.LWP = reader.GetDecimal(FLD_LWP);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.ACTUALWORKDAYS = reader.GetDecimal(FLD_ACTUALWORKDAYS);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.REMARKS = reader.GetDecimal(FLD_REMARKS);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.NUMBEROFMEALS = reader.GetDecimal(FLD_NUMBEROFMEALS);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.PROJECTACTUAL = reader.GetDecimal(FLD_PROJECTACTUAL);
            hREmployeeMonthlyTimeSheetSummary_RPTEntity.OTHERLEAVE = reader.GetDecimal(FLD_OTHERLEAVE);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeFullName = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECODE)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeCode = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeCode = reader.GetString(FLD_EMPLOYEECODE); }
            if (reader.IsDBNull(FLD_EMPLOYEEJOBTYPENAME)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeJobTypeName = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.EmployeeJobTypeName = reader.GetString(FLD_EMPLOYEEJOBTYPENAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DesignationName = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_JOINDATE)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.JoinDate = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.JoinDate = reader.GetDateTime(FLD_JOINDATE); }
            if (reader.IsDBNull(FLD_DISCONTINUTION)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DISCONTINUTION = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.DISCONTINUTION = reader.GetDateTime(FLD_DISCONTINUTION); }
            if (reader.IsDBNull(FLD_SERVICEAGEMONTH)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ServiceAgeMonth = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ServiceAgeMonth = reader.GetInt32(FLD_SERVICEAGEMONTH); }
            if (reader.IsDBNull(FLD_SALARYSESSIONNAME)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SalarySessionName = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SalarySessionName = reader.GetString(FLD_SALARYSESSIONNAME); }
            if (reader.IsDBNull(FLD_SESSIONSTARTDATE)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SessionStartDate = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SessionStartDate = reader.GetDateTime(FLD_SESSIONSTARTDATE); }
            if (reader.IsDBNull(FLD_SESSIONENDDATE)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SessionEndDate = null; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.SessionEndDate = reader.GetDateTime(FLD_SESSIONENDDATE); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ProjectCode = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ProjectName = String.Empty; } else { hREmployeeMonthlyTimeSheetSummary_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }

            return hREmployeeMonthlyTimeSheetSummary_RPTEntity;
        }
    }
}
