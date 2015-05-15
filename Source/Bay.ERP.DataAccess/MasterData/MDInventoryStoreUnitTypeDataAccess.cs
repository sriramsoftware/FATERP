// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:18:05




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
    internal sealed partial class MDInventoryStoreUnitTypeDataAccess : BaseDataAccess, IMDInventoryStoreUnitTypeDataAccess
    {
        #region Constructors

        public MDInventoryStoreUnitTypeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDInventoryStoreUnitTypeEntity> CreateEntityBuilder<MDInventoryStoreUnitTypeEntity>()
        {
            return (new MDInventoryStoreUnitTypeBuilder()) as IEntityBuilder<MDInventoryStoreUnitTypeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDInventoryStoreUnitTypeDataAccess.Add(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDInventoryStoreUnitTypeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDInventoryStoreUnitTypeEntity, option);
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

        private Int64 Add(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "InventoryStoreUnitTypeID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDInventoryStoreUnitTypeEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDInventoryStoreUnitTypeEntity.Description);	
                Database.AddInParameter(cmd, "@IconPath", DbType.String, mDInventoryStoreUnitTypeEntity.IconPath);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDInventoryStoreUnitTypeEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "InventoryStoreUnitTypeID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDInventoryStoreUnitTypeEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDInventoryStoreUnitTypeEntity.Description);
                db.AddInParameter(cmd, "@IconPath", DbType.String, mDInventoryStoreUnitTypeEntity.IconPath);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDInventoryStoreUnitTypeEntity.IsRemoved);

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

        IList<Int64> IMDInventoryStoreUnitTypeDataAccess.Add(IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity in mDInventoryStoreUnitTypeEntityList)
            {
                returnCode = (this as IMDInventoryStoreUnitTypeDataAccess).Add(mDInventoryStoreUnitTypeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDInventoryStoreUnitTypeDataAccess.Update(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDInventoryStoreUnitTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDInventoryStoreUnitTypeEntity, filterExpression, option);
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

        private Int64 Update(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, mDInventoryStoreUnitTypeEntity.InventoryStoreUnitTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDInventoryStoreUnitTypeEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDInventoryStoreUnitTypeEntity.Description);
                Database.AddInParameter(cmd, "@IconPath", DbType.String, mDInventoryStoreUnitTypeEntity.IconPath);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDInventoryStoreUnitTypeEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@InventoryStoreUnitTypeID", DbType.Int64, mDInventoryStoreUnitTypeEntity.InventoryStoreUnitTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDInventoryStoreUnitTypeEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDInventoryStoreUnitTypeEntity.Description);
                db.AddInParameter(cmd, "@IconPath", DbType.String, mDInventoryStoreUnitTypeEntity.IconPath);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDInventoryStoreUnitTypeEntity.IsRemoved);

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

        IList<Int64> IMDInventoryStoreUnitTypeDataAccess.Update(IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity in mDInventoryStoreUnitTypeEntityList)
            {
                returnCode = (this as IMDInventoryStoreUnitTypeDataAccess).Update(mDInventoryStoreUnitTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDInventoryStoreUnitTypeDataAccess.Delete(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDInventoryStoreUnitTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDInventoryStoreUnitTypeEntity, filterExpression, option);
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

        private Int64 Delete(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

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
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDInventoryStoreUnitTypeEntity already exists. Please specify another MDInventoryStoreUnitTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDInventoryStoreUnitType_SET";

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

        IList<Int64> IMDInventoryStoreUnitTypeDataAccess.Delete(IList<MDInventoryStoreUnitTypeEntity> mDInventoryStoreUnitTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDInventoryStoreUnitTypeEntity mDInventoryStoreUnitTypeEntity in mDInventoryStoreUnitTypeEntityList)
            {
                returnCode = (this as IMDInventoryStoreUnitTypeDataAccess).Delete(mDInventoryStoreUnitTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDInventoryStoreUnitTypeEntity> IMDInventoryStoreUnitTypeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDInventoryStoreUnitType_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDInventoryStoreUnitTypeEntity> list = CreateEntityBuilder<MDInventoryStoreUnitTypeEntity>().BuildEntities(reader);

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

        DataTable IMDInventoryStoreUnitTypeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDInventoryStoreUnitType_GET";

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
