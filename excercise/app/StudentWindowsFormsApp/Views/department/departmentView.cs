using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace StudentWindowsFormsApp.Views.departmentView{
    public partial class departmentView : XtraUserControl {
        public departmentView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<StudentWindowsFormsApp.ViewModels.departmentViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                departmentViewBindingSource, x => x.Entity, x => x.Update());
						#region assignments Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowHandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(assignmentsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.departmentassignmentsDetails.SelectedEntity,
                    args => args.Row as StudentWindowsFormsApp.assignment,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(assignmentsGridView, "RowClick")
						.EventToCommand(
						    x => x.departmentassignmentsDetails.Edit(null), x => x.departmentassignmentsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			assignmentsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    assignmentsPopUpMenu.ShowPopup(assignmentsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the departmentassignmentsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(assignmentsGridControl, g => g.DataSource, x => x.departmentassignmentsDetails.Entities);
				
														fluentAPI.BindCommand(bbiassignmentsNew, x => x.departmentassignmentsDetails.New());
																													fluentAPI.BindCommand(bbiassignmentsEdit,x => x.departmentassignmentsDetails.Edit(null), x=>x.departmentassignmentsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiassignmentsDelete,x => x.departmentassignmentsDetails.Delete(null), x=>x.departmentassignmentsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiassignmentsRefresh, x => x.departmentassignmentsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
