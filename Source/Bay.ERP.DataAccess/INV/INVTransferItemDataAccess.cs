// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 02:56:29




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
    internal sealed partial class INVTransferItemDataAccess : BaseDataAccess, IINVTransferItemDataAccess
    {
        #region Constructors

        public INVTransferItemDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVTransferItemEntity> CreateEntityBuilder<INVTransferItemEntity>()
        {
            return (new INVTransferItemBuilder()) as IEntityBuilder<INVTransferItemEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVTransferItemDataAccess.Add(INVTransferItemEntity iNVTransferItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVTransferItemEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVTransferItemEntity, option);
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

        private Int64 Add(INVTransferItemEntity iNVTransferItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TransferItemID");

                Database.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferItemEntity.TransferID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransferItemEntity.ItemID);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransferItemEntity.BrandID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransferItemEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransferItemEntity.CountryID);	
                Database.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVTransferItemEntity.RequestQty);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferItemEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVTransferItemEntity iNVTransferItemEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TransferItemID", db);

                db.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferItemEntity.TransferID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransferItemEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransferItemEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransferItemEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransferItemEntity.CountryID);
                db.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVTransferItemEntity.RequestQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferItemEntity.Remarks);

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

        IList<Int64> IINVTransferItemDataAccess.Add(IList<INVTransferItemEntity> iNVTransferItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVTransferItemEntity iNVTransferItemEntity in iNVTransferItemEntityList)
            {
                returnCode = (this as IINVTransferItemDataAccess).Add(iNVTransferItemEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVTransferItemDataAccess.Update(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVTransferItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVTransferItemEntity, filterExpression, option);
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

        private Int64 Update(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TransferItemID", DbType.Int64, iNVTransferItemEntity.TransferItemID);
                Database.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferItemEntity.TransferID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransferItemEntity.ItemID);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransferItemEntity.BrandID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransferItemEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransferItemEntity.CountryID);
                Database.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVTransferItemEntity.RequestQty);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferItemEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TransferItemID", DbType.Int64, iNVTransferItemEntity.TransferItemID);
                db.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferItemEntity.TransferID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVTransferItemEntity.ItemID);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, iNVTransferItemEntity.BrandID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, iNVTransferItemEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, iNVTransferItemEntity.CountryID);
                db.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVTransferItemEntity.RequestQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferItemEntity.Remarks);

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

        IList<Int64> IINVTransferItemDataAccess.Update(IList<INVTransferItemEntity> iNVTransferItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVTransferItemEntity iNVTransferItemEntity in iNVTransferItemEntityList)
            {
                returnCode = (this as IINVTransferItemDataAccess).Update(iNVTransferItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVTransferItemDataAccess.Delete(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVTransferItemEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVTransferItemEntity, filterExpression, option);
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

        private Int64 Delete(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

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
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferItemEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferItemEntity already exists. Please specify another INVTransferItemEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVTransferItemEntity iNVTransferItemEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransferItem_SET";

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

        IList<Int64> IINVTransferItemDataAccess.Delete(IList<INVTransferItemEntity> iNVTransferItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVTransferItemEntity iNVTransferItemEntity in iNVTransferItemEntityList)
            {
                returnCode = (this as IINVTransferItemDataAccess).Delete(iNVTransferItemEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVTransferItemEntity> IINVTransferItemDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransferItem_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVTransferItemEntity> list = CreateEntityBuilder<INVTransferItemEntity>().BuildEntities(reader);

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

        DataTable IINVTransferItemDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransferItem_GET";

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
