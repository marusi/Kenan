import { Component, OnInit, ViewChild } from '@angular/core';
import { InquiryService } from './../services/inquiry.service';



import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';





@Component({
  selector: 'app-visits-component',
  templateUrl: './visits.component.html',
  styleUrls: ['./visits.component.css']
})
export class VisitsComponent {


  private visit = {
    id: 0,
    name: '',
    phone: '',
    email: '',
    guestNo: '',
    location: '',
    timeExpected: '',
    dateOfEntry: ''
    
  };



  constructor(private inquiryService: InquiryService) {  }

 
  ngOnInit(): void {}





  submitVisit() {
    this.inquiryService.createVisit(this.visit)
      .subscribe(x => console.log(x));
  }








}
