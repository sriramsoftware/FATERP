// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jun-2013, 02:26:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACBankAccountPaymentPostPayableStatementDetailMapBuilder : IEntityBuilder<ACBankAccountPaymentPostPayableStatementDetailMapEntity>
    {
        IList<ACBankAccountPaymentPostPayableStatementDetailMapEntity> IEntityBuilder<ACBankAccountPaymentPostPayableStatementDetailMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ACBankAccountPaymentPostPayableStatementDetailMapEntity> ACBankAccountPaymentPostPayableStatementDetailMapEntityList = new List<ACBankAccountPaymentPostPayableStatementDetailMapEntity>();

            while (reader.Read())
            {
                ACBankAccountPaymentPostPayableStatementDetailMapEntityList.Add(((IEntityBuilder<ACBankAccountPaymentPostPayableStatementDetailMapEntity>)this).BuildEntity(reader));
            }

            return (ACBankAccountPaymentPostPayableStatementDetailMapEntityList.Count > 0) ? ACBankAccountPaymentPostPayableStatementDetailMapEntityList : null;
        }

        ACBankAccountPaymentPostPayableStatementDetailMapEntity IEntityBuilder<ACBankAccountPaymentPostPayableStatementDetailMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTPAYMENTPOSTPAYABLESTATEMENTDETAILMAPID = 0;
            const Int32 FLD_BANKACCOUNTPAYMENTID = 1;
            const Int32 FLD_POSTPAYABLESTATEMENTDETAILID = 2;
            const Int32 FLD_REMARKS = 3;

            ACBankAccountPaymentPostPayableStatementDetailMapEntity aCBankAccountPaymentPostPayableStatementDetailMapEntity = new ACBankAccountPaymentPostPayableStatementDetailMapEntity();

            aCBankAccountPaymentPostPayableStatementDetailMapEntity.BankAccountPaymentPostPayableStatementDetailMapID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTPOSTPAYABLESTATEMENTDETAILMAPID);
            aCBankAccountPaymentPostPayableStatementDetailMapEntity.BankAccountPaymentID = reader.GetInt64(FLD_BANKACCOUNTPAYMENTID);
            aCBankAccountPaymentPostPayableStatementDetailMapEntity.PostPayableStatementDetailID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTDETAILID);
            if (reader.IsDBNull(FLD_REMARKS)) { aCBankAccountPaymentPostPayableStatementDetailMapEntity.Remarks = String.Empty; } else { aCBankAccountPaymentPostPayableStatementDetailMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return aCBankAccountPaymentPostPayableStatementDetailMapEntity;
        }
    }
}
