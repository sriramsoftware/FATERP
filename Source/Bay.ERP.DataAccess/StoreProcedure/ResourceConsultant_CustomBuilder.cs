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
    internal sealed class ResourceConsultant_CustomBuilder : IEntityBuilder<ResourceConsultant_CustomEntity>
    {
        IList<ResourceConsultant_CustomEntity> IEntityBuilder<ResourceConsultant_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ResourceConsultant_CustomEntity> ResourceConsultant_CustomEntityList = new List<ResourceConsultant_CustomEntity>();

            while (reader.Read())
            {
                ResourceConsultant_CustomEntityList.Add(((IEntityBuilder<ResourceConsultant_CustomEntity>)this).BuildEntity(reader));
            }

            return (ResourceConsultant_CustomEntityList.Count > 0) ? ResourceConsultant_CustomEntityList : null;
        }

        ResourceConsultant_CustomEntity IEntityBuilder<ResourceConsultant_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_RESOURCECATEGORYID = 2;
            const Int32 FLD_RESOURCECATEGORYNAME = 3;
            const Int32 FLD_CMCONSULTANTNAME = 4;

            ResourceConsultant_CustomEntity resourceConsultant_CustomEntity = new ResourceConsultant_CustomEntity();

            resourceConsultant_CustomEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            resourceConsultant_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            resourceConsultant_CustomEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            resourceConsultant_CustomEntity.ResourceCategoryName = reader.GetString(FLD_RESOURCECATEGORYNAME);
            resourceConsultant_CustomEntity.CMConsultantName = reader.GetString(FLD_CMCONSULTANTNAME);

            return resourceConsultant_CustomEntity;
        }
    }
}
