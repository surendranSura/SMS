import { Component, OnInit,Output,EventEmitter, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { constants } from 'buffer';
import { Observable, Observer } from 'rxjs';
import { SmsConstant } from 'src/app/shared/constant-values';
import { StaffrestApiService } from '../../staffrest-api.service';

@Component({
  selector: 'app-banking-details',
  templateUrl: './banking-details.component.html',
  styleUrls: ['./banking-details.component.css']
})
export class BankingDetailsComponent implements OnInit, OnDestroy {

  bankingFrom : FormGroup;
  @Output() formDetails=new EventEmitter();
  bank = SmsConstant.bank;
  destroy!: any;
  constructor(private fb: FormBuilder, private staffrestApiService : StaffrestApiService ) { 

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

  ngOnDestroy(): void {

    this.destroy.unsubscribe();
    
  }

  ngOnInit(): void {
     this.destroy = this.staffrestApiService.formValue$.subscribe((data : any) => {
       this.bankingFrom.patchValue(data);
     });
  }

}
