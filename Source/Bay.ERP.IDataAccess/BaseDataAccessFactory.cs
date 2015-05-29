using System;
using System.Diagnostics;

using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    public abstract class BaseDataAccessFactory
    {
        #region Static Variables

        private static readonly Configuration.TypeInfo _typeInfo = Configuration.Settings.TypeInfo;

        #endregion

        #region Instance Variables

        private Context _context;

        #endregion

        #region Property

        protected virtual Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_context == null)
                {
                    _context = new Context();
                }

                return _context;
            }
        }

        #endregion

        #region Constructer

        [DebuggerStepThrough()]
        public BaseDataAccessFactory(Context context)
        {
            _context = context;
        }

        #endregion

        #region Static Methods

        [DebuggerStepThrough()]
        public static BaseDataAccessFactory Create(Context context)
        {
            return (BaseDataAccessFactory)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(
                                                                                            _typeInfo.AssemblyName,
                                                                                            _typeInfo.TypeName,
                                                                                            false,
                                                                                            System.Reflection.BindingFlags.Default,
                                                                                            null,
                                                                                            new object[] { context },
                                                                                            null,
                                                                                            null,
                                                                                            null
                                                                                          );
        }

        #endregion

        #region Factory Methods

        #region AP

        public abstract IAPApprovalProcessDataAccess CreateAPApprovalProcessDataAccess();

        public abstract IAPFeedbackDataAccess CreateAPFeedbackDataAccess();

        public abstract IAPMemberFeedbackDataAccess CreateAPMemberFeedbackDataAccess();

        public abstract IAPPanelDataAccess CreateAPPanelDataAccess();

        public abstract IAPPanelItemCategoryMapDataAccess CreateAPPanelItemCategoryMapDataAccess();

        public abstract IAPPanelMemberDataAccess CreateAPPanelMemberDataAccess();

        public abstract IAPStatusDataAccess CreateAPStatusDataAccess();

        public abstract IAPTypeDataAccess CreateAPTypeDataAccess();

        public abstract IAPWOPanelItemCategoryMapDataAccess CreateAPWOPanelItemCategoryMapDataAccess();

        public abstract IAPMemberFeedbackRemarksDataAccess CreateAPMemberFeedbackRemarksDataAccess();

        public abstract IAPForwardInfoDataAccess CreateAPForwardInfoDataAccess();

        public abstract IAPPanelForwardMemberDataAccess CreateAPPanelForwardMemberDataAccess();

        public abstract IAPApprovalProcessPanelMapDataAccess CreateAPApprovalProcessPanelMapDataAccess();

        #endregion

        #region BD

        public abstract IBDOperatorContactPersonDataAccess CreateBDOperatorContactPersonDataAccess();

        public abstract IBDOperatorDataAccess CreateBDOperatorDataAccess();

        public abstract IBDProjectDataAccess CreateBDProjectDataAccess();

        public abstract IBDOperatorAddressInfoDataAccess CreateBDOperatorAddressInfoDataAccess();


        public abstract IBDProjectAddressInfoDataAccess CreateBDProjectAddressInfoDataAccess();

        public abstract IBDProjectCollectedDocumentCategoryInfoDataAccess CreateBDProjectCollectedDocumentCategoryInfoDataAccess();

        public abstract IBDProjectCollectedDocumentInfoDataAccess CreateBDProjectCollectedDocumentInfoDataAccess();

        public abstract IBDProjectCollectedDocumentUploadInfoDataAccess CreateBDProjectCollectedDocumentUploadInfoDataAccess();

        public abstract IBDProjectDocumentTemplateDataAccess CreateBDProjectDocumentTemplateDataAccess();

        public abstract IBDProjectDocumentTemplateMapDataAccess CreateBDProjectDocumentTemplateMapDataAccess();

        public abstract IBDProjectFloorDataAccess CreateBDProjectFloorDataAccess();

        public abstract IBDProjectHistoryDataAccess CreateBDProjectHistoryDataAccess();

        public abstract IBDProjectOtherInfoDataAccess CreateBDProjectOtherInfoDataAccess();

        public abstract IBDProjectAssignedPersonDataAccess CreateBDProjectAssignedPersonDataAccess();

        public abstract IBDProjectFloorUnitDataAccess CreateBDProjectFloorUnitDataAccess();

        public abstract IBDProcessAssignedResourceDataAccess CreateBDProcessAssignedResourceDataAccess();

        public abstract IBDProcessAssignedResourceMapDataAccess CreateBDProcessAssignedResourceMapDataAccess();

        public abstract IBDTaskTemplateDataAccess CreateBDTaskTemplateDataAccess();

        public abstract IBDTaskTemplateItemMapDataAccess CreateBDTaskTemplateItemMapDataAccess();

        public abstract IBDProjectAdditionalInfoDataAccess CreateBDProjectAdditionalInfoDataAccess();

        public abstract IBDProjectImageGalleryDataAccess CreateBDProjectImageGalleryDataAccess();

        public abstract IBDProjectLiftDataAccess CreateBDProjectLiftDataAccess();

        public abstract IBDProjectParkingDataAccess CreateBDProjectParkingDataAccess();

        public abstract IBDProjectSubstationAndGeneratorDataAccess CreateBDProjectSubstationAndGeneratorDataAccess();

        public abstract IBDProjectUnitLocationDataAccess CreateBDProjectUnitLocationDataAccess();

        public abstract IBDProjectUnitLocation_DetailedDataAccess CreateBDProjectUnitLocation_DetailedDataAccess();

        public abstract IBDProjectWaterReserviorDataAccess CreateBDProjectWaterReserviorDataAccess();

        #endregion

        #region Common

        public abstract ICMNDashboardItemDataAccess CreateCMNDashboardItemDataAccess();

        public abstract ICMNDashboardItemQuicklinkDataAccess CreateCMNDashboardItemQuicklinkDataAccess();

        public abstract ICMNApprovalPanelDataAccess CreateCMNApprovalPanelDataAccess();
        
        public abstract ICMNApprovalProcessDataAccess CreateCMNApprovalProcessDataAccess();

        public abstract ICMNMailTemplateDataAccess CreateCMNMailTemplateDataAccess();

        public abstract ICMNERPCommentDataAccess CreateCMNERPCommentDataAccess();

        public abstract ICMNFavoriteDataAccess CreateCMNFavoriteDataAccess();

        public abstract ICMNProcessCategoryDataAccess CreateCMNProcessCategoryDataAccess();

        public abstract ICMNEventDataAccess CreateCMNEventDataAccess();

        public abstract ICMNEventInvitationInformationDataAccess CreateCMNEventInvitationInformationDataAccess();

        public abstract ICMNEventUploadInfoDataAccess CreateCMNEventUploadInfoDataAccess();

        #endregion

        #region HR

        public abstract IHREmployeeDataAccess CreateHREmployeeDataAccess();

        public abstract IHRMemberDataAccess CreateHRMemberDataAccess();

        public abstract IHRWorkingDayDataAccess CreateHRWorkingDayDataAccess();

        public abstract IHREmployeeEvaluationDataAccess CreateHREmployeeEvaluationDataAccess();

        public abstract IHREmployeeEvaluationResultDataAccess CreateHREmployeeEvaluationResultDataAccess();

        public abstract IHREmployeeSupervisorMapDataAccess CreateHREmployeeSupervisorMapDataAccess();

        public abstract IHRSessionDataAccess CreateHRSessionDataAccess();

        public abstract IHRAdditonalInformationDataAccess CreateHRAdditonalInformationDataAccess();

        public abstract IHRDepartmentEmployeeMapDataAccess CreateHRDepartmentEmployeeMapDataAccess();

        public abstract IHREmployeeAdditionalPaymentInfoDataAccess CreateHREmployeeAdditionalPaymentInfoDataAccess();

        public abstract IHREmployeeAddressInfoDataAccess CreateHREmployeeAddressInfoDataAccess();

        public abstract IHREmployeeBankAccountInformationDataAccess CreateHREmployeeBankAccountInformationDataAccess();

        public abstract IHREmployeeConfidentialInfoDataAccess CreateHREmployeeConfidentialInfoDataAccess();

        public abstract IHREmployeeContactInfoDataAccess CreateHREmployeeContactInfoDataAccess();

        public abstract IHREmployeeDocumentDataAccess CreateHREmployeeDocumentDataAccess();

        public abstract IHREmployeeDrivingLicenseInformationDataAccess CreateHREmployeeDrivingLicenseInformationDataAccess();

        public abstract IHREmployeeEducationDataAccess CreateHREmployeeEducationDataAccess();

        public abstract IHREmployeeEmergencyContactInfoDataAccess CreateHREmployeeEmergencyContactInfoDataAccess();

        public abstract IHREmployeeExperienceDataAccess CreateHREmployeeExperienceDataAccess();

        public abstract IHREmployeeFamilyInfoDataAccess CreateHREmployeeFamilyInfoDataAccess();

        public abstract IHREmployeeJobDescriptionDataAccess CreateHREmployeeJobDescriptionDataAccess();

        public abstract IHREmployeeLanguageMapDataAccess CreateHREmployeeLanguageMapDataAccess();

        public abstract IHREmployeeLeaveApplicationDataAccess CreateHREmployeeLeaveApplicationDataAccess();

        public abstract IHREmployeeLoanApplicationDataAccess CreateHREmployeeLoanApplicationDataAccess();

        public abstract IHREmployeeNoticeDataAccess CreateHREmployeeNoticeDataAccess();

        public abstract IHREmployeeNoticeTemplateDataAccess CreateHREmployeeNoticeTemplateDataAccess();

        public abstract IHREmployeePassportInformationDataAccess CreateHREmployeePassportInformationDataAccess();

        public abstract IHREmployeePhotoDataAccess CreateHREmployeePhotoDataAccess();

        public abstract IHREmployeeResumeDataAccess CreateHREmployeeResumeDataAccess();

        public abstract IHREmployeeSkillMapDataAccess CreateHREmployeeSkillMapDataAccess();

        public abstract IHREmployeeVisaInfomationDataAccess CreateHREmployeeVisaInfomationDataAccess();

        public abstract IHRHolidayDataAccess CreateHRHolidayDataAccess();

        public abstract IHRMemberLeaveAccountDataAccess CreateHRMemberLeaveAccountDataAccess();

        public abstract IHRMemberLeaveOpeningBalanceDataAccess CreateHRMemberLeaveOpeningBalanceDataAccess();

        public abstract IHREmployeeEvaluationReportDataAccess CreateHREmployeeEvaluationReportDataAccess();

        public abstract IHREmployeeMonthlyTimeSheetDataAccess CreateHREmployeeMonthlyTimeSheetDataAccess();

        public abstract IHREmployeeMonthlyTimeSheetSummaryDataAccess CreateHREmployeeMonthlyTimeSheetSummaryDataAccess();

        public abstract IHREmployeeSalaryBreakDownDataAccess CreateHREmployeeSalaryBreakDownDataAccess();

        public abstract IHREmployeeSalaryBreakdownHistoryDataAccess CreateHREmployeeSalaryBreakdownHistoryDataAccess();

        public abstract IHREmployeeSalaryDeducationInfoDataAccess CreateHREmployeeSalaryDeducationInfoDataAccess();

        public abstract IHREmployeeSalaryInfoDataAccess CreateHREmployeeSalaryInfoDataAccess();

        public abstract IHREmployeeSalaryInfoHistoryDataAccess CreateHREmployeeSalaryInfoHistoryDataAccess();

        public abstract IHREmployeeSalaryPaymentDataAccess CreateHREmployeeSalaryPaymentDataAccess();

        public abstract IHREmployeeSalarySessionDeducationInfoDataAccess CreateHREmployeeSalarySessionDeducationInfoDataAccess();

        public abstract IHRSalaryAdjustmentDataAccess CreateHRSalaryAdjustmentDataAccess();

        public abstract IHREmployeeAllowanceDataAccess CreateHREmployeeAllowanceDataAccess();

        public abstract IHREmployeePhoneBillAdjustmentDataAccess CreateHREmployeePhoneBillAdjustmentDataAccess();

        #endregion

        #region INV

        public abstract IINVCurrentStockDataAccess CreateINVCurrentStockDataAccess();

        public abstract IINVStoreDataAccess CreateINVStoreDataAccess();

        public abstract IINVStoreUnitDataAccess CreateINVStoreUnitDataAccess();

        public abstract IINVStoreUnitItemDataAccess CreateINVStoreUnitItemDataAccess();

        public abstract IINVTransactionDataAccess CreateINVTransactionDataAccess();

        public abstract IINVStoreIssueNoteDataAccess CreateINVStoreIssueNoteDataAccess();

        public abstract IINVStoreIssueNoteItemMapDataAccess CreateINVStoreIssueNoteItemMapDataAccess();

        public abstract IINVTransferDataAccess CreateINVTransferDataAccess();

        public abstract IINVTransferItemDataAccess CreateINVTransferItemDataAccess();

        public abstract IINVTRFStoreIssueNoteMapDataAccess CreateINVTRFStoreIssueNoteMapDataAccess();

        #endregion

        #region MasterData


        public abstract IMDOperatorStatusDataAccess CreateMDOperatorStatusDataAccess();

        public abstract IMDOperatorAddressTypeDataAccess CreateMDOperatorAddressTypeDataAccess();


        public abstract IMDZoneDesignationDataAccess CreateMDZoneDesignationDataAccess();

        public abstract ICommonDA_SPDataAccess CreateCommonDA_SPDataAccess();

        public abstract IMDBrandDataAccess CreateMDBrandDataAccess();

        public abstract IMDCityDataAccess CreateMDCityDataAccess();

        public abstract IMDCountryDataAccess CreateMDCountryDataAccess();

        public abstract IMDItemDataAccess CreateMDItemDataAccess();

        public abstract IMDItemCategoryDataAccess CreateMDItemCategoryDataAccess();

        public abstract IMDPreBOQStatusDataAccess CreateMDPreBOQStatusDataAccess();

        public abstract IMDProjectCollectedDocumentStatusDataAccess CreateMDProjectCollectedDocumentStatusDataAccess();

        public abstract IMDProjectDocumentCategoryDataAccess CreateMDProjectDocumentCategoryDataAccess();

        public abstract IMDProjectStatusDataAccess CreateMDProjectStatusDataAccess();

        public abstract IMDRegionDataAccess CreateMDRegionDataAccess();

        public abstract IMDSupplierAddressTypeDataAccess CreateMDSupplierAddressTypeDataAccess();

        public abstract IMDUnitDataAccess CreateMDUnitDataAccess();

        public abstract IMDProjectDocumentDataAccess CreateMDProjectDocumentDataAccess();

        public abstract IMDHolidayCategoryDataAccess CreateMDHolidayCategoryDataAccess();

        public abstract IMDIssueCategoryDataAccess CreateMDIssueCategoryDataAccess();

        public abstract IMDIssueIdentityCategoryDataAccess CreateMDIssueIdentityCategoryDataAccess();

        public abstract IMDIssuePriorityDataAccess CreateMDIssuePriorityDataAccess();

        public abstract IMDIssueStatusDataAccess CreateMDIssueStatusDataAccess();

        public abstract IMDMemberTypeDataAccess CreateMDMemberTypeDataAccess();

        public abstract IMDProjectScheduleItemDataAccess CreateMDProjectScheduleItemDataAccess();

        public abstract IMDResourceCategoryDataAccess CreateMDResourceCategoryDataAccess();

        public abstract IMDScheduleCategoryDataAccess CreateMDScheduleCategoryDataAccess();

        public abstract IMDScheduleIdentityCategoryDataAccess CreateMDScheduleIdentityCategoryDataAccess();

        public abstract IMDSchedulePriorityDataAccess CreateMDSchedulePriorityDataAccess();

        public abstract IResourceDataAccess CreateResourceDataAccess();

        public abstract IMDAddressTypeDataAccess CreateMDAddressTypeDataAccess();

        public abstract IMDContractorCriterionStatusDataAccess CreateMDContractorCriterionStatusDataAccess();

        public abstract IMDCriterionCategoryDataAccess CreateMDCriterionCategoryDataAccess();

        public abstract IMDProjectCategoryDataAccess CreateMDProjectCategoryDataAccess();

        public abstract IMDRequisitionStatusDataAccess CreateMDRequisitionStatusDataAccess();
        
        public abstract IMDConstructionToolCategoryDataAccess CreateMDConstructionToolCategoryDataAccess();
        
        public abstract IMDConstructionToolWorkingConditionDataAccess CreateMDConstructionToolWorkingConditionDataAccess();

        public abstract IMDSupplierStatusDataAccess CreateMDSupplierStatusDataAccess();

        public abstract IMDStandardTimeUnitDataAccess CreateMDStandardTimeUnitDataAccess();

        public abstract IMDDesignationDataAccess CreateMDDesignationDataAccess();

        public abstract IMDItemGroupDataAccess CreateMDItemGroupDataAccess();

        public abstract IMDItemGroupItemCategoryMapDataAccess CreateMDItemGroupItemCategoryMapDataAccess();

        public abstract IMDSupplierItemCategoryDataAccess CreateMDSupplierItemCategoryDataAccess();

        public abstract IMDSupplierTypeDataAccess CreateMDSupplierTypeDataAccess();

        public abstract IMDBOQStatusDataAccess CreateMDBOQStatusDataAccess();

        public abstract IMDItemDefaultDataAccess CreateMDItemDefaultDataAccess();

        public abstract IMDItemThumbRuleDataAccess CreateMDItemThumbRuleDataAccess();

        public abstract IMDFloorDataAccess CreateMDFloorDataAccess();

        public abstract IMDFloorCategoryDataAccess CreateMDFloorCategoryDataAccess();
        
        public abstract IMDApprovalPanelStatusDataAccess CreateMDApprovalPanelStatusDataAccess();

        public abstract IMDApprovalProcessPriorityDataAccess CreateMDApprovalProcessPriorityDataAccess();

        public abstract IMDApprovalProcessStatusDataAccess CreateMDApprovalProcessStatusDataAccess();

        public abstract IMDApprovalProcessTypeDataAccess CreateMDApprovalProcessTypeDataAccess();

        public abstract IMDApprovalRuleDataAccess CreateMDApprovalRuleDataAccess();

        public abstract IMDApprovalRuleDesignationMapDataAccess CreateMDApprovalRuleDesignationMapDataAccess();

        public abstract IMDDepartmentDataAccess CreateMDDepartmentDataAccess();

        public abstract IMDWorkOrderStatusDataAccess CreateMDWorkOrderStatusDataAccess();

        public abstract IMDProjectAssignedPersonTeamRoleDataAccess CreateMDProjectAssignedPersonTeamRoleDataAccess();

        public abstract IMDDMSOwnerTypeDataAccess CreateMDDMSOwnerTypeDataAccess();

        public abstract IMDDocumentStorageTypeDataAccess CreateMDDocumentStorageTypeDataAccess();

        public abstract IMDReferenceLibraryCategoryDataAccess CreateMDReferenceLibraryCategoryDataAccess();

        public abstract IMDBillStatusDataAccess CreateMDBillStatusDataAccess();

        public abstract IMDBillApprovalStatusDataAccess CreateMDBillApprovalStatusDataAccess();

        public abstract IMDMailTemplateTypeDataAccess CreateMDMailTemplateTypeDataAccess();

        public abstract IMDACCPayableApprovalStatusDataAccess CreateMDACCPayableApprovalStatusDataAccess();

        public abstract IMDACCPayablePaymentStatusDataAccess CreateMDACCPayablePaymentStatusDataAccess();

        public abstract IMDVendorCategoryDataAccess CreateMDVendorCategoryDataAccess();

        public abstract IMDAccountPaybleStatementDetailCategoryDataAccess CreateMDAccountPaybleStatementDetailCategoryDataAccess();

        public abstract IMDPayableClassificationDataAccess CreateMDPayableClassificationDataAccess();

        public abstract IMDStoreIssueNoteApprovalStatusDataAccess CreateMDStoreIssueNoteApprovalStatusDataAccess();

        public abstract IMDInventoryStoreUnitTypeDataAccess CreateMDInventoryStoreUnitTypeDataAccess();

        public abstract IMDInventoryTransferStatusDataAccess CreateMDInventoryTransferStatusDataAccess();

        public abstract IACMDBankAccountTypeDataAccess CreateACMDBankAccountTypeDataAccess();

        public abstract IMDCurrencyDataAccess CreateMDCurrencyDataAccess();

        public abstract IACMDDebitCreditDataAccess CreateACMDDebitCreditDataAccess();

        public abstract IACMDAccountResourceCategoryDataAccess CreateACMDAccountResourceCategoryDataAccess();

        public abstract IACMDPaidFromDataAccess CreateACMDPaidFromDataAccess();

        public abstract IACMDPayToDataAccess CreateACMDPayToDataAccess();

        public abstract IACMDBankAccountDepositApprovalStatusDataAccess CreateACMDBankAccountDepositApprovalStatusDataAccess();

        public abstract IACMDBankAccountPaymentApprovalStatusDataAccess CreateACMDBankAccountPaymentApprovalStatusDataAccess();

        public abstract IACMDTemporaryJournalApprovalStatusDataAccess CreateACMDTemporaryJournalApprovalStatusDataAccess();

        public abstract IACMDBankAccountTransferApprovalStatusDataAccess CreateACMDBankAccountTransferApprovalStatusDataAccess();

        public abstract IACMDTDSCategoryDataAccess CreateACMDTDSCategoryDataAccess();

        public abstract IMDMaterialReceiveApprovalStatusDataAccess CreateMDMaterialReceiveApprovalStatusDataAccess();

        public abstract IMDIssueAssignTypeDataAccess CreateMDIssueAssignTypeDataAccess();

        public abstract IKBMDUserTreeSettingDataAccess CreateKBMDUserTreeSettingDataAccess();

        public abstract IKBMDUserTreeSharedPermissionDataAccess CreateKBMDUserTreeSharedPermissionDataAccess();

        public abstract IKBMDUserTreeStatusDataAccess CreateKBMDUserTreeStatusDataAccess();

        public abstract ICRMMDAdvertiseWayDataAccess CreateCRMMDAdvertiseWayDataAccess();

        public abstract ICRMMDAreaUnitDataAccess CreateCRMMDAreaUnitDataAccess();

        public abstract ICRMMDBookingStatusDataAccess CreateCRMMDBookingStatusDataAccess();

        public abstract ICRMMDBuyerInterestedRoomCategoryDataAccess CreateCRMMDBuyerInterestedRoomCategoryDataAccess();

        public abstract ICRMMDBuyerTypeDataAccess CreateCRMMDBuyerTypeDataAccess();

        public abstract ICRMMDCommuicationDiscussionTypeDataAccess CreateCRMMDCommuicationDiscussionTypeDataAccess();

        public abstract ICRMMDCommunicationStatusDataAccess CreateCRMMDCommunicationStatusDataAccess();

        public abstract ICRMMDCustomerAddressTypeDataAccess CreateCRMMDCustomerAddressTypeDataAccess();

        public abstract ICRMMDLandLocationDataAccess CreateCRMMDLandLocationDataAccess();

        public abstract ICRMMDLandOwnerTypeDataAccess CreateCRMMDLandOwnerTypeDataAccess();

        public abstract IMDProjectFloorUnitStatusDataAccess CreateMDProjectFloorUnitStatusDataAccess();

        public abstract IMDProjectFloorUnitTypeDataAccess CreateMDProjectFloorUnitTypeDataAccess();

        public abstract IMDBloodGroupDataAccess CreateMDBloodGroupDataAccess();

        public abstract IMDEmployeeJobTypeDataAccess CreateMDEmployeeJobTypeDataAccess();

        public abstract ICRMMDAgreementApprovalStatusDataAccess CreateCRMMDAgreementApprovalStatusDataAccess();

        public abstract ICRMMDAgreementSpecsTypeDataAccess CreateCRMMDAgreementSpecsTypeDataAccess();

        public abstract ICRMMDAgreementTypeDataAccess CreateCRMMDAgreementTypeDataAccess();

        public abstract ICRMMDAgreementVariableDataAccess CreateCRMMDAgreementVariableDataAccess();

        public abstract ICRMMDPaymentApprovalStatusDataAccess CreateCRMMDPaymentApprovalStatusDataAccess();

        public abstract ICRMMDPaymentCategoryDataAccess CreateCRMMDPaymentCategoryDataAccess();

        public abstract IMDGenderDataAccess CreateMDGenderDataAccess();

        public abstract IBDMDProcessAssignedResourceApprovalStatusDataAccess CreateBDMDProcessAssignedResourceApprovalStatusDataAccess();

        public abstract IBDMDProcessCategoryDataAccess CreateBDMDProcessCategoryDataAccess();

        public abstract IBDMDRepeatCategoryDataAccess CreateBDMDRepeatCategoryDataAccess();

        public abstract IBDMDTaskDataAccess CreateBDMDTaskDataAccess();

        public abstract IBDMDTaskCategoryDataAccess CreateBDMDTaskCategoryDataAccess();

        public abstract IBDMDTaskRepeatDataAccess CreateBDMDTaskRepeatDataAccess();

        public abstract ICMMDBillFloorDetailCategoryDataAccess CreateCMMDBillFloorDetailCategoryDataAccess();

        public abstract IMDEvaluationCriteriaDataAccess CreateMDEvaluationCriteriaDataAccess();

        public abstract IMDEvaluationSessionCategoryDataAccess CreateMDEvaluationSessionCategoryDataAccess();

        public abstract IMDEvaluationSessionStatusDataAccess CreateMDEvaluationSessionStatusDataAccess();

        public abstract IMDEvaluatedByDataAccess CreateMDEvaluatedByDataAccess();

        public abstract IMDEvaluationCriteriaCategoryDataAccess CreateMDEvaluationCriteriaCategoryDataAccess();

        public abstract IMDSupervisorTypeDataAccess CreateMDSupervisorTypeDataAccess();
        
        public abstract IMDFloorUnitLocationCategoryDataAccess CreateMDFloorUnitLocationCategoryDataAccess();

        public abstract IMDOutsourceCategoryDataAccess CreateMDOutsourceCategoryDataAccess();

        public abstract ICMNMDEventCategoryDataAccess CreateCMNMDEventCategoryDataAccess();

        public abstract ICMNMDEventIdentityCategoryDataAccess CreateCMNMDEventIdentityCategoryDataAccess();

        public abstract ICMNMDEventOptionDataAccess CreateCMNMDEventOptionDataAccess();

        public abstract ICMNMDEventStatusDataAccess CreateCMNMDEventStatusDataAccess();

        public abstract ICMNMDSharedSettingDataAccess CreateCMNMDSharedSettingDataAccess();

        public abstract IMDArtGalleriaLocationDataAccess CreateMDArtGalleriaLocationDataAccess();

        public abstract IMDAssetDataAccess CreateMDAssetDataAccess();

        public abstract IMDAssetCateogryDataAccess CreateMDAssetCateogryDataAccess();
        
        public abstract IMDAssetConditionDataAccess CreateMDAssetConditionDataAccess();

        public abstract IMDAssetOwnerTypeDataAccess CreateMDAssetOwnerTypeDataAccess();

        public abstract IMDEventLocationCategoryDataAccess CreateMDEventLocationCategoryDataAccess();

        public abstract IMDSurveyBuildingStatusDataAccess CreateMDSurveyBuildingStatusDataAccess();

        public abstract IMDSurveyOwnerTypeDataAccess CreateMDSurveyOwnerTypeDataAccess();

        public abstract IMDSurveySourceInformationDataAccess CreateMDSurveySourceInformationDataAccess();

        public abstract IMDMailTextTypeDataAccess CreateMDMailTextTypeDataAccess();

        public abstract IMDEventInvitatedPersonTypeDataAccess CreateMDEventInvitatedPersonTypeDataAccess();

        public abstract IMDAreaDataAccess CreateMDAreaDataAccess();

        public abstract IMDAttendanceLeaveAndHolidayCategoryDataAccess CreateMDAttendanceLeaveAndHolidayCategoryDataAccess();

        public abstract IMDAttendanceLeaveHolidayListDataAccess CreateMDAttendanceLeaveHolidayListDataAccess();

        public abstract IMDBankAccountCategoryDataAccess CreateMDBankAccountCategoryDataAccess();

        public abstract IMDDocumentCategoryDataAccess CreateMDDocumentCategoryDataAccess();

        public abstract IMDDrivingLicenseCategoryDataAccess CreateMDDrivingLicenseCategoryDataAccess();

        public abstract IMDEducationalDegreeDataAccess CreateMDEducationalDegreeDataAccess();

        public abstract IMDEmployeeAdditionalInformationCategoryDataAccess CreateMDEmployeeAdditionalInformationCategoryDataAccess();

        public abstract IMDEmployeeAddressTypeDataAccess CreateMDEmployeeAddressTypeDataAccess();

        public abstract IMDEmployeeCompetencyLevelDataAccess CreateMDEmployeeCompetencyLevelDataAccess();

        public abstract IMDEmployeeContactTypeDataAccess CreateMDEmployeeContactTypeDataAccess();

        public abstract IMDEmployeeLanguageDataAccess CreateMDEmployeeLanguageDataAccess();

        public abstract IMDEmployeeLoanApprovalStatusDataAccess CreateMDEmployeeLoanApprovalStatusDataAccess();

        public abstract IMDEmployeeSkillDataAccess CreateMDEmployeeSkillDataAccess();

        public abstract IMDEmploymentStatusDataAccess CreateMDEmploymentStatusDataAccess();

        public abstract IMDFamilyRelationTypeDataAccess CreateMDFamilyRelationTypeDataAccess();

        public abstract IMDHolidayAppliedStatusDataAccess CreateMDHolidayAppliedStatusDataAccess();

        public abstract IMDHRNoticeTemplateTypeDataAccess CreateMDHRNoticeTemplateTypeDataAccess();

        public abstract IMDLeaveApplicationApplicationStatusDataAccess CreateMDLeaveApplicationApplicationStatusDataAccess();

        public abstract IMDLoanCategoryDataAccess CreateMDLoanCategoryDataAccess();

        public abstract IMDMaritalStatusDataAccess CreateMDMaritalStatusDataAccess();

        public abstract IMDPayCycleDataAccess CreateMDPayCycleDataAccess();

        public abstract IMDPayscaleDataAccess CreateMDPayscaleDataAccess();

        public abstract IMDReligionDataAccess CreateMDReligionDataAccess();

        public abstract IMDResumeCategoryDataAccess CreateMDResumeCategoryDataAccess();

        public abstract IMDSalaryRateDurationDataAccess CreateMDSalaryRateDurationDataAccess();

        public abstract IMDSalarySessionDataAccess CreateMDSalarySessionDataAccess();

        public abstract IMDSalarySessionStatusDataAccess CreateMDSalarySessionStatusDataAccess();

        public abstract IMDSalaryTaxTypeDataAccess CreateMDSalaryTaxTypeDataAccess();

        public abstract IMDSalaryTypeDataAccess CreateMDSalaryTypeDataAccess();

        public abstract IMDVisaStatusDataAccess CreateMDVisaStatusDataAccess();

        public abstract IMDEmployeeSalaryPaymentStatusDataAccess CreateMDEmployeeSalaryPaymentStatusDataAccess();

        public abstract IMDSalaryDeducationCategoryDataAccess CreateMDSalaryDeducationCategoryDataAccess();

        public abstract IMDLeaveCategoryDataAccess CreateMDLeaveCategoryDataAccess();

        public abstract IMDDistrictDataAccess CreateMDDistrictDataAccess();

        public abstract IMDDivisionDataAccess CreateMDDivisionDataAccess();

        public abstract IMDAllowanceCategoryDataAccess CreateMDAllowanceCategoryDataAccess();

        public abstract IMDLeavePolicyDataAccess CreateMDLeavePolicyDataAccess();


        #endregion

        #region PRM

        public abstract IPRMPreBOQDataAccess CreatePRMPreBOQDataAccess();

        public abstract IPRMPreBOQDetailDataAccess CreatePRMPreBOQDetailDataAccess();

        public abstract IPRMPreBOQTemplateDataAccess CreatePRMPreBOQTemplateDataAccess();

        public abstract IPRMPreBOQTemplateItemMapDataAccess CreatePRMPreBOQTemplateItemMapDataAccess();

        public abstract IPRMSupplierDataAccess CreatePRMSupplierDataAccess();

        public abstract IPRMSupplierAddressInfoDataAccess CreatePRMSupplierAddressInfoDataAccess();

        public abstract IPRMSupplierContactPersonDataAccess CreatePRMSupplierContactPersonDataAccess();

        public abstract IPRMSupplierBrandMapDataAccess CreatePRMSupplierBrandMapDataAccess();

        public abstract IPRMItemBrandMapDataAccess CreatePRMItemBrandMapDataAccess();

        public abstract IPRMSupplierItemMapDataAccess CreatePRMSupplierItemMapDataAccess();

        public abstract IPRMSupplierItemMapHistoryDataAccess CreatePRMSupplierItemMapHistoryDataAccess();

        public abstract IPRMSupplierItemCategoryMapDataAccess CreatePRMSupplierItemCategoryMapDataAccess();

        public abstract IPRMBOQDataAccess CreatePRMBOQDataAccess();

        public abstract IPRMBOQDetailDataAccess CreatePRMBOQDetailDataAccess();

        public abstract IPRMBOQDetailHistoryDataAccess CreatePRMBOQDetailHistoryDataAccess();

        public abstract IPRMBOQTemplateDataAccess CreatePRMBOQTemplateDataAccess();

        public abstract IPRMBOQTemplateItemMapDataAccess CreatePRMBOQTemplateItemMapDataAccess();

        public abstract IPRMPreBOQDetailHistoryDataAccess CreatePRMPreBOQDetailHistoryDataAccess();

        public abstract IPRMBOQFloorDetailDataAccess CreatePRMBOQFloorDetailDataAccess();

        public abstract IPRMMaterialReceiveDataAccess CreatePRMMaterialReceiveDataAccess();

        public abstract IPRMMaterialReceiveItemMapDataAccess CreatePRMMaterialReceiveItemMapDataAccess();

        public abstract IPRMWorkOrderDataAccess CreatePRMWorkOrderDataAccess();

        public abstract IPRMWorkOrderItemMapDataAccess CreatePRMWorkOrderItemMapDataAccess();

        public abstract IPRMWorkOrderPaymentTermDataAccess CreatePRMWorkOrderPaymentTermDataAccess();

        public abstract IPRMWorkOrderItemDetailDataAccess CreatePRMWorkOrderItemDetailDataAccess();

        public abstract IPRMAvailableBOQQtyForRequisitionDataAccess CreatePRMAvailableBOQQtyForRequisitionDataAccess();

        public abstract IPRMPreBOQFloorDetailDataAccess CreatePRMPreBOQFloorDetailDataAccess();

        public abstract IPRMWorkOrderItemFloorDetailDataAccess CreatePRMWorkOrderItemFloorDetailDataAccess();

        #endregion

        #region CM

        public abstract ICMProjectScheduleTemplateDataAccess CreateCMProjectScheduleTemplateDataAccess();

        public abstract ICMProjectScheduleTemplateItemMapDataAccess CreateCMProjectScheduleTemplateItemMapDataAccess();

        public abstract ICMContractorDataAccess CreateCMContractorDataAccess();

        public abstract ICMContractorContactPersonDataAccess CreateCMContractorContactPersonDataAccess();

        public abstract ICMContractorEquipmentListDataAccess CreateCMContractorEquipmentListDataAccess();

        public abstract ICMContractorLicenceDataAccess CreateCMContractorLicenceDataAccess();

        public abstract ICMContractorMajorProjectExecutedDataAccess CreateCMContractorMajorProjectExecutedDataAccess();

        public abstract ICMCriterionStatusRemarksDataAccess CreateCMCriterionStatusRemarksDataAccess();

        public abstract ICMContractorAddressInfoDataAccess CreateCMContractorAddressInfoDataAccess();

        public abstract ICMFinancialStrengthMajorWorkDataAccess CreateCMFinancialStrengthMajorWorkDataAccess();

        public abstract ICMContractor_DetailedDataAccess CreateCMContractor_DetailedDataAccess();

        public abstract ICMContractorAddressInfo_DetailedDataAccess CreateCMContractorAddressInfo_DetailedDataAccess();

        public abstract ICMContractorEquipmentList_DetailedDataAccess CreateCMContractorEquipmentList_DetailedDataAccess();

        public abstract ICMConsultantDataAccess CreateCMConsultantDataAccess();

        public abstract ICMConsultantAddressInfoDataAccess CreateCMConsultantAddressInfoDataAccess();

        public abstract ICMConsultantAssignedWorkAreaDataAccess CreateCMConsultantAssignedWorkAreaDataAccess();

        public abstract ICMConsultantContactPersonDataAccess CreateCMConsultantContactPersonDataAccess();

        public abstract ICMConsultantWorkAreaDataAccess CreateCMConsultantWorkAreaDataAccess();

        public abstract ICMWorkAreaStatusDataAccess CreateCMWorkAreaStatusDataAccess();

        public abstract ICMConsultantEnlistedWorkAreaDataAccess CreateCMConsultantEnlistedWorkAreaDataAccess();

        public abstract ICMProjectMilestoneDataAccess CreateCMProjectMilestoneDataAccess();

        public abstract ICMConstructionToolDataAccess CreateCMConstructionToolDataAccess();

        public abstract ICMConstructionToolDetailDataAccess CreateCMConstructionToolDetailDataAccess();

        public abstract ICMContractorAssignedWorkAreaDataAccess CreateCMContractorAssignedWorkAreaDataAccess();

        public abstract ICMMeasurementBookDataAccess CreateCMMeasurementBookDataAccess();

        public abstract ICMMeasurementBookDetailDataAccess CreateCMMeasurementBookDetailDataAccess();

        public abstract ICMBillDataAccess CreateCMBillDataAccess();

        public abstract ICMBillUploadInfoDataAccess CreateCMBillUploadInfoDataAccess();

        public abstract ICMBillRequisitionItemMapDataAccess CreateCMBillRequisitionItemMapDataAccess();

        public abstract ICMBillMaterialReceiveMeasurementBookMapDataAccess CreateCMBillMaterialReceiveMeasurementBookMapDataAccess();

        public abstract ICMBillFloorDetailDataAccess CreateCMBillFloorDetailDataAccess();

        #endregion

        #region OT

        public abstract IOTIssueDataAccess CreateOTIssueDataAccess();

        public abstract IOTIssueAssignedResourceDataAccess CreateOTIssueAssignedResourceDataAccess();

        public abstract IOTIssueUploadInfoDataAccess CreateOTIssueUploadInfoDataAccess();

        public abstract IOTIssueWatchListDataAccess CreateOTIssueWatchListDataAccess();

        public abstract IOTScheduleDataAccess CreateOTScheduleDataAccess();

        public abstract IOTScheduleResourceDataAccess CreateOTScheduleResourceDataAccess();

        #endregion

        #region REQ

        public abstract IREQRequisitionDataAccess CreateREQRequisitionDataAccess();

        public abstract IREQRequisitionItemDataAccess CreateREQRequisitionItemDataAccess();

        public abstract IREQRequisitionItemFloorDetailDataAccess CreateREQRequisitionItemFloorDetailDataAccess();

        public abstract IREQRequisitionUploadInfoDataAccess CreateREQRequisitionUploadInfoDataAccess();

        #endregion

        #region DMS

        public abstract IDMSDocumentNodeDataAccess CreateDMSDocumentNodeDataAccess();

        public abstract IDMSFileMovementRegisterDataAccess CreateDMSFileMovementRegisterDataAccess();

        public abstract IDMSFileTrackingDataAccess CreateDMSFileTrackingDataAccess();

        public abstract IDMSReferenceLibraryDataAccess CreateDMSReferenceLibraryDataAccess();

        #endregion

        #region ACC

        public abstract IACCPrePayableStatementDataAccess CreateACCPrePayableStatementDataAccess();

        public abstract IACCPrePayableStatementDetailDataAccess CreateACCPrePayableStatementDetailDataAccess();

        public abstract IACCPostPayableStatementDataAccess CreateACCPostPayableStatementDataAccess();

        public abstract IACCPostPayableStatementDetailDataAccess CreateACCPostPayableStatementDetailDataAccess();

        #endregion

        #region AC

        public abstract IACAccountDataAccess CreateACAccountDataAccess();

        public abstract IACAccountGroupDataAccess CreateACAccountGroupDataAccess();

        public abstract IACAccountStatusDataAccess CreateACAccountStatusDataAccess();

        public abstract IACClassDataAccess CreateACClassDataAccess();

        public abstract IACClassTypeDataAccess CreateACClassTypeDataAccess();

        public abstract IACBankAccountDataAccess CreateACBankAccountDataAccess();

        public abstract IACBudgetDataAccess CreateACBudgetDataAccess();

        public abstract IACCurrencyExchangeRatesDataAccess CreateACCurrencyExchangeRatesDataAccess();

        public abstract IACFiscalYearDataAccess CreateACFiscalYearDataAccess();

        public abstract IACCompanyInfoDataAccess CreateACCompanyInfoDataAccess();

        public abstract IACDimensionDataAccess CreateACDimensionDataAccess();

        public abstract IACItemAccountMapDataAccess CreateACItemAccountMapDataAccess();

        public abstract IACItemGroupAccountMapDataAccess CreateACItemGroupAccountMapDataAccess();

        public abstract IACTaxTypeDataAccess CreateACTaxTypeDataAccess();

        public abstract IACDebitCreditRuleDataAccess CreateACDebitCreditRuleDataAccess();

        public abstract IACDebitCreditRuleElementDataAccess CreateACDebitCreditRuleElementDataAccess();

        public abstract IACDepreciationMethodDataAccess CreateACDepreciationMethodDataAccess();

        public abstract IACJournalDataAccess CreateACJournalDataAccess();

        public abstract IACBankAccountDepositDataAccess CreateACBankAccountDepositDataAccess();

        public abstract IACBankAccountDepositItemDataAccess CreateACBankAccountDepositItemDataAccess();

        public abstract IACBankAccountPaymentDataAccess CreateACBankAccountPaymentDataAccess();

        public abstract IACBankAccountPaymentItemDataAccess CreateACBankAccountPaymentItemDataAccess();

        public abstract IACPettyCashDataAccess CreateACPettyCashDataAccess();

        public abstract IACBankAccountTransferDataAccess CreateACBankAccountTransferDataAccess();

        public abstract IACAccountResourceAccountMapDataAccess CreateACAccountResourceAccountMapDataAccess();

        public abstract IACTemporaryJournalDataAccess CreateACTemporaryJournalDataAccess();

        public abstract IACTemporaryJournalMasterDataAccess CreateACTemporaryJournalMasterDataAccess();

        public abstract IACTDSDataAccess CreateACTDSDataAccess();

        public abstract IACTDSHistoryDataAccess CreateACTDSHistoryDataAccess();

        public abstract IACResourceBankAccountMapDataAccess CreateACResourceBankAccountMapDataAccess();

        public abstract IACBankAccountPaymentPostPayableStatementDetailMapDataAccess CreateACBankAccountPaymentPostPayableStatementDetailMapDataAccess();
        
        #endregion

        #region CRM

        public abstract ICRMCustomerDataAccess CreateCRMCustomerDataAccess();

        public abstract ICRMCustomerAddressInfoDataAccess CreateCRMCustomerAddressInfoDataAccess();

        public abstract ICRMBuyerAllotteeDataAccess CreateCRMBuyerAllotteeDataAccess();

        public abstract ICRMBuyerBasicInfoDataAccess CreateCRMBuyerBasicInfoDataAccess();

        public abstract ICRMBuyerBookSpaceDataAccess CreateCRMBuyerBookSpaceDataAccess();

        public abstract ICRMBuyerInterestedRoomMapDataAccess CreateCRMBuyerInterestedRoomMapDataAccess();

        public abstract ICRMCommunicationDataAccess CreateCRMCommunicationDataAccess();

        public abstract ICRMLandBasicInfoDataAccess CreateCRMLandBasicInfoDataAccess();

        public abstract ICRMLandCurrentStatusDataAccess CreateCRMLandCurrentStatusDataAccess();

        public abstract ICRMLandOwnerDataAccess CreateCRMLandOwnerDataAccess();

        public abstract ICRMAgreementDataAccess CreateCRMAgreementDataAccess();

        public abstract ICRMAgreementSpecsDataAccess CreateCRMAgreementSpecsDataAccess();

        public abstract ICRMAgreementTemplateDataAccess CreateCRMAgreementTemplateDataAccess();

        public abstract ICRMAgreementVariableMapDataAccess CreateCRMAgreementVariableMapDataAccess();

        public abstract ICRMPaymentCollectionDataAccess CreateCRMPaymentCollectionDataAccess();

        public abstract ICRMPaymentScheduleDataAccess CreateCRMPaymentScheduleDataAccess();

        public abstract ICRMPaymentScheduleMapDataAccess CreateCRMPaymentScheduleMapDataAccess();

        public abstract ICRMBuyerChildrenInfoDataAccess CreateCRMBuyerChildrenInfoDataAccess();

        public abstract ICRMSurveyDataAccess CreateCRMSurveyDataAccess();

        public abstract ICRMSurveyOwnerDataAccess CreateCRMSurveyOwnerDataAccess();

        public abstract ICRMSurveyOwnerContactPersonDataAccess CreateCRMSurveyOwnerContactPersonDataAccess();
        
        public abstract ICRMSurveyMasterDataAccess CreateCRMSurveyMasterDataAccess();

        #endregion

        #region KB

        public abstract IKBUserTreeDataAccess CreateKBUserTreeDataAccess();

        public abstract IKBUserTreeModifiedHistoryDataAccess CreateKBUserTreeModifiedHistoryDataAccess();

        public abstract IKBUserTreeSharedDataAccess CreateKBUserTreeSharedDataAccess();

        public abstract IKBUserTreeUploadInfoDataAccess CreateKBUserTreeUploadInfoDataAccess();

        #endregion

        #region Security

        public abstract IASMemberAspnetUsersMapDataAccess CreateASMemberAspnetUsersMapDataAccess();

        public abstract IASPhysicalSiteMapDataAccess CreateASPhysicalSiteMapDataAccess();

        public abstract IASPhysicalSiteMapControlDataAccess CreateASPhysicalSiteMapControlDataAccess();

        public abstract IASRolePermissionDataAccess CreateASRolePermissionDataAccess();

        public abstract IASSiteMapDataAccess CreateASSiteMapDataAccess();

        public abstract IASSiteMapNodeDataAccess CreateASSiteMapNodeDataAccess();

        public abstract IASUserPermissionExcludedDataAccess CreateASUserPermissionExcludedDataAccess();

        public abstract IUserList_DetailedDataAccess CreateUserList_DetailedDataAccess();

        public abstract IActivityLogDataAccess CreateActivityLogDataAccess();

        #endregion

        #region StoreProcedure Detailed

        public abstract IPRMPreBOQ_DetailedDataAccess CreatePRMPreBOQ_DetailedDataAccess();

        public abstract IBDProject_DetailedDataAccess CreateBDProject_DetailedDataAccess();
        
        public abstract IBDProjectAddressInfo_DetailedDataAccess CreateBDProjectAddressInfo_DetailedDataAccess();
        
        public abstract IBDProjectAssignedPerson_DetailedDataAccess CreateBDProjectAssignedPerson_DetailedDataAccess();
        
        public abstract IBDProjectOtherInfo_DetailedDataAccess CreateBDProjectOtherInfo_DetailedDataAccess();
        
        public abstract IMDCity_DetailedDataAccess CreateMDCity_DetailedDataAccess();
        
        public abstract IMDCountry_DetailedDataAccess CreateMDCountry_DetailedDataAccess();

        public abstract IHRHoliday_DetailedDataAccess CreateHRHoliday_DetailedDataAccess();

        public abstract IHRMember_DetailedDataAccess CreateHRMember_DetailedDataAccess();

        public abstract IMDIssueCategory_DetailedDataAccess CreateMDIssueCategory_DetailedDataAccess();

        public abstract IMDScheduleCategory_DetailedDataAccess CreateMDScheduleCategory_DetailedDataAccess();

        public abstract IOTIssue_DetailedDataAccess CreateOTIssue_DetailedDataAccess();

        public abstract IOTSchedule_DetailedDataAccess CreateOTSchedule_DetailedDataAccess();

        public abstract IResource_DetailedDataAccess CreateResource_DetailedDataAccess();

        public abstract IASSiteMapNode_DetailedDataAccess CreateASSiteMapNode_DetailedDataAccess();

        public abstract ICMConsultantAddressInfo_DetailedDataAccess CreateCMConsultantAddressInfo_DetailedDataAccess();

        public abstract ICMConsultantAssignedWorkArea_DetailedDataAccess CreateCMConsultantAssignedWorkArea_DetailedDataAccess();

        public abstract ICMConsultantEnlistedWorkArea_DetailedDataAccess CreateCMConsultantEnlistedWorkArea_DetailedDataAccess();

        public abstract IREQRequisitionItem_DetailedDataAccess CreateREQRequisitionItem_DetailedDataAccess();

        public abstract IREQRequisition_DetailedDataAccess CreateREQRequisition_DetailedDataAccess();

        public abstract ICMProjectMilestone_DetailedDataAccess CreateCMProjectMilestone_DetailedDataAccess();

        public abstract IPRMSupplier_DetailedDataAccess CreatePRMSupplier_DetailedDataAccess();

        public abstract IPRMSupplierAddressInfo_DetailedDataAccess CreatePRMSupplierAddressInfo_DetailedDataAccess();

        public abstract ICMConstructionTool_DetailedDataAccess CreateCMConstructionTool_DetailedDataAccess();

        public abstract ICMConstructionToolDetail_DetailedDataAccess CreateCMConstructionToolDetail_DetailedDataAccess();

        public abstract ICMNDashboardItem_DetailedDataAccess CreateCMNDashboardItem_DetailedDataAccess();

        public abstract ICMCriterionStatusRemarks_DetailedDataAccess CreateCMCriterionStatusRemarks_DetailedDataAccess();

        public abstract ICMNDashboardItemQuicklink_DetailedDataAccess CreateCMNDashboardItemQuicklink_DetailedDataAccess();

        public abstract IPRMSupplierBrandMap_DetailedDataAccess CreatePRMSupplierBrandMap_DetailedDataAccess();

        public abstract IPRMSupplierItemMap_DetailedDataAccess CreatePRMSupplierItemMap_DetailedDataAccess();

        public abstract IPRMItemBrandMap_DetailedDataAccess CreatePRMItemBrandMap_DetailedDataAccess();

        public abstract IBDProjectHistory_DetailedDataAccess CreateBDProjectHistory_DetailedDataAccess();

        public abstract IPRMBOQFloorDetail_DetailedDataAccess CreatePRMBOQFloorDetail_DetailedDataAccess();

        public abstract IMDApprovalRuleDesignationMap_DetailedDataAccess CreateMDApprovalRuleDesignationMap_DetailedDataAccess();

        public abstract IBDProjectFloor_DetailedDataAccess CreateBDProjectFloor_DetailedDataAccess();

        public abstract IMDFloor_DetailedDataAccess CreateMDFloor_DetailedDataAccess();

        public abstract IPRMBOQDetail_DetailedCustomDataAccess CreatePRMBOQDetail_DetailedCustomDataAccess();

        public abstract IPRMPreBOQDetail_DetailedCustomDataAccess CreatePRMPreBOQDetail_DetailedCustomDataAccess();

        public abstract IPRMWorkOrder_DetailedDataAccess CreatePRMWorkOrder_DetailedDataAccess();

        public abstract IPRMWorkOrderItemMap_DetailedDataAccess CreatePRMWorkOrderItemMap_DetailedDataAccess();

        public abstract IPRMMaterialReceiveItemMap_DetailedDataAccess CreatePRMMaterialReceiveItemMap_DetailedDataAccess();

        public abstract IPRMMaterialReceive_DetailedDataAccess CreatePRMMaterialReceive_DetailedDataAccess();

        public abstract IPRMWorkOrderItemDetail_DetailedDataAccess CreatePRMWorkOrderItemDetail_DetailedDataAccess();

        public abstract IDMSFileMovementRegister_DetailedDataAccess CreateDMSFileMovementRegister_DetailedDataAccess();

        public abstract IDMSFileTracking_DetailedDataAccess CreateDMSFileTracking_DetailedDataAccess();

        public abstract IDMSReferenceLibrary_DetailedDataAccess CreateDMSReferenceLibrary_DetailedDataAccess();

        public abstract ICMMeasurementBook_DetailedDataAccess CreateCMMeasurementBook_DetailedDataAccess();

        public abstract ICMMeasurementBookDetail_DetailedDataAccess CreateCMMeasurementBookDetail_DetailedDataAccess();

        public abstract IAPMemberFeedback_DetailedDataAccess CreateAPMemberFeedback_DetailedDataAccess();

        public abstract IAPMemberFeedbackRemarks_DetailedDataAccess CreateAPMemberFeedbackRemarks_DetailedDataAccess();

        public abstract IAPWOPanelItemCategoryMap_DetailedDataAccess CreateAPWOPanelItemCategoryMap_DetailedDataAccess();

        public abstract IAPPanelForwardMember_DetailedDataAccess CreateAPPanelForwardMember_DetailedDataAccess();

        public abstract IAPForwardInfo_DetailedDataAccess CreateAPForwardInfo_DetailedDataAccess();

        public abstract ICMContractorAssignedWorkArea_DetailedDataAccess CreateCMContractorAssignedWorkArea_DetailedDataAccess();

        public abstract ICMBill_DetailedDataAccess CreateCMBill_DetailedDataAccess();

        public abstract IINVCurrentStock_DetailedDataAccess CreateINVCurrentStock_DetailedDataAccess();

        public abstract IINVStore_DetailedDataAccess CreateINVStore_DetailedDataAccess();

        public abstract IINVStoreUnit_DetailedDataAccess CreateINVStoreUnit_DetailedDataAccess();

        public abstract IINVStoreUnitItem_DetailedDataAccess CreateINVStoreUnitItem_DetailedDataAccess();

        public abstract IINVTransaction_DetailedDataAccess CreateINVTransaction_DetailedDataAccess();

        public abstract IINVStoreIssueNote_DetailedDataAccess CreateINVStoreIssueNote_DetailedDataAccess();

        public abstract IINVStoreIssueNoteItemMap_DetailedDataAccess CreateINVStoreIssueNoteItemMap_DetailedDataAccess();

        public abstract IINVTransfer_DetailedDataAccess CreateINVTransfer_DetailedDataAccess();

        public abstract IINVTransferItem_DetailedDataAccess CreateINVTransferItem_DetailedDataAccess();

        public abstract IACCPostPayableStatementDetail_DetailedDataAccess CreateACCPostPayableStatementDetail_DetailedDataAccess();

        public abstract IACCRequisitionWorkOrderMRRDetail_DetailedDataAccess CreateACCRequisitionWorkOrderMRRDetail_DetailedDataAccess();

        public abstract ICMBillRequisitionItemMap_DetailedDataAccess CreateCMBillRequisitionItemMap_DetailedDataAccess();

        public abstract IACAccount_DetailedDataAccess CreateACAccount_DetailedDataAccess();

        public abstract IACAccountGroup_DetailedDataAccess CreateACAccountGroup_DetailedDataAccess();

        public abstract IACClass_DetailedDataAccess CreateACClass_DetailedDataAccess();

        public abstract IACBankAccount_DetailedDataAccess CreateACBankAccount_DetailedDataAccess();

        public abstract IACBudget_DetailedDataAccess CreateACBudget_DetailedDataAccess();

        public abstract IACCurrencyExchangeRates_DetailedDataAccess CreateACCurrencyExchangeRates_DetailedDataAccess();

        public abstract IMDCurrency_DetailedDataAccess CreateMDCurrency_DetailedDataAccess();

        public abstract IACBankAccountDepositItem_DetailedDataAccess CreateACBankAccountDepositItem_DetailedDataAccess();

        public abstract IACBankAccountPaymentItem_DetailedDataAccess CreateACBankAccountPaymentItem_DetailedDataAccess();

        public abstract IACJournal_DetailedDataAccess CreateACJournal_DetailedDataAccess();

        public abstract IACBankAccountDeposit_DetailedDataAccess CreateACBankAccountDeposit_DetailedDataAccess();

        public abstract IACBankAccountPayment_DetailedDataAccess CreateACBankAccountPayment_DetailedDataAccess();

        public abstract IACTemporaryJournal_DetailedDataAccess CreateACTemporaryJournal_DetailedDataAccess();

        public abstract IACTemporaryJournalMaster_DetailedDataAccess CreateACTemporaryJournalMaster_DetailedDataAccess();

        public abstract IACBankAccountTransfer_DetailedDataAccess CreateACBankAccountTransfer_DetailedDataAccess();

        public abstract ICMNERPComment_DetailedDataAccess CreateCMNERPComment_DetailedDataAccess();

        public abstract IKBUserTreeShared_DetailedDataAccess CreateKBUserTreeShared_DetailedDataAccess();

        public abstract IKBUserTree_DetailedDataAccess CreateKBUserTree_DetailedDataAccess();

        public abstract IBDProjectFloorUnit_DetailedDataAccess CreateBDProjectFloorUnit_DetailedDataAccess();

        public abstract ICRMBuyerBasicInfo_DetailedDataAccess CreateCRMBuyerBasicInfo_DetailedDataAccess();

        public abstract ICRMBuyerBookSpace_DetailedDataAccess CreateCRMBuyerBookSpace_DetailedDataAccess();

        public abstract ICRMBuyerInterestedRoomMap_DetailedDataAccess CreateCRMBuyerInterestedRoomMap_DetailedDataAccess();

        public abstract ICRMCommunication_DetailedDataAccess CreateCRMCommunication_DetailedDataAccess();

        public abstract ICRMLandBasicInfo_DetailedDataAccess CreateCRMLandBasicInfo_DetailedDataAccess();

        public abstract ICRMAgreement_DetailedDataAccess CreateCRMAgreement_DetailedDataAccess();

        public abstract ICRMPaymentCollection_DetailedDataAccess CreateCRMPaymentCollection_DetailedDataAccess();

        public abstract ICRMPaymentSchedule_DetailedDataAccess CreateCRMPaymentSchedule_DetailedDataAccess();

        public abstract IPRMPreBOQFloorDetail_DetailedDataAccess CreatePRMPreBOQFloorDetail_DetailedDataAccess();

        public abstract IREQRequisitionItemFloorDetail_DetailedDataAccess CreateREQRequisitionItemFloorDetail_DetailedDataAccess();
        
        public abstract IHREmployeeSupervisorMap_DetailedDataAccess CreateHREmployeeSupervisorMap_DetailedDataAccess();

        public abstract ICMNEvent_DetailedDataAccess CreateCMNEvent_DetailedDataAccess();

        public abstract ICMNEventInvitationInformation_DetailedDataAccess CreateCMNEventInvitationInformation_DetailedDataAccess();

        public abstract IMDAsset_DetailedDataAccess CreateMDAsset_DetailedDataAccess();

        public abstract IBDProcessAssignedResource_DetailedDataAccess CreateBDProcessAssignedResource_DetailedDataAccess();

        public abstract ICMNMailTemplate_DetailedDataAccess CreateCMNMailTemplate_DetailedDataAccess();

        public abstract ICMConsultant_DetailedDataAccess CreateCMConsultant_DetailedDataAccess();

        public abstract ICRMBuyerChildrenInfo_DetailedDataAccess CreateCRMBuyerChildrenInfo_DetailedDataAccess();

        public abstract ICRMSurveyOwner_DetailedDataAccess CreateCRMSurveyOwner_DetailedDataAccess();

        public abstract IINVTransactionAvailable_DetailedDataAccess CreateINVTransactionAvailable_DetailedDataAccess();

        public abstract ICRMPaymentScheduleMap_DetailedDataAccess CreateCRMPaymentScheduleMap_DetailedDataAccess();

        public abstract IHREmployee_DetailedDataAccess CreateHREmployee_DetailedDataAccess();

        public abstract IHRDepartmentEmployeeMap_DetailedDataAccess CreateHRDepartmentEmployeeMap_DetailedDataAccess();

        public abstract IHREmployeeAddressInfo_DetailedDataAccess CreateHREmployeeAddressInfo_DetailedDataAccess();

        public abstract IHREmployeeBankAccountInformation_DetailedDataAccess CreateHREmployeeBankAccountInformation_DetailedDataAccess();

        public abstract IHREmployeeContactInfo_DetailedDataAccess CreateHREmployeeContactInfo_DetailedDataAccess();

        public abstract IHREmployeeDrivingLicenseInformation_DetailedDataAccess CreateHREmployeeDrivingLicenseInformation_DetailedDataAccess();

        public abstract IHREmployeeEducation_DetailedDataAccess CreateHREmployeeEducation_DetailedDataAccess();

        public abstract IHREmployeeExperience_DetailedDataAccess CreateHREmployeeExperience_DetailedDataAccess();

        public abstract IHREmployeeFamilyInfo_DetailedDataAccess CreateHREmployeeFamilyInfo_DetailedDataAccess();

        public abstract IHREmployeeLanguageMap_DetailedDataAccess CreateHREmployeeLanguageMap_DetailedDataAccess();

        public abstract IHREmployeeLeaveApplication_DetailedDataAccess CreateHREmployeeLeaveApplication_DetailedDataAccess();

        public abstract IHREmployeeLoanApplication_DetailedDataAccess CreateHREmployeeLoanApplication_DetailedDataAccess();

        public abstract IHREmployeePassportInformation_DetailedDataAccess CreateHREmployeePassportInformation_DetailedDataAccess();

        public abstract IHREmployeeSkillMap_DetailedDataAccess CreateHREmployeeSkillMap_DetailedDataAccess();

        public abstract IHRMemberLeaveAccount_DetailedDataAccess CreateHRMemberLeaveAccount_DetailedDataAccess();

        public abstract IHRSession_DetailedDataAccess CreateHRSession_DetailedDataAccess();

        public abstract IHREmployeeNotice_DetailedDataAccess CreateHREmployeeNotice_DetailedDataAccess();

        public abstract IHREmployeeLeaveStatus_DetailedDataAccess CreateHREmployeeLeaveStatus_DetailedDataAccess();

        public abstract IMDSalarySession_DetailedDataAccess CreateMDSalarySession_DetailedDataAccess();

        public abstract IMDLeavePolicy_DetailedDataAccess CreateMDLeavePolicy_DetailedDataAccess();

        public abstract IHREmployeeAllowanceCustom_DetailedDataAccess CreateHREmployeeAllowanceCustom_DetailedDataAccess();

        public abstract IHREmployeeSalaryInfo_DetailedDataAccess CreateHREmployeeSalaryInfo_DetailedDataAccess();

        public abstract IHREmployeeAllowance_DetailedDataAccess CreateHREmployeeAllowance_DetailedDataAccess();

        public abstract IHREmployeeSalaryDeducationInfo_DetailedDataAccess CreateHREmployeeSalaryDeducationInfo_DetailedDataAccess();

        public abstract IHRSalaryAdjustment_DetailedDataAccess CreateHRSalaryAdjustment_DetailedDataAccess();

        public abstract IHREmployeeMonthlyTimeSheet_DetailedDataAccess CreateHREmployeeMonthlyTimeSheet_DetailedDataAccess();

        #endregion

        #region StoreProcedure Custom

        public abstract IPRMPreBOQDetail_CustomDataAccess CreatePRMPreBOQDetail_CustomDataAccess();

        public abstract IPRMPreBOQTemplateItemMapBulkInsertDataAccess CreatePRMPreBOQTemplateItemMapBulkInsertDataAccess();

        public abstract IBulkInsertXMLDataAccess CreateBulkInsertXMLDataAccess();

        public abstract IASPNETUserNameByMemberIDDataAccess CreateASPNETUserNameByMemberIDDataAccess();

        public abstract ICMProjectMilestone_CustomDataAccess CreateCMProjectMilestone_CustomDataAccess();

        public abstract IResourceConsultant_CustomDataAccess CreateResourceConsultant_CustomDataAccess();

        public abstract IResourceContractor_CustomDataAccess CreateResourceContractor_CustomDataAccess();

        public abstract IResourceEmployee_CustomDataAccess CreateResourceEmployee_CustomDataAccess();

        public abstract IPRMSupplierByBrand_CustomDataAccess CreatePRMSupplierByBrand_CustomDataAccess();

        public abstract IPRMItemBrandMap_CustomDataAccess CreatePRMItemBrandMap_CustomDataAccess();

        public abstract IPRMSupplierItemMapHistory_CustomDataAccess CreatePRMSupplierItemMapHistory_CustomDataAccess();

        public abstract IPRMItemBrandMapDistinct_CustomDataAccess CreatePRMItemBrandMapDistinct_CustomDataAccess();

        public abstract IBDProject_CustomDataAccess CreateBDProject_CustomDataAccess();

        public abstract IBDProjectStatusDistinct_CustomDataAccess CreateBDProjectStatusDistinct_CustomDataAccess();

        public abstract ICMConsultantEnlistedWorkArea_CustomDataAccess CreateCMConsultantEnlistedWorkArea_CustomDataAccess();

        public abstract IPRMSupplierView_CustomDataAccess CreatePRMSupplierView_CustomDataAccess();

        public abstract IPreBOQtoBOQMigration_CustomDataAccess CreatePreBOQtoBOQMigration_CustomDataAccess();

        public abstract IPRMBOQDetail_CustomDataAccess CreatePRMBOQDetail_CustomDataAccess();

        public abstract IPRMBOQDetailHistory_CustomDataAccess CreatePRMBOQDetailHistory_CustomDataAccess();

        public abstract IPRMPreBOQDetailHistory_CustomDataAccess CreatePRMPreBOQDetailHistory_CustomDataAccess();

        public abstract IOTResourceIssueSchedule_CustomDataAccess CreateOTResourceIssueSchedule_CustomDataAccess();

        public abstract IREQRequisitionItem_CustomDataAccess CreateREQRequisitionItem_CustomDataAccess();

        public abstract IPRMWorkOrder_CustomDataAccess CreatePRMWorkOrder_CustomDataAccess();

        public abstract IPRMRequisitionBySupplierDistinct_CustomDataAccess CreatePRMRequisitionBySupplierDistinct_CustomDataAccess();

        public abstract IPRMSupplierByProjectDistinct_CustomDataAccess CreatePRMSupplierByProjectDistinct_CustomDataAccess();

        public abstract IPRMWorkOrderByRequisitionDistinct_CustomDataAccess CreatePRMWorkOrderByRequisitionDistinct_CustomDataAccess();

        public abstract IPRMBrandByItem_CustomDataAccess CreatePRMBrandByItem_CustomDataAccess();

        public abstract IPRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess CreatePRMOriginCountryByBrandItemRegionDistinct_CustomDataAccess();

        public abstract IPRMOriginRegionByBrandItemDistinct_CustomDataAccess CreatePRMOriginRegionByBrandItemDistinct_CustomDataAccess();

        public abstract IHRMember_CustomDataAccess CreateHRMember_CustomDataAccess();

        public abstract IBDProjectByMember_CustomDataAccess CreateBDProjectByMember_CustomDataAccess();

        public abstract IDMSFileTrackingDepartmentDistinct_CustomDataAccess CreateDMSFileTrackingDepartmentDistinct_CustomDataAccess();

        public abstract IAPPanelItemCategoryMap_CustomDataAccess CreateAPPanelItemCategoryMap_CustomDataAccess();

        public abstract IAPPanelMember_CustomDataAccess CreateAPPanelMember_CustomDataAccess();

        public abstract ICMAbstractMeasurementBook_CustomDataAccess CreateCMAbstractMeasurementBook_CustomDataAccess();

        public abstract ICMAbstractMeasurementBookHelper_CustomDataAccess CreateCMAbstractMeasurementBookHelper_CustomDataAccess();

        public abstract IPRMBOQRequisitionItem_CustomDataAccess CreatePRMBOQRequisitionItem_CustomDataAccess();

        public abstract IPRMWorkOrderItemByWorkOrder_CustomDataAccess CreatePRMWorkOrderItemByWorkOrder_CustomDataAccess();

        public abstract IPRMPreBOQRequisitionItem_CustomDataAccess CreatePRMPreBOQRequisitionItem_CustomDataAccess();

        public abstract IACCPrePayableStatementDetail_CustomDataAccess CreateACCPrePayableStatementDetail_CustomDataAccess();

        public abstract IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess CreateACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess();

        public abstract IINV_MakeDefaultStore_CustomDataAccess CreateINV_MakeDefaultStore_CustomDataAccess();

        public abstract IINV_MakeDefaultStoreUnit_CustomDataAccess CreateINV_MakeDefaultStoreUnit_CustomDataAccess();

        public abstract IACCPrePayableStatementDetailByBill_CustomDataAccess CreateACCPrePayableStatementDetailByBill_CustomDataAccess();

        public abstract IACCPrePayableStatementDetailFromWO_CustomDataAccess CreateACCPrePayableStatementDetailFromWO_CustomDataAccess();

        public abstract IINVTransactionINOUT_CustomDataAccess CreateINVTransactionINOUT_CustomDataAccess();

        public abstract IACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess CreateACCPrePayableStatementDetailByWorkOrderNo_CustomDataAccess();

        public abstract IPRMWorkOrderNoByRequisition_CustomDataAccess CreatePRMWorkOrderNoByRequisition_CustomDataAccess();

        public abstract IPRMApprovedAdvancePaymentWorkOrder_CustomDataAccess CreatePRMApprovedAdvancePaymentWorkOrder_CustomDataAccess();

        public abstract IINVTransactionAvailableQtyWithBatch_CustomDataAccess CreateINVTransactionAvailableQtyWithBatch_CustomDataAccess();

        public abstract IACCPrePayableStatementDistinct_CustomDataAccess CreateACCPrePayableStatementDistinct_CustomDataAccess();

        public abstract IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess CreateAPApprovedRequisitionForWOByPanelMember_CustomDataAccess();

        public abstract IREQRequisitionWithWorkOrder_CustomDataAccess CreateREQRequisitionWithWorkOrder_CustomDataAccess();

        public abstract ICMApprovedBillExceptACCPrePayable_CustomDataAccess CreateCMApprovedBillExceptACCPrePayable_CustomDataAccess();

        public abstract IPRMMaterialRequisitionItem_CustomDataAccess CreatePRMMaterialRequisitionItem_CustomDataAccess();

        public abstract IACAccountsHelper_CustomDataAccess CreateACAccountsHelper_CustomDataAccess();

        public abstract IACBankStatement_CustomDataAccess CreateACBankStatement_CustomDataAccess();

        public abstract IACTrialBalance_CustomDataAccess CreateACTrialBalance_CustomDataAccess();

        public abstract IACAccountGroupBalanceSheet_CustomDataAccess CreateACAccountGroupBalanceSheet_CustomDataAccess();

        public abstract IACAccountBalanceSheet_CustomDataAccess CreateACAccountBalanceSheet_CustomDataAccess();

        public abstract IACProjectWiseAccountResourceTransaction_CustomDataAccess CreateACProjectWiseAccountResourceTransaction_CustomDataAccess();

        public abstract IACAccountOpenCloseBalance_CustomDataAccess CreateACAccountOpenCloseBalance_CustomDataAccess();

        public abstract ICRMContactList_CustomDataAccess CreateCRMContactList_CustomDataAccess();

        public abstract IREQRequisitionDashboard_CustomDataAccess CreateREQRequisitionDashboard_CustomDataAccess();

        public abstract IMDItem_CustomDataAccess CreateMDItem_CustomDataAccess();

        public abstract IHRGenerateEvaluation_CustomDataAccess CreateHRGenerateEvaluation_CustomDataAccess();

        public abstract IHREmployeeEvaluationSession_CustomDataAccess CreateHREmployeeEvaluationSession_CustomDataAccess();

        public abstract IHREmployeeEvaluationIndividual_CustomDataAccess CreateHREmployeeEvaluationIndividual_CustomDataAccess();

        public abstract IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess CreatePRMWorkOrderSingleClickFromRequisition_CustomDataAccess();

        public abstract IINVTransaction_CustomDataAccess CreateINVTransaction_CustomDataAccess();

        public abstract IACProjectWiseAccount_CustomDataAccess CreateACProjectWiseAccount_CustomDataAccess();

        public abstract IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess CreateHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess();

        public abstract IHRMonthlySalaryPayment_CustomDataAccess CreateHRMonthlySalaryPayment_CustomDataAccess();

        public abstract IOTIssue_CustomDataAccess CreateOTIssue_CustomDataAccess();

        #endregion

        #region StoreProcedure Report

        public abstract IREQRequisition_RPTDataAccess CreateREQRequisition_RPTDataAccess();

        public abstract IBDProject_RPTDataAccess CreateBDProject_RPTDataAccess();

        public abstract IBDProjectHistory_RPTDataAccess CreateBDProjectHistory_RPTDataAccess();

        public abstract IMDItem_RPTDataAccess CreateMDItem_RPTDataAccess();

        public abstract IPRMSupplierItemMapHistory_RPTDataAccess CreatePRMSupplierItemMapHistory_RPTDataAccess();

        public abstract IOTMissedIssue_RPTDataAccess CreateOTMissedIssue_RPTDataAccess();

        public abstract IOTUpcomingIssue_RPTDataAccess CreateOTUpcomingIssue_RPTDataAccess();

        public abstract IOTIssue_RPTDataAccess CreateOTIssue_RPTDataAccess();

        public abstract IPRMWorkOrder_RPTDataAccess CreatePRMWorkOrder_RPTDataAccess();

        public abstract IPRMWorkOrderPaymentTerm_RPTDataAccess CreatePRMWorkOrderPaymentTerm_RPTDataAccess();

        public abstract IPRMMaterialReceive_RPTDataAccess CreatePRMMaterialReceive_RPTDataAccess();

        public abstract IREQRequisitionApprovedPortion_RPTDataAccess CreateREQRequisitionApprovedPortion_RPTDataAccess();

        public abstract IPRMWorkOrderItemDetail_RPTDataAccess CreatePRMWorkOrderItemDetail_RPTDataAccess();

        public abstract ICMBill_RPTDataAccess CreateCMBill_RPTDataAccess();

        public abstract ICMMeasurementBookByBill_RPTDataAccess CreateCMMeasurementBookByBill_RPTDataAccess();

        public abstract IPRMMaterialReceiveByWorkOrder_RPTDataAccess CreatePRMMaterialReceiveByWorkOrder_RPTDataAccess();

        public abstract IACCPostPayableStatement_RPTDataAccess CreateACCPostPayableStatement_RPTDataAccess();

        public abstract IACCPrePayableStatement_RPTDataAccess CreateACCPrePayableStatement_RPTDataAccess();

        public abstract ICMBillWithRequisitionItemMap_RPTDataAccess CreateCMBillWithRequisitionItemMap_RPTDataAccess();

        public abstract IACTrialBalanceForActiveFiscalYear_RPTDataAccess CreateACTrialBalanceForActiveFiscalYear_RPTDataAccess();

        public abstract IACBalanceSheet_RPTDataAccess CreateACBalanceSheet_RPTDataAccess();

        public abstract IACBankAccountDeposit_RPTDataAccess CreateACBankAccountDeposit_RPTDataAccess();

        public abstract IACBankAccountPayment_RPTDataAccess CreateACBankAccountPayment_RPTDataAccess();

        public abstract IACTemporaryJournal_RPTDataAccess CreateACTemporaryJournal_RPTDataAccess();

        public abstract ICRMAgreement_RPTDataAccess CreateCRMAgreement_RPTDataAccess();

        public abstract ICRMPaymentCollectionMoneyRecipt_RPTDataAccess CreateCRMPaymentCollectionMoneyRecipt_RPTDataAccess();

        public abstract ICRMPaymentSchedule_RPTDataAccess CreateCRMPaymentSchedule_RPTDataAccess();

        public abstract ICRMPaymentCollection_RPTDataAccess CreateCRMPaymentCollection_RPTDataAccess();

        public abstract ICRMBookingStatus_RPTDataAccess CreateCRMBookingStatus_RPTDataAccess();

        public abstract IBDProjectStatusWiseFloorUnit_RPTDataAccess CreateBDProjectStatusWiseFloorUnit_RPTDataAccess();

        public abstract ICRMDuePaymentFromPaymentSchedule_RPTDataAccess CreateCRMDuePaymentFromPaymentSchedule_RPTDataAccess();

        public abstract ICRMPaymentEncashed_RPTDataAccess CreateCRMPaymentEncashed_RPTDataAccess();

        public abstract ICRMCustomerPortfolioSummary_RPTDataAccess CreateCRMCustomerPortfolioSummary_RPTDataAccess();

        public abstract IBDProjectCutom_RPTDataAccess CreateBDProjectCutom_RPTDataAccess();

        public abstract IOTIssueDateWise_RPTDataAccess CreateOTIssueDateWise_RPTDataAccess();

        public abstract IBDProjectCollectedDocumentCustom_RPTDataAccess CreateBDProjectCollectedDocumentCustom_RPTDataAccess();

        public abstract IBDProcessAssignedResourceMap_RPTDataAccess CreateBDProcessAssignedResourceMap_RPTDataAccess();

        public abstract IACAccount_RPTDataAccess CreateACAccount_RPTDataAccess();

        public abstract IACBankAccountDepositDateWise_RPTDataAccess CreateACBankAccountDepositDateWise_RPTDataAccess();

        public abstract IACBankAccountPaymentDateWise_RPTDataAccess CreateACBankAccountPaymentDateWise_RPTDataAccess();

        public abstract IACDayBookJournalDateWise_RPTDataAccess CreateACDayBookJournalDateWise_RPTDataAccess();

        public abstract IACTemporaryJournalDateWise_RPTDataAccess CreateACTemporaryJournalDateWise_RPTDataAccess();

        public abstract IACCashPaymentDateWise_RPTDataAccess CreateACCashPaymentDateWise_RPTDataAccess();

        public abstract IOTIssueCategoryWise_RPTDataAccess CreateOTIssueCategoryWise_RPTDataAccess();

        public abstract IOTIssueWithEmployeeandDateWise_RPTDataAccess CreateOTIssueWithEmployeeandDateWise_RPTDataAccess();

        public abstract IREQRequisitionItemFloorDetail_RPTDataAccess CreateREQRequisitionItemFloorDetail_RPTDataAccess();

        public abstract IPRMWorkOrderItemFloorDetail_RPTDataAccess CreatePRMWorkOrderItemFloorDetail_RPTDataAccess();

        public abstract IBDFloorWiseWOBillDetail_RPTDataAccess CreateBDFloorWiseWOBillDetail_RPTDataAccess();

        public abstract IOTIssueCategoryWiseIndividual_RPTDataAccess CreateOTIssueCategoryWiseIndividual_RPTDataAccess();

        public abstract IHREvaluation_RPTDataAccess CreateHREvaluation_RPTDataAccess();

        public abstract IHRDTLSubmission_RPTDataAccess CreateHRDTLSubmission_RPTDataAccess();

        public abstract ICRMSurvey_RPTDataAccess CreateCRMSurvey_RPTDataAccess();

        public abstract ICRMAdvertisementRequisition_RPTDataAccess CreateCRMAdvertisementRequisition_RPTDataAccess();

        public abstract IINVStoreIssueNoteItemMap_RPTDataAccess CreateINVStoreIssueNoteItemMap_RPTDataAccess();

        public abstract ICRMSurveyMaster_RPTDataAccess CreateCRMSurveyMaster_RPTDataAccess();

        public abstract IHREmployeeEvaluationReport_RPTDataAccess CreateHREmployeeEvaluationReport_RPTDataAccess();

        public abstract IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess CreateHREmployeeEvaluationReportForAllEmployee_RPTDataAccess();

        public abstract IHRWorkingDay_RPTDataAccess CreateHRWorkingDay_RPTDataAccess();

        public abstract IHREmployeeTimeSheet_RPTDataAccess CreateHREmployeeTimeSheet_RPTDataAccess();

        public abstract IHREmployeeDetails_RPTDataAccess CreateHREmployeeDetails_RPTDataAccess();

        public abstract IHREmployeeList_RPTDataAccess CreateHREmployeeList_RPTDataAccess();

        public abstract IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess CreateHREmployeeMonthlyTimeSheetSummary_RPTDataAccess();

        public abstract IHREmployeeSalaryPayment_RPTDataAccess CreateHREmployeeSalaryPayment_RPTDataAccess();

        public abstract IHREmployeeLeaveStatus_RPTDataAccess CreateHREmployeeLeaveStatus_RPTDataAccess();

        public abstract IHREmployeeResume_RPTDataAccess CreateHREmployeeResume_RPTDataAccess();

        public abstract IHREmployeeSalaryDisbursementBank_RPTDataAccess CreateHREmployeeSalaryDisbursementBank_RPTDataAccess();

        public abstract IHREmployeeLeaveApplications_RPTDataAccess CreateHREmployeeLeaveApplications_RPTDataAccess();

        public abstract IBDProjectFloorUnit_RPTDataAccess CreateBDProjectFloorUnit_RPTDataAccess();

        #endregion

        #endregion
    }
}
