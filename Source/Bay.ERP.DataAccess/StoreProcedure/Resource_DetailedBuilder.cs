// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class Resource_DetailedBuilder : IEntityBuilder<Resource_DetailedEntity>
    {
        IList<Resource_DetailedEntity> IEntityBuilder<Resource_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<Resource_DetailedEntity> Resource_DetailedEntityList = new List<Resource_DetailedEntity>();

            while (reader.Read())
            {
                Resource_DetailedEntityList.Add(((IEntityBuilder<Resource_DetailedEntity>)this).BuildEntity(reader));
            }

            return (Resource_DetailedEntityList.Count > 0) ? Resource_DetailedEntityList : null;
        }

        Resource_DetailedEntity IEntityBuilder<Resource_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEID = 0;
            const Int32 FLD_RESOURCECATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_RESOURCECATEGORYNAME = 3;
            const Int32 FLD_ROWNUMBER = 4;

            Resource_DetailedEntity resource_DetailedEntity = new Resource_DetailedEntity();

            resource_DetailedEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);
            resource_DetailedEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID);
            resource_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_RESOURCECATEGORYNAME)) { resource_DetailedEntity.ResourceCategoryName = String.Empty; } else { resource_DetailedEntity.ResourceCategoryName = reader.GetString(FLD_RESOURCECATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { resource_DetailedEntity.RowNumber = null; } else { resource_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return resource_DetailedEntity;
        }
    }
}
