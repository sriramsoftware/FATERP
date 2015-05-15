// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class KBMDUserTreeSharedPermissionBuilder : IEntityBuilder<KBMDUserTreeSharedPermissionEntity>
    {
        IList<KBMDUserTreeSharedPermissionEntity> IEntityBuilder<KBMDUserTreeSharedPermissionEntity>.BuildEntities(IDataReader reader)
        {
            List<KBMDUserTreeSharedPermissionEntity> KBMDUserTreeSharedPermissionEntityList = new List<KBMDUserTreeSharedPermissionEntity>();

            while (reader.Read())
            {
                KBMDUserTreeSharedPermissionEntityList.Add(((IEntityBuilder<KBMDUserTreeSharedPermissionEntity>)this).BuildEntity(reader));
            }

            return (KBMDUserTreeSharedPermissionEntityList.Count > 0) ? KBMDUserTreeSharedPermissionEntityList : null;
        }

        KBMDUserTreeSharedPermissionEntity IEntityBuilder<KBMDUserTreeSharedPermissionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREESHAREDPERMISSIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity = new KBMDUserTreeSharedPermissionEntity();

            kBMDUserTreeSharedPermissionEntity.UserTreeSharedPermissionID = reader.GetInt64(FLD_USERTREESHAREDPERMISSIONID);
            kBMDUserTreeSharedPermissionEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { kBMDUserTreeSharedPermissionEntity.Remarks = String.Empty; } else { kBMDUserTreeSharedPermissionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            kBMDUserTreeSharedPermissionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return kBMDUserTreeSharedPermissionEntity;
        }
    }
}
