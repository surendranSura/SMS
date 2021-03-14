import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
import { StaffrestApiService } from '../staffrest-api.service';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';


@Component({
  selector: 'app-staff-feedback',
  templateUrl: './staff-feedback.component.html',
  styleUrls: ['./staff-feedback.component.css']
})
export class StaffFeedbackComponent implements OnInit {
  newstaffFeedback: FormGroup;
  feedbackTypes = SmsConstant.feedbackTypes;
  isAddMode?: boolean;
  loading = false;
  submitted = false;
  id?: any;

   @BlockUI() blockUI: NgBlockUI;

  // staffFeedbackTitle = SmsConstant.feedbackTitles;
  constructor(private fb: FormBuilder, private staffrestApiService :StaffrestApiService, private route: ActivatedRoute) {
    this.newstaffFeedback = this.fb.group({
      empid: ['', Validators.required],
      staffName: ['', Validators.required],
      feedbackType: ['',Validators.required],
      date: ['',Validators.required],
      department: ['',Validators.required],
      feedbacktitle: ['',Validators.required],
      teacherId: ['',Validators.required],
      description:['',Validators.required],
      attachment: ['',Validators.required]
    });
  }

  ngAfterViewInit(): void {

    if(!this.isAddMode)
    {
      this.staffrestApiService.getStaffFeedBack(this.id)
        .subscribe(data => {
          this.staffrestApiService.setFormValue(data);
        }, error => console.log(error));
    }
    
  }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;
  }

  submit() {
    this.blockUI.start();
    this.submitted = true;

    if (this.isAddMode) {
      this.createStaffFeedback();
     } else {
      this.updateSatfffeedback();
     }

     this.blockUI.stop();
    
  }

  createStaffFeedback()
  {
    this.staffrestApiService.createStaffFeedBack(this.newstaffFeedback.value).subscribe(_=>{
    });
  }

  updateSatfffeedback()
  {
    this.staffrestApiService.updateStaffFeedBack(this.id, this.newstaffFeedback.value).subscribe(_=>{

    });
  }

}
