// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public sealed partial class HREmployeeVisaInfomationFacade : IHREmployeeVisaInfomationFacade
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

        public HREmployeeVisaInfomationFacade()
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

        ~HREmployeeVisaInfomationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeVisaInfomationFacade.Add(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Add(hREmployeeVisaInfomationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeVisaInfomationFacade.Update(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Update(hREmployeeVisaInfomationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeVisaInfomationFacade.Delete(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Delete(hREmployeeVisaInfomationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeVisaInfomationFacade.Add(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Add(hREmployeeVisaInfomationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeVisaInfomationFacade.Update(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Update(hREmployeeVisaInfomationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeVisaInfomationFacade.Delete(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().Delete(hREmployeeVisaInfomationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeVisaInfomationEntity> IHREmployeeVisaInfomationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeVisaInfomationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeVisaInfomationEntity IHREmployeeVisaInfomationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeVisaInfomationEntity.FLD_NAME_EmployeeVisaInfomationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeVisaInfomationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
