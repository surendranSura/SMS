import { Component, OnInit } from '@angular/core';
interface Blood {
  value: string;
  viewValue: string;
}
@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.css']
})

export class PersonalDetailsComponent implements OnInit {

  constructor() { 
    
  }

  bloods: Blood[] = [
    {value: 'AP-0', viewValue: 'A+'},
    {value: 'BP-1', viewValue: 'B+'},
    {value: 'ABP-2', viewValue: 'AB+'},
    {value: 'OP-3', viewValue: 'OP+'}
  ];  

  ngOnInit(): void {
    
  }

}
