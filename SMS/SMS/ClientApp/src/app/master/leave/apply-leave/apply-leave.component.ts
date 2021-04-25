import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup, FormArray } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';
@Component({
  selector: 'app-apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {

  @Output() formDetails=new EventEmitter();
 
  leaveform : FormGroup;
  leavetype=SmsConstant.leaveType;
  leaveSession=SmsConstant.leaveSession;


  constructor(private fb:FormBuilder) { 
    this.leaveform = this.fb.group({
      leave : [''],
      datefrom : [''],
      leavesec : [''],
      noofdays : [''],
      reason :['']
    });
    this.leaveform.valueChanges.subscribe(()=>{
      
      this.formDetails.emit({value:this.leaveform.value,valid:this.leaveform.valid});
    
    });
  }

  ngOnInit(): void {
  }
  // ngOnInit(): void {
  //   this.staffrestApiService.formValue$.subscribe((data : any) => {
  //     this.empDetailsForm.patchValue(data);
  //   });
  // }

}
