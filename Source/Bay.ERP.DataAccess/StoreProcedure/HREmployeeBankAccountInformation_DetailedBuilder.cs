// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeBankAccountInformation_DetailedBuilder : IEntityBuilder<HREmployeeBankAccountInformation_DetailedEntity>
    {
        IList<HREmployeeBankAccountInformation_DetailedEntity> IEntityBuilder<HREmployeeBankAccountInformation_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeBankAccountInformation_DetailedEntity> HREmployeeBankAccountInformation_DetailedEntityList = new List<HREmployeeBankAccountInformation_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeBankAccountInformation_DetailedEntityList.Add(((IEntityBuilder<HREmployeeBankAccountInformation_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeBankAccountInformation_DetailedEntityList.Count > 0) ? HREmployeeBankAccountInformation_DetailedEntityList : null;
        }

        HREmployeeBankAccountInformation_DetailedEntity IEntityBuilder<HREmployeeBankAccountInformation_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEBANKACCOUNTINFORMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_BANKACCOUNTNO = 2;
            const Int32 FLD_BANKNAME = 3;
            const Int32 FLD_BANKADDRESS = 4;
            const Int32 FLD_CITYID = 5;
            const Int32 FLD_ZIPCODE = 6;
            const Int32 FLD_POBOX = 7;
            const Int32 FLD_BANKACCOUNTCATEGORYID = 8;
            const Int32 FLD_SWIPECODE = 9;
            const Int32 FLD_ROUTINGNO = 10;
            const Int32 FLD_ISSALARYACCOTUNT = 11;
            const Int32 FLD_ISDEFAULT = 12;
            const Int32 FLD_EMPLOYEEFULLNAME = 13;
            const Int32 FLD_CITYNAME = 14;
            const Int32 FLD_BANKACCOUNTCATEGORYNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            HREmployeeBankAccountInformation_DetailedEntity hREmployeeBankAccountInformation_DetailedEntity = new HREmployeeBankAccountInformation_DetailedEntity();

            hREmployeeBankAccountInformation_DetailedEntity.EmployeeBankAccountInformationID = reader.GetInt64(FLD_EMPLOYEEBANKACCOUNTINFORMATIONID);
            hREmployeeBankAccountInformation_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeBankAccountInformation_DetailedEntity.BankAccountNo = reader.GetString(FLD_BANKACCOUNTNO);
            hREmployeeBankAccountInformation_DetailedEntity.BankName = reader.GetString(FLD_BANKNAME);
            hREmployeeBankAccountInformation_DetailedEntity.BankAddress = reader.GetString(FLD_BANKADDRESS);
            hREmployeeBankAccountInformation_DetailedEntity.CityID = reader.GetInt64(FLD_CITYID);
            if (reader.IsDBNull(FLD_ZIPCODE)) { hREmployeeBankAccountInformation_DetailedEntity.ZipCode = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_POBOX)) { hREmployeeBankAccountInformation_DetailedEntity.POBox = null; } else { hREmployeeBankAccountInformation_DetailedEntity.POBox = (byte?[])reader["hREmployeeBankAccountInformation_DetailedEntity"]; }
            hREmployeeBankAccountInformation_DetailedEntity.BankAccountCategoryID = reader.GetInt64(FLD_BANKACCOUNTCATEGORYID);
            if (reader.IsDBNull(FLD_SWIPECODE)) { hREmployeeBankAccountInformation_DetailedEntity.SwipeCode = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.SwipeCode = reader.GetString(FLD_SWIPECODE); }
            if (reader.IsDBNull(FLD_ROUTINGNO)) { hREmployeeBankAccountInformation_DetailedEntity.RoutingNo = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.RoutingNo = reader.GetString(FLD_ROUTINGNO); }
            hREmployeeBankAccountInformation_DetailedEntity.IsSalaryAccotunt = reader.GetBoolean(FLD_ISSALARYACCOTUNT);
            hREmployeeBankAccountInformation_DetailedEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeBankAccountInformation_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_CITYNAME)) { hREmployeeBankAccountInformation_DetailedEntity.CityName = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.CityName = reader.GetString(FLD_CITYNAME); }
            if (reader.IsDBNull(FLD_BANKACCOUNTCATEGORYNAME)) { hREmployeeBankAccountInformation_DetailedEntity.BankAccountCategoryName = String.Empty; } else { hREmployeeBankAccountInformation_DetailedEntity.BankAccountCategoryName = reader.GetString(FLD_BANKACCOUNTCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeBankAccountInformation_DetailedEntity.RowNumber = null; } else { hREmployeeBankAccountInformation_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeBankAccountInformation_DetailedEntity;
        }
    }
}
