// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2012, 10:27:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDBillStatusBuilder : IEntityBuilder<MDBillStatusEntity>
    {
        IList<MDBillStatusEntity> IEntityBuilder<MDBillStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBillStatusEntity> MDBillStatusEntityList = new List<MDBillStatusEntity>();

            while (reader.Read())
            {
                MDBillStatusEntityList.Add(((IEntityBuilder<MDBillStatusEntity>)this).BuildEntity(reader));
            }

            return (MDBillStatusEntityList.Count > 0) ? MDBillStatusEntityList : null;
        }

        MDBillStatusEntity IEntityBuilder<MDBillStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVE = 3;

            MDBillStatusEntity mDBillStatusEntity = new MDBillStatusEntity();

            mDBillStatusEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            mDBillStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDBillStatusEntity.Description = String.Empty; } else { mDBillStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDBillStatusEntity.IsRemove = reader.GetBoolean(FLD_ISREMOVE);

            return mDBillStatusEntity;
        }
    }
}
