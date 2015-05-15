// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-May-2012, 11:38:55




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
    internal sealed partial class PRMSupplierDataAccess : BaseDataAccess, IPRMSupplierDataAccess
    {
        #region Constructors

        public PRMSupplierDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierEntity> CreateEntityBuilder<PRMSupplierEntity>()
        {
            return (new PRMSupplierBuilder()) as IEntityBuilder<PRMSupplierEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMSupplierDataAccess.Add(PRMSupplierEntity pRMSupplierEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMSupplierEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMSupplierEntity, option);
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

        private Int64 Add(PRMSupplierEntity pRMSupplierEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SupplierID");

                Database.AddInParameter(cmd, "@SupplierCode", DbType.String, pRMSupplierEntity.SupplierCode);	
                Database.AddInParameter(cmd, "@SupplierName", DbType.String, pRMSupplierEntity.SupplierName);	
                Database.AddInParameter(cmd, "@Relationship", DbType.String, pRMSupplierEntity.Relationship);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierEntity.Phone);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, pRMSupplierEntity.MobileNo);	
                Database.AddInParameter(cmd, "@Fax", DbType.String, pRMSupplierEntity.Fax);	
                Database.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierEntity.WebLink);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMSupplierEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMSupplierEntity.Remarks);	
                Database.AddInParameter(cmd, "@SupplierTypeID", DbType.Int64, pRMSupplierEntity.SupplierTypeID);	
                Database.AddInParameter(cmd, "@SupplierStatusID", DbType.Int64, pRMSupplierEntity.SupplierStatusID);	
                Database.AddInParameter(cmd, "@Reason", DbType.String, pRMSupplierEntity.Reason);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMSupplierEntity pRMSupplierEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SupplierID", db);

                db.AddInParameter(cmd, "@SupplierCode", DbType.String, pRMSupplierEntity.SupplierCode);
                db.AddInParameter(cmd, "@SupplierName", DbType.String, pRMSupplierEntity.SupplierName);
                db.AddInParameter(cmd, "@Relationship", DbType.String, pRMSupplierEntity.Relationship);
                db.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, pRMSupplierEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, pRMSupplierEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierEntity.WebLink);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMSupplierEntity.CreateDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMSupplierEntity.Remarks);
                db.AddInParameter(cmd, "@SupplierTypeID", DbType.Int64, pRMSupplierEntity.SupplierTypeID);
                db.AddInParameter(cmd, "@SupplierStatusID", DbType.Int64, pRMSupplierEntity.SupplierStatusID);
                db.AddInParameter(cmd, "@Reason", DbType.String, pRMSupplierEntity.Reason);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierEntity.IsRemoved);

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

        IList<Int64> IPRMSupplierDataAccess.Add(IList<PRMSupplierEntity> pRMSupplierEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMSupplierEntity pRMSupplierEntity in pRMSupplierEntityList)
            {
                returnCode = (this as IPRMSupplierDataAccess).Add(pRMSupplierEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMSupplierDataAccess.Update(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMSupplierEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMSupplierEntity, filterExpression, option);
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

        private Int64 Update(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierEntity.SupplierID);
                Database.AddInParameter(cmd, "@SupplierCode", DbType.String, pRMSupplierEntity.SupplierCode);
                Database.AddInParameter(cmd, "@SupplierName", DbType.String, pRMSupplierEntity.SupplierName);
                Database.AddInParameter(cmd, "@Relationship", DbType.String, pRMSupplierEntity.Relationship);
                Database.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierEntity.Phone);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, pRMSupplierEntity.MobileNo);
                Database.AddInParameter(cmd, "@Fax", DbType.String, pRMSupplierEntity.Fax);
                Database.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierEntity.WebLink);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMSupplierEntity.CreateDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMSupplierEntity.Remarks);
                Database.AddInParameter(cmd, "@SupplierTypeID", DbType.Int64, pRMSupplierEntity.SupplierTypeID);
                Database.AddInParameter(cmd, "@SupplierStatusID", DbType.Int64, pRMSupplierEntity.SupplierStatusID);
                Database.AddInParameter(cmd, "@Reason", DbType.String, pRMSupplierEntity.Reason);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierEntity.SupplierID);
                db.AddInParameter(cmd, "@SupplierCode", DbType.String, pRMSupplierEntity.SupplierCode);
                db.AddInParameter(cmd, "@SupplierName", DbType.String, pRMSupplierEntity.SupplierName);
                db.AddInParameter(cmd, "@Relationship", DbType.String, pRMSupplierEntity.Relationship);
                db.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierEntity.Phone);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, pRMSupplierEntity.MobileNo);
                db.AddInParameter(cmd, "@Fax", DbType.String, pRMSupplierEntity.Fax);
                db.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierEntity.WebLink);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMSupplierEntity.CreateDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMSupplierEntity.Remarks);
                db.AddInParameter(cmd, "@SupplierTypeID", DbType.Int64, pRMSupplierEntity.SupplierTypeID);
                db.AddInParameter(cmd, "@SupplierStatusID", DbType.Int64, pRMSupplierEntity.SupplierStatusID);
                db.AddInParameter(cmd, "@Reason", DbType.String, pRMSupplierEntity.Reason);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMSupplierEntity.IsRemoved);

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

        IList<Int64> IPRMSupplierDataAccess.Update(IList<PRMSupplierEntity> pRMSupplierEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMSupplierEntity pRMSupplierEntity in pRMSupplierEntityList)
            {
                returnCode = (this as IPRMSupplierDataAccess).Update(pRMSupplierEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMSupplierDataAccess.Delete(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMSupplierEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMSupplierEntity, filterExpression, option);
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

        private Int64 Delete(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

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
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierEntity already exists. Please specify another PRMSupplierEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMSupplierEntity pRMSupplierEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplier_SET";

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

        IList<Int64> IPRMSupplierDataAccess.Delete(IList<PRMSupplierEntity> pRMSupplierEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMSupplierEntity pRMSupplierEntity in pRMSupplierEntityList)
            {
                returnCode = (this as IPRMSupplierDataAccess).Delete(pRMSupplierEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMSupplierEntity> IPRMSupplierDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplier_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierEntity> list = CreateEntityBuilder<PRMSupplierEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplier_GET";

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
