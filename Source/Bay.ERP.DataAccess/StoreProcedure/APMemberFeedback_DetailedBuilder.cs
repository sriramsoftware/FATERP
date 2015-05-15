// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:49:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APMemberFeedback_DetailedBuilder : IEntityBuilder<APMemberFeedback_DetailedEntity>
    {
        IList<APMemberFeedback_DetailedEntity> IEntityBuilder<APMemberFeedback_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<APMemberFeedback_DetailedEntity> APMemberFeedback_DetailedEntityList = new List<APMemberFeedback_DetailedEntity>();

            while (reader.Read())
            {
                APMemberFeedback_DetailedEntityList.Add(((IEntityBuilder<APMemberFeedback_DetailedEntity>)this).BuildEntity(reader));
            }

            return (APMemberFeedback_DetailedEntityList.Count > 0) ? APMemberFeedback_DetailedEntityList : null;
        }

        APMemberFeedback_DetailedEntity IEntityBuilder<APMemberFeedback_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_DEPARTMENTNAME = 11;
            const Int32 FLD_DESIGNATIONNAME = 12;
            const Int32 FLD_MEMBERFULLNAME = 13;
            const Int32 FLD_APFEEDBACKNAME = 14;
            const Int32 FLD_PROXYMEMBERFULLNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            APMemberFeedback_DetailedEntity aPMemberFeedback_DetailedEntity = new APMemberFeedback_DetailedEntity();

            aPMemberFeedback_DetailedEntity.APMemberFeedbackID = reader.GetInt64(FLD_APMEMBERFEEDBACKID);
            aPMemberFeedback_DetailedEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPMemberFeedback_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPMemberFeedback_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPMemberFeedback_DetailedEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);
            aPMemberFeedback_DetailedEntity.APFeedbackID = reader.GetInt64(FLD_APFEEDBACKID);
            if (reader.IsDBNull(FLD_FEEDBACKREQUESTDATE)) { aPMemberFeedback_DetailedEntity.FeedbackRequestDate = null; } else { aPMemberFeedback_DetailedEntity.FeedbackRequestDate = reader.GetDateTime(FLD_FEEDBACKREQUESTDATE); }
            if (reader.IsDBNull(FLD_FEEDBACKLASTRESPONSEDATE)) { aPMemberFeedback_DetailedEntity.FeedbackLastResponseDate = null; } else { aPMemberFeedback_DetailedEntity.FeedbackLastResponseDate = reader.GetDateTime(FLD_FEEDBACKLASTRESPONSEDATE); }
            if (reader.IsDBNull(FLD_FEEDBACKSUBMITDATE)) { aPMemberFeedback_DetailedEntity.FeedbackSubmitDate = null; } else { aPMemberFeedback_DetailedEntity.FeedbackSubmitDate = reader.GetDateTime(FLD_FEEDBACKSUBMITDATE); }
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPMemberFeedback_DetailedEntity.ProxyEmployeeID = null; } else { aPMemberFeedback_DetailedEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPMemberFeedback_DetailedEntity.IsProxyEmployeeEnabled = reader.GetBoolean(FLD_ISPROXYEMPLOYEEENABLED);
            if (reader.IsDBNull(FLD_DEPARTMENTNAME)) { aPMemberFeedback_DetailedEntity.DepartmentName = String.Empty; } else { aPMemberFeedback_DetailedEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_DESIGNATIONNAME)) { aPMemberFeedback_DetailedEntity.DesignationName = String.Empty; } else { aPMemberFeedback_DetailedEntity.DesignationName = reader.GetString(FLD_DESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aPMemberFeedback_DetailedEntity.MemberFullName = String.Empty; } else { aPMemberFeedback_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_APFEEDBACKNAME)) { aPMemberFeedback_DetailedEntity.APFeedbackName = String.Empty; } else { aPMemberFeedback_DetailedEntity.APFeedbackName = reader.GetString(FLD_APFEEDBACKNAME); }
            if (reader.IsDBNull(FLD_PROXYMEMBERFULLNAME)) { aPMemberFeedback_DetailedEntity.ProxyMemberFullName = String.Empty; } else { aPMemberFeedback_DetailedEntity.ProxyMemberFullName = reader.GetString(FLD_PROXYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPMemberFeedback_DetailedEntity.RowNumber = null; } else { aPMemberFeedback_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPMemberFeedback_DetailedEntity;
        }
    }
}
