// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Mar-2013, 05:35:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDTDSCategoryBuilder : IEntityBuilder<ACMDTDSCategoryEntity>
    {
        IList<ACMDTDSCategoryEntity> IEntityBuilder<ACMDTDSCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDTDSCategoryEntity> ACMDTDSCategoryEntityList = new List<ACMDTDSCategoryEntity>();

            while (reader.Read())
            {
                ACMDTDSCategoryEntityList.Add(((IEntityBuilder<ACMDTDSCategoryEntity>)this).BuildEntity(reader));
            }

            return (ACMDTDSCategoryEntityList.Count > 0) ? ACMDTDSCategoryEntityList : null;
        }

        ACMDTDSCategoryEntity IEntityBuilder<ACMDTDSCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_TDSCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            ACMDTDSCategoryEntity aCMDTDSCategoryEntity = new ACMDTDSCategoryEntity();

            aCMDTDSCategoryEntity.TDSCategoryID = reader.GetInt64(FLD_TDSCATEGORYID);
            aCMDTDSCategoryEntity.Name = reader.GetString(FLD_NAME);
            aCMDTDSCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDTDSCategoryEntity;
        }
    }
}
