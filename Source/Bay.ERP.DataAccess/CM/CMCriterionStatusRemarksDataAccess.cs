// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    internal sealed partial class CMCriterionStatusRemarksDataAccess : BaseDataAccess, ICMCriterionStatusRemarksDataAccess
    {
        #region Constructors

        public CMCriterionStatusRemarksDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMCriterionStatusRemarksEntity> CreateEntityBuilder<CMCriterionStatusRemarksEntity>()
        {
            return (new CMCriterionStatusRemarksBuilder()) as IEntityBuilder<CMCriterionStatusRemarksEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMCriterionStatusRemarksDataAccess.Add(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMCriterionStatusRemarksEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMCriterionStatusRemarksEntity, option);
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

        private Int64 Add(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "CriterionStatusRemarksID");

                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorID);	
                Database.AddInParameter(cmd, "@ReferenceCriterionCategoryID", DbType.Int64, cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID);	
                Database.AddInParameter(cmd, "@ContractorCriterionStatusID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorCriterionStatusID);	
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMCriterionStatusRemarksEntity.MemberID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMCriterionStatusRemarksEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "CriterionStatusRemarksID", db);

                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorID);
                db.AddInParameter(cmd, "@ReferenceCriterionCategoryID", DbType.Int64, cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID);
                db.AddInParameter(cmd, "@ContractorCriterionStatusID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorCriterionStatusID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMCriterionStatusRemarksEntity.MemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMCriterionStatusRemarksEntity.Remarks);

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

        IList<Int64> ICMCriterionStatusRemarksDataAccess.Add(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity in cMCriterionStatusRemarksEntityList)
            {
                returnCode = (this as ICMCriterionStatusRemarksDataAccess).Add(cMCriterionStatusRemarksEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMCriterionStatusRemarksDataAccess.Update(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMCriterionStatusRemarksEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMCriterionStatusRemarksEntity, filterExpression, option);
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

        private Int64 Update(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@CriterionStatusRemarksID", DbType.Int64, cMCriterionStatusRemarksEntity.CriterionStatusRemarksID);
                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorID);
                Database.AddInParameter(cmd, "@ReferenceCriterionCategoryID", DbType.Int64, cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID);
                Database.AddInParameter(cmd, "@ContractorCriterionStatusID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorCriterionStatusID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMCriterionStatusRemarksEntity.MemberID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMCriterionStatusRemarksEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@CriterionStatusRemarksID", DbType.Int64, cMCriterionStatusRemarksEntity.CriterionStatusRemarksID);
                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorID);
                db.AddInParameter(cmd, "@ReferenceCriterionCategoryID", DbType.Int64, cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID);
                db.AddInParameter(cmd, "@ContractorCriterionStatusID", DbType.Int64, cMCriterionStatusRemarksEntity.ContractorCriterionStatusID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMCriterionStatusRemarksEntity.MemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMCriterionStatusRemarksEntity.Remarks);

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

        IList<Int64> ICMCriterionStatusRemarksDataAccess.Update(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity in cMCriterionStatusRemarksEntityList)
            {
                returnCode = (this as ICMCriterionStatusRemarksDataAccess).Update(cMCriterionStatusRemarksEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMCriterionStatusRemarksDataAccess.Delete(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMCriterionStatusRemarksEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMCriterionStatusRemarksEntity, filterExpression, option);
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

        private Int64 Delete(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

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
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMCriterionStatusRemarksEntity already exists. Please specify another CMCriterionStatusRemarksEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMCriterionStatusRemarks_SET";

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

        IList<Int64> ICMCriterionStatusRemarksDataAccess.Delete(IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity in cMCriterionStatusRemarksEntityList)
            {
                returnCode = (this as ICMCriterionStatusRemarksDataAccess).Delete(cMCriterionStatusRemarksEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMCriterionStatusRemarksEntity> ICMCriterionStatusRemarksDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMCriterionStatusRemarks_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMCriterionStatusRemarksEntity> list = CreateEntityBuilder<CMCriterionStatusRemarksEntity>().BuildEntities(reader);

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

        DataTable ICMCriterionStatusRemarksDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMCriterionStatusRemarks_GET";

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
