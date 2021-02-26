import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-course-details',
  templateUrl: './course-details.component.html',
  styleUrls: ['./course-details.component.css']
})
export class CourseDetailsComponent implements OnInit {
  courseDetailsForm : FormGroup;

  constructor(private fb:FormBuilder) {

    this.courseDetailsForm= this.fb.group(
      {
        courseName : [''],
        courseCode : [''],
        courseDescription : [''],
        CompletionCriteria : [''],
        PassingScore : ['']
       
      }
    )
  }
  ngOnInit(): void {
  }

}
