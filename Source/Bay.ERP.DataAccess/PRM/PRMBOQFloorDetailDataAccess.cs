// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 10:55:37




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
    internal sealed partial class PRMBOQFloorDetailDataAccess : BaseDataAccess, IPRMBOQFloorDetailDataAccess
    {
        #region Constructors

        public PRMBOQFloorDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQFloorDetailEntity> CreateEntityBuilder<PRMBOQFloorDetailEntity>()
        {
            return (new PRMBOQFloorDetailBuilder()) as IEntityBuilder<PRMBOQFloorDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMBOQFloorDetailDataAccess.Add(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMBOQFloorDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMBOQFloorDetailEntity, option);
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

        private Int64 Add(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BOQFloorDetailID");

                Database.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQDetailID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMBOQFloorDetailEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMBOQFloorDetailEntity.Qty);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQFloorDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQFloorDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQFloorDetailEntity.EntryDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BOQFloorDetailID", db);

                db.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQDetailID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMBOQFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMBOQFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMBOQFloorDetailDataAccess.Add(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity in pRMBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMBOQFloorDetailDataAccess).Add(pRMBOQFloorDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMBOQFloorDetailDataAccess.Update(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMBOQFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMBOQFloorDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BOQFloorDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQFloorDetailID);
                Database.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQDetailID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMBOQFloorDetailEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMBOQFloorDetailEntity.Qty);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQFloorDetailEntity.Rate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQFloorDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQFloorDetailEntity.EntryDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BOQFloorDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQFloorDetailID);
                db.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQFloorDetailEntity.BOQDetailID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, pRMBOQFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMBOQFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQFloorDetailEntity.EntryDate);

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

        IList<Int64> IPRMBOQFloorDetailDataAccess.Update(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity in pRMBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMBOQFloorDetailDataAccess).Update(pRMBOQFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMBOQFloorDetailDataAccess.Delete(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMBOQFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMBOQFloorDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

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
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQFloorDetailEntity already exists. Please specify another PRMBOQFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQFloorDetail_SET";

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

        IList<Int64> IPRMBOQFloorDetailDataAccess.Delete(IList<PRMBOQFloorDetailEntity> pRMBOQFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMBOQFloorDetailEntity pRMBOQFloorDetailEntity in pRMBOQFloorDetailEntityList)
            {
                returnCode = (this as IPRMBOQFloorDetailDataAccess).Delete(pRMBOQFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMBOQFloorDetailEntity> IPRMBOQFloorDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQFloorDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQFloorDetailEntity> list = CreateEntityBuilder<PRMBOQFloorDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQFloorDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQFloorDetail_GET";

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
