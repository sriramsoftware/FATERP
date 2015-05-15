// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACPettyCashBuilder : IEntityBuilder<ACPettyCashEntity>
    {
        IList<ACPettyCashEntity> IEntityBuilder<ACPettyCashEntity>.BuildEntities(IDataReader reader)
        {
            List<ACPettyCashEntity> ACPettyCashEntityList = new List<ACPettyCashEntity>();

            while (reader.Read())
            {
                ACPettyCashEntityList.Add(((IEntityBuilder<ACPettyCashEntity>)this).BuildEntity(reader));
            }

            return (ACPettyCashEntityList.Count > 0) ? ACPettyCashEntityList : null;
        }

        ACPettyCashEntity IEntityBuilder<ACPettyCashEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACPETTYCASHID = 0;
            const Int32 FLD_CURRENTBALANCE = 1;

            ACPettyCashEntity aCPettyCashEntity = new ACPettyCashEntity();

            aCPettyCashEntity.ACPettyCashID = reader.GetInt64(FLD_ACPETTYCASHID);
            aCPettyCashEntity.CurrentBalance = reader.GetDecimal(FLD_CURRENTBALANCE);

            return aCPettyCashEntity;
        }
    }
}
