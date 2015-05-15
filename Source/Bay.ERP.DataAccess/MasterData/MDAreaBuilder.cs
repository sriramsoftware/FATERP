// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAreaBuilder : IEntityBuilder<MDAreaEntity>
    {
        IList<MDAreaEntity> IEntityBuilder<MDAreaEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAreaEntity> MDAreaEntityList = new List<MDAreaEntity>();

            while (reader.Read())
            {
                MDAreaEntityList.Add(((IEntityBuilder<MDAreaEntity>)this).BuildEntity(reader));
            }

            return (MDAreaEntityList.Count > 0) ? MDAreaEntityList : null;
        }

        MDAreaEntity IEntityBuilder<MDAreaEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AREAID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDAreaEntity mDAreaEntity = new MDAreaEntity();

            mDAreaEntity.AreaID = reader.GetInt64(FLD_AREAID);
            mDAreaEntity.Name = reader.GetString(FLD_NAME);
            mDAreaEntity.Description = reader.GetString(FLD_DESCRIPTION);
            mDAreaEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAreaEntity;
        }
    }
}
