import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeesPageComponent } from './pages/employees-page/employees-page.component';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from 'src/material.module';
import { EmployeeDetailsPageComponent } from './pages/employee-details-page/employee-details-page.component';
import { FormsModule } from '@angular/forms';
import { EmployeesDataService } from './services/employees.service';
import { HttpClientModule } from '@angular/common/http';
import { MedicamentsPageComponent } from './pages/medicaments-page/medicaments-page.component';
import { MedicamentDetailsPageComponent } from './pages/medicament-details-page/medicament-details-page.component';
import { InspectionDetailsPageComponent } from './pages/inspection-details-page/inspection-details-page.component';
import { InspectionsPageComponent } from './pages/inspections-page/inspections-page.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesPageComponent,
    NavbarComponent,
    EmployeeDetailsPageComponent,
    MedicamentsPageComponent,
    MedicamentDetailsPageComponent,
    InspectionDetailsPageComponent,
    InspectionsPageComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule,
  ],
  providers: [EmployeesDataService],
  bootstrap: [AppComponent],
})
export class AppModule {}
