// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




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
    internal sealed partial class MDOperatorAddressTypeDataAccess : BaseDataAccess, IMDOperatorAddressTypeDataAccess
    {
        #region Constructors

        public MDOperatorAddressTypeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDOperatorAddressTypeEntity> CreateEntityBuilder<MDOperatorAddressTypeEntity>()
        {
            return (new MDOperatorAddressTypeBuilder()) as IEntityBuilder<MDOperatorAddressTypeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDOperatorAddressTypeDataAccess.Add(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDOperatorAddressTypeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDOperatorAddressTypeEntity, option);
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

        private Int64 Add(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);

                Database.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, mDOperatorAddressTypeEntity.OperatorAddressTypeID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDOperatorAddressTypeEntity.Name);	
                Database.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorAddressTypeEntity.Descripton);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorAddressTypeEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);

                db.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, mDOperatorAddressTypeEntity.OperatorAddressTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDOperatorAddressTypeEntity.Name);
                db.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorAddressTypeEntity.Descripton);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorAddressTypeEntity.IsRemoved);

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

        IList<Int64> IMDOperatorAddressTypeDataAccess.Add(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity in mDOperatorAddressTypeEntityList)
            {
                returnCode = (this as IMDOperatorAddressTypeDataAccess).Add(mDOperatorAddressTypeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDOperatorAddressTypeDataAccess.Update(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDOperatorAddressTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDOperatorAddressTypeEntity, filterExpression, option);
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

        private Int64 Update(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, mDOperatorAddressTypeEntity.OperatorAddressTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDOperatorAddressTypeEntity.Name);
                Database.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorAddressTypeEntity.Descripton);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorAddressTypeEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, mDOperatorAddressTypeEntity.OperatorAddressTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDOperatorAddressTypeEntity.Name);
                db.AddInParameter(cmd, "@Descripton", DbType.String, mDOperatorAddressTypeEntity.Descripton);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDOperatorAddressTypeEntity.IsRemoved);

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

        IList<Int64> IMDOperatorAddressTypeDataAccess.Update(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity in mDOperatorAddressTypeEntityList)
            {
                returnCode = (this as IMDOperatorAddressTypeDataAccess).Update(mDOperatorAddressTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDOperatorAddressTypeDataAccess.Delete(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDOperatorAddressTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDOperatorAddressTypeEntity, filterExpression, option);
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

        private Int64 Delete(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

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
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDOperatorAddressTypeEntity already exists. Please specify another MDOperatorAddressTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDOperatorAddressType_SET";

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

        IList<Int64> IMDOperatorAddressTypeDataAccess.Delete(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity in mDOperatorAddressTypeEntityList)
            {
                returnCode = (this as IMDOperatorAddressTypeDataAccess).Delete(mDOperatorAddressTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDOperatorAddressTypeEntity> IMDOperatorAddressTypeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOperatorAddressType_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDOperatorAddressTypeEntity> list = CreateEntityBuilder<MDOperatorAddressTypeEntity>().BuildEntities(reader);

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

        DataTable IMDOperatorAddressTypeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDOperatorAddressType_GET";

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
