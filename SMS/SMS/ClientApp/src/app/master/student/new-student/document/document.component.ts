import { Component, OnInit } from '@angular/core';
import {FormControl} from '@angular/forms';

@Component({
  selector: 'app-document',
  templateUrl: './document.component.html',
  styleUrls: ['./document.component.css']
})
export class DocumentComponent implements OnInit {
  selectedFileList!: FileList;
  
  constructor() { 
    this.selectedFileList = (<HTMLInputElement>document.getElementById('tCertificate')).files; 
  }

  ngOnInit(): void {
  }
  // backTab(index:number)
  // {
    
  // }

}
