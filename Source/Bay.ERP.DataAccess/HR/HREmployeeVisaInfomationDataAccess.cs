// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HREmployeeVisaInfomationDataAccess : BaseDataAccess, IHREmployeeVisaInfomationDataAccess
    {
        #region Constructors

        public HREmployeeVisaInfomationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeVisaInfomationEntity> CreateEntityBuilder<HREmployeeVisaInfomationEntity>()
        {
            return (new HREmployeeVisaInfomationBuilder()) as IEntityBuilder<HREmployeeVisaInfomationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeVisaInfomationDataAccess.Add(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeVisaInfomationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeVisaInfomationEntity, option);
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

        private Int64 Add(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeVisaInfomationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@VisaStatusID", DbType.Int64, hREmployeeVisaInfomationEntity.VisaStatusID);	
                Database.AddInParameter(cmd, "@VisaTransferInfo", DbType.String, hREmployeeVisaInfomationEntity.VisaTransferInfo);	
                Database.AddInParameter(cmd, "@ProfessionInVisa", DbType.String, hREmployeeVisaInfomationEntity.ProfessionInVisa);	
                Database.AddInParameter(cmd, "@VisaNumber", DbType.String, hREmployeeVisaInfomationEntity.VisaNumber);	
                Database.AddInParameter(cmd, "@VisaIssuedDate", DbType.DateTime, hREmployeeVisaInfomationEntity.VisaIssuedDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeVisaInfomationEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeVisaInfomationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeID);
                db.AddInParameter(cmd, "@VisaStatusID", DbType.Int64, hREmployeeVisaInfomationEntity.VisaStatusID);
                db.AddInParameter(cmd, "@VisaTransferInfo", DbType.String, hREmployeeVisaInfomationEntity.VisaTransferInfo);
                db.AddInParameter(cmd, "@ProfessionInVisa", DbType.String, hREmployeeVisaInfomationEntity.ProfessionInVisa);
                db.AddInParameter(cmd, "@VisaNumber", DbType.String, hREmployeeVisaInfomationEntity.VisaNumber);
                db.AddInParameter(cmd, "@VisaIssuedDate", DbType.DateTime, hREmployeeVisaInfomationEntity.VisaIssuedDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeVisaInfomationEntity.Remarks);

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

        IList<Int64> IHREmployeeVisaInfomationDataAccess.Add(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity in hREmployeeVisaInfomationEntityList)
            {
                returnCode = (this as IHREmployeeVisaInfomationDataAccess).Add(hREmployeeVisaInfomationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeVisaInfomationDataAccess.Update(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeVisaInfomationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeVisaInfomationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeVisaInfomationID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeVisaInfomationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@VisaStatusID", DbType.Int64, hREmployeeVisaInfomationEntity.VisaStatusID);
                Database.AddInParameter(cmd, "@VisaTransferInfo", DbType.String, hREmployeeVisaInfomationEntity.VisaTransferInfo);
                Database.AddInParameter(cmd, "@ProfessionInVisa", DbType.String, hREmployeeVisaInfomationEntity.ProfessionInVisa);
                Database.AddInParameter(cmd, "@VisaNumber", DbType.String, hREmployeeVisaInfomationEntity.VisaNumber);
                Database.AddInParameter(cmd, "@VisaIssuedDate", DbType.DateTime, hREmployeeVisaInfomationEntity.VisaIssuedDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeVisaInfomationEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeVisaInfomationID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeVisaInfomationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeVisaInfomationEntity.EmployeeID);
                db.AddInParameter(cmd, "@VisaStatusID", DbType.Int64, hREmployeeVisaInfomationEntity.VisaStatusID);
                db.AddInParameter(cmd, "@VisaTransferInfo", DbType.String, hREmployeeVisaInfomationEntity.VisaTransferInfo);
                db.AddInParameter(cmd, "@ProfessionInVisa", DbType.String, hREmployeeVisaInfomationEntity.ProfessionInVisa);
                db.AddInParameter(cmd, "@VisaNumber", DbType.String, hREmployeeVisaInfomationEntity.VisaNumber);
                db.AddInParameter(cmd, "@VisaIssuedDate", DbType.DateTime, hREmployeeVisaInfomationEntity.VisaIssuedDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeVisaInfomationEntity.Remarks);

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

        IList<Int64> IHREmployeeVisaInfomationDataAccess.Update(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity in hREmployeeVisaInfomationEntityList)
            {
                returnCode = (this as IHREmployeeVisaInfomationDataAccess).Update(hREmployeeVisaInfomationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeVisaInfomationDataAccess.Delete(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeVisaInfomationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeVisaInfomationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

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
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeVisaInfomationEntity already exists. Please specify another HREmployeeVisaInfomationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeVisaInfomation_SET";

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

        IList<Int64> IHREmployeeVisaInfomationDataAccess.Delete(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity in hREmployeeVisaInfomationEntityList)
            {
                returnCode = (this as IHREmployeeVisaInfomationDataAccess).Delete(hREmployeeVisaInfomationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeVisaInfomationEntity> IHREmployeeVisaInfomationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeVisaInfomation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeVisaInfomationEntity> list = CreateEntityBuilder<HREmployeeVisaInfomationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeVisaInfomationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeVisaInfomation_GET";

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
