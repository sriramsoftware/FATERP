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
    public sealed partial class KBUserTreeSharedFacade : IKBUserTreeSharedFacade
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

        public KBUserTreeSharedFacade()
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

        ~KBUserTreeSharedFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IKBUserTreeSharedFacade.Add(KBUserTreeSharedEntity kBUserTreeSharedEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Add(kBUserTreeSharedEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IKBUserTreeSharedFacade.Update(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Update(kBUserTreeSharedEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IKBUserTreeSharedFacade.Delete(KBUserTreeSharedEntity kBUserTreeSharedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Delete(kBUserTreeSharedEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IKBUserTreeSharedFacade.Add(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Add(kBUserTreeSharedEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBUserTreeSharedFacade.Update(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Update(kBUserTreeSharedEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBUserTreeSharedFacade.Delete(IList<KBUserTreeSharedEntity> kBUserTreeSharedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().Delete(kBUserTreeSharedEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<KBUserTreeSharedEntity> IKBUserTreeSharedFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IKBUserTreeSharedFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBUserTreeSharedDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        KBUserTreeSharedEntity IKBUserTreeSharedFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeSharedEntity.FLD_NAME_UserTreeSharedID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateKBUserTreeSharedDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
