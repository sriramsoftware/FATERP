// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 06:33:35




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
    public sealed partial class HREmployeeLeaveApplicationFacade : IHREmployeeLeaveApplicationFacade
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

        public HREmployeeLeaveApplicationFacade()
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

        ~HREmployeeLeaveApplicationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeLeaveApplicationFacade.Add(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Add(hREmployeeLeaveApplicationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeLeaveApplicationFacade.Update(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Update(hREmployeeLeaveApplicationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeLeaveApplicationFacade.Delete(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Delete(hREmployeeLeaveApplicationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeLeaveApplicationFacade.Add(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Add(hREmployeeLeaveApplicationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeLeaveApplicationFacade.Update(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Update(hREmployeeLeaveApplicationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeLeaveApplicationFacade.Delete(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().Delete(hREmployeeLeaveApplicationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeLeaveApplicationEntity> IHREmployeeLeaveApplicationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeLeaveApplicationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeLeaveApplicationEntity IHREmployeeLeaveApplicationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeLeaveApplicationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeLeaveApplicationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
