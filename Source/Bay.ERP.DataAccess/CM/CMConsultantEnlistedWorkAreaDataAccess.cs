// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




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
    internal sealed partial class CMConsultantEnlistedWorkAreaDataAccess : BaseDataAccess, ICMConsultantEnlistedWorkAreaDataAccess
    {
        #region Constructors

        public CMConsultantEnlistedWorkAreaDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMConsultantEnlistedWorkAreaEntity> CreateEntityBuilder<CMConsultantEnlistedWorkAreaEntity>()
        {
            return (new CMConsultantEnlistedWorkAreaBuilder()) as IEntityBuilder<CMConsultantEnlistedWorkAreaEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMConsultantEnlistedWorkAreaDataAccess.Add(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMConsultantEnlistedWorkAreaEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMConsultantEnlistedWorkAreaEntity, option);
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

        private Int64 Add(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ConsultantEnlistedWorkAreaID");

                Database.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantID);	
                Database.AddInParameter(cmd, "@ConsultantWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ConsultantEnlistedWorkAreaID", db);

                db.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantID);
                db.AddInParameter(cmd, "@ConsultantWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID);

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

        IList<Int64> ICMConsultantEnlistedWorkAreaDataAccess.Add(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity in cMConsultantEnlistedWorkAreaEntityList)
            {
                returnCode = (this as ICMConsultantEnlistedWorkAreaDataAccess).Add(cMConsultantEnlistedWorkAreaEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMConsultantEnlistedWorkAreaDataAccess.Update(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMConsultantEnlistedWorkAreaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMConsultantEnlistedWorkAreaEntity, filterExpression, option);
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

        private Int64 Update(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ConsultantEnlistedWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantEnlistedWorkAreaID);
                Database.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantID);
                Database.AddInParameter(cmd, "@ConsultantWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ConsultantEnlistedWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantEnlistedWorkAreaID);
                db.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantID);
                db.AddInParameter(cmd, "@ConsultantWorkAreaID", DbType.Int64, cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID);

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

        IList<Int64> ICMConsultantEnlistedWorkAreaDataAccess.Update(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity in cMConsultantEnlistedWorkAreaEntityList)
            {
                returnCode = (this as ICMConsultantEnlistedWorkAreaDataAccess).Update(cMConsultantEnlistedWorkAreaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMConsultantEnlistedWorkAreaDataAccess.Delete(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMConsultantEnlistedWorkAreaEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMConsultantEnlistedWorkAreaEntity, filterExpression, option);
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

        private Int64 Delete(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

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
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantEnlistedWorkAreaEntity already exists. Please specify another CMConsultantEnlistedWorkAreaEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantEnlistedWorkArea_SET";

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

        IList<Int64> ICMConsultantEnlistedWorkAreaDataAccess.Delete(IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity in cMConsultantEnlistedWorkAreaEntityList)
            {
                returnCode = (this as ICMConsultantEnlistedWorkAreaDataAccess).Delete(cMConsultantEnlistedWorkAreaEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMConsultantEnlistedWorkAreaEntity> ICMConsultantEnlistedWorkAreaDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultantEnlistedWorkArea_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMConsultantEnlistedWorkAreaEntity> list = CreateEntityBuilder<CMConsultantEnlistedWorkAreaEntity>().BuildEntities(reader);

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

        DataTable ICMConsultantEnlistedWorkAreaDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultantEnlistedWorkArea_GET";

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
