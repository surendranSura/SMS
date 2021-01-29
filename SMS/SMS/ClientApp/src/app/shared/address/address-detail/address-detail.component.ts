import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-address-detail',
  templateUrl: './address-detail.component.html',
  styleUrls: ['./address-detail.component.css']
})
export class AddressDetailComponent implements OnInit {
@Input('title') addressLabel='';
  constructor() { }


  ngOnInit(): void {
  }

}
