// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMemberLeaveAccount_DetailedBuilder : IEntityBuilder<HRMemberLeaveAccount_DetailedEntity>
    {
        IList<HRMemberLeaveAccount_DetailedEntity> IEntityBuilder<HRMemberLeaveAccount_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMemberLeaveAccount_DetailedEntity> HRMemberLeaveAccount_DetailedEntityList = new List<HRMemberLeaveAccount_DetailedEntity>();

            while (reader.Read())
            {
                HRMemberLeaveAccount_DetailedEntityList.Add(((IEntityBuilder<HRMemberLeaveAccount_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRMemberLeaveAccount_DetailedEntityList.Count > 0) ? HRMemberLeaveAccount_DetailedEntityList : null;
        }

        HRMemberLeaveAccount_DetailedEntity IEntityBuilder<HRMemberLeaveAccount_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERLEAVEACCOUNTID = 0;
            const Int32 FLD_ATTENDANCELEAVEHOLIDAYLISTID = 1;
            const Int32 FLD_SALARYSESSIONID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_UPDATEDATE = 4;
            const Int32 FLD_EARNEDDAYS = 5;
            const Int32 FLD_ACCUREDDAYS = 6;
            const Int32 FLD_USEDDAYS = 7;
            const Int32 FLD_BALANCEDAYS = 8;
            const Int32 FLD_ISREMOVED = 9;
            const Int32 FLD_FISCALYEARID = 10;
            const Int32 FLD_EMPLOYEEFULLNAME = 11;
            const Int32 FLD_NAME = 12;
            const Int32 FLD_CODE = 13;
            const Int32 FLD_COLOR = 14;
            const Int32 FLD_SALARYSESSIONNAME = 15;
            const Int32 FLD_BEGINDATE = 16;
            const Int32 FLD_ENDDATE = 17;
            const Int32 FLD_ISCLOSED = 18;
            const Int32 FLD_ISLOCKED = 19;
            const Int32 FLD_LEAVECATEGORYID = 20;
            const Int32 FLD_LEAVECATEGORYNAME = 21;
            const Int32 FLD_ROWNUMBER = 22;
            

            HRMemberLeaveAccount_DetailedEntity hRMemberLeaveAccount_DetailedEntity = new HRMemberLeaveAccount_DetailedEntity();

            hRMemberLeaveAccount_DetailedEntity.MemberLeaveAccountID = reader.GetInt64(FLD_MEMBERLEAVEACCOUNTID);
            if (reader.IsDBNull(FLD_ATTENDANCELEAVEHOLIDAYLISTID)) { hRMemberLeaveAccount_DetailedEntity.AttendanceLeaveHolidayListID = null; } else { hRMemberLeaveAccount_DetailedEntity.AttendanceLeaveHolidayListID = reader.GetInt64(FLD_ATTENDANCELEAVEHOLIDAYLISTID); }
            if (reader.IsDBNull(FLD_SALARYSESSIONID)) { hRMemberLeaveAccount_DetailedEntity.SalarySessionID= null; } else { hRMemberLeaveAccount_DetailedEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID); }
            hRMemberLeaveAccount_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_UPDATEDATE)) { hRMemberLeaveAccount_DetailedEntity.UpdateDate = null; } else { hRMemberLeaveAccount_DetailedEntity.UpdateDate = reader.GetDateTime(FLD_UPDATEDATE); }
            if (reader.IsDBNull(FLD_EARNEDDAYS)) { hRMemberLeaveAccount_DetailedEntity.EarnedDays = null; } else { hRMemberLeaveAccount_DetailedEntity.EarnedDays = reader.GetDecimal(FLD_EARNEDDAYS); }
            if (reader.IsDBNull(FLD_ACCUREDDAYS)) { hRMemberLeaveAccount_DetailedEntity.AccuredDays = null; } else { hRMemberLeaveAccount_DetailedEntity.AccuredDays = reader.GetDecimal(FLD_ACCUREDDAYS); }
            if (reader.IsDBNull(FLD_USEDDAYS)) { hRMemberLeaveAccount_DetailedEntity.UsedDays = null; } else { hRMemberLeaveAccount_DetailedEntity.UsedDays = reader.GetDecimal(FLD_USEDDAYS); }
            if (reader.IsDBNull(FLD_BALANCEDAYS)) { hRMemberLeaveAccount_DetailedEntity.BalanceDays = null; } else { hRMemberLeaveAccount_DetailedEntity.BalanceDays = reader.GetDecimal(FLD_BALANCEDAYS); }
            hRMemberLeaveAccount_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            hRMemberLeaveAccount_DetailedEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hRMemberLeaveAccount_DetailedEntity.EmployeeFullName = String.Empty; } else { hRMemberLeaveAccount_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_NAME)) { hRMemberLeaveAccount_DetailedEntity.Name = String.Empty; } else { hRMemberLeaveAccount_DetailedEntity.Name = reader.GetString(FLD_NAME); }
            if (reader.IsDBNull(FLD_CODE)) { hRMemberLeaveAccount_DetailedEntity.Code = String.Empty; } else { hRMemberLeaveAccount_DetailedEntity.Code = reader.GetString(FLD_CODE); }
            if (reader.IsDBNull(FLD_COLOR)) { hRMemberLeaveAccount_DetailedEntity.Color = String.Empty; } else { hRMemberLeaveAccount_DetailedEntity.Color = reader.GetString(FLD_COLOR); }
            if (reader.IsDBNull(FLD_SALARYSESSIONNAME)) { hRMemberLeaveAccount_DetailedEntity.SalarySessionName = String.Empty; } else { hRMemberLeaveAccount_DetailedEntity.SalarySessionName = reader.GetString(FLD_SALARYSESSIONNAME); }
            if (reader.IsDBNull(FLD_BEGINDATE)) { hRMemberLeaveAccount_DetailedEntity.BeginDate = null; } else { hRMemberLeaveAccount_DetailedEntity.BeginDate = reader.GetDateTime(FLD_BEGINDATE); }
            if (reader.IsDBNull(FLD_ENDDATE)) { hRMemberLeaveAccount_DetailedEntity.EndDate = null; } else { hRMemberLeaveAccount_DetailedEntity.EndDate = reader.GetDateTime(FLD_ENDDATE); }
            if (reader.IsDBNull(FLD_ISCLOSED)) { hRMemberLeaveAccount_DetailedEntity.IsClosed = false; } else { hRMemberLeaveAccount_DetailedEntity.IsClosed = reader.GetBoolean(FLD_ISCLOSED); }
            if (reader.IsDBNull(FLD_ISLOCKED)) { hRMemberLeaveAccount_DetailedEntity.IsLocked = false; } else { hRMemberLeaveAccount_DetailedEntity.IsLocked = reader.GetBoolean(FLD_ISLOCKED); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRMemberLeaveAccount_DetailedEntity.RowNumber = null; } else { hRMemberLeaveAccount_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }
            hRMemberLeaveAccount_DetailedEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID); 
            hRMemberLeaveAccount_DetailedEntity.LeaveCategoryName = reader.GetString(FLD_LEAVECATEGORYNAME); 

            return hRMemberLeaveAccount_DetailedEntity;
        }
    }
}
