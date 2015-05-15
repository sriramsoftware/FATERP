// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 03:50:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class INV_MakeDefaultStoreUnit_CustomBuilder : IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>
    {
        IList<INV_MakeDefaultStoreUnit_CustomEntity> IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<INV_MakeDefaultStoreUnit_CustomEntity> INV_MakeDefaultStoreUnit_CustomEntityList = new List<INV_MakeDefaultStoreUnit_CustomEntity>();

            while (reader.Read())
            {
                INV_MakeDefaultStoreUnit_CustomEntityList.Add(((IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>)this).BuildEntity(reader));
            }

            return (INV_MakeDefaultStoreUnit_CustomEntityList.Count > 0) ? INV_MakeDefaultStoreUnit_CustomEntityList : null;
        }

        INV_MakeDefaultStoreUnit_CustomEntity IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_NORETURNID = 0;

            INV_MakeDefaultStoreUnit_CustomEntity iNV_MakeDefaultStoreUnit_CustomEntity = new INV_MakeDefaultStoreUnit_CustomEntity();

            iNV_MakeDefaultStoreUnit_CustomEntity.NoReturnID = reader.GetInt32(FLD_NORETURNID);

            return iNV_MakeDefaultStoreUnit_CustomEntity;
        }
    }
}
