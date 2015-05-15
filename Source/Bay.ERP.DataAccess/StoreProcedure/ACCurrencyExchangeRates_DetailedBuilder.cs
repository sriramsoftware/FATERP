// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCurrencyExchangeRates_DetailedBuilder : IEntityBuilder<ACCurrencyExchangeRates_DetailedEntity>
    {
        IList<ACCurrencyExchangeRates_DetailedEntity> IEntityBuilder<ACCurrencyExchangeRates_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCurrencyExchangeRates_DetailedEntity> ACCurrencyExchangeRates_DetailedEntityList = new List<ACCurrencyExchangeRates_DetailedEntity>();

            while (reader.Read())
            {
                ACCurrencyExchangeRates_DetailedEntityList.Add(((IEntityBuilder<ACCurrencyExchangeRates_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACCurrencyExchangeRates_DetailedEntityList.Count > 0) ? ACCurrencyExchangeRates_DetailedEntityList : null;
        }

        ACCurrencyExchangeRates_DetailedEntity IEntityBuilder<ACCurrencyExchangeRates_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENCYEXCHANGERATESID = 0;
            const Int32 FLD_CURRENCYID = 1;
            const Int32 FLD_STANDARDCURRENCYID = 2;
            const Int32 FLD_EXCHANGERATE = 3;
            const Int32 FLD_DATEUSEDFROM = 4;
            const Int32 FLD_DATEUSEDUPTO = 5;
            const Int32 FLD_ISCURRENT = 6;
            const Int32 FLD_CURRENCYNAME = 7;
            const Int32 FLD_STANDARDCURRENCYNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            ACCurrencyExchangeRates_DetailedEntity aCCurrencyExchangeRates_DetailedEntity = new ACCurrencyExchangeRates_DetailedEntity();

            aCCurrencyExchangeRates_DetailedEntity.CurrencyExchangeRatesID = reader.GetInt64(FLD_CURRENCYEXCHANGERATESID);
            aCCurrencyExchangeRates_DetailedEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            aCCurrencyExchangeRates_DetailedEntity.StandardCurrencyID = reader.GetInt64(FLD_STANDARDCURRENCYID);
            aCCurrencyExchangeRates_DetailedEntity.ExchangeRate = reader.GetDecimal(FLD_EXCHANGERATE);
            aCCurrencyExchangeRates_DetailedEntity.DateUsedFrom = reader.GetDateTime(FLD_DATEUSEDFROM);
            if (reader.IsDBNull(FLD_DATEUSEDUPTO)) { aCCurrencyExchangeRates_DetailedEntity.DateUsedUpTo = null; } else { aCCurrencyExchangeRates_DetailedEntity.DateUsedUpTo = reader.GetDateTime(FLD_DATEUSEDUPTO); }
            aCCurrencyExchangeRates_DetailedEntity.IsCurrent = reader.GetBoolean(FLD_ISCURRENT);
            if (reader.IsDBNull(FLD_CURRENCYNAME)) { aCCurrencyExchangeRates_DetailedEntity.CurrencyName = String.Empty; } else { aCCurrencyExchangeRates_DetailedEntity.CurrencyName = reader.GetString(FLD_CURRENCYNAME); }
            if (reader.IsDBNull(FLD_STANDARDCURRENCYNAME)) { aCCurrencyExchangeRates_DetailedEntity.StandardCurrencyName = String.Empty; } else { aCCurrencyExchangeRates_DetailedEntity.StandardCurrencyName = reader.GetString(FLD_STANDARDCURRENCYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCCurrencyExchangeRates_DetailedEntity.RowNumber = null; } else { aCCurrencyExchangeRates_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCCurrencyExchangeRates_DetailedEntity;
        }
    }
}
