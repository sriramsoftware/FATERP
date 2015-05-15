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
    public sealed partial class KBMDUserTreeSettingFacade : IKBMDUserTreeSettingFacade
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

        public KBMDUserTreeSettingFacade()
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

        ~KBMDUserTreeSettingFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IKBMDUserTreeSettingFacade.Add(KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Add(kBMDUserTreeSettingEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeSettingFacade.Update(KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Update(kBMDUserTreeSettingEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeSettingFacade.Delete(KBMDUserTreeSettingEntity kBMDUserTreeSettingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Delete(kBMDUserTreeSettingEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IKBMDUserTreeSettingFacade.Add(IList<KBMDUserTreeSettingEntity> kBMDUserTreeSettingEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Add(kBMDUserTreeSettingEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeSettingFacade.Update(IList<KBMDUserTreeSettingEntity> kBMDUserTreeSettingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Update(kBMDUserTreeSettingEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeSettingFacade.Delete(IList<KBMDUserTreeSettingEntity> kBMDUserTreeSettingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().Delete(kBMDUserTreeSettingEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<KBMDUserTreeSettingEntity> IKBMDUserTreeSettingFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IKBMDUserTreeSettingFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        KBMDUserTreeSettingEntity IKBMDUserTreeSettingFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSettingEntity.FLD_NAME_UserTreeSettingID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateKBMDUserTreeSettingDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
