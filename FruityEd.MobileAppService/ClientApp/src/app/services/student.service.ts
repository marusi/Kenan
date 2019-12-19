import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private readonly studentEndpoint = '/api/students';


  constructor(private http: HttpClient) { }


  getGuardians() {
    return this.http.get<any>('/api/guardians');
  }

  getLocations() {
    return this.http.get<any>('/api/locations');
  }

  getCurriculums() {
    return this.http.get<any>('/api/curriculums');
  }

  getStudent(id) {
    return this.http.get<any>(this.studentEndpoint + '/' + id);
  }

 

  create(student) {
    return this.http.post(this.studentEndpoint, student)

  }
}
