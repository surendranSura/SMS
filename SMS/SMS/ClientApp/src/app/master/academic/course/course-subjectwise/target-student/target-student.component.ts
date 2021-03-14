import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-target-student',
  templateUrl: './target-student.component.html',
  styleUrls: ['./target-student.component.css']
})

export class TargetStudentComponent implements OnInit {
  @Output() emitcourseformDetails = new EventEmitter();
  
  targetstudentForm : FormGroup;
 classes=SmsConstant.classes;
 sections=SmsConstant.section;
 allstatus=SmsConstant.section
  constructor(private fb:FormBuilder) {
    this.targetstudentForm=this.fb.group({
      class:[''],
      section:[''],
      status:['']
    });
    this.targetstudentForm.valueChanges.subscribe(()=>{
      this.emitcourseformDetails.emit({value:this.targetstudentForm.value,valid:this.targetstudentForm.valid});
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
