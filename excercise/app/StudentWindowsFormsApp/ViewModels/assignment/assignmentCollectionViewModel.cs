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
    /// Represents the assignments collection view model.
    /// </summary>
    public partial class assignmentCollectionViewModel : CollectionViewModel<assignment, Guid, IstudentprojectEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of assignmentCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static assignmentCollectionViewModel Create(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new assignmentCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the assignmentCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the assignmentCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected assignmentCollectionViewModel(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.assignments) {
        }
    }
}