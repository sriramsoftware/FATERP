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
    internal sealed partial class HREmployeeConfidentialInfoDataAccess : BaseDataAccess, IHREmployeeConfidentialInfoDataAccess
    {
        #region Constructors

        public HREmployeeConfidentialInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeConfidentialInfoEntity> CreateEntityBuilder<HREmployeeConfidentialInfoEntity>()
        {
            return (new HREmployeeConfidentialInfoBuilder()) as IEntityBuilder<HREmployeeConfidentialInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeConfidentialInfoDataAccess.Add(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeConfidentialInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeConfidentialInfoEntity, option);
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

        private Int64 Add(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeConfidentialInfoID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@NumberofChildren", DbType.Int32, hREmployeeConfidentialInfoEntity.NumberofChildren);	
                Database.AddInParameter(cmd, "@DateofBirth", DbType.DateTime, hREmployeeConfidentialInfoEntity.DateofBirth);	
                Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, hREmployeeConfidentialInfoEntity.MaritalStatusID);	
                Database.AddInParameter(cmd, "@CityofBirth", DbType.String, hREmployeeConfidentialInfoEntity.CityofBirth);	
                Database.AddInParameter(cmd, "@BirthOfStateID", DbType.Int64, hREmployeeConfidentialInfoEntity.BirthOfStateID);	
                Database.AddInParameter(cmd, "@CountryOfBirthCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID);	
                Database.AddInParameter(cmd, "@ResidenceCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.ResidenceCountryID);	
                Database.AddInParameter(cmd, "@PersonlTaxIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber);	
                Database.AddInParameter(cmd, "@NationalIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.NationalIdNumber);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, hREmployeeConfidentialInfoEntity.RegionID);	
                Database.AddInParameter(cmd, "@ReligionID", DbType.Int64, hREmployeeConfidentialInfoEntity.ReligionID);	
                Database.AddInParameter(cmd, "@BirthMark", DbType.String, hREmployeeConfidentialInfoEntity.BirthMark);	
                Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeConfidentialInfoEntity.BloodGroupID);	
                Database.AddInParameter(cmd, "@DisabilityInformation", DbType.String, hREmployeeConfidentialInfoEntity.DisabilityInformation);	
                Database.AddInParameter(cmd, "@GenderID", DbType.Int64, hREmployeeConfidentialInfoEntity.GenderID);	
                Database.AddInParameter(cmd, "@AnniversaryDate", DbType.DateTime, hREmployeeConfidentialInfoEntity.AnniversaryDate);	
                Database.AddInParameter(cmd, "@Height", DbType.String, hREmployeeConfidentialInfoEntity.Height);	
                Database.AddInParameter(cmd, "@Weight", DbType.String, hREmployeeConfidentialInfoEntity.Weight);	
                Database.AddInParameter(cmd, "@CurrentNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID);	
                Database.AddInParameter(cmd, "@PreviousNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID);	
                Database.AddInParameter(cmd, "@HasPassport", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasPassport);	
                Database.AddInParameter(cmd, "@HasDrivingLisence", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasDrivingLisence);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeConfidentialInfoEntity.IsRemoved);
                Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, hREmployeeConfidentialInfoEntity.District);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeConfidentialInfoID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@NumberofChildren", DbType.Int32, hREmployeeConfidentialInfoEntity.NumberofChildren);
                db.AddInParameter(cmd, "@DateofBirth", DbType.DateTime, hREmployeeConfidentialInfoEntity.DateofBirth);
                db.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, hREmployeeConfidentialInfoEntity.MaritalStatusID);
                db.AddInParameter(cmd, "@CityofBirth", DbType.String, hREmployeeConfidentialInfoEntity.CityofBirth);
                db.AddInParameter(cmd, "@BirthOfStateID", DbType.Int64, hREmployeeConfidentialInfoEntity.BirthOfStateID);
                db.AddInParameter(cmd, "@CountryOfBirthCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID);
                db.AddInParameter(cmd, "@ResidenceCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.ResidenceCountryID);
                db.AddInParameter(cmd, "@PersonlTaxIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber);
                db.AddInParameter(cmd, "@NationalIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.NationalIdNumber);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, hREmployeeConfidentialInfoEntity.RegionID);
                db.AddInParameter(cmd, "@ReligionID", DbType.Int64, hREmployeeConfidentialInfoEntity.ReligionID);
                db.AddInParameter(cmd, "@BirthMark", DbType.String, hREmployeeConfidentialInfoEntity.BirthMark);
                db.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeConfidentialInfoEntity.BloodGroupID);
                db.AddInParameter(cmd, "@DisabilityInformation", DbType.String, hREmployeeConfidentialInfoEntity.DisabilityInformation);
                db.AddInParameter(cmd, "@GenderID", DbType.Int64, hREmployeeConfidentialInfoEntity.GenderID);
                db.AddInParameter(cmd, "@AnniversaryDate", DbType.DateTime, hREmployeeConfidentialInfoEntity.AnniversaryDate);
                db.AddInParameter(cmd, "@Height", DbType.String, hREmployeeConfidentialInfoEntity.Height);
                db.AddInParameter(cmd, "@Weight", DbType.String, hREmployeeConfidentialInfoEntity.Weight);
                db.AddInParameter(cmd, "@CurrentNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID);
                db.AddInParameter(cmd, "@PreviousNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID);
                db.AddInParameter(cmd, "@HasPassport", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasPassport);
                db.AddInParameter(cmd, "@HasDrivingLisence", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasDrivingLisence);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeConfidentialInfoEntity.IsRemoved);
                db.AddInParameter(cmd, "@DistrictID", DbType.Int64, hREmployeeConfidentialInfoEntity.District);	

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

        IList<Int64> IHREmployeeConfidentialInfoDataAccess.Add(IList<HREmployeeConfidentialInfoEntity> hREmployeeConfidentialInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity in hREmployeeConfidentialInfoEntityList)
            {
                returnCode = (this as IHREmployeeConfidentialInfoDataAccess).Add(hREmployeeConfidentialInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeConfidentialInfoDataAccess.Update(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeConfidentialInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeConfidentialInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeConfidentialInfoID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeConfidentialInfoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@NumberofChildren", DbType.Int32, hREmployeeConfidentialInfoEntity.NumberofChildren);
                Database.AddInParameter(cmd, "@DateofBirth", DbType.DateTime, hREmployeeConfidentialInfoEntity.DateofBirth);
                Database.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, hREmployeeConfidentialInfoEntity.MaritalStatusID);
                Database.AddInParameter(cmd, "@CityofBirth", DbType.String, hREmployeeConfidentialInfoEntity.CityofBirth);
                Database.AddInParameter(cmd, "@BirthOfStateID", DbType.Int64, hREmployeeConfidentialInfoEntity.BirthOfStateID);
                Database.AddInParameter(cmd, "@CountryOfBirthCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID);
                Database.AddInParameter(cmd, "@ResidenceCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.ResidenceCountryID);
                Database.AddInParameter(cmd, "@PersonlTaxIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber);
                Database.AddInParameter(cmd, "@NationalIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.NationalIdNumber);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, hREmployeeConfidentialInfoEntity.RegionID);
                Database.AddInParameter(cmd, "@ReligionID", DbType.Int64, hREmployeeConfidentialInfoEntity.ReligionID);
                Database.AddInParameter(cmd, "@BirthMark", DbType.String, hREmployeeConfidentialInfoEntity.BirthMark);
                Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeConfidentialInfoEntity.BloodGroupID);
                Database.AddInParameter(cmd, "@DisabilityInformation", DbType.String, hREmployeeConfidentialInfoEntity.DisabilityInformation);
                Database.AddInParameter(cmd, "@GenderID", DbType.Int64, hREmployeeConfidentialInfoEntity.GenderID);
                Database.AddInParameter(cmd, "@AnniversaryDate", DbType.DateTime, hREmployeeConfidentialInfoEntity.AnniversaryDate);
                Database.AddInParameter(cmd, "@Height", DbType.String, hREmployeeConfidentialInfoEntity.Height);
                Database.AddInParameter(cmd, "@Weight", DbType.String, hREmployeeConfidentialInfoEntity.Weight);
                Database.AddInParameter(cmd, "@CurrentNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID);
                Database.AddInParameter(cmd, "@PreviousNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID);
                Database.AddInParameter(cmd, "@HasPassport", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasPassport);
                Database.AddInParameter(cmd, "@HasDrivingLisence", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasDrivingLisence);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeConfidentialInfoEntity.IsRemoved);
                Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, hREmployeeConfidentialInfoEntity.District);	

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeConfidentialInfoID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeConfidentialInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeConfidentialInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@NumberofChildren", DbType.Int32, hREmployeeConfidentialInfoEntity.NumberofChildren);
                db.AddInParameter(cmd, "@DateofBirth", DbType.DateTime, hREmployeeConfidentialInfoEntity.DateofBirth);
                db.AddInParameter(cmd, "@MaritalStatusID", DbType.Int64, hREmployeeConfidentialInfoEntity.MaritalStatusID);
                db.AddInParameter(cmd, "@CityofBirth", DbType.String, hREmployeeConfidentialInfoEntity.CityofBirth);
                db.AddInParameter(cmd, "@BirthOfStateID", DbType.Int64, hREmployeeConfidentialInfoEntity.BirthOfStateID);
                db.AddInParameter(cmd, "@CountryOfBirthCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID);
                db.AddInParameter(cmd, "@ResidenceCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.ResidenceCountryID);
                db.AddInParameter(cmd, "@PersonlTaxIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber);
                db.AddInParameter(cmd, "@NationalIdNumber", DbType.String, hREmployeeConfidentialInfoEntity.NationalIdNumber);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, hREmployeeConfidentialInfoEntity.RegionID);
                db.AddInParameter(cmd, "@ReligionID", DbType.Int64, hREmployeeConfidentialInfoEntity.ReligionID);
                db.AddInParameter(cmd, "@BirthMark", DbType.String, hREmployeeConfidentialInfoEntity.BirthMark);
                db.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeConfidentialInfoEntity.BloodGroupID);
                db.AddInParameter(cmd, "@DisabilityInformation", DbType.String, hREmployeeConfidentialInfoEntity.DisabilityInformation);
                db.AddInParameter(cmd, "@GenderID", DbType.Int64, hREmployeeConfidentialInfoEntity.GenderID);
                db.AddInParameter(cmd, "@AnniversaryDate", DbType.DateTime, hREmployeeConfidentialInfoEntity.AnniversaryDate);
                db.AddInParameter(cmd, "@Height", DbType.String, hREmployeeConfidentialInfoEntity.Height);
                db.AddInParameter(cmd, "@Weight", DbType.String, hREmployeeConfidentialInfoEntity.Weight);
                db.AddInParameter(cmd, "@CurrentNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID);
                db.AddInParameter(cmd, "@PreviousNationalityCountryID", DbType.Int64, hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID);
                db.AddInParameter(cmd, "@HasPassport", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasPassport);
                db.AddInParameter(cmd, "@HasDrivingLisence", DbType.Boolean, hREmployeeConfidentialInfoEntity.HasDrivingLisence);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeConfidentialInfoEntity.IsRemoved);
                db.AddInParameter(cmd, "@DistrictID", DbType.Int64, hREmployeeConfidentialInfoEntity.District);	

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

        IList<Int64> IHREmployeeConfidentialInfoDataAccess.Update(IList<HREmployeeConfidentialInfoEntity> hREmployeeConfidentialInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity in hREmployeeConfidentialInfoEntityList)
            {
                returnCode = (this as IHREmployeeConfidentialInfoDataAccess).Update(hREmployeeConfidentialInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeConfidentialInfoDataAccess.Delete(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeConfidentialInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeConfidentialInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

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
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeConfidentialInfoEntity already exists. Please specify another HREmployeeConfidentialInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeConfidentialInfo_SET";

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

        IList<Int64> IHREmployeeConfidentialInfoDataAccess.Delete(IList<HREmployeeConfidentialInfoEntity> hREmployeeConfidentialInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity in hREmployeeConfidentialInfoEntityList)
            {
                returnCode = (this as IHREmployeeConfidentialInfoDataAccess).Delete(hREmployeeConfidentialInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeConfidentialInfoEntity> IHREmployeeConfidentialInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeConfidentialInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeConfidentialInfoEntity> list = CreateEntityBuilder<HREmployeeConfidentialInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeConfidentialInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeConfidentialInfo_GET";

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
