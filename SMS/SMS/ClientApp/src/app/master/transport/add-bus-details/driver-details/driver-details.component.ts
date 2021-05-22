import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-driver-details',
  templateUrl: './driver-details.component.html',
  styleUrls: ['./driver-details.component.css']
})
export class DriverDetailsComponent implements OnInit {
  @Output() busFormOutput=new EventEmitter<any>(); 
  @Input() getFormValues = {};
  busDriverDetailForm: FormGroup;
  constructor(private fb:FormBuilder) {
    this.busDriverDetailForm = this.fb.group({
      driverName : ['']
      ,driverNumber : ['']
      ,driverAadharNumber : ['']
    });
   }

  ngOnInit(): void {
  }

}
