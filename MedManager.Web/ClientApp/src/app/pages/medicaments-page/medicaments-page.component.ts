import { Component, OnInit } from '@angular/core';
import { Medicament } from 'src/app/models/medicaments.interface';
import { MedicamentsDataService } from 'src/app/services/medicaments.service';

@Component({
  selector: 'kks-medications-page',
  templateUrl: './medicaments-page.component.html',
  styleUrls: ['./medicaments-page.component.scss'],
})
export class MedicamentsPageComponent implements OnInit {
  medicaments: Medicament[];

  constructor(private medicamentsService: MedicamentsDataService) {}

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees(): void {
    this.medicamentsService
      .getMedicamentsList()
      .subscribe((medicaments) => (this.medicaments = medicaments));
  }
}
