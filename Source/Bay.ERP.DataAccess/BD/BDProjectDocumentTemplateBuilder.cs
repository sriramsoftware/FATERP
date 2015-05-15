// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectDocumentTemplateBuilder : IEntityBuilder<BDProjectDocumentTemplateEntity>
    {
        IList<BDProjectDocumentTemplateEntity> IEntityBuilder<BDProjectDocumentTemplateEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectDocumentTemplateEntity> BDProjectDocumentTemplateEntityList = new List<BDProjectDocumentTemplateEntity>();

            while (reader.Read())
            {
                BDProjectDocumentTemplateEntityList.Add(((IEntityBuilder<BDProjectDocumentTemplateEntity>)this).BuildEntity(reader));
            }

            return (BDProjectDocumentTemplateEntityList.Count > 0) ? BDProjectDocumentTemplateEntityList : null;
        }

        BDProjectDocumentTemplateEntity IEntityBuilder<BDProjectDocumentTemplateEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTDOCUMENTTEMPLATEID = 0;
            const Int32 FLD_TEMPLATENAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity = new BDProjectDocumentTemplateEntity();

            bDProjectDocumentTemplateEntity.ProjectDocumentTemplateID = reader.GetInt64(FLD_PROJECTDOCUMENTTEMPLATEID);
            bDProjectDocumentTemplateEntity.TemplateName = reader.GetString(FLD_TEMPLATENAME);
            if (reader.IsDBNull(FLD_REMARKS)) { bDProjectDocumentTemplateEntity.Remarks = String.Empty; } else { bDProjectDocumentTemplateEntity.Remarks = reader.GetString(FLD_REMARKS); }
            bDProjectDocumentTemplateEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDProjectDocumentTemplateEntity;
        }
    }
}
