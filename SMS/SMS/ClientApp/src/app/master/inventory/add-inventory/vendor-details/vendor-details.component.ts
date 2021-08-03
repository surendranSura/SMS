import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-vendor-details',
  templateUrl: './vendor-details.component.html',
  styleUrls: ['./vendor-details.component.css']
})
export class VendorDetailsComponent implements OnInit {
  @Output() busFormOutput=new EventEmitter<any>(); 
  @Input() getFormValues = {};
  vendorDetailForm: FormGroup;
  constructor(private fb:FormBuilder) {
    this.vendorDetailForm = this.fb.group({
      VendorName : ['']
      ,itemPriceorPerUnit : ['']
      ,vendorAddress : ['']
      ,vendorName : ['']
    });
   }

  ngOnInit(): void {
  }
}
