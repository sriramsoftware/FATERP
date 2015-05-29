// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 07:14:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDZoneBuilder : IEntityBuilder<MDZoneEntity>
    {
        IList<MDZoneEntity> IEntityBuilder<MDZoneEntity>.BuildEntities(IDataReader reader)
        {
            List<MDZoneEntity> MDZoneEntityList = new List<MDZoneEntity>();

            while (reader.Read())
            {
                MDZoneEntityList.Add(((IEntityBuilder<MDZoneEntity>)this).BuildEntity(reader));
            }

            return (MDZoneEntityList.Count > 0) ? MDZoneEntityList : null;
        }

        MDZoneEntity IEntityBuilder<MDZoneEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ZONEID = 0;
            const Int32 FLD_ZONECODE = 1;
            const Int32 FLD_ZONENAME = 2;
            const Int32 FLD_DESCRIPTON = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDZoneEntity mDZoneEntity = new MDZoneEntity();

            mDZoneEntity.ZoneID = reader.GetInt64(FLD_ZONEID);
            mDZoneEntity.ZoneCode = reader.GetString(FLD_ZONECODE);
            mDZoneEntity.ZoneName = reader.GetString(FLD_ZONENAME);
            if (reader.IsDBNull(FLD_DESCRIPTON)) { mDZoneEntity.Descripton = String.Empty; } else { mDZoneEntity.Descripton = reader.GetString(FLD_DESCRIPTON); }
            mDZoneEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDZoneEntity;
        }
    }
}
