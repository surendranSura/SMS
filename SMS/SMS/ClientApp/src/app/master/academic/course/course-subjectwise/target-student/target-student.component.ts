import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-target-student',
  templateUrl: './target-student.component.html',
  styleUrls: ['./target-student.component.css']
})

export class TargetStudentComponent implements OnInit {

  targetstudentForm : FormGroup;
 classes=SmsConstant.classes;
 sections=SmsConstant.section;
 allstatus=SmsConstant.section
  constructor(private fb:FormBuilder) {
    this.targetstudentForm=this.fb.group({
      class:[''],
      section:[''],
      status:['']
    })
   }

  ngOnInit(): void {
  }
  checkBoxAction(matValue:any){
    // this.pFlagEmit.emit(matValue.checked);
    // if (matValue.checked) {
    //   this.form.disable();
    // }
    // else {
    //   this.form.enable();
    // }
  }
}
