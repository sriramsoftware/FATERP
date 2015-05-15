using System.Diagnostics;
using Bay.ERP.Common.Shared;
using System;

namespace Bay.ERP.DataAccess
{
    public sealed class DataAccessFactory : BaseDataAccessFactory
    {
        #region Constructor

        public DataAccessFactory(Context context)
            : base(context)
        {
        }

        #endregion

        #region Factory Methods

        #region AP

        #region APApprovalProcessEntity

        [DebuggerStepThrough()]
        public override IAPApprovalProcessDataAccess CreateAPApprovalProcessDataAccess()
        {
            string type = typeof(APApprovalProcessDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APApprovalProcessDataAccess(CurrentContext);
            }

            return (IAPApprovalProcessDataAccess)CurrentContext[type];
        }

        #endregion

        #region APFeedbackEntity

        [DebuggerStepThrough()]
        public override IAPFeedbackDataAccess CreateAPFeedbackDataAccess()
        {
            string type = typeof(APFeedbackDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APFeedbackDataAccess(CurrentContext);
            }

            return (IAPFeedbackDataAccess)CurrentContext[type];
        }

        #endregion

        #region APMemberFeedbackEntity

        [DebuggerStepThrough()]
        public override IAPMemberFeedbackDataAccess CreateAPMemberFeedbackDataAccess()
        {
            string type = typeof(APMemberFeedbackDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APMemberFeedbackDataAccess(CurrentContext);
            }

            return (IAPMemberFeedbackDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelEntity

        [DebuggerStepThrough()]
        public override IAPPanelDataAccess CreateAPPanelDataAccess()
        {
            string type = typeof(APPanelDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelDataAccess(CurrentContext);
            }

            return (IAPPanelDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelItemCategoryMapEntity

        [DebuggerStepThrough()]
        public override IAPPanelItemCategoryMapDataAccess CreateAPPanelItemCategoryMapDataAccess()
        {
            string type = typeof(APPanelItemCategoryMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelItemCategoryMapDataAccess(CurrentContext);
            }

            return (IAPPanelItemCategoryMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelMemberEntity

        [DebuggerStepThrough()]
        public override IAPPanelMemberDataAccess CreateAPPanelMemberDataAccess()
        {
            string type = typeof(APPanelMemberDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelMemberDataAccess(CurrentContext);
            }

            return (IAPPanelMemberDataAccess)CurrentContext[type];
        }

        #endregion

        #region APStatusEntity

        [DebuggerStepThrough()]
        public override IAPStatusDataAccess CreateAPStatusDataAccess()
        {
            string type = typeof(APStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APStatusDataAccess(CurrentContext);
            }

            return (IAPStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region APTypeEntity

        [DebuggerStepThrough()]
        public override IAPTypeDataAccess CreateAPTypeDataAccess()
        {
            string type = typeof(APTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APTypeDataAccess(CurrentContext);
            }

            return (IAPTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region APWOPanelItemCategoryMapEntity

        [DebuggerStepThrough()]
        public override IAPWOPanelItemCategoryMapDataAccess CreateAPWOPanelItemCategoryMapDataAccess()
        {
            string type = typeof(APWOPanelItemCategoryMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APWOPanelItemCategoryMapDataAccess(CurrentContext);
            }

            return (IAPWOPanelItemCategoryMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region APMemberFeedbackRemarksEntity

        [DebuggerStepThrough()]
        public override IAPMemberFeedbackRemarksDataAccess CreateAPMemberFeedbackRemarksDataAccess()
        {
            string type = typeof(APMemberFeedbackRemarksDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APMemberFeedbackRemarksDataAccess(CurrentContext);
            }

            return (IAPMemberFeedbackRemarksDataAccess)CurrentContext[type];
        }

        #endregion
        
        #region APForwardInfoEntity

        [DebuggerStepThrough()]
        public override IAPForwardInfoDataAccess CreateAPForwardInfoDataAccess()
        {
            string type = typeof(APForwardInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APForwardInfoDataAccess(CurrentContext);
            }

            return (IAPForwardInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelForwardMemberEntity

        [DebuggerStepThrough()]
        public override IAPPanelForwardMemberDataAccess CreateAPPanelForwardMemberDataAccess()
        {
            string type = typeof(APPanelForwardMemberDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelForwardMemberDataAccess(CurrentContext);
            }

            return (IAPPanelForwardMemberDataAccess)CurrentContext[type];
        }

        #endregion

        #region APApprovalProcessPanelMapEntity

        [DebuggerStepThrough()]
        public override IAPApprovalProcessPanelMapDataAccess CreateAPApprovalProcessPanelMapDataAccess()
        {
            string type = typeof(APApprovalProcessPanelMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APApprovalProcessPanelMapDataAccess(CurrentContext);
            }

            return (IAPApprovalProcessPanelMapDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region BD

        #region BDProjectEntity

        [DebuggerStepThrough()]
        public override IBDProjectDataAccess CreateBDProjectDataAccess()
        {
            string type = typeof(BDProjectDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectDataAccess(CurrentContext);
            }

            return (IBDProjectDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectAddressInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectAddressInfoDataAccess CreateBDProjectAddressInfoDataAccess()
        {
            string type = typeof(BDProjectAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectAddressInfoDataAccess(CurrentContext);
            }

            return (IBDProjectAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectCollectedDocumentCategoryInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectCollectedDocumentCategoryInfoDataAccess CreateBDProjectCollectedDocumentCategoryInfoDataAccess()
        {
            string type = typeof(BDProjectCollectedDocumentCategoryInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectCollectedDocumentCategoryInfoDataAccess(CurrentContext);
            }

            return (IBDProjectCollectedDocumentCategoryInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectCollectedDocumentInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectCollectedDocumentInfoDataAccess CreateBDProjectCollectedDocumentInfoDataAccess()
        {
            string type = typeof(BDProjectCollectedDocumentInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectCollectedDocumentInfoDataAccess(CurrentContext);
            }

            return (IBDProjectCollectedDocumentInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectCollectedDocumentUploadInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectCollectedDocumentUploadInfoDataAccess CreateBDProjectCollectedDocumentUploadInfoDataAccess()
        {
            string type = typeof(BDProjectCollectedDocumentUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectCollectedDocumentUploadInfoDataAccess(CurrentContext);
            }

            return (IBDProjectCollectedDocumentUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectDocumentTemplateEntity

        [DebuggerStepThrough()]
        public override IBDProjectDocumentTemplateDataAccess CreateBDProjectDocumentTemplateDataAccess()
        {
            string type = typeof(BDProjectDocumentTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectDocumentTemplateDataAccess(CurrentContext);
            }

            return (IBDProjectDocumentTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectDocumentTemplateMapEntity

        [DebuggerStepThrough()]
        public override IBDProjectDocumentTemplateMapDataAccess CreateBDProjectDocumentTemplateMapDataAccess()
        {
            string type = typeof(BDProjectDocumentTemplateMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectDocumentTemplateMapDataAccess(CurrentContext);
            }

            return (IBDProjectDocumentTemplateMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectFloorEntity

        [DebuggerStepThrough()]
        public override IBDProjectFloorDataAccess CreateBDProjectFloorDataAccess()
        {
            string type = typeof(BDProjectFloorDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectFloorDataAccess(CurrentContext);
            }

            return (IBDProjectFloorDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectHistoryEntity

        [DebuggerStepThrough()]
        public override IBDProjectHistoryDataAccess CreateBDProjectHistoryDataAccess()
        {
            string type = typeof(BDProjectHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectHistoryDataAccess(CurrentContext);
            }

            return (IBDProjectHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectOtherInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectOtherInfoDataAccess CreateBDProjectOtherInfoDataAccess()
        {
            string type = typeof(BDProjectOtherInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectOtherInfoDataAccess(CurrentContext);
            }

            return (IBDProjectOtherInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectAssignedPersonEntity

        [DebuggerStepThrough()]
        public override IBDProjectAssignedPersonDataAccess CreateBDProjectAssignedPersonDataAccess()
        {
            string type = typeof(BDProjectAssignedPersonDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectAssignedPersonDataAccess(CurrentContext);
            }

            return (IBDProjectAssignedPersonDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectFloorUnitEntity

        [DebuggerStepThrough()]
        public override IBDProjectFloorUnitDataAccess CreateBDProjectFloorUnitDataAccess()
        {
            string type = typeof(BDProjectFloorUnitDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectFloorUnitDataAccess(CurrentContext);
            }

            return (IBDProjectFloorUnitDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProcessAssignedResourceEntity

        [DebuggerStepThrough()]
        public override IBDProcessAssignedResourceDataAccess CreateBDProcessAssignedResourceDataAccess()
        {
            string type = typeof(BDProcessAssignedResourceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProcessAssignedResourceDataAccess(CurrentContext);
            }

            return (IBDProcessAssignedResourceDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProcessAssignedResourceMapEntity

        [DebuggerStepThrough()]
        public override IBDProcessAssignedResourceMapDataAccess CreateBDProcessAssignedResourceMapDataAccess()
        {
            string type = typeof(BDProcessAssignedResourceMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProcessAssignedResourceMapDataAccess(CurrentContext);
            }

            return (IBDProcessAssignedResourceMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDTaskTemplateEntity

        [DebuggerStepThrough()]
        public override IBDTaskTemplateDataAccess CreateBDTaskTemplateDataAccess()
        {
            string type = typeof(BDTaskTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDTaskTemplateDataAccess(CurrentContext);
            }

            return (IBDTaskTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDTaskTemplateItemMapEntity

        [DebuggerStepThrough()]
        public override IBDTaskTemplateItemMapDataAccess CreateBDTaskTemplateItemMapDataAccess()
        {
            string type = typeof(BDTaskTemplateItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDTaskTemplateItemMapDataAccess(CurrentContext);
            }

            return (IBDTaskTemplateItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectAdditionalInfoEntity

        [DebuggerStepThrough()]
        public override IBDProjectAdditionalInfoDataAccess CreateBDProjectAdditionalInfoDataAccess()
        {
            string type = typeof(BDProjectAdditionalInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectAdditionalInfoDataAccess(CurrentContext);
            }

            return (IBDProjectAdditionalInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectImageGalleryEntity

        [DebuggerStepThrough()]
        public override IBDProjectImageGalleryDataAccess CreateBDProjectImageGalleryDataAccess()
        {
            string type = typeof(BDProjectImageGalleryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectImageGalleryDataAccess(CurrentContext);
            }

            return (IBDProjectImageGalleryDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectLiftEntity

        [DebuggerStepThrough()]
        public override IBDProjectLiftDataAccess CreateBDProjectLiftDataAccess()
        {
            string type = typeof(BDProjectLiftDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectLiftDataAccess(CurrentContext);
            }

            return (IBDProjectLiftDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectParkingEntity

        [DebuggerStepThrough()]
        public override IBDProjectParkingDataAccess CreateBDProjectParkingDataAccess()
        {
            string type = typeof(BDProjectParkingDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectParkingDataAccess(CurrentContext);
            }

            return (IBDProjectParkingDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectSubstationAndGeneratorEntity

        [DebuggerStepThrough()]
        public override IBDProjectSubstationAndGeneratorDataAccess CreateBDProjectSubstationAndGeneratorDataAccess()
        {
            string type = typeof(BDProjectSubstationAndGeneratorDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectSubstationAndGeneratorDataAccess(CurrentContext);
            }

            return (IBDProjectSubstationAndGeneratorDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectUnitLocationEntity

        [DebuggerStepThrough()]
        public override IBDProjectUnitLocationDataAccess CreateBDProjectUnitLocationDataAccess()
        {
            string type = typeof(BDProjectUnitLocationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectUnitLocationDataAccess(CurrentContext);
            }

            return (IBDProjectUnitLocationDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectWaterReserviorEntity

        [DebuggerStepThrough()]
        public override IBDProjectWaterReserviorDataAccess CreateBDProjectWaterReserviorDataAccess()
        {
            string type = typeof(BDProjectWaterReserviorDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectWaterReserviorDataAccess(CurrentContext);
            }

            return (IBDProjectWaterReserviorDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region Common

        #region CMNDashboardItemEntity

        [DebuggerStepThrough()]
        public override ICMNDashboardItemDataAccess CreateCMNDashboardItemDataAccess()
        {
            string type = typeof(CMNDashboardItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNDashboardItemDataAccess(CurrentContext);
            }

            return (ICMNDashboardItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNDashboardItemQuicklinkEntity

        [DebuggerStepThrough()]
        public override ICMNDashboardItemQuicklinkDataAccess CreateCMNDashboardItemQuicklinkDataAccess()
        {
            string type = typeof(CMNDashboardItemQuicklinkDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNDashboardItemQuicklinkDataAccess(CurrentContext);
            }

            return (ICMNDashboardItemQuicklinkDataAccess)CurrentContext[type];
        }

        #endregion
        
        #region CMNApprovalPanelEntity

        [DebuggerStepThrough()]
        public override ICMNApprovalPanelDataAccess CreateCMNApprovalPanelDataAccess()
        {
            string type = typeof(CMNApprovalPanelDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNApprovalPanelDataAccess(CurrentContext);
            }

            return (ICMNApprovalPanelDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNApprovalProcessEntity

        [DebuggerStepThrough()]
        public override ICMNApprovalProcessDataAccess CreateCMNApprovalProcessDataAccess()
        {
            string type = typeof(CMNApprovalProcessDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNApprovalProcessDataAccess(CurrentContext);
            }

            return (ICMNApprovalProcessDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMailTemplateEntity

        [DebuggerStepThrough()]
        public override ICMNMailTemplateDataAccess CreateCMNMailTemplateDataAccess()
        {
            string type = typeof(CMNMailTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMailTemplateDataAccess(CurrentContext);
            }

            return (ICMNMailTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNERPCommentEntity

        [DebuggerStepThrough()]
        public override ICMNERPCommentDataAccess CreateCMNERPCommentDataAccess()
        {
            string type = typeof(CMNERPCommentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNERPCommentDataAccess(CurrentContext);
            }

            return (ICMNERPCommentDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNFavoriteEntity

        [DebuggerStepThrough()]
        public override ICMNFavoriteDataAccess CreateCMNFavoriteDataAccess()
        {
            string type = typeof(CMNFavoriteDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNFavoriteDataAccess(CurrentContext);
            }

            return (ICMNFavoriteDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNProcessCategoryEntity

        [DebuggerStepThrough()]
        public override ICMNProcessCategoryDataAccess CreateCMNProcessCategoryDataAccess()
        {
            string type = typeof(CMNProcessCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNProcessCategoryDataAccess(CurrentContext);
            }

            return (ICMNProcessCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNEventEntity

        [DebuggerStepThrough()]
        public override ICMNEventDataAccess CreateCMNEventDataAccess()
        {
            string type = typeof(CMNEventDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNEventDataAccess(CurrentContext);
            }

            return (ICMNEventDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNEventInvitationInformationEntity

        [DebuggerStepThrough()]
        public override ICMNEventInvitationInformationDataAccess CreateCMNEventInvitationInformationDataAccess()
        {
            string type = typeof(CMNEventInvitationInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNEventInvitationInformationDataAccess(CurrentContext);
            }

            return (ICMNEventInvitationInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNEventUploadInfoEntity

        [DebuggerStepThrough()]
        public override ICMNEventUploadInfoDataAccess CreateCMNEventUploadInfoDataAccess()
        {
            string type = typeof(CMNEventUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNEventUploadInfoDataAccess(CurrentContext);
            }

            return (ICMNEventUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion
        
        #endregion

        #region HR

        #region HREmployeeEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDataAccess CreateHREmployeeDataAccess()
        {
            string type = typeof(HREmployeeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDataAccess(CurrentContext);
            }

            return (IHREmployeeDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRHolidayEntity

        [DebuggerStepThrough()]
        public override IHRHolidayDataAccess CreateHRHolidayDataAccess()
        {
            string type = typeof(HRHolidayDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRHolidayDataAccess(CurrentContext);
            }

            return (IHRHolidayDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMemberEntity

        [DebuggerStepThrough()]
        public override IHRMemberDataAccess CreateHRMemberDataAccess()
        {
            string type = typeof(HRMemberDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMemberDataAccess(CurrentContext);
            }

            return (IHRMemberDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRWorkingDayEntity

        [DebuggerStepThrough()]
        public override IHRWorkingDayDataAccess CreateHRWorkingDayDataAccess()
        {
            string type = typeof(HRWorkingDayDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRWorkingDayDataAccess(CurrentContext);
            }

            return (IHRWorkingDayDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationDataAccess CreateHREmployeeEvaluationDataAccess()
        {
            string type = typeof(HREmployeeEvaluationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationResultEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationResultDataAccess CreateHREmployeeEvaluationResultDataAccess()
        {
            string type = typeof(HREmployeeEvaluationResultDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationResultDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationResultDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSupervisorMapEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSupervisorMapDataAccess CreateHREmployeeSupervisorMapDataAccess()
        {
            string type = typeof(HREmployeeSupervisorMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSupervisorMapDataAccess(CurrentContext);
            }

            return (IHREmployeeSupervisorMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRSessionEntity

        [DebuggerStepThrough()]
        public override IHRSessionDataAccess CreateHRSessionDataAccess()
        {
            string type = typeof(HRSessionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRSessionDataAccess(CurrentContext);
            }

            return (IHRSessionDataAccess)CurrentContext[type];
        }

        #endregion

        #region IHREmployeeSupervisorMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSupervisorMap_DetailedDataAccess CreateHREmployeeSupervisorMap_DetailedDataAccess()
        {
            string type = typeof(HREmployeeSupervisorMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSupervisorMap_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeSupervisorMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRAdditonalInformationEntity

        [DebuggerStepThrough()]
        public override IHRAdditonalInformationDataAccess CreateHRAdditonalInformationDataAccess()
        {
            string type = typeof(HRAdditonalInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRAdditonalInformationDataAccess(CurrentContext);
            }

            return (IHRAdditonalInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRDepartmentEmployeeMapEntity

        [DebuggerStepThrough()]
        public override IHRDepartmentEmployeeMapDataAccess CreateHRDepartmentEmployeeMapDataAccess()
        {
            string type = typeof(HRDepartmentEmployeeMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRDepartmentEmployeeMapDataAccess(CurrentContext);
            }

            return (IHRDepartmentEmployeeMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAdditionalPaymentInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAdditionalPaymentInfoDataAccess CreateHREmployeeAdditionalPaymentInfoDataAccess()
        {
            string type = typeof(HREmployeeAdditionalPaymentInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAdditionalPaymentInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeAdditionalPaymentInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAddressInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAddressInfoDataAccess CreateHREmployeeAddressInfoDataAccess()
        {
            string type = typeof(HREmployeeAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAddressInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion
        
        #region HREmployeeBankAccountInformationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeBankAccountInformationDataAccess CreateHREmployeeBankAccountInformationDataAccess()
        {
            string type = typeof(HREmployeeBankAccountInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeBankAccountInformationDataAccess(CurrentContext);
            }

            return (IHREmployeeBankAccountInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeConfidentialInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeConfidentialInfoDataAccess CreateHREmployeeConfidentialInfoDataAccess()
        {
            string type = typeof(HREmployeeConfidentialInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeConfidentialInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeConfidentialInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeContactInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeContactInfoDataAccess CreateHREmployeeContactInfoDataAccess()
        {
            string type = typeof(HREmployeeContactInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeContactInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeContactInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeDocumentEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDocumentDataAccess CreateHREmployeeDocumentDataAccess()
        {
            string type = typeof(HREmployeeDocumentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDocumentDataAccess(CurrentContext);
            }

            return (IHREmployeeDocumentDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeDrivingLicenseInformationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDrivingLicenseInformationDataAccess CreateHREmployeeDrivingLicenseInformationDataAccess()
        {
            string type = typeof(HREmployeeDrivingLicenseInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDrivingLicenseInformationDataAccess(CurrentContext);
            }

            return (IHREmployeeDrivingLicenseInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEducationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEducationDataAccess CreateHREmployeeEducationDataAccess()
        {
            string type = typeof(HREmployeeEducationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEducationDataAccess(CurrentContext);
            }

            return (IHREmployeeEducationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEmergencyContactInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEmergencyContactInfoDataAccess CreateHREmployeeEmergencyContactInfoDataAccess()
        {
            string type = typeof(HREmployeeEmergencyContactInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEmergencyContactInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeEmergencyContactInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeExperienceEntity

        [DebuggerStepThrough()]
        public override IHREmployeeExperienceDataAccess CreateHREmployeeExperienceDataAccess()
        {
            string type = typeof(HREmployeeExperienceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeExperienceDataAccess(CurrentContext);
            }

            return (IHREmployeeExperienceDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeFamilyInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeFamilyInfoDataAccess CreateHREmployeeFamilyInfoDataAccess()
        {
            string type = typeof(HREmployeeFamilyInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeFamilyInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeFamilyInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeJobDescriptionEntity

        [DebuggerStepThrough()]
        public override IHREmployeeJobDescriptionDataAccess CreateHREmployeeJobDescriptionDataAccess()
        {
            string type = typeof(HREmployeeJobDescriptionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeJobDescriptionDataAccess(CurrentContext);
            }

            return (IHREmployeeJobDescriptionDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLanguageMapEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLanguageMapDataAccess CreateHREmployeeLanguageMapDataAccess()
        {
            string type = typeof(HREmployeeLanguageMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLanguageMapDataAccess(CurrentContext);
            }

            return (IHREmployeeLanguageMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLeaveApplicationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLeaveApplicationDataAccess CreateHREmployeeLeaveApplicationDataAccess()
        {
            string type = typeof(HREmployeeLeaveApplicationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLeaveApplicationDataAccess(CurrentContext);
            }

            return (IHREmployeeLeaveApplicationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLoanApplicationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLoanApplicationDataAccess CreateHREmployeeLoanApplicationDataAccess()
        {
            string type = typeof(HREmployeeLoanApplicationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLoanApplicationDataAccess(CurrentContext);
            }

            return (IHREmployeeLoanApplicationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeNoticeEntity

        [DebuggerStepThrough()]
        public override IHREmployeeNoticeDataAccess CreateHREmployeeNoticeDataAccess()
        {
            string type = typeof(HREmployeeNoticeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeNoticeDataAccess(CurrentContext);
            }

            return (IHREmployeeNoticeDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeNoticeTemplateEntity

        [DebuggerStepThrough()]
        public override IHREmployeeNoticeTemplateDataAccess CreateHREmployeeNoticeTemplateDataAccess()
        {
            string type = typeof(HREmployeeNoticeTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeNoticeTemplateDataAccess(CurrentContext);
            }

            return (IHREmployeeNoticeTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeePassportInformationEntity

        [DebuggerStepThrough()]
        public override IHREmployeePassportInformationDataAccess CreateHREmployeePassportInformationDataAccess()
        {
            string type = typeof(HREmployeePassportInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeePassportInformationDataAccess(CurrentContext);
            }

            return (IHREmployeePassportInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeePhotoEntity

        [DebuggerStepThrough()]
        public override IHREmployeePhotoDataAccess CreateHREmployeePhotoDataAccess()
        {
            string type = typeof(HREmployeePhotoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeePhotoDataAccess(CurrentContext);
            }

            return (IHREmployeePhotoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeResumeEntity

        [DebuggerStepThrough()]
        public override IHREmployeeResumeDataAccess CreateHREmployeeResumeDataAccess()
        {
            string type = typeof(HREmployeeResumeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeResumeDataAccess(CurrentContext);
            }

            return (IHREmployeeResumeDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSkillMapEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSkillMapDataAccess CreateHREmployeeSkillMapDataAccess()
        {
            string type = typeof(HREmployeeSkillMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSkillMapDataAccess(CurrentContext);
            }

            return (IHREmployeeSkillMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeVisaInfomationEntity

        [DebuggerStepThrough()]
        public override IHREmployeeVisaInfomationDataAccess CreateHREmployeeVisaInfomationDataAccess()
        {
            string type = typeof(HREmployeeVisaInfomationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeVisaInfomationDataAccess(CurrentContext);
            }

            return (IHREmployeeVisaInfomationDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMemberLeaveAccountEntity

        [DebuggerStepThrough()]
        public override IHRMemberLeaveAccountDataAccess CreateHRMemberLeaveAccountDataAccess()
        {
            string type = typeof(HRMemberLeaveAccountDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMemberLeaveAccountDataAccess(CurrentContext);
            }

            return (IHRMemberLeaveAccountDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMemberLeaveOpeningBalanceEntity

        [DebuggerStepThrough()]
        public override IHRMemberLeaveOpeningBalanceDataAccess CreateHRMemberLeaveOpeningBalanceDataAccess()
        {
            string type = typeof(HRMemberLeaveOpeningBalanceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMemberLeaveOpeningBalanceDataAccess(CurrentContext);
            }

            return (IHRMemberLeaveOpeningBalanceDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationReportEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationReportDataAccess CreateHREmployeeEvaluationReportDataAccess()
        {
            string type = typeof(HREmployeeEvaluationReportDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationReportDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationReportDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeMonthlyTimeSheetEntity

        [DebuggerStepThrough()]
        public override IHREmployeeMonthlyTimeSheetDataAccess CreateHREmployeeMonthlyTimeSheetDataAccess()
        {
            string type = typeof(HREmployeeMonthlyTimeSheetDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeMonthlyTimeSheetDataAccess(CurrentContext);
            }

            return (IHREmployeeMonthlyTimeSheetDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeMonthlyTimeSheetSummaryEntity

        [DebuggerStepThrough()]
        public override IHREmployeeMonthlyTimeSheetSummaryDataAccess CreateHREmployeeMonthlyTimeSheetSummaryDataAccess()
        {
            string type = typeof(HREmployeeMonthlyTimeSheetSummaryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeMonthlyTimeSheetSummaryDataAccess(CurrentContext);
            }

            return (IHREmployeeMonthlyTimeSheetSummaryDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryBreakDownEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryBreakDownDataAccess CreateHREmployeeSalaryBreakDownDataAccess()
        {
            string type = typeof(HREmployeeSalaryBreakDownDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryBreakDownDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryBreakDownDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryBreakdownHistoryEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryBreakdownHistoryDataAccess CreateHREmployeeSalaryBreakdownHistoryDataAccess()
        {
            string type = typeof(HREmployeeSalaryBreakdownHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryBreakdownHistoryDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryBreakdownHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryDeducationInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryDeducationInfoDataAccess CreateHREmployeeSalaryDeducationInfoDataAccess()
        {
            string type = typeof(HREmployeeSalaryDeducationInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryDeducationInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryDeducationInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryInfoDataAccess CreateHREmployeeSalaryInfoDataAccess()
        {
            string type = typeof(HREmployeeSalaryInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryInfoHistoryEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryInfoHistoryDataAccess CreateHREmployeeSalaryInfoHistoryDataAccess()
        {
            string type = typeof(HREmployeeSalaryInfoHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryInfoHistoryDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryInfoHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryPaymentEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryPaymentDataAccess CreateHREmployeeSalaryPaymentDataAccess()
        {
            string type = typeof(HREmployeeSalaryPaymentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryPaymentDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryPaymentDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalarySessionDeducationInfoEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalarySessionDeducationInfoDataAccess CreateHREmployeeSalarySessionDeducationInfoDataAccess()
        {
            string type = typeof(HREmployeeSalarySessionDeducationInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalarySessionDeducationInfoDataAccess(CurrentContext);
            }

            return (IHREmployeeSalarySessionDeducationInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRSalaryAdjustmentEntity

        [DebuggerStepThrough()]
        public override IHRSalaryAdjustmentDataAccess CreateHRSalaryAdjustmentDataAccess()
        {
            string type = typeof(HRSalaryAdjustmentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRSalaryAdjustmentDataAccess(CurrentContext);
            }

            return (IHRSalaryAdjustmentDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAllowanceEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAllowanceDataAccess CreateHREmployeeAllowanceDataAccess()
        {
            string type = typeof(HREmployeeAllowanceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAllowanceDataAccess(CurrentContext);
            }

            return (IHREmployeeAllowanceDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeePhoneBillAdjustmentEntity

        [DebuggerStepThrough()]
        public override IHREmployeePhoneBillAdjustmentDataAccess CreateHREmployeePhoneBillAdjustmentDataAccess()
        {
            string type = typeof(HREmployeePhoneBillAdjustmentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeePhoneBillAdjustmentDataAccess(CurrentContext);
            }

            return (IHREmployeePhoneBillAdjustmentDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region INV

        #region INVCurrentStockEntity

        [DebuggerStepThrough()]
        public override IINVCurrentStockDataAccess CreateINVCurrentStockDataAccess()
        {
            string type = typeof(INVCurrentStockDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVCurrentStockDataAccess(CurrentContext);
            }

            return (IINVCurrentStockDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreEntity

        [DebuggerStepThrough()]
        public override IINVStoreDataAccess CreateINVStoreDataAccess()
        {
            string type = typeof(INVStoreDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreDataAccess(CurrentContext);
            }

            return (IINVStoreDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreUnitEntity

        [DebuggerStepThrough()]
        public override IINVStoreUnitDataAccess CreateINVStoreUnitDataAccess()
        {
            string type = typeof(INVStoreUnitDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreUnitDataAccess(CurrentContext);
            }

            return (IINVStoreUnitDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreUnitItemEntity

        [DebuggerStepThrough()]
        public override IINVStoreUnitItemDataAccess CreateINVStoreUnitItemDataAccess()
        {
            string type = typeof(INVStoreUnitItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreUnitItemDataAccess(CurrentContext);
            }

            return (IINVStoreUnitItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransactionEntity

        [DebuggerStepThrough()]
        public override IINVTransactionDataAccess CreateINVTransactionDataAccess()
        {
            string type = typeof(INVTransactionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransactionDataAccess(CurrentContext);
            }

            return (IINVTransactionDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreIssueNoteEntity

        [DebuggerStepThrough()]
        public override IINVStoreIssueNoteDataAccess CreateINVStoreIssueNoteDataAccess()
        {
            string type = typeof(INVStoreIssueNoteDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreIssueNoteDataAccess(CurrentContext);
            }

            return (IINVStoreIssueNoteDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreIssueNoteItemMapEntity

        [DebuggerStepThrough()]
        public override IINVStoreIssueNoteItemMapDataAccess CreateINVStoreIssueNoteItemMapDataAccess()
        {
            string type = typeof(INVStoreIssueNoteItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreIssueNoteItemMapDataAccess(CurrentContext);
            }

            return (IINVStoreIssueNoteItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransferEntity

        [DebuggerStepThrough()]
        public override IINVTransferDataAccess CreateINVTransferDataAccess()
        {
            string type = typeof(INVTransferDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransferDataAccess(CurrentContext);
            }

            return (IINVTransferDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransferItemEntity

        [DebuggerStepThrough()]
        public override IINVTransferItemDataAccess CreateINVTransferItemDataAccess()
        {
            string type = typeof(INVTransferItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransferItemDataAccess(CurrentContext);
            }

            return (IINVTransferItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTRFStoreIssueNoteMapEntity

        [DebuggerStepThrough()]
        public override IINVTRFStoreIssueNoteMapDataAccess CreateINVTRFStoreIssueNoteMapDataAccess()
        {
            string type = typeof(INVTRFStoreIssueNoteMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTRFStoreIssueNoteMapDataAccess(CurrentContext);
            }

            return (IINVTRFStoreIssueNoteMapDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region MasterData

        #region ICommonDA_SPDataAccess

        [DebuggerStepThrough()]
        public override ICommonDA_SPDataAccess CreateCommonDA_SPDataAccess()
        {
            string type = typeof(CommonDA_SPDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CommonDA_SPDataAccess(CurrentContext);
            }

            return (ICommonDA_SPDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBrandEntity

        [DebuggerStepThrough()]
        public override IMDBrandDataAccess CreateMDBrandDataAccess()
        {
            string type = typeof(MDBrandDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBrandDataAccess(CurrentContext);
            }

            return (IMDBrandDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCityEntity

        [DebuggerStepThrough()]
        public override IMDCityDataAccess CreateMDCityDataAccess()
        {
            string type = typeof(MDCityDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCityDataAccess(CurrentContext);
            }

            return (IMDCityDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCountryEntity

        [DebuggerStepThrough()]
        public override IMDCountryDataAccess CreateMDCountryDataAccess()
        {
            string type = typeof(MDCountryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCountryDataAccess(CurrentContext);
            }

            return (IMDCountryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemEntity

        [DebuggerStepThrough()]
        public override IMDItemDataAccess CreateMDItemDataAccess()
        {
            string type = typeof(MDItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemDataAccess(CurrentContext);
            }

            return (IMDItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemCategoryEntity

        [DebuggerStepThrough()]
        public override IMDItemCategoryDataAccess CreateMDItemCategoryDataAccess()
        {
            string type = typeof(MDItemCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemCategoryDataAccess(CurrentContext);
            }

            return (IMDItemCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDPreBOQStatusEntity

        [DebuggerStepThrough()]
        public override IMDPreBOQStatusDataAccess CreateMDPreBOQStatusDataAccess()
        {
            string type = typeof(MDPreBOQStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDPreBOQStatusDataAccess(CurrentContext);
            }

            return (IMDPreBOQStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectCollectedDocumentStatusEntity

        [DebuggerStepThrough()]
        public override IMDProjectCollectedDocumentStatusDataAccess CreateMDProjectCollectedDocumentStatusDataAccess()
        {
            string type = typeof(MDProjectCollectedDocumentStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectCollectedDocumentStatusDataAccess(CurrentContext);
            }

            return (IMDProjectCollectedDocumentStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectDocumentCategoryEntity

        [DebuggerStepThrough()]
        public override IMDProjectDocumentCategoryDataAccess CreateMDProjectDocumentCategoryDataAccess()
        {
            string type = typeof(MDProjectDocumentCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectDocumentCategoryDataAccess(CurrentContext);
            }

            return (IMDProjectDocumentCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectStatusEntity

        [DebuggerStepThrough()]
        public override IMDProjectStatusDataAccess CreateMDProjectStatusDataAccess()
        {
            string type = typeof(MDProjectStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectStatusDataAccess(CurrentContext);
            }

            return (IMDProjectStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDRegionEntity

        [DebuggerStepThrough()]
        public override IMDRegionDataAccess CreateMDRegionDataAccess()
        {
            string type = typeof(MDRegionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDRegionDataAccess(CurrentContext);
            }

            return (IMDRegionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSupplierAddressTypeEntity

        [DebuggerStepThrough()]
        public override IMDSupplierAddressTypeDataAccess CreateMDSupplierAddressTypeDataAccess()
        {
            string type = typeof(MDSupplierAddressTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSupplierAddressTypeDataAccess(CurrentContext);
            }

            return (IMDSupplierAddressTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDUnitEntity

        [DebuggerStepThrough()]
        public override IMDUnitDataAccess CreateMDUnitDataAccess()
        {
            string type = typeof(MDUnitDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDUnitDataAccess(CurrentContext);
            }

            return (IMDUnitDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectDocumentEntity

        [DebuggerStepThrough()]
        public override IMDProjectDocumentDataAccess CreateMDProjectDocumentDataAccess()
        {
            string type = typeof(MDProjectDocumentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectDocumentDataAccess(CurrentContext);
            }

            return (IMDProjectDocumentDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDHolidayCategoryEntity

        [DebuggerStepThrough()]
        public override IMDHolidayCategoryDataAccess CreateMDHolidayCategoryDataAccess()
        {
            string type = typeof(MDHolidayCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDHolidayCategoryDataAccess(CurrentContext);
            }

            return (IMDHolidayCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssueCategoryEntity

        [DebuggerStepThrough()]
        public override IMDIssueCategoryDataAccess CreateMDIssueCategoryDataAccess()
        {
            string type = typeof(MDIssueCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssueCategoryDataAccess(CurrentContext);
            }

            return (IMDIssueCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssueIdentityCategoryEntity

        [DebuggerStepThrough()]
        public override IMDIssueIdentityCategoryDataAccess CreateMDIssueIdentityCategoryDataAccess()
        {
            string type = typeof(MDIssueIdentityCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssueIdentityCategoryDataAccess(CurrentContext);
            }

            return (IMDIssueIdentityCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssuePriorityEntity

        [DebuggerStepThrough()]
        public override IMDIssuePriorityDataAccess CreateMDIssuePriorityDataAccess()
        {
            string type = typeof(MDIssuePriorityDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssuePriorityDataAccess(CurrentContext);
            }

            return (IMDIssuePriorityDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssueStatusEntity

        [DebuggerStepThrough()]
        public override IMDIssueStatusDataAccess CreateMDIssueStatusDataAccess()
        {
            string type = typeof(MDIssueStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssueStatusDataAccess(CurrentContext);
            }

            return (IMDIssueStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ResourceEntity

        [DebuggerStepThrough()]
        public override IResourceDataAccess CreateResourceDataAccess()
        {
            string type = typeof(ResourceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ResourceDataAccess(CurrentContext);
            }

            return (IResourceDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDMemberTypeEntity

        [DebuggerStepThrough()]
        public override IMDMemberTypeDataAccess CreateMDMemberTypeDataAccess()
        {
            string type = typeof(MDMemberTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDMemberTypeDataAccess(CurrentContext);
            }

            return (IMDMemberTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectScheduleItemEntity

        [DebuggerStepThrough()]
        public override IMDProjectScheduleItemDataAccess CreateMDProjectScheduleItemDataAccess()
        {
            string type = typeof(MDProjectScheduleItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectScheduleItemDataAccess(CurrentContext);
            }

            return (IMDProjectScheduleItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDResourceCategoryEntity

        [DebuggerStepThrough()]
        public override IMDResourceCategoryDataAccess CreateMDResourceCategoryDataAccess()
        {
            string type = typeof(MDResourceCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDResourceCategoryDataAccess(CurrentContext);
            }

            return (IMDResourceCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDScheduleCategoryEntity

        [DebuggerStepThrough()]
        public override IMDScheduleCategoryDataAccess CreateMDScheduleCategoryDataAccess()
        {
            string type = typeof(MDScheduleCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDScheduleCategoryDataAccess(CurrentContext);
            }

            return (IMDScheduleCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDScheduleIdentityCategoryEntity

        [DebuggerStepThrough()]
        public override IMDScheduleIdentityCategoryDataAccess CreateMDScheduleIdentityCategoryDataAccess()
        {
            string type = typeof(MDScheduleIdentityCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDScheduleIdentityCategoryDataAccess(CurrentContext);
            }

            return (IMDScheduleIdentityCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSchedulePriorityEntity

        [DebuggerStepThrough()]
        public override IMDSchedulePriorityDataAccess CreateMDSchedulePriorityDataAccess()
        {
            string type = typeof(MDSchedulePriorityDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSchedulePriorityDataAccess(CurrentContext);
            }

            return (IMDSchedulePriorityDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAddressTypeEntity

        [DebuggerStepThrough()]
        public override IMDAddressTypeDataAccess CreateMDAddressTypeDataAccess()
        {
            string type = typeof(MDAddressTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAddressTypeDataAccess(CurrentContext);
            }

            return (IMDAddressTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDContractorCriterionStatusEntity

        [DebuggerStepThrough()]
        public override IMDContractorCriterionStatusDataAccess CreateMDContractorCriterionStatusDataAccess()
        {
            string type = typeof(MDContractorCriterionStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDContractorCriterionStatusDataAccess(CurrentContext);
            }

            return (IMDContractorCriterionStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCriterionCategoryEntity

        [DebuggerStepThrough()]
        public override IMDCriterionCategoryDataAccess CreateMDCriterionCategoryDataAccess()
        {
            string type = typeof(MDCriterionCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCriterionCategoryDataAccess(CurrentContext);
            }

            return (IMDCriterionCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectCategoryEntity

        [DebuggerStepThrough()]
        public override IMDProjectCategoryDataAccess CreateMDProjectCategoryDataAccess()
        {
            string type = typeof(MDProjectCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectCategoryDataAccess(CurrentContext);
            }

            return (IMDProjectCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDRequisitionStatusEntity

        [DebuggerStepThrough()]
        public override IMDRequisitionStatusDataAccess CreateMDRequisitionStatusDataAccess()
        {
            string type = typeof(MDRequisitionStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDRequisitionStatusDataAccess(CurrentContext);
            }

            return (IMDRequisitionStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDConstructionToolCategoryEntity

        [DebuggerStepThrough()]
        public override IMDConstructionToolCategoryDataAccess CreateMDConstructionToolCategoryDataAccess()
        {
            string type = typeof(MDConstructionToolCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDConstructionToolCategoryDataAccess(CurrentContext);
            }

            return (IMDConstructionToolCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDConstructionToolWorkingConditionEntity

        [DebuggerStepThrough()]
        public override IMDConstructionToolWorkingConditionDataAccess CreateMDConstructionToolWorkingConditionDataAccess()
        {
            string type = typeof(MDConstructionToolWorkingConditionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDConstructionToolWorkingConditionDataAccess(CurrentContext);
            }

            return (IMDConstructionToolWorkingConditionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSupplierStatusEntity

        [DebuggerStepThrough()]
        public override IMDSupplierStatusDataAccess CreateMDSupplierStatusDataAccess()
        {
            string type = typeof(MDSupplierStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSupplierStatusDataAccess(CurrentContext);
            }

            return (IMDSupplierStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDStandardTimeUnitEntity

        [DebuggerStepThrough()]
        public override IMDStandardTimeUnitDataAccess CreateMDStandardTimeUnitDataAccess()
        {
            string type = typeof(MDStandardTimeUnitDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDStandardTimeUnitDataAccess(CurrentContext);
            }

            return (IMDStandardTimeUnitDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDesignationEntity

        [DebuggerStepThrough()]
        public override IMDDesignationDataAccess CreateMDDesignationDataAccess()
        {
            string type = typeof(MDDesignationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDesignationDataAccess(CurrentContext);
            }

            return (IMDDesignationDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemGroupEntity

        [DebuggerStepThrough()]
        public override IMDItemGroupDataAccess CreateMDItemGroupDataAccess()
        {
            string type = typeof(MDItemGroupDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemGroupDataAccess(CurrentContext);
            }

            return (IMDItemGroupDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemGroupItemCategoryMapEntity

        [DebuggerStepThrough()]
        public override IMDItemGroupItemCategoryMapDataAccess CreateMDItemGroupItemCategoryMapDataAccess()
        {
            string type = typeof(MDItemGroupItemCategoryMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemGroupItemCategoryMapDataAccess(CurrentContext);
            }

            return (IMDItemGroupItemCategoryMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSupplierItemCategoryEntity

        [DebuggerStepThrough()]
        public override IMDSupplierItemCategoryDataAccess CreateMDSupplierItemCategoryDataAccess()
        {
            string type = typeof(MDSupplierItemCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSupplierItemCategoryDataAccess(CurrentContext);
            }

            return (IMDSupplierItemCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSupplierTypeEntity

        [DebuggerStepThrough()]
        public override IMDSupplierTypeDataAccess CreateMDSupplierTypeDataAccess()
        {
            string type = typeof(MDSupplierTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSupplierTypeDataAccess(CurrentContext);
            }

            return (IMDSupplierTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBOQStatusEntity

        [DebuggerStepThrough()]
        public override IMDBOQStatusDataAccess CreateMDBOQStatusDataAccess()
        {
            string type = typeof(MDBOQStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBOQStatusDataAccess(CurrentContext);
            }

            return (IMDBOQStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemDefaultEntity

        [DebuggerStepThrough()]
        public override IMDItemDefaultDataAccess CreateMDItemDefaultDataAccess()
        {
            string type = typeof(MDItemDefaultDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemDefaultDataAccess(CurrentContext);
            }

            return (IMDItemDefaultDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItemThumbRuleEntity

        [DebuggerStepThrough()]
        public override IMDItemThumbRuleDataAccess CreateMDItemThumbRuleDataAccess()
        {
            string type = typeof(MDItemThumbRuleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItemThumbRuleDataAccess(CurrentContext);
            }

            return (IMDItemThumbRuleDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDFloorEntity

        [DebuggerStepThrough()]
        public override IMDFloorDataAccess CreateMDFloorDataAccess()
        {
            string type = typeof(MDFloorDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDFloorDataAccess(CurrentContext);
            }

            return (IMDFloorDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDFloorCategoryEntity

        [DebuggerStepThrough()]
        public override IMDFloorCategoryDataAccess CreateMDFloorCategoryDataAccess()
        {
            string type = typeof(MDFloorCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDFloorCategoryDataAccess(CurrentContext);
            }

            return (IMDFloorCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalPanelStatusEntity

        [DebuggerStepThrough()]
        public override IMDApprovalPanelStatusDataAccess CreateMDApprovalPanelStatusDataAccess()
        {
            string type = typeof(MDApprovalPanelStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalPanelStatusDataAccess(CurrentContext);
            }

            return (IMDApprovalPanelStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalProcessPriorityEntity

        [DebuggerStepThrough()]
        public override IMDApprovalProcessPriorityDataAccess CreateMDApprovalProcessPriorityDataAccess()
        {
            string type = typeof(MDApprovalProcessPriorityDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalProcessPriorityDataAccess(CurrentContext);
            }

            return (IMDApprovalProcessPriorityDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalProcessStatusEntity

        [DebuggerStepThrough()]
        public override IMDApprovalProcessStatusDataAccess CreateMDApprovalProcessStatusDataAccess()
        {
            string type = typeof(MDApprovalProcessStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalProcessStatusDataAccess(CurrentContext);
            }

            return (IMDApprovalProcessStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalProcessTypeEntity

        [DebuggerStepThrough()]
        public override IMDApprovalProcessTypeDataAccess CreateMDApprovalProcessTypeDataAccess()
        {
            string type = typeof(MDApprovalProcessTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalProcessTypeDataAccess(CurrentContext);
            }

            return (IMDApprovalProcessTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalRuleEntity

        [DebuggerStepThrough()]
        public override IMDApprovalRuleDataAccess CreateMDApprovalRuleDataAccess()
        {
            string type = typeof(MDApprovalRuleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalRuleDataAccess(CurrentContext);
            }

            return (IMDApprovalRuleDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalRuleDesignationMapEntity

        [DebuggerStepThrough()]
        public override IMDApprovalRuleDesignationMapDataAccess CreateMDApprovalRuleDesignationMapDataAccess()
        {
            string type = typeof(MDApprovalRuleDesignationMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalRuleDesignationMapDataAccess(CurrentContext);
            }

            return (IMDApprovalRuleDesignationMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDepartmentEntity

        [DebuggerStepThrough()]
        public override IMDDepartmentDataAccess CreateMDDepartmentDataAccess()
        {
            string type = typeof(MDDepartmentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDepartmentDataAccess(CurrentContext);
            }

            return (IMDDepartmentDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDWorkOrderStatusEntity

        [DebuggerStepThrough()]
        public override IMDWorkOrderStatusDataAccess CreateMDWorkOrderStatusDataAccess()
        {
            string type = typeof(MDWorkOrderStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDWorkOrderStatusDataAccess(CurrentContext);
            }

            return (IMDWorkOrderStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectAssignedPersonTeamRoleEntity

        [DebuggerStepThrough()]
        public override IMDProjectAssignedPersonTeamRoleDataAccess CreateMDProjectAssignedPersonTeamRoleDataAccess()
        {
            string type = typeof(MDProjectAssignedPersonTeamRoleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectAssignedPersonTeamRoleDataAccess(CurrentContext);
            }

            return (IMDProjectAssignedPersonTeamRoleDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDMSOwnerTypeEntity

        [DebuggerStepThrough()]
        public override IMDDMSOwnerTypeDataAccess CreateMDDMSOwnerTypeDataAccess()
        {
            string type = typeof(MDDMSOwnerTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDMSOwnerTypeDataAccess(CurrentContext);
            }

            return (IMDDMSOwnerTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDocumentStorageTypeEntity

        [DebuggerStepThrough()]
        public override IMDDocumentStorageTypeDataAccess CreateMDDocumentStorageTypeDataAccess()
        {
            string type = typeof(MDDocumentStorageTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDocumentStorageTypeDataAccess(CurrentContext);
            }

            return (IMDDocumentStorageTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDReferenceLibraryCategoryEntity

        [DebuggerStepThrough()]
        public override IMDReferenceLibraryCategoryDataAccess CreateMDReferenceLibraryCategoryDataAccess()
        {
            string type = typeof(MDReferenceLibraryCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDReferenceLibraryCategoryDataAccess(CurrentContext);
            }

            return (IMDReferenceLibraryCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBillStatusEntity

        [DebuggerStepThrough()]
        public override IMDBillStatusDataAccess CreateMDBillStatusDataAccess()
        {
            string type = typeof(MDBillStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBillStatusDataAccess(CurrentContext);
            }

            return (IMDBillStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBillApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IMDBillApprovalStatusDataAccess CreateMDBillApprovalStatusDataAccess()
        {
            string type = typeof(MDBillApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBillApprovalStatusDataAccess(CurrentContext);
            }

            return (IMDBillApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDMailTemplateTypeEntity

        [DebuggerStepThrough()]
        public override IMDMailTemplateTypeDataAccess CreateMDMailTemplateTypeDataAccess()
        {
            string type = typeof(MDMailTemplateTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDMailTemplateTypeDataAccess(CurrentContext);
            }

            return (IMDMailTemplateTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDACCPayableApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IMDACCPayableApprovalStatusDataAccess CreateMDACCPayableApprovalStatusDataAccess()
        {
            string type = typeof(MDACCPayableApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDACCPayableApprovalStatusDataAccess(CurrentContext);
            }

            return (IMDACCPayableApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDACCPayablePaymentStatusEntity

        [DebuggerStepThrough()]
        public override IMDACCPayablePaymentStatusDataAccess CreateMDACCPayablePaymentStatusDataAccess()
        {
            string type = typeof(MDACCPayablePaymentStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDACCPayablePaymentStatusDataAccess(CurrentContext);
            }

            return (IMDACCPayablePaymentStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDVendorCategoryEntity

        [DebuggerStepThrough()]
        public override IMDVendorCategoryDataAccess CreateMDVendorCategoryDataAccess()
        {
            string type = typeof(MDVendorCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDVendorCategoryDataAccess(CurrentContext);
            }

            return (IMDVendorCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAccountPaybleStatementDetailCategoryEntity

        [DebuggerStepThrough()]
        public override IMDAccountPaybleStatementDetailCategoryDataAccess CreateMDAccountPaybleStatementDetailCategoryDataAccess()
        {
            string type = typeof(MDAccountPaybleStatementDetailCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAccountPaybleStatementDetailCategoryDataAccess(CurrentContext);
            }

            return (IMDAccountPaybleStatementDetailCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDPayableClassificationEntity

        [DebuggerStepThrough()]
        public override IMDPayableClassificationDataAccess CreateMDPayableClassificationDataAccess()
        {
            string type = typeof(MDPayableClassificationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDPayableClassificationDataAccess(CurrentContext);
            }

            return (IMDPayableClassificationDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDStoreIssueNoteApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IMDStoreIssueNoteApprovalStatusDataAccess CreateMDStoreIssueNoteApprovalStatusDataAccess()
        {
            string type = typeof(MDStoreIssueNoteApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDStoreIssueNoteApprovalStatusDataAccess(CurrentContext);
            }

            return (IMDStoreIssueNoteApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDInventoryStoreUnitTypeEntity

        [DebuggerStepThrough()]
        public override IMDInventoryStoreUnitTypeDataAccess CreateMDInventoryStoreUnitTypeDataAccess()
        {
            string type = typeof(MDInventoryStoreUnitTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDInventoryStoreUnitTypeDataAccess(CurrentContext);
            }

            return (IMDInventoryStoreUnitTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDInventoryTransferStatusEntity

        [DebuggerStepThrough()]
        public override IMDInventoryTransferStatusDataAccess CreateMDInventoryTransferStatusDataAccess()
        {
            string type = typeof(MDInventoryTransferStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDInventoryTransferStatusDataAccess(CurrentContext);
            }

            return (IMDInventoryTransferStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDBankAccountTypeEntity

        [DebuggerStepThrough()]
        public override IACMDBankAccountTypeDataAccess CreateACMDBankAccountTypeDataAccess()
        {
            string type = typeof(ACMDBankAccountTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDBankAccountTypeDataAccess(CurrentContext);
            }

            return (IACMDBankAccountTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCurrencyEntity

        [DebuggerStepThrough()]
        public override IMDCurrencyDataAccess CreateMDCurrencyDataAccess()
        {
            string type = typeof(MDCurrencyDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCurrencyDataAccess(CurrentContext);
            }

            return (IMDCurrencyDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDAccountResourceCategoryEntity

        [DebuggerStepThrough()]
        public override IACMDAccountResourceCategoryDataAccess CreateACMDAccountResourceCategoryDataAccess()
        {
            string type = typeof(ACMDAccountResourceCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDAccountResourceCategoryDataAccess(CurrentContext);
            }

            return (IACMDAccountResourceCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDPaidFromEntity

        [DebuggerStepThrough()]
        public override IACMDPaidFromDataAccess CreateACMDPaidFromDataAccess()
        {
            string type = typeof(ACMDPaidFromDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDPaidFromDataAccess(CurrentContext);
            }

            return (IACMDPaidFromDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDPayToEntity

        [DebuggerStepThrough()]
        public override IACMDPayToDataAccess CreateACMDPayToDataAccess()
        {
            string type = typeof(ACMDPayToDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDPayToDataAccess(CurrentContext);
            }

            return (IACMDPayToDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDBankAccountDepositApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IACMDBankAccountDepositApprovalStatusDataAccess CreateACMDBankAccountDepositApprovalStatusDataAccess()
        {
            string type = typeof(ACMDBankAccountDepositApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDBankAccountDepositApprovalStatusDataAccess(CurrentContext);
            }

            return (IACMDBankAccountDepositApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDBankAccountPaymentApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IACMDBankAccountPaymentApprovalStatusDataAccess CreateACMDBankAccountPaymentApprovalStatusDataAccess()
        {
            string type = typeof(ACMDBankAccountPaymentApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDBankAccountPaymentApprovalStatusDataAccess(CurrentContext);
            }

            return (IACMDBankAccountPaymentApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDTemporaryJournalApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IACMDTemporaryJournalApprovalStatusDataAccess CreateACMDTemporaryJournalApprovalStatusDataAccess()
        {
            string type = typeof(ACMDTemporaryJournalApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDTemporaryJournalApprovalStatusDataAccess(CurrentContext);
            }

            return (IACMDTemporaryJournalApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDBankAccountTransferApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IACMDBankAccountTransferApprovalStatusDataAccess CreateACMDBankAccountTransferApprovalStatusDataAccess()
        {
            string type = typeof(ACMDBankAccountTransferApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDBankAccountTransferApprovalStatusDataAccess(CurrentContext);
            }

            return (IACMDBankAccountTransferApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDTDSCategoryEntity

        [DebuggerStepThrough()]
        public override IACMDTDSCategoryDataAccess CreateACMDTDSCategoryDataAccess()
        {
            string type = typeof(ACMDTDSCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDTDSCategoryDataAccess(CurrentContext);
            }

            return (IACMDTDSCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDMaterialReceiveApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IMDMaterialReceiveApprovalStatusDataAccess CreateMDMaterialReceiveApprovalStatusDataAccess()
        {
            string type = typeof(MDMaterialReceiveApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDMaterialReceiveApprovalStatusDataAccess(CurrentContext);
            }

            return (IMDMaterialReceiveApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssueAssignTypeEntity

        [DebuggerStepThrough()]
        public override IMDIssueAssignTypeDataAccess CreateMDIssueAssignTypeDataAccess()
        {
            string type = typeof(MDIssueAssignTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssueAssignTypeDataAccess(CurrentContext);
            }

            return (IMDIssueAssignTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBMDUserTreeSettingEntity

        [DebuggerStepThrough()]
        public override IKBMDUserTreeSettingDataAccess CreateKBMDUserTreeSettingDataAccess()
        {
            string type = typeof(KBMDUserTreeSettingDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBMDUserTreeSettingDataAccess(CurrentContext);
            }

            return (IKBMDUserTreeSettingDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBMDUserTreeSharedPermissionEntity

        [DebuggerStepThrough()]
        public override IKBMDUserTreeSharedPermissionDataAccess CreateKBMDUserTreeSharedPermissionDataAccess()
        {
            string type = typeof(KBMDUserTreeSharedPermissionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBMDUserTreeSharedPermissionDataAccess(CurrentContext);
            }

            return (IKBMDUserTreeSharedPermissionDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBMDUserTreeStatusEntity

        [DebuggerStepThrough()]
        public override IKBMDUserTreeStatusDataAccess CreateKBMDUserTreeStatusDataAccess()
        {
            string type = typeof(KBMDUserTreeStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBMDUserTreeStatusDataAccess(CurrentContext);
            }

            return (IKBMDUserTreeStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDAdvertiseWayEntity

        [DebuggerStepThrough()]
        public override ICRMMDAdvertiseWayDataAccess CreateCRMMDAdvertiseWayDataAccess()
        {
            string type = typeof(CRMMDAdvertiseWayDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAdvertiseWayDataAccess(CurrentContext);
            }

            return (ICRMMDAdvertiseWayDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDAreaUnitEntity

        [DebuggerStepThrough()]
        public override ICRMMDAreaUnitDataAccess CreateCRMMDAreaUnitDataAccess()
        {
            string type = typeof(CRMMDAreaUnitDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAreaUnitDataAccess(CurrentContext);
            }

            return (ICRMMDAreaUnitDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDBookingStatusEntity

        [DebuggerStepThrough()]
        public override ICRMMDBookingStatusDataAccess CreateCRMMDBookingStatusDataAccess()
        {
            string type = typeof(CRMMDBookingStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDBookingStatusDataAccess(CurrentContext);
            }

            return (ICRMMDBookingStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDBuyerInterestedRoomCategoryEntity

        [DebuggerStepThrough()]
        public override ICRMMDBuyerInterestedRoomCategoryDataAccess CreateCRMMDBuyerInterestedRoomCategoryDataAccess()
        {
            string type = typeof(CRMMDBuyerInterestedRoomCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDBuyerInterestedRoomCategoryDataAccess(CurrentContext);
            }

            return (ICRMMDBuyerInterestedRoomCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDBuyerTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDBuyerTypeDataAccess CreateCRMMDBuyerTypeDataAccess()
        {
            string type = typeof(CRMMDBuyerTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDBuyerTypeDataAccess(CurrentContext);
            }

            return (ICRMMDBuyerTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDCommuicationDiscussionTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDCommuicationDiscussionTypeDataAccess CreateCRMMDCommuicationDiscussionTypeDataAccess()
        {
            string type = typeof(CRMMDCommuicationDiscussionTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDCommuicationDiscussionTypeDataAccess(CurrentContext);
            }

            return (ICRMMDCommuicationDiscussionTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDCommunicationStatusEntity

        [DebuggerStepThrough()]
        public override ICRMMDCommunicationStatusDataAccess CreateCRMMDCommunicationStatusDataAccess()
        {
            string type = typeof(CRMMDCommunicationStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDCommunicationStatusDataAccess(CurrentContext);
            }

            return (ICRMMDCommunicationStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDCustomerAddressTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDCustomerAddressTypeDataAccess CreateCRMMDCustomerAddressTypeDataAccess()
        {
            string type = typeof(CRMMDCustomerAddressTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDCustomerAddressTypeDataAccess(CurrentContext);
            }

            return (ICRMMDCustomerAddressTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDLandLocationEntity

        [DebuggerStepThrough()]
        public override ICRMMDLandLocationDataAccess CreateCRMMDLandLocationDataAccess()
        {
            string type = typeof(CRMMDLandLocationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDLandLocationDataAccess(CurrentContext);
            }

            return (ICRMMDLandLocationDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDLandOwnerTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDLandOwnerTypeDataAccess CreateCRMMDLandOwnerTypeDataAccess()
        {
            string type = typeof(CRMMDLandOwnerTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDLandOwnerTypeDataAccess(CurrentContext);
            }

            return (ICRMMDLandOwnerTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectFloorUnitStatusEntity

        [DebuggerStepThrough()]
        public override IMDProjectFloorUnitStatusDataAccess CreateMDProjectFloorUnitStatusDataAccess()
        {
            string type = typeof(MDProjectFloorUnitStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectFloorUnitStatusDataAccess(CurrentContext);
            }

            return (IMDProjectFloorUnitStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDProjectFloorUnitTypeEntity

        [DebuggerStepThrough()]
        public override IMDProjectFloorUnitTypeDataAccess CreateMDProjectFloorUnitTypeDataAccess()
        {
            string type = typeof(MDProjectFloorUnitTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDProjectFloorUnitTypeDataAccess(CurrentContext);
            }

            return (IMDProjectFloorUnitTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBloodGroupEntity

        [DebuggerStepThrough()]
        public override IMDBloodGroupDataAccess CreateMDBloodGroupDataAccess()
        {
            string type = typeof(MDBloodGroupDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBloodGroupDataAccess(CurrentContext);
            }

            return (IMDBloodGroupDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeJobTypeEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeJobTypeDataAccess CreateMDEmployeeJobTypeDataAccess()
        {
            string type = typeof(MDEmployeeJobTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeJobTypeDataAccess(CurrentContext);
            }

            return (IMDEmployeeJobTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDAgreementApprovalStatusEntity

        [DebuggerStepThrough()]
        public override ICRMMDAgreementApprovalStatusDataAccess CreateCRMMDAgreementApprovalStatusDataAccess()
        {
            string type = typeof(CRMMDAgreementApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAgreementApprovalStatusDataAccess(CurrentContext);
            }

            return (ICRMMDAgreementApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDAgreementSpecsTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDAgreementSpecsTypeDataAccess CreateCRMMDAgreementSpecsTypeDataAccess()
        {
            string type = typeof(CRMMDAgreementSpecsTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAgreementSpecsTypeDataAccess(CurrentContext);
            }

            return (ICRMMDAgreementSpecsTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDAgreementTypeEntity

        [DebuggerStepThrough()]
        public override ICRMMDAgreementTypeDataAccess CreateCRMMDAgreementTypeDataAccess()
        {
            string type = typeof(CRMMDAgreementTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAgreementTypeDataAccess(CurrentContext);
            }

            return (ICRMMDAgreementTypeDataAccess)CurrentContext[type];
        }

        #endregion
        
        #region CRMMDAgreementVariableEntity

        [DebuggerStepThrough()]
        public override ICRMMDAgreementVariableDataAccess CreateCRMMDAgreementVariableDataAccess()
        {
            string type = typeof(CRMMDAgreementVariableDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDAgreementVariableDataAccess(CurrentContext);
            }

            return (ICRMMDAgreementVariableDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDPaymentApprovalStatusEntity

        [DebuggerStepThrough()]
        public override ICRMMDPaymentApprovalStatusDataAccess CreateCRMMDPaymentApprovalStatusDataAccess()
        {
            string type = typeof(CRMMDPaymentApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDPaymentApprovalStatusDataAccess(CurrentContext);
            }

            return (ICRMMDPaymentApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMMDPaymentCategoryEntity

        [DebuggerStepThrough()]
        public override ICRMMDPaymentCategoryDataAccess CreateCRMMDPaymentCategoryDataAccess()
        {
            string type = typeof(CRMMDPaymentCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMMDPaymentCategoryDataAccess(CurrentContext);
            }

            return (ICRMMDPaymentCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDGenderEntity

        [DebuggerStepThrough()]
        public override IMDGenderDataAccess CreateMDGenderDataAccess()
        {
            string type = typeof(MDGenderDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDGenderDataAccess(CurrentContext);
            }

            return (IMDGenderDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDProcessAssignedResourceApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IBDMDProcessAssignedResourceApprovalStatusDataAccess CreateBDMDProcessAssignedResourceApprovalStatusDataAccess()
        {
            string type = typeof(BDMDProcessAssignedResourceApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDProcessAssignedResourceApprovalStatusDataAccess(CurrentContext);
            }

            return (IBDMDProcessAssignedResourceApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDProcessCategoryEntity

        [DebuggerStepThrough()]
        public override IBDMDProcessCategoryDataAccess CreateBDMDProcessCategoryDataAccess()
        {
            string type = typeof(BDMDProcessCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDProcessCategoryDataAccess(CurrentContext);
            }

            return (IBDMDProcessCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDRepeatCategoryEntity

        [DebuggerStepThrough()]
        public override IBDMDRepeatCategoryDataAccess CreateBDMDRepeatCategoryDataAccess()
        {
            string type = typeof(BDMDRepeatCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDRepeatCategoryDataAccess(CurrentContext);
            }

            return (IBDMDRepeatCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDTaskEntity

        [DebuggerStepThrough()]
        public override IBDMDTaskDataAccess CreateBDMDTaskDataAccess()
        {
            string type = typeof(BDMDTaskDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDTaskDataAccess(CurrentContext);
            }

            return (IBDMDTaskDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDTaskCategoryEntity

        [DebuggerStepThrough()]
        public override IBDMDTaskCategoryDataAccess CreateBDMDTaskCategoryDataAccess()
        {
            string type = typeof(BDMDTaskCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDTaskCategoryDataAccess(CurrentContext);
            }

            return (IBDMDTaskCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDMDTaskRepeatEntity

        [DebuggerStepThrough()]
        public override IBDMDTaskRepeatDataAccess CreateBDMDTaskRepeatDataAccess()
        {
            string type = typeof(BDMDTaskRepeatDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDMDTaskRepeatDataAccess(CurrentContext);
            }

            return (IBDMDTaskRepeatDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMDBillFloorDetailCategoryEntity

        [DebuggerStepThrough()]
        public override ICMMDBillFloorDetailCategoryDataAccess CreateCMMDBillFloorDetailCategoryDataAccess()
        {
            string type = typeof(CMMDBillFloorDetailCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMDBillFloorDetailCategoryDataAccess(CurrentContext);
            }

            return (ICMMDBillFloorDetailCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEvaluationCriteriaEntity

        [DebuggerStepThrough()]
        public override IMDEvaluationCriteriaDataAccess CreateMDEvaluationCriteriaDataAccess()
        {
            string type = typeof(MDEvaluationCriteriaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEvaluationCriteriaDataAccess(CurrentContext);
            }

            return (IMDEvaluationCriteriaDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEvaluationSessionCategoryEntity

        [DebuggerStepThrough()]
        public override IMDEvaluationSessionCategoryDataAccess CreateMDEvaluationSessionCategoryDataAccess()
        {
            string type = typeof(MDEvaluationSessionCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEvaluationSessionCategoryDataAccess(CurrentContext);
            }

            return (IMDEvaluationSessionCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEvaluationSessionStatusEntity

        [DebuggerStepThrough()]
        public override IMDEvaluationSessionStatusDataAccess CreateMDEvaluationSessionStatusDataAccess()
        {
            string type = typeof(MDEvaluationSessionStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEvaluationSessionStatusDataAccess(CurrentContext);
            }

            return (IMDEvaluationSessionStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEvaluatedByEntity

        [DebuggerStepThrough()]
        public override IMDEvaluatedByDataAccess CreateMDEvaluatedByDataAccess()
        {
            string type = typeof(MDEvaluatedByDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEvaluatedByDataAccess(CurrentContext);
            }

            return (IMDEvaluatedByDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEvaluationCriteriaCategoryEntity

        [DebuggerStepThrough()]
        public override IMDEvaluationCriteriaCategoryDataAccess CreateMDEvaluationCriteriaCategoryDataAccess()
        {
            string type = typeof(MDEvaluationCriteriaCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEvaluationCriteriaCategoryDataAccess(CurrentContext);
            }

            return (IMDEvaluationCriteriaCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSupervisorTypeEntity

        [DebuggerStepThrough()]
        public override IMDSupervisorTypeDataAccess CreateMDSupervisorTypeDataAccess()
        {
            string type = typeof(MDSupervisorTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSupervisorTypeDataAccess(CurrentContext);
            }

            return (IMDSupervisorTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDFloorUnitLocationCategoryEntity

        [DebuggerStepThrough()]
        public override IMDFloorUnitLocationCategoryDataAccess CreateMDFloorUnitLocationCategoryDataAccess()
        {
            string type = typeof(MDFloorUnitLocationCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDFloorUnitLocationCategoryDataAccess(CurrentContext);
            }

            return (IMDFloorUnitLocationCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDOutsourceCategoryEntity

        [DebuggerStepThrough()]
        public override IMDOutsourceCategoryDataAccess CreateMDOutsourceCategoryDataAccess()
        {
            string type = typeof(MDOutsourceCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDOutsourceCategoryDataAccess(CurrentContext);
            }

            return (IMDOutsourceCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMDEventCategoryEntity

        [DebuggerStepThrough()]
        public override ICMNMDEventCategoryDataAccess CreateCMNMDEventCategoryDataAccess()
        {
            string type = typeof(CMNMDEventCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMDEventCategoryDataAccess(CurrentContext);
            }

            return (ICMNMDEventCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMDEventIdentityCategoryEntity

        [DebuggerStepThrough()]
        public override ICMNMDEventIdentityCategoryDataAccess CreateCMNMDEventIdentityCategoryDataAccess()
        {
            string type = typeof(CMNMDEventIdentityCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMDEventIdentityCategoryDataAccess(CurrentContext);
            }

            return (ICMNMDEventIdentityCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMDEventOptionEntity

        [DebuggerStepThrough()]
        public override ICMNMDEventOptionDataAccess CreateCMNMDEventOptionDataAccess()
        {
            string type = typeof(CMNMDEventOptionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMDEventOptionDataAccess(CurrentContext);
            }

            return (ICMNMDEventOptionDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMDEventStatusEntity

        [DebuggerStepThrough()]
        public override ICMNMDEventStatusDataAccess CreateCMNMDEventStatusDataAccess()
        {
            string type = typeof(CMNMDEventStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMDEventStatusDataAccess(CurrentContext);
            }

            return (ICMNMDEventStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMDSharedSettingEntity

        [DebuggerStepThrough()]
        public override ICMNMDSharedSettingDataAccess CreateCMNMDSharedSettingDataAccess()
        {
            string type = typeof(CMNMDSharedSettingDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMDSharedSettingDataAccess(CurrentContext);
            }

            return (ICMNMDSharedSettingDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDArtGalleriaLocationEntity

        [DebuggerStepThrough()]
        public override IMDArtGalleriaLocationDataAccess CreateMDArtGalleriaLocationDataAccess()
        {
            string type = typeof(MDArtGalleriaLocationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDArtGalleriaLocationDataAccess(CurrentContext);
            }

            return (IMDArtGalleriaLocationDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAssetEntity

        [DebuggerStepThrough()]
        public override IMDAssetDataAccess CreateMDAssetDataAccess()
        {
            string type = typeof(MDAssetDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAssetDataAccess(CurrentContext);
            }

            return (IMDAssetDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAssetCateogryEntity

        [DebuggerStepThrough()]
        public override IMDAssetCateogryDataAccess CreateMDAssetCateogryDataAccess()
        {
            string type = typeof(MDAssetCateogryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAssetCateogryDataAccess(CurrentContext);
            }

            return (IMDAssetCateogryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAssetConditionEntity

        [DebuggerStepThrough()]
        public override IMDAssetConditionDataAccess CreateMDAssetConditionDataAccess()
        {
            string type = typeof(MDAssetConditionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAssetConditionDataAccess(CurrentContext);
            }

            return (IMDAssetConditionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAssetOwnerTypeEntity

        [DebuggerStepThrough()]
        public override IMDAssetOwnerTypeDataAccess CreateMDAssetOwnerTypeDataAccess()
        {
            string type = typeof(MDAssetOwnerTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAssetOwnerTypeDataAccess(CurrentContext);
            }

            return (IMDAssetOwnerTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEventLocationCategoryEntity

        [DebuggerStepThrough()]
        public override IMDEventLocationCategoryDataAccess CreateMDEventLocationCategoryDataAccess()
        {
            string type = typeof(MDEventLocationCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEventLocationCategoryDataAccess(CurrentContext);
            }

            return (IMDEventLocationCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSurveyBuildingStatusEntity

        [DebuggerStepThrough()]
        public override IMDSurveyBuildingStatusDataAccess CreateMDSurveyBuildingStatusDataAccess()
        {
            string type = typeof(MDSurveyBuildingStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSurveyBuildingStatusDataAccess(CurrentContext);
            }

            return (IMDSurveyBuildingStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSurveyOwnerTypeEntity

        [DebuggerStepThrough()]
        public override IMDSurveyOwnerTypeDataAccess CreateMDSurveyOwnerTypeDataAccess()
        {
            string type = typeof(MDSurveyOwnerTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSurveyOwnerTypeDataAccess(CurrentContext);
            }

            return (IMDSurveyOwnerTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSurveySourceInformationEntity

        [DebuggerStepThrough()]
        public override IMDSurveySourceInformationDataAccess CreateMDSurveySourceInformationDataAccess()
        {
            string type = typeof(MDSurveySourceInformationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSurveySourceInformationDataAccess(CurrentContext);
            }

            return (IMDSurveySourceInformationDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDMailTextTypeEntity

        [DebuggerStepThrough()]
        public override IMDMailTextTypeDataAccess CreateMDMailTextTypeDataAccess()
        {
            string type = typeof(MDMailTextTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDMailTextTypeDataAccess(CurrentContext);
            }

            return (IMDMailTextTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEventInvitatedPersonTypeEntity

        [DebuggerStepThrough()]
        public override IMDEventInvitatedPersonTypeDataAccess CreateMDEventInvitatedPersonTypeDataAccess()
        {
            string type = typeof(MDEventInvitatedPersonTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEventInvitatedPersonTypeDataAccess(CurrentContext);
            }

            return (IMDEventInvitatedPersonTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAreaEntity

        [DebuggerStepThrough()]
        public override IMDAreaDataAccess CreateMDAreaDataAccess()
        {
            string type = typeof(MDAreaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAreaDataAccess(CurrentContext);
            }

            return (IMDAreaDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAttendanceLeaveAndHolidayCategoryEntity

        [DebuggerStepThrough()]
        public override IMDAttendanceLeaveAndHolidayCategoryDataAccess CreateMDAttendanceLeaveAndHolidayCategoryDataAccess()
        {
            string type = typeof(MDAttendanceLeaveAndHolidayCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAttendanceLeaveAndHolidayCategoryDataAccess(CurrentContext);
            }

            return (IMDAttendanceLeaveAndHolidayCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAttendanceLeaveHolidayListEntity

        [DebuggerStepThrough()]
        public override IMDAttendanceLeaveHolidayListDataAccess CreateMDAttendanceLeaveHolidayListDataAccess()
        {
            string type = typeof(MDAttendanceLeaveHolidayListDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAttendanceLeaveHolidayListDataAccess(CurrentContext);
            }

            return (IMDAttendanceLeaveHolidayListDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDBankAccountCategoryEntity

        [DebuggerStepThrough()]
        public override IMDBankAccountCategoryDataAccess CreateMDBankAccountCategoryDataAccess()
        {
            string type = typeof(MDBankAccountCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDBankAccountCategoryDataAccess(CurrentContext);
            }

            return (IMDBankAccountCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDocumentCategoryEntity

        [DebuggerStepThrough()]
        public override IMDDocumentCategoryDataAccess CreateMDDocumentCategoryDataAccess()
        {
            string type = typeof(MDDocumentCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDocumentCategoryDataAccess(CurrentContext);
            }

            return (IMDDocumentCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDrivingLicenseCategoryEntity

        [DebuggerStepThrough()]
        public override IMDDrivingLicenseCategoryDataAccess CreateMDDrivingLicenseCategoryDataAccess()
        {
            string type = typeof(MDDrivingLicenseCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDrivingLicenseCategoryDataAccess(CurrentContext);
            }

            return (IMDDrivingLicenseCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEducationalDegreeEntity

        [DebuggerStepThrough()]
        public override IMDEducationalDegreeDataAccess CreateMDEducationalDegreeDataAccess()
        {
            string type = typeof(MDEducationalDegreeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEducationalDegreeDataAccess(CurrentContext);
            }

            return (IMDEducationalDegreeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeAdditionalInformationCategoryEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeAdditionalInformationCategoryDataAccess CreateMDEmployeeAdditionalInformationCategoryDataAccess()
        {
            string type = typeof(MDEmployeeAdditionalInformationCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeAdditionalInformationCategoryDataAccess(CurrentContext);
            }

            return (IMDEmployeeAdditionalInformationCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeAddressTypeEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeAddressTypeDataAccess CreateMDEmployeeAddressTypeDataAccess()
        {
            string type = typeof(MDEmployeeAddressTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeAddressTypeDataAccess(CurrentContext);
            }

            return (IMDEmployeeAddressTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeCompetencyLevelEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeCompetencyLevelDataAccess CreateMDEmployeeCompetencyLevelDataAccess()
        {
            string type = typeof(MDEmployeeCompetencyLevelDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeCompetencyLevelDataAccess(CurrentContext);
            }

            return (IMDEmployeeCompetencyLevelDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeContactTypeEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeContactTypeDataAccess CreateMDEmployeeContactTypeDataAccess()
        {
            string type = typeof(MDEmployeeContactTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeContactTypeDataAccess(CurrentContext);
            }

            return (IMDEmployeeContactTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeLanguageEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeLanguageDataAccess CreateMDEmployeeLanguageDataAccess()
        {
            string type = typeof(MDEmployeeLanguageDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeLanguageDataAccess(CurrentContext);
            }

            return (IMDEmployeeLanguageDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeLoanApprovalStatusEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeLoanApprovalStatusDataAccess CreateMDEmployeeLoanApprovalStatusDataAccess()
        {
            string type = typeof(MDEmployeeLoanApprovalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeLoanApprovalStatusDataAccess(CurrentContext);
            }

            return (IMDEmployeeLoanApprovalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeSkillEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeSkillDataAccess CreateMDEmployeeSkillDataAccess()
        {
            string type = typeof(MDEmployeeSkillDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeSkillDataAccess(CurrentContext);
            }

            return (IMDEmployeeSkillDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmploymentStatusEntity

        [DebuggerStepThrough()]
        public override IMDEmploymentStatusDataAccess CreateMDEmploymentStatusDataAccess()
        {
            string type = typeof(MDEmploymentStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmploymentStatusDataAccess(CurrentContext);
            }

            return (IMDEmploymentStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDFamilyRelationTypeEntity

        [DebuggerStepThrough()]
        public override IMDFamilyRelationTypeDataAccess CreateMDFamilyRelationTypeDataAccess()
        {
            string type = typeof(MDFamilyRelationTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDFamilyRelationTypeDataAccess(CurrentContext);
            }

            return (IMDFamilyRelationTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDHolidayAppliedStatusEntity

        [DebuggerStepThrough()]
        public override IMDHolidayAppliedStatusDataAccess CreateMDHolidayAppliedStatusDataAccess()
        {
            string type = typeof(MDHolidayAppliedStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDHolidayAppliedStatusDataAccess(CurrentContext);
            }

            return (IMDHolidayAppliedStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDHRNoticeTemplateTypeEntity

        [DebuggerStepThrough()]
        public override IMDHRNoticeTemplateTypeDataAccess CreateMDHRNoticeTemplateTypeDataAccess()
        {
            string type = typeof(MDHRNoticeTemplateTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDHRNoticeTemplateTypeDataAccess(CurrentContext);
            }

            return (IMDHRNoticeTemplateTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDLeaveApplicationApplicationStatusEntity

        [DebuggerStepThrough()]
        public override IMDLeaveApplicationApplicationStatusDataAccess CreateMDLeaveApplicationApplicationStatusDataAccess()
        {
            string type = typeof(MDLeaveApplicationApplicationStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDLeaveApplicationApplicationStatusDataAccess(CurrentContext);
            }

            return (IMDLeaveApplicationApplicationStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDLoanCategoryEntity

        [DebuggerStepThrough()]
        public override IMDLoanCategoryDataAccess CreateMDLoanCategoryDataAccess()
        {
            string type = typeof(MDLoanCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDLoanCategoryDataAccess(CurrentContext);
            }

            return (IMDLoanCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDMaritalStatusEntity

        [DebuggerStepThrough()]
        public override IMDMaritalStatusDataAccess CreateMDMaritalStatusDataAccess()
        {
            string type = typeof(MDMaritalStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDMaritalStatusDataAccess(CurrentContext);
            }

            return (IMDMaritalStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDPayCycleEntity

        [DebuggerStepThrough()]
        public override IMDPayCycleDataAccess CreateMDPayCycleDataAccess()
        {
            string type = typeof(MDPayCycleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDPayCycleDataAccess(CurrentContext);
            }

            return (IMDPayCycleDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDPayscaleEntity

        [DebuggerStepThrough()]
        public override IMDPayscaleDataAccess CreateMDPayscaleDataAccess()
        {
            string type = typeof(MDPayscaleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDPayscaleDataAccess(CurrentContext);
            }

            return (IMDPayscaleDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDReligionEntity

        [DebuggerStepThrough()]
        public override IMDReligionDataAccess CreateMDReligionDataAccess()
        {
            string type = typeof(MDReligionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDReligionDataAccess(CurrentContext);
            }

            return (IMDReligionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDResumeCategoryEntity

        [DebuggerStepThrough()]
        public override IMDResumeCategoryDataAccess CreateMDResumeCategoryDataAccess()
        {
            string type = typeof(MDResumeCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDResumeCategoryDataAccess(CurrentContext);
            }

            return (IMDResumeCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalaryRateDurationEntity

        [DebuggerStepThrough()]
        public override IMDSalaryRateDurationDataAccess CreateMDSalaryRateDurationDataAccess()
        {
            string type = typeof(MDSalaryRateDurationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalaryRateDurationDataAccess(CurrentContext);
            }

            return (IMDSalaryRateDurationDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalarySessionEntity

        [DebuggerStepThrough()]
        public override IMDSalarySessionDataAccess CreateMDSalarySessionDataAccess()
        {
            string type = typeof(MDSalarySessionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalarySessionDataAccess(CurrentContext);
            }

            return (IMDSalarySessionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalarySessionStatusEntity

        [DebuggerStepThrough()]
        public override IMDSalarySessionStatusDataAccess CreateMDSalarySessionStatusDataAccess()
        {
            string type = typeof(MDSalarySessionStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalarySessionStatusDataAccess(CurrentContext);
            }

            return (IMDSalarySessionStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalaryTaxTypeEntity

        [DebuggerStepThrough()]
        public override IMDSalaryTaxTypeDataAccess CreateMDSalaryTaxTypeDataAccess()
        {
            string type = typeof(MDSalaryTaxTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalaryTaxTypeDataAccess(CurrentContext);
            }

            return (IMDSalaryTaxTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalaryTypeEntity

        [DebuggerStepThrough()]
        public override IMDSalaryTypeDataAccess CreateMDSalaryTypeDataAccess()
        {
            string type = typeof(MDSalaryTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalaryTypeDataAccess(CurrentContext);
            }

            return (IMDSalaryTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDVisaStatusEntity

        [DebuggerStepThrough()]
        public override IMDVisaStatusDataAccess CreateMDVisaStatusDataAccess()
        {
            string type = typeof(MDVisaStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDVisaStatusDataAccess(CurrentContext);
            }

            return (IMDVisaStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDEmployeeSalaryPaymentStatusEntity

        [DebuggerStepThrough()]
        public override IMDEmployeeSalaryPaymentStatusDataAccess CreateMDEmployeeSalaryPaymentStatusDataAccess()
        {
            string type = typeof(MDEmployeeSalaryPaymentStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDEmployeeSalaryPaymentStatusDataAccess(CurrentContext);
            }

            return (IMDEmployeeSalaryPaymentStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalaryDeducationCategoryEntity

        [DebuggerStepThrough()]
        public override IMDSalaryDeducationCategoryDataAccess CreateMDSalaryDeducationCategoryDataAccess()
        {
            string type = typeof(MDSalaryDeducationCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalaryDeducationCategoryDataAccess(CurrentContext);
            }

            return (IMDSalaryDeducationCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDLeaveCategoryEntity

        [DebuggerStepThrough()]
        public override IMDLeaveCategoryDataAccess CreateMDLeaveCategoryDataAccess()
        {
            string type = typeof(MDLeaveCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDLeaveCategoryDataAccess(CurrentContext);
            }

            return (IMDLeaveCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDistrictEntity

        [DebuggerStepThrough()]
        public override IMDDistrictDataAccess CreateMDDistrictDataAccess()
        {
            string type = typeof(MDDistrictDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDistrictDataAccess(CurrentContext);
            }

            return (IMDDistrictDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDDivisionEntity

        [DebuggerStepThrough()]
        public override IMDDivisionDataAccess CreateMDDivisionDataAccess()
        {
            string type = typeof(MDDivisionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDDivisionDataAccess(CurrentContext);
            }

            return (IMDDivisionDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAllowanceCategoryEntity

        [DebuggerStepThrough()]
        public override IMDAllowanceCategoryDataAccess CreateMDAllowanceCategoryDataAccess()
        {
            string type = typeof(MDAllowanceCategoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAllowanceCategoryDataAccess(CurrentContext);
            }

            return (IMDAllowanceCategoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDLeavePolicyEntity

        [DebuggerStepThrough()]
        public override IMDLeavePolicyDataAccess CreateMDLeavePolicyDataAccess()
        {
            string type = typeof(MDLeavePolicyDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDLeavePolicyDataAccess(CurrentContext);
            }

            return (IMDLeavePolicyDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region PRM

        #region PRMPreBOQEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDataAccess CreatePRMPreBOQDataAccess()
        {
            string type = typeof(PRMPreBOQDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQDetailEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDetailDataAccess CreatePRMPreBOQDetailDataAccess()
        {
            string type = typeof(PRMPreBOQDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDetailDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQTemplateEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQTemplateDataAccess CreatePRMPreBOQTemplateDataAccess()
        {
            string type = typeof(PRMPreBOQTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQTemplateDataAccess(CurrentContext);
            }

            return (IPRMPreBOQTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQTemplateItemMapEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQTemplateItemMapDataAccess CreatePRMPreBOQTemplateItemMapDataAccess()
        {
            string type = typeof(PRMPreBOQTemplateItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQTemplateItemMapDataAccess(CurrentContext);
            }

            return (IPRMPreBOQTemplateItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierDataAccess CreatePRMSupplierDataAccess()
        {
            string type = typeof(PRMSupplierDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierDataAccess(CurrentContext);
            }

            return (IPRMSupplierDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierAddressInfoEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierAddressInfoDataAccess CreatePRMSupplierAddressInfoDataAccess()
        {
            string type = typeof(PRMSupplierAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierAddressInfoDataAccess(CurrentContext);
            }

            return (IPRMSupplierAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierContactPersonEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierContactPersonDataAccess CreatePRMSupplierContactPersonDataAccess()
        {
            string type = typeof(PRMSupplierContactPersonDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierContactPersonDataAccess(CurrentContext);
            }

            return (IPRMSupplierContactPersonDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierBrandMapEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierBrandMapDataAccess CreatePRMSupplierBrandMapDataAccess()
        {
            string type = typeof(PRMSupplierBrandMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierBrandMapDataAccess(CurrentContext);
            }

            return (IPRMSupplierBrandMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMItemBrandMapEntity

        [DebuggerStepThrough()]
        public override IPRMItemBrandMapDataAccess CreatePRMItemBrandMapDataAccess()
        {
            string type = typeof(PRMItemBrandMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMItemBrandMapDataAccess(CurrentContext);
            }

            return (IPRMItemBrandMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemMapEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemMapDataAccess CreatePRMSupplierItemMapDataAccess()
        {
            string type = typeof(PRMSupplierItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemMapDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemMapHistoryEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemMapHistoryDataAccess CreatePRMSupplierItemMapHistoryDataAccess()
        {
            string type = typeof(PRMSupplierItemMapHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemMapHistoryDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemMapHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemCategoryMapEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemCategoryMapDataAccess CreatePRMSupplierItemCategoryMapDataAccess()
        {
            string type = typeof(PRMSupplierItemCategoryMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemCategoryMapDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemCategoryMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDataAccess CreatePRMBOQDataAccess()
        {
            string type = typeof(PRMBOQDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDataAccess(CurrentContext);
            }

            return (IPRMBOQDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQDetailEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDetailDataAccess CreatePRMBOQDetailDataAccess()
        {
            string type = typeof(PRMBOQDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDetailDataAccess(CurrentContext);
            }

            return (IPRMBOQDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQDetailHistoryEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDetailHistoryDataAccess CreatePRMBOQDetailHistoryDataAccess()
        {
            string type = typeof(PRMBOQDetailHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDetailHistoryDataAccess(CurrentContext);
            }

            return (IPRMBOQDetailHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQTemplateEntity

        [DebuggerStepThrough()]
        public override IPRMBOQTemplateDataAccess CreatePRMBOQTemplateDataAccess()
        {
            string type = typeof(PRMBOQTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQTemplateDataAccess(CurrentContext);
            }

            return (IPRMBOQTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQTemplateItemMapEntity

        [DebuggerStepThrough()]
        public override IPRMBOQTemplateItemMapDataAccess CreatePRMBOQTemplateItemMapDataAccess()
        {
            string type = typeof(PRMBOQTemplateItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQTemplateItemMapDataAccess(CurrentContext);
            }

            return (IPRMBOQTemplateItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQDetailHistoryEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDetailHistoryDataAccess CreatePRMPreBOQDetailHistoryDataAccess()
        {
            string type = typeof(PRMPreBOQDetailHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDetailHistoryDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDetailHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQFloorDetailEntity

        [DebuggerStepThrough()]
        public override IPRMBOQFloorDetailDataAccess CreatePRMBOQFloorDetailDataAccess()
        {
            string type = typeof(PRMBOQFloorDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQFloorDetailDataAccess(CurrentContext);
            }

            return (IPRMBOQFloorDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceiveEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceiveDataAccess CreatePRMMaterialReceiveDataAccess()
        {
            string type = typeof(PRMMaterialReceiveDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceiveDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceiveDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceiveItemMapEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceiveItemMapDataAccess CreatePRMMaterialReceiveItemMapDataAccess()
        {
            string type = typeof(PRMMaterialReceiveItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceiveItemMapDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceiveItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderDataAccess CreatePRMWorkOrderDataAccess()
        {
            string type = typeof(PRMWorkOrderDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemMapEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemMapDataAccess CreatePRMWorkOrderItemMapDataAccess()
        {
            string type = typeof(PRMWorkOrderItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemMapDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderPaymentTermEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderPaymentTermDataAccess CreatePRMWorkOrderPaymentTermDataAccess()
        {
            string type = typeof(PRMWorkOrderPaymentTermDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderPaymentTermDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderPaymentTermDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemDetailEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemDetailDataAccess CreatePRMWorkOrderItemDetailDataAccess()
        {
            string type = typeof(PRMWorkOrderItemDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemDetailDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMAvailableBOQQtyForRequisitionEntity

        [DebuggerStepThrough()]
        public override IPRMAvailableBOQQtyForRequisitionDataAccess CreatePRMAvailableBOQQtyForRequisitionDataAccess()
        {
            string type = typeof(PRMAvailableBOQQtyForRequisitionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMAvailableBOQQtyForRequisitionDataAccess(CurrentContext);
            }

            return (IPRMAvailableBOQQtyForRequisitionDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQFloorDetailEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQFloorDetailDataAccess CreatePRMPreBOQFloorDetailDataAccess()
        {
            string type = typeof(PRMPreBOQFloorDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQFloorDetailDataAccess(CurrentContext);
            }

            return (IPRMPreBOQFloorDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemFloorDetailEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemFloorDetailDataAccess CreatePRMWorkOrderItemFloorDetailDataAccess()
        {
            string type = typeof(PRMWorkOrderItemFloorDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemFloorDetailDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemFloorDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region OT

        #region OTIssueEntity

        [DebuggerStepThrough()]
        public override IOTIssueDataAccess CreateOTIssueDataAccess()
        {
            string type = typeof(OTIssueDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueDataAccess(CurrentContext);
            }

            return (IOTIssueDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueAssignedResourceEntity

        [DebuggerStepThrough()]
        public override IOTIssueAssignedResourceDataAccess CreateOTIssueAssignedResourceDataAccess()
        {
            string type = typeof(OTIssueAssignedResourceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueAssignedResourceDataAccess(CurrentContext);
            }

            return (IOTIssueAssignedResourceDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueUploadInfoEntity

        [DebuggerStepThrough()]
        public override IOTIssueUploadInfoDataAccess CreateOTIssueUploadInfoDataAccess()
        {
            string type = typeof(OTIssueUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueUploadInfoDataAccess(CurrentContext);
            }

            return (IOTIssueUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueWatchListEntity

        [DebuggerStepThrough()]
        public override IOTIssueWatchListDataAccess CreateOTIssueWatchListDataAccess()
        {
            string type = typeof(OTIssueWatchListDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueWatchListDataAccess(CurrentContext);
            }

            return (IOTIssueWatchListDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTScheduleEntity

        [DebuggerStepThrough()]
        public override IOTScheduleDataAccess CreateOTScheduleDataAccess()
        {
            string type = typeof(OTScheduleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTScheduleDataAccess(CurrentContext);
            }

            return (IOTScheduleDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTScheduleResourceEntity

        [DebuggerStepThrough()]
        public override IOTScheduleResourceDataAccess CreateOTScheduleResourceDataAccess()
        {
            string type = typeof(OTScheduleResourceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTScheduleResourceDataAccess(CurrentContext);
            }

            return (IOTScheduleResourceDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region CM

        #region CMProjectScheduleTemplateEntity

        [DebuggerStepThrough()]
        public override ICMProjectScheduleTemplateDataAccess CreateCMProjectScheduleTemplateDataAccess()
        {
            string type = typeof(CMProjectScheduleTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMProjectScheduleTemplateDataAccess(CurrentContext);
            }

            return (ICMProjectScheduleTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMProjectScheduleTemplateItemMapEntity

        [DebuggerStepThrough()]
        public override ICMProjectScheduleTemplateItemMapDataAccess CreateCMProjectScheduleTemplateItemMapDataAccess()
        {
            string type = typeof(CMProjectScheduleTemplateItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMProjectScheduleTemplateItemMapDataAccess(CurrentContext);
            }

            return (ICMProjectScheduleTemplateItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConstructionToolEntity

        [DebuggerStepThrough()]
        public override ICMConstructionToolDataAccess CreateCMConstructionToolDataAccess()
        {
            string type = typeof(CMConstructionToolDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConstructionToolDataAccess(CurrentContext);
            }

            return (ICMConstructionToolDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConstructionToolDetailEntity

        [DebuggerStepThrough()]
        public override ICMConstructionToolDetailDataAccess CreateCMConstructionToolDetailDataAccess()
        {
            string type = typeof(CMConstructionToolDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConstructionToolDetailDataAccess(CurrentContext);
            }

            return (ICMConstructionToolDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorEntity

        [DebuggerStepThrough()]
        public override ICMContractorDataAccess CreateCMContractorDataAccess()
        {
            string type = typeof(CMContractorDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorDataAccess(CurrentContext);
            }

            return (ICMContractorDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorContactPersonEntity

        [DebuggerStepThrough()]
        public override ICMContractorContactPersonDataAccess CreateCMContractorContactPersonDataAccess()
        {
            string type = typeof(CMContractorContactPersonDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorContactPersonDataAccess(CurrentContext);
            }

            return (ICMContractorContactPersonDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorEquipmentListEntity

        [DebuggerStepThrough()]
        public override ICMContractorEquipmentListDataAccess CreateCMContractorEquipmentListDataAccess()
        {
            string type = typeof(CMContractorEquipmentListDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorEquipmentListDataAccess(CurrentContext);
            }

            return (ICMContractorEquipmentListDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorLicenceEntity

        [DebuggerStepThrough()]
        public override ICMContractorLicenceDataAccess CreateCMContractorLicenceDataAccess()
        {
            string type = typeof(CMContractorLicenceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorLicenceDataAccess(CurrentContext);
            }

            return (ICMContractorLicenceDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorMajorProjectExecutedEntity

        [DebuggerStepThrough()]
        public override ICMContractorMajorProjectExecutedDataAccess CreateCMContractorMajorProjectExecutedDataAccess()
        {
            string type = typeof(CMContractorMajorProjectExecutedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorMajorProjectExecutedDataAccess(CurrentContext);
            }

            return (ICMContractorMajorProjectExecutedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMCriterionStatusRemarksEntity

        [DebuggerStepThrough()]
        public override ICMCriterionStatusRemarksDataAccess CreateCMCriterionStatusRemarksDataAccess()
        {
            string type = typeof(CMCriterionStatusRemarksDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMCriterionStatusRemarksDataAccess(CurrentContext);
            }

            return (ICMCriterionStatusRemarksDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorAddressInfoEntity

        [DebuggerStepThrough()]
        public override ICMContractorAddressInfoDataAccess CreateCMContractorAddressInfoDataAccess()
        {
            string type = typeof(CMContractorAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorAddressInfoDataAccess(CurrentContext);
            }

            return (ICMContractorAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMFinancialStrengthMajorWorkEntity

        [DebuggerStepThrough()]
        public override ICMFinancialStrengthMajorWorkDataAccess CreateCMFinancialStrengthMajorWorkDataAccess()
        {
            string type = typeof(CMFinancialStrengthMajorWorkDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMFinancialStrengthMajorWorkDataAccess(CurrentContext);
            }

            return (ICMFinancialStrengthMajorWorkDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractor_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMContractor_DetailedDataAccess CreateCMContractor_DetailedDataAccess()
        {
            string type = typeof(CMContractor_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractor_DetailedDataAccess(CurrentContext);
            }

            return (ICMContractor_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantEntity

        [DebuggerStepThrough()]
        public override ICMConsultantDataAccess CreateCMConsultantDataAccess()
        {
            string type = typeof(CMConsultantDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantDataAccess(CurrentContext);
            }

            return (ICMConsultantDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantAddressInfoEntity

        [DebuggerStepThrough()]
        public override ICMConsultantAddressInfoDataAccess CreateCMConsultantAddressInfoDataAccess()
        {
            string type = typeof(CMConsultantAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantAddressInfoDataAccess(CurrentContext);
            }

            return (ICMConsultantAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantAssignedWorkAreaEntity

        [DebuggerStepThrough()]
        public override ICMConsultantAssignedWorkAreaDataAccess CreateCMConsultantAssignedWorkAreaDataAccess()
        {
            string type = typeof(CMConsultantAssignedWorkAreaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantAssignedWorkAreaDataAccess(CurrentContext);
            }

            return (ICMConsultantAssignedWorkAreaDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantContactPersonEntity

        [DebuggerStepThrough()]
        public override ICMConsultantContactPersonDataAccess CreateCMConsultantContactPersonDataAccess()
        {
            string type = typeof(CMConsultantContactPersonDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantContactPersonDataAccess(CurrentContext);
            }

            return (ICMConsultantContactPersonDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantWorkAreaEntity

        [DebuggerStepThrough()]
        public override ICMConsultantWorkAreaDataAccess CreateCMConsultantWorkAreaDataAccess()
        {
            string type = typeof(CMConsultantWorkAreaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantWorkAreaDataAccess(CurrentContext);
            }

            return (ICMConsultantWorkAreaDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMWorkAreaStatusEntity

        [DebuggerStepThrough()]
        public override ICMWorkAreaStatusDataAccess CreateCMWorkAreaStatusDataAccess()
        {
            string type = typeof(CMWorkAreaStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMWorkAreaStatusDataAccess(CurrentContext);
            }

            return (ICMWorkAreaStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantEnlistedWorkAreaEntity

        [DebuggerStepThrough()]
        public override ICMConsultantEnlistedWorkAreaDataAccess CreateCMConsultantEnlistedWorkAreaDataAccess()
        {
            string type = typeof(CMConsultantEnlistedWorkAreaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantEnlistedWorkAreaDataAccess(CurrentContext);
            }

            return (ICMConsultantEnlistedWorkAreaDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMProjectMilestoneEntity

        [DebuggerStepThrough()]
        public override ICMProjectMilestoneDataAccess CreateCMProjectMilestoneDataAccess()
        {
            string type = typeof(CMProjectMilestoneDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMProjectMilestoneDataAccess(CurrentContext);
            }

            return (ICMProjectMilestoneDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConstructionTool_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConstructionTool_DetailedDataAccess CreateCMConstructionTool_DetailedDataAccess()
        {
            string type = typeof(CMConstructionTool_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConstructionTool_DetailedDataAccess(CurrentContext);
            }

            return (ICMConstructionTool_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConstructionToolDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConstructionToolDetail_DetailedDataAccess CreateCMConstructionToolDetail_DetailedDataAccess()
        {
            string type = typeof(CMConstructionToolDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConstructionToolDetail_DetailedDataAccess(CurrentContext);
            }

            return (ICMConstructionToolDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorAssignedWorkAreaEntity

        [DebuggerStepThrough()]
        public override ICMContractorAssignedWorkAreaDataAccess CreateCMContractorAssignedWorkAreaDataAccess()
        {
            string type = typeof(CMContractorAssignedWorkAreaDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorAssignedWorkAreaDataAccess(CurrentContext);
            }

            return (ICMContractorAssignedWorkAreaDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMeasurementBookEntity

        [DebuggerStepThrough()]
        public override ICMMeasurementBookDataAccess CreateCMMeasurementBookDataAccess()
        {
            string type = typeof(CMMeasurementBookDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMeasurementBookDataAccess(CurrentContext);
            }

            return (ICMMeasurementBookDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMeasurementBookDetailEntity

        [DebuggerStepThrough()]
        public override ICMMeasurementBookDetailDataAccess CreateCMMeasurementBookDetailDataAccess()
        {
            string type = typeof(CMMeasurementBookDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMeasurementBookDetailDataAccess(CurrentContext);
            }

            return (ICMMeasurementBookDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillEntity

        [DebuggerStepThrough()]
        public override ICMBillDataAccess CreateCMBillDataAccess()
        {
            string type = typeof(CMBillDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillDataAccess(CurrentContext);
            }

            return (ICMBillDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillUploadInfoEntity

        [DebuggerStepThrough()]
        public override ICMBillUploadInfoDataAccess CreateCMBillUploadInfoDataAccess()
        {
            string type = typeof(CMBillUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillUploadInfoDataAccess(CurrentContext);
            }

            return (ICMBillUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillRequisitionItemMapEntity

        [DebuggerStepThrough()]
        public override ICMBillRequisitionItemMapDataAccess CreateCMBillRequisitionItemMapDataAccess()
        {
            string type = typeof(CMBillRequisitionItemMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillRequisitionItemMapDataAccess(CurrentContext);
            }

            return (ICMBillRequisitionItemMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillMaterialReceiveMeasurementBookMapEntity

        [DebuggerStepThrough()]
        public override ICMBillMaterialReceiveMeasurementBookMapDataAccess CreateCMBillMaterialReceiveMeasurementBookMapDataAccess()
        {
            string type = typeof(CMBillMaterialReceiveMeasurementBookMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillMaterialReceiveMeasurementBookMapDataAccess(CurrentContext);
            }

            return (ICMBillMaterialReceiveMeasurementBookMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillFloorDetailEntity

        [DebuggerStepThrough()]
        public override ICMBillFloorDetailDataAccess CreateCMBillFloorDetailDataAccess()
        {
            string type = typeof(CMBillFloorDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillFloorDetailDataAccess(CurrentContext);
            }

            return (ICMBillFloorDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region REQ

        #region REQRequisitionEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionDataAccess CreateREQRequisitionDataAccess()
        {
            string type = typeof(REQRequisitionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionDataAccess(CurrentContext);
            }

            return (IREQRequisitionDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItemEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItemDataAccess CreateREQRequisitionItemDataAccess()
        {
            string type = typeof(REQRequisitionItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItemDataAccess(CurrentContext);
            }

            return (IREQRequisitionItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItemFloorDetailEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItemFloorDetailDataAccess CreateREQRequisitionItemFloorDetailDataAccess()
        {
            string type = typeof(REQRequisitionItemFloorDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItemFloorDetailDataAccess(CurrentContext);
            }

            return (IREQRequisitionItemFloorDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionUploadInfoEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionUploadInfoDataAccess CreateREQRequisitionUploadInfoDataAccess()
        {
            string type = typeof(REQRequisitionUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionUploadInfoDataAccess(CurrentContext);
            }

            return (IREQRequisitionUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region DMS

        #region DMSDocumentNodeEntity

        [DebuggerStepThrough()]
        public override IDMSDocumentNodeDataAccess CreateDMSDocumentNodeDataAccess()
        {
            string type = typeof(DMSDocumentNodeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSDocumentNodeDataAccess(CurrentContext);
            }

            return (IDMSDocumentNodeDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSFileMovementRegisterEntity

        [DebuggerStepThrough()]
        public override IDMSFileMovementRegisterDataAccess CreateDMSFileMovementRegisterDataAccess()
        {
            string type = typeof(DMSFileMovementRegisterDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSFileMovementRegisterDataAccess(CurrentContext);
            }

            return (IDMSFileMovementRegisterDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSFileTrackingEntity

        [DebuggerStepThrough()]
        public override IDMSFileTrackingDataAccess CreateDMSFileTrackingDataAccess()
        {
            string type = typeof(DMSFileTrackingDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSFileTrackingDataAccess(CurrentContext);
            }

            return (IDMSFileTrackingDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSReferenceLibraryEntity

        [DebuggerStepThrough()]
        public override IDMSReferenceLibraryDataAccess CreateDMSReferenceLibraryDataAccess()
        {
            string type = typeof(DMSReferenceLibraryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSReferenceLibraryDataAccess(CurrentContext);
            }

            return (IDMSReferenceLibraryDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region ACC

        #region ACCPrePayableStatementEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDataAccess CreateACCPrePayableStatementDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDetailEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDetailDataAccess CreateACCPrePayableStatementDetailDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDetailDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPostPayableStatementEntity

        [DebuggerStepThrough()]
        public override IACCPostPayableStatementDataAccess CreateACCPostPayableStatementDataAccess()
        {
            string type = typeof(ACCPostPayableStatementDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPostPayableStatementDataAccess(CurrentContext);
            }

            return (IACCPostPayableStatementDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPostPayableStatementDetailEntity

        [DebuggerStepThrough()]
        public override IACCPostPayableStatementDetailDataAccess CreateACCPostPayableStatementDetailDataAccess()
        {
            string type = typeof(ACCPostPayableStatementDetailDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPostPayableStatementDetailDataAccess(CurrentContext);
            }

            return (IACCPostPayableStatementDetailDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region AC

        #region ACAccountEntity

        [DebuggerStepThrough()]
        public override IACAccountDataAccess CreateACAccountDataAccess()
        {
            string type = typeof(ACAccountDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountDataAccess(CurrentContext);
            }

            return (IACAccountDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountGroupEntity

        [DebuggerStepThrough()]
        public override IACAccountGroupDataAccess CreateACAccountGroupDataAccess()
        {
            string type = typeof(ACAccountGroupDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountGroupDataAccess(CurrentContext);
            }

            return (IACAccountGroupDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountStatusEntity

        [DebuggerStepThrough()]
        public override IACAccountStatusDataAccess CreateACAccountStatusDataAccess()
        {
            string type = typeof(ACAccountStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountStatusDataAccess(CurrentContext);
            }

            return (IACAccountStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACClassEntity

        [DebuggerStepThrough()]
        public override IACClassDataAccess CreateACClassDataAccess()
        {
            string type = typeof(ACClassDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACClassDataAccess(CurrentContext);
            }

            return (IACClassDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACClassTypeEntity

        [DebuggerStepThrough()]
        public override IACClassTypeDataAccess CreateACClassTypeDataAccess()
        {
            string type = typeof(ACClassTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACClassTypeDataAccess(CurrentContext);
            }

            return (IACClassTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDataAccess CreateACBankAccountDataAccess()
        {
            string type = typeof(ACBankAccountDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDataAccess(CurrentContext);
            }

            return (IACBankAccountDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBudgetEntity

        [DebuggerStepThrough()]
        public override IACBudgetDataAccess CreateACBudgetDataAccess()
        {
            string type = typeof(ACBudgetDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBudgetDataAccess(CurrentContext);
            }

            return (IACBudgetDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCurrencyExchangeRatesEntity

        [DebuggerStepThrough()]
        public override IACCurrencyExchangeRatesDataAccess CreateACCurrencyExchangeRatesDataAccess()
        {
            string type = typeof(ACCurrencyExchangeRatesDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCurrencyExchangeRatesDataAccess(CurrentContext);
            }

            return (IACCurrencyExchangeRatesDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACFiscalYearEntity

        [DebuggerStepThrough()]
        public override IACFiscalYearDataAccess CreateACFiscalYearDataAccess()
        {
            string type = typeof(ACFiscalYearDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACFiscalYearDataAccess(CurrentContext);
            }

            return (IACFiscalYearDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCompanyInfoEntity

        [DebuggerStepThrough()]
        public override IACCompanyInfoDataAccess CreateACCompanyInfoDataAccess()
        {
            string type = typeof(ACCompanyInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCompanyInfoDataAccess(CurrentContext);
            }

            return (IACCompanyInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACDimensionEntity

        [DebuggerStepThrough()]
        public override IACDimensionDataAccess CreateACDimensionDataAccess()
        {
            string type = typeof(ACDimensionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACDimensionDataAccess(CurrentContext);
            }

            return (IACDimensionDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACItemAccountMapEntity

        [DebuggerStepThrough()]
        public override IACItemAccountMapDataAccess CreateACItemAccountMapDataAccess()
        {
            string type = typeof(ACItemAccountMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACItemAccountMapDataAccess(CurrentContext);
            }

            return (IACItemAccountMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACItemGroupAccountMapEntity

        [DebuggerStepThrough()]
        public override IACItemGroupAccountMapDataAccess CreateACItemGroupAccountMapDataAccess()
        {
            string type = typeof(ACItemGroupAccountMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACItemGroupAccountMapDataAccess(CurrentContext);
            }

            return (IACItemGroupAccountMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTaxTypeEntity

        [DebuggerStepThrough()]
        public override IACTaxTypeDataAccess CreateACTaxTypeDataAccess()
        {
            string type = typeof(ACTaxTypeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTaxTypeDataAccess(CurrentContext);
            }

            return (IACTaxTypeDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACDebitCreditRuleEntity

        [DebuggerStepThrough()]
        public override IACDebitCreditRuleDataAccess CreateACDebitCreditRuleDataAccess()
        {
            string type = typeof(ACDebitCreditRuleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACDebitCreditRuleDataAccess(CurrentContext);
            }

            return (IACDebitCreditRuleDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACDebitCreditRuleElementEntity

        [DebuggerStepThrough()]
        public override IACDebitCreditRuleElementDataAccess CreateACDebitCreditRuleElementDataAccess()
        {
            string type = typeof(ACDebitCreditRuleElementDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACDebitCreditRuleElementDataAccess(CurrentContext);
            }

            return (IACDebitCreditRuleElementDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACDepreciationMethodEntity

        [DebuggerStepThrough()]
        public override IACDepreciationMethodDataAccess CreateACDepreciationMethodDataAccess()
        {
            string type = typeof(ACDepreciationMethodDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACDepreciationMethodDataAccess(CurrentContext);
            }

            return (IACDepreciationMethodDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACJournalEntity

        [DebuggerStepThrough()]
        public override IACJournalDataAccess CreateACJournalDataAccess()
        {
            string type = typeof(ACJournalDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACJournalDataAccess(CurrentContext);
            }

            return (IACJournalDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACMDDebitCreditEntity

        [DebuggerStepThrough()]
        public override IACMDDebitCreditDataAccess CreateACMDDebitCreditDataAccess()
        {
            string type = typeof(ACMDDebitCreditDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACMDDebitCreditDataAccess(CurrentContext);
            }

            return (IACMDDebitCreditDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDepositEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDepositDataAccess CreateACBankAccountDepositDataAccess()
        {
            string type = typeof(ACBankAccountDepositDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDepositDataAccess(CurrentContext);
            }

            return (IACBankAccountDepositDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDepositItemEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDepositItemDataAccess CreateACBankAccountDepositItemDataAccess()
        {
            string type = typeof(ACBankAccountDepositItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDepositItemDataAccess(CurrentContext);
            }

            return (IACBankAccountDepositItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPaymentEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPaymentDataAccess CreateACBankAccountPaymentDataAccess()
        {
            string type = typeof(ACBankAccountPaymentDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPaymentDataAccess(CurrentContext);
            }

            return (IACBankAccountPaymentDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPaymentItemEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPaymentItemDataAccess CreateACBankAccountPaymentItemDataAccess()
        {
            string type = typeof(ACBankAccountPaymentItemDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPaymentItemDataAccess(CurrentContext);
            }

            return (IACBankAccountPaymentItemDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountResourceAccountMapEntity

        [DebuggerStepThrough()]
        public override IACAccountResourceAccountMapDataAccess CreateACAccountResourceAccountMapDataAccess()
        {
            string type = typeof(ACAccountResourceAccountMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountResourceAccountMapDataAccess(CurrentContext);
            }

            return (IACAccountResourceAccountMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountTransferEntity

        [DebuggerStepThrough()]
        public override IACBankAccountTransferDataAccess CreateACBankAccountTransferDataAccess()
        {
            string type = typeof(ACBankAccountTransferDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountTransferDataAccess(CurrentContext);
            }

            return (IACBankAccountTransferDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACPettyCashEntity

        [DebuggerStepThrough()]
        public override IACPettyCashDataAccess CreateACPettyCashDataAccess()
        {
            string type = typeof(ACPettyCashDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACPettyCashDataAccess(CurrentContext);
            }

            return (IACPettyCashDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournalEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournalDataAccess CreateACTemporaryJournalDataAccess()
        {
            string type = typeof(ACTemporaryJournalDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournalDataAccess(CurrentContext);
            }

            return (IACTemporaryJournalDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournalMasterEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournalMasterDataAccess CreateACTemporaryJournalMasterDataAccess()
        {
            string type = typeof(ACTemporaryJournalMasterDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournalMasterDataAccess(CurrentContext);
            }

            return (IACTemporaryJournalMasterDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTDSEntity

        [DebuggerStepThrough()]
        public override IACTDSDataAccess CreateACTDSDataAccess()
        {
            string type = typeof(ACTDSDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTDSDataAccess(CurrentContext);
            }

            return (IACTDSDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTDSHistoryEntity

        [DebuggerStepThrough()]
        public override IACTDSHistoryDataAccess CreateACTDSHistoryDataAccess()
        {
            string type = typeof(ACTDSHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTDSHistoryDataAccess(CurrentContext);
            }

            return (IACTDSHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACResourceBankAccountMapEntity

        [DebuggerStepThrough()]
        public override IACResourceBankAccountMapDataAccess CreateACResourceBankAccountMapDataAccess()
        {
            string type = typeof(ACResourceBankAccountMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACResourceBankAccountMapDataAccess(CurrentContext);
            }

            return (IACResourceBankAccountMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPaymentPostPayableStatementDetailMapEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPaymentPostPayableStatementDetailMapDataAccess CreateACBankAccountPaymentPostPayableStatementDetailMapDataAccess()
        {
            string type = typeof(ACBankAccountPaymentPostPayableStatementDetailMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPaymentPostPayableStatementDetailMapDataAccess(CurrentContext);
            }

            return (IACBankAccountPaymentPostPayableStatementDetailMapDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region CRM

        #region CRMCustomerEntity

        [DebuggerStepThrough()]
        public override ICRMCustomerDataAccess CreateCRMCustomerDataAccess()
        {
            string type = typeof(CRMCustomerDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMCustomerDataAccess(CurrentContext);
            }

            return (ICRMCustomerDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMCustomerAddressInfoEntity

        [DebuggerStepThrough()]
        public override ICRMCustomerAddressInfoDataAccess CreateCRMCustomerAddressInfoDataAccess()
        {
            string type = typeof(CRMCustomerAddressInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMCustomerAddressInfoDataAccess(CurrentContext);
            }

            return (ICRMCustomerAddressInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerAllotteeEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerAllotteeDataAccess CreateCRMBuyerAllotteeDataAccess()
        {
            string type = typeof(CRMBuyerAllotteeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerAllotteeDataAccess(CurrentContext);
            }

            return (ICRMBuyerAllotteeDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerBasicInfoEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerBasicInfoDataAccess CreateCRMBuyerBasicInfoDataAccess()
        {
            string type = typeof(CRMBuyerBasicInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerBasicInfoDataAccess(CurrentContext);
            }

            return (ICRMBuyerBasicInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerBookSpaceEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerBookSpaceDataAccess CreateCRMBuyerBookSpaceDataAccess()
        {
            string type = typeof(CRMBuyerBookSpaceDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerBookSpaceDataAccess(CurrentContext);
            }

            return (ICRMBuyerBookSpaceDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerInterestedRoomMapEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerInterestedRoomMapDataAccess CreateCRMBuyerInterestedRoomMapDataAccess()
        {
            string type = typeof(CRMBuyerInterestedRoomMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerInterestedRoomMapDataAccess(CurrentContext);
            }

            return (ICRMBuyerInterestedRoomMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMCommunicationEntity

        [DebuggerStepThrough()]
        public override ICRMCommunicationDataAccess CreateCRMCommunicationDataAccess()
        {
            string type = typeof(CRMCommunicationDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMCommunicationDataAccess(CurrentContext);
            }

            return (ICRMCommunicationDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMLandBasicInfoEntity

        [DebuggerStepThrough()]
        public override ICRMLandBasicInfoDataAccess CreateCRMLandBasicInfoDataAccess()
        {
            string type = typeof(CRMLandBasicInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMLandBasicInfoDataAccess(CurrentContext);
            }

            return (ICRMLandBasicInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMLandCurrentStatusEntity

        [DebuggerStepThrough()]
        public override ICRMLandCurrentStatusDataAccess CreateCRMLandCurrentStatusDataAccess()
        {
            string type = typeof(CRMLandCurrentStatusDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMLandCurrentStatusDataAccess(CurrentContext);
            }

            return (ICRMLandCurrentStatusDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMLandOwnerEntity

        [DebuggerStepThrough()]
        public override ICRMLandOwnerDataAccess CreateCRMLandOwnerDataAccess()
        {
            string type = typeof(CRMLandOwnerDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMLandOwnerDataAccess(CurrentContext);
            }

            return (ICRMLandOwnerDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreementEntity

        [DebuggerStepThrough()]
        public override ICRMAgreementDataAccess CreateCRMAgreementDataAccess()
        {
            string type = typeof(CRMAgreementDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreementDataAccess(CurrentContext);
            }

            return (ICRMAgreementDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreementSpecsEntity

        [DebuggerStepThrough()]
        public override ICRMAgreementSpecsDataAccess CreateCRMAgreementSpecsDataAccess()
        {
            string type = typeof(CRMAgreementSpecsDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreementSpecsDataAccess(CurrentContext);
            }

            return (ICRMAgreementSpecsDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreementTemplateEntity

        [DebuggerStepThrough()]
        public override ICRMAgreementTemplateDataAccess CreateCRMAgreementTemplateDataAccess()
        {
            string type = typeof(CRMAgreementTemplateDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreementTemplateDataAccess(CurrentContext);
            }

            return (ICRMAgreementTemplateDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreementVariableMapEntity

        [DebuggerStepThrough()]
        public override ICRMAgreementVariableMapDataAccess CreateCRMAgreementVariableMapDataAccess()
        {
            string type = typeof(CRMAgreementVariableMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreementVariableMapDataAccess(CurrentContext);
            }

            return (ICRMAgreementVariableMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentCollectionEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentCollectionDataAccess CreateCRMPaymentCollectionDataAccess()
        {
            string type = typeof(CRMPaymentCollectionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentCollectionDataAccess(CurrentContext);
            }

            return (ICRMPaymentCollectionDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentScheduleEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentScheduleDataAccess CreateCRMPaymentScheduleDataAccess()
        {
            string type = typeof(CRMPaymentScheduleDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentScheduleDataAccess(CurrentContext);
            }

            return (ICRMPaymentScheduleDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentScheduleMapEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentScheduleMapDataAccess CreateCRMPaymentScheduleMapDataAccess()
        {
            string type = typeof(CRMPaymentScheduleMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentScheduleMapDataAccess(CurrentContext);
            }

            return (ICRMPaymentScheduleMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerChildrenInfoEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerChildrenInfoDataAccess CreateCRMBuyerChildrenInfoDataAccess()
        {
            string type = typeof(CRMBuyerChildrenInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerChildrenInfoDataAccess(CurrentContext);
            }

            return (ICRMBuyerChildrenInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyDataAccess CreateCRMSurveyDataAccess()
        {
            string type = typeof(CRMSurveyDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyDataAccess(CurrentContext);
            }

            return (ICRMSurveyDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyOwnerEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyOwnerDataAccess CreateCRMSurveyOwnerDataAccess()
        {
            string type = typeof(CRMSurveyOwnerDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyOwnerDataAccess(CurrentContext);
            }

            return (ICRMSurveyOwnerDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyOwnerContactPersonEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyOwnerContactPersonDataAccess CreateCRMSurveyOwnerContactPersonDataAccess()
        {
            string type = typeof(CRMSurveyOwnerContactPersonDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyOwnerContactPersonDataAccess(CurrentContext);
            }

            return (ICRMSurveyOwnerContactPersonDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyMasterEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyMasterDataAccess CreateCRMSurveyMasterDataAccess()
        {
            string type = typeof(CRMSurveyMasterDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyMasterDataAccess(CurrentContext);
            }

            return (ICRMSurveyMasterDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region KB

        #region KBUserTreeEntity

        [DebuggerStepThrough()]
        public override IKBUserTreeDataAccess CreateKBUserTreeDataAccess()
        {
            string type = typeof(KBUserTreeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTreeDataAccess(CurrentContext);
            }

            return (IKBUserTreeDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBUserTreeModifiedHistoryEntity

        [DebuggerStepThrough()]
        public override IKBUserTreeModifiedHistoryDataAccess CreateKBUserTreeModifiedHistoryDataAccess()
        {
            string type = typeof(KBUserTreeModifiedHistoryDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTreeModifiedHistoryDataAccess(CurrentContext);
            }

            return (IKBUserTreeModifiedHistoryDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBUserTreeSharedEntity

        [DebuggerStepThrough()]
        public override IKBUserTreeSharedDataAccess CreateKBUserTreeSharedDataAccess()
        {
            string type = typeof(KBUserTreeSharedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTreeSharedDataAccess(CurrentContext);
            }

            return (IKBUserTreeSharedDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBUserTreeUploadInfoEntity

        [DebuggerStepThrough()]
        public override IKBUserTreeUploadInfoDataAccess CreateKBUserTreeUploadInfoDataAccess()
        {
            string type = typeof(KBUserTreeUploadInfoDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTreeUploadInfoDataAccess(CurrentContext);
            }

            return (IKBUserTreeUploadInfoDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region Security

        #region ASMemberAspnetUsersMapEntity

        [DebuggerStepThrough()]
        public override IASMemberAspnetUsersMapDataAccess CreateASMemberAspnetUsersMapDataAccess()
        {
            string type = typeof(ASMemberAspnetUsersMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASMemberAspnetUsersMapDataAccess(CurrentContext);
            }

            return (IASMemberAspnetUsersMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASPhysicalSiteMapEntity

        [DebuggerStepThrough()]
        public override IASPhysicalSiteMapDataAccess CreateASPhysicalSiteMapDataAccess()
        {
            string type = typeof(ASPhysicalSiteMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASPhysicalSiteMapDataAccess(CurrentContext);
            }

            return (IASPhysicalSiteMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASPhysicalSiteMapControlEntity

        [DebuggerStepThrough()]
        public override IASPhysicalSiteMapControlDataAccess CreateASPhysicalSiteMapControlDataAccess()
        {
            string type = typeof(ASPhysicalSiteMapControlDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASPhysicalSiteMapControlDataAccess(CurrentContext);
            }

            return (IASPhysicalSiteMapControlDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASRolePermissionEntity

        [DebuggerStepThrough()]
        public override IASRolePermissionDataAccess CreateASRolePermissionDataAccess()
        {
            string type = typeof(ASRolePermissionDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASRolePermissionDataAccess(CurrentContext);
            }

            return (IASRolePermissionDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASSiteMapEntity

        [DebuggerStepThrough()]
        public override IASSiteMapDataAccess CreateASSiteMapDataAccess()
        {
            string type = typeof(ASSiteMapDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASSiteMapDataAccess(CurrentContext);
            }

            return (IASSiteMapDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASSiteMapNodeEntity

        [DebuggerStepThrough()]
        public override IASSiteMapNodeDataAccess CreateASSiteMapNodeDataAccess()
        {
            string type = typeof(ASSiteMapNodeDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASSiteMapNodeDataAccess(CurrentContext);
            }

            return (IASSiteMapNodeDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASUserPermissionExcludedEntity

        [DebuggerStepThrough()]
        public override IASUserPermissionExcludedDataAccess CreateASUserPermissionExcludedDataAccess()
        {
            string type = typeof(ASUserPermissionExcludedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASUserPermissionExcludedDataAccess(CurrentContext);
            }

            return (IASUserPermissionExcludedDataAccess)CurrentContext[type];
        }

        #endregion

        #region UserList_DetailedEntity

        [DebuggerStepThrough()]
        public override IUserList_DetailedDataAccess CreateUserList_DetailedDataAccess()
        {
            string type = typeof(UserList_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new UserList_DetailedDataAccess(CurrentContext);
            }

            return (IUserList_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ActivityLogEntity

        [DebuggerStepThrough()]
        public override IActivityLogDataAccess CreateActivityLogDataAccess()
        {
            string type = typeof(ActivityLogDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ActivityLogDataAccess(CurrentContext);
            }

            return (IActivityLogDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region StoreProcedure Detailed

        #region PRMPreBOQ_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQ_DetailedDataAccess CreatePRMPreBOQ_DetailedDataAccess()
        {
            string type = typeof(PRMPreBOQ_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQ_DetailedDataAccess(CurrentContext);
            }

            return (IPRMPreBOQ_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProject_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProject_DetailedDataAccess CreateBDProject_DetailedDataAccess()
        {
            string type = typeof(BDProject_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProject_DetailedDataAccess(CurrentContext);
            }

            return (IBDProject_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectAddressInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectAddressInfo_DetailedDataAccess CreateBDProjectAddressInfo_DetailedDataAccess()
        {
            string type = typeof(BDProjectAddressInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectAddressInfo_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectAddressInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectAssignedPerson_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectAssignedPerson_DetailedDataAccess CreateBDProjectAssignedPerson_DetailedDataAccess()
        {
            string type = typeof(BDProjectAssignedPerson_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectAssignedPerson_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectAssignedPerson_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectOtherInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectOtherInfo_DetailedDataAccess CreateBDProjectOtherInfo_DetailedDataAccess()
        {
            string type = typeof(BDProjectOtherInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectOtherInfo_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectOtherInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCity_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDCity_DetailedDataAccess CreateMDCity_DetailedDataAccess()
        {
            string type = typeof(MDCity_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCity_DetailedDataAccess(CurrentContext);
            }

            return (IMDCity_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCountry_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDCountry_DetailedDataAccess CreateMDCountry_DetailedDataAccess()
        {
            string type = typeof(MDCountry_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCountry_DetailedDataAccess(CurrentContext);
            }

            return (IMDCountry_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRHoliday_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRHoliday_DetailedDataAccess CreateHRHoliday_DetailedDataAccess()
        {
            string type = typeof(HRHoliday_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRHoliday_DetailedDataAccess(CurrentContext);
            }

            return (IHRHoliday_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMember_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRMember_DetailedDataAccess CreateHRMember_DetailedDataAccess()
        {
            string type = typeof(HRMember_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMember_DetailedDataAccess(CurrentContext);
            }

            return (IHRMember_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDIssueCategory_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDIssueCategory_DetailedDataAccess CreateMDIssueCategory_DetailedDataAccess()
        {
            string type = typeof(MDIssueCategory_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDIssueCategory_DetailedDataAccess(CurrentContext);
            }

            return (IMDIssueCategory_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDScheduleCategory_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDScheduleCategory_DetailedDataAccess CreateMDScheduleCategory_DetailedDataAccess()
        {
            string type = typeof(MDScheduleCategory_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDScheduleCategory_DetailedDataAccess(CurrentContext);
            }

            return (IMDScheduleCategory_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssue_DetailedEntity

        [DebuggerStepThrough()]
        public override IOTIssue_DetailedDataAccess CreateOTIssue_DetailedDataAccess()
        {
            string type = typeof(OTIssue_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssue_DetailedDataAccess(CurrentContext);
            }

            return (IOTIssue_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTSchedule_DetailedEntity

        [DebuggerStepThrough()]
        public override IOTSchedule_DetailedDataAccess CreateOTSchedule_DetailedDataAccess()
        {
            string type = typeof(OTSchedule_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTSchedule_DetailedDataAccess(CurrentContext);
            }

            return (IOTSchedule_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region Resource_DetailedEntity

        [DebuggerStepThrough()]
        public override IResource_DetailedDataAccess CreateResource_DetailedDataAccess()
        {
            string type = typeof(Resource_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new Resource_DetailedDataAccess(CurrentContext);
            }

            return (IResource_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASSiteMapNode_DetailedEntity

        [DebuggerStepThrough()]
        public override IASSiteMapNode_DetailedDataAccess CreateASSiteMapNode_DetailedDataAccess()
        {
            string type = typeof(ASSiteMapNode_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASSiteMapNode_DetailedDataAccess(CurrentContext);
            }

            return (IASSiteMapNode_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorAddressInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMContractorAddressInfo_DetailedDataAccess CreateCMContractorAddressInfo_DetailedDataAccess()
        {
            string type = typeof(CMContractorAddressInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorAddressInfo_DetailedDataAccess(CurrentContext);
            }

            return (ICMContractorAddressInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorEquipmentList_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMContractorEquipmentList_DetailedDataAccess CreateCMContractorEquipmentList_DetailedDataAccess()
        {
            string type = typeof(CMContractorEquipmentList_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorEquipmentList_DetailedDataAccess(CurrentContext);
            }

            return (ICMContractorEquipmentList_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantAddressInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConsultantAddressInfo_DetailedDataAccess CreateCMConsultantAddressInfo_DetailedDataAccess()
        {
            string type = typeof(CMConsultantAddressInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantAddressInfo_DetailedDataAccess(CurrentContext);
            }

            return (ICMConsultantAddressInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantAssignedWorkArea_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConsultantAssignedWorkArea_DetailedDataAccess CreateCMConsultantAssignedWorkArea_DetailedDataAccess()
        {
            string type = typeof(CMConsultantAssignedWorkArea_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantAssignedWorkArea_DetailedDataAccess(CurrentContext);
            }

            return (ICMConsultantAssignedWorkArea_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantEnlistedWorkArea_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConsultantEnlistedWorkArea_DetailedDataAccess CreateCMConsultantEnlistedWorkArea_DetailedDataAccess()
        {
            string type = typeof(CMConsultantEnlistedWorkArea_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantEnlistedWorkArea_DetailedDataAccess(CurrentContext);
            }

            return (ICMConsultantEnlistedWorkArea_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItem_DetailedEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItem_DetailedDataAccess CreateREQRequisitionItem_DetailedDataAccess()
        {
            string type = typeof(REQRequisitionItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItem_DetailedDataAccess(CurrentContext);
            }

            return (IREQRequisitionItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisition_DetailedEntity

        [DebuggerStepThrough()]
        public override IREQRequisition_DetailedDataAccess CreateREQRequisition_DetailedDataAccess()
        {
            string type = typeof(REQRequisition_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisition_DetailedDataAccess(CurrentContext);
            }

            return (IREQRequisition_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMProjectMilestone_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMProjectMilestone_DetailedDataAccess CreateCMProjectMilestone_DetailedDataAccess()
        {
            string type = typeof(CMProjectMilestone_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMProjectMilestone_DetailedDataAccess(CurrentContext);
            }

            return (ICMProjectMilestone_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplier_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMSupplier_DetailedDataAccess CreatePRMSupplier_DetailedDataAccess()
        {
            string type = typeof(PRMSupplier_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplier_DetailedDataAccess(CurrentContext);
            }

            return (IPRMSupplier_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierAddressInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierAddressInfo_DetailedDataAccess CreatePRMSupplierAddressInfo_DetailedDataAccess()
        {
            string type = typeof(PRMSupplierAddressInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierAddressInfo_DetailedDataAccess(CurrentContext);
            }

            return (IPRMSupplierAddressInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMCriterionStatusRemarks_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMCriterionStatusRemarks_DetailedDataAccess CreateCMCriterionStatusRemarks_DetailedDataAccess()
        {
            string type = typeof(CMCriterionStatusRemarks_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMCriterionStatusRemarks_DetailedDataAccess(CurrentContext);
            }

            return (ICMCriterionStatusRemarks_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNDashboardItem_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNDashboardItem_DetailedDataAccess CreateCMNDashboardItem_DetailedDataAccess()
        {
            string type = typeof(CMNDashboardItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNDashboardItem_DetailedDataAccess(CurrentContext);
            }

            return (ICMNDashboardItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNDashboardItemQuicklink_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNDashboardItemQuicklink_DetailedDataAccess CreateCMNDashboardItemQuicklink_DetailedDataAccess()
        {
            string type = typeof(CMNDashboardItemQuicklink_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNDashboardItemQuicklink_DetailedDataAccess(CurrentContext);
            }

            return (ICMNDashboardItemQuicklink_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierBrandMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierBrandMap_DetailedDataAccess CreatePRMSupplierBrandMap_DetailedDataAccess()
        {
            string type = typeof(PRMSupplierBrandMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierBrandMap_DetailedDataAccess(CurrentContext);
            }

            return (IPRMSupplierBrandMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemMap_DetailedDataAccess CreatePRMSupplierItemMap_DetailedDataAccess()
        {
            string type = typeof(PRMSupplierItemMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemMap_DetailedDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMItemBrandMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMItemBrandMap_DetailedDataAccess CreatePRMItemBrandMap_DetailedDataAccess()
        {
            string type = typeof(PRMItemBrandMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMItemBrandMap_DetailedDataAccess(CurrentContext);
            }

            return (IPRMItemBrandMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectHistory_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectHistory_DetailedDataAccess CreateBDProjectHistory_DetailedDataAccess()
        {
            string type = typeof(BDProjectHistory_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectHistory_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectHistory_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQFloorDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMBOQFloorDetail_DetailedDataAccess CreatePRMBOQFloorDetail_DetailedDataAccess()
        {
            string type = typeof(PRMBOQFloorDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQFloorDetail_DetailedDataAccess(CurrentContext);
            }

            return (IPRMBOQFloorDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDApprovalRuleDesignationMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDApprovalRuleDesignationMap_DetailedDataAccess CreateMDApprovalRuleDesignationMap_DetailedDataAccess()
        {
            string type = typeof(MDApprovalRuleDesignationMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDApprovalRuleDesignationMap_DetailedDataAccess(CurrentContext);
            }

            return (IMDApprovalRuleDesignationMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectFloor_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectFloor_DetailedDataAccess CreateBDProjectFloor_DetailedDataAccess()
        {
            string type = typeof(BDProjectFloor_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectFloor_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectFloor_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDFloor_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDFloor_DetailedDataAccess CreateMDFloor_DetailedDataAccess()
        {
            string type = typeof(MDFloor_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDFloor_DetailedDataAccess(CurrentContext);
            }

            return (IMDFloor_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQDetail_DetailedCustomEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDetail_DetailedCustomDataAccess CreatePRMBOQDetail_DetailedCustomDataAccess()
        {
            string type = typeof(PRMBOQDetail_DetailedCustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDetail_DetailedCustomDataAccess(CurrentContext);
            }

            return (IPRMBOQDetail_DetailedCustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQDetail_DetailedCustomEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDetail_DetailedCustomDataAccess CreatePRMPreBOQDetail_DetailedCustomDataAccess()
        {
            string type = typeof(PRMPreBOQDetail_DetailedCustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDetail_DetailedCustomDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDetail_DetailedCustomDataAccess)CurrentContext[type];
        }

        #endregion
        
        #region PRMWorkOrder_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrder_DetailedDataAccess CreatePRMWorkOrder_DetailedDataAccess()
        {
            string type = typeof(PRMWorkOrder_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrder_DetailedDataAccess(CurrentContext);
            }

            return (IPRMWorkOrder_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemMap_DetailedDataAccess CreatePRMWorkOrderItemMap_DetailedDataAccess()
        {
            string type = typeof(PRMWorkOrderItemMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemMap_DetailedDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceiveItemMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceiveItemMap_DetailedDataAccess CreatePRMMaterialReceiveItemMap_DetailedDataAccess()
        {
            string type = typeof(PRMMaterialReceiveItemMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceiveItemMap_DetailedDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceiveItemMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceive_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceive_DetailedDataAccess CreatePRMMaterialReceive_DetailedDataAccess()
        {
            string type = typeof(PRMMaterialReceive_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceive_DetailedDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceive_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemDetail_DetailedDataAccess CreatePRMWorkOrderItemDetail_DetailedDataAccess()
        {
            string type = typeof(PRMWorkOrderItemDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemDetail_DetailedDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSFileMovementRegister_DetailedEntity

        [DebuggerStepThrough()]
        public override IDMSFileMovementRegister_DetailedDataAccess CreateDMSFileMovementRegister_DetailedDataAccess()
        {
            string type = typeof(DMSFileMovementRegister_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSFileMovementRegister_DetailedDataAccess(CurrentContext);
            }

            return (IDMSFileMovementRegister_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSFileTracking_DetailedEntity

        [DebuggerStepThrough()]
        public override IDMSFileTracking_DetailedDataAccess CreateDMSFileTracking_DetailedDataAccess()
        {
            string type = typeof(DMSFileTracking_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSFileTracking_DetailedDataAccess(CurrentContext);
            }

            return (IDMSFileTracking_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSReferenceLibrary_DetailedEntity

        [DebuggerStepThrough()]
        public override IDMSReferenceLibrary_DetailedDataAccess CreateDMSReferenceLibrary_DetailedDataAccess()
        {
            string type = typeof(DMSReferenceLibrary_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSReferenceLibrary_DetailedDataAccess(CurrentContext);
            }

            return (IDMSReferenceLibrary_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMeasurementBook_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMMeasurementBook_DetailedDataAccess CreateCMMeasurementBook_DetailedDataAccess()
        {
            string type = typeof(CMMeasurementBook_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMeasurementBook_DetailedDataAccess(CurrentContext);
            }

            return (ICMMeasurementBook_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMeasurementBookDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMMeasurementBookDetail_DetailedDataAccess CreateCMMeasurementBookDetail_DetailedDataAccess()
        {
            string type = typeof(CMMeasurementBookDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMeasurementBookDetail_DetailedDataAccess(CurrentContext);
            }

            return (ICMMeasurementBookDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region APMemberFeedback_DetailedEntity

        [DebuggerStepThrough()]
        public override IAPMemberFeedback_DetailedDataAccess CreateAPMemberFeedback_DetailedDataAccess()
        {
            string type = typeof(APMemberFeedback_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APMemberFeedback_DetailedDataAccess(CurrentContext);
            }

            return (IAPMemberFeedback_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region APMemberFeedbackRemarks_DetailedEntity

        [DebuggerStepThrough()]
        public override IAPMemberFeedbackRemarks_DetailedDataAccess CreateAPMemberFeedbackRemarks_DetailedDataAccess()
        {
            string type = typeof(APMemberFeedbackRemarks_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APMemberFeedbackRemarks_DetailedDataAccess(CurrentContext);
            }

            return (IAPMemberFeedbackRemarks_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region APWOPanelItemCategoryMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IAPWOPanelItemCategoryMap_DetailedDataAccess CreateAPWOPanelItemCategoryMap_DetailedDataAccess()
        {
            string type = typeof(APWOPanelItemCategoryMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APWOPanelItemCategoryMap_DetailedDataAccess(CurrentContext);
            }

            return (IAPWOPanelItemCategoryMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelForwardMember_DetailedEntity

        [DebuggerStepThrough()]
        public override IAPPanelForwardMember_DetailedDataAccess CreateAPPanelForwardMember_DetailedDataAccess()
        {
            string type = typeof(APPanelForwardMember_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelForwardMember_DetailedDataAccess(CurrentContext);
            }

            return (IAPPanelForwardMember_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region APForwardInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IAPForwardInfo_DetailedDataAccess CreateAPForwardInfo_DetailedDataAccess()
        {
            string type = typeof(APForwardInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APForwardInfo_DetailedDataAccess(CurrentContext);
            }

            return (IAPForwardInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMContractorAssignedWorkArea_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMContractorAssignedWorkArea_DetailedDataAccess CreateCMContractorAssignedWorkArea_DetailedDataAccess()
        {
            string type = typeof(CMContractorAssignedWorkArea_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMContractorAssignedWorkArea_DetailedDataAccess(CurrentContext);
            }

            return (ICMContractorAssignedWorkArea_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBill_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMBill_DetailedDataAccess CreateCMBill_DetailedDataAccess()
        {
            string type = typeof(CMBill_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBill_DetailedDataAccess(CurrentContext);
            }

            return (ICMBill_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVCurrentStock_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVCurrentStock_DetailedDataAccess CreateINVCurrentStock_DetailedDataAccess()
        {
            string type = typeof(INVCurrentStock_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVCurrentStock_DetailedDataAccess(CurrentContext);
            }

            return (IINVCurrentStock_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStore_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVStore_DetailedDataAccess CreateINVStore_DetailedDataAccess()
        {
            string type = typeof(INVStore_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStore_DetailedDataAccess(CurrentContext);
            }

            return (IINVStore_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreUnit_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVStoreUnit_DetailedDataAccess CreateINVStoreUnit_DetailedDataAccess()
        {
            string type = typeof(INVStoreUnit_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreUnit_DetailedDataAccess(CurrentContext);
            }

            return (IINVStoreUnit_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreUnitItem_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVStoreUnitItem_DetailedDataAccess CreateINVStoreUnitItem_DetailedDataAccess()
        {
            string type = typeof(INVStoreUnitItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreUnitItem_DetailedDataAccess(CurrentContext);
            }

            return (IINVStoreUnitItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransaction_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVTransaction_DetailedDataAccess CreateINVTransaction_DetailedDataAccess()
        {
            string type = typeof(INVTransaction_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransaction_DetailedDataAccess(CurrentContext);
            }

            return (IINVTransaction_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreIssueNote_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVStoreIssueNote_DetailedDataAccess CreateINVStoreIssueNote_DetailedDataAccess()
        {
            string type = typeof(INVStoreIssueNote_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreIssueNote_DetailedDataAccess(CurrentContext);
            }

            return (IINVStoreIssueNote_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreIssueNoteItemMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVStoreIssueNoteItemMap_DetailedDataAccess CreateINVStoreIssueNoteItemMap_DetailedDataAccess()
        {
            string type = typeof(INVStoreIssueNoteItemMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreIssueNoteItemMap_DetailedDataAccess(CurrentContext);
            }

            return (IINVStoreIssueNoteItemMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransfer_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVTransfer_DetailedDataAccess CreateINVTransfer_DetailedDataAccess()
        {
            string type = typeof(INVTransfer_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransfer_DetailedDataAccess(CurrentContext);
            }

            return (IINVTransfer_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransferItem_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVTransferItem_DetailedDataAccess CreateINVTransferItem_DetailedDataAccess()
        {
            string type = typeof(INVTransferItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransferItem_DetailedDataAccess(CurrentContext);
            }

            return (IINVTransferItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPostPayableStatementDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IACCPostPayableStatementDetail_DetailedDataAccess CreateACCPostPayableStatementDetail_DetailedDataAccess()
        {
            string type = typeof(ACCPostPayableStatementDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPostPayableStatementDetail_DetailedDataAccess(CurrentContext);
            }

            return (IACCPostPayableStatementDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCRequisitionWorkOrderMRRDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IACCRequisitionWorkOrderMRRDetail_DetailedDataAccess CreateACCRequisitionWorkOrderMRRDetail_DetailedDataAccess()
        {
            string type = typeof(ACCRequisitionWorkOrderMRRDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCRequisitionWorkOrderMRRDetail_DetailedDataAccess(CurrentContext);
            }

            return (IACCRequisitionWorkOrderMRRDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillRequisitionItemMap_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMBillRequisitionItemMap_DetailedDataAccess CreateCMBillRequisitionItemMap_DetailedDataAccess()
        {
            string type = typeof(CMBillRequisitionItemMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillRequisitionItemMap_DetailedDataAccess(CurrentContext);
            }

            return (ICMBillRequisitionItemMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccount_DetailedEntity

        [DebuggerStepThrough()]
        public override IACAccount_DetailedDataAccess CreateACAccount_DetailedDataAccess()
        {
            string type = typeof(ACAccount_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccount_DetailedDataAccess(CurrentContext);
            }

            return (IACAccount_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountGroup_DetailedEntity

        [DebuggerStepThrough()]
        public override IACAccountGroup_DetailedDataAccess CreateACAccountGroup_DetailedDataAccess()
        {
            string type = typeof(ACAccountGroup_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountGroup_DetailedDataAccess(CurrentContext);
            }

            return (IACAccountGroup_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACClass_DetailedEntity

        [DebuggerStepThrough()]
        public override IACClass_DetailedDataAccess CreateACClass_DetailedDataAccess()
        {
            string type = typeof(ACClass_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACClass_DetailedDataAccess(CurrentContext);
            }

            return (IACClass_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccount_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccount_DetailedDataAccess CreateACBankAccount_DetailedDataAccess()
        {
            string type = typeof(ACBankAccount_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccount_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccount_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBudget_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBudget_DetailedDataAccess CreateACBudget_DetailedDataAccess()
        {
            string type = typeof(ACBudget_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBudget_DetailedDataAccess(CurrentContext);
            }

            return (IACBudget_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCurrencyExchangeRates_DetailedEntity

        [DebuggerStepThrough()]
        public override IACCurrencyExchangeRates_DetailedDataAccess CreateACCurrencyExchangeRates_DetailedDataAccess()
        {
            string type = typeof(ACCurrencyExchangeRates_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCurrencyExchangeRates_DetailedDataAccess(CurrentContext);
            }

            return (IACCurrencyExchangeRates_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDCurrency_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDCurrency_DetailedDataAccess CreateMDCurrency_DetailedDataAccess()
        {
            string type = typeof(MDCurrency_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDCurrency_DetailedDataAccess(CurrentContext);
            }

            return (IMDCurrency_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDepositItem_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDepositItem_DetailedDataAccess CreateACBankAccountDepositItem_DetailedDataAccess()
        {
            string type = typeof(ACBankAccountDepositItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDepositItem_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccountDepositItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPaymentItem_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPaymentItem_DetailedDataAccess CreateACBankAccountPaymentItem_DetailedDataAccess()
        {
            string type = typeof(ACBankAccountPaymentItem_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPaymentItem_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccountPaymentItem_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACJournal_DetailedEntity

        [DebuggerStepThrough()]
        public override IACJournal_DetailedDataAccess CreateACJournal_DetailedDataAccess()
        {
            string type = typeof(ACJournal_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACJournal_DetailedDataAccess(CurrentContext);
            }

            return (IACJournal_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDeposit_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDeposit_DetailedDataAccess CreateACBankAccountDeposit_DetailedDataAccess()
        {
            string type = typeof(ACBankAccountDeposit_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDeposit_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccountDeposit_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPayment_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPayment_DetailedDataAccess CreateACBankAccountPayment_DetailedDataAccess()
        {
            string type = typeof(ACBankAccountPayment_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPayment_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccountPayment_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournal_DetailedEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournal_DetailedDataAccess CreateACTemporaryJournal_DetailedDataAccess()
        {
            string type = typeof(ACTemporaryJournal_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournal_DetailedDataAccess(CurrentContext);
            }

            return (IACTemporaryJournal_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournalMaster_DetailedEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournalMaster_DetailedDataAccess CreateACTemporaryJournalMaster_DetailedDataAccess()
        {
            string type = typeof(ACTemporaryJournalMaster_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournalMaster_DetailedDataAccess(CurrentContext);
            }

            return (IACTemporaryJournalMaster_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountTransfer_DetailedEntity

        [DebuggerStepThrough()]
        public override IACBankAccountTransfer_DetailedDataAccess CreateACBankAccountTransfer_DetailedDataAccess()
        {
            string type = typeof(ACBankAccountTransfer_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountTransfer_DetailedDataAccess(CurrentContext);
            }

            return (IACBankAccountTransfer_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNERPComment_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNERPComment_DetailedDataAccess CreateCMNERPComment_DetailedDataAccess()
        {
            string type = typeof(CMNERPComment_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNERPComment_DetailedDataAccess(CurrentContext);
            }

            return (ICMNERPComment_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBUserTreeShared_DetailedEntity

        [DebuggerStepThrough()]
        public override IKBUserTreeShared_DetailedDataAccess CreateKBUserTreeShared_DetailedDataAccess()
        {
            string type = typeof(KBUserTreeShared_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTreeShared_DetailedDataAccess(CurrentContext);
            }

            return (IKBUserTreeShared_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region KBUserTree_DetailedEntity

        [DebuggerStepThrough()]
        public override IKBUserTree_DetailedDataAccess CreateKBUserTree_DetailedDataAccess()
        {
            string type = typeof(KBUserTree_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new KBUserTree_DetailedDataAccess(CurrentContext);
            }

            return (IKBUserTree_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectFloorUnit_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectFloorUnit_DetailedDataAccess CreateBDProjectFloorUnit_DetailedDataAccess()
        {
            string type = typeof(BDProjectFloorUnit_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectFloorUnit_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectFloorUnit_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerBasicInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerBasicInfo_DetailedDataAccess CreateCRMBuyerBasicInfo_DetailedDataAccess()
        {
            string type = typeof(CRMBuyerBasicInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerBasicInfo_DetailedDataAccess(CurrentContext);
            }

            return (ICRMBuyerBasicInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerBookSpace_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerBookSpace_DetailedDataAccess CreateCRMBuyerBookSpace_DetailedDataAccess()
        {
            string type = typeof(CRMBuyerBookSpace_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerBookSpace_DetailedDataAccess(CurrentContext);
            }

            return (ICRMBuyerBookSpace_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerInterestedRoomMap_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerInterestedRoomMap_DetailedDataAccess CreateCRMBuyerInterestedRoomMap_DetailedDataAccess()
        {
            string type = typeof(CRMBuyerInterestedRoomMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerInterestedRoomMap_DetailedDataAccess(CurrentContext);
            }

            return (ICRMBuyerInterestedRoomMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMCommunication_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMCommunication_DetailedDataAccess CreateCRMCommunication_DetailedDataAccess()
        {
            string type = typeof(CRMCommunication_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMCommunication_DetailedDataAccess(CurrentContext);
            }

            return (ICRMCommunication_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMLandBasicInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMLandBasicInfo_DetailedDataAccess CreateCRMLandBasicInfo_DetailedDataAccess()
        {
            string type = typeof(CRMLandBasicInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMLandBasicInfo_DetailedDataAccess(CurrentContext);
            }

            return (ICRMLandBasicInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreement_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMAgreement_DetailedDataAccess CreateCRMAgreement_DetailedDataAccess()
        {
            string type = typeof(CRMAgreement_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreement_DetailedDataAccess(CurrentContext);
            }

            return (ICRMAgreement_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentCollection_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentCollection_DetailedDataAccess CreateCRMPaymentCollection_DetailedDataAccess()
        {
            string type = typeof(CRMPaymentCollection_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentCollection_DetailedDataAccess(CurrentContext);
            }

            return (ICRMPaymentCollection_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentSchedule_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentSchedule_DetailedDataAccess CreateCRMPaymentSchedule_DetailedDataAccess()
        {
            string type = typeof(CRMPaymentSchedule_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentSchedule_DetailedDataAccess(CurrentContext);
            }

            return (ICRMPaymentSchedule_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQFloorDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQFloorDetail_DetailedDataAccess CreatePRMPreBOQFloorDetail_DetailedDataAccess()
        {
            string type = typeof(PRMPreBOQFloorDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQFloorDetail_DetailedDataAccess(CurrentContext);
            }

            return (IPRMPreBOQFloorDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItemFloorDetail_DetailedEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItemFloorDetail_DetailedDataAccess CreateREQRequisitionItemFloorDetail_DetailedDataAccess()
        {
            string type = typeof(REQRequisitionItemFloorDetail_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItemFloorDetail_DetailedDataAccess(CurrentContext);
            }

            return (IREQRequisitionItemFloorDetail_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectUnitLocation_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProjectUnitLocation_DetailedDataAccess CreateBDProjectUnitLocation_DetailedDataAccess()
        {
            string type = typeof(BDProjectUnitLocation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectUnitLocation_DetailedDataAccess(CurrentContext);
            }

            return (IBDProjectUnitLocation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNEvent_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNEvent_DetailedDataAccess CreateCMNEvent_DetailedDataAccess()
        {
            string type = typeof(CMNEvent_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNEvent_DetailedDataAccess(CurrentContext);
            }

            return (ICMNEvent_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNEventInvitationInformation_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNEventInvitationInformation_DetailedDataAccess CreateCMNEventInvitationInformation_DetailedDataAccess()
        {
            string type = typeof(CMNEventInvitationInformation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNEventInvitationInformation_DetailedDataAccess(CurrentContext);
            }

            return (ICMNEventInvitationInformation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDAsset_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDAsset_DetailedDataAccess CreateMDAsset_DetailedDataAccess()
        {
            string type = typeof(MDAsset_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDAsset_DetailedDataAccess(CurrentContext);
            }

            return (IMDAsset_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProcessAssignedResource_DetailedEntity

        [DebuggerStepThrough()]
        public override IBDProcessAssignedResource_DetailedDataAccess CreateBDProcessAssignedResource_DetailedDataAccess()
        {
            string type = typeof(BDProcessAssignedResource_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProcessAssignedResource_DetailedDataAccess(CurrentContext);
            }

            return (IBDProcessAssignedResource_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMNMailTemplate_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMNMailTemplate_DetailedDataAccess CreateCMNMailTemplate_DetailedDataAccess()
        {
            string type = typeof(CMNMailTemplate_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMNMailTemplate_DetailedDataAccess(CurrentContext);
            }

            return (ICMNMailTemplate_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultant_DetailedEntity

        [DebuggerStepThrough()]
        public override ICMConsultant_DetailedDataAccess CreateCMConsultant_DetailedDataAccess()
        {
            string type = typeof(CMConsultant_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultant_DetailedDataAccess(CurrentContext);
            }

            return (ICMConsultant_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBuyerChildrenInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMBuyerChildrenInfo_DetailedDataAccess CreateCRMBuyerChildrenInfo_DetailedDataAccess()
        {
            string type = typeof(CRMBuyerChildrenInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBuyerChildrenInfo_DetailedDataAccess(CurrentContext);
            }

            return (ICRMBuyerChildrenInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyOwner_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyOwner_DetailedDataAccess CreateCRMSurveyOwner_DetailedDataAccess()
        {
            string type = typeof(CRMSurveyOwner_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyOwner_DetailedDataAccess(CurrentContext);
            }

            return (ICRMSurveyOwner_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransactionAvailable_DetailedEntity

        [DebuggerStepThrough()]
        public override IINVTransactionAvailable_DetailedDataAccess CreateINVTransactionAvailable_DetailedDataAccess()
        {
            string type = typeof(INVTransactionAvailable_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransactionAvailable_DetailedDataAccess(CurrentContext);
            }

            return (IINVTransactionAvailable_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentScheduleMap_DetailedEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentScheduleMap_DetailedDataAccess CreateCRMPaymentScheduleMap_DetailedDataAccess()
        {
            string type = typeof(CRMPaymentScheduleMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentScheduleMap_DetailedDataAccess(CurrentContext);
            }

            return (ICRMPaymentScheduleMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployee_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployee_DetailedDataAccess CreateHREmployee_DetailedDataAccess()
        {
            string type = typeof(HREmployee_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployee_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployee_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRDepartmentEmployeeMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRDepartmentEmployeeMap_DetailedDataAccess CreateHRDepartmentEmployeeMap_DetailedDataAccess()
        {
            string type = typeof(HRDepartmentEmployeeMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRDepartmentEmployeeMap_DetailedDataAccess(CurrentContext);
            }

            return (IHRDepartmentEmployeeMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAddressInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAddressInfo_DetailedDataAccess CreateHREmployeeAddressInfo_DetailedDataAccess()
        {
            string type = typeof(HREmployeeAddressInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAddressInfo_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeAddressInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeBankAccountInformation_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeBankAccountInformation_DetailedDataAccess CreateHREmployeeBankAccountInformation_DetailedDataAccess()
        {
            string type = typeof(HREmployeeBankAccountInformation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeBankAccountInformation_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeBankAccountInformation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeContactInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeContactInfo_DetailedDataAccess CreateHREmployeeContactInfo_DetailedDataAccess()
        {
            string type = typeof(HREmployeeContactInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeContactInfo_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeContactInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeDrivingLicenseInformation_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDrivingLicenseInformation_DetailedDataAccess CreateHREmployeeDrivingLicenseInformation_DetailedDataAccess()
        {
            string type = typeof(HREmployeeDrivingLicenseInformation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDrivingLicenseInformation_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeDrivingLicenseInformation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEducation_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEducation_DetailedDataAccess CreateHREmployeeEducation_DetailedDataAccess()
        {
            string type = typeof(HREmployeeEducation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEducation_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeEducation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeExperience_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeExperience_DetailedDataAccess CreateHREmployeeExperience_DetailedDataAccess()
        {
            string type = typeof(HREmployeeExperience_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeExperience_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeExperience_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeFamilyInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeFamilyInfo_DetailedDataAccess CreateHREmployeeFamilyInfo_DetailedDataAccess()
        {
            string type = typeof(HREmployeeFamilyInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeFamilyInfo_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeFamilyInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLanguageMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLanguageMap_DetailedDataAccess CreateHREmployeeLanguageMap_DetailedDataAccess()
        {
            string type = typeof(HREmployeeLanguageMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLanguageMap_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeLanguageMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLeaveApplication_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLeaveApplication_DetailedDataAccess CreateHREmployeeLeaveApplication_DetailedDataAccess()
        {
            string type = typeof(HREmployeeLeaveApplication_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLeaveApplication_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeLeaveApplication_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLoanApplication_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLoanApplication_DetailedDataAccess CreateHREmployeeLoanApplication_DetailedDataAccess()
        {
            string type = typeof(HREmployeeLoanApplication_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLoanApplication_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeLoanApplication_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeePassportInformation_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeePassportInformation_DetailedDataAccess CreateHREmployeePassportInformation_DetailedDataAccess()
        {
            string type = typeof(HREmployeePassportInformation_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeePassportInformation_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeePassportInformation_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSkillMap_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSkillMap_DetailedDataAccess CreateHREmployeeSkillMap_DetailedDataAccess()
        {
            string type = typeof(HREmployeeSkillMap_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSkillMap_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeSkillMap_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMemberLeaveAccount_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRMemberLeaveAccount_DetailedDataAccess CreateHRMemberLeaveAccount_DetailedDataAccess()
        {
            string type = typeof(HRMemberLeaveAccount_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMemberLeaveAccount_DetailedDataAccess(CurrentContext);
            }

            return (IHRMemberLeaveAccount_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRSession_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRSession_DetailedDataAccess CreateHRSession_DetailedDataAccess()
        {
            string type = typeof(HRSession_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRSession_DetailedDataAccess(CurrentContext);
            }

            return (IHRSession_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeNotice_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeNotice_DetailedDataAccess CreateHREmployeeNotice_DetailedDataAccess()
        {
            string type = typeof(HREmployeeNotice_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeNotice_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeNotice_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLeaveStatus_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLeaveStatus_DetailedDataAccess CreateHREmployeeLeaveStatus_DetailedDataAccess()
        {
            string type = typeof(HREmployeeLeaveStatus_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLeaveStatus_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeLeaveStatus_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDSalarySession_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDSalarySession_DetailedDataAccess CreateMDSalarySession_DetailedDataAccess()
        {
            string type = typeof(MDSalarySession_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDSalarySession_DetailedDataAccess(CurrentContext);
            }

            return (IMDSalarySession_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDLeavePolicy_DetailedEntity

        [DebuggerStepThrough()]
        public override IMDLeavePolicy_DetailedDataAccess CreateMDLeavePolicy_DetailedDataAccess()
        {
            string type = typeof(MDLeavePolicy_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDLeavePolicy_DetailedDataAccess(CurrentContext);
            }

            return (IMDLeavePolicy_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAllowanceCustom_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAllowanceCustom_DetailedDataAccess CreateHREmployeeAllowanceCustom_DetailedDataAccess()
        {
            string type = typeof(HREmployeeAllowanceCustom_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAllowanceCustom_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeAllowanceCustom_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryInfo_DetailedDataAccess CreateHREmployeeSalaryInfo_DetailedDataAccess()
        {
            string type = typeof(HREmployeeSalaryInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryInfo_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeAllowance_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeAllowance_DetailedDataAccess CreateHREmployeeAllowance_DetailedDataAccess()
        {
            string type = typeof(HREmployeeAllowance_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeAllowance_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeAllowance_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryDeducationInfo_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryDeducationInfo_DetailedDataAccess CreateHREmployeeSalaryDeducationInfo_DetailedDataAccess()
        {
            string type = typeof(HREmployeeSalaryDeducationInfo_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryDeducationInfo_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryDeducationInfo_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRSalaryAdjustment_DetailedEntity

        [DebuggerStepThrough()]
        public override IHRSalaryAdjustment_DetailedDataAccess CreateHRSalaryAdjustment_DetailedDataAccess()
        {
            string type = typeof(HRSalaryAdjustment_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRSalaryAdjustment_DetailedDataAccess(CurrentContext);
            }

            return (IHRSalaryAdjustment_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeMonthlyTimeSheet_DetailedEntity

        [DebuggerStepThrough()]
        public override IHREmployeeMonthlyTimeSheet_DetailedDataAccess CreateHREmployeeMonthlyTimeSheet_DetailedDataAccess()
        {
            string type = typeof(HREmployeeMonthlyTimeSheet_DetailedDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeMonthlyTimeSheet_DetailedDataAccess(CurrentContext);
            }

            return (IHREmployeeMonthlyTimeSheet_DetailedDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region StoreProcedure Custom

        #region PRMPreBOQDetail_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDetail_CustomDataAccess CreatePRMPreBOQDetail_CustomDataAccess()
        {
            string type = typeof(PRMPreBOQDetail_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDetail_CustomDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDetail_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQTemplateItemMapBulkInsertEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQTemplateItemMapBulkInsertDataAccess CreatePRMPreBOQTemplateItemMapBulkInsertDataAccess()
        {
            string type = typeof(PRMPreBOQTemplateItemMapBulkInsertDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQTemplateItemMapBulkInsertDataAccess(CurrentContext);
            }

            return (IPRMPreBOQTemplateItemMapBulkInsertDataAccess)CurrentContext[type];
        }

        #endregion

        #region BulkInsertXMLEntity

        [DebuggerStepThrough()]
        public override IBulkInsertXMLDataAccess CreateBulkInsertXMLDataAccess()
        {
            string type = typeof(BulkInsertXMLDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BulkInsertXMLDataAccess(CurrentContext);
            }

            return (IBulkInsertXMLDataAccess)CurrentContext[type];
        }

        #endregion

        #region ASPNETUserNameByMemberIDEntity

        [DebuggerStepThrough()]
        public override IASPNETUserNameByMemberIDDataAccess CreateASPNETUserNameByMemberIDDataAccess()
        {
            string type = typeof(ASPNETUserNameByMemberIDDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ASPNETUserNameByMemberIDDataAccess(CurrentContext);
            }

            return (IASPNETUserNameByMemberIDDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMProjectMilestone_CustomEntity

        [DebuggerStepThrough()]
        public override ICMProjectMilestone_CustomDataAccess CreateCMProjectMilestone_CustomDataAccess()
        {
            string type = typeof(CMProjectMilestone_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMProjectMilestone_CustomDataAccess(CurrentContext);
            }

            return (ICMProjectMilestone_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ResourceConsultant_CustomEntity

        [DebuggerStepThrough()]
        public override IResourceConsultant_CustomDataAccess CreateResourceConsultant_CustomDataAccess()
        {
            string type = typeof(ResourceConsultant_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ResourceConsultant_CustomDataAccess(CurrentContext);
            }

            return (IResourceConsultant_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ResourceContractor_CustomEntity

        [DebuggerStepThrough()]
        public override IResourceContractor_CustomDataAccess CreateResourceContractor_CustomDataAccess()
        {
            string type = typeof(ResourceContractor_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ResourceContractor_CustomDataAccess(CurrentContext);
            }

            return (IResourceContractor_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ResourceEmployee_CustomEntity

        [DebuggerStepThrough()]
        public override IResourceEmployee_CustomDataAccess CreateResourceEmployee_CustomDataAccess()
        {
            string type = typeof(ResourceEmployee_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ResourceEmployee_CustomDataAccess(CurrentContext);
            }

            return (IResourceEmployee_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierByBrand_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierByBrand_CustomDataAccess CreatePRMSupplierByBrand_CustomDataAccess()
        {
            string type = typeof(PRMSupplierByBrand_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierByBrand_CustomDataAccess(CurrentContext);
            }

            return (IPRMSupplierByBrand_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMItemBrandMap_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMItemBrandMap_CustomDataAccess CreatePRMItemBrandMap_CustomDataAccess()
        {
            string type = typeof(PRMItemBrandMap_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMItemBrandMap_CustomDataAccess(CurrentContext);
            }

            return (IPRMItemBrandMap_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemMapHistory_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemMapHistory_CustomDataAccess CreatePRMSupplierItemMapHistory_CustomDataAccess()
        {
            string type = typeof(PRMSupplierItemMapHistory_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemMapHistory_CustomDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemMapHistory_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMItemBrandMapDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMItemBrandMapDistinct_CustomDataAccess CreatePRMItemBrandMapDistinct_CustomDataAccess()
        {
            string type = typeof(PRMItemBrandMapDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMItemBrandMapDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMItemBrandMapDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProject_CustomEntity

        [DebuggerStepThrough()]
        public override IBDProject_CustomDataAccess CreateBDProject_CustomDataAccess()
        {
            string type = typeof(BDProject_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProject_CustomDataAccess(CurrentContext);
            }

            return (IBDProject_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectStatusDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IBDProjectStatusDistinct_CustomDataAccess CreateBDProjectStatusDistinct_CustomDataAccess()
        {
            string type = typeof(BDProjectStatusDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectStatusDistinct_CustomDataAccess(CurrentContext);
            }

            return (IBDProjectStatusDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMConsultantEnlistedWorkArea_CustomEntity

        [DebuggerStepThrough()]
        public override ICMConsultantEnlistedWorkArea_CustomDataAccess CreateCMConsultantEnlistedWorkArea_CustomDataAccess()
        {
            string type = typeof(CMConsultantEnlistedWorkArea_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMConsultantEnlistedWorkArea_CustomDataAccess(CurrentContext);
            }

            return (ICMConsultantEnlistedWorkArea_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierView_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierView_CustomDataAccess CreatePRMSupplierView_CustomDataAccess()
        {
            string type = typeof(PRMSupplierView_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierView_CustomDataAccess(CurrentContext);
            }

            return (IPRMSupplierView_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PreBOQtoBOQMigration_CustomEntity

        [DebuggerStepThrough()]
        public override IPreBOQtoBOQMigration_CustomDataAccess CreatePreBOQtoBOQMigration_CustomDataAccess()
        {
            string type = typeof(PreBOQtoBOQMigration_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PreBOQtoBOQMigration_CustomDataAccess(CurrentContext);
            }

            return (IPreBOQtoBOQMigration_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQDetail_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDetail_CustomDataAccess CreatePRMBOQDetail_CustomDataAccess()
        {
            string type = typeof(PRMBOQDetail_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDetail_CustomDataAccess(CurrentContext);
            }

            return (IPRMBOQDetail_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQDetailHistory_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMBOQDetailHistory_CustomDataAccess CreatePRMBOQDetailHistory_CustomDataAccess()
        {
            string type = typeof(PRMBOQDetailHistory_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQDetailHistory_CustomDataAccess(CurrentContext);
            }

            return (IPRMBOQDetailHistory_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQDetailHistory_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQDetailHistory_CustomDataAccess CreatePRMPreBOQDetailHistory_CustomDataAccess()
        {
            string type = typeof(PRMPreBOQDetailHistory_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQDetailHistory_CustomDataAccess(CurrentContext);
            }

            return (IPRMPreBOQDetailHistory_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTResourceIssueSchedule_CustomEntity

        [DebuggerStepThrough()]
        public override IOTResourceIssueSchedule_CustomDataAccess CreateOTResourceIssueSchedule_CustomDataAccess()
        {
            string type = typeof(OTResourceIssueSchedule_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTResourceIssueSchedule_CustomDataAccess(CurrentContext);
            }

            return (IOTResourceIssueSchedule_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItem_CustomEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItem_CustomDataAccess CreateREQRequisitionItem_CustomDataAccess()
        {
            string type = typeof(REQRequisitionItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItem_CustomDataAccess(CurrentContext);
            }

            return (IREQRequisitionItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrder_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrder_CustomDataAccess CreatePRMWorkOrder_CustomDataAccess()
        {
            string type = typeof(PRMWorkOrder_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrder_CustomDataAccess(CurrentContext);
            }

            return (IPRMWorkOrder_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMRequisitionBySupplierDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMRequisitionBySupplierDistinct_CustomDataAccess CreatePRMRequisitionBySupplierDistinct_CustomDataAccess()
        {
            string type = typeof(PRMRequisitionBySupplierDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMRequisitionBySupplierDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMRequisitionBySupplierDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierByProjectDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierByProjectDistinct_CustomDataAccess CreatePRMSupplierByProjectDistinct_CustomDataAccess()
        {
            string type = typeof(PRMSupplierByProjectDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierByProjectDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMSupplierByProjectDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderByRequisitionDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderByRequisitionDistinct_CustomDataAccess CreatePRMWorkOrderByRequisitionDistinct_CustomDataAccess()
        {
            string type = typeof(PRMWorkOrderByRequisitionDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderByRequisitionDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderByRequisitionDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBrandByItem_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMBrandByItem_CustomDataAccess CreatePRMBrandByItem_CustomDataAccess()
        {
            string type = typeof(PRMBrandByItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBrandByItem_CustomDataAccess(CurrentContext);
            }

            return (IPRMBrandByItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMOriginCountryByBrandItemRegionDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess CreatePRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess()
        {
            string type = typeof(PRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMOriginRegionByBrandItemDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMOriginRegionByBrandItemDistinct_CustomDataAccess CreatePRMOriginRegionByBrandItemDistinct_CustomDataAccess()
        {
            string type = typeof(PRMOriginRegionByBrandItemDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMOriginRegionByBrandItemDistinct_CustomDataAccess(CurrentContext);
            }

            return (IPRMOriginRegionByBrandItemDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMember_CustomEntity

        [DebuggerStepThrough()]
        public override IHRMember_CustomDataAccess CreateHRMember_CustomDataAccess()
        {
            string type = typeof(HRMember_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMember_CustomDataAccess(CurrentContext);
            }

            return (IHRMember_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectByMember_CustomEntity

        [DebuggerStepThrough()]
        public override IBDProjectByMember_CustomDataAccess CreateBDProjectByMember_CustomDataAccess()
        {
            string type = typeof(BDProjectByMember_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectByMember_CustomDataAccess(CurrentContext);
            }

            return (IBDProjectByMember_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region DMSFileTrackingDepartmentDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IDMSFileTrackingDepartmentDistinct_CustomDataAccess CreateDMSFileTrackingDepartmentDistinct_CustomDataAccess()
        {
            string type = typeof(DMSFileTrackingDepartmentDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new DMSFileTrackingDepartmentDistinct_CustomDataAccess(CurrentContext);
            }

            return (IDMSFileTrackingDepartmentDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelItemCategoryMap_CustomEntity

        [DebuggerStepThrough()]
        public override IAPPanelItemCategoryMap_CustomDataAccess CreateAPPanelItemCategoryMap_CustomDataAccess()
        {
            string type = typeof(APPanelItemCategoryMap_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelItemCategoryMap_CustomDataAccess(CurrentContext);
            }

            return (IAPPanelItemCategoryMap_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region APPanelMember_CustomEntity

        [DebuggerStepThrough()]
        public override IAPPanelMember_CustomDataAccess CreateAPPanelMember_CustomDataAccess()
        {
            string type = typeof(APPanelMember_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APPanelMember_CustomDataAccess(CurrentContext);
            }

            return (IAPPanelMember_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMAbstractMeasurementBook_CustomEntity

        [DebuggerStepThrough()]
        public override ICMAbstractMeasurementBook_CustomDataAccess CreateCMAbstractMeasurementBook_CustomDataAccess()
        {
            string type = typeof(CMAbstractMeasurementBook_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMAbstractMeasurementBook_CustomDataAccess(CurrentContext);
            }

            return (ICMAbstractMeasurementBook_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMAbstractMeasurementBookHelper_CustomEntity

        [DebuggerStepThrough()]
        public override ICMAbstractMeasurementBookHelper_CustomDataAccess CreateCMAbstractMeasurementBookHelper_CustomDataAccess()
        {
            string type = typeof(CMAbstractMeasurementBookHelper_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMAbstractMeasurementBookHelper_CustomDataAccess(CurrentContext);
            }

            return (ICMAbstractMeasurementBookHelper_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMBOQRequisitionItem_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMBOQRequisitionItem_CustomDataAccess CreatePRMBOQRequisitionItem_CustomDataAccess()
        {
            string type = typeof(PRMBOQRequisitionItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMBOQRequisitionItem_CustomDataAccess(CurrentContext);
            }

            return (IPRMBOQRequisitionItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemByWorkOrder_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemByWorkOrder_CustomDataAccess CreatePRMWorkOrderItemByWorkOrder_CustomDataAccess()
        {
            string type = typeof(PRMWorkOrderItemByWorkOrder_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemByWorkOrder_CustomDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemByWorkOrder_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMPreBOQRequisitionItem_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMPreBOQRequisitionItem_CustomDataAccess CreatePRMPreBOQRequisitionItem_CustomDataAccess()
        {
            string type = typeof(PRMPreBOQRequisitionItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMPreBOQRequisitionItem_CustomDataAccess(CurrentContext);
            }

            return (IPRMPreBOQRequisitionItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDetail_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDetail_CustomDataAccess CreateACCPrePayableStatementDetail_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDetail_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDetail_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDetail_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess CreateACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region INV_MakeDefaultStore_CustomEntity

        [DebuggerStepThrough()]
        public override IINV_MakeDefaultStore_CustomDataAccess CreateINV_MakeDefaultStore_CustomDataAccess()
        {
            string type = typeof(INV_MakeDefaultStore_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INV_MakeDefaultStore_CustomDataAccess(CurrentContext);
            }

            return (IINV_MakeDefaultStore_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region INV_MakeDefaultStoreUnit_CustomEntity

        [DebuggerStepThrough()]
        public override IINV_MakeDefaultStoreUnit_CustomDataAccess CreateINV_MakeDefaultStoreUnit_CustomDataAccess()
        {
            string type = typeof(INV_MakeDefaultStoreUnit_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INV_MakeDefaultStoreUnit_CustomDataAccess(CurrentContext);
            }

            return (IINV_MakeDefaultStoreUnit_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDetailByBill_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDetailByBill_CustomDataAccess CreateACCPrePayableStatementDetailByBill_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDetailByBill_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDetailByBill_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDetailByBill_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDetailFromWO_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDetailFromWO_CustomDataAccess CreateACCPrePayableStatementDetailFromWO_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDetailFromWO_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDetailFromWO_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDetailFromWO_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransactionINOUT_CustomEntity

        [DebuggerStepThrough()]
        public override IINVTransactionINOUT_CustomDataAccess CreateINVTransactionINOUT_CustomDataAccess()
        {
            string type = typeof(INVTransactionINOUT_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransactionINOUT_CustomDataAccess(CurrentContext);
            }

            return (IINVTransactionINOUT_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess CreateACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderNoByRequisition_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderNoByRequisition_CustomDataAccess CreatePRMWorkOrderNoByRequisition_CustomDataAccess()
        {
            string type = typeof(PRMWorkOrderNoByRequisition_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderNoByRequisition_CustomDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderNoByRequisition_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMApprovedAdvancePaymentWorkOrder_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess CreatePRMApprovedAdvancePaymentWorkOrder_CustomDataAccess()
        {
            string type = typeof(PRMApprovedAdvancePaymentWorkOrder_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMApprovedAdvancePaymentWorkOrder_CustomDataAccess(CurrentContext);
            }

            return (IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransactionAvailableQtyWithBatch_CustomEntity

        [DebuggerStepThrough()]
        public override IINVTransactionAvailableQtyWithBatch_CustomDataAccess CreateINVTransactionAvailableQtyWithBatch_CustomDataAccess()
        {
            string type = typeof(INVTransactionAvailableQtyWithBatch_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransactionAvailableQtyWithBatch_CustomDataAccess(CurrentContext);
            }

            return (IINVTransactionAvailableQtyWithBatch_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatementDistinct_CustomEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatementDistinct_CustomDataAccess CreateACCPrePayableStatementDistinct_CustomDataAccess()
        {
            string type = typeof(ACCPrePayableStatementDistinct_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatementDistinct_CustomDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatementDistinct_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region APApprovedRequisitionForWOByPanelMember_CustomEntity

        [DebuggerStepThrough()]
        public override IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess CreateAPApprovedRequisitionForWOByPanelMember_CustomDataAccess()
        {
            string type = typeof(APApprovedRequisitionForWOByPanelMember_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new APApprovedRequisitionForWOByPanelMember_CustomDataAccess(CurrentContext);
            }

            return (IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionWithWorkOrder_CustomEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionWithWorkOrder_CustomDataAccess CreateREQRequisitionWithWorkOrder_CustomDataAccess()
        {
            string type = typeof(REQRequisitionWithWorkOrder_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionWithWorkOrder_CustomDataAccess(CurrentContext);
            }

            return (IREQRequisitionWithWorkOrder_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMApprovedBillExceptACCPrePayable_CustomEntity

        [DebuggerStepThrough()]
        public override ICMApprovedBillExceptACCPrePayable_CustomDataAccess CreateCMApprovedBillExceptACCPrePayable_CustomDataAccess()
        {
            string type = typeof(CMApprovedBillExceptACCPrePayable_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMApprovedBillExceptACCPrePayable_CustomDataAccess(CurrentContext);
            }

            return (ICMApprovedBillExceptACCPrePayable_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialRequisitionItem_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialRequisitionItem_CustomDataAccess CreatePRMMaterialRequisitionItem_CustomDataAccess()
        {
            string type = typeof(PRMMaterialRequisitionItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialRequisitionItem_CustomDataAccess(CurrentContext);
            }

            return (IPRMMaterialRequisitionItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountsHelper_CustomEntity

        [DebuggerStepThrough()]
        public override IACAccountsHelper_CustomDataAccess CreateACAccountsHelper_CustomDataAccess()
        {
            string type = typeof(ACAccountsHelper_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountsHelper_CustomDataAccess(CurrentContext);
            }

            return (IACAccountsHelper_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankStatement_CustomEntity

        [DebuggerStepThrough()]
        public override IACBankStatement_CustomDataAccess CreateACBankStatement_CustomDataAccess()
        {
            string type = typeof(ACBankStatement_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankStatement_CustomDataAccess(CurrentContext);
            }

            return (IACBankStatement_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTrialBalance_CustomEntity

        [DebuggerStepThrough()]
        public override IACTrialBalance_CustomDataAccess CreateACTrialBalance_CustomDataAccess()
        {
            string type = typeof(ACTrialBalance_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTrialBalance_CustomDataAccess(CurrentContext);
            }

            return (IACTrialBalance_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountGroupBalanceSheet_CustomEntity

        [DebuggerStepThrough()]
        public override IACAccountGroupBalanceSheet_CustomDataAccess CreateACAccountGroupBalanceSheet_CustomDataAccess()
        {
            string type = typeof(ACAccountGroupBalanceSheet_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountGroupBalanceSheet_CustomDataAccess(CurrentContext);
            }

            return (IACAccountGroupBalanceSheet_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountBalanceSheet_CustomEntity

        [DebuggerStepThrough()]
        public override IACAccountBalanceSheet_CustomDataAccess CreateACAccountBalanceSheet_CustomDataAccess()
        {
            string type = typeof(ACAccountBalanceSheet_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountBalanceSheet_CustomDataAccess(CurrentContext);
            }

            return (IACAccountBalanceSheet_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACProjectWiseAccountResourceTransaction_CustomEntity

        [DebuggerStepThrough()]
        public override IACProjectWiseAccountResourceTransaction_CustomDataAccess CreateACProjectWiseAccountResourceTransaction_CustomDataAccess()
        {
            string type = typeof(ACProjectWiseAccountResourceTransaction_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACProjectWiseAccountResourceTransaction_CustomDataAccess(CurrentContext);
            }

            return (IACProjectWiseAccountResourceTransaction_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccountOpenCloseBalance_CustomEntity

        [DebuggerStepThrough()]
        public override IACAccountOpenCloseBalance_CustomDataAccess CreateACAccountOpenCloseBalance_CustomDataAccess()
        {
            string type = typeof(ACAccountOpenCloseBalance_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccountOpenCloseBalance_CustomDataAccess(CurrentContext);
            }

            return (IACAccountOpenCloseBalance_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMContactList_CustomEntity

        [DebuggerStepThrough()]
        public override ICRMContactList_CustomDataAccess CreateCRMContactList_CustomDataAccess()
        {
            string type = typeof(CRMContactList_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMContactList_CustomDataAccess(CurrentContext);
            }

            return (ICRMContactList_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionDashboard_CustomEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionDashboard_CustomDataAccess CreateREQRequisitionDashboard_CustomDataAccess()
        {
            string type = typeof(REQRequisitionDashboard_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionDashboard_CustomDataAccess(CurrentContext);
            }

            return (IREQRequisitionDashboard_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItem_CustomEntity

        [DebuggerStepThrough()]
        public override IMDItem_CustomDataAccess CreateMDItem_CustomDataAccess()
        {
            string type = typeof(MDItem_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItem_CustomDataAccess(CurrentContext);
            }

            return (IMDItem_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRGenerateEvaluation_CustomEntity

        [DebuggerStepThrough()]
        public override IHRGenerateEvaluation_CustomDataAccess CreateHRGenerateEvaluation_CustomDataAccess()
        {
            string type = typeof(HRGenerateEvaluation_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRGenerateEvaluation_CustomDataAccess(CurrentContext);
            }

            return (IHRGenerateEvaluation_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationSession_CustomEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationSession_CustomDataAccess CreateHREmployeeEvaluationSession_CustomDataAccess()
        {
            string type = typeof(HREmployeeEvaluationSession_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationSession_CustomDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationSession_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationIndividual_CustomEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationIndividual_CustomDataAccess CreateHREmployeeEvaluationIndividual_CustomDataAccess()
        {
            string type = typeof(HREmployeeEvaluationIndividual_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationIndividual_CustomDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationIndividual_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderSingleClickFromRequisition_CustomEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess CreatePRMWorkOrderSingleClickFromRequisition_CustomDataAccess()
        {
            string type = typeof(PRMWorkOrderSingleClickFromRequisition_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderSingleClickFromRequisition_CustomDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVTransaction_CustomEntity

        [DebuggerStepThrough()]
        public override IINVTransaction_CustomDataAccess CreateINVTransaction_CustomDataAccess()
        {
            string type = typeof(INVTransaction_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVTransaction_CustomDataAccess(CurrentContext);
            }

            return (IINVTransaction_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACProjectWiseAccount_CustomEntity

        [DebuggerStepThrough()]
        public override IACProjectWiseAccount_CustomDataAccess CreateACProjectWiseAccount_CustomDataAccess()
        {
            string type = typeof(ACProjectWiseAccount_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACProjectWiseAccount_CustomDataAccess(CurrentContext);
            }

            return (IACProjectWiseAccount_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess CreateHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess()
        {
            string type = typeof(HREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess(CurrentContext);
            }

            return (IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRMonthlySalaryPayment_CustomEntity

        [DebuggerStepThrough()]
        public override IHRMonthlySalaryPayment_CustomDataAccess CreateHRMonthlySalaryPayment_CustomDataAccess()
        {
            string type = typeof(HRMonthlySalaryPayment_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRMonthlySalaryPayment_CustomDataAccess(CurrentContext);
            }

            return (IHRMonthlySalaryPayment_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssue_CustomEntity

        [DebuggerStepThrough()]
        public override IOTIssue_CustomDataAccess CreateOTIssue_CustomDataAccess()
        {
            string type = typeof(OTIssue_CustomDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssue_CustomDataAccess(CurrentContext);
            }

            return (IOTIssue_CustomDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #region StoreProcedure Report

        #region REQRequisition_RPTEntity

        [DebuggerStepThrough()]
        public override IREQRequisition_RPTDataAccess CreateREQRequisition_RPTDataAccess()
        {
            string type = typeof(REQRequisition_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisition_RPTDataAccess(CurrentContext);
            }

            return (IREQRequisition_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProject_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProject_RPTDataAccess CreateBDProject_RPTDataAccess()
        {
            string type = typeof(BDProject_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProject_RPTDataAccess(CurrentContext);
            }

            return (IBDProject_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectHistory_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProjectHistory_RPTDataAccess CreateBDProjectHistory_RPTDataAccess()
        {
            string type = typeof(BDProjectHistory_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectHistory_RPTDataAccess(CurrentContext);
            }

            return (IBDProjectHistory_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region MDItem_RPTEntity

        [DebuggerStepThrough()]
        public override IMDItem_RPTDataAccess CreateMDItem_RPTDataAccess()
        {
            string type = typeof(MDItem_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new MDItem_RPTDataAccess(CurrentContext);
            }

            return (IMDItem_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMSupplierItemMapHistory_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMSupplierItemMapHistory_RPTDataAccess CreatePRMSupplierItemMapHistory_RPTDataAccess()
        {
            string type = typeof(PRMSupplierItemMapHistory_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMSupplierItemMapHistory_RPTDataAccess(CurrentContext);
            }

            return (IPRMSupplierItemMapHistory_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTMissedIssue_RPTEntity

        [DebuggerStepThrough()]
        public override IOTMissedIssue_RPTDataAccess CreateOTMissedIssue_RPTDataAccess()
        {
            string type = typeof(OTMissedIssue_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTMissedIssue_RPTDataAccess(CurrentContext);
            }

            return (IOTMissedIssue_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTUpcomingIssue_RPTEntity

        [DebuggerStepThrough()]
        public override IOTUpcomingIssue_RPTDataAccess CreateOTUpcomingIssue_RPTDataAccess()
        {
            string type = typeof(OTUpcomingIssue_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTUpcomingIssue_RPTDataAccess(CurrentContext);
            }

            return (IOTUpcomingIssue_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssue_RPTEntity

        [DebuggerStepThrough()]
        public override IOTIssue_RPTDataAccess CreateOTIssue_RPTDataAccess()
        {
            string type = typeof(OTIssue_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssue_RPTDataAccess(CurrentContext);
            }

            return (IOTIssue_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrder_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrder_RPTDataAccess CreatePRMWorkOrder_RPTDataAccess()
        {
            string type = typeof(PRMWorkOrder_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrder_RPTDataAccess(CurrentContext);
            }

            return (IPRMWorkOrder_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderPaymentTerm_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderPaymentTerm_RPTDataAccess CreatePRMWorkOrderPaymentTerm_RPTDataAccess()
        {
            string type = typeof(PRMWorkOrderPaymentTerm_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderPaymentTerm_RPTDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderPaymentTerm_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceive_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceive_RPTDataAccess CreatePRMMaterialReceive_RPTDataAccess()
        {
            string type = typeof(PRMMaterialReceive_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceive_RPTDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceive_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionApprovedPortion_RPTEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionApprovedPortion_RPTDataAccess CreateREQRequisitionApprovedPortion_RPTDataAccess()
        {
            string type = typeof(REQRequisitionApprovedPortion_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionApprovedPortion_RPTDataAccess(CurrentContext);
            }

            return (IREQRequisitionApprovedPortion_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemDetail_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemDetail_RPTDataAccess CreatePRMWorkOrderItemDetail_RPTDataAccess()
        {
            string type = typeof(PRMWorkOrderItemDetail_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemDetail_RPTDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemDetail_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBill_RPTEntity

        [DebuggerStepThrough()]
        public override ICMBill_RPTDataAccess CreateCMBill_RPTDataAccess()
        {
            string type = typeof(CMBill_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBill_RPTDataAccess(CurrentContext);
            }

            return (ICMBill_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMMeasurementBookByBill_RPTEntity

        [DebuggerStepThrough()]
        public override ICMMeasurementBookByBill_RPTDataAccess CreateCMMeasurementBookByBill_RPTDataAccess()
        {
            string type = typeof(CMMeasurementBookByBill_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMMeasurementBookByBill_RPTDataAccess(CurrentContext);
            }

            return (ICMMeasurementBookByBill_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMMaterialReceiveByWorkOrder_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMMaterialReceiveByWorkOrder_RPTDataAccess CreatePRMMaterialReceiveByWorkOrder_RPTDataAccess()
        {
            string type = typeof(PRMMaterialReceiveByWorkOrder_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMMaterialReceiveByWorkOrder_RPTDataAccess(CurrentContext);
            }

            return (IPRMMaterialReceiveByWorkOrder_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPostPayableStatement_RPTEntity

        [DebuggerStepThrough()]
        public override IACCPostPayableStatement_RPTDataAccess CreateACCPostPayableStatement_RPTDataAccess()
        {
            string type = typeof(ACCPostPayableStatement_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPostPayableStatement_RPTDataAccess(CurrentContext);
            }

            return (IACCPostPayableStatement_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCPrePayableStatement_RPTEntity

        [DebuggerStepThrough()]
        public override IACCPrePayableStatement_RPTDataAccess CreateACCPrePayableStatement_RPTDataAccess()
        {
            string type = typeof(ACCPrePayableStatement_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCPrePayableStatement_RPTDataAccess(CurrentContext);
            }

            return (IACCPrePayableStatement_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CMBillWithRequisitionItemMap_RPTEntity

        [DebuggerStepThrough()]
        public override ICMBillWithRequisitionItemMap_RPTDataAccess CreateCMBillWithRequisitionItemMap_RPTDataAccess()
        {
            string type = typeof(CMBillWithRequisitionItemMap_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CMBillWithRequisitionItemMap_RPTDataAccess(CurrentContext);
            }

            return (ICMBillWithRequisitionItemMap_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTrialBalanceForActiveFiscalYear_RPTEntity

        [DebuggerStepThrough()]
        public override IACTrialBalanceForActiveFiscalYear_RPTDataAccess CreateACTrialBalanceForActiveFiscalYear_RPTDataAccess()
        {
            string type = typeof(ACTrialBalanceForActiveFiscalYear_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTrialBalanceForActiveFiscalYear_RPTDataAccess(CurrentContext);
            }

            return (IACTrialBalanceForActiveFiscalYear_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBalanceSheet_RPTEntity

        [DebuggerStepThrough()]
        public override IACBalanceSheet_RPTDataAccess CreateACBalanceSheet_RPTDataAccess()
        {
            string type = typeof(ACBalanceSheet_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBalanceSheet_RPTDataAccess(CurrentContext);
            }

            return (IACBalanceSheet_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDeposit_RPTEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDeposit_RPTDataAccess CreateACBankAccountDeposit_RPTDataAccess()
        {
            string type = typeof(ACBankAccountDeposit_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDeposit_RPTDataAccess(CurrentContext);
            }

            return (IACBankAccountDeposit_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPayment_RPTEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPayment_RPTDataAccess CreateACBankAccountPayment_RPTDataAccess()
        {
            string type = typeof(ACBankAccountPayment_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPayment_RPTDataAccess(CurrentContext);
            }

            return (IACBankAccountPayment_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournal_RPTEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournal_RPTDataAccess CreateACTemporaryJournal_RPTDataAccess()
        {
            string type = typeof(ACTemporaryJournal_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournal_RPTDataAccess(CurrentContext);
            }

            return (IACTemporaryJournal_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAgreement_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMAgreement_RPTDataAccess CreateCRMAgreement_RPTDataAccess()
        {
            string type = typeof(CRMAgreement_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAgreement_RPTDataAccess(CurrentContext);
            }

            return (ICRMAgreement_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentCollectionMoneyRecipt_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentCollectionMoneyRecipt_RPTDataAccess CreateCRMPaymentCollectionMoneyRecipt_RPTDataAccess()
        {
            string type = typeof(CRMPaymentCollectionMoneyRecipt_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentCollectionMoneyRecipt_RPTDataAccess(CurrentContext);
            }

            return (ICRMPaymentCollectionMoneyRecipt_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentSchedule_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentSchedule_RPTDataAccess CreateCRMPaymentSchedule_RPTDataAccess()
        {
            string type = typeof(CRMPaymentSchedule_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentSchedule_RPTDataAccess(CurrentContext);
            }

            return (ICRMPaymentSchedule_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentCollection_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentCollection_RPTDataAccess CreateCRMPaymentCollection_RPTDataAccess()
        {
            string type = typeof(CRMPaymentCollection_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentCollection_RPTDataAccess(CurrentContext);
            }

            return (ICRMPaymentCollection_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectStatusWiseFloorUnit_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProjectStatusWiseFloorUnit_RPTDataAccess CreateBDProjectStatusWiseFloorUnit_RPTDataAccess()
        {
            string type = typeof(BDProjectStatusWiseFloorUnit_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectStatusWiseFloorUnit_RPTDataAccess(CurrentContext);
            }

            return (IBDProjectStatusWiseFloorUnit_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMBookingStatus_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMBookingStatus_RPTDataAccess CreateCRMBookingStatus_RPTDataAccess()
        {
            string type = typeof(CRMBookingStatus_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMBookingStatus_RPTDataAccess(CurrentContext);
            }

            return (ICRMBookingStatus_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMDuePaymentFromPaymentSchedule_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMDuePaymentFromPaymentSchedule_RPTDataAccess CreateCRMDuePaymentFromPaymentSchedule_RPTDataAccess()
        {
            string type = typeof(CRMDuePaymentFromPaymentSchedule_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMDuePaymentFromPaymentSchedule_RPTDataAccess(CurrentContext);
            }

            return (ICRMDuePaymentFromPaymentSchedule_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMPaymentEncashed_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMPaymentEncashed_RPTDataAccess CreateCRMPaymentEncashed_RPTDataAccess()
        {
            string type = typeof(CRMPaymentEncashed_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMPaymentEncashed_RPTDataAccess(CurrentContext);
            }

            return (ICRMPaymentEncashed_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMCustomerPortfolioSummary_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMCustomerPortfolioSummary_RPTDataAccess CreateCRMCustomerPortfolioSummary_RPTDataAccess()
        {
            string type = typeof(CRMCustomerPortfolioSummary_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMCustomerPortfolioSummary_RPTDataAccess(CurrentContext);
            }

            return (ICRMCustomerPortfolioSummary_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectCutom_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProjectCutom_RPTDataAccess CreateBDProjectCutom_RPTDataAccess()
        {
            string type = typeof(BDProjectCutom_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectCutom_RPTDataAccess(CurrentContext);
            }

            return (IBDProjectCutom_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IOTIssueDateWise_RPTDataAccess CreateOTIssueDateWise_RPTDataAccess()
        {
            string type = typeof(OTIssueDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueDateWise_RPTDataAccess(CurrentContext);
            }

            return (IOTIssueDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectCollectedDocumentCustom_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProjectCollectedDocumentCustom_RPTDataAccess CreateBDProjectCollectedDocumentCustom_RPTDataAccess()
        {
            string type = typeof(BDProjectCollectedDocumentCustom_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectCollectedDocumentCustom_RPTDataAccess(CurrentContext);
            }

            return (IBDProjectCollectedDocumentCustom_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProcessAssignedResourceMap_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProcessAssignedResourceMap_RPTDataAccess CreateBDProcessAssignedResourceMap_RPTDataAccess()
        {
            string type = typeof(BDProcessAssignedResourceMap_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProcessAssignedResourceMap_RPTDataAccess(CurrentContext);
            }

            return (IBDProcessAssignedResourceMap_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACAccount_RPTEntity

        [DebuggerStepThrough()]
        public override IACAccount_RPTDataAccess CreateACAccount_RPTDataAccess()
        {
            string type = typeof(ACAccount_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACAccount_RPTDataAccess(CurrentContext);
            }

            return (IACAccount_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountDepositDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IACBankAccountDepositDateWise_RPTDataAccess CreateACBankAccountDepositDateWise_RPTDataAccess()
        {
            string type = typeof(ACBankAccountDepositDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountDepositDateWise_RPTDataAccess(CurrentContext);
            }

            return (IACBankAccountDepositDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACBankAccountPaymentDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IACBankAccountPaymentDateWise_RPTDataAccess CreateACBankAccountPaymentDateWise_RPTDataAccess()
        {
            string type = typeof(ACBankAccountPaymentDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACBankAccountPaymentDateWise_RPTDataAccess(CurrentContext);
            }

            return (IACBankAccountPaymentDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACDayBookJournalDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IACDayBookJournalDateWise_RPTDataAccess CreateACDayBookJournalDateWise_RPTDataAccess()
        {
            string type = typeof(ACDayBookJournalDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACDayBookJournalDateWise_RPTDataAccess(CurrentContext);
            }

            return (IACDayBookJournalDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACTemporaryJournalDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IACTemporaryJournalDateWise_RPTDataAccess CreateACTemporaryJournalDateWise_RPTDataAccess()
        {
            string type = typeof(ACTemporaryJournalDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACTemporaryJournalDateWise_RPTDataAccess(CurrentContext);
            }

            return (IACTemporaryJournalDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region ACCashPaymentDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IACCashPaymentDateWise_RPTDataAccess CreateACCashPaymentDateWise_RPTDataAccess()
        {
            string type = typeof(ACCashPaymentDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new ACCashPaymentDateWise_RPTDataAccess(CurrentContext);
            }

            return (IACCashPaymentDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueCategoryWise_RPTEntity

        [DebuggerStepThrough()]
        public override IOTIssueCategoryWise_RPTDataAccess CreateOTIssueCategoryWise_RPTDataAccess()
        {
            string type = typeof(OTIssueCategoryWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueCategoryWise_RPTDataAccess(CurrentContext);
            }

            return (IOTIssueCategoryWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueWithEmployeeandDateWise_RPTEntity

        [DebuggerStepThrough()]
        public override IOTIssueWithEmployeeandDateWise_RPTDataAccess CreateOTIssueWithEmployeeandDateWise_RPTDataAccess()
        {
            string type = typeof(OTIssueWithEmployeeandDateWise_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueWithEmployeeandDateWise_RPTDataAccess(CurrentContext);
            }

            return (IOTIssueWithEmployeeandDateWise_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region REQRequisitionItemFloorDetail_RPTEntity

        [DebuggerStepThrough()]
        public override IREQRequisitionItemFloorDetail_RPTDataAccess CreateREQRequisitionItemFloorDetail_RPTDataAccess()
        {
            string type = typeof(REQRequisitionItemFloorDetail_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new REQRequisitionItemFloorDetail_RPTDataAccess(CurrentContext);
            }

            return (IREQRequisitionItemFloorDetail_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region PRMWorkOrderItemFloorDetail_RPTEntity

        [DebuggerStepThrough()]
        public override IPRMWorkOrderItemFloorDetail_RPTDataAccess CreatePRMWorkOrderItemFloorDetail_RPTDataAccess()
        {
            string type = typeof(PRMWorkOrderItemFloorDetail_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new PRMWorkOrderItemFloorDetail_RPTDataAccess(CurrentContext);
            }

            return (IPRMWorkOrderItemFloorDetail_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDFloorWiseWOBillDetail_RPTEntity

        [DebuggerStepThrough()]
        public override IBDFloorWiseWOBillDetail_RPTDataAccess CreateBDFloorWiseWOBillDetail_RPTDataAccess()
        {
            string type = typeof(BDFloorWiseWOBillDetail_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDFloorWiseWOBillDetail_RPTDataAccess(CurrentContext);
            }

            return (IBDFloorWiseWOBillDetail_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region OTIssueCategoryWiseIndividual_RPTEntity

        [DebuggerStepThrough()]
        public override IOTIssueCategoryWiseIndividual_RPTDataAccess CreateOTIssueCategoryWiseIndividual_RPTDataAccess()
        {
            string type = typeof(OTIssueCategoryWiseIndividual_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new OTIssueCategoryWiseIndividual_RPTDataAccess(CurrentContext);
            }

            return (IOTIssueCategoryWiseIndividual_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREvaluation_RPTEntity

        [DebuggerStepThrough()]
        public override IHREvaluation_RPTDataAccess CreateHREvaluation_RPTDataAccess()
        {
            string type = typeof(HREvaluation_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREvaluation_RPTDataAccess(CurrentContext);
            }

            return (IHREvaluation_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRDTLSubmission_RPTEntity

        [DebuggerStepThrough()]
        public override IHRDTLSubmission_RPTDataAccess CreateHRDTLSubmission_RPTDataAccess()
        {
            string type = typeof(HRDTLSubmission_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRDTLSubmission_RPTDataAccess(CurrentContext);
            }

            return (IHRDTLSubmission_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurvey_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMSurvey_RPTDataAccess CreateCRMSurvey_RPTDataAccess()
        {
            string type = typeof(CRMSurvey_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurvey_RPTDataAccess(CurrentContext);
            }

            return (ICRMSurvey_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMAdvertisementRequisition_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMAdvertisementRequisition_RPTDataAccess CreateCRMAdvertisementRequisition_RPTDataAccess()
        {
            string type = typeof(CRMAdvertisementRequisition_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMAdvertisementRequisition_RPTDataAccess(CurrentContext);
            }

            return (ICRMAdvertisementRequisition_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region INVStoreIssueNoteItemMap_RPTEntity

        [DebuggerStepThrough()]
        public override IINVStoreIssueNoteItemMap_RPTDataAccess CreateINVStoreIssueNoteItemMap_RPTDataAccess()
        {
            string type = typeof(INVStoreIssueNoteItemMap_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new INVStoreIssueNoteItemMap_RPTDataAccess(CurrentContext);
            }

            return (IINVStoreIssueNoteItemMap_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region CRMSurveyMaster_RPTEntity

        [DebuggerStepThrough()]
        public override ICRMSurveyMaster_RPTDataAccess CreateCRMSurveyMaster_RPTDataAccess()
        {
            string type = typeof(CRMSurveyMaster_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new CRMSurveyMaster_RPTDataAccess(CurrentContext);
            }

            return (ICRMSurveyMaster_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationReport_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationReport_RPTDataAccess CreateHREmployeeEvaluationReport_RPTDataAccess()
        {
            string type = typeof(HREmployeeEvaluationReport_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationReport_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationReport_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeEvaluationReportForAllEmployee_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess CreateHREmployeeEvaluationReportForAllEmployee_RPTDataAccess()
        {
            string type = typeof(HREmployeeEvaluationReportForAllEmployee_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeEvaluationReportForAllEmployee_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HRWorkingDay_RPTEntity

        [DebuggerStepThrough()]
        public override IHRWorkingDay_RPTDataAccess CreateHRWorkingDay_RPTDataAccess()
        {
            string type = typeof(HRWorkingDay_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HRWorkingDay_RPTDataAccess(CurrentContext);
            }

            return (IHRWorkingDay_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeTimeSheet_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeTimeSheet_RPTDataAccess CreateHREmployeeTimeSheet_RPTDataAccess()
        {
            string type = typeof(HREmployeeTimeSheet_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeTimeSheet_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeTimeSheet_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeDetails_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeDetails_RPTDataAccess CreateHREmployeeDetails_RPTDataAccess()
        {
            string type = typeof(HREmployeeDetails_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeDetails_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeDetails_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeList_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeList_RPTDataAccess CreateHREmployeeList_RPTDataAccess()
        {
            string type = typeof(HREmployeeList_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeList_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeList_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeMonthlyTimeSheetSummary_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess CreateHREmployeeMonthlyTimeSheetSummary_RPTDataAccess()
        {
            string type = typeof(HREmployeeMonthlyTimeSheetSummary_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeMonthlyTimeSheetSummary_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryPayment_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryPayment_RPTDataAccess CreateHREmployeeSalaryPayment_RPTDataAccess()
        {
            string type = typeof(HREmployeeSalaryPayment_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryPayment_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryPayment_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLeaveStatus_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLeaveStatus_RPTDataAccess CreateHREmployeeLeaveStatus_RPTDataAccess()
        {
            string type = typeof(HREmployeeLeaveStatus_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLeaveStatus_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeLeaveStatus_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeResume_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeResume_RPTDataAccess CreateHREmployeeResume_RPTDataAccess()
        {
            string type = typeof(HREmployeeResume_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeResume_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeResume_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeSalaryDisbursementBank_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeSalaryDisbursementBank_RPTDataAccess CreateHREmployeeSalaryDisbursementBank_RPTDataAccess()
        {
            string type = typeof(HREmployeeSalaryDisbursementBank_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeSalaryDisbursementBank_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeSalaryDisbursementBank_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region HREmployeeLeaveStatus_RPTEntity

        [DebuggerStepThrough()]
        public override IHREmployeeLeaveApplications_RPTDataAccess CreateHREmployeeLeaveApplications_RPTDataAccess()
        {
            string type = typeof(HREmployeeLeaveApplications_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new HREmployeeLeaveApplications_RPTDataAccess(CurrentContext);
            }

            return (IHREmployeeLeaveApplications_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #region BDProjectFloorUnit_RPTEntity

        [DebuggerStepThrough()]
        public override IBDProjectFloorUnit_RPTDataAccess CreateBDProjectFloorUnit_RPTDataAccess()
        {
            string type = typeof(BDProjectFloorUnit_RPTDataAccess).ToString();

            if (!CurrentContext.Contains(type))
            {
                CurrentContext[type] = new BDProjectFloorUnit_RPTDataAccess(CurrentContext);
            }

            return (IBDProjectFloorUnit_RPTDataAccess)CurrentContext[type];
        }

        #endregion

        #endregion

        #endregion
    }
}