import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';


@Component({
  selector: 'app-add-bus',
  templateUrl: './add-bus.component.html',
  styleUrls: ['./add-bus.component.css']
})
export class AddBusComponent implements OnInit {
 @Output() busFormOutput=new EventEmitter<any>(); 
 @Input() getFormValues = {};
 busDetailForm: FormGroup;
 bustype = SmsConstant.busTypes;
 sendNotification = SmsConstant.notification;
  constructor(private fb:FormBuilder) {
    this.busDetailForm = this.fb.group({
      bus : ['']
      ,company : ['']
      ,seats : ['']
      ,busNumber : ['']
      ,insPolicyNum : ['']
      ,insurenceDate : ['']
      ,notification : ['']
    })
   }
  
  ngOnInit(): void {
  }

}
