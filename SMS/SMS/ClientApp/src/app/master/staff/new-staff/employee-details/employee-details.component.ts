import { Component, OnInit, Output,EventEmitter } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup, FormArray } from '@angular/forms';
@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  @Output() formDetails=new EventEmitter();

  empDetailsForm : FormGroup;

  constructor(private fb: FormBuilder) {     
    
    this.empDetailsForm = this.fb.group(
      {
        teacherId : [''],
        employeeId : [''],
        educationId : [''],
        officialEmailId : [''],
        esiNumber : [''],
        staffId : [''],
        employeementstatusId : [''],
        reportingTo : [''],
        epfNumber : [''],
        departmentId : [''],
        joiningDate : [''],
        activeId : [''],
        uanNumber : [''],
        designationId : [''],
        roleId : ['']
      }
    );
    this.empDetailsForm.valueChanges.subscribe(()=>{
      
      this.formDetails.emit({value:this.empDetailsForm.value,valid:this.empDetailsForm.valid});
    
    });
  }

onSubmit(){

}
  ngOnInit(): void {
  }

}
