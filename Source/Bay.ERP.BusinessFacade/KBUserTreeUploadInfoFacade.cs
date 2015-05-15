// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public sealed partial class KBUserTreeUploadInfoFacade : IKBUserTreeUploadInfoFacade
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

        public KBUserTreeUploadInfoFacade()
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

        ~KBUserTreeUploadInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IKBUserTreeUploadInfoFacade.Add(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Add(kBUserTreeUploadInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IKBUserTreeUploadInfoFacade.Update(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Update(kBUserTreeUploadInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IKBUserTreeUploadInfoFacade.Delete(KBUserTreeUploadInfoEntity kBUserTreeUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Delete(kBUserTreeUploadInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IKBUserTreeUploadInfoFacade.Add(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Add(kBUserTreeUploadInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBUserTreeUploadInfoFacade.Update(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Update(kBUserTreeUploadInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBUserTreeUploadInfoFacade.Delete(IList<KBUserTreeUploadInfoEntity> kBUserTreeUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().Delete(kBUserTreeUploadInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<KBUserTreeUploadInfoEntity> IKBUserTreeUploadInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IKBUserTreeUploadInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        KBUserTreeUploadInfoEntity IKBUserTreeUploadInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeUploadInfoEntity.FLD_NAME_UserTreeUploadInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateKBUserTreeUploadInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
