// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeNoticeTemplateBuilder : IEntityBuilder<HREmployeeNoticeTemplateEntity>
    {
        IList<HREmployeeNoticeTemplateEntity> IEntityBuilder<HREmployeeNoticeTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeNoticeTemplateEntity> HREmployeeNoticeTemplateEntityList = new List<HREmployeeNoticeTemplateEntity>();

            while (reader.Read())
            {
                HREmployeeNoticeTemplateEntityList.Add(((IEntityBuilder<HREmployeeNoticeTemplateEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeNoticeTemplateEntityList.Count > 0) ? HREmployeeNoticeTemplateEntityList : null;
        }

        HREmployeeNoticeTemplateEntity IEntityBuilder<HREmployeeNoticeTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEENOTICETEMPLATEID = 0;
            const Int32 FLD_NOTICETEMPLATETYPEID = 1;
            const Int32 FLD_TEMPLATENAME = 2;
            const Int32 FLD_TEXT = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_CREATEDATE = 5;
            const Int32 FLD_IP = 6;
            const Int32 FLD_CREATEDBYEMPLOYEEID = 7;

            HREmployeeNoticeTemplateEntity hREmployeeNoticeTemplateEntity = new HREmployeeNoticeTemplateEntity();

            hREmployeeNoticeTemplateEntity.EmployeeNoticeTemplateID = reader.GetInt64(FLD_EMPLOYEENOTICETEMPLATEID);
            hREmployeeNoticeTemplateEntity.NoticeTemplateTypeID = reader.GetInt64(FLD_NOTICETEMPLATETYPEID);
            hREmployeeNoticeTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            hREmployeeNoticeTemplateEntity.Text = reader.GetString(FLD_TEXT);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeNoticeTemplateEntity.Remarks = String.Empty; } else { hREmployeeNoticeTemplateEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeNoticeTemplateEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            hREmployeeNoticeTemplateEntity.IP = reader.GetString(FLD_IP);
            hREmployeeNoticeTemplateEntity.CreatedByEmployeeID = reader.GetInt64(FLD_CREATEDBYEMPLOYEEID);

            return hREmployeeNoticeTemplateEntity;
        }
    }
}
