// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Feb-2012, 10:17:53




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplier_DetailedBuilder : IEntityBuilder<PRMSupplier_DetailedEntity>
    {
        IList<PRMSupplier_DetailedEntity> IEntityBuilder<PRMSupplier_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplier_DetailedEntity> PRMSupplier_DetailedEntityList = new List<PRMSupplier_DetailedEntity>();

            while (reader.Read())
            {
                PRMSupplier_DetailedEntityList.Add(((IEntityBuilder<PRMSupplier_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplier_DetailedEntityList.Count > 0) ? PRMSupplier_DetailedEntityList : null;
        }

        PRMSupplier_DetailedEntity IEntityBuilder<PRMSupplier_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_SUPPLIERSTATUSID = 9;
            const Int32 FLD_REASON = 10;
            const Int32 FLD_ISREMOVED = 11;
            const Int32 FLD_SUPPLIERSTATUS = 12;
            const Int32 FLD_ROWNUMBER = 13;

            PRMSupplier_DetailedEntity pRMSupplier_DetailedEntity = new PRMSupplier_DetailedEntity();

            pRMSupplier_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            if (reader.IsDBNull(FLD_SUPPLIERCODE)) { pRMSupplier_DetailedEntity.SupplierCode = String.Empty; } else { pRMSupplier_DetailedEntity.SupplierCode = reader.GetString(FLD_SUPPLIERCODE); }
            pRMSupplier_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME);
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { pRMSupplier_DetailedEntity.Relationship = String.Empty; } else { pRMSupplier_DetailedEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplier_DetailedEntity.Phone = String.Empty; } else { pRMSupplier_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMSupplier_DetailedEntity.MobileNo = String.Empty; } else { pRMSupplier_DetailedEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { pRMSupplier_DetailedEntity.Fax = String.Empty; } else { pRMSupplier_DetailedEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplier_DetailedEntity.Email = String.Empty; } else { pRMSupplier_DetailedEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplier_DetailedEntity.WebLink = String.Empty; } else { pRMSupplier_DetailedEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            pRMSupplier_DetailedEntity.SupplierStatusID = reader.GetInt64(FLD_SUPPLIERSTATUSID);
            if (reader.IsDBNull(FLD_REASON)) { pRMSupplier_DetailedEntity.Reason = String.Empty; } else { pRMSupplier_DetailedEntity.Reason = reader.GetString(FLD_REASON); }
            pRMSupplier_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_SUPPLIERSTATUS)) { pRMSupplier_DetailedEntity.SupplierStatus = String.Empty; } else { pRMSupplier_DetailedEntity.SupplierStatus = reader.GetString(FLD_SUPPLIERSTATUS); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMSupplier_DetailedEntity.RowNumber = null; } else { pRMSupplier_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMSupplier_DetailedEntity;
        }
    }
}
