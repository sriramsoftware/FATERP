// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2013, 12:49:20




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
    internal sealed partial class ACCompanyInfoDataAccess : BaseDataAccess, IACCompanyInfoDataAccess
    {
        #region Constructors

        public ACCompanyInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCompanyInfoEntity> CreateEntityBuilder<ACCompanyInfoEntity>()
        {
            return (new ACCompanyInfoBuilder()) as IEntityBuilder<ACCompanyInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACCompanyInfoDataAccess.Add(ACCompanyInfoEntity aCCompanyInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCCompanyInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCCompanyInfoEntity, option);
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

        private Int64 Add(ACCompanyInfoEntity aCCompanyInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CompanyInfoID");

                Database.AddInParameter(cmd, "@CompanyName", DbType.String, aCCompanyInfoEntity.CompanyName);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, aCCompanyInfoEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, aCCompanyInfoEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@PhoneNumber", DbType.String, aCCompanyInfoEntity.PhoneNumber);	
                Database.AddInParameter(cmd, "@Email", DbType.String, aCCompanyInfoEntity.Email);	
                Database.AddInParameter(cmd, "@OfficialCompanyNumber", DbType.String, aCCompanyInfoEntity.OfficialCompanyNumber);	
                Database.AddInParameter(cmd, "@HomeCurrencyID", DbType.Int64, aCCompanyInfoEntity.HomeCurrencyID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCCompanyInfoEntity.FiscalYearID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACCompanyInfoEntity aCCompanyInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CompanyInfoID", db);

                db.AddInParameter(cmd, "@CompanyName", DbType.String, aCCompanyInfoEntity.CompanyName);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, aCCompanyInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, aCCompanyInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@PhoneNumber", DbType.String, aCCompanyInfoEntity.PhoneNumber);
                db.AddInParameter(cmd, "@Email", DbType.String, aCCompanyInfoEntity.Email);
                db.AddInParameter(cmd, "@OfficialCompanyNumber", DbType.String, aCCompanyInfoEntity.OfficialCompanyNumber);
                db.AddInParameter(cmd, "@HomeCurrencyID", DbType.Int64, aCCompanyInfoEntity.HomeCurrencyID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCCompanyInfoEntity.FiscalYearID);

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

        IList<Int64> IACCompanyInfoDataAccess.Add(IList<ACCompanyInfoEntity> aCCompanyInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACCompanyInfoEntity aCCompanyInfoEntity in aCCompanyInfoEntityList)
            {
                returnCode = (this as IACCompanyInfoDataAccess).Add(aCCompanyInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACCompanyInfoDataAccess.Update(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCCompanyInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCCompanyInfoEntity, filterExpression, option);
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

        private Int64 Update(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CompanyInfoID", DbType.Int64, aCCompanyInfoEntity.CompanyInfoID);
                Database.AddInParameter(cmd, "@CompanyName", DbType.String, aCCompanyInfoEntity.CompanyName);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, aCCompanyInfoEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, aCCompanyInfoEntity.AddressLine2);
                Database.AddInParameter(cmd, "@PhoneNumber", DbType.String, aCCompanyInfoEntity.PhoneNumber);
                Database.AddInParameter(cmd, "@Email", DbType.String, aCCompanyInfoEntity.Email);
                Database.AddInParameter(cmd, "@OfficialCompanyNumber", DbType.String, aCCompanyInfoEntity.OfficialCompanyNumber);
                Database.AddInParameter(cmd, "@HomeCurrencyID", DbType.Int64, aCCompanyInfoEntity.HomeCurrencyID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCCompanyInfoEntity.FiscalYearID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CompanyInfoID", DbType.Int64, aCCompanyInfoEntity.CompanyInfoID);
                db.AddInParameter(cmd, "@CompanyName", DbType.String, aCCompanyInfoEntity.CompanyName);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, aCCompanyInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, aCCompanyInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@PhoneNumber", DbType.String, aCCompanyInfoEntity.PhoneNumber);
                db.AddInParameter(cmd, "@Email", DbType.String, aCCompanyInfoEntity.Email);
                db.AddInParameter(cmd, "@OfficialCompanyNumber", DbType.String, aCCompanyInfoEntity.OfficialCompanyNumber);
                db.AddInParameter(cmd, "@HomeCurrencyID", DbType.Int64, aCCompanyInfoEntity.HomeCurrencyID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, aCCompanyInfoEntity.FiscalYearID);

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

        IList<Int64> IACCompanyInfoDataAccess.Update(IList<ACCompanyInfoEntity> aCCompanyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACCompanyInfoEntity aCCompanyInfoEntity in aCCompanyInfoEntityList)
            {
                returnCode = (this as IACCompanyInfoDataAccess).Update(aCCompanyInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACCompanyInfoDataAccess.Delete(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCCompanyInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCCompanyInfoEntity, filterExpression, option);
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

        private Int64 Delete(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

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
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACCompanyInfoEntity already exists. Please specify another ACCompanyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACCompanyInfoEntity aCCompanyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACCompanyInfo_SET";

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

        IList<Int64> IACCompanyInfoDataAccess.Delete(IList<ACCompanyInfoEntity> aCCompanyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACCompanyInfoEntity aCCompanyInfoEntity in aCCompanyInfoEntityList)
            {
                returnCode = (this as IACCompanyInfoDataAccess).Delete(aCCompanyInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACCompanyInfoEntity> IACCompanyInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCompanyInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCompanyInfoEntity> list = CreateEntityBuilder<ACCompanyInfoEntity>().BuildEntities(reader);

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

        DataTable IACCompanyInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACCompanyInfo_GET";

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
