// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Dec-2013, 03:44:05




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
    internal sealed partial class CRMPaymentSchedule_RPTDataAccess : BaseDataAccess, ICRMPaymentSchedule_RPTDataAccess
    {
        #region Constructors

        public CRMPaymentSchedule_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentSchedule_RPTEntity> CreateEntityBuilder<CRMPaymentSchedule_RPTEntity>()
        {
            return (new CRMPaymentSchedule_RPTBuilder()) as IEntityBuilder<CRMPaymentSchedule_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMPaymentSchedule_RPTEntity> ICRMPaymentSchedule_RPTDataAccess.GetIL(Int64 paymentScheduleID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentSchedule_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PaymentScheduleID", DbType.Int64, paymentScheduleID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentSchedule_RPTEntity> list = CreateEntityBuilder<CRMPaymentSchedule_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentSchedule_RPTDataAccess.GetDT(Int64 paymentScheduleID)
        {
            try
            {
                const string SP = "dbo.CRMPaymentSchedule_RPT";

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
