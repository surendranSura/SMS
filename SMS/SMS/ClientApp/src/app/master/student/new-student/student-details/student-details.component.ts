import { Component, OnInit, Output, EventEmitter, Input, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {
  @Output() stuFormtDetails = new EventEmitter();
  @Input() getFormValues = {};
  studentProfileForm: FormGroup;
  formValues = { addresses: [] };//refer to student details parameters
  addressValidFlag: boolean = false;
  blood = SmsConstant.bloods;
  salutations =SmsConstant.salutations;
  maritalstatus =SmsConstant.maritalStatus;
  religion =SmsConstant.religion;
  gender = SmsConstant.gender;
  nationality = SmsConstant.nationality;
  motherTon = SmsConstant.motherTongue;
  languageknown = SmsConstant.languageKnown;
  class = SmsConstant.classes
  firstLang =SmsConstant.firstLanguage;
  secndLanguage =SmsConstant.secondLanguage;
  section =SmsConstant.section;
  sclBrand =SmsConstant.schoolBrand;
  pasOutScl =SmsConstant.passingOutSchool;
  yearOfAttends =SmsConstant.yearOfAttendence;
  addressData = null;

  constructor(private fb: FormBuilder) {
    this.studentProfileForm = this.fb.group({
        salutation: ['']
      , firstName: ['']
      , middleName: ['']
      , lastName: ['']
      , dob: ['']
      , bloodGroup: ['']
      , nationalityId: ['']
      , religionId: ['']
      , gender: ['']
      , emailId: ['']
      , aadharNumber: ['']
      , mobile: ['']
      , admissionNumber: ['']
      , amissionDate: ['']
      , class: ['']
      , section: ['']
      , rollNo: ['']
      , firstLanguage: ['']
      , secondLanguage: ['']
      , emisNumber: ['']
      , schoolName: ['']
      , schoolBrand: ['']
      , passingOutSchool: ['']
      , yearofattendence: ['']
      , academicPrecentage: ['']
      , reasonForLeaving: ['']
      , designation : ['']
    });

    this.studentProfileForm.valueChanges.subscribe(() => {
      Object.assign(this.formValues, this.studentProfileForm.value);
      this.stuFormtDetails.emit({ value: this.formValues, valid: (this.studentProfileForm.valid && this.addressValidFlag) });

    })
    
  }
  ngOnChanges(changes: SimpleChanges): void {
  
    if (changes.getFormValues.currentValue)
    {
      console.log("current value is"+changes.getFormValues.currentValue);
      this.addressData=this.getFormValues["addresses"];
      this.studentProfileForm.patchValue(this.getFormValues);
    }
  }
  onSubmit() {
    console.warn(this.studentProfileForm.value);
  }

  ngOnInit(): void {
  }
  getAddress(arrValue: any) {
    let value = Array.from(arrValue, (obj: any) => obj.value) as never[];
    this.formValues.addresses = value;
    this.addressValidFlag = !((Array.from(arrValue, (obj: any) => obj.valid)).includes(false));
    this.stuFormtDetails.emit({ value: this.formValues, valid: (this.studentProfileForm.valid && this.addressValidFlag) });
  }


}
