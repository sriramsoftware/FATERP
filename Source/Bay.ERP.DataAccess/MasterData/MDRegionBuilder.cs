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
    internal sealed class MDRegionBuilder : IEntityBuilder<MDRegionEntity>
    {
        IList<MDRegionEntity> IEntityBuilder<MDRegionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDRegionEntity> MDRegionEntityList = new List<MDRegionEntity>();

            while (reader.Read())
            {
                MDRegionEntityList.Add(((IEntityBuilder<MDRegionEntity>)this).BuildEntity(reader));
            }

            return (MDRegionEntityList.Count > 0) ? MDRegionEntityList : null;
        }

        MDRegionEntity IEntityBuilder<MDRegionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_REGIONID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDRegionEntity mDRegionEntity = new MDRegionEntity();

            mDRegionEntity.RegionID = reader.GetInt64(FLD_REGIONID);
            mDRegionEntity.Name = reader.GetString(FLD_NAME);
            mDRegionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDRegionEntity;
        }
    }
}
