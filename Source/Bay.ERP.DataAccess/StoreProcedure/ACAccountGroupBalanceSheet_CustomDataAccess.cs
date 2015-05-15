// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 02:55:23




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
    internal sealed partial class ACAccountGroupBalanceSheet_CustomDataAccess : BaseDataAccess, IACAccountGroupBalanceSheet_CustomDataAccess
    {
        #region Constructors

        public ACAccountGroupBalanceSheet_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity> CreateEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>()
        {
            return (new ACAccountGroupBalanceSheet_CustomBuilder()) as IEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACAccountGroupBalanceSheet_CustomEntity> IACAccountGroupBalanceSheet_CustomDataAccess.GetIL(Int64 fiscalYearID, DateTime asAtDate)
        {
            try
            {
                const string SP = "dbo.ACAccountGroupBalanceSheet_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	
				    Database.AddInParameter(cmd, "@AsAtDate", DbType.DateTime, asAtDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACAccountGroupBalanceSheet_CustomEntity> list = CreateEntityBuilder<ACAccountGroupBalanceSheet_CustomEntity>().BuildEntities(reader);

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

        DataTable IACAccountGroupBalanceSheet_CustomDataAccess.GetDT(Int64 fiscalYearID, DateTime asAtDate)
        {
            try
            {
                const string SP = "dbo.ACAccountGroupBalanceSheet_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
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
