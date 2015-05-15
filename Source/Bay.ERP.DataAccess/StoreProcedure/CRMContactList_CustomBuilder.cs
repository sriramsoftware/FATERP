// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:25:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMContactList_CustomBuilder : IEntityBuilder<CRMContactList_CustomEntity>
    {
        IList<CRMContactList_CustomEntity> IEntityBuilder<CRMContactList_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMContactList_CustomEntity> CRMContactList_CustomEntityList = new List<CRMContactList_CustomEntity>();

            while (reader.Read())
            {
                CRMContactList_CustomEntityList.Add(((IEntityBuilder<CRMContactList_CustomEntity>)this).BuildEntity(reader));
            }

            return (CRMContactList_CustomEntityList.Count > 0) ? CRMContactList_CustomEntityList : null;
        }

        CRMContactList_CustomEntity IEntityBuilder<CRMContactList_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_RESOURCECATEGORYID = 1;
            const Int32 FLD_RESOURCENAME = 2;
            const Int32 FLD_RESOURCEDESIGNATION = 3;
            const Int32 FLD_RESOURCECOMPANY = 4;
            const Int32 FLD_RESOURCEMOBILENO = 5;
            const Int32 FLD_RESOURCEEMAIL = 6;
            const Int32 FLD_ADDRESSLINE1 = 7;
            const Int32 FLD_ADDRESSLINE2 = 8;
            const Int32 FLD_RESOURCETYPEID = 9;
            const Int32 FLD_RESOURCEDOB = 10;

            CRMContactList_CustomEntity cRMContactList_CustomEntity = new CRMContactList_CustomEntity();

            cRMContactList_CustomEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            cRMContactList_CustomEntity.ResourceCategoryID = reader.GetString(FLD_RESOURCECATEGORYID);
            if (reader.IsDBNull(FLD_RESOURCENAME)) { cRMContactList_CustomEntity.ResourceName = String.Empty; } else { cRMContactList_CustomEntity.ResourceName = reader.GetString(FLD_RESOURCENAME); }
            if (reader.IsDBNull(FLD_RESOURCEDESIGNATION)) { cRMContactList_CustomEntity.ResourceDesignation = String.Empty; } else { cRMContactList_CustomEntity.ResourceDesignation = reader.GetString(FLD_RESOURCEDESIGNATION); }
            if (reader.IsDBNull(FLD_RESOURCECOMPANY)) { cRMContactList_CustomEntity.ResourceCompany = String.Empty; } else { cRMContactList_CustomEntity.ResourceCompany = reader.GetString(FLD_RESOURCECOMPANY); }
            if (reader.IsDBNull(FLD_RESOURCEMOBILENO)) { cRMContactList_CustomEntity.ResourceMobileNo = String.Empty; } else { cRMContactList_CustomEntity.ResourceMobileNo = reader.GetString(FLD_RESOURCEMOBILENO); }
            if (reader.IsDBNull(FLD_RESOURCEEMAIL)) { cRMContactList_CustomEntity.ResourceEmail = String.Empty; } else { cRMContactList_CustomEntity.ResourceEmail = reader.GetString(FLD_RESOURCEEMAIL); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cRMContactList_CustomEntity.AddressLine1 = String.Empty; } else { cRMContactList_CustomEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cRMContactList_CustomEntity.AddressLine2 = String.Empty; } else { cRMContactList_CustomEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            cRMContactList_CustomEntity.ResourceTypeID = reader.GetInt64(FLD_RESOURCETYPEID);
            if (reader.IsDBNull(FLD_RESOURCEDOB)) { cRMContactList_CustomEntity.ResourceDOB = null; } else { cRMContactList_CustomEntity.ResourceDOB = reader.GetDateTime(FLD_RESOURCEDOB); }

            return cRMContactList_CustomEntity;
        }
    }
}
