// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    public sealed partial class HREmployeePhoneBillAdjustmentFacade : IHREmployeePhoneBillAdjustmentFacade
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

        public HREmployeePhoneBillAdjustmentFacade()
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

        ~HREmployeePhoneBillAdjustmentFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeePhoneBillAdjustmentFacade.Add(HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Add(hREmployeePhoneBillAdjustmentEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeePhoneBillAdjustmentFacade.Update(HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Update(hREmployeePhoneBillAdjustmentEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeePhoneBillAdjustmentFacade.Delete(HREmployeePhoneBillAdjustmentEntity hREmployeePhoneBillAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Delete(hREmployeePhoneBillAdjustmentEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeePhoneBillAdjustmentFacade.Add(IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Add(hREmployeePhoneBillAdjustmentEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeePhoneBillAdjustmentFacade.Update(IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Update(hREmployeePhoneBillAdjustmentEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeePhoneBillAdjustmentFacade.Delete(IList<HREmployeePhoneBillAdjustmentEntity> hREmployeePhoneBillAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().Delete(hREmployeePhoneBillAdjustmentEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeePhoneBillAdjustmentEntity> IHREmployeePhoneBillAdjustmentFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeePhoneBillAdjustmentFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeePhoneBillAdjustmentEntity IHREmployeePhoneBillAdjustmentFacade.GetByID(Int64 iD)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePhoneBillAdjustmentEntity.FLD_NAME_PhoneBillAdjustmentID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeePhoneBillAdjustmentDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
