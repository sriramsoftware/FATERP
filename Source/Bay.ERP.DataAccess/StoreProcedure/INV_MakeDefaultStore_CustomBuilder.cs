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
    internal sealed class INV_MakeDefaultStore_CustomBuilder : IEntityBuilder<INV_MakeDefaultStore_CustomEntity>
    {
        IList<INV_MakeDefaultStore_CustomEntity> IEntityBuilder<INV_MakeDefaultStore_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<INV_MakeDefaultStore_CustomEntity> INV_MakeDefaultStore_CustomEntityList = new List<INV_MakeDefaultStore_CustomEntity>();

            while (reader.Read())
            {
                INV_MakeDefaultStore_CustomEntityList.Add(((IEntityBuilder<INV_MakeDefaultStore_CustomEntity>)this).BuildEntity(reader));
            }

            return (INV_MakeDefaultStore_CustomEntityList.Count > 0) ? INV_MakeDefaultStore_CustomEntityList : null;
        }

        INV_MakeDefaultStore_CustomEntity IEntityBuilder<INV_MakeDefaultStore_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_NORETURNID = 0;

            INV_MakeDefaultStore_CustomEntity iNV_MakeDefaultStore_CustomEntity = new INV_MakeDefaultStore_CustomEntity();

            iNV_MakeDefaultStore_CustomEntity.NoReturnID = reader.GetInt32(FLD_NORETURNID);

            return iNV_MakeDefaultStore_CustomEntity;
        }
    }
}
