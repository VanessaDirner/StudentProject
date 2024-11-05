using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using StudentWindowsFormsApp.studentprojectEntitiesDataModel;
using StudentWindowsFormsApp.Common;
using StudentWindowsFormsApp;

namespace StudentWindowsFormsApp.ViewModels {

    /// <summary>
    /// Represents the employees collection view model.
    /// </summary>
    public partial class employeeCollectionViewModel : CollectionViewModel<employee, Guid, IstudentprojectEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of employeeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static employeeCollectionViewModel Create(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new employeeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the employeeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the employeeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected employeeCollectionViewModel(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.employees) {
        }
    }
}