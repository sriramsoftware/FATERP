// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2013, 01:42:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMAgreement_RPTBuilder : IEntityBuilder<CRMAgreement_RPTEntity>
    {
        IList<CRMAgreement_RPTEntity> IEntityBuilder<CRMAgreement_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreement_RPTEntity> CRMAgreement_RPTEntityList = new List<CRMAgreement_RPTEntity>();

            while (reader.Read())
            {
                CRMAgreement_RPTEntityList.Add(((IEntityBuilder<CRMAgreement_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreement_RPTEntityList.Count > 0) ? CRMAgreement_RPTEntityList : null;
        }

        CRMAgreement_RPTEntity IEntityBuilder<CRMAgreement_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTID = 0;
            const Int32 FLD_AGREEMENTTYPEID = 1;
            const Int32 FLD_BUYERBASICINFOID = 2;
            const Int32 FLD_PROJECTID = 3;
            const Int32 FLD_PROJECTFLOORUNITID = 4;
            const Int32 FLD_TEXT = 5;
            const Int32 FLD_AGREEMENTDATE = 6;
            const Int32 FLD_SIGNDATE = 7;
            const Int32 FLD_EXECUTEDATE = 8;
            const Int32 FLD_FIELD1 = 9;
            const Int32 FLD_FIELD2 = 10;
            const Int32 FLD_FIELD3 = 11;
            const Int32 FLD_FIELD4 = 12;
            const Int32 FLD_REMARKS = 13;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 14;
            const Int32 FLD_CREATEDATE = 15;
            const Int32 FLD_IP = 16;
            const Int32 FLD_AGREEMENTAPPROVALSTATUSID = 17;
            const Int32 FLD_CRMMDAGREEMENTTYPENAME = 18;
            const Int32 FLD_CRMBUYERBASICINFOCONTACTFULLNAME = 19;
            const Int32 FLD_BDPROJECTPROJECTNAME = 20;
            const Int32 FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME = 21;
            const Int32 FLD_CREATEDBYMEMBERFULLNAME = 22;
            const Int32 FLD_CRMMDAGREEMENTAPPROVALSTATUSNAME = 23;
            const Int32 FLD_ROWNUMBER = 24;

            CRMAgreement_RPTEntity cRMAgreement_RPTEntity = new CRMAgreement_RPTEntity();

            cRMAgreement_RPTEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMAgreement_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMAgreement_RPTEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMAgreement_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMAgreement_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            cRMAgreement_RPTEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMAgreement_RPTEntity.AgreementDate = null; } else { cRMAgreement_RPTEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            if (reader.IsDBNull(FLD_SIGNDATE)) { cRMAgreement_RPTEntity.SignDate = null; } else { cRMAgreement_RPTEntity.SignDate = reader.GetDateTime(FLD_SIGNDATE); }
            if (reader.IsDBNull(FLD_EXECUTEDATE)) { cRMAgreement_RPTEntity.ExecuteDate = null; } else { cRMAgreement_RPTEntity.ExecuteDate = reader.GetDateTime(FLD_EXECUTEDATE); }
            if (reader.IsDBNull(FLD_FIELD1)) { cRMAgreement_RPTEntity.Field1 = String.Empty; } else { cRMAgreement_RPTEntity.Field1 = reader.GetString(FLD_FIELD1); }
            if (reader.IsDBNull(FLD_FIELD2)) { cRMAgreement_RPTEntity.Field2 = String.Empty; } else { cRMAgreement_RPTEntity.Field2 = reader.GetString(FLD_FIELD2); }
            if (reader.IsDBNull(FLD_FIELD3)) { cRMAgreement_RPTEntity.Field3 = String.Empty; } else { cRMAgreement_RPTEntity.Field3 = reader.GetString(FLD_FIELD3); }
            if (reader.IsDBNull(FLD_FIELD4)) { cRMAgreement_RPTEntity.Field4 = String.Empty; } else { cRMAgreement_RPTEntity.Field4 = reader.GetString(FLD_FIELD4); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreement_RPTEntity.Remarks = String.Empty; } else { cRMAgreement_RPTEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreement_RPTEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            cRMAgreement_RPTEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMAgreement_RPTEntity.IP = reader.GetString(FLD_IP);
            cRMAgreement_RPTEntity.AgreementApprovalStatusID = reader.GetInt64(FLD_AGREEMENTAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_CRMMDAGREEMENTTYPENAME)) { cRMAgreement_RPTEntity.CRMMDAgreementTypeName = String.Empty; } else { cRMAgreement_RPTEntity.CRMMDAgreementTypeName = reader.GetString(FLD_CRMMDAGREEMENTTYPENAME); }
            if (reader.IsDBNull(FLD_CRMBUYERBASICINFOCONTACTFULLNAME)) { cRMAgreement_RPTEntity.CRMBuyerBasicInfoContactFullName = String.Empty; } else { cRMAgreement_RPTEntity.CRMBuyerBasicInfoContactFullName = reader.GetString(FLD_CRMBUYERBASICINFOCONTACTFULLNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { cRMAgreement_RPTEntity.BDProjectProjectName = String.Empty; } else { cRMAgreement_RPTEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME)) { cRMAgreement_RPTEntity.BDProjectFloorUnitProjectFloorUnitName = String.Empty; } else { cRMAgreement_RPTEntity.BDProjectFloorUnitProjectFloorUnitName = reader.GetString(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMAgreement_RPTEntity.CreatedByMemberFullName = String.Empty; } else { cRMAgreement_RPTEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_CRMMDAGREEMENTAPPROVALSTATUSNAME)) { cRMAgreement_RPTEntity.CRMMDAgreementApprovalStatusName = String.Empty; } else { cRMAgreement_RPTEntity.CRMMDAgreementApprovalStatusName = reader.GetString(FLD_CRMMDAGREEMENTAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMAgreement_RPTEntity.RowNumber = null; } else { cRMAgreement_RPTEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMAgreement_RPTEntity;
        }
    }
}
