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
    internal sealed class APMemberFeedbackBuilder : IEntityBuilder<APMemberFeedbackEntity>
    {
        IList<APMemberFeedbackEntity> IEntityBuilder<APMemberFeedbackEntity>.BuildEntities(IDataReader reader)
        {
            List<APMemberFeedbackEntity> APMemberFeedbackEntityList = new List<APMemberFeedbackEntity>();

            while (reader.Read())
            {
                APMemberFeedbackEntityList.Add(((IEntityBuilder<APMemberFeedbackEntity>)this).BuildEntity(reader));
            }

            return (APMemberFeedbackEntityList.Count > 0) ? APMemberFeedbackEntityList : null;
        }

        APMemberFeedbackEntity IEntityBuilder<APMemberFeedbackEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APMEMBERFEEDBACKID = 0;
            const Int32 FLD_APAPPROVALPROCESSID = 1;
            const Int32 FLD_DEPARTMENTID = 2;
            const Int32 FLD_EMPLOYEEID = 3;
            const Int32 FLD_SEQUENCENO = 4;
            const Int32 FLD_APFEEDBACKID = 5;
            const Int32 FLD_FEEDBACKREQUESTDATE = 6;
            const Int32 FLD_FEEDBACKLASTRESPONSEDATE = 7;
            const Int32 FLD_FEEDBACKSUBMITDATE = 8;
            const Int32 FLD_PROXYEMPLOYEEID = 9;
            const Int32 FLD_ISPROXYEMPLOYEEENABLED = 10;

            APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

            aPMemberFeedbackEntity.APMemberFeedbackID = reader.GetInt64(FLD_APMEMBERFEEDBACKID);
            aPMemberFeedbackEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPMemberFeedbackEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPMemberFeedbackEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPMemberFeedbackEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);
            aPMemberFeedbackEntity.APFeedbackID = reader.GetInt64(FLD_APFEEDBACKID);
            if (reader.IsDBNull(FLD_FEEDBACKREQUESTDATE)) { aPMemberFeedbackEntity.FeedbackRequestDate = null; } else { aPMemberFeedbackEntity.FeedbackRequestDate = reader.GetDateTime(FLD_FEEDBACKREQUESTDATE); }
            if (reader.IsDBNull(FLD_FEEDBACKLASTRESPONSEDATE)) { aPMemberFeedbackEntity.FeedbackLastResponseDate = null; } else { aPMemberFeedbackEntity.FeedbackLastResponseDate = reader.GetDateTime(FLD_FEEDBACKLASTRESPONSEDATE); }
            if (reader.IsDBNull(FLD_FEEDBACKSUBMITDATE)) { aPMemberFeedbackEntity.FeedbackSubmitDate = null; } else { aPMemberFeedbackEntity.FeedbackSubmitDate = reader.GetDateTime(FLD_FEEDBACKSUBMITDATE); }
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPMemberFeedbackEntity.ProxyEmployeeID = null; } else { aPMemberFeedbackEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPMemberFeedbackEntity.IsProxyEmployeeEnabled = reader.GetBoolean(FLD_ISPROXYEMPLOYEEENABLED);

            return aPMemberFeedbackEntity;
        }
    }
}
