import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeesPageComponent } from './pages/employees-page/employees-page.component';
import { EmployeeDetailsPageComponent } from './pages/employee-details-page/employee-details-page.component';
import { MedicamentsPageComponent } from './pages/medicaments-page/medicaments-page.component';
import { MedicamentDetailsPageComponent } from './pages/medicament-details-page/medicament-details-page.component';
import { InspectionsPageComponent } from './pages/inspections-page/inspections-page.component';
import { InspectionDetailsPageComponent } from './pages/inspection-details-page/inspection-details-page.component';

const routes: Routes = [
  { path: '', redirectTo: 'employees', pathMatch: 'full' },
  { path: 'employees', component: EmployeesPageComponent },
  { path: 'employee-details/:id', component: EmployeeDetailsPageComponent },
  { path: 'medicaments', component: MedicamentsPageComponent },
  { path: 'medicament-details/:id', component: MedicamentDetailsPageComponent },
  { path: 'inspections', component: InspectionsPageComponent },
  { path: 'inspection-details/:id', component: InspectionDetailsPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
