// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierContactPersonBuilder : IEntityBuilder<PRMSupplierContactPersonEntity>
    {
        IList<PRMSupplierContactPersonEntity> IEntityBuilder<PRMSupplierContactPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierContactPersonEntity> PRMSupplierContactPersonEntityList = new List<PRMSupplierContactPersonEntity>();

            while (reader.Read())
            {
                PRMSupplierContactPersonEntityList.Add(((IEntityBuilder<PRMSupplierContactPersonEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierContactPersonEntityList.Count > 0) ? PRMSupplierContactPersonEntityList : null;
        }

        PRMSupplierContactPersonEntity IEntityBuilder<PRMSupplierContactPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERCONTACTPERSONID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESIGNATION = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_FAX = 6;
            const Int32 FLD_EMAIL = 7;
            const Int32 FLD_WEBLINK = 8;

            PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity = new PRMSupplierContactPersonEntity();

            pRMSupplierContactPersonEntity.SupplierContactPersonID = reader.GetInt64(FLD_SUPPLIERCONTACTPERSONID);
            pRMSupplierContactPersonEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMSupplierContactPersonEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { pRMSupplierContactPersonEntity.Designation = String.Empty; } else { pRMSupplierContactPersonEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_PHONE)) { pRMSupplierContactPersonEntity.Phone = String.Empty; } else { pRMSupplierContactPersonEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { pRMSupplierContactPersonEntity.MobileNo = String.Empty; } else { pRMSupplierContactPersonEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { pRMSupplierContactPersonEntity.Fax = String.Empty; } else { pRMSupplierContactPersonEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { pRMSupplierContactPersonEntity.Email = String.Empty; } else { pRMSupplierContactPersonEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { pRMSupplierContactPersonEntity.WebLink = String.Empty; } else { pRMSupplierContactPersonEntity.WebLink = reader.GetString(FLD_WEBLINK); }

            return pRMSupplierContactPersonEntity;
        }
    }
}
