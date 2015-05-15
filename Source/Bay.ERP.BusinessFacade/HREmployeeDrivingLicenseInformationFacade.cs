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
    public sealed partial class HREmployeeDrivingLicenseInformationFacade : IHREmployeeDrivingLicenseInformationFacade
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

        public HREmployeeDrivingLicenseInformationFacade()
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

        ~HREmployeeDrivingLicenseInformationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHREmployeeDrivingLicenseInformationFacade.Add(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Add(hREmployeeDrivingLicenseInformationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeDrivingLicenseInformationFacade.Update(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Update(hREmployeeDrivingLicenseInformationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHREmployeeDrivingLicenseInformationFacade.Delete(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Delete(hREmployeeDrivingLicenseInformationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHREmployeeDrivingLicenseInformationFacade.Add(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Add(hREmployeeDrivingLicenseInformationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeDrivingLicenseInformationFacade.Update(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Update(hREmployeeDrivingLicenseInformationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHREmployeeDrivingLicenseInformationFacade.Delete(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().Delete(hREmployeeDrivingLicenseInformationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HREmployeeDrivingLicenseInformationEntity> IHREmployeeDrivingLicenseInformationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHREmployeeDrivingLicenseInformationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HREmployeeDrivingLicenseInformationEntity IHREmployeeDrivingLicenseInformationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDrivingLicenseInformationEntity.FLD_NAME_EmployeeDrivingLicenseInformationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHREmployeeDrivingLicenseInformationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
