// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2013, 02:02:01




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
    internal sealed partial class CRMPaymentEncashed_RPTDataAccess : BaseDataAccess, ICRMPaymentEncashed_RPTDataAccess
    {
        #region Constructors

        public CRMPaymentEncashed_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMPaymentEncashed_RPTEntity> CreateEntityBuilder<CRMPaymentEncashed_RPTEntity>()
        {
            return (new CRMPaymentEncashed_RPTBuilder()) as IEntityBuilder<CRMPaymentEncashed_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CRMPaymentEncashed_RPTEntity> ICRMPaymentEncashed_RPTDataAccess.GetIL(DateTime toDate, Boolean encashed)
        {
            try
            {
                const string SP = "dbo.CRMPaymentEncashed_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@Encashed", DbType.Boolean, encashed);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMPaymentEncashed_RPTEntity> list = CreateEntityBuilder<CRMPaymentEncashed_RPTEntity>().BuildEntities(reader);

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

        DataTable ICRMPaymentEncashed_RPTDataAccess.GetDT(DateTime toDate, Boolean encashed)
        {
            try
            {
                const string SP = "dbo.CRMPaymentEncashed_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@Encashed", DbType.Boolean, encashed);	

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
