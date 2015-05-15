// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Apr-2013, 12:28:07




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
    internal sealed partial class ACAccountBalanceSheet_CustomDataAccess : BaseDataAccess, IACAccountBalanceSheet_CustomDataAccess
    {
        #region Constructors

        public ACAccountBalanceSheet_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountBalanceSheet_CustomEntity> CreateEntityBuilder<ACAccountBalanceSheet_CustomEntity>()
        {
            return (new ACAccountBalanceSheet_CustomBuilder()) as IEntityBuilder<ACAccountBalanceSheet_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACAccountBalanceSheet_CustomEntity> IACAccountBalanceSheet_CustomDataAccess.GetIL(Int64 accountGroupID, Int64 fiscalYearID, DateTime asAtDate)
        {
            try
            {
                const string SP = "dbo.ACAccountBalanceSheet_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, accountGroupID);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@AsAtDate", DbType.DateTime, asAtDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountBalanceSheet_CustomEntity> list = CreateEntityBuilder<ACAccountBalanceSheet_CustomEntity>().BuildEntities(reader);

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

        DataTable IACAccountBalanceSheet_CustomDataAccess.GetDT(Int64 accountGroupID, Int64 fiscalYearID, DateTime asAtDate)
        {
            try
            {
                const string SP = "dbo.ACAccountBalanceSheet_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@AccountGroupID", DbType.Int64, accountGroupID);	
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@AsAtDate", DbType.DateTime, asAtDate);	

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
