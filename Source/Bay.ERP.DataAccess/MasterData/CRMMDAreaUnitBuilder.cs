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
    internal sealed class CRMMDAreaUnitBuilder : IEntityBuilder<CRMMDAreaUnitEntity>
    {
        IList<CRMMDAreaUnitEntity> IEntityBuilder<CRMMDAreaUnitEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAreaUnitEntity> CRMMDAreaUnitEntityList = new List<CRMMDAreaUnitEntity>();

            while (reader.Read())
            {
                CRMMDAreaUnitEntityList.Add(((IEntityBuilder<CRMMDAreaUnitEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAreaUnitEntityList.Count > 0) ? CRMMDAreaUnitEntityList : null;
        }

        CRMMDAreaUnitEntity IEntityBuilder<CRMMDAreaUnitEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AREAUNITID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDAreaUnitEntity cRMMDAreaUnitEntity = new CRMMDAreaUnitEntity();

            cRMMDAreaUnitEntity.AreaUnitID = reader.GetInt64(FLD_AREAUNITID);
            cRMMDAreaUnitEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDAreaUnitEntity.Description = String.Empty; } else { cRMMDAreaUnitEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDAreaUnitEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAreaUnitEntity;
        }
    }
}
