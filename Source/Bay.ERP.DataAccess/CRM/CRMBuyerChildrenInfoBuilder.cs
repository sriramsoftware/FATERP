// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 05:23:07




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMBuyerChildrenInfoBuilder : IEntityBuilder<CRMBuyerChildrenInfoEntity>
    {
        IList<CRMBuyerChildrenInfoEntity> IEntityBuilder<CRMBuyerChildrenInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerChildrenInfoEntity> CRMBuyerChildrenInfoEntityList = new List<CRMBuyerChildrenInfoEntity>();

            while (reader.Read())
            {
                CRMBuyerChildrenInfoEntityList.Add(((IEntityBuilder<CRMBuyerChildrenInfoEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerChildrenInfoEntityList.Count > 0) ? CRMBuyerChildrenInfoEntityList : null;
        }

        CRMBuyerChildrenInfoEntity IEntityBuilder<CRMBuyerChildrenInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERCHILDRENINFOID = 0;
            const Int32 FLD_BUYERBASICINFOID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DOB = 3;
            const Int32 FLD_GENDERID = 4;
            const Int32 FLD_EDITIONALINSTITUTENAME = 5;

            CRMBuyerChildrenInfoEntity cRMBuyerChildrenInfoEntity = new CRMBuyerChildrenInfoEntity();

            cRMBuyerChildrenInfoEntity.BuyerChildrenInfoID = reader.GetInt64(FLD_BUYERCHILDRENINFOID);
            cRMBuyerChildrenInfoEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerChildrenInfoEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DOB)) { cRMBuyerChildrenInfoEntity.DOB = null; } else { cRMBuyerChildrenInfoEntity.DOB = reader.GetDateTime(FLD_DOB); }
            cRMBuyerChildrenInfoEntity.GenderID = reader.GetInt64(FLD_GENDERID);
            if (reader.IsDBNull(FLD_EDITIONALINSTITUTENAME)) { cRMBuyerChildrenInfoEntity.EditionalInstituteName = String.Empty; } else { cRMBuyerChildrenInfoEntity.EditionalInstituteName = reader.GetString(FLD_EDITIONALINSTITUTENAME); }

            return cRMBuyerChildrenInfoEntity;
        }
    }
}
