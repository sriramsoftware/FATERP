// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountResourceAccountMapBuilder : IEntityBuilder<ACAccountResourceAccountMapEntity>
    {
        IList<ACAccountResourceAccountMapEntity> IEntityBuilder<ACAccountResourceAccountMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountResourceAccountMapEntity> ACAccountResourceAccountMapEntityList = new List<ACAccountResourceAccountMapEntity>();

            while (reader.Read())
            {
                ACAccountResourceAccountMapEntityList.Add(((IEntityBuilder<ACAccountResourceAccountMapEntity>)this).BuildEntity(reader));
            }

            return (ACAccountResourceAccountMapEntityList.Count > 0) ? ACAccountResourceAccountMapEntityList : null;
        }

        ACAccountResourceAccountMapEntity IEntityBuilder<ACAccountResourceAccountMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESOURCEACCOUNTMAPID = 0;
            const Int32 FLD_ACCOUNTID = 1;
            const Int32 FLD_ACCOUNTRESOURCECATEGORYID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_REMARKS = 4;

            ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity = new ACAccountResourceAccountMapEntity();

            aCAccountResourceAccountMapEntity.ResourceAccountMapID = reader.GetInt64(FLD_RESOURCEACCOUNTMAPID);
            aCAccountResourceAccountMapEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCAccountResourceAccountMapEntity.AccountResourceCategoryID = reader.GetInt64(FLD_ACCOUNTRESOURCECATEGORYID);
            aCAccountResourceAccountMapEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_REMARKS)) { aCAccountResourceAccountMapEntity.Remarks = String.Empty; } else { aCAccountResourceAccountMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return aCAccountResourceAccountMapEntity;
        }
    }
}
