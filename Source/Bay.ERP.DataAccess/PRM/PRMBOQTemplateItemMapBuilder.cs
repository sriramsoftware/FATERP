// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMBOQTemplateItemMapBuilder : IEntityBuilder<PRMBOQTemplateItemMapEntity>
    {
        IList<PRMBOQTemplateItemMapEntity> IEntityBuilder<PRMBOQTemplateItemMapEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMBOQTemplateItemMapEntity> PRMBOQTemplateItemMapEntityList = new List<PRMBOQTemplateItemMapEntity>();

            while (reader.Read())
            {
                PRMBOQTemplateItemMapEntityList.Add(((IEntityBuilder<PRMBOQTemplateItemMapEntity>)this).BuildEntity(reader));
            }

            return (PRMBOQTemplateItemMapEntityList.Count > 0) ? PRMBOQTemplateItemMapEntityList : null;
        }

        PRMBOQTemplateItemMapEntity IEntityBuilder<PRMBOQTemplateItemMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BOQTEMPLATEITEMMAPID = 0;
            const Int32 FLD_BOQTEMPLATEID = 1;
            const Int32 FLD_ITEMID = 2;
            const Int32 FLD_SEQUENCENO = 3;

            PRMBOQTemplateItemMapEntity pRMBOQTemplateItemMapEntity = new PRMBOQTemplateItemMapEntity();

            pRMBOQTemplateItemMapEntity.BOQTemplateItemMapID = reader.GetInt64(FLD_BOQTEMPLATEITEMMAPID);
            pRMBOQTemplateItemMapEntity.BOQTemplateID = reader.GetInt64(FLD_BOQTEMPLATEID);
            pRMBOQTemplateItemMapEntity.ItemID = reader.GetInt64(FLD_ITEMID);
            pRMBOQTemplateItemMapEntity.SequenceNo = reader.GetInt32(FLD_SEQUENCENO);

            return pRMBOQTemplateItemMapEntity;
        }
    }
}
