// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-May-2012, 11:38:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierBuilder : IEntityBuilder<PRMSupplierEntity>
    {
        IList<PRMSupplierEntity> IEntityBuilder<PRMSupplierEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierEntity> PRMSupplierEntityList = new List<PRMSupplierEntity>();

            while (reader.Read())
            {
                PRMSupplierEntityList.Add(((IEntityBuilder<PRMSupplierEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierEntityList.Count > 0) ? PRMSupplierEntityList : null;
        }

        PRMSupplierEntity IEntityBuilder<PRMSupplierEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERID = 0;
            const Int32 FLD_SUPPLIERCODE = 1;
            const Int32 FLD_SUPPLIERNAME = 2;
            const Int32 FLD_RELATIONSHIP = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_FAX = 6;
            const Int32 FLD_EMAIL = 7;
            const Int32 FLD_WEBLINK = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_REMARKS = 10;
            const Int32 FLD_SUPPLIERTYPEID = 11;
            const Int32 FLD_SUPPLIERSTATUSID = 12;
            const Int32 FLD_REASON = 13;
            const Int32 FLD_ISREMOVED = 14;

            PRMSupplierEntity pRMSupplierEntity = new PRMSupplierEntity();

            pRMSupplierEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMSupplierEntity.SupplierCode = String.Empty; } else { pRMSupplierEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMSupplierEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMSupplierEntity.Relationship = String.Empty; } else { pRMSupplierEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierEntity.Phone = String.Empty; } else { pRMSupplierEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMSupplierEntity.MobileNo = String.Empty; } else { pRMSupplierEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { pRMSupplierEntity.Fax = String.Empty; } else { pRMSupplierEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplierEntity.Email = String.Empty; } else { pRMSupplierEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplierEntity.WebLink = String.Empty; } else { pRMSupplierEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            pRMSupplierEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { pRMSupplierEntity.Remarks = String.Empty; } else { pRMSupplierEntity.Remarks = reader.GetString(FLD_REMARKS); }
            pRMSupplierEntity.SupplierTypeID = reader.GetInt64(FLD_SUPPLIERTYPEID);
            pRMSupplierEntity.SupplierStatusID = reader.GetInt64(FLD_SUPPLIERSTATUSID);
            if (reader.IsDBNull(FLD_REASON)) { pRMSupplierEntity.Reason = String.Empty; } else { pRMSupplierEntity.Reason = reader.GetString(FLD_REASON); }
            pRMSupplierEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return pRMSupplierEntity;
        }
    }
}
