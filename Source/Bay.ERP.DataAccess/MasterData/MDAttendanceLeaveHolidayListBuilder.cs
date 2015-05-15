// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAttendanceLeaveHolidayListBuilder : IEntityBuilder<MDAttendanceLeaveHolidayListEntity>
    {
        IList<MDAttendanceLeaveHolidayListEntity> IEntityBuilder<MDAttendanceLeaveHolidayListEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAttendanceLeaveHolidayListEntity> MDAttendanceLeaveHolidayListEntityList = new List<MDAttendanceLeaveHolidayListEntity>();

            while (reader.Read())
            {
                MDAttendanceLeaveHolidayListEntityList.Add(((IEntityBuilder<MDAttendanceLeaveHolidayListEntity>)this).BuildEntity(reader));
            }

            return (MDAttendanceLeaveHolidayListEntityList.Count > 0) ? MDAttendanceLeaveHolidayListEntityList : null;
        }

        MDAttendanceLeaveHolidayListEntity IEntityBuilder<MDAttendanceLeaveHolidayListEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ATTENDANCELEAVEHOLIDAYLISTID = 0;
            const Int32 FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_CODE = 4;
            const Int32 FLD_COLOR = 5;

            MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity = new MDAttendanceLeaveHolidayListEntity();

            mDAttendanceLeaveHolidayListEntity.AttendanceLeaveHolidayListID = reader.GetInt64(FLD_ATTENDANCELEAVEHOLIDAYLISTID);
            mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID = reader.GetInt64(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID);
            mDAttendanceLeaveHolidayListEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAttendanceLeaveHolidayListEntity.Description = String.Empty; } else { mDAttendanceLeaveHolidayListEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDAttendanceLeaveHolidayListEntity.Code = reader.GetString(FLD_CODE);
            mDAttendanceLeaveHolidayListEntity.Color = reader.GetString(FLD_COLOR);

            return mDAttendanceLeaveHolidayListEntity;
        }
    }
}
