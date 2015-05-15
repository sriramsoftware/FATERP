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
    public sealed partial class HRAdditonalInformationFacade : IHRAdditonalInformationFacade
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

        public HRAdditonalInformationFacade()
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

        ~HRAdditonalInformationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHRAdditonalInformationFacade.Add(HRAdditonalInformationEntity hRAdditonalInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Add(hRAdditonalInformationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHRAdditonalInformationFacade.Update(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Update(hRAdditonalInformationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHRAdditonalInformationFacade.Delete(HRAdditonalInformationEntity hRAdditonalInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Delete(hRAdditonalInformationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHRAdditonalInformationFacade.Add(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Add(hRAdditonalInformationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRAdditonalInformationFacade.Update(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Update(hRAdditonalInformationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRAdditonalInformationFacade.Delete(IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().Delete(hRAdditonalInformationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HRAdditonalInformationEntity> IHRAdditonalInformationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHRAdditonalInformationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRAdditonalInformationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HRAdditonalInformationEntity IHRAdditonalInformationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHRAdditonalInformationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
