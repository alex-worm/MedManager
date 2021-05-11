import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from 'src/app/models/employee.interface';
import { InspectionsDataService } from 'src/app/services/inspections.service';

import { Inspection } from '../../models/inspection.interface';

@Component({
  selector: 'kks-details-page',
  templateUrl: './inspection-details-page.component.html',
  styleUrls: ['./inspection-details-page.component.scss'],
})
export class InspectionDetailsPageComponent implements OnInit {
  inspection: Inspection;
  employee: Employee;

  constructor(
    private route: ActivatedRoute,
    private inspectionsService: InspectionsDataService
  ) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.inspectionsService
      .getInspectionById(id)[0]
      .subscribe((inspection) => (this.inspection = inspection));
    this.inspectionsService
      .getInspectionById(id)[1]
      .subscribe((employee) => (this.employee = employee));
  }

  update() {
    this.inspectionsService.updateInspection(this.inspection).subscribe();
  }
}
