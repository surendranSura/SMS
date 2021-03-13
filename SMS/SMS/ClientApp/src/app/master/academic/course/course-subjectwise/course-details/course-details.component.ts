import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-course-details',
  templateUrl: './course-details.component.html',
  styleUrls: ['./course-details.component.css']
})
export class CourseDetailsComponent implements OnInit {
  courseDetailsForm : FormGroup;

  complitionCriteria =SmsConstant.complitionCriteria;

  constructor(private fb:FormBuilder) {

    this.courseDetailsForm= this.fb.group(
      {
        courseName : [''],
        courseCode : [''],
        courseDescription : [''],
        complitionCriteria : [''],
        PassingScore : [''],
        topic : ['']
       
      }
    )
  }
  ngOnInit(): void {
  }
  toggle() {

    // if (this.parents.disabled) {
    //   this.parents.enable();
    //   return;
    // }
    // this.parents.reset();
    // this.parents.disable();
  }
}
