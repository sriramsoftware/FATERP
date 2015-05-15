// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    internal sealed partial class MDCurrencyDataAccess : BaseDataAccess, IMDCurrencyDataAccess
    {
        #region Constructors

        public MDCurrencyDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDCurrencyEntity> CreateEntityBuilder<MDCurrencyEntity>()
        {
            return (new MDCurrencyBuilder()) as IEntityBuilder<MDCurrencyEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDCurrencyDataAccess.Add(MDCurrencyEntity mDCurrencyEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDCurrencyEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDCurrencyEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(MDCurrencyEntity mDCurrencyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CurrencyID");

                Database.AddInParameter(cmd, "@Abbreviation", DbType.String, mDCurrencyEntity.Abbreviation);	
                Database.AddInParameter(cmd, "@Symbol", DbType.String, mDCurrencyEntity.Symbol);	
                Database.AddInParameter(cmd, "@CurrencyName", DbType.String, mDCurrencyEntity.CurrencyName);	
                Database.AddInParameter(cmd, "@HundredthsName", DbType.String, mDCurrencyEntity.HundredthsName);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, mDCurrencyEntity.CountryID);	
                Database.AddInParameter(cmd, "@IsStandardCurrency", DbType.Boolean, mDCurrencyEntity.IsStandardCurrency);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDCurrencyEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDCurrencyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDCurrencyEntity mDCurrencyEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CurrencyID", db);

                db.AddInParameter(cmd, "@Abbreviation", DbType.String, mDCurrencyEntity.Abbreviation);
                db.AddInParameter(cmd, "@Symbol", DbType.String, mDCurrencyEntity.Symbol);
                db.AddInParameter(cmd, "@CurrencyName", DbType.String, mDCurrencyEntity.CurrencyName);
                db.AddInParameter(cmd, "@HundredthsName", DbType.String, mDCurrencyEntity.HundredthsName);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, mDCurrencyEntity.CountryID);
                db.AddInParameter(cmd, "@IsStandardCurrency", DbType.Boolean, mDCurrencyEntity.IsStandardCurrency);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDCurrencyEntity.IsRemoved);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> IMDCurrencyDataAccess.Add(IList<MDCurrencyEntity> mDCurrencyEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDCurrencyEntity mDCurrencyEntity in mDCurrencyEntityList)
            {
                returnCode = (this as IMDCurrencyDataAccess).Add(mDCurrencyEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDCurrencyDataAccess.Update(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDCurrencyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDCurrencyEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CurrencyID", DbType.Int64, mDCurrencyEntity.CurrencyID);
                Database.AddInParameter(cmd, "@Abbreviation", DbType.String, mDCurrencyEntity.Abbreviation);
                Database.AddInParameter(cmd, "@Symbol", DbType.String, mDCurrencyEntity.Symbol);
                Database.AddInParameter(cmd, "@CurrencyName", DbType.String, mDCurrencyEntity.CurrencyName);
                Database.AddInParameter(cmd, "@HundredthsName", DbType.String, mDCurrencyEntity.HundredthsName);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, mDCurrencyEntity.CountryID);
                Database.AddInParameter(cmd, "@IsStandardCurrency", DbType.Boolean, mDCurrencyEntity.IsStandardCurrency);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDCurrencyEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDCurrencyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CurrencyID", DbType.Int64, mDCurrencyEntity.CurrencyID);
                db.AddInParameter(cmd, "@Abbreviation", DbType.String, mDCurrencyEntity.Abbreviation);
                db.AddInParameter(cmd, "@Symbol", DbType.String, mDCurrencyEntity.Symbol);
                db.AddInParameter(cmd, "@CurrencyName", DbType.String, mDCurrencyEntity.CurrencyName);
                db.AddInParameter(cmd, "@HundredthsName", DbType.String, mDCurrencyEntity.HundredthsName);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, mDCurrencyEntity.CountryID);
                db.AddInParameter(cmd, "@IsStandardCurrency", DbType.Boolean, mDCurrencyEntity.IsStandardCurrency);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDCurrencyEntity.IsRemoved);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> IMDCurrencyDataAccess.Update(IList<MDCurrencyEntity> mDCurrencyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDCurrencyEntity mDCurrencyEntity in mDCurrencyEntityList)
            {
                returnCode = (this as IMDCurrencyDataAccess).Update(mDCurrencyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDCurrencyDataAccess.Delete(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDCurrencyEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDCurrencyEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDCurrencyEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDCurrencyEntity already exists. Please specify another MDCurrencyEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDCurrencyEntity mDCurrencyEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDCurrency_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> IMDCurrencyDataAccess.Delete(IList<MDCurrencyEntity> mDCurrencyEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDCurrencyEntity mDCurrencyEntity in mDCurrencyEntityList)
            {
                returnCode = (this as IMDCurrencyDataAccess).Delete(mDCurrencyEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDCurrencyEntity> IMDCurrencyDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDCurrency_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDCurrencyEntity> list = CreateEntityBuilder<MDCurrencyEntity>().BuildEntities(reader);

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

        DataTable IMDCurrencyDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDCurrency_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

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
