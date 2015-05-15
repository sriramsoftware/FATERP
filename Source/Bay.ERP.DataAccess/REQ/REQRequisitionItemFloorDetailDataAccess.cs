// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Nov-2013, 10:23:55




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
    internal sealed partial class REQRequisitionItemFloorDetailDataAccess : BaseDataAccess, IREQRequisitionItemFloorDetailDataAccess
    {
        #region Constructors

        public REQRequisitionItemFloorDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionItemFloorDetailEntity> CreateEntityBuilder<REQRequisitionItemFloorDetailEntity>()
        {
            return (new REQRequisitionItemFloorDetailBuilder()) as IEntityBuilder<REQRequisitionItemFloorDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IREQRequisitionItemFloorDetailDataAccess.Add(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(rEQRequisitionItemFloorDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(rEQRequisitionItemFloorDetailEntity, option);
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

        private Int64 Add(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "RequisitionItemFloorDetailID");

                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionID);	
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Qty);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemFloorDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, rEQRequisitionItemFloorDetailEntity.EntryDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "RequisitionItemFloorDetailID", db);

                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, rEQRequisitionItemFloorDetailEntity.EntryDate);

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

        IList<Int64> IREQRequisitionItemFloorDetailDataAccess.Add(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity in rEQRequisitionItemFloorDetailEntityList)
            {
                returnCode = (this as IREQRequisitionItemFloorDetailDataAccess).Add(rEQRequisitionItemFloorDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IREQRequisitionItemFloorDetailDataAccess.Update(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(rEQRequisitionItemFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(rEQRequisitionItemFloorDetailEntity, filterExpression, option);
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

        private Int64 Update(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@RequisitionItemFloorDetailID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemFloorDetailID);
                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionID);
                Database.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Qty);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Rate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemFloorDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, rEQRequisitionItemFloorDetailEntity.EntryDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@RequisitionItemFloorDetailID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemFloorDetailID);
                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionID);
                db.AddInParameter(cmd, "@RequisitionItemID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.RequisitionItemID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, rEQRequisitionItemFloorDetailEntity.ProjectUnitLocationID);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Qty);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, rEQRequisitionItemFloorDetailEntity.Rate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionItemFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, rEQRequisitionItemFloorDetailEntity.EntryDate);

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

        IList<Int64> IREQRequisitionItemFloorDetailDataAccess.Update(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity in rEQRequisitionItemFloorDetailEntityList)
            {
                returnCode = (this as IREQRequisitionItemFloorDetailDataAccess).Update(rEQRequisitionItemFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IREQRequisitionItemFloorDetailDataAccess.Delete(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(rEQRequisitionItemFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(rEQRequisitionItemFloorDetailEntity, filterExpression, option);
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

        private Int64 Delete(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

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
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionItemFloorDetailEntity already exists. Please specify another REQRequisitionItemFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisitionItemFloorDetail_SET";

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

        IList<Int64> IREQRequisitionItemFloorDetailDataAccess.Delete(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity in rEQRequisitionItemFloorDetailEntityList)
            {
                returnCode = (this as IREQRequisitionItemFloorDetailDataAccess).Delete(rEQRequisitionItemFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<REQRequisitionItemFloorDetailEntity> IREQRequisitionItemFloorDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItemFloorDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionItemFloorDetailEntity> list = CreateEntityBuilder<REQRequisitionItemFloorDetailEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionItemFloorDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisitionItemFloorDetail_GET";

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
