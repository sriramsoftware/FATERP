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
    internal sealed class MDBrandBuilder : IEntityBuilder<MDBrandEntity>
    {
        IList<MDBrandEntity> IEntityBuilder<MDBrandEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBrandEntity> MDBrandEntityList = new List<MDBrandEntity>();

            while (reader.Read())
            {
                MDBrandEntityList.Add(((IEntityBuilder<MDBrandEntity>)this).BuildEntity(reader));
            }

            return (MDBrandEntityList.Count > 0) ? MDBrandEntityList : null;
        }

        MDBrandEntity IEntityBuilder<MDBrandEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BRANDID = 0;
            const Int32 FLD_BRANDNAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDBrandEntity mDBrandEntity = new MDBrandEntity();

            mDBrandEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            mDBrandEntity.BrandName = reader.GetString(FLD_BRANDNAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDBrandEntity.Remarks = String.Empty; } else { mDBrandEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDBrandEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDBrandEntity;
        }
    }
}
