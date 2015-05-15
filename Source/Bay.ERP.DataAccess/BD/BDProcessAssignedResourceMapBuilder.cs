// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:43:35




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProcessAssignedResourceMapBuilder : IEntityBuilder<BDProcessAssignedResourceMapEntity>
    {
        IList<BDProcessAssignedResourceMapEntity> IEntityBuilder<BDProcessAssignedResourceMapEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProcessAssignedResourceMapEntity> BDProcessAssignedResourceMapEntityList = new List<BDProcessAssignedResourceMapEntity>();

            while (reader.Read())
            {
                BDProcessAssignedResourceMapEntityList.Add(((IEntityBuilder<BDProcessAssignedResourceMapEntity>)this).BuildEntity(reader));
            }

            return (BDProcessAssignedResourceMapEntityList.Count > 0) ? BDProcessAssignedResourceMapEntityList : null;
        }

        BDProcessAssignedResourceMapEntity IEntityBuilder<BDProcessAssignedResourceMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROCESSASSIGNEDRESOURCEMAPID = 0;
            const Int32 FLD_PROCESSASSIGNEDRESOURCEID = 1;
            const Int32 FLD_RESOURCECATEGORYID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_RESOURCENAME = 4;
            const Int32 FLD_RESOURCEDESIGNATION = 5;
            const Int32 FLD_RESOURCECOMPANY = 6;
            const Int32 FLD_RESOURCEMOBILENO = 7;
            const Int32 FLD_RESOURCEEMAIL = 8;
            const Int32 FLD_ADDRESSLINE1 = 9;
            const Int32 FLD_ADDRESSLINE2 = 10;
            const Int32 FLD_RESOURCETYPEID = 11;
            const Int32 FLD_RESOURCEDOB = 12;
            const Int32 FLD_REMARKS = 13;

            BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();

            bDProcessAssignedResourceMapEntity.ProcessAssignedResourceMapID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEMAPID);
            bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEID);
            bDProcessAssignedResourceMapEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            bDProcessAssignedResourceMapEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            bDProcessAssignedResourceMapEntity.ResourceName = reader.GetString(FLD_RESOURCENAME);
            if (reader.IsDBNull(FLD_RESOURCEDESIGNATION)) { bDProcessAssignedResourceMapEntity.ResourceDesignation = String.Empty; } else { bDProcessAssignedResourceMapEntity.ResourceDesignation = reader.GetString(FLD_RESOURCEDESIGNATION); }
            if (reader.IsDBNull(FLD_RESOURCECOMPANY)) { bDProcessAssignedResourceMapEntity.ResourceCompany = String.Empty; } else { bDProcessAssignedResourceMapEntity.ResourceCompany = reader.GetString(FLD_RESOURCECOMPANY); }
            if (reader.IsDBNull(FLD_RESOURCEMOBILENO)) { bDProcessAssignedResourceMapEntity.ResourceMobileNo = String.Empty; } else { bDProcessAssignedResourceMapEntity.ResourceMobileNo = reader.GetString(FLD_RESOURCEMOBILENO); }
            if (reader.IsDBNull(FLD_RESOURCEEMAIL)) { bDProcessAssignedResourceMapEntity.ResourceEmail = String.Empty; } else { bDProcessAssignedResourceMapEntity.ResourceEmail = reader.GetString(FLD_RESOURCEEMAIL); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { bDProcessAssignedResourceMapEntity.AddressLine1 = String.Empty; } else { bDProcessAssignedResourceMapEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProcessAssignedResourceMapEntity.AddressLine2 = String.Empty; } else { bDProcessAssignedResourceMapEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_RESOURCETYPEID)) { bDProcessAssignedResourceMapEntity.ResourceTypeID = null; } else { bDProcessAssignedResourceMapEntity.ResourceTypeID = reader.GetInt64(FLD_RESOURCETYPEID); }
            if (reader.IsDBNull(FLD_RESOURCEDOB)) { bDProcessAssignedResourceMapEntity.ResourceDOB = null; } else { bDProcessAssignedResourceMapEntity.ResourceDOB = reader.GetDateTime(FLD_RESOURCEDOB); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProcessAssignedResourceMapEntity.Remarks = String.Empty; } else { bDProcessAssignedResourceMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return bDProcessAssignedResourceMapEntity;
        }
    }
}
