// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAddressTypeBuilder : IEntityBuilder<MDAddressTypeEntity>
    {
        IList<MDAddressTypeEntity> IEntityBuilder<MDAddressTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAddressTypeEntity> MDAddressTypeEntityList = new List<MDAddressTypeEntity>();

            while (reader.Read())
            {
                MDAddressTypeEntityList.Add(((IEntityBuilder<MDAddressTypeEntity>)this).BuildEntity(reader));
            }

            return (MDAddressTypeEntityList.Count > 0) ? MDAddressTypeEntityList : null;
        }

        MDAddressTypeEntity IEntityBuilder<MDAddressTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ADDRESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;

            MDAddressTypeEntity mDAddressTypeEntity = new MDAddressTypeEntity();

            mDAddressTypeEntity.AddressTypeID = reader.GetInt64(FLD_ADDRESSTYPEID);
            mDAddressTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDAddressTypeEntity.Description = String.Empty; } else { mDAddressTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return mDAddressTypeEntity;
        }
    }
}
