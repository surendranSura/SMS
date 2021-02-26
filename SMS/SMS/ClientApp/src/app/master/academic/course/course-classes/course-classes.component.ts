import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-course-classes',
  templateUrl: './course-classes.component.html',
  styleUrls: ['./course-classes.component.css']
})
export class CourseClassesComponent implements OnInit {
  standard:any=
  [{
    class:"1"},{class:"2"},{class:"3"},{class:"4"},{class:"5"},{class:"6"},{class:"7"},{class:"8"},{class:"9"},{class:"10"}];

     constructor() { }

  ngOnInit(): void {
  }

}
