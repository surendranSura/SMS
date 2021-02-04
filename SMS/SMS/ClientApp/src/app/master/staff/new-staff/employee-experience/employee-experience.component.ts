import { Component, OnInit, Output,EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-employee-experience',
  templateUrl: './employee-experience.component.html',
  styleUrls: ['./employee-experience.component.css']
})
export class EmployeeExperienceComponent implements OnInit {

  experienceForm : FormGroup;
  @Output() formDetails=new EventEmitter();

  constructor(private fb : FormBuilder) { 
     this.experienceForm = this.fb.group(
       {
         from : [''],
         to: [''],
         responsiblity: ['']
       })
       this.experienceForm.valueChanges.subscribe(()=>{
      
        this.formDetails.emit({value:this.experienceForm.value,valid:this.experienceForm.valid});
      
      });
  }

  ngOnInit(): void {
  }
  
}
