// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCurrencyExchangeRatesBuilder : IEntityBuilder<ACCurrencyExchangeRatesEntity>
    {
        IList<ACCurrencyExchangeRatesEntity> IEntityBuilder<ACCurrencyExchangeRatesEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCurrencyExchangeRatesEntity> ACCurrencyExchangeRatesEntityList = new List<ACCurrencyExchangeRatesEntity>();

            while (reader.Read())
            {
                ACCurrencyExchangeRatesEntityList.Add(((IEntityBuilder<ACCurrencyExchangeRatesEntity>)this).BuildEntity(reader));
            }

            return (ACCurrencyExchangeRatesEntityList.Count > 0) ? ACCurrencyExchangeRatesEntityList : null;
        }

        ACCurrencyExchangeRatesEntity IEntityBuilder<ACCurrencyExchangeRatesEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENCYEXCHANGERATESID = 0;
            const Int32 FLD_CURRENCYID = 1;
            const Int32 FLD_STANDARDCURRENCYID = 2;
            const Int32 FLD_EXCHANGERATE = 3;
            const Int32 FLD_DATEUSEDFROM = 4;
            const Int32 FLD_DATEUSEDUPTO = 5;
            const Int32 FLD_ISCURRENT = 6;

            ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity = new ACCurrencyExchangeRatesEntity();

            aCCurrencyExchangeRatesEntity.CurrencyExchangeRatesID = reader.GetInt64(FLD_CURRENCYEXCHANGERATESID);
            aCCurrencyExchangeRatesEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            aCCurrencyExchangeRatesEntity.StandardCurrencyID = reader.GetInt64(FLD_STANDARDCURRENCYID);
            aCCurrencyExchangeRatesEntity.ExchangeRate = reader.GetDecimal(FLD_EXCHANGERATE);
            aCCurrencyExchangeRatesEntity.DateUsedFrom = reader.GetDateTime(FLD_DATEUSEDFROM);
            if (reader.IsDBNull(FLD_DATEUSEDUPTO)) { aCCurrencyExchangeRatesEntity.DateUsedUpTo = null; } else { aCCurrencyExchangeRatesEntity.DateUsedUpTo = reader.GetDateTime(FLD_DATEUSEDUPTO); }
            aCCurrencyExchangeRatesEntity.IsCurrent = reader.GetBoolean(FLD_ISCURRENT);

            return aCCurrencyExchangeRatesEntity;
        }
    }
}
