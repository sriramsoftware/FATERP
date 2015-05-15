// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2013, 01:17:51




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
    public sealed partial class HREmployeeEvaluationReportFacade : IHREmployeeEvaluationReportFacade
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

        public HREmployeeEvaluationReportFacade()
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

        ~HREmployeeEvaluationReportFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeEvaluationReportFacade.Add(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Add(hREmployeeEvaluationReportEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationReportFacade.Update(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Update(hREmployeeEvaluationReportEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeEvaluationReportFacade.Delete(HREmployeeEvaluationReportEntity hREmployeeEvaluationReportEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Delete(hREmployeeEvaluationReportEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationReportFacade.Add(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Add(hREmployeeEvaluationReportEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationReportFacade.Update(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Update(hREmployeeEvaluationReportEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeEvaluationReportFacade.Delete(IList<HREmployeeEvaluationReportEntity> hREmployeeEvaluationReportEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().Delete(hREmployeeEvaluationReportEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeEvaluationReportEntity> IHREmployeeEvaluationReportFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeEvaluationReportFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeEvaluationReportEntity IHREmployeeEvaluationReportFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEvaluationReportEntity.FLD_NAME_EmployeeEvaluationReportID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeEvaluationReportDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
