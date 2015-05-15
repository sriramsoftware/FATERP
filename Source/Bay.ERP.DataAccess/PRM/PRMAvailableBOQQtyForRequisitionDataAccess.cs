// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Jul-2013, 05:44:25




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
    internal sealed partial class PRMAvailableBOQQtyForRequisitionDataAccess : BaseDataAccess, IPRMAvailableBOQQtyForRequisitionDataAccess
    {
        #region Constructors

        public PRMAvailableBOQQtyForRequisitionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity> CreateEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>()
        {
            return (new PRMAvailableBOQQtyForRequisitionBuilder()) as IEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMAvailableBOQQtyForRequisitionDataAccess.Add(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMAvailableBOQQtyForRequisitionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMAvailableBOQQtyForRequisitionEntity, option);
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

        private Int64 Add(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AvailableBOQQtyForRequisitionID");

                Database.AddInParameter(cmd, "@IsBOQ", DbType.Boolean, pRMAvailableBOQQtyForRequisitionEntity.IsBOQ);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ProjectID);	
                Database.AddInParameter(cmd, "@PreBOQOrBOQDetailID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ItemID);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMAvailableBOQQtyForRequisitionEntity.Qty);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMAvailableBOQQtyForRequisitionEntity.CreateDate);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AvailableBOQQtyForRequisitionID", db);

                db.AddInParameter(cmd, "@IsBOQ", DbType.Boolean, pRMAvailableBOQQtyForRequisitionEntity.IsBOQ);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ProjectID);
                db.AddInParameter(cmd, "@PreBOQOrBOQDetailID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ItemID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMAvailableBOQQtyForRequisitionEntity.Qty);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMAvailableBOQQtyForRequisitionEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID);

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

        IList<Int64> IPRMAvailableBOQQtyForRequisitionDataAccess.Add(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity in pRMAvailableBOQQtyForRequisitionEntityList)
            {
                returnCode = (this as IPRMAvailableBOQQtyForRequisitionDataAccess).Add(pRMAvailableBOQQtyForRequisitionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMAvailableBOQQtyForRequisitionDataAccess.Update(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option);
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

        private Int64 Update(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AvailableBOQQtyForRequisitionID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.AvailableBOQQtyForRequisitionID);
                Database.AddInParameter(cmd, "@IsBOQ", DbType.Boolean, pRMAvailableBOQQtyForRequisitionEntity.IsBOQ);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ProjectID);
                Database.AddInParameter(cmd, "@PreBOQOrBOQDetailID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ItemID);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMAvailableBOQQtyForRequisitionEntity.Qty);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMAvailableBOQQtyForRequisitionEntity.CreateDate);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AvailableBOQQtyForRequisitionID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.AvailableBOQQtyForRequisitionID);
                db.AddInParameter(cmd, "@IsBOQ", DbType.Boolean, pRMAvailableBOQQtyForRequisitionEntity.IsBOQ);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ProjectID);
                db.AddInParameter(cmd, "@PreBOQOrBOQDetailID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.PreBOQOrBOQDetailID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.ItemID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, pRMAvailableBOQQtyForRequisitionEntity.Qty);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, pRMAvailableBOQQtyForRequisitionEntity.CreateDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMAvailableBOQQtyForRequisitionEntity.CreatedByEmployeeID);

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

        IList<Int64> IPRMAvailableBOQQtyForRequisitionDataAccess.Update(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity in pRMAvailableBOQQtyForRequisitionEntityList)
            {
                returnCode = (this as IPRMAvailableBOQQtyForRequisitionDataAccess).Update(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMAvailableBOQQtyForRequisitionDataAccess.Delete(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option);
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

        private Int64 Delete(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

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
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMAvailableBOQQtyForRequisitionEntity already exists. Please specify another PRMAvailableBOQQtyForRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMAvailableBOQQtyForRequisition_SET";

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

        IList<Int64> IPRMAvailableBOQQtyForRequisitionDataAccess.Delete(IList<PRMAvailableBOQQtyForRequisitionEntity> pRMAvailableBOQQtyForRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMAvailableBOQQtyForRequisitionEntity pRMAvailableBOQQtyForRequisitionEntity in pRMAvailableBOQQtyForRequisitionEntityList)
            {
                returnCode = (this as IPRMAvailableBOQQtyForRequisitionDataAccess).Delete(pRMAvailableBOQQtyForRequisitionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMAvailableBOQQtyForRequisitionEntity> IPRMAvailableBOQQtyForRequisitionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMAvailableBOQQtyForRequisition_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMAvailableBOQQtyForRequisitionEntity> list = CreateEntityBuilder<PRMAvailableBOQQtyForRequisitionEntity>().BuildEntities(reader);

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

        DataTable IPRMAvailableBOQQtyForRequisitionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMAvailableBOQQtyForRequisition_GET";

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
