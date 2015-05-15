// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 01:40:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProcessAssignedResourceMap_RPTBuilder : IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>
    {
        IList<BDProcessAssignedResourceMap_RPTEntity> IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProcessAssignedResourceMap_RPTEntity> BDProcessAssignedResourceMap_RPTEntityList = new List<BDProcessAssignedResourceMap_RPTEntity>();

            while (reader.Read())
            {
                BDProcessAssignedResourceMap_RPTEntityList.Add(((IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProcessAssignedResourceMap_RPTEntityList.Count > 0) ? BDProcessAssignedResourceMap_RPTEntityList : null;
        }

        BDProcessAssignedResourceMap_RPTEntity IEntityBuilder<BDProcessAssignedResourceMap_RPTEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_TITLE = 14;
            const Int32 FLD_PURPOSES = 15;

            BDProcessAssignedResourceMap_RPTEntity bDProcessAssignedResourceMap_RPTEntity = new BDProcessAssignedResourceMap_RPTEntity();

            bDProcessAssignedResourceMap_RPTEntity.ProcessAssignedResourceMapID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEMAPID);
            bDProcessAssignedResourceMap_RPTEntity.ProcessAssignedResourceID = reader.GetInt64(FLD_PROCESSASSIGNEDRESOURCEID);
            bDProcessAssignedResourceMap_RPTEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            bDProcessAssignedResourceMap_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            bDProcessAssignedResourceMap_RPTEntity.ResourceName = reader.GetString(FLD_RESOURCENAME);
            if (reader.IsDBNull(FLD_RESOURCEDESIGNATION)) { bDProcessAssignedResourceMap_RPTEntity.ResourceDesignation = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceDesignation = reader.GetString(FLD_RESOURCEDESIGNATION); }
            if (reader.IsDBNull(FLD_RESOURCECOMPANY)) { bDProcessAssignedResourceMap_RPTEntity.ResourceCompany = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceCompany = reader.GetString(FLD_RESOURCECOMPANY); }
            if (reader.IsDBNull(FLD_RESOURCEMOBILENO)) { bDProcessAssignedResourceMap_RPTEntity.ResourceMobileNo = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceMobileNo = reader.GetString(FLD_RESOURCEMOBILENO); }
            if (reader.IsDBNull(FLD_RESOURCEEMAIL)) { bDProcessAssignedResourceMap_RPTEntity.ResourceEmail = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceEmail = reader.GetString(FLD_RESOURCEEMAIL); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { bDProcessAssignedResourceMap_RPTEntity.AddressLine1 = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProcessAssignedResourceMap_RPTEntity.AddressLine2 = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_RESOURCETYPEID)) { bDProcessAssignedResourceMap_RPTEntity.ResourceTypeID = null; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceTypeID = reader.GetInt64(FLD_RESOURCETYPEID); }
            if (reader.IsDBNull(FLD_RESOURCEDOB)) { bDProcessAssignedResourceMap_RPTEntity.ResourceDOB = null; } else { bDProcessAssignedResourceMap_RPTEntity.ResourceDOB = reader.GetDateTime(FLD_RESOURCEDOB); }
            if (reader.IsDBNull(FLD_REMARKS)) { bDProcessAssignedResourceMap_RPTEntity.Remarks = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProcessAssignedResourceMap_RPTEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_PURPOSES)) { bDProcessAssignedResourceMap_RPTEntity.Purposes = String.Empty; } else { bDProcessAssignedResourceMap_RPTEntity.Purposes = reader.GetString(FLD_PURPOSES); }

            return bDProcessAssignedResourceMap_RPTEntity;
        }
    }
}
