import { Component, OnInit, Output,EventEmitter } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup, FormArray } from '@angular/forms';


interface Blood {
  value: string;
  viewValue: string;
}
@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})

export class PersonalDetailsComponent implements OnInit {

  @Output() formDetails=new EventEmitter();
  profileForm : FormGroup;
  


  // get aliases() {
  //   return this.profileForm.get('aliases') as FormArray;
  // }

  constructor(private fb: FormBuilder) {

    this.profileForm = this.fb.group(
      {
      Salutation: [''],
      Dob: [''],
      Religion: [''],
      MotherTonge: [''],
      FirstName: ['',Validators.required],
      BloodGroup: [''],
      Gender: [''],
      LanguagesKnown: [''],
      MiddleName: [''],
      MaritalStatus: [''],
      Nationality: [''],
      PersonalEmail: [''],
      LastName: [''],
      WeedingDate: [''],
      MobileNumber: [''],
      AadharNumber: [''],
      FatherName: [''],
      MotherName: [''],
      SpouseName: [''],
      FatherOccupation: [''],
      MotherOccupation: [''],
      SouseOccupation: [''],
      FatherMobileNumber: [''],
      MotherMobileNumber: [''],
      SpouseMobileNumber: ['']
    }
    );
    this.profileForm.valueChanges.subscribe(()=>{
      
      this.formDetails.emit({value:this.profileForm.value,valid:this.profileForm.valid});
    
    });
  }

  // updateProfile() {
  //   this.profileForm.patchValue({
  //     FirstName: 'Nancy',
  //     MiddleName: 'Suprise'
  //   });
  // }

  // addAlias() {
  //   this.aliases.push(this.fb.control(''));
  // }

  onSubmit() {
    // TODO: Use EventEmitter with form value
    console.warn(this.profileForm.value);
  }

  ngOnInit(): void {
  }

}
