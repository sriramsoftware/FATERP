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
    internal sealed partial class INVStoreUnitDataAccess : BaseDataAccess, IINVStoreUnitDataAccess
    {
        #region Constructors

        public INVStoreUnitDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INVStoreUnitEntity> CreateEntityBuilder<INVStoreUnitEntity>()
        {
            return (new INVStoreUnitBuilder()) as IEntityBuilder<INVStoreUnitEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IINVStoreUnitDataAccess.Add(INVStoreUnitEntity iNVStoreUnitEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(iNVStoreUnitEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(iNVStoreUnitEntity, option);
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

        private Int64 Add(INVStoreUnitEntity iNVStoreUnitEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "StoreUnitID");

                Database.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreUnitEntity.StoreID);	
                Database.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, iNVStoreUnitEntity.InventoryStoreUnitTypeID);	
                Database.AddInParameter(cmd, "@UnitTrackNumber", DbType.String, iNVStoreUnitEntity.UnitTrackNumber);	
                Database.AddInParameter(cmd, "@Location", DbType.String, iNVStoreUnitEntity.Location);	
                Database.AddInParameter(cmd, "@Description", DbType.String, iNVStoreUnitEntity.Description);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreUnitEntity.CreateDate);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreUnitEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@ParentStoreUnitID", DbType.Int64, iNVStoreUnitEntity.ParentStoreUnitID);	
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreUnitEntity.IsDefault);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(INVStoreUnitEntity iNVStoreUnitEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "StoreUnitID", db);

                db.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreUnitEntity.StoreID);
                db.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, iNVStoreUnitEntity.InventoryStoreUnitTypeID);
                db.AddInParameter(cmd, "@UnitTrackNumber", DbType.String, iNVStoreUnitEntity.UnitTrackNumber);
                db.AddInParameter(cmd, "@Location", DbType.String, iNVStoreUnitEntity.Location);
                db.AddInParameter(cmd, "@Description", DbType.String, iNVStoreUnitEntity.Description);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreUnitEntity.CreateDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreUnitEntity.IsRemoved);
                db.AddInParameter(cmd, "@ParentStoreUnitID", DbType.Int64, iNVStoreUnitEntity.ParentStoreUnitID);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreUnitEntity.IsDefault);

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

        IList<Int64> IINVStoreUnitDataAccess.Add(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (INVStoreUnitEntity iNVStoreUnitEntity in iNVStoreUnitEntityList)
            {
                returnCode = (this as IINVStoreUnitDataAccess).Add(iNVStoreUnitEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IINVStoreUnitDataAccess.Update(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(iNVStoreUnitEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(iNVStoreUnitEntity, filterExpression, option);
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

        private Int64 Update(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVStoreUnitEntity.StoreUnitID);
                Database.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreUnitEntity.StoreID);
                Database.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, iNVStoreUnitEntity.InventoryStoreUnitTypeID);
                Database.AddInParameter(cmd, "@UnitTrackNumber", DbType.String, iNVStoreUnitEntity.UnitTrackNumber);
                Database.AddInParameter(cmd, "@Location", DbType.String, iNVStoreUnitEntity.Location);
                Database.AddInParameter(cmd, "@Description", DbType.String, iNVStoreUnitEntity.Description);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreUnitEntity.CreateDate);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreUnitEntity.IsRemoved);
                Database.AddInParameter(cmd, "@ParentStoreUnitID", DbType.Int64, iNVStoreUnitEntity.ParentStoreUnitID);
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreUnitEntity.IsDefault);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, iNVStoreUnitEntity.StoreUnitID);
                db.AddInParameter(cmd, "@StoreID", DbType.Int64, iNVStoreUnitEntity.StoreID);
                db.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, iNVStoreUnitEntity.InventoryStoreUnitTypeID);
                db.AddInParameter(cmd, "@UnitTrackNumber", DbType.String, iNVStoreUnitEntity.UnitTrackNumber);
                db.AddInParameter(cmd, "@Location", DbType.String, iNVStoreUnitEntity.Location);
                db.AddInParameter(cmd, "@Description", DbType.String, iNVStoreUnitEntity.Description);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, iNVStoreUnitEntity.CreateDate);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, iNVStoreUnitEntity.IsRemoved);
                db.AddInParameter(cmd, "@ParentStoreUnitID", DbType.Int64, iNVStoreUnitEntity.ParentStoreUnitID);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, iNVStoreUnitEntity.IsDefault);

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

        IList<Int64> IINVStoreUnitDataAccess.Update(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (INVStoreUnitEntity iNVStoreUnitEntity in iNVStoreUnitEntityList)
            {
                returnCode = (this as IINVStoreUnitDataAccess).Update(iNVStoreUnitEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IINVStoreUnitDataAccess.Delete(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(iNVStoreUnitEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(iNVStoreUnitEntity, filterExpression, option);
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

        private Int64 Delete(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

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
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("INVStoreUnitEntity already exists. Please specify another INVStoreUnitEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(INVStoreUnitEntity iNVStoreUnitEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.INVStoreUnit_SET";

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

        IList<Int64> IINVStoreUnitDataAccess.Delete(IList<INVStoreUnitEntity> iNVStoreUnitEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (INVStoreUnitEntity iNVStoreUnitEntity in iNVStoreUnitEntityList)
            {
                returnCode = (this as IINVStoreUnitDataAccess).Delete(iNVStoreUnitEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<INVStoreUnitEntity> IINVStoreUnitDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreUnit_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INVStoreUnitEntity> list = CreateEntityBuilder<INVStoreUnitEntity>().BuildEntities(reader);

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

        DataTable IINVStoreUnitDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.INVStoreUnit_GET";

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
