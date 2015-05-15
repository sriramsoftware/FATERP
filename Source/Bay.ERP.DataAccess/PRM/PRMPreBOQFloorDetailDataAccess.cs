// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    internal sealed partial class PRMPreBOQFloorDetailDataAccess : BaseDataAccess, IPRMPreBOQFloorDetailDataAccess
    {
        #region Constructors

        public PRMPreBOQFloorDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQFloorDetailEntity> CreateEntityBuilder<PRMPreBOQFloorDetailEntity>()
        {
            return (new PRMPreBOQFloorDetailBuilder()) as IEntityBuilder<PRMPreBOQFloorDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMPreBOQFloorDetailDataAccess.Add(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMPreBOQFloorDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMPreBOQFloorDetailEntity, option);
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

        private Int64 Add(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "PreBOQFloorDetailID");

                Database.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQDetailID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMPreBOQFloorDetailEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMPreBOQFloorDetailEntity.Qty);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQFloorDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQFloorDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQFloorDetailEntity.EntryDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "PreBOQFloorDetailID", db);

                db.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQDetailID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMPreBOQFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMPreBOQFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMPreBOQFloorDetailDataAccess.Add(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity in pRMPreBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQFloorDetailDataAccess).Add(pRMPreBOQFloorDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMPreBOQFloorDetailDataAccess.Update(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMPreBOQFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMPreBOQFloorDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@PreBOQFloorDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQFloorDetailID);
                Database.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQDetailID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMPreBOQFloorDetailEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMPreBOQFloorDetailEntity.Qty);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQFloorDetailEntity.Rate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQFloorDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQFloorDetailEntity.EntryDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@PreBOQFloorDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQFloorDetailID);
                db.AddInParameter(cmd, "@PreBOQDetailID", DbType.Int64, pRMPreBOQFloorDetailEntity.PreBOQDetailID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMPreBOQFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMPreBOQFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMPreBOQFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMPreBOQFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMPreBOQFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMPreBOQFloorDetailDataAccess.Update(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity in pRMPreBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQFloorDetailDataAccess).Update(pRMPreBOQFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMPreBOQFloorDetailDataAccess.Delete(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMPreBOQFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMPreBOQFloorDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

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
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMPreBOQFloorDetailEntity already exists. Please specify another PRMPreBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMPreBOQFloorDetail_SET";

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

        IList<Int64> IPRMPreBOQFloorDetailDataAccess.Delete(IList<PRMPreBOQFloorDetailEntity> pRMPreBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMPreBOQFloorDetailEntity pRMPreBOQFloorDetailEntity in pRMPreBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMPreBOQFloorDetailDataAccess).Delete(pRMPreBOQFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMPreBOQFloorDetailEntity> IPRMPreBOQFloorDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQFloorDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQFloorDetailEntity> list = CreateEntityBuilder<PRMPreBOQFloorDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQFloorDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQFloorDetail_GET";

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
