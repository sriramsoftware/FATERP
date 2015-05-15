// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2013, 03:37:43




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
    internal sealed partial class CRMBuyerBasicInfoDataAccess : BaseDataAccess, ICRMBuyerBasicInfoDataAccess
    {
        #region Constructors

        public CRMBuyerBasicInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMBuyerBasicInfoEntity> CreateEntityBuilder<CRMBuyerBasicInfoEntity>()
        {
            return (new CRMBuyerBasicInfoBuilder()) as IEntityBuilder<CRMBuyerBasicInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMBuyerBasicInfoDataAccess.Add(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMBuyerBasicInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMBuyerBasicInfoEntity, option);
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

        private Int64 Add(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BuyerBasicInfoID");

                Database.AddInParameter(cmd, "@BuyerTypeID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerTypeID);	
                Database.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMBuyerBasicInfoEntity.ContactFullName);	
                Database.AddInParameter(cmd, "@CompanyName", DbType.String, cRMBuyerBasicInfoEntity.CompanyName);	
                Database.AddInParameter(cmd, "@Designation", DbType.String, cRMBuyerBasicInfoEntity.Designation);	
                Database.AddInParameter(cmd, "@InterestedProjectCategoryID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedProjectCategoryID);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMBuyerBasicInfoEntity.MobileNo);	
                Database.AddInParameter(cmd, "@MobileNo2", DbType.String, cRMBuyerBasicInfoEntity.MobileNo2);	
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMBuyerBasicInfoEntity.LandPhone);	
                Database.AddInParameter(cmd, "@LandPhoneOffice", DbType.String, cRMBuyerBasicInfoEntity.LandPhoneOffice);	
                Database.AddInParameter(cmd, "@FaxNumber", DbType.String, cRMBuyerBasicInfoEntity.FaxNumber);	
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMBuyerBasicInfoEntity.PresentAddress);	
                Database.AddInParameter(cmd, "@PresentAddressOffice", DbType.String, cRMBuyerBasicInfoEntity.PresentAddressOffice);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMBuyerBasicInfoEntity.Email);	
                Database.AddInParameter(cmd, "@Email2", DbType.String, cRMBuyerBasicInfoEntity.Email2);	
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerBasicInfoEntity.DOB);	
                Database.AddInParameter(cmd, "@NoOfChildren", DbType.Decimal, cRMBuyerBasicInfoEntity.NoOfChildren);	
                Database.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedLandLocationID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cRMBuyerBasicInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@AreaNeededFrom", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededFrom);	
                Database.AddInParameter(cmd, "@AreaNeededTo", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededTo);	
                Database.AddInParameter(cmd, "@ParkingNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ParkingNeeded);	
                Database.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMBuyerBasicInfoEntity.AreaUnitID);	
                Database.AddInParameter(cmd, "@ToiletNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ToiletNeeded);	
                Database.AddInParameter(cmd, "@UnitNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.UnitNeeded);	
                Database.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMBuyerBasicInfoEntity.AdvertiseWayID);	
                Database.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID);	
                Database.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID);	
                Database.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID);	
                Database.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMBuyerBasicInfoEntity.LeadConversionDate);	
                Database.AddInParameter(cmd, "@ProspectForProject", DbType.Int64, cRMBuyerBasicInfoEntity.ProspectForProject);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMBuyerBasicInfoEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBasicInfoEntity.IP);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBasicInfoEntity.CreateDate);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBasicInfoEntity.ImageUrl);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BuyerBasicInfoID", db);

                db.AddInParameter(cmd, "@BuyerTypeID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerTypeID);
                db.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMBuyerBasicInfoEntity.ContactFullName);
                db.AddInParameter(cmd, "@CompanyName", DbType.String, cRMBuyerBasicInfoEntity.CompanyName);
                db.AddInParameter(cmd, "@Designation", DbType.String, cRMBuyerBasicInfoEntity.Designation);
                db.AddInParameter(cmd, "@InterestedProjectCategoryID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedProjectCategoryID);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMBuyerBasicInfoEntity.MobileNo);
                db.AddInParameter(cmd, "@MobileNo2", DbType.String, cRMBuyerBasicInfoEntity.MobileNo2);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMBuyerBasicInfoEntity.LandPhone);
                db.AddInParameter(cmd, "@LandPhoneOffice", DbType.String, cRMBuyerBasicInfoEntity.LandPhoneOffice);
                db.AddInParameter(cmd, "@FaxNumber", DbType.String, cRMBuyerBasicInfoEntity.FaxNumber);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMBuyerBasicInfoEntity.PresentAddress);
                db.AddInParameter(cmd, "@PresentAddressOffice", DbType.String, cRMBuyerBasicInfoEntity.PresentAddressOffice);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMBuyerBasicInfoEntity.Email);
                db.AddInParameter(cmd, "@Email2", DbType.String, cRMBuyerBasicInfoEntity.Email2);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerBasicInfoEntity.DOB);
                db.AddInParameter(cmd, "@NoOfChildren", DbType.Decimal, cRMBuyerBasicInfoEntity.NoOfChildren);
                db.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedLandLocationID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cRMBuyerBasicInfoEntity.CityID);
                db.AddInParameter(cmd, "@AreaNeededFrom", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededFrom);
                db.AddInParameter(cmd, "@AreaNeededTo", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededTo);
                db.AddInParameter(cmd, "@ParkingNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ParkingNeeded);
                db.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMBuyerBasicInfoEntity.AreaUnitID);
                db.AddInParameter(cmd, "@ToiletNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ToiletNeeded);
                db.AddInParameter(cmd, "@UnitNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.UnitNeeded);
                db.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMBuyerBasicInfoEntity.AdvertiseWayID);
                db.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID);
                db.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMBuyerBasicInfoEntity.LeadConversionDate);
                db.AddInParameter(cmd, "@ProspectForProject", DbType.Int64, cRMBuyerBasicInfoEntity.ProspectForProject);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMBuyerBasicInfoEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBasicInfoEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBasicInfoEntity.CreateDate);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBasicInfoEntity.ImageUrl);

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

        IList<Int64> ICRMBuyerBasicInfoDataAccess.Add(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity in cRMBuyerBasicInfoEntityList)
            {
                returnCode = (this as ICRMBuyerBasicInfoDataAccess).Add(cRMBuyerBasicInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMBuyerBasicInfoDataAccess.Update(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMBuyerBasicInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMBuyerBasicInfoEntity, filterExpression, option);
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

        private Int64 Update(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerBasicInfoID);
                Database.AddInParameter(cmd, "@BuyerTypeID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerTypeID);
                Database.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMBuyerBasicInfoEntity.ContactFullName);
                Database.AddInParameter(cmd, "@CompanyName", DbType.String, cRMBuyerBasicInfoEntity.CompanyName);
                Database.AddInParameter(cmd, "@Designation", DbType.String, cRMBuyerBasicInfoEntity.Designation);
                Database.AddInParameter(cmd, "@InterestedProjectCategoryID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedProjectCategoryID);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMBuyerBasicInfoEntity.MobileNo);
                Database.AddInParameter(cmd, "@MobileNo2", DbType.String, cRMBuyerBasicInfoEntity.MobileNo2);
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMBuyerBasicInfoEntity.LandPhone);
                Database.AddInParameter(cmd, "@LandPhoneOffice", DbType.String, cRMBuyerBasicInfoEntity.LandPhoneOffice);
                Database.AddInParameter(cmd, "@FaxNumber", DbType.String, cRMBuyerBasicInfoEntity.FaxNumber);
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMBuyerBasicInfoEntity.PresentAddress);
                Database.AddInParameter(cmd, "@PresentAddressOffice", DbType.String, cRMBuyerBasicInfoEntity.PresentAddressOffice);
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMBuyerBasicInfoEntity.Email);
                Database.AddInParameter(cmd, "@Email2", DbType.String, cRMBuyerBasicInfoEntity.Email2);
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerBasicInfoEntity.DOB);
                Database.AddInParameter(cmd, "@NoOfChildren", DbType.Decimal, cRMBuyerBasicInfoEntity.NoOfChildren);
                Database.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedLandLocationID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cRMBuyerBasicInfoEntity.CityID);
                Database.AddInParameter(cmd, "@AreaNeededFrom", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededFrom);
                Database.AddInParameter(cmd, "@AreaNeededTo", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededTo);
                Database.AddInParameter(cmd, "@ParkingNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ParkingNeeded);
                Database.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMBuyerBasicInfoEntity.AreaUnitID);
                Database.AddInParameter(cmd, "@ToiletNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ToiletNeeded);
                Database.AddInParameter(cmd, "@UnitNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.UnitNeeded);
                Database.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMBuyerBasicInfoEntity.AdvertiseWayID);
                Database.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID);
                Database.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID);
                Database.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID);
                Database.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMBuyerBasicInfoEntity.LeadConversionDate);
                Database.AddInParameter(cmd, "@ProspectForProject", DbType.Int64, cRMBuyerBasicInfoEntity.ProspectForProject);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMBuyerBasicInfoEntity.Remarks);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBasicInfoEntity.IP);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBasicInfoEntity.CreateDate);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBasicInfoEntity.ImageUrl);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BuyerBasicInfoID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerBasicInfoID);
                db.AddInParameter(cmd, "@BuyerTypeID", DbType.Int64, cRMBuyerBasicInfoEntity.BuyerTypeID);
                db.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMBuyerBasicInfoEntity.ContactFullName);
                db.AddInParameter(cmd, "@CompanyName", DbType.String, cRMBuyerBasicInfoEntity.CompanyName);
                db.AddInParameter(cmd, "@Designation", DbType.String, cRMBuyerBasicInfoEntity.Designation);
                db.AddInParameter(cmd, "@InterestedProjectCategoryID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedProjectCategoryID);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMBuyerBasicInfoEntity.MobileNo);
                db.AddInParameter(cmd, "@MobileNo2", DbType.String, cRMBuyerBasicInfoEntity.MobileNo2);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMBuyerBasicInfoEntity.LandPhone);
                db.AddInParameter(cmd, "@LandPhoneOffice", DbType.String, cRMBuyerBasicInfoEntity.LandPhoneOffice);
                db.AddInParameter(cmd, "@FaxNumber", DbType.String, cRMBuyerBasicInfoEntity.FaxNumber);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMBuyerBasicInfoEntity.PresentAddress);
                db.AddInParameter(cmd, "@PresentAddressOffice", DbType.String, cRMBuyerBasicInfoEntity.PresentAddressOffice);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMBuyerBasicInfoEntity.Email);
                db.AddInParameter(cmd, "@Email2", DbType.String, cRMBuyerBasicInfoEntity.Email2);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, cRMBuyerBasicInfoEntity.DOB);
                db.AddInParameter(cmd, "@NoOfChildren", DbType.Decimal, cRMBuyerBasicInfoEntity.NoOfChildren);
                db.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMBuyerBasicInfoEntity.InterestedLandLocationID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cRMBuyerBasicInfoEntity.CityID);
                db.AddInParameter(cmd, "@AreaNeededFrom", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededFrom);
                db.AddInParameter(cmd, "@AreaNeededTo", DbType.Decimal, cRMBuyerBasicInfoEntity.AreaNeededTo);
                db.AddInParameter(cmd, "@ParkingNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ParkingNeeded);
                db.AddInParameter(cmd, "@AreaUnitID", DbType.Int64, cRMBuyerBasicInfoEntity.AreaUnitID);
                db.AddInParameter(cmd, "@ToiletNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.ToiletNeeded);
                db.AddInParameter(cmd, "@UnitNeeded", DbType.Decimal, cRMBuyerBasicInfoEntity.UnitNeeded);
                db.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMBuyerBasicInfoEntity.AdvertiseWayID);
                db.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID);
                db.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMBuyerBasicInfoEntity.LeadConversionDate);
                db.AddInParameter(cmd, "@ProspectForProject", DbType.Int64, cRMBuyerBasicInfoEntity.ProspectForProject);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMBuyerBasicInfoEntity.Remarks);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBasicInfoEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBasicInfoEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBasicInfoEntity.CreateDate);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBasicInfoEntity.ImageUrl);

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

        IList<Int64> ICRMBuyerBasicInfoDataAccess.Update(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity in cRMBuyerBasicInfoEntityList)
            {
                returnCode = (this as ICRMBuyerBasicInfoDataAccess).Update(cRMBuyerBasicInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMBuyerBasicInfoDataAccess.Delete(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMBuyerBasicInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMBuyerBasicInfoEntity, filterExpression, option);
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

        private Int64 Delete(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

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
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBasicInfoEntity already exists. Please specify another CRMBuyerBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBasicInfo_SET";

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

        IList<Int64> ICRMBuyerBasicInfoDataAccess.Delete(IList<CRMBuyerBasicInfoEntity> cRMBuyerBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity in cRMBuyerBasicInfoEntityList)
            {
                returnCode = (this as ICRMBuyerBasicInfoDataAccess).Delete(cRMBuyerBasicInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMBuyerBasicInfoEntity> ICRMBuyerBasicInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerBasicInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMBuyerBasicInfoEntity> list = CreateEntityBuilder<CRMBuyerBasicInfoEntity>().BuildEntities(reader);

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

        DataTable ICRMBuyerBasicInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerBasicInfo_GET";

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
