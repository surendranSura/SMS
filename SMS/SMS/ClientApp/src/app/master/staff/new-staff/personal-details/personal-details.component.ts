import { Component, OnInit, Output, EventEmitter, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { FormControl, FormGroup, FormArray } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';




@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})

export class PersonalDetailsComponent implements OnInit, OnChanges {

  @Output() formDetails = new EventEmitter();
  @Input() getFormValues = {};
  profileForm: FormGroup;
  addressValidFlag: boolean = false;
  formValues = { addresses: [''] };
  blood = SmsConstant.bloods;
  salutations =SmsConstant.salutations;
  maritalstatus =SmsConstant.maritalStatus;
  religion =SmsConstant.religion;
  gender = SmsConstant.gender;
  nationality = SmsConstant.nationality;
  motherTon = SmsConstant.motherTongue;
  languageknown = SmsConstant.languageKnown;
  getselectdata :string;





  // get aliases() {
  //   return this.profileForm.get('aliases') as FormArray;
  // }

  constructor(private fb: FormBuilder) {

    this.profileForm = this.fb.group(
      {
        salutationId: ['',Validators.required],
        dob: ['',Validators.required],
        religionId: ['',Validators.required],
        motherTonge: ['',Validators.required],
        firstName: ['', Validators.required],
        bloodGroup: ['',Validators.required],
        gender: ['',Validators.required],
        emailId: ['',Validators.required],
        languages: ['',Validators.required],
        middleName: [''],
        maritalStatus: ['',Validators.required],
        nationality: [''],
        lastName: ['',Validators.required],
        weedingDate: [''],
        mobileNumber: ['',Validators.required],
        aadharNumber: ['',Validators.required],
        fatherName: ['',Validators.required],
        motherName: ['',Validators.required],
        spouseName: [''],
        fatherOccupation: ['',Validators.required],
        motherOccupation: ['',Validators.required],
        souseOccupation: [''],
        fatherMobileNumber: ['',Validators.required],
        motherMobileNumber: ['',Validators.required],
        spouseMobileNumber: [''],
        
      }
    );

    this.profileForm.valueChanges.subscribe(() => {
      Object.assign(this.formValues, this.profileForm.value);
      this.formValues["mobileNumber"]=Number.parseInt(this.formValues["mobileNumber"]);
      this.formDetails.emit({ value: this.formValues, valid: (this.profileForm.valid && this.addressValidFlag) });

    });
  }
  ngOnChanges(changes: SimpleChanges): void {
  
    if (changes.getFormValues.currentValue)
    {
      console.log(changes.getFormValues.currentValue);
      this.profileForm.patchValue(this.getFormValues);
    }
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

  getAddress(arrValue: any) {
    let value = Array.from(arrValue, (obj: any) => obj.value) as never[];
    this.formValues.addresses = value;
    this.addressValidFlag = !((Array.from(arrValue, (obj: any) => obj.valid)).includes(false));
    this.formDetails.emit({ value: this.formValues, valid: (this.profileForm.valid && this.addressValidFlag) });//
  }

}
