import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-e-letter',
  templateUrl: './e-letter.component.html',
  styleUrls: ['./e-letter.component.css']
})
export class ELetterComponent implements OnInit {
  eletterfrm : FormGroup;
  letterTypes = SmsConstant.letterType;
  month = SmsConstant.months;
  years = SmsConstant.year;
  constructor( private fb:FormBuilder) {
      this.eletterfrm = this.fb.group({
        empid: [''],
        staffName:['hai'],
        letterType:[''],
        department:['cOMPUTER SCIENCE'],
        month:[''],
        teacherId:['706'],
        year:[''],
        attachment:['']
      });

   }

  ngOnInit(): void {
  }

}
