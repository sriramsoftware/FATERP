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
    internal sealed class KBMDUserTreeStatusBuilder : IEntityBuilder<KBMDUserTreeStatusEntity>
    {
        IList<KBMDUserTreeStatusEntity> IEntityBuilder<KBMDUserTreeStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<KBMDUserTreeStatusEntity> KBMDUserTreeStatusEntityList = new List<KBMDUserTreeStatusEntity>();

            while (reader.Read())
            {
                KBMDUserTreeStatusEntityList.Add(((IEntityBuilder<KBMDUserTreeStatusEntity>)this).BuildEntity(reader));
            }

            return (KBMDUserTreeStatusEntityList.Count > 0) ? KBMDUserTreeStatusEntityList : null;
        }

        KBMDUserTreeStatusEntity IEntityBuilder<KBMDUserTreeStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_USERTREESTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity = new KBMDUserTreeStatusEntity();

            kBMDUserTreeStatusEntity.UserTreeStatusID = reader.GetInt64(FLD_USERTREESTATUSID);
            kBMDUserTreeStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { kBMDUserTreeStatusEntity.Remarks = String.Empty; } else { kBMDUserTreeStatusEntity.Remarks = reader.GetString(FLD_REMARKS); }
            kBMDUserTreeStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return kBMDUserTreeStatusEntity;
        }
    }
}
