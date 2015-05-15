// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Feb-2012, 04:20:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ResourceContractor_CustomBuilder : IEntityBuilder<ResourceContractor_CustomEntity>
    {
        IList<ResourceContractor_CustomEntity> IEntityBuilder<ResourceContractor_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ResourceContractor_CustomEntity> ResourceContractor_CustomEntityList = new List<ResourceContractor_CustomEntity>();

            while (reader.Read())
            {
                ResourceContractor_CustomEntityList.Add(((IEntityBuilder<ResourceContractor_CustomEntity>)this).BuildEntity(reader));
            }

            return (ResourceContractor_CustomEntityList.Count > 0) ? ResourceContractor_CustomEntityList : null;
        }

        ResourceContractor_CustomEntity IEntityBuilder<ResourceContractor_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_RESOURCECATEGORYID = 2;
            const Int32 FLD_RESOURCECATEGORYNAME = 3;
            const Int32 FLD_CONTRACTORNAME = 4;

            ResourceContractor_CustomEntity resourceContractor_CustomEntity = new ResourceContractor_CustomEntity();

            resourceContractor_CustomEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            resourceContractor_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            resourceContractor_CustomEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            resourceContractor_CustomEntity.ResourceCategoryName = reader.GetString(FLD_RESOURCECATEGORYNAME);
            resourceContractor_CustomEntity.ContractorName = reader.GetString(FLD_CONTRACTORNAME);

            return resourceContractor_CustomEntity;
        }
    }
}
