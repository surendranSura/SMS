import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-inventory-detail',
  templateUrl: './inventory-detail.component.html',
  styleUrls: ['./inventory-detail.component.css']
})
export class InventoryDetailComponent implements OnInit {

  @Output() busFormOutput=new EventEmitter<any>(); 
 @Input() getFormValues = {};
 inventoryDetailForm: FormGroup;  
 itemtype = SmsConstant.itemName;
 itemusageAreaType = SmsConstant.itemUsageArea;

  constructor(private fb:FormBuilder) {

    this.inventoryDetailForm = this.fb.group({
      bus : ['']
      ,itemName : ['']
      ,modelNumber : ['']
      ,serialNumber : ['']
      ,detailOfWG : ['']
      ,ItemUsage : ['']
      ,warGarenty: [true]
      ,brandName : ['']
      ,quantity : ['']
    })
   }
  
  ngOnInit(): void {
  }

}

