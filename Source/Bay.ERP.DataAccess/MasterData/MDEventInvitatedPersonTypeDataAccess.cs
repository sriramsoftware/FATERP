// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    internal sealed partial class MDEventInvitatedPersonTypeDataAccess : BaseDataAccess, IMDEventInvitatedPersonTypeDataAccess
    {
        #region Constructors

        public MDEventInvitatedPersonTypeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDEventInvitatedPersonTypeEntity> CreateEntityBuilder<MDEventInvitatedPersonTypeEntity>()
        {
            return (new MDEventInvitatedPersonTypeBuilder()) as IEntityBuilder<MDEventInvitatedPersonTypeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDEventInvitatedPersonTypeDataAccess.Add(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDEventInvitatedPersonTypeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDEventInvitatedPersonTypeEntity, option);
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

        private Int64 Add(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EventInvitatedPersonTypeID");

                Database.AddInParameter(cmd, "@Name", DbType.String, mDEventInvitatedPersonTypeEntity.Name);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDEventInvitatedPersonTypeEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEventInvitatedPersonTypeEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EventInvitatedPersonTypeID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, mDEventInvitatedPersonTypeEntity.Name);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDEventInvitatedPersonTypeEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEventInvitatedPersonTypeEntity.IsRemoved);

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

        IList<Int64> IMDEventInvitatedPersonTypeDataAccess.Add(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity in mDEventInvitatedPersonTypeEntityList)
            {
                returnCode = (this as IMDEventInvitatedPersonTypeDataAccess).Add(mDEventInvitatedPersonTypeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDEventInvitatedPersonTypeDataAccess.Update(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDEventInvitatedPersonTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDEventInvitatedPersonTypeEntity, filterExpression, option);
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

        private Int64 Update(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, mDEventInvitatedPersonTypeEntity.EventInvitatedPersonTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDEventInvitatedPersonTypeEntity.Name);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, mDEventInvitatedPersonTypeEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEventInvitatedPersonTypeEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EventInvitatedPersonTypeID", DbType.Int64, mDEventInvitatedPersonTypeEntity.EventInvitatedPersonTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDEventInvitatedPersonTypeEntity.Name);
                db.AddInParameter(cmd, "@Remarks", DbType.String, mDEventInvitatedPersonTypeEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDEventInvitatedPersonTypeEntity.IsRemoved);

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

        IList<Int64> IMDEventInvitatedPersonTypeDataAccess.Update(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity in mDEventInvitatedPersonTypeEntityList)
            {
                returnCode = (this as IMDEventInvitatedPersonTypeDataAccess).Update(mDEventInvitatedPersonTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDEventInvitatedPersonTypeDataAccess.Delete(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDEventInvitatedPersonTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDEventInvitatedPersonTypeEntity, filterExpression, option);
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

        private Int64 Delete(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

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
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDEventInvitatedPersonTypeEntity already exists. Please specify another MDEventInvitatedPersonTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDEventInvitatedPersonType_SET";

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

        IList<Int64> IMDEventInvitatedPersonTypeDataAccess.Delete(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity in mDEventInvitatedPersonTypeEntityList)
            {
                returnCode = (this as IMDEventInvitatedPersonTypeDataAccess).Delete(mDEventInvitatedPersonTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDEventInvitatedPersonTypeEntity> IMDEventInvitatedPersonTypeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEventInvitatedPersonType_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDEventInvitatedPersonTypeEntity> list = CreateEntityBuilder<MDEventInvitatedPersonTypeEntity>().BuildEntities(reader);

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

        DataTable IMDEventInvitatedPersonTypeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDEventInvitatedPersonType_GET";

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
