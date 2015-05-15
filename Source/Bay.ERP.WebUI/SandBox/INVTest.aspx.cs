// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:42:57




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;
using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.Web.UI
{
    public partial class INVTestPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "INVTestPageEntity";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("INV Test", " - ", base.Page.Title);

           // ucMDCityEntity.ContentHolderPageUrl = "~/Controls/MD/MDCity.aspx";

            if (!IsPostBack)
            {
                INVStoreEntity ent=new INVStoreEntity();
                ent.ProjectID=48;
                ent.DepartmentID=11;
                ent.StoreInChargeEmployeeID=215;
                ent.Name="ProjectName+Store";
                ent.StoreTrackNumber="TestTrackNo";
                ent.Location="ProjectAddress";
                ent.Description=String.Empty;
                ent.CreateDate=System.DateTime.Now;
                ent.IsRemoved=false;

                Int64 storeID = INVManager.CreateStore(ent.ProjectID, ent.DepartmentID, ent.StoreInChargeEmployeeID, ent.Name, ent.StoreTrackNumber, ent.Location, ent.Description);

                //INVStoreUnitEntity entStoreUnit = new INVStoreUnitEntity();


                //entStoreUnit.ParentStoreUnitID = null;
                //entStoreUnit.c
                Int64 storeUnit = INVManager.CreateStoreUnit(storeID, 1, "UnitTrack-001", "ProjectLocation", "", null);

                //INVManager.AddStoreUnitItem(storeUnit, 1, 51, 104, 12, 116, 200);
               // INVManager.GetAllCurrentStock(storeUnit, 1, 51, 104, 12, 116, 200);

            }
        }

        #endregion
    }
}
