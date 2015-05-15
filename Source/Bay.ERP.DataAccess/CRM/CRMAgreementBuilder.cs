// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2013, 08:24:37




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMAgreementBuilder : IEntityBuilder<CRMAgreementEntity>
    {
        IList<CRMAgreementEntity> IEntityBuilder<CRMAgreementEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreementEntity> CRMAgreementEntityList = new List<CRMAgreementEntity>();

            while (reader.Read())
            {
                CRMAgreementEntityList.Add(((IEntityBuilder<CRMAgreementEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreementEntityList.Count > 0) ? CRMAgreementEntityList : null;
        }

        CRMAgreementEntity IEntityBuilder<CRMAgreementEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTID = 0;
            const Int32 FLD_PAYMENTSCHEDULEID = 1;
            const Int32 FLD_AGREEMENTTYPEID = 2;
            const Int32 FLD_BUYERBASICINFOID = 3;
            const Int32 FLD_PROJECTID = 4;
            const Int32 FLD_PROJECTFLOORUNITID = 5;
            const Int32 FLD_TEXT = 6;
            const Int32 FLD_AGREEMENTDATE = 7;
            const Int32 FLD_SIGNDATE = 8;
            const Int32 FLD_EXECUTEDATE = 9;
            const Int32 FLD_FIELD1 = 10;
            const Int32 FLD_FIELD2 = 11;
            const Int32 FLD_FIELD3 = 12;
            const Int32 FLD_FIELD4 = 13;
            const Int32 FLD_REMARKS = 14;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 15;
            const Int32 FLD_CREATEDATE = 16;
            const Int32 FLD_IP = 17;
            const Int32 FLD_AGREEMENTAPPROVALSTATUSID = 18;

            CRMAgreementEntity cRMAgreementEntity = new CRMAgreementEntity();

            cRMAgreementEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMAgreementEntity.PaymentScheduleID = reader.GetInt64(FLD_PAYMENTSCHEDULEID);
            cRMAgreementEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMAgreementEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMAgreementEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMAgreementEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            cRMAgreementEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMAgreementEntity.AgreementDate = null; } else { cRMAgreementEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            if (reader.IsDBNull(FLD_SIGNDATE)) { cRMAgreementEntity.SignDate = null; } else { cRMAgreementEntity.SignDate = reader.GetDateTime(FLD_SIGNDATE); }
            if (reader.IsDBNull(FLD_EXECUTEDATE)) { cRMAgreementEntity.ExecuteDate = null; } else { cRMAgreementEntity.ExecuteDate = reader.GetDateTime(FLD_EXECUTEDATE); }
            if (reader.IsDBNull(FLD_FIELD1)) { cRMAgreementEntity.Field1 = String.Empty; } else { cRMAgreementEntity.Field1 = reader.GetString(FLD_FIELD1); }
            if (reader.IsDBNull(FLD_FIELD2)) { cRMAgreementEntity.Field2 = String.Empty; } else { cRMAgreementEntity.Field2 = reader.GetString(FLD_FIELD2); }
            if (reader.IsDBNull(FLD_FIELD3)) { cRMAgreementEntity.Field3 = String.Empty; } else { cRMAgreementEntity.Field3 = reader.GetString(FLD_FIELD3); }
            if (reader.IsDBNull(FLD_FIELD4)) { cRMAgreementEntity.Field4 = String.Empty; } else { cRMAgreementEntity.Field4 = reader.GetString(FLD_FIELD4); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreementEntity.Remarks = String.Empty; } else { cRMAgreementEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreementEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            cRMAgreementEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMAgreementEntity.IP = reader.GetString(FLD_IP);
            cRMAgreementEntity.AgreementApprovalStatusID = reader.GetInt64(FLD_AGREEMENTAPPROVALSTATUSID);

            return cRMAgreementEntity;
        }
    }
}
