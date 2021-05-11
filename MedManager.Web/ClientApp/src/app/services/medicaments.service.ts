import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Medicament } from '../models/medicaments.interface';
import { RequestBuilder } from './request-builder';

const apiController = 'Medicaments';

@Injectable({
  providedIn: 'root',
})
export class MedicamentsDataService {
  constructor(private readonly builder: RequestBuilder) {}

  public getMedicamentsList(): Observable<Medicament[]> {
    return this.builder.useApiUrl(`v1/${apiController}/`).get<Medicament[]>();
  }

  public getMedicamentById(id: number): Observable<Medicament> {
    return this.builder
      .useApiUrl(`v1/${apiController}/${id}/`)
      .get<Medicament>();
  }

  public updateMedicament(medicament: Medicament) {
    return this.builder.useApiUrl(`v1/${apiController}/`).put(medicament);
  }
}
