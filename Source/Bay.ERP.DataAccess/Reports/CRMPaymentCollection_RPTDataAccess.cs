// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-May-2013, 01:17:08




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
    internal sealed partial class CRMPaymentCollection_RPTDataAccess : BaseDataAccess, ICRMPaymentCollection_RPTDataAccess
    {
        #region Constructors

        public CRMPaymentCollection_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentCollection_RPTEntity> CreateEntityBuilder<CRMPaymentCollection_RPTEntity>()
        {
            return (new CRMPaymentCollection_RPTBuilder()) as IEntityBuilder<CRMPaymentCollection_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMPaymentCollection_RPTEntity> ICRMPaymentCollection_RPTDataAccess.GetIL(Int64 paymentScheduleID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollection_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, paymentScheduleID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentCollection_RPTEntity> list = CreateEntityBuilder<CRMPaymentCollection_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentCollection_RPTDataAccess.GetDT(Int64 paymentScheduleID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentCollection_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, paymentScheduleID);	

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
