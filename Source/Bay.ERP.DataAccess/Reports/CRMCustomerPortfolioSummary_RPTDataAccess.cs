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
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class CRMCustomerPortfolioSummary_RPTDataAccess : BaseDataAccess, ICRMCustomerPortfolioSummary_RPTDataAccess
    {
        #region Constructors

        public CRMCustomerPortfolioSummary_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity> CreateEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>()
        {
            return (new CRMCustomerPortfolioSummary_RPTBuilder()) as IEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMCustomerPortfolioSummary_RPTEntity> ICRMCustomerPortfolioSummary_RPTDataAccess.GetIL(Int64 buyerBasicInfoID, Int64 projectFloorUnitID)
        {
            try
            {
                const string SP = "dbo.CRMCustomerPortfolioSummary_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, buyerBasicInfoID);	
				    Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, projectFloorUnitID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMCustomerPortfolioSummary_RPTEntity> list = CreateEntityBuilder<CRMCustomerPortfolioSummary_RPTEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable ICRMCustomerPortfolioSummary_RPTDataAccess.GetDT(Int64 buyerBasicInfoID, Int64 projectFloorUnitID)
        {
            try
            {
                const string SP = "dbo.CRMCustomerPortfolioSummary_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, buyerBasicInfoID);	
				    Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, projectFloorUnitID);	

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
