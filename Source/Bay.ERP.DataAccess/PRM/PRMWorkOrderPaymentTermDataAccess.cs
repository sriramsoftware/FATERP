// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    internal sealed partial class PRMWorkOrderPaymentTermDataAccess : BaseDataAccess, IPRMWorkOrderPaymentTermDataAccess
    {
        #region Constructors

        public PRMWorkOrderPaymentTermDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderPaymentTermEntity> CreateEntityBuilder<PRMWorkOrderPaymentTermEntity>()
        {
            return (new PRMWorkOrderPaymentTermBuilder()) as IEntityBuilder<PRMWorkOrderPaymentTermEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMWorkOrderPaymentTermDataAccess.Add(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMWorkOrderPaymentTermEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMWorkOrderPaymentTermEntity, option);
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

        private Int64 Add(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderPaymentTermID");

                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@PaymentPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.PaymentPercentage);	
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.CompletionPercentage);	
                Database.AddInParameter(cmd, "@CompletionNote", DbType.String, pRMWorkOrderPaymentTermEntity.CompletionNote);	
                Database.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, pRMWorkOrderPaymentTermEntity.PaymentDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderPaymentTermID", db);

                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderID);
                db.AddInParameter(cmd, "@PaymentPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.PaymentPercentage);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@CompletionNote", DbType.String, pRMWorkOrderPaymentTermEntity.CompletionNote);
                db.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, pRMWorkOrderPaymentTermEntity.PaymentDate);

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

        IList<Int64> IPRMWorkOrderPaymentTermDataAccess.Add(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity in pRMWorkOrderPaymentTermEntityList)
            {
                returnCode = (this as IPRMWorkOrderPaymentTermDataAccess).Add(pRMWorkOrderPaymentTermEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMWorkOrderPaymentTermDataAccess.Update(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMWorkOrderPaymentTermEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMWorkOrderPaymentTermEntity, filterExpression, option);
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

        private Int64 Update(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkOrderPaymentTermID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderPaymentTermID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@PaymentPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.PaymentPercentage);
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.CompletionPercentage);
                Database.AddInParameter(cmd, "@CompletionNote", DbType.String, pRMWorkOrderPaymentTermEntity.CompletionNote);
                Database.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, pRMWorkOrderPaymentTermEntity.PaymentDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkOrderPaymentTermID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderPaymentTermID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMWorkOrderPaymentTermEntity.WorkOrderID);
                db.AddInParameter(cmd, "@PaymentPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.PaymentPercentage);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, pRMWorkOrderPaymentTermEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@CompletionNote", DbType.String, pRMWorkOrderPaymentTermEntity.CompletionNote);
                db.AddInParameter(cmd, "@PaymentDate", DbType.DateTime, pRMWorkOrderPaymentTermEntity.PaymentDate);

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

        IList<Int64> IPRMWorkOrderPaymentTermDataAccess.Update(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity in pRMWorkOrderPaymentTermEntityList)
            {
                returnCode = (this as IPRMWorkOrderPaymentTermDataAccess).Update(pRMWorkOrderPaymentTermEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMWorkOrderPaymentTermDataAccess.Delete(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMWorkOrderPaymentTermEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMWorkOrderPaymentTermEntity, filterExpression, option);
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

        private Int64 Delete(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

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
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderPaymentTermEntity already exists. Please specify another PRMWorkOrderPaymentTermEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderPaymentTerm_SET";

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

        IList<Int64> IPRMWorkOrderPaymentTermDataAccess.Delete(IList<PRMWorkOrderPaymentTermEntity> pRMWorkOrderPaymentTermEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity in pRMWorkOrderPaymentTermEntityList)
            {
                returnCode = (this as IPRMWorkOrderPaymentTermDataAccess).Delete(pRMWorkOrderPaymentTermEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMWorkOrderPaymentTermEntity> IPRMWorkOrderPaymentTermDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderPaymentTerm_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderPaymentTermEntity> list = CreateEntityBuilder<PRMWorkOrderPaymentTermEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderPaymentTermDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderPaymentTerm_GET";

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
