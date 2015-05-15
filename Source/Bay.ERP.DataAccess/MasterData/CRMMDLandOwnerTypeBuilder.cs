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
    internal sealed class CRMMDLandOwnerTypeBuilder : IEntityBuilder<CRMMDLandOwnerTypeEntity>
    {
        IList<CRMMDLandOwnerTypeEntity> IEntityBuilder<CRMMDLandOwnerTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDLandOwnerTypeEntity> CRMMDLandOwnerTypeEntityList = new List<CRMMDLandOwnerTypeEntity>();

            while (reader.Read())
            {
                CRMMDLandOwnerTypeEntityList.Add(((IEntityBuilder<CRMMDLandOwnerTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDLandOwnerTypeEntityList.Count > 0) ? CRMMDLandOwnerTypeEntityList : null;
        }

        CRMMDLandOwnerTypeEntity IEntityBuilder<CRMMDLandOwnerTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LANDOWNERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDLandOwnerTypeEntity cRMMDLandOwnerTypeEntity = new CRMMDLandOwnerTypeEntity();

            cRMMDLandOwnerTypeEntity.LandOwnerTypeID = reader.GetInt64(FLD_LANDOWNERTYPEID);
            cRMMDLandOwnerTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDLandOwnerTypeEntity.Description = String.Empty; } else { cRMMDLandOwnerTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDLandOwnerTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDLandOwnerTypeEntity;
        }
    }
}
