import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-vendor-details',
  templateUrl: './vendor-details.component.html',
  styleUrls: ['./vendor-details.component.css']
})
export class VendorDetailsComponent implements OnInit {
  @Output() inventoryFormDetails=new EventEmitter<any>(); 
  // @Input() getFormValues = {};
  vendorDetailForm: FormGroup;
  constructor(private fb:FormBuilder) {
    this.vendorDetailForm = this.fb.group({
      VendorName : ['', Validators.required]
      ,itemPriceorPerUnit : ['', Validators.required]
      ,vendorAddress : ['', Validators.required]
      ,vendorName : ['', Validators.required]
    });
    this.vendorDetailForm.valueChanges.subscribe(()=>{      
      this.inventoryFormDetails.emit({value:this.vendorDetailForm.value,valid:this.vendorDetailForm.valid});    
    });
   }
   formTouched(): boolean {
    this.vendorDetailForm.markAllAsTouched();
    return this.vendorDetailForm.valid;
  }

  ngOnInit(): void {
  }
}
