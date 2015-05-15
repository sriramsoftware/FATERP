// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2013, 03:06:02




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
    internal sealed partial class INVStoreIssueNoteItemMapDataAccess : BaseDataAccess, IINVStoreIssueNoteItemMapDataAccess
    {
        #region Constructors

        public INVStoreIssueNoteItemMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVStoreIssueNoteItemMapEntity> CreateEntityBuilder<INVStoreIssueNoteItemMapEntity>()
        {
            return (new INVStoreIssueNoteItemMapBuilder()) as IEntityBuilder<INVStoreIssueNoteItemMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVStoreIssueNoteItemMapDataAccess.Add(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVStoreIssueNoteItemMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVStoreIssueNoteItemMapEntity, option);
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

        private Int64 Add(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteItemMapID");

                Database.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ItemID);	
                Database.AddInParameter(cmd, "@FolioNo", DbType.String, iNVStoreIssueNoteItemMapEntity.FolioNo);	
                Database.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.RequestQty);	
                Database.AddInParameter(cmd, "@BatchNo", DbType.String, iNVStoreIssueNoteItemMapEntity.BatchNo);	
                Database.AddInParameter(cmd, "@IssueQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.IssueQty);	
                Database.AddInParameter(cmd, "@IssuedFromStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID);	
                Database.AddInParameter(cmd, "@IssuedFromStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID);	
                Database.AddInParameter(cmd, "@ReceivedDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReceivedDate);	
                Database.AddInParameter(cmd, "@ReceivedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID);	
                Database.AddInParameter(cmd, "@ReturnQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ReturnQty);	
                Database.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReturnDate);	
                Database.AddInParameter(cmd, "@ReturnToStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreID);	
                Database.AddInParameter(cmd, "@ReturnToStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID);	
                Database.AddInParameter(cmd, "@ReturnedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID);	
                Database.AddInParameter(cmd, "@ActualUse", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ActualUse);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.Amount);	
                Database.AddInParameter(cmd, "@PurposeOfWorks", DbType.String, iNVStoreIssueNoteItemMapEntity.PurposeOfWorks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "StoreIssueNoteItemMapID", db);

                db.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@FolioNo", DbType.String, iNVStoreIssueNoteItemMapEntity.FolioNo);
                db.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.RequestQty);
                db.AddInParameter(cmd, "@BatchNo", DbType.String, iNVStoreIssueNoteItemMapEntity.BatchNo);
                db.AddInParameter(cmd, "@IssueQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.IssueQty);
                db.AddInParameter(cmd, "@IssuedFromStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID);
                db.AddInParameter(cmd, "@IssuedFromStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID);
                db.AddInParameter(cmd, "@ReceivedDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReceivedDate);
                db.AddInParameter(cmd, "@ReceivedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID);
                db.AddInParameter(cmd, "@ReturnQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ReturnQty);
                db.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReturnDate);
                db.AddInParameter(cmd, "@ReturnToStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreID);
                db.AddInParameter(cmd, "@ReturnToStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID);
                db.AddInParameter(cmd, "@ReturnedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID);
                db.AddInParameter(cmd, "@ActualUse", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ActualUse);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.Amount);
                db.AddInParameter(cmd, "@PurposeOfWorks", DbType.String, iNVStoreIssueNoteItemMapEntity.PurposeOfWorks);

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

        IList<Int64> IINVStoreIssueNoteItemMapDataAccess.Add(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity in iNVStoreIssueNoteItemMapEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteItemMapDataAccess).Add(iNVStoreIssueNoteItemMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVStoreIssueNoteItemMapDataAccess.Update(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVStoreIssueNoteItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVStoreIssueNoteItemMapEntity, filterExpression, option);
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

        private Int64 Update(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@StoreIssueNoteItemMapID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID);
                Database.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ItemID);
                Database.AddInParameter(cmd, "@FolioNo", DbType.String, iNVStoreIssueNoteItemMapEntity.FolioNo);
                Database.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.RequestQty);
                Database.AddInParameter(cmd, "@BatchNo", DbType.String, iNVStoreIssueNoteItemMapEntity.BatchNo);
                Database.AddInParameter(cmd, "@IssueQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.IssueQty);
                Database.AddInParameter(cmd, "@IssuedFromStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID);
                Database.AddInParameter(cmd, "@IssuedFromStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID);
                Database.AddInParameter(cmd, "@ReceivedDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReceivedDate);
                Database.AddInParameter(cmd, "@ReceivedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID);
                Database.AddInParameter(cmd, "@ReturnQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ReturnQty);
                Database.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReturnDate);
                Database.AddInParameter(cmd, "@ReturnToStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreID);
                Database.AddInParameter(cmd, "@ReturnToStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID);
                Database.AddInParameter(cmd, "@ReturnedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID);
                Database.AddInParameter(cmd, "@ActualUse", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ActualUse);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.Amount);
                Database.AddInParameter(cmd, "@PurposeOfWorks", DbType.String, iNVStoreIssueNoteItemMapEntity.PurposeOfWorks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@StoreIssueNoteItemMapID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID);
                db.AddInParameter(cmd, "@StoreIssueNoteID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ItemID);
                db.AddInParameter(cmd, "@FolioNo", DbType.String, iNVStoreIssueNoteItemMapEntity.FolioNo);
                db.AddInParameter(cmd, "@RequestQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.RequestQty);
                db.AddInParameter(cmd, "@BatchNo", DbType.String, iNVStoreIssueNoteItemMapEntity.BatchNo);
                db.AddInParameter(cmd, "@IssueQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.IssueQty);
                db.AddInParameter(cmd, "@IssuedFromStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID);
                db.AddInParameter(cmd, "@IssuedFromStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID);
                db.AddInParameter(cmd, "@ReceivedDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReceivedDate);
                db.AddInParameter(cmd, "@ReceivedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID);
                db.AddInParameter(cmd, "@ReturnQty", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ReturnQty);
                db.AddInParameter(cmd, "@ReturnDate", DbType.DateTime, iNVStoreIssueNoteItemMapEntity.ReturnDate);
                db.AddInParameter(cmd, "@ReturnToStoreID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreID);
                db.AddInParameter(cmd, "@ReturnToStoreUnitID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID);
                db.AddInParameter(cmd, "@ReturnedByEmployeeID", DbType.Int64, iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID);
                db.AddInParameter(cmd, "@ActualUse", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.ActualUse);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, iNVStoreIssueNoteItemMapEntity.Amount);
                db.AddInParameter(cmd, "@PurposeOfWorks", DbType.String, iNVStoreIssueNoteItemMapEntity.PurposeOfWorks);

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

        IList<Int64> IINVStoreIssueNoteItemMapDataAccess.Update(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity in iNVStoreIssueNoteItemMapEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteItemMapDataAccess).Update(iNVStoreIssueNoteItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVStoreIssueNoteItemMapDataAccess.Delete(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVStoreIssueNoteItemMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVStoreIssueNoteItemMapEntity, filterExpression, option);
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

        private Int64 Delete(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

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
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreIssueNoteItemMapEntity already exists. Please specify another INVStoreIssueNoteItemMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreIssueNoteItemMap_SET";

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

        IList<Int64> IINVStoreIssueNoteItemMapDataAccess.Delete(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity in iNVStoreIssueNoteItemMapEntityList)
            {
                returnCode = (this as IINVStoreIssueNoteItemMapDataAccess).Delete(iNVStoreIssueNoteItemMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVStoreIssueNoteItemMapEntity> IINVStoreIssueNoteItemMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreIssueNoteItemMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVStoreIssueNoteItemMapEntity> list = CreateEntityBuilder<INVStoreIssueNoteItemMapEntity>().BuildEntities(reader);

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

        DataTable IINVStoreIssueNoteItemMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreIssueNoteItemMap_GET";

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
