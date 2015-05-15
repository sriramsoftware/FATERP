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
    internal sealed partial class MDItemGroupItemCategoryMapDataAccess : BaseDataAccess, IMDItemGroupItemCategoryMapDataAccess
    {
        #region Constructors

        public MDItemGroupItemCategoryMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDItemGroupItemCategoryMapEntity> CreateEntityBuilder<MDItemGroupItemCategoryMapEntity>()
        {
            return (new MDItemGroupItemCategoryMapBuilder()) as IEntityBuilder<MDItemGroupItemCategoryMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDItemGroupItemCategoryMapDataAccess.Add(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDItemGroupItemCategoryMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDItemGroupItemCategoryMapEntity, option);
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

        private Int64 Add(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ItemGroupItemCategoryMapID");

                Database.AddInParameter(cmd, "@ItemGroupID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupID);	
                Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemCategoryID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ItemGroupItemCategoryMapID", db);

                db.AddInParameter(cmd, "@ItemGroupID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupID);
                db.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemCategoryID);

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

        IList<Int64> IMDItemGroupItemCategoryMapDataAccess.Add(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity in mDItemGroupItemCategoryMapEntityList)
            {
                returnCode = (this as IMDItemGroupItemCategoryMapDataAccess).Add(mDItemGroupItemCategoryMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDItemGroupItemCategoryMapDataAccess.Update(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDItemGroupItemCategoryMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDItemGroupItemCategoryMapEntity, filterExpression, option);
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

        private Int64 Update(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ItemGroupItemCategoryMapID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupItemCategoryMapID);
                Database.AddInParameter(cmd, "@ItemGroupID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupID);
                Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemCategoryID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ItemGroupItemCategoryMapID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupItemCategoryMapID);
                db.AddInParameter(cmd, "@ItemGroupID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemGroupID);
                db.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, mDItemGroupItemCategoryMapEntity.ItemCategoryID);

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

        IList<Int64> IMDItemGroupItemCategoryMapDataAccess.Update(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity in mDItemGroupItemCategoryMapEntityList)
            {
                returnCode = (this as IMDItemGroupItemCategoryMapDataAccess).Update(mDItemGroupItemCategoryMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDItemGroupItemCategoryMapDataAccess.Delete(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDItemGroupItemCategoryMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDItemGroupItemCategoryMapEntity, filterExpression, option);
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

        private Int64 Delete(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

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
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDItemGroupItemCategoryMapEntity already exists. Please specify another MDItemGroupItemCategoryMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDItemGroupItemCategoryMap_SET";

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

        IList<Int64> IMDItemGroupItemCategoryMapDataAccess.Delete(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity in mDItemGroupItemCategoryMapEntityList)
            {
                returnCode = (this as IMDItemGroupItemCategoryMapDataAccess).Delete(mDItemGroupItemCategoryMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDItemGroupItemCategoryMapEntity> IMDItemGroupItemCategoryMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDItemGroupItemCategoryMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDItemGroupItemCategoryMapEntity> list = CreateEntityBuilder<MDItemGroupItemCategoryMapEntity>().BuildEntities(reader);

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

        DataTable IMDItemGroupItemCategoryMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDItemGroupItemCategoryMap_GET";

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
