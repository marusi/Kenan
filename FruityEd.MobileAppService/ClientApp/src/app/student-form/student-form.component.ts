// import * as _ from 'underscore'; 
import { Component, OnInit } from '@angular/core';
import { StudentService } from './../services/student.service';
import { Observable, forkJoin } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Router, ActivatedRoute } from '@angular/router';
// import 'rxjs/add/Observable/forkJoin';
import { SaveStudent, Student } from '../models/student';





@Component({
  selector: 'app-student-form',
  templateUrl: './student-form.component.html',
  styleUrls: ['./student-form.component.css']
})

export class StudentFormComponent implements OnInit {

  //
  private curriculums: any[];
  private curriculumClasses: any[];
  private locations: any[];
  private guardians: any[];
  //private student: any = {};

  private student: SaveStudent = {
    id: 0,
   curriculumId: 0,
   curriculumClassId: 0,
    isActive: false,
   locations: [],
    guardians: [],
    pupil: {
      firstName: '',
      lastName: '',
      favoriteColor: '',
      dateOfBirth:'',
      admissionNo: '',
    }
  };


  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private studentService: StudentService,
    private toastrService: ToastrService) {

    route.params.subscribe(p => {
     // this.student.id = +p['id'] || 0;
    });

  }

  ngOnInit(): void {

    let sources = [
      this.studentService.getCurriculums(),
      this.studentService.getLocations(),
      this.studentService.getGuardians()
    ];

    if (this.student.id)
      sources.push(this.studentService.getStudent(this.student.id));

    forkJoin (sources).subscribe(data => {
      this.curriculums = data[0];
      this.locations = data[1];
      this.guardians = data[2];

      if (this.student.id) {
        this.setStudent(data[3]);
      }

      }, err => {

     //   if (err.status == 404)
      //    this.router.navigate(['/not-found-error']);
  
      });

  }

  private setStudent(s: Student) {
    this.student.id = s.id;
    this.student.curriculumId = s.curriculum.id;
    this.student.curriculumClassId = s.curriculumClass.id;
    this.student.isActive = s.isActive;
    this.student.pupil = s.pupil;
    //*this.student.guardians = s.guardians;

  }

  onCurriculumChange() {

    let selectedCurriculum = this.curriculums.find(c => c.id == this.student.curriculumId);

    this.curriculumClasses = selectedCurriculum.curriculumClasses;

  }


  onLocationToggle(locationId, $event) {
    if ($event.target.checked)
      this.student.locations.push(locationId);
    else {
      var index = this.student.locations.indexOf(locationId);
      this.student.locations.splice(index, 1);
    }

  }


  onGuardianToggle(guardianId, $event) {
    if ($event.target.checked)
      this.student.guardians.push(guardianId);
    else {
      var index = this.student.guardians.indexOf(guardianId);
      this.student.guardians.splice(index, 1);
    }

  }

  submitStudent() {
    this.studentService.create(this.student)
      .subscribe(x => {
        this.toastrService.success('Thank you', 'Student Created Successfuly');

      });
  }

}
