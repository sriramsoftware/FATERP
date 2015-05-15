// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDVendorCategoryBuilder : IEntityBuilder<MDVendorCategoryEntity>
    {
        IList<MDVendorCategoryEntity> IEntityBuilder<MDVendorCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDVendorCategoryEntity> MDVendorCategoryEntityList = new List<MDVendorCategoryEntity>();

            while (reader.Read())
            {
                MDVendorCategoryEntityList.Add(((IEntityBuilder<MDVendorCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDVendorCategoryEntityList.Count > 0) ? MDVendorCategoryEntityList : null;
        }

        MDVendorCategoryEntity IEntityBuilder<MDVendorCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_VENDORCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDVendorCategoryEntity mDVendorCategoryEntity = new MDVendorCategoryEntity();

            mDVendorCategoryEntity.VendorCategoryID = reader.GetInt64(FLD_VENDORCATEGORYID);
            mDVendorCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDVendorCategoryEntity.Description = String.Empty; } else { mDVendorCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDVendorCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDVendorCategoryEntity;
        }
    }
}
