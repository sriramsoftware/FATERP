// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDHRNoticeTemplateTypeBuilder : IEntityBuilder<MDHRNoticeTemplateTypeEntity>
    {
        IList<MDHRNoticeTemplateTypeEntity> IEntityBuilder<MDHRNoticeTemplateTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDHRNoticeTemplateTypeEntity> MDHRNoticeTemplateTypeEntityList = new List<MDHRNoticeTemplateTypeEntity>();

            while (reader.Read())
            {
                MDHRNoticeTemplateTypeEntityList.Add(((IEntityBuilder<MDHRNoticeTemplateTypeEntity>)this).BuildEntity(reader));
            }

            return (MDHRNoticeTemplateTypeEntityList.Count > 0) ? MDHRNoticeTemplateTypeEntityList : null;
        }

        MDHRNoticeTemplateTypeEntity IEntityBuilder<MDHRNoticeTemplateTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_NOTICETEMPLATETYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity = new MDHRNoticeTemplateTypeEntity();

            mDHRNoticeTemplateTypeEntity.NoticeTemplateTypeID = reader.GetInt64(FLD_NOTICETEMPLATETYPEID);
            mDHRNoticeTemplateTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDHRNoticeTemplateTypeEntity.Description = String.Empty; } else { mDHRNoticeTemplateTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDHRNoticeTemplateTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDHRNoticeTemplateTypeEntity;
        }
    }
}
