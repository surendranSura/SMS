import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-preview-publish',
  templateUrl: './preview-publish.component.html',
  styleUrls: ['./preview-publish.component.css']
})
export class PreviewPublishComponent implements OnInit {
  @Output() emitcourseformDetails = new EventEmitter();
cDate:any;
  prePublishForm:FormGroup;
  constructor(private fb:FormBuilder) {
    this.prePublishForm = this.fb.group({
      courseName:[''],
      courseCode:[''],
      courseDesc:[''],
      courseTopic:['']


    });
    this.prePublishForm.valueChanges.subscribe(()=>{
      this.emitcourseformDetails.emit({value:this.prePublishForm.value,valid:this.prePublishForm.valid})
    })
   }

  ngOnInit(): void {
  }

}
