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
    internal sealed class CRMAgreementVariableMapBuilder : IEntityBuilder<CRMAgreementVariableMapEntity>
    {
        IList<CRMAgreementVariableMapEntity> IEntityBuilder<CRMAgreementVariableMapEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreementVariableMapEntity> CRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();

            while (reader.Read())
            {
                CRMAgreementVariableMapEntityList.Add(((IEntityBuilder<CRMAgreementVariableMapEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreementVariableMapEntityList.Count > 0) ? CRMAgreementVariableMapEntityList : null;
        }

        CRMAgreementVariableMapEntity IEntityBuilder<CRMAgreementVariableMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTVARIABLEMAPID = 0;
            const Int32 FLD_AGREEMENTID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_VALUE = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 5;
            const Int32 FLD_CREATEDATE = 6;
            const Int32 FLD_IP = 7;

            CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();

            cRMAgreementVariableMapEntity.AgreementVariableMapID = reader.GetInt64(FLD_AGREEMENTVARIABLEMAPID);
            cRMAgreementVariableMapEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMAgreementVariableMapEntity.Name = reader.GetString(FLD_NAME);
            cRMAgreementVariableMapEntity.Value = reader.GetString(FLD_VALUE);
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreementVariableMapEntity.Remarks = String.Empty; } else { cRMAgreementVariableMapEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreementVariableMapEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            cRMAgreementVariableMapEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMAgreementVariableMapEntity.IP = reader.GetString(FLD_IP);

            return cRMAgreementVariableMapEntity;
        }
    }
}
