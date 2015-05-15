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
    internal sealed partial class HREmployeeEmergencyContactInfoDataAccess : BaseDataAccess, IHREmployeeEmergencyContactInfoDataAccess
    {
        #region Constructors

        public HREmployeeEmergencyContactInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEmergencyContactInfoEntity> CreateEntityBuilder<HREmployeeEmergencyContactInfoEntity>()
        {
            return (new HREmployeeEmergencyContactInfoBuilder()) as IEntityBuilder<HREmployeeEmergencyContactInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeEmergencyContactInfoDataAccess.Add(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeEmergencyContactInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeEmergencyContactInfoEntity, option);
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

        private Int64 Add(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEmergencyContactInfoID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeEmergencyContactInfoEntity.FirstName);	
                Database.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeEmergencyContactInfoEntity.MiddleName);	
                Database.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeEmergencyContactInfoEntity.LastName);	
                Database.AddInParameter(cmd, "@HomePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.HomePhoneNumber);
                Database.AddInParameter(cmd, "@MobilePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber);	
                Database.AddInParameter(cmd, "@RelationShip", DbType.String, hREmployeeEmergencyContactInfoEntity.RelationShip);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeEmergencyContactInfoID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeEmergencyContactInfoEntity.FirstName);
                db.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeEmergencyContactInfoEntity.MiddleName);
                db.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeEmergencyContactInfoEntity.LastName);
                db.AddInParameter(cmd, "@HomePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.HomePhoneNumber);
                db.AddInParameter(cmd, "@MobilePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber);
                db.AddInParameter(cmd, "@RelationShip", DbType.String, hREmployeeEmergencyContactInfoEntity.RelationShip);

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

        IList<Int64> IHREmployeeEmergencyContactInfoDataAccess.Add(IList<HREmployeeEmergencyContactInfoEntity> hREmployeeEmergencyContactInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity in hREmployeeEmergencyContactInfoEntityList)
            {
                returnCode = (this as IHREmployeeEmergencyContactInfoDataAccess).Add(hREmployeeEmergencyContactInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeEmergencyContactInfoDataAccess.Update(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeEmergencyContactInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeEmergencyContactInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeEmergencyContactInfoID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeEmergencyContactInfoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeEmergencyContactInfoEntity.FirstName);
                Database.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeEmergencyContactInfoEntity.MiddleName);
                Database.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeEmergencyContactInfoEntity.LastName);
                Database.AddInParameter(cmd, "@HomePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.HomePhoneNumber);
                Database.AddInParameter(cmd, "@MobilePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber);
                Database.AddInParameter(cmd, "@RelationShip", DbType.String, hREmployeeEmergencyContactInfoEntity.RelationShip);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeEmergencyContactInfoID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeEmergencyContactInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEmergencyContactInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeEmergencyContactInfoEntity.FirstName);
                db.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeEmergencyContactInfoEntity.MiddleName);
                db.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeEmergencyContactInfoEntity.LastName);
                db.AddInParameter(cmd, "@HomePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.HomePhoneNumber);
                db.AddInParameter(cmd, "@MobilePhoneNumber", DbType.String, hREmployeeEmergencyContactInfoEntity.MobilePhoneNumber);
                db.AddInParameter(cmd, "@RelationShip", DbType.String, hREmployeeEmergencyContactInfoEntity.RelationShip);

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

        IList<Int64> IHREmployeeEmergencyContactInfoDataAccess.Update(IList<HREmployeeEmergencyContactInfoEntity> hREmployeeEmergencyContactInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity in hREmployeeEmergencyContactInfoEntityList)
            {
                returnCode = (this as IHREmployeeEmergencyContactInfoDataAccess).Update(hREmployeeEmergencyContactInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeEmergencyContactInfoDataAccess.Delete(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeEmergencyContactInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeEmergencyContactInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

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
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEmergencyContactInfoEntity already exists. Please specify another HREmployeeEmergencyContactInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeEmergencyContactInfo_SET";

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

        IList<Int64> IHREmployeeEmergencyContactInfoDataAccess.Delete(IList<HREmployeeEmergencyContactInfoEntity> hREmployeeEmergencyContactInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeEmergencyContactInfoEntity hREmployeeEmergencyContactInfoEntity in hREmployeeEmergencyContactInfoEntityList)
            {
                returnCode = (this as IHREmployeeEmergencyContactInfoDataAccess).Delete(hREmployeeEmergencyContactInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeEmergencyContactInfoEntity> IHREmployeeEmergencyContactInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEmergencyContactInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEmergencyContactInfoEntity> list = CreateEntityBuilder<HREmployeeEmergencyContactInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeEmergencyContactInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeEmergencyContactInfo_GET";

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
