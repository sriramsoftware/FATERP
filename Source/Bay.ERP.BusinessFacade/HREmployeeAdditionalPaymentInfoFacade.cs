// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public sealed partial class HREmployeeAdditionalPaymentInfoFacade : IHREmployeeAdditionalPaymentInfoFacade
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

        public HREmployeeAdditionalPaymentInfoFacade()
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

        ~HREmployeeAdditionalPaymentInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeAdditionalPaymentInfoFacade.Add(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Add(hREmployeeAdditionalPaymentInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeAdditionalPaymentInfoFacade.Update(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Update(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeAdditionalPaymentInfoFacade.Delete(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Delete(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeAdditionalPaymentInfoFacade.Add(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Add(hREmployeeAdditionalPaymentInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeAdditionalPaymentInfoFacade.Update(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Update(hREmployeeAdditionalPaymentInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeAdditionalPaymentInfoFacade.Delete(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().Delete(hREmployeeAdditionalPaymentInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeAdditionalPaymentInfoEntity> IHREmployeeAdditionalPaymentInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeAdditionalPaymentInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeAdditionalPaymentInfoEntity IHREmployeeAdditionalPaymentInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAdditionalPaymentInfoEntity.FLD_NAME_EmployeeAdditonalPaymentInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeAdditionalPaymentInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
