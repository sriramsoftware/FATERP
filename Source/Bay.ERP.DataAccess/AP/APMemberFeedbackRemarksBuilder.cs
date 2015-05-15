// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APMemberFeedbackRemarksBuilder : IEntityBuilder<APMemberFeedbackRemarksEntity>
    {
        IList<APMemberFeedbackRemarksEntity> IEntityBuilder<APMemberFeedbackRemarksEntity>.BuildEntities(IDataReader reader)
        {
            List<APMemberFeedbackRemarksEntity> APMemberFeedbackRemarksEntityList = new List<APMemberFeedbackRemarksEntity>();

            while (reader.Read())
            {
                APMemberFeedbackRemarksEntityList.Add(((IEntityBuilder<APMemberFeedbackRemarksEntity>)this).BuildEntity(reader));
            }

            return (APMemberFeedbackRemarksEntityList.Count > 0) ? APMemberFeedbackRemarksEntityList : null;
        }

        APMemberFeedbackRemarksEntity IEntityBuilder<APMemberFeedbackRemarksEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APMEMBERFEEDBACKREMARKSID = 0;
            const Int32 FLD_APAPPROVALPROCESSID = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_REMARKSDATETIME = 3;
            const Int32 FLD_EMPLOYEEID = 4;
            const Int32 FLD_APFEEDBACKID = 5;
            const Int32 FLD_PROXYEMPLOYEEID = 6;
            const Int32 FLD_ISPROXYEMPLOYEEREMARKS = 7;
            const Int32 FLD_PROXYEMPLOYEEREMARKS = 8;

            APMemberFeedbackRemarksEntity aPMemberFeedbackRemarksEntity = new APMemberFeedbackRemarksEntity();

            aPMemberFeedbackRemarksEntity.APMemberFeedbackRemarksID = reader.GetInt64(FLD_APMEMBERFEEDBACKREMARKSID);
            aPMemberFeedbackRemarksEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            if (reader.IsDBNull(FLD_REMARKS)) { aPMemberFeedbackRemarksEntity.Remarks = String.Empty; } else { aPMemberFeedbackRemarksEntity.Remarks = reader.GetString(FLD_REMARKS); }
            aPMemberFeedbackRemarksEntity.RemarksDateTime = reader.GetDateTime(FLD_REMARKSDATETIME);
            aPMemberFeedbackRemarksEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPMemberFeedbackRemarksEntity.APFeedbackID = reader.GetInt64(FLD_APFEEDBACKID);
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPMemberFeedbackRemarksEntity.ProxyEmployeeID = null; } else { aPMemberFeedbackRemarksEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPMemberFeedbackRemarksEntity.IsProxyEmployeeRemarks = reader.GetBoolean(FLD_ISPROXYEMPLOYEEREMARKS);
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEREMARKS)) { aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks = String.Empty; } else { aPMemberFeedbackRemarksEntity.ProxyEmployeeRemarks = reader.GetString(FLD_PROXYEMPLOYEEREMARKS); }

            return aPMemberFeedbackRemarksEntity;
        }
    }
}
