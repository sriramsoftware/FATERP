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
    internal sealed class PRMSupplierItemCategoryMapBuilder : IEntityBuilder<PRMSupplierItemCategoryMapEntity>
    {
        IList<PRMSupplierItemCategoryMapEntity> IEntityBuilder<PRMSupplierItemCategoryMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemCategoryMapEntity> PRMSupplierItemCategoryMapEntityList = new List<PRMSupplierItemCategoryMapEntity>();

            while (reader.Read())
            {
                PRMSupplierItemCategoryMapEntityList.Add(((IEntityBuilder<PRMSupplierItemCategoryMapEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemCategoryMapEntityList.Count > 0) ? PRMSupplierItemCategoryMapEntityList : null;
        }

        PRMSupplierItemCategoryMapEntity IEntityBuilder<PRMSupplierItemCategoryMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMCATEGORYMAPID = 0;
            const Int32 FLD_SUPPLIERITEMCATEGORYID = 1;
            const Int32 FLD_SUPPLIERID = 2;

            PRMSupplierItemCategoryMapEntity pRMSupplierItemCategoryMapEntity = new PRMSupplierItemCategoryMapEntity();

            pRMSupplierItemCategoryMapEntity.SupplierItemCategoryMapID = reader.GetInt64(FLD_SUPPLIERITEMCATEGORYMAPID);
            pRMSupplierItemCategoryMapEntity.SupplierItemCategoryID = reader.GetInt64(FLD_SUPPLIERITEMCATEGORYID);
            pRMSupplierItemCategoryMapEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);

            return pRMSupplierItemCategoryMapEntity;
        }
    }
}
