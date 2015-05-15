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
    internal sealed class KBUserTreeSharedBuilder : IEntityBuilder<KBUserTreeSharedEntity>
    {
        IList<KBUserTreeSharedEntity> IEntityBuilder<KBUserTreeSharedEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTreeSharedEntity> KBUserTreeSharedEntityList = new List<KBUserTreeSharedEntity>();

            while (reader.Read())
            {
                KBUserTreeSharedEntityList.Add(((IEntityBuilder<KBUserTreeSharedEntity>)this).BuildEntity(reader));
            }

            return (KBUserTreeSharedEntityList.Count > 0) ? KBUserTreeSharedEntityList : null;
        }

        KBUserTreeSharedEntity IEntityBuilder<KBUserTreeSharedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREESHAREDID = 0;
            const Int32 FLD_USERTREEID = 1;
            const Int32 FLD_USERTREESETTINGID = 2;
            const Int32 FLD_MESSAGE = 3;
            const Int32 FLD_SHAREDGIVENBYEMPLOYEEID = 4;
            const Int32 FLD_SHAREDDATETIME = 5;
            const Int32 FLD_SHAREDGIVENTOEMPLOYEEID = 6;
            const Int32 FLD_IP = 7;
            const Int32 FLD_USERTREEPERMISSIONID = 8;

            KBUserTreeSharedEntity kBUserTreeSharedEntity = new KBUserTreeSharedEntity();

            kBUserTreeSharedEntity.UserTreeSharedID = reader.GetInt64(FLD_USERTREESHAREDID);
            kBUserTreeSharedEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            kBUserTreeSharedEntity.UserTreeSettingID = reader.GetInt64(FLD_USERTREESETTINGID);
            if (reader.IsDBNull(FLD_MESSAGE)) { kBUserTreeSharedEntity.Message = String.Empty; } else { kBUserTreeSharedEntity.Message = reader.GetString(FLD_MESSAGE); }
            kBUserTreeSharedEntity.SharedGivenByEmployeeID = reader.GetInt64(FLD_SHAREDGIVENBYEMPLOYEEID);
            kBUserTreeSharedEntity.SharedDateTime = reader.GetDateTime(FLD_SHAREDDATETIME);
            kBUserTreeSharedEntity.SharedGivenToEmployeeID = reader.GetInt64(FLD_SHAREDGIVENTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { kBUserTreeSharedEntity.IP = String.Empty; } else { kBUserTreeSharedEntity.IP = reader.GetString(FLD_IP); }
            kBUserTreeSharedEntity.UserTreePermissionID = reader.GetInt64(FLD_USERTREEPERMISSIONID);

            return kBUserTreeSharedEntity;
        }
    }
}
