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
    internal sealed class CRMMDBuyerTypeBuilder : IEntityBuilder<CRMMDBuyerTypeEntity>
    {
        IList<CRMMDBuyerTypeEntity> IEntityBuilder<CRMMDBuyerTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDBuyerTypeEntity> CRMMDBuyerTypeEntityList = new List<CRMMDBuyerTypeEntity>();

            while (reader.Read())
            {
                CRMMDBuyerTypeEntityList.Add(((IEntityBuilder<CRMMDBuyerTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDBuyerTypeEntityList.Count > 0) ? CRMMDBuyerTypeEntityList : null;
        }

        CRMMDBuyerTypeEntity IEntityBuilder<CRMMDBuyerTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDBuyerTypeEntity cRMMDBuyerTypeEntity = new CRMMDBuyerTypeEntity();

            cRMMDBuyerTypeEntity.BuyerTypeID = reader.GetInt64(FLD_BUYERTYPEID);
            cRMMDBuyerTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDBuyerTypeEntity.Description = String.Empty; } else { cRMMDBuyerTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDBuyerTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDBuyerTypeEntity;
        }
    }
}
