import { Component, OnInit} from '@angular/core';


@Component({
  selector: 'app-mainpage',
  templateUrl: './mainpage.component.html',
  styleUrls: ['./mainpage.component.css']
})
export class MainComponent implements OnInit {

  showFiller = false;
  shouldRun=false;

  ngOnInit(): void {
  }

  getMenuToggleValue(value:boolean){
    console.log(value);
  }
}
