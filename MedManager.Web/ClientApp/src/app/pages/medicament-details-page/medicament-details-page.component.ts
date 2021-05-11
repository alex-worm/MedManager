import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Medicament } from 'src/app/models/medicaments.interface';
import { MedicamentsDataService } from 'src/app/services/medicaments.service';

@Component({
  selector: 'kks-medication-details-page',
  templateUrl: './medicament-details-page.component.html',
  styleUrls: ['./medicamant-details-page.component.scss'],
})
export class MedicamentDetailsPageComponent implements OnInit {
  medicament: Medicament;

  constructor(
    private route: ActivatedRoute,
    private medicamentsService: MedicamentsDataService
  ) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.medicamentsService
      .getMedicamentById(id)
      .subscribe((medicament) => (this.medicament = medicament));
  }

  update() {
    this.medicamentsService.updateMedicament(this.medicament).subscribe();
  }
}
