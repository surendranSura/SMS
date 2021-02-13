import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
@Component({
  selector: 'app-student-feedback',
  templateUrl: './student-feedback.component.html',
  styleUrls: ['./student-feedback.component.css']
})
export class StudentFeedbackComponent implements OnInit {
  newstudentFeedback:FormGroup;
  feedbackTypes = SmsConstant.feedbackTypes;
  studentFeedbackTitle = SmsConstant.feedbackTitles;
  constructor(private fb:FormBuilder) 
  {
    this.newstudentFeedback=this.fb.group({
      admittonNumber: [''],
      staffName: ['staffhere'],
      feedbackType: [''],
      date: [''],
      class: ['Maths'],
      feedbacktitle: [''],
      section:[''],
      teacherId: ['701'],
      description:[''],
      attachment: ['']
    });

   }
  
  ngOnInit(): void {
  }

}
