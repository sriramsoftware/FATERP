// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDBloodGroupBuilder : IEntityBuilder<MDBloodGroupEntity>
    {
        IList<MDBloodGroupEntity> IEntityBuilder<MDBloodGroupEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBloodGroupEntity> MDBloodGroupEntityList = new List<MDBloodGroupEntity>();

            while (reader.Read())
            {
                MDBloodGroupEntityList.Add(((IEntityBuilder<MDBloodGroupEntity>)this).BuildEntity(reader));
            }

            return (MDBloodGroupEntityList.Count > 0) ? MDBloodGroupEntityList : null;
        }

        MDBloodGroupEntity IEntityBuilder<MDBloodGroupEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BLOODGROUPID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDBloodGroupEntity mDBloodGroupEntity = new MDBloodGroupEntity();

            mDBloodGroupEntity.BloodGroupID = reader.GetInt64(FLD_BLOODGROUPID);
            mDBloodGroupEntity.Name = reader.GetString(FLD_NAME);
            mDBloodGroupEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDBloodGroupEntity;
        }
    }
}
