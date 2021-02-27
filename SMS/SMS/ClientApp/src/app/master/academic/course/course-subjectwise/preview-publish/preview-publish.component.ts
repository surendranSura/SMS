import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-preview-publish',
  templateUrl: './preview-publish.component.html',
  styleUrls: ['./preview-publish.component.css']
})
export class PreviewPublishComponent implements OnInit {
cDate:any;
  prePublishForm:FormGroup;
  constructor(private fb:FormBuilder) {
    this.prePublishForm = this.fb.group({
      courseName:[''],
      courseCode:[''],
      courseDesc:[''],
      courseTopic:['']


    })
   }

  ngOnInit(): void {
  }

}
