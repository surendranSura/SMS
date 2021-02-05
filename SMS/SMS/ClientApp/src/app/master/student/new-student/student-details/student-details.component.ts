import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {
  @Output() stuFormtDetails = new EventEmitter();
  studentProfileForm: FormGroup;
  addressValidFlag: boolean = false;
  formValues = { addresses: [] };//refer to student details parameters

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
