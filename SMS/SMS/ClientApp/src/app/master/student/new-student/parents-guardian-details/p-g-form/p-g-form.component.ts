import { Component, EventEmitter, Input, OnInit, Output, SimpleChange } from '@angular/core';
import { FormGroup, FormBuilder, Validator, FormControl } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-p-g-form',
  templateUrl: './p-g-form.component.html',
  styleUrls: ['./p-g-form.component.css']
})
export class PGFormComponent implements OnInit {

  @Input() titleLabel: string = '';
  @Input() pFlag = false;
  @Input() formInput = {};
  @Output() formValue = new EventEmitter<any>();
  @Output() pflagEmit = new EventEmitter<boolean>();
  parents: FormGroup;
  salutations=SmsConstant.salutations;
  constructor(private fb: FormBuilder) {
    this.parents = fb.group({
      salutation: ['']
      , firstName: ['']
      , middleName: ['']
      , lastName: ['']
      , mobileNumber: ['']
      , occupation: ['']
      , email: ['']
      , aadharNumber: ['']
      , company: ['']
      , designation: ['']
      , annualIncome: ['']
      , bvEmployee: ['']
    });

    this.parents.valueChanges.subscribe(() => {
      this.formValue.emit({
        value: this.parents.value, valid: this.parents.valid
      })
    });
  }

  ngOnInit(): void {
  }

  toggle() {

    if (this.parents.disabled) {
      this.parents.enable();
      return;
    }
    this.parents.reset();
    this.parents.disable();
  }

}
