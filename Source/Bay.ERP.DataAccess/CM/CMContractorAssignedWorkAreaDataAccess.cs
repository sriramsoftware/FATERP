// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




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
    internal sealed partial class CMContractorAssignedWorkAreaDataAccess : BaseDataAccess, ICMContractorAssignedWorkAreaDataAccess
    {
        #region Constructors

        public CMContractorAssignedWorkAreaDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMContractorAssignedWorkAreaEntity> CreateEntityBuilder<CMContractorAssignedWorkAreaEntity>()
        {
            return (new CMContractorAssignedWorkAreaBuilder()) as IEntityBuilder<CMContractorAssignedWorkAreaEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMContractorAssignedWorkAreaDataAccess.Add(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMContractorAssignedWorkAreaEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMContractorAssignedWorkAreaEntity, option);
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

        private Int64 Add(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ContractorAssignedWorkAreaID");

                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ProjectID);	
                Database.AddInParameter(cmd, "@WorkDescription", DbType.String, cMContractorAssignedWorkAreaEntity.WorkDescription);	
                Database.AddInParameter(cmd, "@WorkAreaStatusID", DbType.Int64, cMContractorAssignedWorkAreaEntity.WorkAreaStatusID);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.StartDate);	
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.EndDate);	
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualStartDate);	
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualEndDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMContractorAssignedWorkAreaEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ContractorAssignedWorkAreaID", db);

                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ProjectID);
                db.AddInParameter(cmd, "@WorkDescription", DbType.String, cMContractorAssignedWorkAreaEntity.WorkDescription);
                db.AddInParameter(cmd, "@WorkAreaStatusID", DbType.Int64, cMContractorAssignedWorkAreaEntity.WorkAreaStatusID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.EndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualEndDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMContractorAssignedWorkAreaEntity.Remarks);

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

        IList<Int64> ICMContractorAssignedWorkAreaDataAccess.Add(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity in cMContractorAssignedWorkAreaEntityList)
            {
                returnCode = (this as ICMContractorAssignedWorkAreaDataAccess).Add(cMContractorAssignedWorkAreaEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMContractorAssignedWorkAreaDataAccess.Update(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMContractorAssignedWorkAreaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMContractorAssignedWorkAreaEntity, filterExpression, option);
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

        private Int64 Update(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ContractorAssignedWorkAreaID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorAssignedWorkAreaID);
                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ProjectID);
                Database.AddInParameter(cmd, "@WorkDescription", DbType.String, cMContractorAssignedWorkAreaEntity.WorkDescription);
                Database.AddInParameter(cmd, "@WorkAreaStatusID", DbType.Int64, cMContractorAssignedWorkAreaEntity.WorkAreaStatusID);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.StartDate);
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.EndDate);
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualStartDate);
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualEndDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMContractorAssignedWorkAreaEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ContractorAssignedWorkAreaID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorAssignedWorkAreaID);
                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ContractorID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cMContractorAssignedWorkAreaEntity.ProjectID);
                db.AddInParameter(cmd, "@WorkDescription", DbType.String, cMContractorAssignedWorkAreaEntity.WorkDescription);
                db.AddInParameter(cmd, "@WorkAreaStatusID", DbType.Int64, cMContractorAssignedWorkAreaEntity.WorkAreaStatusID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.EndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, cMContractorAssignedWorkAreaEntity.ActualEndDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMContractorAssignedWorkAreaEntity.Remarks);

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

        IList<Int64> ICMContractorAssignedWorkAreaDataAccess.Update(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity in cMContractorAssignedWorkAreaEntityList)
            {
                returnCode = (this as ICMContractorAssignedWorkAreaDataAccess).Update(cMContractorAssignedWorkAreaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMContractorAssignedWorkAreaDataAccess.Delete(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMContractorAssignedWorkAreaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMContractorAssignedWorkAreaEntity, filterExpression, option);
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

        private Int64 Delete(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

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
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorAssignedWorkAreaEntity already exists. Please specify another CMContractorAssignedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorAssignedWorkArea_SET";

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

        IList<Int64> ICMContractorAssignedWorkAreaDataAccess.Delete(IList<CMContractorAssignedWorkAreaEntity> cMContractorAssignedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity in cMContractorAssignedWorkAreaEntityList)
            {
                returnCode = (this as ICMContractorAssignedWorkAreaDataAccess).Delete(cMContractorAssignedWorkAreaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMContractorAssignedWorkAreaEntity> ICMContractorAssignedWorkAreaDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractorAssignedWorkArea_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMContractorAssignedWorkAreaEntity> list = CreateEntityBuilder<CMContractorAssignedWorkAreaEntity>().BuildEntities(reader);

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

        DataTable ICMContractorAssignedWorkAreaDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractorAssignedWorkArea_GET";

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
