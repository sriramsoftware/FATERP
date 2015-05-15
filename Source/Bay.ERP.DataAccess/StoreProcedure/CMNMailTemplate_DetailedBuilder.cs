// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Nov-2013, 10:24:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNMailTemplate_DetailedBuilder : IEntityBuilder<CMNMailTemplate_DetailedEntity>
    {
        IList<CMNMailTemplate_DetailedEntity> IEntityBuilder<CMNMailTemplate_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNMailTemplate_DetailedEntity> CMNMailTemplate_DetailedEntityList = new List<CMNMailTemplate_DetailedEntity>();

            while (reader.Read())
            {
                CMNMailTemplate_DetailedEntityList.Add(((IEntityBuilder<CMNMailTemplate_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMNMailTemplate_DetailedEntityList.Count > 0) ? CMNMailTemplate_DetailedEntityList : null;
        }

        CMNMailTemplate_DetailedEntity IEntityBuilder<CMNMailTemplate_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MAILTEMPLATEID = 0;
            const Int32 FLD_MAILTEMPLATETYPEID = 1;
            const Int32 FLD_TEMPLATENAME = 2;
            const Int32 FLD_SUBJECT = 3;
            const Int32 FLD_BODYMESSAGE = 4;
            const Int32 FLD_SIGNATURE = 5;
            const Int32 FLD_MAILTEXTTYPEID = 6;
            const Int32 FLD_REMARKS = 7;
            const Int32 FLD_MAILTEXTTYPENAME = 8;
            const Int32 FLD_MAILTEMPLATETYPENAME = 9;

            CMNMailTemplate_DetailedEntity cMNMailTemplate_DetailedEntity = new CMNMailTemplate_DetailedEntity();

            cMNMailTemplate_DetailedEntity.MailTemplateID = reader.GetInt64(FLD_MAILTEMPLATEID);
            cMNMailTemplate_DetailedEntity.MailTemplateTypeID = reader.GetInt64(FLD_MAILTEMPLATETYPEID);
            cMNMailTemplate_DetailedEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_SUBJECT)) { cMNMailTemplate_DetailedEntity.Subject = String.Empty; } else { cMNMailTemplate_DetailedEntity.Subject = reader.GetString(FLD_SUBJECT); }
            cMNMailTemplate_DetailedEntity.BodyMessage = reader.GetString(FLD_BODYMESSAGE);
            if (reader.IsDBNull(FLD_SIGNATURE)) { cMNMailTemplate_DetailedEntity.Signature = String.Empty; } else { cMNMailTemplate_DetailedEntity.Signature = reader.GetString(FLD_SIGNATURE); }
            cMNMailTemplate_DetailedEntity.MailTextTypeID = reader.GetInt64(FLD_MAILTEXTTYPEID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNMailTemplate_DetailedEntity.Remarks = String.Empty; } else { cMNMailTemplate_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNMailTemplate_DetailedEntity.MailTextTypeName = reader.GetString(FLD_MAILTEXTTYPENAME);
            cMNMailTemplate_DetailedEntity.MailTemplateTypeName = reader.GetString(FLD_MAILTEMPLATETYPENAME);

            return cMNMailTemplate_DetailedEntity;
        }
    }
}
