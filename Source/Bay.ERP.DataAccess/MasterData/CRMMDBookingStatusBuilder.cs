// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDBookingStatusBuilder : IEntityBuilder<CRMMDBookingStatusEntity>
    {
        IList<CRMMDBookingStatusEntity> IEntityBuilder<CRMMDBookingStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDBookingStatusEntity> CRMMDBookingStatusEntityList = new List<CRMMDBookingStatusEntity>();

            while (reader.Read())
            {
                CRMMDBookingStatusEntityList.Add(((IEntityBuilder<CRMMDBookingStatusEntity>)this).BuildEntity(reader));
            }

            return (CRMMDBookingStatusEntityList.Count > 0) ? CRMMDBookingStatusEntityList : null;
        }

        CRMMDBookingStatusEntity IEntityBuilder<CRMMDBookingStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOOKINGSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDBookingStatusEntity cRMMDBookingStatusEntity = new CRMMDBookingStatusEntity();

            cRMMDBookingStatusEntity.BookingStatusID = reader.GetInt64(FLD_BOOKINGSTATUSID);
            cRMMDBookingStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDBookingStatusEntity.Description = String.Empty; } else { cRMMDBookingStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDBookingStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDBookingStatusEntity;
        }
    }
}
