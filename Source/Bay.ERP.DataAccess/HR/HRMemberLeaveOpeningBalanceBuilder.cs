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
    internal sealed class HRMemberLeaveOpeningBalanceBuilder : IEntityBuilder<HRMemberLeaveOpeningBalanceEntity>
    {
        IList<HRMemberLeaveOpeningBalanceEntity> IEntityBuilder<HRMemberLeaveOpeningBalanceEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMemberLeaveOpeningBalanceEntity> HRMemberLeaveOpeningBalanceEntityList = new List<HRMemberLeaveOpeningBalanceEntity>();

            while (reader.Read())
            {
                HRMemberLeaveOpeningBalanceEntityList.Add(((IEntityBuilder<HRMemberLeaveOpeningBalanceEntity>)this).BuildEntity(reader));
            }

            return (HRMemberLeaveOpeningBalanceEntityList.Count > 0) ? HRMemberLeaveOpeningBalanceEntityList : null;
        }

        HRMemberLeaveOpeningBalanceEntity IEntityBuilder<HRMemberLeaveOpeningBalanceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERLEAVEOPENINGBALANCEID = 0;
            const Int32 FLD_ATTENDANCELEAVEHOLIDAYLISTID = 1;
            const Int32 FLD_EMPLOYEEID = 2;
            const Int32 FLD_BALANCEDAYS = 3;
            const Int32 FLD_BALANCEASOFFDATE = 4;
            const Int32 FLD_REMARKS = 5;

            HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity = new HRMemberLeaveOpeningBalanceEntity();

            hRMemberLeaveOpeningBalanceEntity.MemberLeaveOpeningBalanceID = reader.GetInt64(FLD_MEMBERLEAVEOPENINGBALANCEID);
            hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID = reader.GetInt64(FLD_ATTENDANCELEAVEHOLIDAYLISTID);
            hRMemberLeaveOpeningBalanceEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            if (reader.IsDBNull(FLD_BALANCEDAYS)) { hRMemberLeaveOpeningBalanceEntity.BalanceDays = null; } else { hRMemberLeaveOpeningBalanceEntity.BalanceDays = reader.GetDecimal(FLD_BALANCEDAYS); }
            if (reader.IsDBNull(FLD_BALANCEASOFFDATE)) { hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate = null; } else { hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate = reader.GetDateTime(FLD_BALANCEASOFFDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { hRMemberLeaveOpeningBalanceEntity.Remarks = String.Empty; } else { hRMemberLeaveOpeningBalanceEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hRMemberLeaveOpeningBalanceEntity;
        }
    }
}
