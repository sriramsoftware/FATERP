// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2013, 10:57:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNMDEventCategoryBuilder : IEntityBuilder<CMNMDEventCategoryEntity>
    {
        IList<CMNMDEventCategoryEntity> IEntityBuilder<CMNMDEventCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNMDEventCategoryEntity> CMNMDEventCategoryEntityList = new List<CMNMDEventCategoryEntity>();

            while (reader.Read())
            {
                CMNMDEventCategoryEntityList.Add(((IEntityBuilder<CMNMDEventCategoryEntity>)this).BuildEntity(reader));
            }

            return (CMNMDEventCategoryEntityList.Count > 0) ? CMNMDEventCategoryEntityList : null;
        }

        CMNMDEventCategoryEntity IEntityBuilder<CMNMDEventCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTCATEGORYID = 0;
            const Int32 FLD_EVENTIDENTITYCATEGORYID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            CMNMDEventCategoryEntity cMNMDEventCategoryEntity = new CMNMDEventCategoryEntity();

            cMNMDEventCategoryEntity.EventCategoryID = reader.GetInt64(FLD_EVENTCATEGORYID);
            cMNMDEventCategoryEntity.EventIdentityCategoryID = reader.GetInt64(FLD_EVENTIDENTITYCATEGORYID);
            cMNMDEventCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMNMDEventCategoryEntity.Description = String.Empty; } else { cMNMDEventCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMNMDEventCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNMDEventCategoryEntity;
        }
    }
}
