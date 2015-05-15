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
    internal sealed class BDProjectDocumentTemplateMapBuilder : IEntityBuilder<BDProjectDocumentTemplateMapEntity>
    {
        IList<BDProjectDocumentTemplateMapEntity> IEntityBuilder<BDProjectDocumentTemplateMapEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectDocumentTemplateMapEntity> BDProjectDocumentTemplateMapEntityList = new List<BDProjectDocumentTemplateMapEntity>();

            while (reader.Read())
            {
                BDProjectDocumentTemplateMapEntityList.Add(((IEntityBuilder<BDProjectDocumentTemplateMapEntity>)this).BuildEntity(reader));
            }

            return (BDProjectDocumentTemplateMapEntityList.Count > 0) ? BDProjectDocumentTemplateMapEntityList : null;
        }

        BDProjectDocumentTemplateMapEntity IEntityBuilder<BDProjectDocumentTemplateMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTDOCUMENTTEMPLATEMAPID = 0;
            const Int32 FLD_PROJECTDOCUMENTTEMPLATEID = 1;
            const Int32 FLD_PROJECTDOCUMENTID = 2;

            BDProjectDocumentTemplateMapEntity bDProjectDocumentTemplateMapEntity = new BDProjectDocumentTemplateMapEntity();

            bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateMapID = reader.GetInt64(FLD_PROJECTDOCUMENTTEMPLATEMAPID);
            bDProjectDocumentTemplateMapEntity.ProjectDocumentTemplateID = reader.GetInt64(FLD_PROJECTDOCUMENTTEMPLATEID);
            bDProjectDocumentTemplateMapEntity.ProjectDocumentID = reader.GetInt64(FLD_PROJECTDOCUMENTID);

            return bDProjectDocumentTemplateMapEntity;
        }
    }
}
