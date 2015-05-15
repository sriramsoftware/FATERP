// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDHRNoticeTemplateTypeFacade : IMDHRNoticeTemplateTypeFacade
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

        public MDHRNoticeTemplateTypeFacade()
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

        ~MDHRNoticeTemplateTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDHRNoticeTemplateTypeFacade.Add(MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Add(mDHRNoticeTemplateTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDHRNoticeTemplateTypeFacade.Update(MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Update(mDHRNoticeTemplateTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDHRNoticeTemplateTypeFacade.Delete(MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Delete(mDHRNoticeTemplateTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDHRNoticeTemplateTypeFacade.Add(IList<MDHRNoticeTemplateTypeEntity> mDHRNoticeTemplateTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Add(mDHRNoticeTemplateTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDHRNoticeTemplateTypeFacade.Update(IList<MDHRNoticeTemplateTypeEntity> mDHRNoticeTemplateTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Update(mDHRNoticeTemplateTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDHRNoticeTemplateTypeFacade.Delete(IList<MDHRNoticeTemplateTypeEntity> mDHRNoticeTemplateTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().Delete(mDHRNoticeTemplateTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDHRNoticeTemplateTypeEntity> IMDHRNoticeTemplateTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDHRNoticeTemplateTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDHRNoticeTemplateTypeEntity IMDHRNoticeTemplateTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDHRNoticeTemplateTypeEntity.FLD_NAME_NoticeTemplateTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDHRNoticeTemplateTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
