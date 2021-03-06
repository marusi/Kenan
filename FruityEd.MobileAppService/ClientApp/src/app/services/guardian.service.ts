import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class GuardianService {

  private readonly guardianEndpoint = '/api/guardians';


  constructor(private http: HttpClient) { }


  getGuardian(id) {
    return this.http.get<any>(this.guardianEndpoint + '/' + id);
  }

  create(guardian) {
    return this.http.post(this.guardianEndpoint, guardian)

  }
}
