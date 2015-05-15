// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ResourceBuilder : IEntityBuilder<ResourceEntity>
    {
        IList<ResourceEntity> IEntityBuilder<ResourceEntity>.BuildEntities(IDataReader reader)
        {
            List<ResourceEntity> ResourceEntityList = new List<ResourceEntity>();

            while (reader.Read())
            {
                ResourceEntityList.Add(((IEntityBuilder<ResourceEntity>)this).BuildEntity(reader));
            }

            return (ResourceEntityList.Count > 0) ? ResourceEntityList : null;
        }

        ResourceEntity IEntityBuilder<ResourceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_RESOURCECATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;

            ResourceEntity resourceEntity = new ResourceEntity();

            resourceEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            resourceEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            resourceEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);

            return resourceEntity;
        }
    }
}
