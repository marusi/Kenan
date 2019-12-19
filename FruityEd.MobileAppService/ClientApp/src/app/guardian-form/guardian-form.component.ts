import { Component, OnInit } from '@angular/core';
import { GuardianService } from './../services/guardian.service';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-guardian-form',
  templateUrl: './guardian-form.component.html',
  styleUrls: ['./guardian-form.component.css']
})

export class GuardianFormComponent implements OnInit {



 private guardian = {
    id: 0,
   firstName: '',
   otherName: '',
    contact: {
      email: '',
      phone:'',
      address: '',
    }
  };

 


  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private toastrService: ToastrService,
    private guardianService: GuardianService) {
 
    route.params.subscribe(p => {
      this.guardian.id = +p['id'] || 0;
    });
  }

  ngOnInit(): void {

    this.guardianService.getGuardian(this.guardian.id)
      .subscribe(g => {
        this.guardian = g;
      }, err => {
      //  if (err.status == 404)
       //   this.router.navigate(['/not-found-error'])
      });

  }

  submitGuardian() {
    this.guardianService.create(this.guardian)
      .subscribe(x => console.log(x));
  }

}
