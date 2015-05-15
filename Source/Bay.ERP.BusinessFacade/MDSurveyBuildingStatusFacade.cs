// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDSurveyBuildingStatusFacade : IMDSurveyBuildingStatusFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public MDSurveyBuildingStatusFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~MDSurveyBuildingStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDSurveyBuildingStatusFacade.Add(MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Add(mDSurveyBuildingStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSurveyBuildingStatusFacade.Update(MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Update(mDSurveyBuildingStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSurveyBuildingStatusFacade.Delete(MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Delete(mDSurveyBuildingStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDSurveyBuildingStatusFacade.Add(IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Add(mDSurveyBuildingStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSurveyBuildingStatusFacade.Update(IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Update(mDSurveyBuildingStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSurveyBuildingStatusFacade.Delete(IList<MDSurveyBuildingStatusEntity> mDSurveyBuildingStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().Delete(mDSurveyBuildingStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDSurveyBuildingStatusEntity> IMDSurveyBuildingStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDSurveyBuildingStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDSurveyBuildingStatusEntity IMDSurveyBuildingStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyBuildingStatusEntity.FLD_NAME_SurveyBuildingStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDSurveyBuildingStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
