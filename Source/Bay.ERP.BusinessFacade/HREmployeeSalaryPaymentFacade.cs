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
    public sealed partial class HREmployeeSalaryPaymentFacade : IHREmployeeSalaryPaymentFacade
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

        public HREmployeeSalaryPaymentFacade()
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

        ~HREmployeeSalaryPaymentFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeSalaryPaymentFacade.Add(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Add(hREmployeeSalaryPaymentEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryPaymentFacade.Update(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Update(hREmployeeSalaryPaymentEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeSalaryPaymentFacade.Delete(HREmployeeSalaryPaymentEntity hREmployeeSalaryPaymentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Delete(hREmployeeSalaryPaymentEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeSalaryPaymentFacade.Add(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Add(hREmployeeSalaryPaymentEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryPaymentFacade.Update(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Update(hREmployeeSalaryPaymentEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeSalaryPaymentFacade.Delete(IList<HREmployeeSalaryPaymentEntity> hREmployeeSalaryPaymentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().Delete(hREmployeeSalaryPaymentEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeSalaryPaymentEntity> IHREmployeeSalaryPaymentFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeSalaryPaymentFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeSalaryPaymentEntity IHREmployeeSalaryPaymentFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryPaymentEntity.FLD_NAME_EmployeeSalaryPaymentID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeSalaryPaymentDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
