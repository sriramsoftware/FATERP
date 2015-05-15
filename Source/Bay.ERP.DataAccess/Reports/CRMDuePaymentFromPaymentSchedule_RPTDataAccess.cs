// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:09:58




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
    internal sealed partial class CRMDuePaymentFromPaymentSchedule_RPTDataAccess : BaseDataAccess, ICRMDuePaymentFromPaymentSchedule_RPTDataAccess
    {
        #region Constructors

        public CRMDuePaymentFromPaymentSchedule_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity> CreateEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>()
        {
            return (new CRMDuePaymentFromPaymentSchedule_RPTBuilder()) as IEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMDuePaymentFromPaymentSchedule_RPTEntity> ICRMDuePaymentFromPaymentSchedule_RPTDataAccess.GetIL(DateTime toDate)
        {
            try
            {
                const string SP = "dbo.CRMDuePaymentFromPaymentSchedule_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMDuePaymentFromPaymentSchedule_RPTEntity> list = CreateEntityBuilder<CRMDuePaymentFromPaymentSchedule_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMDuePaymentFromPaymentSchedule_RPTDataAccess.GetDT(DateTime toDate)
        {
            try
            {
                const string SP = "dbo.CRMDuePaymentFromPaymentSchedule_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

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
