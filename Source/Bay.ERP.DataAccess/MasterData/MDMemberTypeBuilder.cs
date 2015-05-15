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
    internal sealed class MDMemberTypeBuilder : IEntityBuilder<MDMemberTypeEntity>
    {
        IList<MDMemberTypeEntity> IEntityBuilder<MDMemberTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDMemberTypeEntity> MDMemberTypeEntityList = new List<MDMemberTypeEntity>();

            while (reader.Read())
            {
                MDMemberTypeEntityList.Add(((IEntityBuilder<MDMemberTypeEntity>)this).BuildEntity(reader));
            }

            return (MDMemberTypeEntityList.Count > 0) ? MDMemberTypeEntityList : null;
        }

        MDMemberTypeEntity IEntityBuilder<MDMemberTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDMemberTypeEntity mDMemberTypeEntity = new MDMemberTypeEntity();

            mDMemberTypeEntity.MemberTypeID = reader.GetInt64(FLD_MEMBERTYPEID);
            mDMemberTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDMemberTypeEntity.Description = String.Empty; } else { mDMemberTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDMemberTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDMemberTypeEntity;
        }
    }
}
