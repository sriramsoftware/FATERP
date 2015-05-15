// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 05:05:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APForwardInfo_DetailedBuilder : IEntityBuilder<APForwardInfo_DetailedEntity>
    {
        IList<APForwardInfo_DetailedEntity> IEntityBuilder<APForwardInfo_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<APForwardInfo_DetailedEntity> APForwardInfo_DetailedEntityList = new List<APForwardInfo_DetailedEntity>();

            while (reader.Read())
            {
                APForwardInfo_DetailedEntityList.Add(((IEntityBuilder<APForwardInfo_DetailedEntity>)this).BuildEntity(reader));
            }

            return (APForwardInfo_DetailedEntityList.Count > 0) ? APForwardInfo_DetailedEntityList : null;
        }

        APForwardInfo_DetailedEntity IEntityBuilder<APForwardInfo_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APFORWARDINFOID = 0;
            const Int32 FLD_APMEMBERFEEDBACKID = 1;
            const Int32 FLD_APAPPROVALPROCESSID = 2;
            const Int32 FLD_APMEMBERFEEDBACKREMARKSID = 3;
            const Int32 FLD_DEPARTMENTID = 4;
            const Int32 FLD_EMPLOYEEID = 5;
            const Int32 FLD_COMMENTREQUESTDATE = 6;
            const Int32 FLD_COMMENTSUBMITDATE = 7;
            const Int32 FLD_APMEMBERCOMMENT = 8;
            const Int32 FLD_APFORWARDMEMBERCOMMENT = 9;
            const Int32 FLD_MDDEPARTMENTNAME = 10;
            const Int32 FLD_HREMPLOYEEMEMBERID = 11;
            const Int32 FLD_MEMBERFULLNAME = 12;
            const Int32 FLD_ROWNUMBER = 13;

            APForwardInfo_DetailedEntity aPForwardInfo_DetailedEntity = new APForwardInfo_DetailedEntity();

            aPForwardInfo_DetailedEntity.APForwardInfoID = reader.GetInt64(FLD_APFORWARDINFOID);
            aPForwardInfo_DetailedEntity.APMemberFeedbackID = reader.GetInt64(FLD_APMEMBERFEEDBACKID);
            aPForwardInfo_DetailedEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPForwardInfo_DetailedEntity.APMemberFeedbackRemarksID = reader.GetInt64(FLD_APMEMBERFEEDBACKREMARKSID);
            aPForwardInfo_DetailedEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPForwardInfo_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPForwardInfo_DetailedEntity.CommentRequestDate = reader.GetDateTime(FLD_COMMENTREQUESTDATE);
            if (reader.IsDBNull(FLD_COMMENTSUBMITDATE)) { aPForwardInfo_DetailedEntity.CommentSubmitDate = null; } else { aPForwardInfo_DetailedEntity.CommentSubmitDate = reader.GetDateTime(FLD_COMMENTSUBMITDATE); }
            if (reader.IsDBNull(FLD_APMEMBERCOMMENT)) { aPForwardInfo_DetailedEntity.APMemberComment = String.Empty; } else { aPForwardInfo_DetailedEntity.APMemberComment = reader.GetString(FLD_APMEMBERCOMMENT); }
            if (reader.IsDBNull(FLD_APFORWARDMEMBERCOMMENT)) { aPForwardInfo_DetailedEntity.APForwardMemberComment = String.Empty; } else { aPForwardInfo_DetailedEntity.APForwardMemberComment = reader.GetString(FLD_APFORWARDMEMBERCOMMENT); }
            if (reader.IsDBNull(FLD_MDDEPARTMENTNAME)) { aPForwardInfo_DetailedEntity.MDDepartmentName = String.Empty; } else { aPForwardInfo_DetailedEntity.MDDepartmentName = reader.GetString(FLD_MDDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { aPForwardInfo_DetailedEntity.HREmployeeMemberID = null; } else { aPForwardInfo_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { aPForwardInfo_DetailedEntity.MemberFullName = String.Empty; } else { aPForwardInfo_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPForwardInfo_DetailedEntity.RowNumber = null; } else { aPForwardInfo_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPForwardInfo_DetailedEntity;
        }
    }
}
