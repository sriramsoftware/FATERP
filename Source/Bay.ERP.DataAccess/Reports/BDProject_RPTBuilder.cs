// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 09:58:11




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProject_RPTBuilder : IEntityBuilder<BDProject_RPTEntity>
    {
        IList<BDProject_RPTEntity> IEntityBuilder<BDProject_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProject_RPTEntity> BDProject_RPTEntityList = new List<BDProject_RPTEntity>();

            while (reader.Read())
            {
                BDProject_RPTEntityList.Add(((IEntityBuilder<BDProject_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProject_RPTEntityList.Count > 0) ? BDProject_RPTEntityList : null;
        }

        BDProject_RPTEntity IEntityBuilder<BDProject_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_LANDAREAKATHA = 3;
            const Int32 FLD_LANDAREASFT = 4;
            const Int32 FLD_NOOFSTORIED = 5;
            const Int32 FLD_NOOFBASEMENT = 6;
            const Int32 FLD_DESCRIPTION = 7;
            const Int32 FLD_CLIENTPERCENTAGE = 8;
            const Int32 FLD_COMPANYPERCENTAGE = 9;
            const Int32 FLD_PROJECTSTATUSID = 10;
            const Int32 FLD_ISREMOVED = 11;
            const Int32 FLD_PROJECTADDRESSINFOID = 12;
            const Int32 FLD_ADDRESSLINE1 = 13;
            const Int32 FLD_ADDRESSLINE2 = 14;
            const Int32 FLD_COUNTRYID = 15;
            const Int32 FLD_CITYID = 16;
            const Int32 FLD_ZIPCODE = 17;
            const Int32 FLD_COUNTRY = 18;
            const Int32 FLD_CITY = 19;
            const Int32 FLD_PROJECTOTHERINFOID = 20;
            const Int32 FLD_TBA = 21;
            const Int32 FLD_TBAUNITID = 22;
            const Int32 FLD_FAR = 23;
            const Int32 FLD_FIA = 24;
            const Int32 FLD_FIAUNITID = 25;
            const Int32 FLD_GSA = 26;
            const Int32 FLD_GSAUNITID = 27;
            const Int32 FLD_GROUNDCOVERAGE = 28;
            const Int32 FLD_DATEOFAGREEMENT = 29;
            const Int32 FLD_DATEOFHANDOVER = 30;
            const Int32 FLD_DELAYCLAUSE = 31;
            const Int32 FLD_TBAUNIT = 32;
            const Int32 FLD_FIAUNIT = 33;
            const Int32 FLD_GSAUNIT = 34;
            const Int32 FLD_PROJECTSTATUS = 35;

            BDProject_RPTEntity bDProject_RPTEntity = new BDProject_RPTEntity();

            bDProject_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProject_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProject_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProject_RPTEntity.LandAreaKatha = null; } else { bDProject_RPTEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProject_RPTEntity.LandAreaSft = null; } else { bDProject_RPTEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProject_RPTEntity.NoOfStoried = null; } else { bDProject_RPTEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProject_RPTEntity.NoOfBasement = null; } else { bDProject_RPTEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProject_RPTEntity.Description = String.Empty; } else { bDProject_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProject_RPTEntity.ClientPercentage = null; } else { bDProject_RPTEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProject_RPTEntity.CompanyPercentage = null; } else { bDProject_RPTEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProject_RPTEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            bDProject_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PROJECTADDRESSINFOID)) { bDProject_RPTEntity.ProjectAddressInfoID = null; } else { bDProject_RPTEntity.ProjectAddressInfoID = reader.GetInt64(FLD_PROJECTADDRESSINFOID); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { bDProject_RPTEntity.AddressLine1 = String.Empty; } else { bDProject_RPTEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { bDProject_RPTEntity.AddressLine2 = String.Empty; } else { bDProject_RPTEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_COUNTRYID)) { bDProject_RPTEntity.CountryID = null; } else { bDProject_RPTEntity.CountryID = reader.GetInt64(FLD_COUNTRYID); }
            if (reader.IsDBNull(FLD_CITYID)) { bDProject_RPTEntity.CityID = null; } else { bDProject_RPTEntity.CityID = reader.GetInt64(FLD_CITYID); }
            if (reader.IsDBNull(FLD_ZIPCODE)) { bDProject_RPTEntity.ZipCode = String.Empty; } else { bDProject_RPTEntity.ZipCode = reader.GetString(FLD_ZIPCODE); }
            if (reader.IsDBNull(FLD_COUNTRY)) { bDProject_RPTEntity.Country = String.Empty; } else { bDProject_RPTEntity.Country = reader.GetString(FLD_COUNTRY); }
            if (reader.IsDBNull(FLD_CITY)) { bDProject_RPTEntity.City = String.Empty; } else { bDProject_RPTEntity.City = reader.GetString(FLD_CITY); }
            if (reader.IsDBNull(FLD_PROJECTOTHERINFOID)) { bDProject_RPTEntity.ProjectOtherInfoID = null; } else { bDProject_RPTEntity.ProjectOtherInfoID = reader.GetInt64(FLD_PROJECTOTHERINFOID); }
            if (reader.IsDBNull(FLD_TBA)) { bDProject_RPTEntity.TBA = null; } else { bDProject_RPTEntity.TBA = reader.GetDecimal(FLD_TBA); }
            if (reader.IsDBNull(FLD_TBAUNITID)) { bDProject_RPTEntity.TBAUnitID = null; } else { bDProject_RPTEntity.TBAUnitID = reader.GetInt64(FLD_TBAUNITID); }
            if (reader.IsDBNull(FLD_FAR)) { bDProject_RPTEntity.FAR = null; } else { bDProject_RPTEntity.FAR = reader.GetDecimal(FLD_FAR); }
            if (reader.IsDBNull(FLD_FIA)) { bDProject_RPTEntity.FIA = null; } else { bDProject_RPTEntity.FIA = reader.GetDecimal(FLD_FIA); }
            if (reader.IsDBNull(FLD_FIAUNITID)) { bDProject_RPTEntity.FIAUnitID = null; } else { bDProject_RPTEntity.FIAUnitID = reader.GetInt64(FLD_FIAUNITID); }
            if (reader.IsDBNull(FLD_GSA)) { bDProject_RPTEntity.GSA = null; } else { bDProject_RPTEntity.GSA = reader.GetDecimal(FLD_GSA); }
            if (reader.IsDBNull(FLD_GSAUNITID)) { bDProject_RPTEntity.GSAUnitID = null; } else { bDProject_RPTEntity.GSAUnitID = reader.GetInt64(FLD_GSAUNITID); }
            if (reader.IsDBNull(FLD_GROUNDCOVERAGE)) { bDProject_RPTEntity.GroundCoverage = String.Empty; } else { bDProject_RPTEntity.GroundCoverage = reader.GetString(FLD_GROUNDCOVERAGE); }
            if (reader.IsDBNull(FLD_DATEOFAGREEMENT)) { bDProject_RPTEntity.DateOfAgreement = null; } else { bDProject_RPTEntity.DateOfAgreement = reader.GetDateTime(FLD_DATEOFAGREEMENT); }
            if (reader.IsDBNull(FLD_DATEOFHANDOVER)) { bDProject_RPTEntity.DateOfHandover = null; } else { bDProject_RPTEntity.DateOfHandover = reader.GetDateTime(FLD_DATEOFHANDOVER); }
            if (reader.IsDBNull(FLD_DELAYCLAUSE)) { bDProject_RPTEntity.DelayClause = String.Empty; } else { bDProject_RPTEntity.DelayClause = reader.GetString(FLD_DELAYCLAUSE); }
            if (reader.IsDBNull(FLD_TBAUNIT)) { bDProject_RPTEntity.TBAUnit = String.Empty; } else { bDProject_RPTEntity.TBAUnit = reader.GetString(FLD_TBAUNIT); }
            if (reader.IsDBNull(FLD_FIAUNIT)) { bDProject_RPTEntity.FIAUnit = String.Empty; } else { bDProject_RPTEntity.FIAUnit = reader.GetString(FLD_FIAUNIT); }
            if (reader.IsDBNull(FLD_GSAUNIT)) { bDProject_RPTEntity.GSAUnit = String.Empty; } else { bDProject_RPTEntity.GSAUnit = reader.GetString(FLD_GSAUNIT); }
            bDProject_RPTEntity.ProjectStatus = reader.GetString(FLD_PROJECTSTATUS);

            return bDProject_RPTEntity;
        }
    }
}
