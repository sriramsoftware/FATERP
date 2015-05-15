// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDDebitCreditBuilder : IEntityBuilder<ACMDDebitCreditEntity>
    {
        IList<ACMDDebitCreditEntity> IEntityBuilder<ACMDDebitCreditEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDDebitCreditEntity> ACMDDebitCreditEntityList = new List<ACMDDebitCreditEntity>();

            while (reader.Read())
            {
                ACMDDebitCreditEntityList.Add(((IEntityBuilder<ACMDDebitCreditEntity>)this).BuildEntity(reader));
            }

            return (ACMDDebitCreditEntityList.Count > 0) ? ACMDDebitCreditEntityList : null;
        }

        ACMDDebitCreditEntity IEntityBuilder<ACMDDebitCreditEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MDDEBITCREDITID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISDEBIT = 2;
            const Int32 FLD_ISCREDIT = 3;

            ACMDDebitCreditEntity aCMDDebitCreditEntity = new ACMDDebitCreditEntity();

            aCMDDebitCreditEntity.MDDebitCreditID = reader.GetInt64(FLD_MDDEBITCREDITID);
            aCMDDebitCreditEntity.Name = reader.GetString(FLD_NAME);
            aCMDDebitCreditEntity.IsDebit = reader.GetBoolean(FLD_ISDEBIT);
            aCMDDebitCreditEntity.IsCredit = reader.GetBoolean(FLD_ISCREDIT);

            return aCMDDebitCreditEntity;
        }
    }
}
