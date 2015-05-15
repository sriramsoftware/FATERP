// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDistrictBuilder : IEntityBuilder<MDDistrictEntity>
    {
        IList<MDDistrictEntity> IEntityBuilder<MDDistrictEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDistrictEntity> MDDistrictEntityList = new List<MDDistrictEntity>();

            while (reader.Read())
            {
                MDDistrictEntityList.Add(((IEntityBuilder<MDDistrictEntity>)this).BuildEntity(reader));
            }

            return (MDDistrictEntityList.Count > 0) ? MDDistrictEntityList : null;
        }

        MDDistrictEntity IEntityBuilder<MDDistrictEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DISTRICTID = 0;
            const Int32 FLD_DISTRICTNAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_DIVISIONID = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDDistrictEntity mDDistrictEntity = new MDDistrictEntity();

            mDDistrictEntity.DistrictID = reader.GetInt64(FLD_DISTRICTID);
            mDDistrictEntity.DistrictName = reader.GetString(FLD_DISTRICTNAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDDistrictEntity.Remarks = String.Empty; } else { mDDistrictEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDDistrictEntity.DivisionID = reader.GetInt64(FLD_DIVISIONID);
            mDDistrictEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDistrictEntity;
        }
    }
}
