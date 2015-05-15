// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSupplierAddressTypeBuilder : IEntityBuilder<MDSupplierAddressTypeEntity>
    {
        IList<MDSupplierAddressTypeEntity> IEntityBuilder<MDSupplierAddressTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSupplierAddressTypeEntity> MDSupplierAddressTypeEntityList = new List<MDSupplierAddressTypeEntity>();

            while (reader.Read())
            {
                MDSupplierAddressTypeEntityList.Add(((IEntityBuilder<MDSupplierAddressTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSupplierAddressTypeEntityList.Count > 0) ? MDSupplierAddressTypeEntityList : null;
        }

        MDSupplierAddressTypeEntity IEntityBuilder<MDSupplierAddressTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERADDRESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSupplierAddressTypeEntity mDSupplierAddressTypeEntity = new MDSupplierAddressTypeEntity();

            mDSupplierAddressTypeEntity.SupplierAddressTypeID = reader.GetInt64(FLD_SUPPLIERADDRESSTYPEID);
            mDSupplierAddressTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSupplierAddressTypeEntity.Description = String.Empty; } else { mDSupplierAddressTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSupplierAddressTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSupplierAddressTypeEntity;
        }
    }
}
