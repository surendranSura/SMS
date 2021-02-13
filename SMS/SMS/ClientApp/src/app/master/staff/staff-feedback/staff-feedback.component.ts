import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-staff-feedback',
  templateUrl: './staff-feedback.component.html',
  styleUrls: ['./staff-feedback.component.css']
})
export class StaffFeedbackComponent implements OnInit {
  newstaffFeedback: FormGroup;
  feedbackTypes = SmsConstant.feedbackTypes;
  staffFeedbackTitle = SmsConstant.feedbackTitles;
  constructor(private fb: FormBuilder) {
    this.newstaffFeedback = this.fb.group({
      empid: [''],
      staffName: ['staffhere'],
      feedbackType: [''],
      date: [''],
      department: ['Maths'],
      feedbacktitle: [''],
      teacherId: ['701'],
      description:[''],
      attachment: ['']
    });
  }

  ngOnInit(): void {
  }

}
