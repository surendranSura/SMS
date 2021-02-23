import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-classes',
  templateUrl: './classes.component.html',
  styleUrls: ['./classes.component.css']
})
export class ClassesComponent implements OnInit {
  @Input() title: string = "";
  @Input() route_Link: string = "/main/lesson-plan/subjectDetails";
  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  navigate() {  
   
      this.router.navigate([this.route_Link]);
  }

}
