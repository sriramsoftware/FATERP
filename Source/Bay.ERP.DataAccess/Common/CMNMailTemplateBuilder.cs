// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Oct-2013, 12:17:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNMailTemplateBuilder : IEntityBuilder<CMNMailTemplateEntity>
    {
        IList<CMNMailTemplateEntity> IEntityBuilder<CMNMailTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNMailTemplateEntity> CMNMailTemplateEntityList = new List<CMNMailTemplateEntity>();

            while (reader.Read())
            {
                CMNMailTemplateEntityList.Add(((IEntityBuilder<CMNMailTemplateEntity>)this).BuildEntity(reader));
            }

            return (CMNMailTemplateEntityList.Count > 0) ? CMNMailTemplateEntityList : null;
        }

        CMNMailTemplateEntity IEntityBuilder<CMNMailTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MAILTEMPLATEID = 0;
            const Int32 FLD_MAILTEMPLATETYPEID = 1;
            const Int32 FLD_TEMPLATENAME = 2;
            const Int32 FLD_SUBJECT = 3;
            const Int32 FLD_BODYMESSAGE = 4;
            const Int32 FLD_SIGNATURE = 5;
            const Int32 FLD_MAILTEXTTYPEID = 6;
            const Int32 FLD_REMARKS = 7;

            CMNMailTemplateEntity cMNMailTemplateEntity = new CMNMailTemplateEntity();

            cMNMailTemplateEntity.MailTemplateID = reader.GetInt64(FLD_MAILTEMPLATEID);
            cMNMailTemplateEntity.MailTemplateTypeID = reader.GetInt64(FLD_MAILTEMPLATETYPEID);
            cMNMailTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_SUBJECT)) { cMNMailTemplateEntity.Subject = String.Empty; } else { cMNMailTemplateEntity.Subject = reader.GetString(FLD_SUBJECT); }
            cMNMailTemplateEntity.BodyMessage = reader.GetString(FLD_BODYMESSAGE);
            if (reader.IsDBNull(FLD_SIGNATURE)) { cMNMailTemplateEntity.Signature = String.Empty; } else { cMNMailTemplateEntity.Signature = reader.GetString(FLD_SIGNATURE); }
            cMNMailTemplateEntity.MailTextTypeID = reader.GetInt64(FLD_MAILTEXTTYPEID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNMailTemplateEntity.Remarks = String.Empty; } else { cMNMailTemplateEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cMNMailTemplateEntity;
        }
    }
}
