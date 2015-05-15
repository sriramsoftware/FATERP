// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jun-2013, 02:33:32




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMCustomerPortfolioSummary_RPTBuilder : IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>
    {
        IList<CRMCustomerPortfolioSummary_RPTEntity> IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMCustomerPortfolioSummary_RPTEntity> CRMCustomerPortfolioSummary_RPTEntityList = new List<CRMCustomerPortfolioSummary_RPTEntity>();

            while (reader.Read())
            {
                CRMCustomerPortfolioSummary_RPTEntityList.Add(((IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>)this).BuildEntity(reader));
            }

            return (CRMCustomerPortfolioSummary_RPTEntityList.Count > 0) ? CRMCustomerPortfolioSummary_RPTEntityList : null;
        }

        CRMCustomerPortfolioSummary_RPTEntity IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERBASICINFOID = 0;
            const Int32 FLD_PROJECTFLOORUNITID = 1;
            const Int32 FLD_AGREEMENTTYPEID = 2;
            const Int32 FLD_TOTALAGREEMENTAMOUNT = 3;
            const Int32 FLD_TOTALRECEIVABLEAMOUNTWITHFEES = 4;
            const Int32 FLD_TOTALRECEIVABLEAGREEMENTAAMOUNT = 5;
            const Int32 FLD_TOTALRECEIVABLEAGREEMENTBAMOUNT = 6;
            const Int32 FLD_TOTALRECEIVABLEAGREEMENTCAMOUNT = 7;
            const Int32 FLD_TOTALRECEIVEDAMOUNT = 8;
            const Int32 FLD_TOTALOVERDUEAMOUNT = 9;

            CRMCustomerPortfolioSummary_RPTEntity cRMCustomerPortfolioSummary_RPTEntity = new CRMCustomerPortfolioSummary_RPTEntity();

            cRMCustomerPortfolioSummary_RPTEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            if (reader.IsDBNull(FLD_PROJECTFLOORUNITID)) { cRMCustomerPortfolioSummary_RPTEntity.ProjectFloorUnitID = null; } else { cRMCustomerPortfolioSummary_RPTEntity.ProjectFloorUnitID = reader.GetInt64(FLD_PROJECTFLOORUNITID); }
            cRMCustomerPortfolioSummary_RPTEntity.AgreementTypeID = reader.GetInt64(FLD_AGREEMENTTYPEID);
            if (reader.IsDBNull(FLD_TOTALAGREEMENTAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalAgreementAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalAgreementAmount = reader.GetDecimal(FLD_TOTALAGREEMENTAMOUNT); }
            if (reader.IsDBNull(FLD_TOTALRECEIVABLEAMOUNTWITHFEES)) { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAmountWithFees = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAmountWithFees = reader.GetDecimal(FLD_TOTALRECEIVABLEAMOUNTWITHFEES); }
            if (reader.IsDBNull(FLD_TOTALRECEIVABLEAGREEMENTAAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementAAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementAAmount = reader.GetDecimal(FLD_TOTALRECEIVABLEAGREEMENTAAMOUNT); }
            if (reader.IsDBNull(FLD_TOTALRECEIVABLEAGREEMENTBAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementBAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementBAmount = reader.GetDecimal(FLD_TOTALRECEIVABLEAGREEMENTBAMOUNT); }
            if (reader.IsDBNull(FLD_TOTALRECEIVABLEAGREEMENTCAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementCAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivableAgreementCAmount = reader.GetDecimal(FLD_TOTALRECEIVABLEAGREEMENTCAMOUNT); }
            if (reader.IsDBNull(FLD_TOTALRECEIVEDAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivedAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalReceivedAmount = reader.GetDecimal(FLD_TOTALRECEIVEDAMOUNT); }
            if (reader.IsDBNull(FLD_TOTALOVERDUEAMOUNT)) { cRMCustomerPortfolioSummary_RPTEntity.TotalOverDueAmount = null; } else { cRMCustomerPortfolioSummary_RPTEntity.TotalOverDueAmount = reader.GetDecimal(FLD_TOTALOVERDUEAMOUNT); }

            return cRMCustomerPortfolioSummary_RPTEntity;
        }
    }
}
