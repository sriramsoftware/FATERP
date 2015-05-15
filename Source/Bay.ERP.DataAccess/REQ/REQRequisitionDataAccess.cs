// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Oct-2013, 01:03:02




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
    internal sealed partial class REQRequisitionDataAccess : BaseDataAccess, IREQRequisitionDataAccess
    {
        #region Constructors

        public REQRequisitionDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<REQRequisitionEntity> CreateEntityBuilder<REQRequisitionEntity>()
        {
            return (new REQRequisitionBuilder()) as IEntityBuilder<REQRequisitionEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IREQRequisitionDataAccess.Add(REQRequisitionEntity rEQRequisitionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(rEQRequisitionEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(rEQRequisitionEntity, option);
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

        private Int64 Add(REQRequisitionEntity rEQRequisitionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "RequisitionID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, rEQRequisitionEntity.ProjectID);	
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, rEQRequisitionEntity.RequisitionNo);	
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, rEQRequisitionEntity.RequisitionDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionEntity.Remarks);	
                Database.AddInParameter(cmd, "@RequisitionStatusID", DbType.Int64, rEQRequisitionEntity.RequisitionStatusID);	
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, rEQRequisitionEntity.PreparedByMemberID);	
                Database.AddInParameter(cmd, "@IsCashPayment", DbType.Boolean, rEQRequisitionEntity.IsCashPayment);	
                Database.AddInParameter(cmd, "@IsAccountsMadePayment", DbType.Boolean, rEQRequisitionEntity.IsAccountsMadePayment);	
                Database.AddInParameter(cmd, "@IsRCS", DbType.Boolean, rEQRequisitionEntity.IsRCS);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(REQRequisitionEntity rEQRequisitionEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "RequisitionID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, rEQRequisitionEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, rEQRequisitionEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, rEQRequisitionEntity.RequisitionDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionEntity.Remarks);
                db.AddInParameter(cmd, "@RequisitionStatusID", DbType.Int64, rEQRequisitionEntity.RequisitionStatusID);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, rEQRequisitionEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@IsCashPayment", DbType.Boolean, rEQRequisitionEntity.IsCashPayment);
                db.AddInParameter(cmd, "@IsAccountsMadePayment", DbType.Boolean, rEQRequisitionEntity.IsAccountsMadePayment);
                db.AddInParameter(cmd, "@IsRCS", DbType.Boolean, rEQRequisitionEntity.IsRCS);

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

        IList<Int64> IREQRequisitionDataAccess.Add(IList<REQRequisitionEntity> rEQRequisitionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (REQRequisitionEntity rEQRequisitionEntity in rEQRequisitionEntityList)
            {
                returnCode = (this as IREQRequisitionDataAccess).Add(rEQRequisitionEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IREQRequisitionDataAccess.Update(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(rEQRequisitionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(rEQRequisitionEntity, filterExpression, option);
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

        private Int64 Update(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionEntity.RequisitionID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, rEQRequisitionEntity.ProjectID);
                Database.AddInParameter(cmd, "@RequisitionNo", DbType.String, rEQRequisitionEntity.RequisitionNo);
                Database.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, rEQRequisitionEntity.RequisitionDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionEntity.Remarks);
                Database.AddInParameter(cmd, "@RequisitionStatusID", DbType.Int64, rEQRequisitionEntity.RequisitionStatusID);
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, rEQRequisitionEntity.PreparedByMemberID);
                Database.AddInParameter(cmd, "@IsCashPayment", DbType.Boolean, rEQRequisitionEntity.IsCashPayment);
                Database.AddInParameter(cmd, "@IsAccountsMadePayment", DbType.Boolean, rEQRequisitionEntity.IsAccountsMadePayment);
                Database.AddInParameter(cmd, "@IsRCS", DbType.Boolean, rEQRequisitionEntity.IsRCS);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@RequisitionID", DbType.Int64, rEQRequisitionEntity.RequisitionID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, rEQRequisitionEntity.ProjectID);
                db.AddInParameter(cmd, "@RequisitionNo", DbType.String, rEQRequisitionEntity.RequisitionNo);
                db.AddInParameter(cmd, "@RequisitionDate", DbType.DateTime, rEQRequisitionEntity.RequisitionDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, rEQRequisitionEntity.Remarks);
                db.AddInParameter(cmd, "@RequisitionStatusID", DbType.Int64, rEQRequisitionEntity.RequisitionStatusID);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, rEQRequisitionEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@IsCashPayment", DbType.Boolean, rEQRequisitionEntity.IsCashPayment);
                db.AddInParameter(cmd, "@IsAccountsMadePayment", DbType.Boolean, rEQRequisitionEntity.IsAccountsMadePayment);
                db.AddInParameter(cmd, "@IsRCS", DbType.Boolean, rEQRequisitionEntity.IsRCS);

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

        IList<Int64> IREQRequisitionDataAccess.Update(IList<REQRequisitionEntity> rEQRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (REQRequisitionEntity rEQRequisitionEntity in rEQRequisitionEntityList)
            {
                returnCode = (this as IREQRequisitionDataAccess).Update(rEQRequisitionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IREQRequisitionDataAccess.Delete(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(rEQRequisitionEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(rEQRequisitionEntity, filterExpression, option);
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

        private Int64 Delete(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

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
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("REQRequisitionEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("REQRequisitionEntity already exists. Please specify another REQRequisitionEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(REQRequisitionEntity rEQRequisitionEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.REQRequisition_SET";

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

        IList<Int64> IREQRequisitionDataAccess.Delete(IList<REQRequisitionEntity> rEQRequisitionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (REQRequisitionEntity rEQRequisitionEntity in rEQRequisitionEntityList)
            {
                returnCode = (this as IREQRequisitionDataAccess).Delete(rEQRequisitionEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<REQRequisitionEntity> IREQRequisitionDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisition_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<REQRequisitionEntity> list = CreateEntityBuilder<REQRequisitionEntity>().BuildEntities(reader);

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

        DataTable IREQRequisitionDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.REQRequisition_GET";

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
