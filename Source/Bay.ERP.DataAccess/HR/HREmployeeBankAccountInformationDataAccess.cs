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
    internal sealed partial class HREmployeeBankAccountInformationDataAccess : BaseDataAccess, IHREmployeeBankAccountInformationDataAccess
    {
        #region Constructors

        public HREmployeeBankAccountInformationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeBankAccountInformationEntity> CreateEntityBuilder<HREmployeeBankAccountInformationEntity>()
        {
            return (new HREmployeeBankAccountInformationBuilder()) as IEntityBuilder<HREmployeeBankAccountInformationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeBankAccountInformationDataAccess.Add(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeBankAccountInformationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeBankAccountInformationEntity, option);
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

        private Int64 Add(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeBankAccountInformationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@BankAccountNo", DbType.String, hREmployeeBankAccountInformationEntity.BankAccountNo);	
                Database.AddInParameter(cmd, "@BankName", DbType.String, hREmployeeBankAccountInformationEntity.BankName);	
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, hREmployeeBankAccountInformationEntity.BankAddress);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, hREmployeeBankAccountInformationEntity.CityID);	
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, hREmployeeBankAccountInformationEntity.ZipCode);	
                Database.AddInParameter(cmd, "@POBox", DbType.Binary, hREmployeeBankAccountInformationEntity.POBox);	
                Database.AddInParameter(cmd, "@BankAccountCategoryID", DbType.Int64, hREmployeeBankAccountInformationEntity.BankAccountCategoryID);	
                Database.AddInParameter(cmd, "@SwipeCode", DbType.String, hREmployeeBankAccountInformationEntity.SwipeCode);	
                Database.AddInParameter(cmd, "@RoutingNo", DbType.String, hREmployeeBankAccountInformationEntity.RoutingNo);	
                Database.AddInParameter(cmd, "@IsSalaryAccotunt", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsSalaryAccotunt);	
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsDefault);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeBankAccountInformationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@BankAccountNo", DbType.String, hREmployeeBankAccountInformationEntity.BankAccountNo);
                db.AddInParameter(cmd, "@BankName", DbType.String, hREmployeeBankAccountInformationEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, hREmployeeBankAccountInformationEntity.BankAddress);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, hREmployeeBankAccountInformationEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, hREmployeeBankAccountInformationEntity.ZipCode);
                db.AddInParameter(cmd, "@POBox", DbType.Binary, hREmployeeBankAccountInformationEntity.POBox);
                db.AddInParameter(cmd, "@BankAccountCategoryID", DbType.Int64, hREmployeeBankAccountInformationEntity.BankAccountCategoryID);
                db.AddInParameter(cmd, "@SwipeCode", DbType.String, hREmployeeBankAccountInformationEntity.SwipeCode);
                db.AddInParameter(cmd, "@RoutingNo", DbType.String, hREmployeeBankAccountInformationEntity.RoutingNo);
                db.AddInParameter(cmd, "@IsSalaryAccotunt", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsSalaryAccotunt);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsDefault);

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

        IList<Int64> IHREmployeeBankAccountInformationDataAccess.Add(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity in hREmployeeBankAccountInformationEntityList)
            {
                returnCode = (this as IHREmployeeBankAccountInformationDataAccess).Add(hREmployeeBankAccountInformationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeBankAccountInformationDataAccess.Update(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeBankAccountInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeBankAccountInformationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeBankAccountInformationID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeBankAccountInformationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@BankAccountNo", DbType.String, hREmployeeBankAccountInformationEntity.BankAccountNo);
                Database.AddInParameter(cmd, "@BankName", DbType.String, hREmployeeBankAccountInformationEntity.BankName);
                Database.AddInParameter(cmd, "@BankAddress", DbType.String, hREmployeeBankAccountInformationEntity.BankAddress);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, hREmployeeBankAccountInformationEntity.CityID);
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, hREmployeeBankAccountInformationEntity.ZipCode);
                Database.AddInParameter(cmd, "@POBox", DbType.Binary, hREmployeeBankAccountInformationEntity.POBox);
                Database.AddInParameter(cmd, "@BankAccountCategoryID", DbType.Int64, hREmployeeBankAccountInformationEntity.BankAccountCategoryID);
                Database.AddInParameter(cmd, "@SwipeCode", DbType.String, hREmployeeBankAccountInformationEntity.SwipeCode);
                Database.AddInParameter(cmd, "@RoutingNo", DbType.String, hREmployeeBankAccountInformationEntity.RoutingNo);
                Database.AddInParameter(cmd, "@IsSalaryAccotunt", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsSalaryAccotunt);
                Database.AddInParameter(cmd, "@IsDefault", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsDefault);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeBankAccountInformationID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeBankAccountInformationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeBankAccountInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@BankAccountNo", DbType.String, hREmployeeBankAccountInformationEntity.BankAccountNo);
                db.AddInParameter(cmd, "@BankName", DbType.String, hREmployeeBankAccountInformationEntity.BankName);
                db.AddInParameter(cmd, "@BankAddress", DbType.String, hREmployeeBankAccountInformationEntity.BankAddress);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, hREmployeeBankAccountInformationEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, hREmployeeBankAccountInformationEntity.ZipCode);
                db.AddInParameter(cmd, "@POBox", DbType.Binary, hREmployeeBankAccountInformationEntity.POBox);
                db.AddInParameter(cmd, "@BankAccountCategoryID", DbType.Int64, hREmployeeBankAccountInformationEntity.BankAccountCategoryID);
                db.AddInParameter(cmd, "@SwipeCode", DbType.String, hREmployeeBankAccountInformationEntity.SwipeCode);
                db.AddInParameter(cmd, "@RoutingNo", DbType.String, hREmployeeBankAccountInformationEntity.RoutingNo);
                db.AddInParameter(cmd, "@IsSalaryAccotunt", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsSalaryAccotunt);
                db.AddInParameter(cmd, "@IsDefault", DbType.Boolean, hREmployeeBankAccountInformationEntity.IsDefault);

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

        IList<Int64> IHREmployeeBankAccountInformationDataAccess.Update(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity in hREmployeeBankAccountInformationEntityList)
            {
                returnCode = (this as IHREmployeeBankAccountInformationDataAccess).Update(hREmployeeBankAccountInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeBankAccountInformationDataAccess.Delete(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeBankAccountInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeBankAccountInformationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

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
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeBankAccountInformationEntity already exists. Please specify another HREmployeeBankAccountInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeBankAccountInformation_SET";

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

        IList<Int64> IHREmployeeBankAccountInformationDataAccess.Delete(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity in hREmployeeBankAccountInformationEntityList)
            {
                returnCode = (this as IHREmployeeBankAccountInformationDataAccess).Delete(hREmployeeBankAccountInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeBankAccountInformationEntity> IHREmployeeBankAccountInformationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeBankAccountInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeBankAccountInformationEntity> list = CreateEntityBuilder<HREmployeeBankAccountInformationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeBankAccountInformationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeBankAccountInformation_GET";

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
