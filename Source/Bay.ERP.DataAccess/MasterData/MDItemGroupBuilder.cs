// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDItemGroupBuilder : IEntityBuilder<MDItemGroupEntity>
    {
        IList<MDItemGroupEntity> IEntityBuilder<MDItemGroupEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemGroupEntity> MDItemGroupEntityList = new List<MDItemGroupEntity>();

            while (reader.Read())
            {
                MDItemGroupEntityList.Add(((IEntityBuilder<MDItemGroupEntity>)this).BuildEntity(reader));
            }

            return (MDItemGroupEntityList.Count > 0) ? MDItemGroupEntityList : null;
        }

        MDItemGroupEntity IEntityBuilder<MDItemGroupEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMGROUPID = 0;
            const Int32 FLD_GROUPNAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDItemGroupEntity mDItemGroupEntity = new MDItemGroupEntity();

            mDItemGroupEntity.ItemGroupID = reader.GetInt64(FLD_ITEMGROUPID);
            mDItemGroupEntity.GroupName = reader.GetString(FLD_GROUPNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDItemGroupEntity.Description = String.Empty; } else { mDItemGroupEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDItemGroupEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDItemGroupEntity;
        }
    }
}
