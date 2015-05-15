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
    internal sealed class CRMMDAdvertiseWayBuilder : IEntityBuilder<CRMMDAdvertiseWayEntity>
    {
        IList<CRMMDAdvertiseWayEntity> IEntityBuilder<CRMMDAdvertiseWayEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAdvertiseWayEntity> CRMMDAdvertiseWayEntityList = new List<CRMMDAdvertiseWayEntity>();

            while (reader.Read())
            {
                CRMMDAdvertiseWayEntityList.Add(((IEntityBuilder<CRMMDAdvertiseWayEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAdvertiseWayEntityList.Count > 0) ? CRMMDAdvertiseWayEntityList : null;
        }

        CRMMDAdvertiseWayEntity IEntityBuilder<CRMMDAdvertiseWayEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ADVERTISEWAYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity = new CRMMDAdvertiseWayEntity();

            cRMMDAdvertiseWayEntity.AdvertiseWayID = reader.GetInt64(FLD_ADVERTISEWAYID);
            cRMMDAdvertiseWayEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDAdvertiseWayEntity.Description = String.Empty; } else { cRMMDAdvertiseWayEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDAdvertiseWayEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAdvertiseWayEntity;
        }
    }
}
