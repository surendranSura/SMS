import {  Component, OnInit, Output,EventEmitter, ViewChild, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router'
import { FormBuilder, FormControl,FormGroup } from '@angular/forms';
import { StaffrestApiService } from '../../staff/staffrest-api.service';
 import { Staff } from '../inventorydetails';
import { Subscription} from 'rxjs';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { BlockUI, NgBlockUI } from 'ng-block-ui';
import { SmsConstant } from 'src/app/shared/constant-values';
import { Console } from 'console';

@Component({
  selector: 'app-list-inventory',
  templateUrl: './list-inventory.component.html',
  styleUrls: ['./list-inventory.component.css']
})
export class ListInventoryComponent implements OnInit {

  itemstypes = SmsConstant.itemName;
  itemusageArea = SmsConstant.itemUsageArea;

  filters : boolean = false;
  rows : number = 0;
  @ViewChild(MatPaginator)
  paginator!: MatPaginator;
  @ViewChild(MatSort) sort !: MatSort;
 
  currentUserSubscription !: Subscription;
  currentStaff? : Staff;
  staffs: Staff[] = [];
  staffListData!: MatTableDataSource<any>;

  departmentIdFilter = new FormControl('');
  designationFilter = new FormControl('');
  statusvalueFilter = new FormControl('');
  joiningDateFrom = new FormControl('');
  

  columnsToDisplay = ['itemCode', 'itemName','serialNumber','brand','itemType','itemUsageArea','priperunit','quantity','vendor','attachment','actions'];
  
  filterValues = {
    //department: 
    departmentId :'',
   // designation: '',
    designationId: '',
    //status: '',
    employeementstatusId: '',
    //joiningDateFrom: '',
    joiningDate: ''
    //joiningDateTo: '',
  };

   @BlockUI() blockUI: NgBlockUI;
  stafffilters: FormGroup;
  
  constructor(private fb: FormBuilder,private router:Router, private staffApiService: StaffrestApiService) {
    this.stafffilters = this.fb.group({
      departmentIdFilter: [''],
      designationFilter: [''],
      statusvalueFilter: [''],
      joiningDateFrom: ['']
    });

    this.loadStaff();
    
  }

  // departmentchange(value)
  // {
    
  //   this.staffListData.filter.search(value);
  //     console.log(this.staffListData.filter.search(value));
  // }
  loadStaff()
  {
    this.blockUI.start();

    this.currentUserSubscription = this.staffApiService.getStaffs().subscribe((staff:any) => {
      this.currentStaff = staff;
      this.staffListData = new MatTableDataSource(staff);
       this.staffListData.paginator = this.paginator;
      this.staffListData.sort = this.sort;
      console.log(this.staffListData);
      this.staffListData.filterPredicate = this.createFilter();
       this.blockUI.stop();
      
      this.rows = this.staffListData.data.length;
    });

  }

  

  ngOnInit(): void {
    this.departmentIdFilter.valueChanges
    .subscribe(
      departmentId => {
        this.filterValues.departmentId = departmentId;
        this.staffListData.filter = JSON.stringify(this.filterValues);
        
      }
      
    )

    this.designationFilter.valueChanges
    .subscribe(
      designationId => {
        this.filterValues.designationId = designationId;
        this.staffListData.filter = JSON.stringify(this.filterValues);
      }
    )

    this.statusvalueFilter.valueChanges
    .subscribe(
      employeementstatusId => {
        this.filterValues.employeementstatusId = employeementstatusId;
        this.staffListData.filter = JSON.stringify(this.filterValues);
      }
    )
    
    this.joiningDateFrom.valueChanges
    .subscribe(
      joiningDate => {
        this.filterValues.joiningDate = joiningDate;
        this.staffListData.filter = JSON.stringify(this.filterValues);
      }
    )


    // this.staffListData = new MatTableDataSource(this.staffs);
    // this.staffListData.paginator = this.paginator;
    // this.staffListData.sort = this.sort;
    
  }

  filterToggle()
  {
    this.filters = !this.filters;
  }

  callNewStudent()
  {  
    this.router.navigate(['/add-inventory']);
  }
  
  removeStaff(staff : Staff)
  {
    this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
      this.loadStaff();
    });
  }

  editStaff(staff : Staff)
  {
    this.router.navigate(['/main/add-inventory',staff.mobile]);
    // this.staffApiService.deleteStaff(staff.mobile).subscribe(_=>{
    // });
  }

  createFilter(): (data: any, filter: string) => boolean {
    let filterFunction = function(data, filter): boolean {
      let searchTerms = JSON.parse(filter);
      return data.departmentId.toLowerCase().indexOf(searchTerms.departmentId) !== -1
        && data.designationId.toString().toLowerCase().indexOf(searchTerms.designationId) !== -1
        && data.employeementstatusId.toLowerCase().indexOf(searchTerms.employeementstatusId) !== -1
        && data.joiningDate.toLowerCase().indexOf(searchTerms.joiningDate) !== -1;
    }
    return filterFunction;
  }

}
