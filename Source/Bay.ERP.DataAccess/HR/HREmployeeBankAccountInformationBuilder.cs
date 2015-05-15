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
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeBankAccountInformationBuilder : IEntityBuilder<HREmployeeBankAccountInformationEntity>
    {
        IList<HREmployeeBankAccountInformationEntity> IEntityBuilder<HREmployeeBankAccountInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeBankAccountInformationEntity> HREmployeeBankAccountInformationEntityList = new List<HREmployeeBankAccountInformationEntity>();

            while (reader.Read())
            {
                HREmployeeBankAccountInformationEntityList.Add(((IEntityBuilder<HREmployeeBankAccountInformationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeBankAccountInformationEntityList.Count > 0) ? HREmployeeBankAccountInformationEntityList : null;
        }

        HREmployeeBankAccountInformationEntity IEntityBuilder<HREmployeeBankAccountInformationEntity>.BuildEntity(IDataReader reader)
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

            HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity = new HREmployeeBankAccountInformationEntity();

            hREmployeeBankAccountInformationEntity.EmployeeBankAccountInformationID = reader.GetInt64(FLD_EMPLOYEEBANKACCOUNTINFORMATIONID);
            hREmployeeBankAccountInformationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeBankAccountInformationEntity.BankAccountNo = reader.GetString(FLD_BANKACCOUNTNO);
            hREmployeeBankAccountInformationEntity.BankName = reader.GetString(FLD_BANKNAME);
            hREmployeeBankAccountInformationEntity.BankAddress = reader.GetString(FLD_BANKADDRESS);
            hREmployeeBankAccountInformationEntity.CityID = reader.GetInt64(FLD_CITYID);
            if (reader.IsDBNull(FLD_ZIPCODE)) { hREmployeeBankAccountInformationEntity.ZipCode = String.Empty; } else { hREmployeeBankAccountInformationEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_POBOX)) { hREmployeeBankAccountInformationEntity.POBox = null; } else { hREmployeeBankAccountInformationEntity.POBox = (byte?[])reader["hREmployeeBankAccountInformationEntity"]; }
            hREmployeeBankAccountInformationEntity.BankAccountCategoryID = reader.GetInt64(FLD_BANKACCOUNTCATEGORYID);
            if (reader.IsDBNull(FLD_SWIPECODE)) { hREmployeeBankAccountInformationEntity.SwipeCode = String.Empty; } else { hREmployeeBankAccountInformationEntity.SwipeCode = reader.GetString(FLD_SWIPECODE); }
            if (reader.IsDBNull(FLD_ROUTINGNO)) { hREmployeeBankAccountInformationEntity.RoutingNo = String.Empty; } else { hREmployeeBankAccountInformationEntity.RoutingNo = reader.GetString(FLD_ROUTINGNO); }
            hREmployeeBankAccountInformationEntity.IsSalaryAccotunt = reader.GetBoolean(FLD_ISSALARYACCOTUNT);
            hREmployeeBankAccountInformationEntity.IsDefault = reader.GetBoolean(FLD_ISDEFAULT);

            return hREmployeeBankAccountInformationEntity;
        }
    }
}
