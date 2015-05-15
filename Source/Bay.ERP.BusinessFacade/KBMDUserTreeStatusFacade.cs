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
    public sealed partial class KBMDUserTreeStatusFacade : IKBMDUserTreeStatusFacade
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

        public KBMDUserTreeStatusFacade()
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

        ~KBMDUserTreeStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IKBMDUserTreeStatusFacade.Add(KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Add(kBMDUserTreeStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeStatusFacade.Update(KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Update(kBMDUserTreeStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeStatusFacade.Delete(KBMDUserTreeStatusEntity kBMDUserTreeStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Delete(kBMDUserTreeStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IKBMDUserTreeStatusFacade.Add(IList<KBMDUserTreeStatusEntity> kBMDUserTreeStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Add(kBMDUserTreeStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeStatusFacade.Update(IList<KBMDUserTreeStatusEntity> kBMDUserTreeStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Update(kBMDUserTreeStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeStatusFacade.Delete(IList<KBMDUserTreeStatusEntity> kBMDUserTreeStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().Delete(kBMDUserTreeStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<KBMDUserTreeStatusEntity> IKBMDUserTreeStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IKBMDUserTreeStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        KBMDUserTreeStatusEntity IKBMDUserTreeStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeStatusEntity.FLD_NAME_UserTreeStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateKBMDUserTreeStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
