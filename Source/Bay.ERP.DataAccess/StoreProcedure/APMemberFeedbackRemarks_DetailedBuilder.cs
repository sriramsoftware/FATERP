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
    internal sealed class APMemberFeedbackRemarks_DetailedBuilder : IEntityBuilder<APMemberFeedbackRemarks_DetailedEntity>
    {
        IList<APMemberFeedbackRemarks_DetailedEntity> IEntityBuilder<APMemberFeedbackRemarks_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<APMemberFeedbackRemarks_DetailedEntity> APMemberFeedbackRemarks_DetailedEntityList = new List<APMemberFeedbackRemarks_DetailedEntity>();

            while (reader.Read())
            {
                APMemberFeedbackRemarks_DetailedEntityList.Add(((IEntityBuilder<APMemberFeedbackRemarks_DetailedEntity>)this).BuildEntity(reader));
            }

            return (APMemberFeedbackRemarks_DetailedEntityList.Count > 0) ? APMemberFeedbackRemarks_DetailedEntityList : null;
        }

        APMemberFeedbackRemarks_DetailedEntity IEntityBuilder<APMemberFeedbackRemarks_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APMEMBERFEEDBACKREMARKSID = 0;
            const Int32 FLD_APAPPROVALPROCESSID = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_REMARKSDATETIME = 3;
            const Int32 FLD_EMPLOYEEID = 4;
            const Int32 FLD_APFEEDBACKID = 5;
            const Int32 FLD_PROXYEMPLOYEEID = 6;
            const Int32 FLD_ISPROXYEMPLOYEEREMARKS = 7;
            const Int32 FLD_MEMBERFULLNAME = 8;
            const Int32 FLD_APFEEDBACKNAME = 9;
            const Int32 FLD_PROXYMEMBERFULLNAME = 10;
            const Int32 FLD_PROXYEMPLOYEEREMARKS = 11;
            const Int32 FLD_ROWNUMBER = 12;

            APMemberFeedbackRemarks_DetailedEntity aPMemberFeedbackRemarks_DetailedEntity = new APMemberFeedbackRemarks_DetailedEntity();

            aPMemberFeedbackRemarks_DetailedEntity.APMemberFeedbackRemarksID = reader.GetInt64(FLD_APMEMBERFEEDBACKREMARKSID);
            aPMemberFeedbackRemarks_DetailedEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            if (reader.IsDBNull(FLD_REMARKS)) { aPMemberFeedbackRemarks_DetailedEntity.Remarks = String.Empty; } else { aPMemberFeedbackRemarks_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            aPMemberFeedbackRemarks_DetailedEntity.RemarksDateTime = reader.GetDateTime(FLD_REMARKSDATETIME);
            aPMemberFeedbackRemarks_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPMemberFeedbackRemarks_DetailedEntity.APFeedbackID = reader.GetInt64(FLD_APFEEDBACKID);
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEID)) { aPMemberFeedbackRemarks_DetailedEntity.ProxyEmployeeID = null; } else { aPMemberFeedbackRemarks_DetailedEntity.ProxyEmployeeID = reader.GetInt64(FLD_PROXYEMPLOYEEID); }
            aPMemberFeedbackRemarks_DetailedEntity.IsProxyEmployeeRemarks = reader.GetBoolean(FLD_ISPROXYEMPLOYEEREMARKS);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aPMemberFeedbackRemarks_DetailedEntity.MemberFullName = String.Empty; } else { aPMemberFeedbackRemarks_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_APFEEDBACKNAME)) { aPMemberFeedbackRemarks_DetailedEntity.APFeedbackName = String.Empty; } else { aPMemberFeedbackRemarks_DetailedEntity.APFeedbackName = reader.GetString(FLD_APFEEDBACKNAME); }
            if (reader.IsDBNull(FLD_PROXYMEMBERFULLNAME)) { aPMemberFeedbackRemarks_DetailedEntity.ProxyMemberFullName = String.Empty; } else { aPMemberFeedbackRemarks_DetailedEntity.ProxyMemberFullName = reader.GetString(FLD_PROXYMEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PROXYEMPLOYEEREMARKS)) { aPMemberFeedbackRemarks_DetailedEntity.ProxyEmployeeRemarks = String.Empty; } else { aPMemberFeedbackRemarks_DetailedEntity.ProxyEmployeeRemarks = reader.GetString(FLD_PROXYEMPLOYEEREMARKS); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPMemberFeedbackRemarks_DetailedEntity.RowNumber = null; } else { aPMemberFeedbackRemarks_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPMemberFeedbackRemarks_DetailedEntity;
        }
    }
}
