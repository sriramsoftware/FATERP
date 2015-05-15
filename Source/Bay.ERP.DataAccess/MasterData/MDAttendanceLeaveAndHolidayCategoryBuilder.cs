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
    internal sealed class MDAttendanceLeaveAndHolidayCategoryBuilder : IEntityBuilder<MDAttendanceLeaveAndHolidayCategoryEntity>
    {
        IList<MDAttendanceLeaveAndHolidayCategoryEntity> IEntityBuilder<MDAttendanceLeaveAndHolidayCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAttendanceLeaveAndHolidayCategoryEntity> MDAttendanceLeaveAndHolidayCategoryEntityList = new List<MDAttendanceLeaveAndHolidayCategoryEntity>();

            while (reader.Read())
            {
                MDAttendanceLeaveAndHolidayCategoryEntityList.Add(((IEntityBuilder<MDAttendanceLeaveAndHolidayCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDAttendanceLeaveAndHolidayCategoryEntityList.Count > 0) ? MDAttendanceLeaveAndHolidayCategoryEntityList : null;
        }

        MDAttendanceLeaveAndHolidayCategoryEntity IEntityBuilder<MDAttendanceLeaveAndHolidayCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDAttendanceLeaveAndHolidayCategoryEntity mDAttendanceLeaveAndHolidayCategoryEntity = new MDAttendanceLeaveAndHolidayCategoryEntity();

            mDAttendanceLeaveAndHolidayCategoryEntity.AttendanceLeaveAndHolidayCategoryID = reader.GetInt64(FLD_ATTENDANCELEAVEANDHOLIDAYCATEGORYID);
            mDAttendanceLeaveAndHolidayCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAttendanceLeaveAndHolidayCategoryEntity.Description = String.Empty; } else { mDAttendanceLeaveAndHolidayCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDAttendanceLeaveAndHolidayCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAttendanceLeaveAndHolidayCategoryEntity;
        }
    }
}
