// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDBOQStatusBuilder : IEntityBuilder<MDBOQStatusEntity>
    {
        IList<MDBOQStatusEntity> IEntityBuilder<MDBOQStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBOQStatusEntity> MDBOQStatusEntityList = new List<MDBOQStatusEntity>();

            while (reader.Read())
            {
                MDBOQStatusEntityList.Add(((IEntityBuilder<MDBOQStatusEntity>)this).BuildEntity(reader));
            }

            return (MDBOQStatusEntityList.Count > 0) ? MDBOQStatusEntityList : null;
        }

        MDBOQStatusEntity IEntityBuilder<MDBOQStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDBOQStatusEntity mDBOQStatusEntity = new MDBOQStatusEntity();

            mDBOQStatusEntity.BOQStatusID = reader.GetInt64(FLD_BOQSTATUSID);
            mDBOQStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDBOQStatusEntity.Description = String.Empty; } else { mDBOQStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDBOQStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDBOQStatusEntity;
        }
    }
}
