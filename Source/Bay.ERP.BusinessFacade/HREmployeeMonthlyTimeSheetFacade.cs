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
    public sealed partial class HREmployeeMonthlyTimeSheetFacade : IHREmployeeMonthlyTimeSheetFacade
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

        public HREmployeeMonthlyTimeSheetFacade()
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

        ~HREmployeeMonthlyTimeSheetFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetFacade.Add(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Add(hREmployeeMonthlyTimeSheetEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetFacade.Update(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Update(hREmployeeMonthlyTimeSheetEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeMonthlyTimeSheetFacade.Delete(HREmployeeMonthlyTimeSheetEntity hREmployeeMonthlyTimeSheetEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Delete(hREmployeeMonthlyTimeSheetEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetFacade.Add(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Add(hREmployeeMonthlyTimeSheetEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetFacade.Update(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Update(hREmployeeMonthlyTimeSheetEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeMonthlyTimeSheetFacade.Delete(IList<HREmployeeMonthlyTimeSheetEntity> hREmployeeMonthlyTimeSheetEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().Delete(hREmployeeMonthlyTimeSheetEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeMonthlyTimeSheetEntity> IHREmployeeMonthlyTimeSheetFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeMonthlyTimeSheetFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeMonthlyTimeSheetEntity IHREmployeeMonthlyTimeSheetFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeMonthlyTimeSheetEntity.FLD_NAME_EmployeeMonthlyTimeSheetID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeMonthlyTimeSheetDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
