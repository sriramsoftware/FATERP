// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-May-2012, 12:01:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierView_CustomBuilder : IEntityBuilder<PRMSupplierView_CustomEntity>
    {
        IList<PRMSupplierView_CustomEntity> IEntityBuilder<PRMSupplierView_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierView_CustomEntity> PRMSupplierView_CustomEntityList = new List<PRMSupplierView_CustomEntity>();

            while (reader.Read())
            {
                PRMSupplierView_CustomEntityList.Add(((IEntityBuilder<PRMSupplierView_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierView_CustomEntityList.Count > 0) ? PRMSupplierView_CustomEntityList : null;
        }

        PRMSupplierView_CustomEntity IEntityBuilder<PRMSupplierView_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERID = 0;
            const Int32 FLD_SUPPLIERCODE = 1;
            const Int32 FLD_SUPPLIERNAME = 2;
            const Int32 FLD_RELATIONSHIP = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_EMAIL = 5;
            const Int32 FLD_FAX = 6;
            const Int32 FLD_MOBILENO = 7;
            const Int32 FLD_WEBLINK = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_SUPPLIERTYPEID = 10;
            const Int32 FLD_SUPPLIERSTATUSID = 11;
            const Int32 FLD_SUPPLIERTYPENAME = 12;
            const Int32 FLD_SUPPLIERSTATUSNAME = 13;
            const Int32 FLD_SUPPLIERITEMCATEGORYID = 14;
            const Int32 FLD_SUPPLIERITEMCATEGORYNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            PRMSupplierView_CustomEntity pRMSupplierView_CustomEntity = new PRMSupplierView_CustomEntity();

            pRMSupplierView_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMSupplierView_CustomEntity.SupplierCode = String.Empty; } else { pRMSupplierView_CustomEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMSupplierView_CustomEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMSupplierView_CustomEntity.Relationship = String.Empty; } else { pRMSupplierView_CustomEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierView_CustomEntity.Phone = String.Empty; } else { pRMSupplierView_CustomEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplierView_CustomEntity.Email = String.Empty; } else { pRMSupplierView_CustomEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_FAX)) { pRMSupplierView_CustomEntity.Fax = String.Empty; } else { pRMSupplierView_CustomEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMSupplierView_CustomEntity.MobileNo = String.Empty; } else { pRMSupplierView_CustomEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplierView_CustomEntity.WebLink = String.Empty; } else { pRMSupplierView_CustomEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            pRMSupplierView_CustomEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            pRMSupplierView_CustomEntity.SupplierTypeID = reader.GetInt64(FLD_SUPPLIERTYPEID);
            pRMSupplierView_CustomEntity.SupplierStatusID = reader.GetInt64(FLD_SUPPLIERSTATUSID);
            pRMSupplierView_CustomEntity.SupplierTypeName = reader.GetString(FLD_SUPPLIERTYPENAME);
            pRMSupplierView_CustomEntity.SupplierStatusName = reader.GetString(FLD_SUPPLIERSTATUSNAME);
            if (reader.IsDBNull(FLD_SUPPLIERITEMCATEGORYID)) { pRMSupplierView_CustomEntity.SupplierItemCategoryID = null; } else { pRMSupplierView_CustomEntity.SupplierItemCategoryID = reader.GetInt64(FLD_SUPPLIERITEMCATEGORYID); }
            if (reader.IsDBNull(FLD_SUPPLIERITEMCATEGORYNAME)) { pRMSupplierView_CustomEntity.SupplierItemCategoryName = String.Empty; } else { pRMSupplierView_CustomEntity.SupplierItemCategoryName = reader.GetString(FLD_SUPPLIERITEMCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMSupplierView_CustomEntity.RowNumber = null; } else { pRMSupplierView_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMSupplierView_CustomEntity;
        }
    }
}
