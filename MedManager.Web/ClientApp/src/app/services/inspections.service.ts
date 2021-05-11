import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Inspection } from '../models/inspection.interface';
import { Employee } from '../models/employee.interface';
import { RequestBuilder } from './request-builder';

const inspectionController = 'Inspections';
const employeeController = 'Employees';

@Injectable({
  providedIn: 'root',
})
export class InspectionsDataService {
  constructor(private readonly builder: RequestBuilder) {}

  public getInspectionsList(): Observable<Inspection[]> {
    return this.builder
      .useApiUrl(`v1/${inspectionController}/`)
      .get<Inspection[]>();
  }

  public getInspectionById(
    id: number
  ): [Observable<Inspection>, Observable<Employee>] {
    return [
      this.builder
        .useApiUrl(`v1/${inspectionController}/${id}/`)
        .get<Inspection>(),
      this.builder.useApiUrl(`v1/${employeeController}/${id}/`).get<Employee>(),
    ];
  }

  public updateInspection(inspection: Inspection) {
    return this.builder
      .useApiUrl(`v1/${inspectionController}/`)
      .put(inspection);
  }
}
