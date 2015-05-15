// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    internal sealed partial class PRMBOQDataAccess : BaseDataAccess, IPRMBOQDataAccess
    {
        #region Constructors

        public PRMBOQDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQEntity> CreateEntityBuilder<PRMBOQEntity>()
        {
            return (new PRMBOQBuilder()) as IEntityBuilder<PRMBOQEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMBOQDataAccess.Add(PRMBOQEntity pRMBOQEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMBOQEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMBOQEntity, option);
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

        private Int64 Add(PRMBOQEntity pRMBOQEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BOQID");

                Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMBOQEntity.PreBOQID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMBOQEntity.ProjectID);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMBOQEntity.StartDate);	
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMBOQEntity.PreparedByMemberID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQEntity.Remarks);	
                Database.AddInParameter(cmd, "@BOQStatusID", DbType.Int64, pRMBOQEntity.BOQStatusID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMBOQEntity pRMBOQEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BOQID", db);

                db.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMBOQEntity.PreBOQID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMBOQEntity.ProjectID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMBOQEntity.StartDate);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMBOQEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQEntity.Remarks);
                db.AddInParameter(cmd, "@BOQStatusID", DbType.Int64, pRMBOQEntity.BOQStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQEntity.IsRemoved);

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

        IList<Int64> IPRMBOQDataAccess.Add(IList<PRMBOQEntity> pRMBOQEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMBOQEntity pRMBOQEntity in pRMBOQEntityList)
            {
                returnCode = (this as IPRMBOQDataAccess).Add(pRMBOQEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMBOQDataAccess.Update(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMBOQEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMBOQEntity, filterExpression, option);
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

        private Int64 Update(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQEntity.BOQID);
                Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMBOQEntity.PreBOQID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMBOQEntity.ProjectID);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMBOQEntity.StartDate);
                Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMBOQEntity.PreparedByMemberID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQEntity.Remarks);
                Database.AddInParameter(cmd, "@BOQStatusID", DbType.Int64, pRMBOQEntity.BOQStatusID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQEntity.BOQID);
                db.AddInParameter(cmd, "@PreBOQID", DbType.Int64, pRMBOQEntity.PreBOQID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, pRMBOQEntity.ProjectID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, pRMBOQEntity.StartDate);
                db.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, pRMBOQEntity.PreparedByMemberID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQEntity.Remarks);
                db.AddInParameter(cmd, "@BOQStatusID", DbType.Int64, pRMBOQEntity.BOQStatusID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQEntity.IsRemoved);

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

        IList<Int64> IPRMBOQDataAccess.Update(IList<PRMBOQEntity> pRMBOQEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMBOQEntity pRMBOQEntity in pRMBOQEntityList)
            {
                returnCode = (this as IPRMBOQDataAccess).Update(pRMBOQEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMBOQDataAccess.Delete(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMBOQEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMBOQEntity, filterExpression, option);
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

        private Int64 Delete(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

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
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQEntity already exists. Please specify another PRMBOQEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMBOQEntity pRMBOQEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQ_SET";

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

        IList<Int64> IPRMBOQDataAccess.Delete(IList<PRMBOQEntity> pRMBOQEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMBOQEntity pRMBOQEntity in pRMBOQEntityList)
            {
                returnCode = (this as IPRMBOQDataAccess).Delete(pRMBOQEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMBOQEntity> IPRMBOQDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQ_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQEntity> list = CreateEntityBuilder<PRMBOQEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQ_GET";

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
