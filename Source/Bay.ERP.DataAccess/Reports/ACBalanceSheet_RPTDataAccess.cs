// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 01:13:55




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
    internal sealed partial class ACBalanceSheet_RPTDataAccess : BaseDataAccess, IACBalanceSheet_RPTDataAccess
    {
        #region Constructors

        public ACBalanceSheet_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACBalanceSheet_RPTEntity> CreateEntityBuilder<ACBalanceSheet_RPTEntity>()
        {
            return (new ACBalanceSheet_RPTBuilder()) as IEntityBuilder<ACBalanceSheet_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACBalanceSheet_RPTEntity> IACBalanceSheet_RPTDataAccess.GetIL(Int64 fiscalYearID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACBalanceSheet_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACBalanceSheet_RPTEntity> list = CreateEntityBuilder<ACBalanceSheet_RPTEntity>().BuildEntities(reader);

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

        DataTable IACBalanceSheet_RPTDataAccess.GetDT(Int64 fiscalYearID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.ACBalanceSheet_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
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
