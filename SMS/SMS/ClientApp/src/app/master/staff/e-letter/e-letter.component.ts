import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
import { StaffrestApiService } from '../staffrest-api.service';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';

@Component({
  selector: 'app-e-letter',
  templateUrl: './e-letter.component.html',
  styleUrls: ['./e-letter.component.css']
})
export class ELetterComponent implements OnInit {
  eletterfrm : FormGroup;
  letterTypes = SmsConstant.letterType;
  month = SmsConstant.months;
  years = SmsConstant.year;
  isAddMode?: boolean;
  loading = false;
  submitted = false;
  id?: any;

   @BlockUI() blockUI: NgBlockUI;

  constructor( private fb:FormBuilder, private staffrestApiService :StaffrestApiService, private route: ActivatedRoute) {
      this.eletterfrm = this.fb.group({
        empid: ['', Validators.required],
        staffName:['', Validators.required],
        letterType:['',Validators.required],
        department:['', Validators.required],
        month:['', Validators.required],
        teacherId:['',Validators.required],
        year:['', Validators.required]
      });

   }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;
  }

  submit() {
    this.blockUI.start();
    this.submitted = true;

    if (this.isAddMode) {
      this.createStaffeLetter();
     } else {
      this.updateSatffeLetter();
     }

     this.blockUI.stop();
    
  }

  createStaffeLetter()
  {
    this.staffrestApiService.createStaffeLetter(this.eletterfrm.value).subscribe(_=>{
    });
  }

  updateSatffeLetter()
  {
    this.staffrestApiService.updateStaffeLetter(this.id, this.eletterfrm.value).subscribe(_=>{

    });
  }

}
