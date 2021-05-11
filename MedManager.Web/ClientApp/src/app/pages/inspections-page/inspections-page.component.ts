import { Component, OnInit } from '@angular/core';
import { Inspection } from 'src/app/models/inspection.interface';
import { InspectionsDataService } from 'src/app/services/inspections.service';

@Component({
  selector: 'kks-inspections-page',
  templateUrl: './inspections-page.component.html',
  styleUrls: ['./inspections-page.component.scss'],
})
export class InspectionsPageComponent implements OnInit {
  inspections: Inspection[];

  constructor(private inspectionsService: InspectionsDataService) {}

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees(): void {
    this.inspectionsService
      .getInspectionsList()
      .subscribe((inspections) => (this.inspections = inspections));
  }
}
