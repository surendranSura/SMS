import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
import { ActivatedRoute } from '@angular/router';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { StudentrestApiService } from '../studentrest-api.service';

@Component({
  selector: 'app-student-feedback',
  templateUrl: './student-feedback.component.html',
  styleUrls: ['./student-feedback.component.css']
})
export class StudentFeedbackComponent implements OnInit {
  newstudentFeedback:FormGroup;
  feedbackTypes = SmsConstant.feedbackTypes;
  isAddMode?: boolean;
  loading = false;
  submitted = false;
  id?: any;

   @BlockUI() blockUI: NgBlockUI;
  // studentFeedbackTitle = SmsConstant.feedbackTitles;
  constructor(private fb:FormBuilder,  private studentrestApiService :StudentrestApiService, private route: ActivatedRoute) 
  {
    this.newstudentFeedback=this.fb.group({
      admittonNumber: ['', Validators.required],
      staffName: ['', Validators.required],
      feedbackType: ['', Validators.required],
      date: ['', Validators.required],
      class: ['', Validators.required],
      feedbacktitle: ['', Validators.required],
      section:['', Validators.required],
      teacherId: ['', Validators.required],
      description:['', Validators.required],
      attachment: ['', Validators.required]
    });

   }

   ngAfterViewInit(): void {

    if(!this.isAddMode)
    {
      this.studentrestApiService.getStudentFeedBack(this.id)
        .subscribe(data => {
          this.studentrestApiService.setFormValue(data);
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
      this.createStudenteLetter();
     } else {
      this.updateStudenteLetter();
     }

     this.blockUI.stop();
    
  }

  createStudenteLetter()
  {
    this.studentrestApiService.createStudentFeedBack(this.newstudentFeedback.value).subscribe(_=>{
    });
  }

  updateStudenteLetter()
  {
    this.studentrestApiService.updateStudentFeedBack(this.id, this.newstudentFeedback.value).subscribe(_=>{

    });
  }


}
