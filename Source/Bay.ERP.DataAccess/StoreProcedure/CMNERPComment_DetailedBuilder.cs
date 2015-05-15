// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Mar-2013, 04:19:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNERPComment_DetailedBuilder : IEntityBuilder<CMNERPComment_DetailedEntity>
    {
        IList<CMNERPComment_DetailedEntity> IEntityBuilder<CMNERPComment_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNERPComment_DetailedEntity> CMNERPComment_DetailedEntityList = new List<CMNERPComment_DetailedEntity>();

            while (reader.Read())
            {
                CMNERPComment_DetailedEntityList.Add(((IEntityBuilder<CMNERPComment_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMNERPComment_DetailedEntityList.Count > 0) ? CMNERPComment_DetailedEntityList : null;
        }

        CMNERPComment_DetailedEntity IEntityBuilder<CMNERPComment_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMENTID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_COMMENT = 3;
            const Int32 FLD_COMMENTDATE = 4;
            const Int32 FLD_EMPLOYEEID = 5;
            const Int32 FLD_IP = 6;
            const Int32 FLD_CMNPROCESSCATEGORYNAME = 7;
            const Int32 FLD_HREMPLOYEEMEMBERID = 8;
            const Int32 FLD_MEMBERFULLNAME = 9;
            const Int32 FLD_ROWNUMBER = 10;

            CMNERPComment_DetailedEntity cMNERPComment_DetailedEntity = new CMNERPComment_DetailedEntity();

            cMNERPComment_DetailedEntity.CommentID = reader.GetInt64(FLD_COMMENTID);
            cMNERPComment_DetailedEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cMNERPComment_DetailedEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cMNERPComment_DetailedEntity.Comment = reader.GetString(FLD_COMMENT);
            cMNERPComment_DetailedEntity.CommentDate = reader.GetDateTime(FLD_COMMENTDATE);
            cMNERPComment_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            cMNERPComment_DetailedEntity.IP = reader.GetString(FLD_IP);
            if (reader.IsDBNull(FLD_CMNPROCESSCATEGORYNAME)) { cMNERPComment_DetailedEntity.CMNProcessCategoryName = String.Empty; } else { cMNERPComment_DetailedEntity.CMNProcessCategoryName = reader.GetString(FLD_CMNPROCESSCATEGORYNAME); }
            if (reader.IsDBNull(FLD_HREMPLOYEEMEMBERID)) { cMNERPComment_DetailedEntity.HREmployeeMemberID = null; } else { cMNERPComment_DetailedEntity.HREmployeeMemberID = reader.GetInt64(FLD_HREMPLOYEEMEMBERID); }
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cMNERPComment_DetailedEntity.MemberFullName = String.Empty; } else { cMNERPComment_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMNERPComment_DetailedEntity.RowNumber = null; } else { cMNERPComment_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMNERPComment_DetailedEntity;
        }
    }
}
