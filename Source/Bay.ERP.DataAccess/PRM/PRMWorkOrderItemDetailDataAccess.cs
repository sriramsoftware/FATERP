// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2012, 04:57:13




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
    internal sealed partial class PRMWorkOrderItemDetailDataAccess : BaseDataAccess, IPRMWorkOrderItemDetailDataAccess
    {
        #region Constructors

        public PRMWorkOrderItemDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderItemDetailEntity> CreateEntityBuilder<PRMWorkOrderItemDetailEntity>()
        {
            return (new PRMWorkOrderItemDetailBuilder()) as IEntityBuilder<PRMWorkOrderItemDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMWorkOrderItemDetailDataAccess.Add(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMWorkOrderItemDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMWorkOrderItemDetailEntity, option);
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

        private Int64 Add(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemDetailID");

                Database.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemMapID);	
                Database.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemDetailEntity.Description);	
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, pRMWorkOrderItemDetailEntity.UnitID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemDetailEntity.Qty);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "WorkOrderItemDetailID", db);

                db.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemMapID);
                db.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemDetailEntity.Description);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, pRMWorkOrderItemDetailEntity.UnitID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemDetailEntity.Rate);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemDetailEntity.Qty);

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

        IList<Int64> IPRMWorkOrderItemDetailDataAccess.Add(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity in pRMWorkOrderItemDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemDetailDataAccess).Add(pRMWorkOrderItemDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMWorkOrderItemDetailDataAccess.Update(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMWorkOrderItemDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMWorkOrderItemDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@WorkOrderItemDetailID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID);
                Database.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemMapID);
                Database.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemDetailEntity.Description);
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, pRMWorkOrderItemDetailEntity.UnitID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemDetailEntity.Rate);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemDetailEntity.Qty);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@WorkOrderItemDetailID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID);
                db.AddInParameter(cmd, "@WorkOrderItemMapID", DbType.Int64, pRMWorkOrderItemDetailEntity.WorkOrderItemMapID);
                db.AddInParameter(cmd, "@Description", DbType.String, pRMWorkOrderItemDetailEntity.Description);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, pRMWorkOrderItemDetailEntity.UnitID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMWorkOrderItemDetailEntity.Rate);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMWorkOrderItemDetailEntity.Qty);

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

        IList<Int64> IPRMWorkOrderItemDetailDataAccess.Update(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity in pRMWorkOrderItemDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemDetailDataAccess).Update(pRMWorkOrderItemDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMWorkOrderItemDetailDataAccess.Delete(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMWorkOrderItemDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMWorkOrderItemDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

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
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMWorkOrderItemDetailEntity already exists. Please specify another PRMWorkOrderItemDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMWorkOrderItemDetail_SET";

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

        IList<Int64> IPRMWorkOrderItemDetailDataAccess.Delete(IList<PRMWorkOrderItemDetailEntity> pRMWorkOrderItemDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity in pRMWorkOrderItemDetailEntityList)
            {
                returnCode = (this as IPRMWorkOrderItemDetailDataAccess).Delete(pRMWorkOrderItemDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMWorkOrderItemDetailEntity> IPRMWorkOrderItemDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderItemDetailEntity> list = CreateEntityBuilder<PRMWorkOrderItemDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderItemDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderItemDetail_GET";

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
