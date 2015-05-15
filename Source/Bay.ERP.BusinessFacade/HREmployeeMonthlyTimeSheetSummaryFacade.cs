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
    public sealed partial class HREmployeeMonthlyTimeSheetSummaryFacade : IHREmployeeMonthlyTimeSheetSummaryFacade
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

        public HREmployeeMonthlyTimeSheetSummaryFacade()
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

        ~HREmployeeMonthlyTimeSheetSummaryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetSummaryFacade.Add(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Add(hREmployeeMonthlyTimeSheetSummaryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetSummaryFacade.Update(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Update(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetSummaryFacade.Delete(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Delete(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryFacade.Add(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Add(hREmployeeMonthlyTimeSheetSummaryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryFacade.Update(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Update(hREmployeeMonthlyTimeSheetSummaryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryFacade.Delete(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().Delete(hREmployeeMonthlyTimeSheetSummaryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeMonthlyTimeSheetSummaryEntity> IHREmployeeMonthlyTimeSheetSummaryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeMonthlyTimeSheetSummaryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeMonthlyTimeSheetSummaryEntity IHREmployeeMonthlyTimeSheetSummaryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetSummaryEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetSummaryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
