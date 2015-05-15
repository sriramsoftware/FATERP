// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNERPCommentBuilder : IEntityBuilder<CMNERPCommentEntity>
    {
        IList<CMNERPCommentEntity> IEntityBuilder<CMNERPCommentEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNERPCommentEntity> CMNERPCommentEntityList = new List<CMNERPCommentEntity>();

            while (reader.Read())
            {
                CMNERPCommentEntityList.Add(((IEntityBuilder<CMNERPCommentEntity>)this).BuildEntity(reader));
            }

            return (CMNERPCommentEntityList.Count > 0) ? CMNERPCommentEntityList : null;
        }

        CMNERPCommentEntity IEntityBuilder<CMNERPCommentEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMENTID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_COMMENT = 3;
            const Int32 FLD_COMMENTDATE = 4;
            const Int32 FLD_EMPLOYEEID = 5;
            const Int32 FLD_IP = 6;

            CMNERPCommentEntity cMNERPCommentEntity = new CMNERPCommentEntity();

            cMNERPCommentEntity.CommentID = reader.GetInt64(FLD_COMMENTID);
            cMNERPCommentEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cMNERPCommentEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            cMNERPCommentEntity.Comment = reader.GetString(FLD_COMMENT);
            cMNERPCommentEntity.CommentDate = reader.GetDateTime(FLD_COMMENTDATE);
            cMNERPCommentEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            cMNERPCommentEntity.IP = reader.GetString(FLD_IP);

            return cMNERPCommentEntity;
        }
    }
}
