// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    internal sealed partial class INVCurrentStockDataAccess : BaseDataAccess, IINVCurrentStockDataAccess
    {
        #region Constructors

        public INVCurrentStockDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVCurrentStockEntity> CreateEntityBuilder<INVCurrentStockEntity>()
        {
            return (new INVCurrentStockBuilder()) as IEntityBuilder<INVCurrentStockEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVCurrentStockDataAccess.Add(INVCurrentStockEntity iNVCurrentStockEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVCurrentStockEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVCurrentStockEntity, option);
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

        private Int64 Add(INVCurrentStockEntity iNVCurrentStockEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CurrentStockID");

                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVCurrentStockEntity.ItemID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVCurrentStockEntity.BrandID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVCurrentStockEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVCurrentStockEntity.CountryID);	
                Database.AddInParameter(cmd, "@UnitCurrentStock", DbType.Int64, iNVCurrentStockEntity.UnitCurrentStock);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVCurrentStockEntity iNVCurrentStockEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CurrentStockID", db);

                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVCurrentStockEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVCurrentStockEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVCurrentStockEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVCurrentStockEntity.CountryID);
                db.AddInParameter(cmd, "@UnitCurrentStock", DbType.Int64, iNVCurrentStockEntity.UnitCurrentStock);

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

        IList<Int64> IINVCurrentStockDataAccess.Add(IList<INVCurrentStockEntity> iNVCurrentStockEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVCurrentStockEntity iNVCurrentStockEntity in iNVCurrentStockEntityList)
            {
                returnCode = (this as IINVCurrentStockDataAccess).Add(iNVCurrentStockEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVCurrentStockDataAccess.Update(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVCurrentStockEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVCurrentStockEntity, filterExpression, option);
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

        private Int64 Update(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CurrentStockID", DbType.Int64, iNVCurrentStockEntity.CurrentStockID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVCurrentStockEntity.ItemID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVCurrentStockEntity.BrandID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVCurrentStockEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVCurrentStockEntity.CountryID);
                Database.AddInParameter(cmd, "@UnitCurrentStock", DbType.Int64, iNVCurrentStockEntity.UnitCurrentStock);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CurrentStockID", DbType.Int64, iNVCurrentStockEntity.CurrentStockID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVCurrentStockEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVCurrentStockEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVCurrentStockEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVCurrentStockEntity.CountryID);
                db.AddInParameter(cmd, "@UnitCurrentStock", DbType.Int64, iNVCurrentStockEntity.UnitCurrentStock);

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

        IList<Int64> IINVCurrentStockDataAccess.Update(IList<INVCurrentStockEntity> iNVCurrentStockEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVCurrentStockEntity iNVCurrentStockEntity in iNVCurrentStockEntityList)
            {
                returnCode = (this as IINVCurrentStockDataAccess).Update(iNVCurrentStockEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVCurrentStockDataAccess.Delete(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVCurrentStockEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVCurrentStockEntity, filterExpression, option);
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

        private Int64 Delete(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

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
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVCurrentStockEntity already exists. Please specify another INVCurrentStockEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVCurrentStockEntity iNVCurrentStockEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVCurrentStock_SET";

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

        IList<Int64> IINVCurrentStockDataAccess.Delete(IList<INVCurrentStockEntity> iNVCurrentStockEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVCurrentStockEntity iNVCurrentStockEntity in iNVCurrentStockEntityList)
            {
                returnCode = (this as IINVCurrentStockDataAccess).Delete(iNVCurrentStockEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVCurrentStockEntity> IINVCurrentStockDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVCurrentStock_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVCurrentStockEntity> list = CreateEntityBuilder<INVCurrentStockEntity>().BuildEntities(reader);

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

        DataTable IINVCurrentStockDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVCurrentStock_GET";

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
