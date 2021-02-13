import { Component, OnInit,Output,EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { constants } from 'buffer';
import { SmsConstant } from 'src/app/shared/constant-values';

@Component({
  selector: 'app-banking-details',
  templateUrl: './banking-details.component.html',
  styleUrls: ['./banking-details.component.css']
})
export class BankingDetailsComponent implements OnInit {

  bankingFrom : FormGroup;
  @Output() formDetails=new EventEmitter();
 bank = SmsConstant.bank;
  constructor(private fb: FormBuilder) { 

    this.bankingFrom = this.fb.group({
      bankName : [''],
      bankAccountNumber : [''],
      panNumber : [''],
      branchNumber : [''],
      bankIfscCode : ['']
    });
    this.bankingFrom.valueChanges.subscribe(()=>{
      
      this.formDetails.emit({value:this.bankingFrom.value,valid:this.bankingFrom.valid});
    
    });
  }

  ngOnInit(): void {
  }

}
