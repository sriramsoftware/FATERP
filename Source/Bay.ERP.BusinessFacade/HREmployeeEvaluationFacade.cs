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
    public sealed partial class HREmployeeEvaluationFacade : IHREmployeeEvaluationFacade
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

        public HREmployeeEvaluationFacade()
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

        ~HREmployeeEvaluationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeEvaluationFacade.Add(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Add(hREmployeeEvaluationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationFacade.Update(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Update(hREmployeeEvaluationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationFacade.Delete(HREmployeeEvaluationEntity hREmployeeEvaluationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Delete(hREmployeeEvaluationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationFacade.Add(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Add(hREmployeeEvaluationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationFacade.Update(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Update(hREmployeeEvaluationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationFacade.Delete(IList<HREmployeeEvaluationEntity> hREmployeeEvaluationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().Delete(hREmployeeEvaluationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeEvaluationEntity> IHREmployeeEvaluationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeEvaluationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeEvaluationEntity IHREmployeeEvaluationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationEntity.FLD_NAME_EmployeeEvaluationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeEvaluationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
