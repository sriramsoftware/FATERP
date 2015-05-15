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
    public sealed partial class HRSalaryAdjustmentFacade : IHRSalaryAdjustmentFacade
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

        public HRSalaryAdjustmentFacade()
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

        ~HRSalaryAdjustmentFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHRSalaryAdjustmentFacade.Add(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Add(hRSalaryAdjustmentEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHRSalaryAdjustmentFacade.Update(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Update(hRSalaryAdjustmentEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHRSalaryAdjustmentFacade.Delete(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Delete(hRSalaryAdjustmentEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHRSalaryAdjustmentFacade.Add(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Add(hRSalaryAdjustmentEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRSalaryAdjustmentFacade.Update(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Update(hRSalaryAdjustmentEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRSalaryAdjustmentFacade.Delete(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().Delete(hRSalaryAdjustmentEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HRSalaryAdjustmentEntity> IHRSalaryAdjustmentFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHRSalaryAdjustmentFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HRSalaryAdjustmentEntity IHRSalaryAdjustmentFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRSalaryAdjustmentEntity.FLD_NAME_SalaryAdjustmentID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHRSalaryAdjustmentDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
