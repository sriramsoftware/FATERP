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
    internal sealed class CMNMDEventIdentityCategoryBuilder : IEntityBuilder<CMNMDEventIdentityCategoryEntity>
    {
        IList<CMNMDEventIdentityCategoryEntity> IEntityBuilder<CMNMDEventIdentityCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNMDEventIdentityCategoryEntity> CMNMDEventIdentityCategoryEntityList = new List<CMNMDEventIdentityCategoryEntity>();

            while (reader.Read())
            {
                CMNMDEventIdentityCategoryEntityList.Add(((IEntityBuilder<CMNMDEventIdentityCategoryEntity>)this).BuildEntity(reader));
            }

            return (CMNMDEventIdentityCategoryEntityList.Count > 0) ? CMNMDEventIdentityCategoryEntityList : null;
        }

        CMNMDEventIdentityCategoryEntity IEntityBuilder<CMNMDEventIdentityCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTIDENTITYCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity = new CMNMDEventIdentityCategoryEntity();

            cMNMDEventIdentityCategoryEntity.EventIdentityCategoryID = reader.GetInt64(FLD_EVENTIDENTITYCATEGORYID);
            cMNMDEventIdentityCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cMNMDEventIdentityCategoryEntity.Description = String.Empty; } else { cMNMDEventIdentityCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cMNMDEventIdentityCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNMDEventIdentityCategoryEntity;
        }
    }
}
