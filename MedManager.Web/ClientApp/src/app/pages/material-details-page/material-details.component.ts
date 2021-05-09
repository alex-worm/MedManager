import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {MaterialsDataService} from '../../services/materials.service';
import {Material} from '../../models/material.interface';

@Component({
  selector: 'kks-material-details',
  templateUrl: './material-details.component.html',
  styleUrls: ['./material-details.component.scss']
})
export class MaterialDetailsComponent implements OnInit {
  material: Material;

  constructor(
    private route: ActivatedRoute,
    private materialsService: MaterialsDataService
  ) {
  }

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.materialsService
      .getMaterialById(id)
      .subscribe((material) => (this.material = material));
  }

  update() {
    this.materialsService.updateMaterial(this.material).subscribe();
  }
}
