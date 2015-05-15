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
    internal sealed class CRMAgreement_DetailedBuilder : IEntityBuilder<CRMAgreement_DetailedEntity>
    {
        IList<CRMAgreement_DetailedEntity> IEntityBuilder<CRMAgreement_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreement_DetailedEntity> CRMAgreement_DetailedEntityList = new List<CRMAgreement_DetailedEntity>();

            while (reader.Read())
            {
                CRMAgreement_DetailedEntityList.Add(((IEntityBuilder<CRMAgreement_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreement_DetailedEntityList.Count > 0) ? CRMAgreement_DetailedEntityList : null;
        }

        CRMAgreement_DetailedEntity IEntityBuilder<CRMAgreement_DetailedEntity>.BuildEntity(IDataReader reader)
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

            CRMAgreement_DetailedEntity cRMAgreement_DetailedEntity = new CRMAgreement_DetailedEntity();

            cRMAgreement_DetailedEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMAgreement_DetailedEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            cRMAgreement_DetailedEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMAgreement_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cRMAgreement_DetailedEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID);
            cRMAgreement_DetailedEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_AGREEMENTDATE)) { cRMAgreement_DetailedEntity.AgreementDate = null; } else { cRMAgreement_DetailedEntity.AgreementDate = reader.GetDateTime(FLD_AGREEMENTDATE); }
            if (reader.IsDBNull(FLD_SIGNDATE)) { cRMAgreement_DetailedEntity.SignDate = null; } else { cRMAgreement_DetailedEntity.SignDate = reader.GetDateTime(FLD_SIGNDATE); }
            if (reader.IsDBNull(FLD_EXECUTEDATE)) { cRMAgreement_DetailedEntity.ExecuteDate = null; } else { cRMAgreement_DetailedEntity.ExecuteDate = reader.GetDateTime(FLD_EXECUTEDATE); }
            if (reader.IsDBNull(FLD_FIELD1)) { cRMAgreement_DetailedEntity.Field1 = String.Empty; } else { cRMAgreement_DetailedEntity.Field1 = reader.GetString(FLD_FIELD1); }
            if (reader.IsDBNull(FLD_FIELD2)) { cRMAgreement_DetailedEntity.Field2 = String.Empty; } else { cRMAgreement_DetailedEntity.Field2 = reader.GetString(FLD_FIELD2); }
            if (reader.IsDBNull(FLD_FIELD3)) { cRMAgreement_DetailedEntity.Field3 = String.Empty; } else { cRMAgreement_DetailedEntity.Field3 = reader.GetString(FLD_FIELD3); }
            if (reader.IsDBNull(FLD_FIELD4)) { cRMAgreement_DetailedEntity.Field4 = String.Empty; } else { cRMAgreement_DetailedEntity.Field4 = reader.GetString(FLD_FIELD4); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreement_DetailedEntity.Remarks = String.Empty; } else { cRMAgreement_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreement_DetailedEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);
            cRMAgreement_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            cRMAgreement_DetailedEntity.IP = reader.GetString(FLD_IP);
            cRMAgreement_DetailedEntity.AgreementApprovalStatusID = reader.GetInt64(FLD_AGREEMENTAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_CRMMDAGREEMENTTYPENAME)) { cRMAgreement_DetailedEntity.CRMMDAgreementTypeName = String.Empty; } else { cRMAgreement_DetailedEntity.CRMMDAgreementTypeName = reader.GetString(FLD_CRMMDAGREEMENTTYPENAME); }
            if (reader.IsDBNull(FLD_CRMBUYERBASICINFOCONTACTFULLNAME)) { cRMAgreement_DetailedEntity.CRMBuyerBasicInfoContactFullName = String.Empty; } else { cRMAgreement_DetailedEntity.CRMBuyerBasicInfoContactFullName = reader.GetString(FLD_CRMBUYERBASICINFOCONTACTFULLNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTPROJECTNAME)) { cRMAgreement_DetailedEntity.BDProjectProjectName = String.Empty; } else { cRMAgreement_DetailedEntity.BDProjectProjectName = reader.GetString(FLD_BDPROJECTPROJECTNAME); }
            if (reader.IsDBNull(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME)) { cRMAgreement_DetailedEntity.BDProjectFloorUnitProjectFloorUnitName = String.Empty; } else { cRMAgreement_DetailedEntity.BDProjectFloorUnitProjectFloorUnitName = reader.GetString(FLD_BDPROJECTFLOORUNITPROJECTFLOORUNITNAME); }
            if (reader.IsDBNull(FLD_CREATEDBYMEMBERFULLNAME)) { cRMAgreement_DetailedEntity.CreatedByMemberFullName = String.Empty; } else { cRMAgreement_DetailedEntity.CreatedByMemberFullName = reader.GetString(FLD_CREATEDBYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_CRMMDAGREEMENTAPPROVALSTATUSNAME)) { cRMAgreement_DetailedEntity.CRMMDAgreementApprovalStatusName = String.Empty; } else { cRMAgreement_DetailedEntity.CRMMDAgreementApprovalStatusName = reader.GetString(FLD_CRMMDAGREEMENTAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cRMAgreement_DetailedEntity.RowNumber = null; } else { cRMAgreement_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cRMAgreement_DetailedEntity;
        }
    }
}
