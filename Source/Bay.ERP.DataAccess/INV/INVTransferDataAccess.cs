// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jun-2013, 01:46:16




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
    internal sealed partial class INVTransferDataAccess : BaseDataAccess, IINVTransferDataAccess
    {
        #region Constructors

        public INVTransferDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVTransferEntity> CreateEntityBuilder<INVTransferEntity>()
        {
            return (new INVTransferBuilder()) as IEntityBuilder<INVTransferEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVTransferDataAccess.Add(INVTransferEntity iNVTransferEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVTransferEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVTransferEntity, option);
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

        private Int64 Add(INVTransferEntity iNVTransferEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TransferID");

                Database.AddInParameter(cmd, "@TRFNo", DbType.String, iNVTransferEntity.TRFNo);	
                Database.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVTransferEntity.RequestedByEmployeeID);	
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVTransferEntity.RequestDate);	
                Database.AddInParameter(cmd, "@TransferFromStoreID", DbType.Int64, iNVTransferEntity.TransferFromStoreID);	
                Database.AddInParameter(cmd, "@TransferFromStoreUnitID", DbType.Int64, iNVTransferEntity.TransferFromStoreUnitID);	
                Database.AddInParameter(cmd, "@TransferToStoreID", DbType.Int64, iNVTransferEntity.TransferToStoreID);	
                Database.AddInParameter(cmd, "@TransferToStoreUnitID", DbType.Int64, iNVTransferEntity.TransferToStoreUnitID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, iNVTransferEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferEntity.Remarks);	
                Database.AddInParameter(cmd, "@InventoryTransferStatusID", DbType.Int64, iNVTransferEntity.InventoryTransferStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVTransferEntity iNVTransferEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TransferID", db);

                db.AddInParameter(cmd, "@TRFNo", DbType.String, iNVTransferEntity.TRFNo);
                db.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVTransferEntity.RequestedByEmployeeID);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVTransferEntity.RequestDate);
                db.AddInParameter(cmd, "@TransferFromStoreID", DbType.Int64, iNVTransferEntity.TransferFromStoreID);
                db.AddInParameter(cmd, "@TransferFromStoreUnitID", DbType.Int64, iNVTransferEntity.TransferFromStoreUnitID);
                db.AddInParameter(cmd, "@TransferToStoreID", DbType.Int64, iNVTransferEntity.TransferToStoreID);
                db.AddInParameter(cmd, "@TransferToStoreUnitID", DbType.Int64, iNVTransferEntity.TransferToStoreUnitID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, iNVTransferEntity.RequisitionID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferEntity.Remarks);
                db.AddInParameter(cmd, "@InventoryTransferStatusID", DbType.Int64, iNVTransferEntity.InventoryTransferStatusID);

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

        IList<Int64> IINVTransferDataAccess.Add(IList<INVTransferEntity> iNVTransferEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVTransferEntity iNVTransferEntity in iNVTransferEntityList)
            {
                returnCode = (this as IINVTransferDataAccess).Add(iNVTransferEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVTransferDataAccess.Update(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVTransferEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVTransferEntity, filterExpression, option);
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

        private Int64 Update(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferEntity.TransferID);
                Database.AddInParameter(cmd, "@TRFNo", DbType.String, iNVTransferEntity.TRFNo);
                Database.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVTransferEntity.RequestedByEmployeeID);
                Database.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVTransferEntity.RequestDate);
                Database.AddInParameter(cmd, "@TransferFromStoreID", DbType.Int64, iNVTransferEntity.TransferFromStoreID);
                Database.AddInParameter(cmd, "@TransferFromStoreUnitID", DbType.Int64, iNVTransferEntity.TransferFromStoreUnitID);
                Database.AddInParameter(cmd, "@TransferToStoreID", DbType.Int64, iNVTransferEntity.TransferToStoreID);
                Database.AddInParameter(cmd, "@TransferToStoreUnitID", DbType.Int64, iNVTransferEntity.TransferToStoreUnitID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, iNVTransferEntity.RequisitionID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferEntity.Remarks);
                Database.AddInParameter(cmd, "@InventoryTransferStatusID", DbType.Int64, iNVTransferEntity.InventoryTransferStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TransferID", DbType.Int64, iNVTransferEntity.TransferID);
                db.AddInParameter(cmd, "@TRFNo", DbType.String, iNVTransferEntity.TRFNo);
                db.AddInParameter(cmd, "@RequestedByEmployeeID", DbType.Int64, iNVTransferEntity.RequestedByEmployeeID);
                db.AddInParameter(cmd, "@RequestDate", DbType.DateTime, iNVTransferEntity.RequestDate);
                db.AddInParameter(cmd, "@TransferFromStoreID", DbType.Int64, iNVTransferEntity.TransferFromStoreID);
                db.AddInParameter(cmd, "@TransferFromStoreUnitID", DbType.Int64, iNVTransferEntity.TransferFromStoreUnitID);
                db.AddInParameter(cmd, "@TransferToStoreID", DbType.Int64, iNVTransferEntity.TransferToStoreID);
                db.AddInParameter(cmd, "@TransferToStoreUnitID", DbType.Int64, iNVTransferEntity.TransferToStoreUnitID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, iNVTransferEntity.RequisitionID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, iNVTransferEntity.Remarks);
                db.AddInParameter(cmd, "@InventoryTransferStatusID", DbType.Int64, iNVTransferEntity.InventoryTransferStatusID);

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

        IList<Int64> IINVTransferDataAccess.Update(IList<INVTransferEntity> iNVTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVTransferEntity iNVTransferEntity in iNVTransferEntityList)
            {
                returnCode = (this as IINVTransferDataAccess).Update(iNVTransferEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVTransferDataAccess.Delete(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVTransferEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVTransferEntity, filterExpression, option);
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

        private Int64 Delete(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

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
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVTransferEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVTransferEntity already exists. Please specify another INVTransferEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVTransferEntity iNVTransferEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVTransfer_SET";

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

        IList<Int64> IINVTransferDataAccess.Delete(IList<INVTransferEntity> iNVTransferEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVTransferEntity iNVTransferEntity in iNVTransferEntityList)
            {
                returnCode = (this as IINVTransferDataAccess).Delete(iNVTransferEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVTransferEntity> IINVTransferDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransfer_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVTransferEntity> list = CreateEntityBuilder<INVTransferEntity>().BuildEntities(reader);

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

        DataTable IINVTransferDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVTransfer_GET";

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
