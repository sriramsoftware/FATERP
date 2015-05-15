// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-May-2012, 04:19:57




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
    internal sealed partial class PRMPreBOQDataAccess : BaseDataAccess, IPRMPreBOQDataAccess
    {
        #region Constructors

        public PRMPreBOQDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQEntity> CreateEntityBuilder<PRMPreBOQEntity>()
        {
            return (new PRMPreBOQBuilder()) as IEntityBuilder<PRMPreBOQEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQDataAccess.Add(PRMPreBOQEntity pRMPreBOQEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQEntity, option);
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

        private Int64 Add(PRMPreBOQEntity pRMPreBOQEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PreBOQID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMPreBOQEntity.ProjectID);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMPreBOQEntity.StartDate);	
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMPreBOQEntity.PreparedByMemberID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQEntity.Remarks);	
                Database.AddInParameter(cmd, "@PreBOQStatusID", DbType.Int64, pRMPreBOQEntity.PreBOQStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, pRMPreBOQEntity.IsLocked);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQEntity pRMPreBOQEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PreBOQID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMPreBOQEntity.ProjectID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMPreBOQEntity.StartDate);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMPreBOQEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQEntity.Remarks);
                db.AddInParameter(cmd, "@PreBOQStatusID", DbType.Int64, pRMPreBOQEntity.PreBOQStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, pRMPreBOQEntity.IsLocked);

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

        IList<Int64> IPRMPreBOQDataAccess.Add(IList<PRMPreBOQEntity> pRMPreBOQEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQEntity pRMPreBOQEntity in pRMPreBOQEntityList)
            {
                returnCode = (this as IPRMPreBOQDataAccess).Add(pRMPreBOQEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQDataAccess.Update(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQEntity.PreBOQID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMPreBOQEntity.ProjectID);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMPreBOQEntity.StartDate);
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMPreBOQEntity.PreparedByMemberID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQEntity.Remarks);
                Database.AddInParameter(cmd, "@PreBOQStatusID", DbType.Int64, pRMPreBOQEntity.PreBOQStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQEntity.IsRemoved);
                Database.AddInParameter(cmd, "@IsLocked", DbType.Boolean, pRMPreBOQEntity.IsLocked);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMPreBOQEntity.PreBOQID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMPreBOQEntity.ProjectID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMPreBOQEntity.StartDate);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMPreBOQEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQEntity.Remarks);
                db.AddInParameter(cmd, "@PreBOQStatusID", DbType.Int64, pRMPreBOQEntity.PreBOQStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMPreBOQEntity.IsRemoved);
                db.AddInParameter(cmd, "@IsLocked", DbType.Boolean, pRMPreBOQEntity.IsLocked);

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

        IList<Int64> IPRMPreBOQDataAccess.Update(IList<PRMPreBOQEntity> pRMPreBOQEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQEntity pRMPreBOQEntity in pRMPreBOQEntityList)
            {
                returnCode = (this as IPRMPreBOQDataAccess).Update(pRMPreBOQEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQDataAccess.Delete(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

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
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQEntity already exists. Please specify another PRMPreBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQEntity pRMPreBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQ_SET";

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

        IList<Int64> IPRMPreBOQDataAccess.Delete(IList<PRMPreBOQEntity> pRMPreBOQEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQEntity pRMPreBOQEntity in pRMPreBOQEntityList)
            {
                returnCode = (this as IPRMPreBOQDataAccess).Delete(pRMPreBOQEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQEntity> IPRMPreBOQDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQ_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQEntity> list = CreateEntityBuilder<PRMPreBOQEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQ_GET";

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
