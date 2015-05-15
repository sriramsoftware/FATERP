// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public sealed partial class OTIssueUploadInfoFacade : IOTIssueUploadInfoFacade
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

        public OTIssueUploadInfoFacade()
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

        ~OTIssueUploadInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IOTIssueUploadInfoFacade.Add(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Add(oTIssueUploadInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IOTIssueUploadInfoFacade.Update(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Update(oTIssueUploadInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IOTIssueUploadInfoFacade.Delete(OTIssueUploadInfoEntity oTIssueUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Delete(oTIssueUploadInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IOTIssueUploadInfoFacade.Add(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Add(oTIssueUploadInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTIssueUploadInfoFacade.Update(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Update(oTIssueUploadInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IOTIssueUploadInfoFacade.Delete(IList<OTIssueUploadInfoEntity> oTIssueUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().Delete(oTIssueUploadInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<OTIssueUploadInfoEntity> IOTIssueUploadInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IOTIssueUploadInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        OTIssueUploadInfoEntity IOTIssueUploadInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueUploadInfoEntity.FLD_NAME_IssueUploadInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateOTIssueUploadInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
