// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    internal sealed partial class APPanelForwardMemberDataAccess : BaseDataAccess, IAPPanelForwardMemberDataAccess
    {
        #region Constructors

        public APPanelForwardMemberDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APPanelForwardMemberEntity> CreateEntityBuilder<APPanelForwardMemberEntity>()
        {
            return (new APPanelForwardMemberBuilder()) as IEntityBuilder<APPanelForwardMemberEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IAPPanelForwardMemberDataAccess.Add(APPanelForwardMemberEntity aPPanelForwardMemberEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aPPanelForwardMemberEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aPPanelForwardMemberEntity, option);
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

        private Int64 Add(APPanelForwardMemberEntity aPPanelForwardMemberEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "APPanelForwardMemberID");

                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelForwardMemberEntity.APPanelID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelForwardMemberEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelForwardMemberEntity.DepartmentID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(APPanelForwardMemberEntity aPPanelForwardMemberEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "APPanelForwardMemberID", db);

                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelForwardMemberEntity.APPanelID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelForwardMemberEntity.EmployeeID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelForwardMemberEntity.DepartmentID);

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

        IList<Int64> IAPPanelForwardMemberDataAccess.Add(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (APPanelForwardMemberEntity aPPanelForwardMemberEntity in aPPanelForwardMemberEntityList)
            {
                returnCode = (this as IAPPanelForwardMemberDataAccess).Add(aPPanelForwardMemberEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IAPPanelForwardMemberDataAccess.Update(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aPPanelForwardMemberEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aPPanelForwardMemberEntity, filterExpression, option);
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

        private Int64 Update(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@APPanelForwardMemberID", DbType.Int64, aPPanelForwardMemberEntity.APPanelForwardMemberID);
                Database.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelForwardMemberEntity.APPanelID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelForwardMemberEntity.EmployeeID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelForwardMemberEntity.DepartmentID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@APPanelForwardMemberID", DbType.Int64, aPPanelForwardMemberEntity.APPanelForwardMemberID);
                db.AddInParameter(cmd, "@APPanelID", DbType.Int64, aPPanelForwardMemberEntity.APPanelID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, aPPanelForwardMemberEntity.EmployeeID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, aPPanelForwardMemberEntity.DepartmentID);

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

        IList<Int64> IAPPanelForwardMemberDataAccess.Update(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (APPanelForwardMemberEntity aPPanelForwardMemberEntity in aPPanelForwardMemberEntityList)
            {
                returnCode = (this as IAPPanelForwardMemberDataAccess).Update(aPPanelForwardMemberEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IAPPanelForwardMemberDataAccess.Delete(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aPPanelForwardMemberEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aPPanelForwardMemberEntity, filterExpression, option);
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

        private Int64 Delete(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

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
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APPanelForwardMemberEntity already exists. Please specify another APPanelForwardMemberEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APPanelForwardMember_SET";

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

        IList<Int64> IAPPanelForwardMemberDataAccess.Delete(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (APPanelForwardMemberEntity aPPanelForwardMemberEntity in aPPanelForwardMemberEntityList)
            {
                returnCode = (this as IAPPanelForwardMemberDataAccess).Delete(aPPanelForwardMemberEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<APPanelForwardMemberEntity> IAPPanelForwardMemberDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APPanelForwardMember_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APPanelForwardMemberEntity> list = CreateEntityBuilder<APPanelForwardMemberEntity>().BuildEntities(reader);

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

        DataTable IAPPanelForwardMemberDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APPanelForwardMember_GET";

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
