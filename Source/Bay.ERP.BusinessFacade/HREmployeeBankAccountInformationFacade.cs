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
    public sealed partial class HREmployeeBankAccountInformationFacade : IHREmployeeBankAccountInformationFacade
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

        public HREmployeeBankAccountInformationFacade()
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

        ~HREmployeeBankAccountInformationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeBankAccountInformationFacade.Add(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Add(hREmployeeBankAccountInformationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeBankAccountInformationFacade.Update(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Update(hREmployeeBankAccountInformationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeBankAccountInformationFacade.Delete(HREmployeeBankAccountInformationEntity hREmployeeBankAccountInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Delete(hREmployeeBankAccountInformationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeBankAccountInformationFacade.Add(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Add(hREmployeeBankAccountInformationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeBankAccountInformationFacade.Update(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Update(hREmployeeBankAccountInformationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeBankAccountInformationFacade.Delete(IList<HREmployeeBankAccountInformationEntity> hREmployeeBankAccountInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().Delete(hREmployeeBankAccountInformationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeBankAccountInformationEntity> IHREmployeeBankAccountInformationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeBankAccountInformationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeBankAccountInformationEntity IHREmployeeBankAccountInformationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeBankAccountInformationEntity.FLD_NAME_EmployeeBankAccountInformationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeBankAccountInformationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
