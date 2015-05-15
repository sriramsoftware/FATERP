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
    internal sealed partial class PRMMaterialReceiveDataAccess : BaseDataAccess, IPRMMaterialReceiveDataAccess
    {
        #region Constructors

        public PRMMaterialReceiveDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMMaterialReceiveEntity> CreateEntityBuilder<PRMMaterialReceiveEntity>()
        {
            return (new PRMMaterialReceiveBuilder()) as IEntityBuilder<PRMMaterialReceiveEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMMaterialReceiveDataAccess.Add(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMMaterialReceiveEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMMaterialReceiveEntity, option);
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

        private Int64 Add(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MaterialReceiveID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMMaterialReceiveEntity.ProjectID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMMaterialReceiveEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMMaterialReceiveEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMMaterialReceiveEntity.WorkOrderID);	
                Database.AddInParameter(cmd, "@MRRNo", DbType.String, pRMMaterialReceiveEntity.MRRNo);	
                Database.AddInParameter(cmd, "@MRRDate", DbType.DateTime, pRMMaterialReceiveEntity.MRRDate);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMMaterialReceiveEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMMaterialReceiveEntity.Remarks);	
                Database.AddInParameter(cmd, "@MaterialReceiveApprovalStatusID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MaterialReceiveID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMMaterialReceiveEntity.ProjectID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMMaterialReceiveEntity.SupplierID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMMaterialReceiveEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMMaterialReceiveEntity.WorkOrderID);
                db.AddInParameter(cmd, "@MRRNo", DbType.String, pRMMaterialReceiveEntity.MRRNo);
                db.AddInParameter(cmd, "@MRRDate", DbType.DateTime, pRMMaterialReceiveEntity.MRRDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMMaterialReceiveEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMMaterialReceiveEntity.Remarks);
                db.AddInParameter(cmd, "@MaterialReceiveApprovalStatusID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID);

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

        IList<Int64> IPRMMaterialReceiveDataAccess.Add(IList<PRMMaterialReceiveEntity> pRMMaterialReceiveEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMMaterialReceiveEntity pRMMaterialReceiveEntity in pRMMaterialReceiveEntityList)
            {
                returnCode = (this as IPRMMaterialReceiveDataAccess).Add(pRMMaterialReceiveEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMMaterialReceiveDataAccess.Update(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMMaterialReceiveEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMMaterialReceiveEntity, filterExpression, option);
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

        private Int64 Update(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMMaterialReceiveEntity.ProjectID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMMaterialReceiveEntity.SupplierID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMMaterialReceiveEntity.RequisitionID);
                Database.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMMaterialReceiveEntity.WorkOrderID);
                Database.AddInParameter(cmd, "@MRRNo", DbType.String, pRMMaterialReceiveEntity.MRRNo);
                Database.AddInParameter(cmd, "@MRRDate", DbType.DateTime, pRMMaterialReceiveEntity.MRRDate);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMMaterialReceiveEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMMaterialReceiveEntity.Remarks);
                Database.AddInParameter(cmd, "@MaterialReceiveApprovalStatusID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMMaterialReceiveEntity.ProjectID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMMaterialReceiveEntity.SupplierID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, pRMMaterialReceiveEntity.RequisitionID);
                db.AddInParameter(cmd, "@WorkOrderID", DbType.Int64, pRMMaterialReceiveEntity.WorkOrderID);
                db.AddInParameter(cmd, "@MRRNo", DbType.String, pRMMaterialReceiveEntity.MRRNo);
                db.AddInParameter(cmd, "@MRRDate", DbType.DateTime, pRMMaterialReceiveEntity.MRRDate);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, pRMMaterialReceiveEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMMaterialReceiveEntity.Remarks);
                db.AddInParameter(cmd, "@MaterialReceiveApprovalStatusID", DbType.Int64, pRMMaterialReceiveEntity.MaterialReceiveApprovalStatusID);

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

        IList<Int64> IPRMMaterialReceiveDataAccess.Update(IList<PRMMaterialReceiveEntity> pRMMaterialReceiveEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMMaterialReceiveEntity pRMMaterialReceiveEntity in pRMMaterialReceiveEntityList)
            {
                returnCode = (this as IPRMMaterialReceiveDataAccess).Update(pRMMaterialReceiveEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMMaterialReceiveDataAccess.Delete(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMMaterialReceiveEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMMaterialReceiveEntity, filterExpression, option);
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

        private Int64 Delete(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

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
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMMaterialReceiveEntity already exists. Please specify another PRMMaterialReceiveEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMMaterialReceiveEntity pRMMaterialReceiveEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMMaterialReceive_SET";

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

        IList<Int64> IPRMMaterialReceiveDataAccess.Delete(IList<PRMMaterialReceiveEntity> pRMMaterialReceiveEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMMaterialReceiveEntity pRMMaterialReceiveEntity in pRMMaterialReceiveEntityList)
            {
                returnCode = (this as IPRMMaterialReceiveDataAccess).Delete(pRMMaterialReceiveEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMMaterialReceiveEntity> IPRMMaterialReceiveDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMMaterialReceive_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMMaterialReceiveEntity> list = CreateEntityBuilder<PRMMaterialReceiveEntity>().BuildEntities(reader);

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

        DataTable IPRMMaterialReceiveDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMMaterialReceive_GET";

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
