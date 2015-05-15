// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




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
    internal sealed partial class INVTransactionDataAccess : BaseDataAccess, IINVTransactionDataAccess
    {
        #region Constructors

        public INVTransactionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVTransactionEntity> CreateEntityBuilder<INVTransactionEntity>()
        {
            return (new INVTransactionBuilder()) as IEntityBuilder<INVTransactionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVTransactionDataAccess.Add(INVTransactionEntity iNVTransactionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVTransactionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVTransactionEntity, option);
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

        private Int64 Add(INVTransactionEntity iNVTransactionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TransactionID");

                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransactionEntity.ItemID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransactionEntity.BrandID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransactionEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransactionEntity.CountryID);	
                Database.AddInParameter(cmd, "@BatchNumber", DbType.String, iNVTransactionEntity.BatchNumber);	
                Database.AddInParameter(cmd, "@TransactionQty", DbType.Int64, iNVTransactionEntity.TransactionQty);	
                Database.AddInParameter(cmd, "@TransactionDate", DbType.DateTime, iNVTransactionEntity.TransactionDate);	
                Database.AddInParameter(cmd, "@TransactionDirection", DbType.Boolean, iNVTransactionEntity.TransactionDirection);	
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, iNVTransactionEntity.IPAddress);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, iNVTransactionEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@UnitPrice", DbType.Decimal, iNVTransactionEntity.UnitPrice);	
                Database.AddInParameter(cmd, "@RequisitionNumber", DbType.String, iNVTransactionEntity.RequisitionNumber);	
                Database.AddInParameter(cmd, "@WordOrderNumber", DbType.String, iNVTransactionEntity.WordOrderNumber);	
                Database.AddInParameter(cmd, "@MRRNumber", DbType.String, iNVTransactionEntity.MRRNumber);	
                Database.AddInParameter(cmd, "@BillNumber", DbType.String, iNVTransactionEntity.BillNumber);	
                Database.AddInParameter(cmd, "@IsTransfer", DbType.Boolean, iNVTransactionEntity.IsTransfer);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVTransactionEntity.ProjectID);	
                Database.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVTransactionEntity.StoreID);	
                Database.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVTransactionEntity.StoreUnitID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransactionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVTransactionEntity iNVTransactionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TransactionID", db);

                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransactionEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransactionEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransactionEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransactionEntity.CountryID);
                db.AddInParameter(cmd, "@BatchNumber", DbType.String, iNVTransactionEntity.BatchNumber);
                db.AddInParameter(cmd, "@TransactionQty", DbType.Int64, iNVTransactionEntity.TransactionQty);
                db.AddInParameter(cmd, "@TransactionDate", DbType.DateTime, iNVTransactionEntity.TransactionDate);
                db.AddInParameter(cmd, "@TransactionDirection", DbType.Boolean, iNVTransactionEntity.TransactionDirection);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, iNVTransactionEntity.IPAddress);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, iNVTransactionEntity.EmployeeID);
                db.AddInParameter(cmd, "@UnitPrice", DbType.Decimal, iNVTransactionEntity.UnitPrice);
                db.AddInParameter(cmd, "@RequisitionNumber", DbType.String, iNVTransactionEntity.RequisitionNumber);
                db.AddInParameter(cmd, "@WordOrderNumber", DbType.String, iNVTransactionEntity.WordOrderNumber);
                db.AddInParameter(cmd, "@MRRNumber", DbType.String, iNVTransactionEntity.MRRNumber);
                db.AddInParameter(cmd, "@BillNumber", DbType.String, iNVTransactionEntity.BillNumber);
                db.AddInParameter(cmd, "@IsTransfer", DbType.Boolean, iNVTransactionEntity.IsTransfer);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVTransactionEntity.ProjectID);
                db.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVTransactionEntity.StoreID);
                db.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVTransactionEntity.StoreUnitID);

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

        IList<Int64> IINVTransactionDataAccess.Add(IList<INVTransactionEntity> iNVTransactionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVTransactionEntity iNVTransactionEntity in iNVTransactionEntityList)
            {
                returnCode = (this as IINVTransactionDataAccess).Add(iNVTransactionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVTransactionDataAccess.Update(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVTransactionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVTransactionEntity, filterExpression, option);
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

        private Int64 Update(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TransactionID", DbType.Int64, iNVTransactionEntity.TransactionID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransactionEntity.ItemID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransactionEntity.BrandID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransactionEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransactionEntity.CountryID);
                Database.AddInParameter(cmd, "@BatchNumber", DbType.String, iNVTransactionEntity.BatchNumber);
                Database.AddInParameter(cmd, "@TransactionQty", DbType.Int64, iNVTransactionEntity.TransactionQty);
                Database.AddInParameter(cmd, "@TransactionDate", DbType.DateTime, iNVTransactionEntity.TransactionDate);
                Database.AddInParameter(cmd, "@TransactionDirection", DbType.Boolean, iNVTransactionEntity.TransactionDirection);
                Database.AddInParameter(cmd, "@IPAddress", DbType.String, iNVTransactionEntity.IPAddress);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, iNVTransactionEntity.EmployeeID);
                Database.AddInParameter(cmd, "@UnitPrice", DbType.Decimal, iNVTransactionEntity.UnitPrice);
                Database.AddInParameter(cmd, "@RequisitionNumber", DbType.String, iNVTransactionEntity.RequisitionNumber);
                Database.AddInParameter(cmd, "@WordOrderNumber", DbType.String, iNVTransactionEntity.WordOrderNumber);
                Database.AddInParameter(cmd, "@MRRNumber", DbType.String, iNVTransactionEntity.MRRNumber);
                Database.AddInParameter(cmd, "@BillNumber", DbType.String, iNVTransactionEntity.BillNumber);
                Database.AddInParameter(cmd, "@IsTransfer", DbType.Boolean, iNVTransactionEntity.IsTransfer);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVTransactionEntity.ProjectID);
                Database.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVTransactionEntity.StoreID);
                Database.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVTransactionEntity.StoreUnitID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransactionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TransactionID", DbType.Int64, iNVTransactionEntity.TransactionID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransactionEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransactionEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransactionEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransactionEntity.CountryID);
                db.AddInParameter(cmd, "@BatchNumber", DbType.String, iNVTransactionEntity.BatchNumber);
                db.AddInParameter(cmd, "@TransactionQty", DbType.Int64, iNVTransactionEntity.TransactionQty);
                db.AddInParameter(cmd, "@TransactionDate", DbType.DateTime, iNVTransactionEntity.TransactionDate);
                db.AddInParameter(cmd, "@TransactionDirection", DbType.Boolean, iNVTransactionEntity.TransactionDirection);
                db.AddInParameter(cmd, "@IPAddress", DbType.String, iNVTransactionEntity.IPAddress);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, iNVTransactionEntity.EmployeeID);
                db.AddInParameter(cmd, "@UnitPrice", DbType.Decimal, iNVTransactionEntity.UnitPrice);
                db.AddInParameter(cmd, "@RequisitionNumber", DbType.String, iNVTransactionEntity.RequisitionNumber);
                db.AddInParameter(cmd, "@WordOrderNumber", DbType.String, iNVTransactionEntity.WordOrderNumber);
                db.AddInParameter(cmd, "@MRRNumber", DbType.String, iNVTransactionEntity.MRRNumber);
                db.AddInParameter(cmd, "@BillNumber", DbType.String, iNVTransactionEntity.BillNumber);
                db.AddInParameter(cmd, "@IsTransfer", DbType.Boolean, iNVTransactionEntity.IsTransfer);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, iNVTransactionEntity.ProjectID);
                db.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVTransactionEntity.StoreID);
                db.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVTransactionEntity.StoreUnitID);

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

        IList<Int64> IINVTransactionDataAccess.Update(IList<INVTransactionEntity> iNVTransactionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVTransactionEntity iNVTransactionEntity in iNVTransactionEntityList)
            {
                returnCode = (this as IINVTransactionDataAccess).Update(iNVTransactionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVTransactionDataAccess.Delete(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVTransactionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVTransactionEntity, filterExpression, option);
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

        private Int64 Delete(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

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
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransactionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransactionEntity already exists. Please specify another INVTransactionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVTransactionEntity iNVTransactionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransaction_SET";

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

        IList<Int64> IINVTransactionDataAccess.Delete(IList<INVTransactionEntity> iNVTransactionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVTransactionEntity iNVTransactionEntity in iNVTransactionEntityList)
            {
                returnCode = (this as IINVTransactionDataAccess).Delete(iNVTransactionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVTransactionEntity> IINVTransactionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransaction_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVTransactionEntity> list = CreateEntityBuilder<INVTransactionEntity>().BuildEntities(reader);

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

        DataTable IINVTransactionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransaction_GET";

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
