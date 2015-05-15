// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSupplierItemCategoryBuilder : IEntityBuilder<MDSupplierItemCategoryEntity>
    {
        IList<MDSupplierItemCategoryEntity> IEntityBuilder<MDSupplierItemCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSupplierItemCategoryEntity> MDSupplierItemCategoryEntityList = new List<MDSupplierItemCategoryEntity>();

            while (reader.Read())
            {
                MDSupplierItemCategoryEntityList.Add(((IEntityBuilder<MDSupplierItemCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDSupplierItemCategoryEntityList.Count > 0) ? MDSupplierItemCategoryEntityList : null;
        }

        MDSupplierItemCategoryEntity IEntityBuilder<MDSupplierItemCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDSupplierItemCategoryEntity mDSupplierItemCategoryEntity = new MDSupplierItemCategoryEntity();

            mDSupplierItemCategoryEntity.SupplierItemCategoryID = reader.GetInt64(FLD_SUPPLIERITEMCATEGORYID);
            mDSupplierItemCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDSupplierItemCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSupplierItemCategoryEntity;
        }
    }
}
