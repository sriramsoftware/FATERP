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
    internal sealed class KBMDUserTreeSettingBuilder : IEntityBuilder<KBMDUserTreeSettingEntity>
    {
        IList<KBMDUserTreeSettingEntity> IEntityBuilder<KBMDUserTreeSettingEntity>.BuildEntities(IDataReader reader)
        {
            List<KBMDUserTreeSettingEntity> KBMDUserTreeSettingEntityList = new List<KBMDUserTreeSettingEntity>();

            while (reader.Read())
            {
                KBMDUserTreeSettingEntityList.Add(((IEntityBuilder<KBMDUserTreeSettingEntity>)this).BuildEntity(reader));
            }

            return (KBMDUserTreeSettingEntityList.Count > 0) ? KBMDUserTreeSettingEntityList : null;
        }

        KBMDUserTreeSettingEntity IEntityBuilder<KBMDUserTreeSettingEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREESETTINGID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity = new KBMDUserTreeSettingEntity();

            kBMDUserTreeSettingEntity.UserTreeSettingID = reader.GetInt64(FLD_USERTREESETTINGID);
            kBMDUserTreeSettingEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { kBMDUserTreeSettingEntity.Remarks = String.Empty; } else { kBMDUserTreeSettingEntity.Remarks = reader.GetString(FLD_REMARKS); }
            kBMDUserTreeSettingEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return kBMDUserTreeSettingEntity;
        }
    }
}
