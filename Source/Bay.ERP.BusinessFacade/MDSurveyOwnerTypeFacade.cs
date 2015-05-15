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
    public sealed partial class MDSurveyOwnerTypeFacade : IMDSurveyOwnerTypeFacade
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

        public MDSurveyOwnerTypeFacade()
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

        ~MDSurveyOwnerTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDSurveyOwnerTypeFacade.Add(MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Add(mDSurveyOwnerTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSurveyOwnerTypeFacade.Update(MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Update(mDSurveyOwnerTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSurveyOwnerTypeFacade.Delete(MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Delete(mDSurveyOwnerTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDSurveyOwnerTypeFacade.Add(IList<MDSurveyOwnerTypeEntity> mDSurveyOwnerTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Add(mDSurveyOwnerTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSurveyOwnerTypeFacade.Update(IList<MDSurveyOwnerTypeEntity> mDSurveyOwnerTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Update(mDSurveyOwnerTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSurveyOwnerTypeFacade.Delete(IList<MDSurveyOwnerTypeEntity> mDSurveyOwnerTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().Delete(mDSurveyOwnerTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDSurveyOwnerTypeEntity> IMDSurveyOwnerTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDSurveyOwnerTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDSurveyOwnerTypeEntity IMDSurveyOwnerTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyOwnerTypeEntity.FLD_NAME_SurveyOwnerTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDSurveyOwnerTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
