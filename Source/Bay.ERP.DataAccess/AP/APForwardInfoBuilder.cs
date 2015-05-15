// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 04:39:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APForwardInfoBuilder : IEntityBuilder<APForwardInfoEntity>
    {
        IList<APForwardInfoEntity> IEntityBuilder<APForwardInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<APForwardInfoEntity> APForwardInfoEntityList = new List<APForwardInfoEntity>();

            while (reader.Read())
            {
                APForwardInfoEntityList.Add(((IEntityBuilder<APForwardInfoEntity>)this).BuildEntity(reader));
            }

            return (APForwardInfoEntityList.Count > 0) ? APForwardInfoEntityList : null;
        }

        APForwardInfoEntity IEntityBuilder<APForwardInfoEntity>.BuildEntity(IDataReader reader)
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

            APForwardInfoEntity aPForwardInfoEntity = new APForwardInfoEntity();

            aPForwardInfoEntity.APForwardInfoID = reader.GetInt64(FLD_APFORWARDINFOID);
            aPForwardInfoEntity.APMemberFeedbackID = reader.GetInt64(FLD_APMEMBERFEEDBACKID);
            aPForwardInfoEntity.APApprovalProcessID = reader.GetInt64(FLD_APAPPROVALPROCESSID);
            aPForwardInfoEntity.APMemberFeedbackRemarksID = reader.GetInt64(FLD_APMEMBERFEEDBACKREMARKSID);
            aPForwardInfoEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            aPForwardInfoEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            aPForwardInfoEntity.CommentRequestDate = reader.GetDateTime(FLD_COMMENTREQUESTDATE);
            if (reader.IsDBNull(FLD_COMMENTSUBMITDATE)) { aPForwardInfoEntity.CommentSubmitDate = null; } else { aPForwardInfoEntity.CommentSubmitDate = reader.GetDateTime(FLD_COMMENTSUBMITDATE); }
            if (reader.IsDBNull(FLD_APMEMBERCOMMENT)) { aPForwardInfoEntity.APMemberComment = String.Empty; } else { aPForwardInfoEntity.APMemberComment = reader.GetString(FLD_APMEMBERCOMMENT); }
            if (reader.IsDBNull(FLD_APFORWARDMEMBERCOMMENT)) { aPForwardInfoEntity.APForwardMemberComment = String.Empty; } else { aPForwardInfoEntity.APForwardMemberComment = reader.GetString(FLD_APFORWARDMEMBERCOMMENT); }

            return aPForwardInfoEntity;
        }
    }
}
