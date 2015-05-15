// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMemberLeaveAccountBuilder : IEntityBuilder<HRMemberLeaveAccountEntity>
    {
        IList<HRMemberLeaveAccountEntity> IEntityBuilder<HRMemberLeaveAccountEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMemberLeaveAccountEntity> HRMemberLeaveAccountEntityList = new List<HRMemberLeaveAccountEntity>();

            while (reader.Read())
            {
                HRMemberLeaveAccountEntityList.Add(((IEntityBuilder<HRMemberLeaveAccountEntity>)this).BuildEntity(reader));
            }

            return (HRMemberLeaveAccountEntityList.Count > 0) ? HRMemberLeaveAccountEntityList : null;
        }

        HRMemberLeaveAccountEntity IEntityBuilder<HRMemberLeaveAccountEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_LEAVECATEGORYID = 11;

            HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity = new HRMemberLeaveAccountEntity();

            hRMemberLeaveAccountEntity.MemberLeaveAccountID = reader.GetInt64(FLD_MEMBERLEAVEACCOUNTID);
            if (reader.IsDBNull(FLD_ATTENDANCELEAVEHOLIDAYLISTID)) { hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID = null; } else { hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID = reader.GetInt64(FLD_ATTENDANCELEAVEHOLIDAYLISTID); }
            if (reader.IsDBNull(FLD_SALARYSESSIONID)) { hRMemberLeaveAccountEntity.SalarySessionID = null; } else { hRMemberLeaveAccountEntity.SalarySessionID = reader.GetInt64(FLD_SALARYSESSIONID); }
            hRMemberLeaveAccountEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_UPDATEDATE)) { hRMemberLeaveAccountEntity.UpdateDate = null; } else { hRMemberLeaveAccountEntity.UpdateDate = reader.GetDateTime(FLD_UPDATEDATE); }
            if (reader.IsDBNull(FLD_EARNEDDAYS)) { hRMemberLeaveAccountEntity.EarnedDays = null; } else { hRMemberLeaveAccountEntity.EarnedDays = reader.GetDecimal(FLD_EARNEDDAYS); }
            if (reader.IsDBNull(FLD_ACCUREDDAYS)) { hRMemberLeaveAccountEntity.AccuredDays = null; } else { hRMemberLeaveAccountEntity.AccuredDays = reader.GetDecimal(FLD_ACCUREDDAYS); }
            if (reader.IsDBNull(FLD_USEDDAYS)) { hRMemberLeaveAccountEntity.UsedDays = null; } else { hRMemberLeaveAccountEntity.UsedDays = reader.GetDecimal(FLD_USEDDAYS); }
            if (reader.IsDBNull(FLD_BALANCEDAYS)) { hRMemberLeaveAccountEntity.BalanceDays = null; } else { hRMemberLeaveAccountEntity.BalanceDays = reader.GetDecimal(FLD_BALANCEDAYS); }
            hRMemberLeaveAccountEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            hRMemberLeaveAccountEntity.FiscalYearID = reader.GetInt64(FLD_FISCALYEARID);
            hRMemberLeaveAccountEntity.LeaveCategoryID = reader.GetInt64(FLD_LEAVECATEGORYID);

            return hRMemberLeaveAccountEntity;
        }
    }
}
