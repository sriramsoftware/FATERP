// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Mar-2013, 04:43:03




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class KBUserTreeShared_DetailedBuilder : IEntityBuilder<KBUserTreeShared_DetailedEntity>
    {
        IList<KBUserTreeShared_DetailedEntity> IEntityBuilder<KBUserTreeShared_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<KBUserTreeShared_DetailedEntity> KBUserTreeShared_DetailedEntityList = new List<KBUserTreeShared_DetailedEntity>();

            while (reader.Read())
            {
                KBUserTreeShared_DetailedEntityList.Add(((IEntityBuilder<KBUserTreeShared_DetailedEntity>)this).BuildEntity(reader));
            }

            return (KBUserTreeShared_DetailedEntityList.Count > 0) ? KBUserTreeShared_DetailedEntityList : null;
        }

        KBUserTreeShared_DetailedEntity IEntityBuilder<KBUserTreeShared_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_KBUSERTREEPARENTUSERTREEID = 9;
            const Int32 FLD_KBMDUSERTREESETTINGNAME = 10;
            const Int32 FLD_SHAREDGIVENBYEMPLOYEEFULLNAME = 11;
            const Int32 FLD_SHAREDGIVENTOEMPLOYEEFULLNAME = 12;
            const Int32 FLD_KBMDUSERTREESHAREDPERMISSIONNAME = 13;
            const Int32 FLD_ROWNUMBER = 14;

            KBUserTreeShared_DetailedEntity kBUserTreeShared_DetailedEntity = new KBUserTreeShared_DetailedEntity();

            kBUserTreeShared_DetailedEntity.UserTreeSharedID = reader.GetInt64(FLD_USERTREESHAREDID);
            kBUserTreeShared_DetailedEntity.UserTreeID = reader.GetInt64(FLD_USERTREEID);
            kBUserTreeShared_DetailedEntity.UserTreeSettingID = reader.GetInt64(FLD_USERTREESETTINGID);
            if (reader.IsDBNull(FLD_MESSAGE)) { kBUserTreeShared_DetailedEntity.Message = String.Empty; } else { kBUserTreeShared_DetailedEntity.Message = reader.GetString(FLD_MESSAGE); }
            kBUserTreeShared_DetailedEntity.SharedGivenByEmployeeID = reader.GetInt64(FLD_SHAREDGIVENBYEMPLOYEEID);
            kBUserTreeShared_DetailedEntity.SharedDateTime = reader.GetDateTime(FLD_SHAREDDATETIME);
            kBUserTreeShared_DetailedEntity.SharedGivenToEmployeeID = reader.GetInt64(FLD_SHAREDGIVENTOEMPLOYEEID);
            if (reader.IsDBNull(FLD_IP)) { kBUserTreeShared_DetailedEntity.IP = String.Empty; } else { kBUserTreeShared_DetailedEntity.IP = reader.GetString(FLD_IP); }
            kBUserTreeShared_DetailedEntity.UserTreePermissionID = reader.GetInt64(FLD_USERTREEPERMISSIONID);
            if (reader.IsDBNull(FLD_KBUSERTREEPARENTUSERTREEID)) { kBUserTreeShared_DetailedEntity.KBUserTreeParentUserTreeID = null; } else { kBUserTreeShared_DetailedEntity.KBUserTreeParentUserTreeID = reader.GetInt64(FLD_KBUSERTREEPARENTUSERTREEID); }
            if (reader.IsDBNull(FLD_KBMDUSERTREESETTINGNAME)) { kBUserTreeShared_DetailedEntity.KBMDUserTreeSettingName = String.Empty; } else { kBUserTreeShared_DetailedEntity.KBMDUserTreeSettingName = reader.GetString(FLD_KBMDUSERTREESETTINGNAME); }
            if (reader.IsDBNull(FLD_SHAREDGIVENBYEMPLOYEEFULLNAME)) { kBUserTreeShared_DetailedEntity.SharedGivenByEmployeeFullName = String.Empty; } else { kBUserTreeShared_DetailedEntity.SharedGivenByEmployeeFullName = reader.GetString(FLD_SHAREDGIVENBYEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_SHAREDGIVENTOEMPLOYEEFULLNAME)) { kBUserTreeShared_DetailedEntity.SharedGivenToEmployeeFullName = String.Empty; } else { kBUserTreeShared_DetailedEntity.SharedGivenToEmployeeFullName = reader.GetString(FLD_SHAREDGIVENTOEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_KBMDUSERTREESHAREDPERMISSIONNAME)) { kBUserTreeShared_DetailedEntity.KBMDUserTreeSharedPermissionName = String.Empty; } else { kBUserTreeShared_DetailedEntity.KBMDUserTreeSharedPermissionName = reader.GetString(FLD_KBMDUSERTREESHAREDPERMISSIONNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { kBUserTreeShared_DetailedEntity.RowNumber = null; } else { kBUserTreeShared_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return kBUserTreeShared_DetailedEntity;
        }
    }
}
