// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    internal sealed partial class MDFloorUnitLocationCategoryDataAccess : BaseDataAccess, IMDFloorUnitLocationCategoryDataAccess
    {
        #region Constructors

        public MDFloorUnitLocationCategoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDFloorUnitLocationCategoryEntity> CreateEntityBuilder<MDFloorUnitLocationCategoryEntity>()
        {
            return (new MDFloorUnitLocationCategoryBuilder()) as IEntityBuilder<MDFloorUnitLocationCategoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDFloorUnitLocationCategoryDataAccess.Add(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDFloorUnitLocationCategoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDFloorUnitLocationCategoryEntity, option);
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

        private Int64 Add(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "FloorUnitLocationCategoryID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDFloorUnitLocationCategoryEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDFloorUnitLocationCategoryEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDFloorUnitLocationCategoryEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "FloorUnitLocationCategoryID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDFloorUnitLocationCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDFloorUnitLocationCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDFloorUnitLocationCategoryEntity.IsRemoved);

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

        IList<Int64> IMDFloorUnitLocationCategoryDataAccess.Add(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity in mDFloorUnitLocationCategoryEntityList)
            {
                returnCode = (this as IMDFloorUnitLocationCategoryDataAccess).Add(mDFloorUnitLocationCategoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDFloorUnitLocationCategoryDataAccess.Update(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDFloorUnitLocationCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDFloorUnitLocationCategoryEntity, filterExpression, option);
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

        private Int64 Update(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, mDFloorUnitLocationCategoryEntity.FloorUnitLocationCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDFloorUnitLocationCategoryEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDFloorUnitLocationCategoryEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDFloorUnitLocationCategoryEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, mDFloorUnitLocationCategoryEntity.FloorUnitLocationCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDFloorUnitLocationCategoryEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDFloorUnitLocationCategoryEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDFloorUnitLocationCategoryEntity.IsRemoved);

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

        IList<Int64> IMDFloorUnitLocationCategoryDataAccess.Update(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity in mDFloorUnitLocationCategoryEntityList)
            {
                returnCode = (this as IMDFloorUnitLocationCategoryDataAccess).Update(mDFloorUnitLocationCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDFloorUnitLocationCategoryDataAccess.Delete(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDFloorUnitLocationCategoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDFloorUnitLocationCategoryEntity, filterExpression, option);
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

        private Int64 Delete(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

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
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDFloorUnitLocationCategoryEntity already exists. Please specify another MDFloorUnitLocationCategoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDFloorUnitLocationCategory_SET";

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

        IList<Int64> IMDFloorUnitLocationCategoryDataAccess.Delete(IList<MDFloorUnitLocationCategoryEntity> mDFloorUnitLocationCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDFloorUnitLocationCategoryEntity mDFloorUnitLocationCategoryEntity in mDFloorUnitLocationCategoryEntityList)
            {
                returnCode = (this as IMDFloorUnitLocationCategoryDataAccess).Delete(mDFloorUnitLocationCategoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDFloorUnitLocationCategoryEntity> IMDFloorUnitLocationCategoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDFloorUnitLocationCategory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDFloorUnitLocationCategoryEntity> list = CreateEntityBuilder<MDFloorUnitLocationCategoryEntity>().BuildEntities(reader);

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

        DataTable IMDFloorUnitLocationCategoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDFloorUnitLocationCategory_GET";

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