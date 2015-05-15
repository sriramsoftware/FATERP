// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Sep-2013, 01:42:20




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
    public sealed partial class HREmployeeEvaluationResultFacade : IHREmployeeEvaluationResultFacade
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

        public HREmployeeEvaluationResultFacade()
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

        ~HREmployeeEvaluationResultFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeEvaluationResultFacade.Add(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Add(hREmployeeEvaluationResultEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationResultFacade.Update(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Update(hREmployeeEvaluationResultEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationResultFacade.Delete(HREmployeeEvaluationResultEntity hREmployeeEvaluationResultEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Delete(hREmployeeEvaluationResultEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationResultFacade.Add(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Add(hREmployeeEvaluationResultEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationResultFacade.Update(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Update(hREmployeeEvaluationResultEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationResultFacade.Delete(IList<HREmployeeEvaluationResultEntity> hREmployeeEvaluationResultEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().Delete(hREmployeeEvaluationResultEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeEvaluationResultEntity> IHREmployeeEvaluationResultFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeEvaluationResultFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeEvaluationResultEntity IHREmployeeEvaluationResultFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationResultEntity.FLD_NAME_EmployeeEvaluationResultID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeEvaluationResultDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
