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
    internal sealed class CRMMDCustomerAddressTypeBuilder : IEntityBuilder<CRMMDCustomerAddressTypeEntity>
    {
        IList<CRMMDCustomerAddressTypeEntity> IEntityBuilder<CRMMDCustomerAddressTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDCustomerAddressTypeEntity> CRMMDCustomerAddressTypeEntityList = new List<CRMMDCustomerAddressTypeEntity>();

            while (reader.Read())
            {
                CRMMDCustomerAddressTypeEntityList.Add(((IEntityBuilder<CRMMDCustomerAddressTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDCustomerAddressTypeEntityList.Count > 0) ? CRMMDCustomerAddressTypeEntityList : null;
        }

        CRMMDCustomerAddressTypeEntity IEntityBuilder<CRMMDCustomerAddressTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CUSTOMERADDRESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDCustomerAddressTypeEntity cRMMDCustomerAddressTypeEntity = new CRMMDCustomerAddressTypeEntity();

            cRMMDCustomerAddressTypeEntity.CustomerAddressTypeID = reader.GetInt64(FLD_CUSTOMERADDRESSTYPEID);
            cRMMDCustomerAddressTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDCustomerAddressTypeEntity.Description = String.Empty; } else { cRMMDCustomerAddressTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDCustomerAddressTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDCustomerAddressTypeEntity;
        }
    }
}
