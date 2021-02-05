import { Component, EventEmitter, Input, OnInit, Output, SimpleChange } from '@angular/core';
import { FormGroup, FormBuilder, Validator, FormControl } from '@angular/forms';

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
    });

    this.parents.valueChanges.subscribe(() => {
      this.formValue.emit({
        value: this.parents.value, valid: this.parents.valid
      })});
    }
    
  ngOnInit(): void {
  }

}
