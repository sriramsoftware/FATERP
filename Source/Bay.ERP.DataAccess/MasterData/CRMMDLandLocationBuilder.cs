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
    internal sealed class CRMMDLandLocationBuilder : IEntityBuilder<CRMMDLandLocationEntity>
    {
        IList<CRMMDLandLocationEntity> IEntityBuilder<CRMMDLandLocationEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDLandLocationEntity> CRMMDLandLocationEntityList = new List<CRMMDLandLocationEntity>();

            while (reader.Read())
            {
                CRMMDLandLocationEntityList.Add(((IEntityBuilder<CRMMDLandLocationEntity>)this).BuildEntity(reader));
            }

            return (CRMMDLandLocationEntityList.Count > 0) ? CRMMDLandLocationEntityList : null;
        }

        CRMMDLandLocationEntity IEntityBuilder<CRMMDLandLocationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LANDLOCATIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDLandLocationEntity cRMMDLandLocationEntity = new CRMMDLandLocationEntity();

            cRMMDLandLocationEntity.LandLocationID = reader.GetInt64(FLD_LANDLOCATIONID);
            cRMMDLandLocationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDLandLocationEntity.Description = String.Empty; } else { cRMMDLandLocationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDLandLocationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDLandLocationEntity;
        }
    }
}
