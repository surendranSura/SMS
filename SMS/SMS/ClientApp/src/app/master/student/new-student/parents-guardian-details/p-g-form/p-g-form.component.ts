import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-p-g-form',
  templateUrl: './p-g-form.component.html',
  styleUrls: ['./p-g-form.component.css']
})
export class PGFormComponent implements OnInit {

  @Input() titleLabel:string ='';
  constructor() { }

  ngOnInit(): void {
  }

}
