// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    internal sealed partial class BDMDProcessAssignedResourceApprovalStatusDataAccess : BaseDataAccess, IBDMDProcessAssignedResourceApprovalStatusDataAccess
    {
        #region Constructors

        public BDMDProcessAssignedResourceApprovalStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity> CreateEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>()
        {
            return (new BDMDProcessAssignedResourceApprovalStatusBuilder()) as IEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDMDProcessAssignedResourceApprovalStatusDataAccess.Add(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDMDProcessAssignedResourceApprovalStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDMDProcessAssignedResourceApprovalStatusEntity, option);
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

        private Int64 Add(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProcessAssignedResourceApprovalStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProcessAssignedResourceApprovalStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusDataAccess.Add(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity in bDMDProcessAssignedResourceApprovalStatusEntityList)
            {
                returnCode = (this as IBDMDProcessAssignedResourceApprovalStatusDataAccess).Add(bDMDProcessAssignedResourceApprovalStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDMDProcessAssignedResourceApprovalStatusDataAccess.Update(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option);
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

        private Int64 Update(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProcessAssignedResourceApprovalStatusID", DbType.Int64, bDMDProcessAssignedResourceApprovalStatusEntity.ProcessAssignedResourceApprovalStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProcessAssignedResourceApprovalStatusID", DbType.Int64, bDMDProcessAssignedResourceApprovalStatusEntity.ProcessAssignedResourceApprovalStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, bDMDProcessAssignedResourceApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusDataAccess.Update(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity in bDMDProcessAssignedResourceApprovalStatusEntityList)
            {
                returnCode = (this as IBDMDProcessAssignedResourceApprovalStatusDataAccess).Update(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDMDProcessAssignedResourceApprovalStatusDataAccess.Delete(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option);
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

        private Int64 Delete(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

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
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDMDProcessAssignedResourceApprovalStatusEntity already exists. Please specify another BDMDProcessAssignedResourceApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_SET";

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

        IList<Int64> IBDMDProcessAssignedResourceApprovalStatusDataAccess.Delete(IList<BDMDProcessAssignedResourceApprovalStatusEntity> bDMDProcessAssignedResourceApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity in bDMDProcessAssignedResourceApprovalStatusEntityList)
            {
                returnCode = (this as IBDMDProcessAssignedResourceApprovalStatusDataAccess).Delete(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDMDProcessAssignedResourceApprovalStatusEntity> IBDMDProcessAssignedResourceApprovalStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDMDProcessAssignedResourceApprovalStatusEntity> list = CreateEntityBuilder<BDMDProcessAssignedResourceApprovalStatusEntity>().BuildEntities(reader);

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

        DataTable IBDMDProcessAssignedResourceApprovalStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDMDProcessAssignedResourceApprovalStatus_GET";

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
