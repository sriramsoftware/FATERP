// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    internal sealed partial class PRMSupplierItemMapHistoryDataAccess : BaseDataAccess, IPRMSupplierItemMapHistoryDataAccess
    {
        #region Constructors

        public PRMSupplierItemMapHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierItemMapHistoryEntity> CreateEntityBuilder<PRMSupplierItemMapHistoryEntity>()
        {
            return (new PRMSupplierItemMapHistoryBuilder()) as IEntityBuilder<PRMSupplierItemMapHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMSupplierItemMapHistoryDataAccess.Add(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMSupplierItemMapHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMSupplierItemMapHistoryEntity, option);
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

        private Int64 Add(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemMapHistoryID");

                Database.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapID);	
                Database.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapHistoryEntity.ActualPrice);	
                Database.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapHistoryEntity.DiscountPercentage);	
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapHistoryEntity.Price);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapHistoryEntity.EntryDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SupplierItemMapHistoryID", db);

                db.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapID);
                db.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapHistoryEntity.ActualPrice);
                db.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapHistoryEntity.DiscountPercentage);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapHistoryEntity.Price);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapHistoryEntity.EntryDate);

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

        IList<Int64> IPRMSupplierItemMapHistoryDataAccess.Add(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity in pRMSupplierItemMapHistoryEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapHistoryDataAccess).Add(pRMSupplierItemMapHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMSupplierItemMapHistoryDataAccess.Update(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMSupplierItemMapHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMSupplierItemMapHistoryEntity, filterExpression, option);
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

        private Int64 Update(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SupplierItemMapHistoryID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapHistoryID);
                Database.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapID);
                Database.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapHistoryEntity.ActualPrice);
                Database.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapHistoryEntity.DiscountPercentage);
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapHistoryEntity.Price);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapHistoryEntity.EntryDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SupplierItemMapHistoryID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapHistoryID);
                db.AddInParameter(cmd, "@SupplierItemMapID", DbType.Int64, pRMSupplierItemMapHistoryEntity.SupplierItemMapID);
                db.AddInParameter(cmd, "@ActualPrice", DbType.Decimal, pRMSupplierItemMapHistoryEntity.ActualPrice);
                db.AddInParameter(cmd, "@DiscountPercentage", DbType.Decimal, pRMSupplierItemMapHistoryEntity.DiscountPercentage);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, pRMSupplierItemMapHistoryEntity.Price);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMSupplierItemMapHistoryEntity.EntryDate);

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

        IList<Int64> IPRMSupplierItemMapHistoryDataAccess.Update(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity in pRMSupplierItemMapHistoryEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapHistoryDataAccess).Update(pRMSupplierItemMapHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMSupplierItemMapHistoryDataAccess.Delete(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMSupplierItemMapHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMSupplierItemMapHistoryEntity, filterExpression, option);
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

        private Int64 Delete(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

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
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierItemMapHistoryEntity already exists. Please specify another PRMSupplierItemMapHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierItemMapHistory_SET";

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

        IList<Int64> IPRMSupplierItemMapHistoryDataAccess.Delete(IList<PRMSupplierItemMapHistoryEntity> pRMSupplierItemMapHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity in pRMSupplierItemMapHistoryEntityList)
            {
                returnCode = (this as IPRMSupplierItemMapHistoryDataAccess).Delete(pRMSupplierItemMapHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMSupplierItemMapHistoryEntity> IPRMSupplierItemMapHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMapHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierItemMapHistoryEntity> list = CreateEntityBuilder<PRMSupplierItemMapHistoryEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierItemMapHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMapHistory_GET";

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
