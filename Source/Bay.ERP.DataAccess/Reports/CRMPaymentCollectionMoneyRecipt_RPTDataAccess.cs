// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2013, 02:23:48




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
    internal sealed partial class CRMPaymentCollectionMoneyRecipt_RPTDataAccess : BaseDataAccess, ICRMPaymentCollectionMoneyRecipt_RPTDataAccess
    {
        #region Constructors

        public CRMPaymentCollectionMoneyRecipt_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity> CreateEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>()
        {
            return (new CRMPaymentCollectionMoneyRecipt_RPTBuilder()) as IEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMPaymentCollectionMoneyRecipt_RPTEntity> ICRMPaymentCollectionMoneyRecipt_RPTDataAccess.GetIL(Int64 paymentCollectionID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollectionMoneyRecipt_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PaymentCollectionID", DbType.Int64, paymentCollectionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentCollectionMoneyRecipt_RPTEntity> list = CreateEntityBuilder<CRMPaymentCollectionMoneyRecipt_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentCollectionMoneyRecipt_RPTDataAccess.GetDT(Int64 paymentCollectionID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollectionMoneyRecipt_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PaymentCollectionID", DbType.Int64, paymentCollectionID);	

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
