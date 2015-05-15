// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Oct-2012, 04:13:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDBillApprovalStatusBuilder : IEntityBuilder<MDBillApprovalStatusEntity>
    {
        IList<MDBillApprovalStatusEntity> IEntityBuilder<MDBillApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBillApprovalStatusEntity> MDBillApprovalStatusEntityList = new List<MDBillApprovalStatusEntity>();

            while (reader.Read())
            {
                MDBillApprovalStatusEntityList.Add(((IEntityBuilder<MDBillApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDBillApprovalStatusEntityList.Count > 0) ? MDBillApprovalStatusEntityList : null;
        }

        MDBillApprovalStatusEntity IEntityBuilder<MDBillApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDBillApprovalStatusEntity mDBillApprovalStatusEntity = new MDBillApprovalStatusEntity();

            mDBillApprovalStatusEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);
            mDBillApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            mDBillApprovalStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDBillApprovalStatusEntity;
        }
    }
}
