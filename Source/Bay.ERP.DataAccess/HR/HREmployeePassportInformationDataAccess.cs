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
    internal sealed partial class HREmployeePassportInformationDataAccess : BaseDataAccess, IHREmployeePassportInformationDataAccess
    {
        #region Constructors

        public HREmployeePassportInformationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeePassportInformationEntity> CreateEntityBuilder<HREmployeePassportInformationEntity>()
        {
            return (new HREmployeePassportInformationBuilder()) as IEntityBuilder<HREmployeePassportInformationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeePassportInformationDataAccess.Add(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeePassportInformationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeePassportInformationEntity, option);
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

        private Int64 Add(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeePassportInformationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePassportInformationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@PassportCountry", DbType.Int64, hREmployeePassportInformationEntity.PassportCountry);	
                Database.AddInParameter(cmd, "@CityName", DbType.String, hREmployeePassportInformationEntity.CityName);	
                Database.AddInParameter(cmd, "@PassportNumber", DbType.String, hREmployeePassportInformationEntity.PassportNumber);	
                Database.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeePassportInformationEntity.IssuedDate);	
                Database.AddInParameter(cmd, "@ExpireDate", DbType.DateTime, hREmployeePassportInformationEntity.ExpireDate);	
                Database.AddInParameter(cmd, "@PassportProfession", DbType.String, hREmployeePassportInformationEntity.PassportProfession);	
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeePassportInformationEntity.Note);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeePassportInformationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePassportInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@PassportCountry", DbType.Int64, hREmployeePassportInformationEntity.PassportCountry);
                db.AddInParameter(cmd, "@CityName", DbType.String, hREmployeePassportInformationEntity.CityName);
                db.AddInParameter(cmd, "@PassportNumber", DbType.String, hREmployeePassportInformationEntity.PassportNumber);
                db.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeePassportInformationEntity.IssuedDate);
                db.AddInParameter(cmd, "@ExpireDate", DbType.DateTime, hREmployeePassportInformationEntity.ExpireDate);
                db.AddInParameter(cmd, "@PassportProfession", DbType.String, hREmployeePassportInformationEntity.PassportProfession);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeePassportInformationEntity.Note);

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

        IList<Int64> IHREmployeePassportInformationDataAccess.Add(IList<HREmployeePassportInformationEntity> hREmployeePassportInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeePassportInformationEntity hREmployeePassportInformationEntity in hREmployeePassportInformationEntityList)
            {
                returnCode = (this as IHREmployeePassportInformationDataAccess).Add(hREmployeePassportInformationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeePassportInformationDataAccess.Update(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeePassportInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeePassportInformationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeePassportInformationID", DbType.Int64, hREmployeePassportInformationEntity.EmployeePassportInformationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePassportInformationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@PassportCountry", DbType.Int64, hREmployeePassportInformationEntity.PassportCountry);
                Database.AddInParameter(cmd, "@CityName", DbType.String, hREmployeePassportInformationEntity.CityName);
                Database.AddInParameter(cmd, "@PassportNumber", DbType.String, hREmployeePassportInformationEntity.PassportNumber);
                Database.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeePassportInformationEntity.IssuedDate);
                Database.AddInParameter(cmd, "@ExpireDate", DbType.DateTime, hREmployeePassportInformationEntity.ExpireDate);
                Database.AddInParameter(cmd, "@PassportProfession", DbType.String, hREmployeePassportInformationEntity.PassportProfession);
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeePassportInformationEntity.Note);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeePassportInformationID", DbType.Int64, hREmployeePassportInformationEntity.EmployeePassportInformationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeePassportInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@PassportCountry", DbType.Int64, hREmployeePassportInformationEntity.PassportCountry);
                db.AddInParameter(cmd, "@CityName", DbType.String, hREmployeePassportInformationEntity.CityName);
                db.AddInParameter(cmd, "@PassportNumber", DbType.String, hREmployeePassportInformationEntity.PassportNumber);
                db.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeePassportInformationEntity.IssuedDate);
                db.AddInParameter(cmd, "@ExpireDate", DbType.DateTime, hREmployeePassportInformationEntity.ExpireDate);
                db.AddInParameter(cmd, "@PassportProfession", DbType.String, hREmployeePassportInformationEntity.PassportProfession);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeePassportInformationEntity.Note);

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

        IList<Int64> IHREmployeePassportInformationDataAccess.Update(IList<HREmployeePassportInformationEntity> hREmployeePassportInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeePassportInformationEntity hREmployeePassportInformationEntity in hREmployeePassportInformationEntityList)
            {
                returnCode = (this as IHREmployeePassportInformationDataAccess).Update(hREmployeePassportInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeePassportInformationDataAccess.Delete(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeePassportInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeePassportInformationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

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
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeePassportInformationEntity already exists. Please specify another HREmployeePassportInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeePassportInformationEntity hREmployeePassportInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeePassportInformation_SET";

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

        IList<Int64> IHREmployeePassportInformationDataAccess.Delete(IList<HREmployeePassportInformationEntity> hREmployeePassportInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeePassportInformationEntity hREmployeePassportInformationEntity in hREmployeePassportInformationEntityList)
            {
                returnCode = (this as IHREmployeePassportInformationDataAccess).Delete(hREmployeePassportInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeePassportInformationEntity> IHREmployeePassportInformationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeePassportInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeePassportInformationEntity> list = CreateEntityBuilder<HREmployeePassportInformationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeePassportInformationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeePassportInformation_GET";

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
