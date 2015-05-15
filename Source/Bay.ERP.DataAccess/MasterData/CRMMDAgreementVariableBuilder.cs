// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Apr-2013, 05:21:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDAgreementVariableBuilder : IEntityBuilder<CRMMDAgreementVariableEntity>
    {
        IList<CRMMDAgreementVariableEntity> IEntityBuilder<CRMMDAgreementVariableEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDAgreementVariableEntity> CRMMDAgreementVariableEntityList = new List<CRMMDAgreementVariableEntity>();

            while (reader.Read())
            {
                CRMMDAgreementVariableEntityList.Add(((IEntityBuilder<CRMMDAgreementVariableEntity>)this).BuildEntity(reader));
            }

            return (CRMMDAgreementVariableEntityList.Count > 0) ? CRMMDAgreementVariableEntityList : null;
        }

        CRMMDAgreementVariableEntity IEntityBuilder<CRMMDAgreementVariableEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTVARIABLEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_VALUE = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 4;
            const Int32 FLD_CREATEDATE = 5;
            const Int32 FLD_IP = 6;
            const Int32 FLD_ISREMOVED = 7;

            CRMMDAgreementVariableEntity cRMMDAgreementVariableEntity = new CRMMDAgreementVariableEntity();

            cRMMDAgreementVariableEntity.AgreementVariableID = reader.GetInt64(FLD_AGREEMENTVARIABLEID);
            cRMMDAgreementVariableEntity.Name = reader.GetString(FLD_NAME);
            cRMMDAgreementVariableEntity.Value = reader.GetString(FLD_VALUE);
            if (reader.IsDBNull(FLD_REMARKS)) { cRMMDAgreementVariableEntity.Remarks = String.Empty; } else { cRMMDAgreementVariableEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMMDAgreementVariableEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            cRMMDAgreementVariableEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMMDAgreementVariableEntity.IP = reader.GetString(FLD_IP);
            cRMMDAgreementVariableEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDAgreementVariableEntity;
        }
    }
}
